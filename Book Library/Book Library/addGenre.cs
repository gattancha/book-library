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
    public partial class addGenre : Form
    {
        public addGenre()
        {
            InitializeComponent();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string genre = txtNewGenre.Text;

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
                string commandText = "InsertGenre";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Genre '" + genre + "' added successfully");
            }
            catch
            {
                MessageBox.Show("Error adding '" + genre + "'");
            }


        }
    }
}
