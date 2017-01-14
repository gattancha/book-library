using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library
{
    public partial class frmSearch : Form
    {
        public string searchTitle { get; set; }
        public string searchISBN { get; set; }
        public string searchAuthor { get; set; }
        public string searchSeries { get; set; }



        public frmSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTitle = txtfindTitle.Text;
            searchISBN = txtFindISBN.Text;
            searchAuthor = txtFindAuthor.Text;
            searchSeries = txtFindSeries.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
