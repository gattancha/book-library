using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Book_Library
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDS.Series' table. You can move, or remove it, as needed.
            this.seriesTableAdapter.Fill(this.booksDS.Series);
            // TODO: This line of code loads data into the 'booksDS.formats' table. You can move, or remove it, as needed.
            this.formatsTableAdapter.Fill(this.booksDS.formats);
            // TODO: This line of code loads data into the 'booksDS.genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.booksDS.genre);
            // TODO: This line of code loads data into the 'booksDS.authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.booksDS.authors);
            // TODO: This line of code loads data into the 'booksDS.info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.booksDS.info);

        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            string title = txtBoxAddTitle.Text;
            string isbn = txtAddISBN.Text;
            string desc = richTextBox1.Text;
            int author = Convert.ToInt32(cmbAddAuthor.SelectedValue);
            int genre = Convert.ToInt32(cmbAddGenre.SelectedValue);
            int format = Convert.ToInt32(cmbAddFormat.SelectedValue);
            int series = Convert.ToInt32(cmbAddSeries.SelectedValue);

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
                string commandText = "insertQuery";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@isbn", isbn);
                cmd.Parameters.AddWithValue("@series", series);
                cmd.Parameters.AddWithValue("@description", desc);
                cmd.Parameters.AddWithValue("@format", format);

                cmd.ExecuteNonQuery();
                conn.Close();
                
                MessageBox.Show("Book '" + title + "' added successfully","Record Addded",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error adding '" + title+"'","Error Adding Record",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthor = new AddAuthor();
            addAuthor.ShowDialog();
            this.authorsTableAdapter.Fill(this.booksDS.authors);
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            addGenre addgenre = new addGenre();
            addgenre.ShowDialog();
            this.genreTableAdapter.Fill(this.booksDS.genre);
        }

        private void btnAddFormat_Click(object sender, EventArgs e)
        {
            AddFormats addFormat = new AddFormats();
            addFormat.ShowDialog();
            this.formatsTableAdapter.Fill(this.booksDS.formats);
        }

        private void button1_Click(object sender, EventArgs e)
        {
             AddSeries addSeries = new AddSeries();
            addSeries.ShowDialog();
            this.seriesTableAdapter.Fill(this.booksDS.Series);

        }
    }
}
