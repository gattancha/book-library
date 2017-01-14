namespace Book_Library
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.lblAddSeries = new System.Windows.Forms.Label();
            this.txtFindISBN = new System.Windows.Forms.TextBox();
            this.txtfindTitle = new System.Windows.Forms.TextBox();
            this.lblAddISBN = new System.Windows.Forms.Label();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFindSeries = new System.Windows.Forms.TextBox();
            this.txtFindAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddSeries
            // 
            this.lblAddSeries.AutoSize = true;
            this.lblAddSeries.Location = new System.Drawing.Point(274, 86);
            this.lblAddSeries.Name = "lblAddSeries";
            this.lblAddSeries.Size = new System.Drawing.Size(36, 13);
            this.lblAddSeries.TabIndex = 0;
            this.lblAddSeries.Text = "Series";
            // 
            // txtFindISBN
            // 
            this.txtFindISBN.Location = new System.Drawing.Point(68, 83);
            this.txtFindISBN.Name = "txtFindISBN";
            this.txtFindISBN.Size = new System.Drawing.Size(121, 20);
            this.txtFindISBN.TabIndex = 3;
            // 
            // txtfindTitle
            // 
            this.txtfindTitle.Location = new System.Drawing.Point(68, 52);
            this.txtfindTitle.Name = "txtfindTitle";
            this.txtfindTitle.Size = new System.Drawing.Size(121, 20);
            this.txtfindTitle.TabIndex = 1;
            // 
            // lblAddISBN
            // 
            this.lblAddISBN.AutoSize = true;
            this.lblAddISBN.Location = new System.Drawing.Point(21, 86);
            this.lblAddISBN.Name = "lblAddISBN";
            this.lblAddISBN.Size = new System.Drawing.Size(32, 13);
            this.lblAddISBN.TabIndex = 0;
            this.lblAddISBN.Text = "ISBN";
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(272, 52);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAddAuthor.TabIndex = 0;
            this.lblAddAuthor.Text = "Author";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(21, 55);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(27, 13);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFindSeries
            // 
            this.txtFindSeries.Location = new System.Drawing.Point(316, 86);
            this.txtFindSeries.Name = "txtFindSeries";
            this.txtFindSeries.Size = new System.Drawing.Size(121, 20);
            this.txtFindSeries.TabIndex = 4;
            // 
            // txtFindAuthor
            // 
            this.txtFindAuthor.Location = new System.Drawing.Point(316, 52);
            this.txtFindAuthor.Name = "txtFindAuthor";
            this.txtFindAuthor.Size = new System.Drawing.Size(121, 20);
            this.txtFindAuthor.TabIndex = 2;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Library.Properties.Resources.papyrus;
            this.ClientSize = new System.Drawing.Size(474, 159);
            this.Controls.Add(this.txtFindAuthor);
            this.Controls.Add(this.txtFindSeries);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAddSeries);
            this.Controls.Add(this.txtFindISBN);
            this.Controls.Add(this.txtfindTitle);
            this.Controls.Add(this.lblAddISBN);
            this.Controls.Add(this.lblAddAuthor);
            this.Controls.Add(this.lblAddTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddSeries;
        private System.Windows.Forms.TextBox txtFindISBN;
        public System.Windows.Forms.TextBox txtfindTitle;
        private System.Windows.Forms.Label lblAddISBN;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFindSeries;
        private System.Windows.Forms.TextBox txtFindAuthor;
    }
}