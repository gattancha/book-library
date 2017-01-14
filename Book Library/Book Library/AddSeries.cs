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
    public partial class AddSeries : Form
    {
        public AddSeries()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string series = txtNewSeries.Text;

            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["BooksCS"].ConnectionString;
                string commandText = "InsertSeries";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(commandText, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();

                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@series", series);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Series '" + series + "' added successfully");
            }
            catch
            {
                MessageBox.Show("Error adding '" + series + "'");
            }


        }
    }
}
