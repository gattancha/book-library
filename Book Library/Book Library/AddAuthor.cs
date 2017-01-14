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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = txtNewAuthor.Text;

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
                string commandText = "InsertAuthor";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@author_name", author);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Author '" + author + "' added successfully");              
            }
            catch
            {
                MessageBox.Show("Error adding '" + author + "'");
            }

        }
    }
}
