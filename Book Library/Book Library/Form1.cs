#region Using statements
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
#endregion

namespace Book_Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0; // Set "Next Record" counter to zero
        int isSearch = 0; // By default we wont be searching - so set this to zero

        /// <summary>
        /// Declare local string variables for search results so we can use them across this form
        /// These will be bound when we search
        /// </summary>
        public string searchISBN = ""; 
        public string searchTitle = "";
        public string searchAuthor = "";
        public string searchSeries = "";


        private void Form1_Load(object sender, EventArgs e)
        {
            allBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Before we search, we should make sure we clear any previous search results..
            searchISBN = "";
            searchSeries = "";
            searchTitle = "";
            searchAuthor = "";

            // Now we can search....
            searchBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdd addBook = new frmAdd();
            addBook.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            allBooks();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nextRecord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prevRecord();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstRecord();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lastRecord();
        }


        private void button9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("View All Records", button9);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                nextRecord();
            }
            else if (e.KeyCode == Keys.Left)
            {
                prevRecord();
            }
        }

        #region Custom Methods
        /// <summary>
        ///  Custom Methods go here
        /// </summary>
        private void formReset()
        {
            allBooks();
        }

        private void allBooks()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
            string commandText = "searchQuery";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(commandText, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.Parameters.AddWithValue("@isbn", "%" );
            cmd.Parameters.AddWithValue("@author", "%");
            cmd.Parameters.AddWithValue("@series", "%");
            cmd.Parameters.AddWithValue("@title", "%");
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            label1.Text = sdr["Title"].ToString();
            lblAuthor.Text = sdr["Author_Name"].ToString();
            this.Text = sdr["Title"].ToString()+" ("+ sdr["Author_Name"].ToString()+")";
            
            try
            {
                pictureBox1.ImageLocation = "https://pictures.abebooks.com/isbn/" + sdr["isbn"] + "-uk.jpg";
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.nocover;
            }

            lblISBN.Text = sdr["isbn"].ToString();
            label3.Text = sdr["Description"].ToString();
            sdr.Close();
            conn.Close();
        }
        public void searchBooks()
        {
            using (frmSearch search = new frmSearch())
            {
                if (search.ShowDialog() == DialogResult.OK)
                {
                    try  //try and run our seaarch
                    {
                        string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
                        string commandText = "searchQuery";
                        SqlConnection conn = new SqlConnection(connStr);
                        SqlCommand cmd = new SqlCommand(commandText, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        cmd.Parameters.AddWithValue("@isbn", "%" + search.searchISBN + "%");
                        cmd.Parameters.AddWithValue("@author", "%" + search.searchAuthor + "%");
                        cmd.Parameters.AddWithValue("@series", "%" + search.searchSeries + "%");
                        cmd.Parameters.AddWithValue("@title", "%" + search.searchTitle + "%");
                        searchTitle = search.searchTitle;
                        searchISBN = search.searchISBN;
                        searchSeries = search.searchSeries;
                        searchAuthor = search.searchAuthor;
                        SqlDataReader sdr = cmd.ExecuteReader();
                        sdr.Read();
                        label1.Text = sdr["Title"].ToString();
                        lblAuthor.Text = sdr["Author_Name"].ToString();
                        this.Text = sdr["Title"].ToString() + " (" + sdr["Author_Name"].ToString() + ")";
                        try
                        {
                            pictureBox1.ImageLocation = "https://pictures.abebooks.com/isbn/" + sdr["isbn"] + "-uk.jpg";
                        }
                        catch
                        {
                            pictureBox1.Image = Properties.Resources.nocover;
                        }
                        lblISBN.Text = sdr["isbn"].ToString();
                        label3.Text = sdr["Description"].ToString();
                        sdr.Close();
                        conn.Close();
                    }
                    catch (InvalidOperationException inopex)
                    {
                       if (inopex.Message.ToLower().Contains("no data is present"))
                       {
                            MessageBox.Show("No results found.\nPlease check your criteria and try again","No Results Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An unknown Error was encountered: \\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            isSearch = 1;
        }


        private void nextRecord()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
            string commandText = "searchQuery";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(commandText, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            if (isSearch == 0)
            {
                cmd.Parameters.AddWithValue("@isbn", "%");
                cmd.Parameters.AddWithValue("@author", "%");
                cmd.Parameters.AddWithValue("@series", "%");
                cmd.Parameters.AddWithValue("@title", "%");
            }
            else if (isSearch == 1)
            {
                cmd.Parameters.AddWithValue("@isbn", "%" + searchISBN + "%");
                cmd.Parameters.AddWithValue("@author", "%" + searchAuthor + "%");
                cmd.Parameters.AddWithValue("@series", "%" + searchSeries + "%");
                cmd.Parameters.AddWithValue("@title", "%" + searchTitle + "%");
            }
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (i < dt.Rows.Count - 1)
            {
                i++;
                label1.Text = dt.Rows[i]["Title"].ToString();
                lblAuthor.Text = dt.Rows[i]["Author_Name"].ToString();
                this.Text = dt.Rows[i]["Title"].ToString() + " (" + dt.Rows[i]["Author_Name"].ToString() + ")";
                try
                {
                    pictureBox1.ImageLocation = "https://pictures.abebooks.com/isbn/" + dt.Rows[i]["isbn"] + "-uk.jpg";
                }
                catch
                {
                    pictureBox1.Image = Properties.Resources.nocover;
                }
                lblISBN.Text = dt.Rows[i]["ISBN"].ToString();
                label3.Text = dt.Rows[i]["Description"].ToString();
            }
            conn.Close();
        }


        private void prevRecord()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
            string commandText = "searchQuery";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(commandText, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            if (isSearch == 0)
            {
                cmd.Parameters.AddWithValue("@isbn", "%");
                cmd.Parameters.AddWithValue("@author", "%");
                cmd.Parameters.AddWithValue("@series", "%");
                cmd.Parameters.AddWithValue("@title", "%");
            }
            else if (isSearch == 1)
            {
                cmd.Parameters.AddWithValue("@isbn", "%" + searchISBN + "%");
                cmd.Parameters.AddWithValue("@author", "%" + searchAuthor + "%");
                cmd.Parameters.AddWithValue("@series", "%" + searchSeries + "%");
                cmd.Parameters.AddWithValue("@title", "%" + searchTitle + "%");

            }
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (i == dt.Rows.Count - 1 || i != 0)
            {
                i--;
                label1.Text = dt.Rows[i]["Title"].ToString();
                lblAuthor.Text = dt.Rows[i]["Author_Name"].ToString();
                this.Text = dt.Rows[i]["Title"].ToString() + " (" + dt.Rows[i]["Author_Name"].ToString() + ")";
                try
                {
                    pictureBox1.ImageLocation = "https://pictures.abebooks.com/isbn/" + dt.Rows[i]["isbn"] + "-uk.jpg";
                }
                catch
                {
                    pictureBox1.Image = Properties.Resources.nocover;
                }
                    lblISBN.Text = dt.Rows[i]["ISBN"].ToString();
                label3.Text = dt.Rows[i]["Description"].ToString();

            }
            conn.Close();
        }

        private void firstRecord()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
            string commandText = "searchQuery";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(commandText, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            if (isSearch == 0)
            {
                cmd.Parameters.AddWithValue("@isbn", "%");
                cmd.Parameters.AddWithValue("@author", "%");
                cmd.Parameters.AddWithValue("@series", "%");
                cmd.Parameters.AddWithValue("@title", "%");
            }
            else if (isSearch == 1)
            {
                cmd.Parameters.AddWithValue("@isbn", "%" + searchISBN + "%");
                cmd.Parameters.AddWithValue("@author", "%" + searchAuthor + "%");
                cmd.Parameters.AddWithValue("@series", "%" + searchSeries + "%");
                cmd.Parameters.AddWithValue("@title", "%" + searchTitle + "%");

            }
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                i = 0;
                label1.Text = dt.Rows[i]["Title"].ToString();
                lblAuthor.Text = dt.Rows[i]["Author_Name"].ToString();
                this.Text = dt.Rows[i]["Title"].ToString() + " (" + dt.Rows[i]["Author_Name"].ToString() + ")";
                try
                {
                    pictureBox1.ImageLocation = "https://pictures.abebooks.com/isbn/" + dt.Rows[i]["isbn"] + "-uk.jpg";
                }
                catch
                {
                    pictureBox1.Image = Properties.Resources.nocover;
                }
                lblISBN.Text = dt.Rows[i]["ISBN"].ToString();
                label3.Text = dt.Rows[i]["Description"].ToString();

            }
            conn.Close();
        }

        private void lastRecord()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
            string commandText = "searchQuery";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(commandText, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            if (isSearch == 0)
            {
                cmd.Parameters.AddWithValue("@isbn", "%");
                cmd.Parameters.AddWithValue("@author", "%");
                cmd.Parameters.AddWithValue("@series", "%");
                cmd.Parameters.AddWithValue("@title", "%");
            }
            else if (isSearch == 1)
            {
                cmd.Parameters.AddWithValue("@isbn", "%" + searchISBN + "%");
                cmd.Parameters.AddWithValue("@author", "%" + searchAuthor + "%");
                cmd.Parameters.AddWithValue("@series", "%" + searchSeries + "%");
                cmd.Parameters.AddWithValue("@title", "%" + searchTitle + "%");

            }
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            i = dt.Rows.Count - 1;
            label1.Text = dt.Rows[i]["Title"].ToString();
            lblAuthor.Text = dt.Rows[i]["Author_Name"].ToString();
            this.Text = dt.Rows[i]["Title"].ToString() + " (" + dt.Rows[i]["Author_Name"].ToString() + ")";
            try
            {
                pictureBox1.ImageLocation = "https://pictures.abebooks.com/isbn/" + dt.Rows[i]["isbn"] + "-uk.jpg";
            }
            catch
            {
                pictureBox1.Image = Properties.Resources.nocover;
            }
            lblISBN.Text = dt.Rows[i]["ISBN"].ToString();
            label3.Text = dt.Rows[i]["Description"].ToString();
            conn.Close();
        }
        #endregion

    }
}