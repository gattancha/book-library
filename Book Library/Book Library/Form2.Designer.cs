namespace Book_Library
{
    partial class frmAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAddISBN = new System.Windows.Forms.Label();
            this.txtBoxAddTitle = new System.Windows.Forms.TextBox();
            this.cmbAddAuthor = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDS = new Book_Library.BooksDS();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddISBN = new System.Windows.Forms.TextBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.infoTableAdapter = new Book_Library.BooksDSTableAdapters.infoTableAdapter();
            this.authorsTableAdapter = new Book_Library.BooksDSTableAdapters.authorsTableAdapter();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.cmbAddGenre = new System.Windows.Forms.ComboBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new Book_Library.BooksDSTableAdapters.genreTableAdapter();
            this.cmbAddFormat = new System.Windows.Forms.ComboBox();
            this.formatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFormat = new System.Windows.Forms.Label();
            this.formatsTableAdapter = new Book_Library.BooksDSTableAdapters.formatsTableAdapter();
            this.cmbAddSeries = new System.Windows.Forms.ComboBox();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddSeries = new System.Windows.Forms.Label();
            this.seriesTableAdapter = new Book_Library.BooksDSTableAdapters.SeriesTableAdapter();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnAddFormat = new System.Windows.Forms.Button();
            this.btnAddSeries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(14, 42);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(27, 13);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Title";
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(265, 39);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAddAuthor.TabIndex = 1;
            this.lblAddAuthor.Text = "Author";
            // 
            // lblAddISBN
            // 
            this.lblAddISBN.AutoSize = true;
            this.lblAddISBN.Location = new System.Drawing.Point(14, 73);
            this.lblAddISBN.Name = "lblAddISBN";
            this.lblAddISBN.Size = new System.Drawing.Size(32, 13);
            this.lblAddISBN.TabIndex = 2;
            this.lblAddISBN.Text = "ISBN";
            // 
            // txtBoxAddTitle
            // 
            this.txtBoxAddTitle.Location = new System.Drawing.Point(61, 39);
            this.txtBoxAddTitle.Name = "txtBoxAddTitle";
            this.txtBoxAddTitle.Size = new System.Drawing.Size(121, 20);
            this.txtBoxAddTitle.TabIndex = 3;
            // 
            // cmbAddAuthor
            // 
            this.cmbAddAuthor.DataSource = this.authorsBindingSource;
            this.cmbAddAuthor.DisplayMember = "author_name";
            this.cmbAddAuthor.FormattingEnabled = true;
            this.cmbAddAuthor.Location = new System.Drawing.Point(310, 36);
            this.cmbAddAuthor.Name = "cmbAddAuthor";
            this.cmbAddAuthor.Size = new System.Drawing.Size(121, 21);
            this.cmbAddAuthor.TabIndex = 4;
            this.cmbAddAuthor.ValueMember = "author_id";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "authors";
            this.authorsBindingSource.DataSource = this.booksDSBindingSource;
            // 
            // booksDSBindingSource
            // 
            this.booksDSBindingSource.DataSource = this.booksDS;
            this.booksDSBindingSource.Position = 0;
            // 
            // booksDS
            // 
            this.booksDS.DataSetName = "BooksDS";
            this.booksDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.booksDSBindingSource;
            // 
            // txtAddISBN
            // 
            this.txtAddISBN.Location = new System.Drawing.Point(61, 70);
            this.txtAddISBN.Name = "txtAddISBN";
            this.txtAddISBN.Size = new System.Drawing.Size(121, 20);
            this.txtAddISBN.TabIndex = 5;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(196, 238);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecord.TabIndex = 6;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Location = new System.Drawing.Point(265, 71);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(36, 13);
            this.lblAddGenre.TabIndex = 7;
            this.lblAddGenre.Text = "Genre";
            // 
            // cmbAddGenre
            // 
            this.cmbAddGenre.DataSource = this.genreBindingSource;
            this.cmbAddGenre.DisplayMember = "genre";
            this.cmbAddGenre.FormattingEnabled = true;
            this.cmbAddGenre.Location = new System.Drawing.Point(310, 68);
            this.cmbAddGenre.Name = "cmbAddGenre";
            this.cmbAddGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbAddGenre.TabIndex = 8;
            this.cmbAddGenre.ValueMember = "genre_id";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "genre";
            this.genreBindingSource.DataSource = this.booksDS;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAddFormat
            // 
            this.cmbAddFormat.DataSource = this.formatsBindingSource;
            this.cmbAddFormat.DisplayMember = "format";
            this.cmbAddFormat.FormattingEnabled = true;
            this.cmbAddFormat.Location = new System.Drawing.Point(310, 99);
            this.cmbAddFormat.Name = "cmbAddFormat";
            this.cmbAddFormat.Size = new System.Drawing.Size(121, 21);
            this.cmbAddFormat.TabIndex = 10;
            this.cmbAddFormat.ValueMember = "format_id";
            // 
            // formatsBindingSource
            // 
            this.formatsBindingSource.DataMember = "formats";
            this.formatsBindingSource.DataSource = this.booksDS;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(265, 102);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(39, 13);
            this.lblFormat.TabIndex = 9;
            this.lblFormat.Text = "Format";
            // 
            // formatsTableAdapter
            // 
            this.formatsTableAdapter.ClearBeforeFill = true;
            // 
            // cmbAddSeries
            // 
            this.cmbAddSeries.DataSource = this.seriesBindingSource;
            this.cmbAddSeries.DisplayMember = "series";
            this.cmbAddSeries.FormattingEnabled = true;
            this.cmbAddSeries.Location = new System.Drawing.Point(61, 97);
            this.cmbAddSeries.Name = "cmbAddSeries";
            this.cmbAddSeries.Size = new System.Drawing.Size(121, 21);
            this.cmbAddSeries.TabIndex = 12;
            this.cmbAddSeries.ValueMember = "series_id";
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.booksDS;
            // 
            // lblAddSeries
            // 
            this.lblAddSeries.AutoSize = true;
            this.lblAddSeries.Location = new System.Drawing.Point(14, 100);
            this.lblAddSeries.Name = "lblAddSeries";
            this.lblAddSeries.Size = new System.Drawing.Size(36, 13);
            this.lblAddSeries.TabIndex = 11;
            this.lblAddSeries.Text = "Series";
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(44, 134);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(60, 13);
            this.lblAddDescription.TabIndex = 13;
            this.lblAddDescription.Text = "Description";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(47, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(383, 82);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Image = global::Book_Library.Properties.Resources.Create;
            this.btnAddAuthor.Location = new System.Drawing.Point(437, 36);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(29, 25);
            this.btnAddAuthor.TabIndex = 15;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddGenre.FlatAppearance.BorderSize = 0;
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Image = global::Book_Library.Properties.Resources.Create;
            this.btnAddGenre.Location = new System.Drawing.Point(436, 65);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(29, 25);
            this.btnAddGenre.TabIndex = 16;
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnAddFormat
            // 
            this.btnAddFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddFormat.FlatAppearance.BorderSize = 0;
            this.btnAddFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFormat.Image = global::Book_Library.Properties.Resources.Create;
            this.btnAddFormat.Location = new System.Drawing.Point(436, 96);
            this.btnAddFormat.Name = "btnAddFormat";
            this.btnAddFormat.Size = new System.Drawing.Size(29, 25);
            this.btnAddFormat.TabIndex = 17;
            this.btnAddFormat.UseVisualStyleBackColor = false;
            this.btnAddFormat.Click += new System.EventHandler(this.btnAddFormat_Click);
            // 
            // btnAddSeries
            // 
            this.btnAddSeries.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSeries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddSeries.FlatAppearance.BorderSize = 0;
            this.btnAddSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSeries.Image = global::Book_Library.Properties.Resources.Create;
            this.btnAddSeries.Location = new System.Drawing.Point(188, 94);
            this.btnAddSeries.Name = "btnAddSeries";
            this.btnAddSeries.Size = new System.Drawing.Size(29, 25);
            this.btnAddSeries.TabIndex = 18;
            this.btnAddSeries.UseVisualStyleBackColor = false;
            this.btnAddSeries.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Book_Library.Properties.Resources.papyrus;
            this.ClientSize = new System.Drawing.Size(490, 273);
            this.Controls.Add(this.btnAddSeries);
            this.Controls.Add(this.btnAddFormat);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblAddDescription);
            this.Controls.Add(this.cmbAddSeries);
            this.Controls.Add(this.lblAddSeries);
            this.Controls.Add(this.cmbAddFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.cmbAddGenre);
            this.Controls.Add(this.lblAddGenre);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.txtAddISBN);
            this.Controls.Add(this.cmbAddAuthor);
            this.Controls.Add(this.txtBoxAddTitle);
            this.Controls.Add(this.lblAddISBN);
            this.Controls.Add(this.lblAddAuthor);
            this.Controls.Add(this.lblAddTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Label lblAddISBN;
        private System.Windows.Forms.TextBox txtBoxAddTitle;
        private System.Windows.Forms.ComboBox cmbAddAuthor;
        private System.Windows.Forms.TextBox txtAddISBN;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.BindingSource booksDSBindingSource;
        private BooksDS booksDS;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private BooksDSTableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BooksDSTableAdapters.authorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.ComboBox cmbAddGenre;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private BooksDSTableAdapters.genreTableAdapter genreTableAdapter;
        private System.Windows.Forms.ComboBox cmbAddFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.BindingSource formatsBindingSource;
        private BooksDSTableAdapters.formatsTableAdapter formatsTableAdapter;
        private System.Windows.Forms.ComboBox cmbAddSeries;
        private System.Windows.Forms.Label lblAddSeries;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private BooksDSTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnAddFormat;
        private System.Windows.Forms.Button btnAddSeries;
    }
}