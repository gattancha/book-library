namespace Book_Library
{
    partial class addGenre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addGenre));
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.txtNewGenre = new System.Windows.Forms.TextBox();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(189, 29);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 5;
            this.btnAddGenre.Text = "Add Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // txtNewGenre
            // 
            this.txtNewGenre.Location = new System.Drawing.Point(72, 31);
            this.txtNewGenre.Name = "txtNewGenre";
            this.txtNewGenre.Size = new System.Drawing.Size(100, 20);
            this.txtNewGenre.TabIndex = 4;
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Location = new System.Drawing.Point(28, 34);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(36, 13);
            this.lblAddGenre.TabIndex = 3;
            this.lblAddGenre.Text = "Genre";
            // 
            // addGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Library.Properties.Resources.papyrus;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 81);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.txtNewGenre);
            this.Controls.Add(this.lblAddGenre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Genre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.TextBox txtNewGenre;
        private System.Windows.Forms.Label lblAddGenre;
    }
}