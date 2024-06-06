namespace AnimeAndMangaList
{
    partial class FrmManga
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManga));
            btnSaveManga = new Button();
            btnGetStats = new Button();
            lstvDataManga = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnDeleteManga = new Button();
            btnExportManga = new Button();
            txtReview = new TextBox();
            lblAddReview = new Label();
            btnSaveReviewManga = new Button();
            btnLoadData = new Button();
            btnSimilarManga = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtChapters = new TextBox();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblDate = new Label();
            lblChapters = new Label();
            dtpDate = new DateTimePicker();
            lblEditorial = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            lblRating = new Label();
            nudRating = new NumericUpDown();
            cbEditorial = new ComboBox();
            cbGenre = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // btnSaveManga
            // 
            btnSaveManga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveManga.BackColor = SystemColors.ActiveCaptionText;
            btnSaveManga.FlatAppearance.BorderColor = SystemColors.WindowText;
            btnSaveManga.FlatAppearance.BorderSize = 0;
            btnSaveManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveManga.FlatStyle = FlatStyle.Flat;
            btnSaveManga.ForeColor = SystemColors.ControlLightLight;
            btnSaveManga.Location = new Point(1085, 20);
            btnSaveManga.Margin = new Padding(4);
            btnSaveManga.Name = "btnSaveManga";
            btnSaveManga.Size = new Size(97, 49);
            btnSaveManga.TabIndex = 7;
            btnSaveManga.Text = "Save";
            btnSaveManga.UseVisualStyleBackColor = false;
            btnSaveManga.Click += btnSaveManga_Click;
            // 
            // btnGetStats
            // 
            btnGetStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetStats.BackColor = SystemColors.ActiveCaptionText;
            btnGetStats.Cursor = Cursors.Hand;
            btnGetStats.FlatAppearance.BorderSize = 0;
            btnGetStats.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnGetStats.FlatStyle = FlatStyle.Flat;
            btnGetStats.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetStats.ForeColor = SystemColors.ControlLightLight;
            btnGetStats.Location = new Point(1085, 156);
            btnGetStats.Margin = new Padding(4);
            btnGetStats.Name = "btnGetStats";
            btnGetStats.Size = new Size(97, 49);
            btnGetStats.TabIndex = 20;
            btnGetStats.Text = "Get Stats";
            btnGetStats.UseVisualStyleBackColor = false;
            btnGetStats.Click += btnGetStats_Click;
            // 
            // lstvDataManga
            // 
            lstvDataManga.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstvDataManga.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lstvDataManga.FullRowSelect = true;
            lstvDataManga.Location = new Point(364, 291);
            lstvDataManga.Margin = new Padding(4, 3, 4, 3);
            lstvDataManga.Name = "lstvDataManga";
            lstvDataManga.Size = new Size(856, 267);
            lstvDataManga.TabIndex = 23;
            lstvDataManga.UseCompatibleStateImageBehavior = false;
            lstvDataManga.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Author";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Genre";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Volume";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Editorial";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Rating";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Price";
            // 
            // btnDeleteManga
            // 
            btnDeleteManga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteManga.BackColor = SystemColors.ActiveCaptionText;
            btnDeleteManga.Cursor = Cursors.Hand;
            btnDeleteManga.FlatAppearance.BorderSize = 0;
            btnDeleteManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnDeleteManga.FlatStyle = FlatStyle.Flat;
            btnDeleteManga.ForeColor = SystemColors.ControlLightLight;
            btnDeleteManga.Location = new Point(1085, 92);
            btnDeleteManga.Margin = new Padding(4, 3, 4, 3);
            btnDeleteManga.Name = "btnDeleteManga";
            btnDeleteManga.Size = new Size(97, 49);
            btnDeleteManga.TabIndex = 29;
            btnDeleteManga.Text = "Delete";
            btnDeleteManga.UseVisualStyleBackColor = false;
            btnDeleteManga.Click += btnDeleteManga_Click;
            // 
            // btnExportManga
            // 
            btnExportManga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportManga.BackColor = SystemColors.ActiveCaptionText;
            btnExportManga.Cursor = Cursors.Hand;
            btnExportManga.FlatAppearance.BorderSize = 0;
            btnExportManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnExportManga.FlatStyle = FlatStyle.Flat;
            btnExportManga.ForeColor = SystemColors.ButtonHighlight;
            btnExportManga.Location = new Point(1135, 571);
            btnExportManga.Margin = new Padding(3, 4, 3, 4);
            btnExportManga.Name = "btnExportManga";
            btnExportManga.Size = new Size(86, 35);
            btnExportManga.TabIndex = 32;
            btnExportManga.Text = "Export To";
            btnExportManga.UseVisualStyleBackColor = false;
            btnExportManga.Click += btnExport_Click;
            // 
            // txtReview
            // 
            txtReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtReview.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            txtReview.Location = new Point(21, 356);
            txtReview.Margin = new Padding(3, 4, 3, 4);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(317, 188);
            txtReview.TabIndex = 34;
            txtReview.Text = "Title of manga:\r\n\r\nReview:";
            // 
            // lblAddReview
            // 
            lblAddReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddReview.AutoSize = true;
            lblAddReview.Location = new Point(21, 333);
            lblAddReview.Name = "lblAddReview";
            lblAddReview.Size = new Size(100, 19);
            lblAddReview.TabIndex = 35;
            lblAddReview.Text = "Add a review";
            // 
            // btnSaveReviewManga
            // 
            btnSaveReviewManga.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveReviewManga.BackColor = SystemColors.ActiveCaptionText;
            btnSaveReviewManga.Cursor = Cursors.Hand;
            btnSaveReviewManga.FlatAppearance.BorderSize = 0;
            btnSaveReviewManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveReviewManga.FlatStyle = FlatStyle.Flat;
            btnSaveReviewManga.ForeColor = SystemColors.Window;
            btnSaveReviewManga.Location = new Point(21, 565);
            btnSaveReviewManga.Margin = new Padding(3, 4, 3, 4);
            btnSaveReviewManga.Name = "btnSaveReviewManga";
            btnSaveReviewManga.Size = new Size(75, 32);
            btnSaveReviewManga.TabIndex = 36;
            btnSaveReviewManga.Text = "Save";
            btnSaveReviewManga.UseVisualStyleBackColor = false;
            btnSaveReviewManga.Click += btnSaveReview_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = SystemColors.ActiveCaptionText;
            btnLoadData.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoadData.Cursor = Cursors.Hand;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.ForeColor = SystemColors.ButtonHighlight;
            btnLoadData.Location = new Point(12, 14);
            btnLoadData.Margin = new Padding(3, 4, 3, 4);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(104, 44);
            btnLoadData.TabIndex = 37;
            btnLoadData.Text = "Load data";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnSimilarManga
            // 
            btnSimilarManga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSimilarManga.BackColor = SystemColors.ActiveCaptionText;
            btnSimilarManga.FlatAppearance.BorderSize = 0;
            btnSimilarManga.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSimilarManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSimilarManga.FlatStyle = FlatStyle.Flat;
            btnSimilarManga.ForeColor = SystemColors.ControlLightLight;
            btnSimilarManga.Location = new Point(1085, 225);
            btnSimilarManga.Name = "btnSimilarManga";
            btnSimilarManga.Size = new Size(97, 49);
            btnSimilarManga.TabIndex = 38;
            btnSimilarManga.Text = "Similar Mangas";
            btnSimilarManga.UseVisualStyleBackColor = false;
            btnSimilarManga.Click += btnSimilarManga_Click;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTitle.Font = new Font("Microsoft Tai Le", 11F);
            txtTitle.Location = new Point(197, 83);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(312, 26);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAuthor.Font = new Font("Microsoft Tai Le", 11F);
            txtAuthor.Location = new Point(197, 138);
            txtAuthor.Margin = new Padding(4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(312, 26);
            txtAuthor.TabIndex = 2;
            // 
            // txtChapters
            // 
            txtChapters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtChapters.Font = new Font("Microsoft Tai Le", 11F);
            txtChapters.Location = new Point(705, 83);
            txtChapters.Margin = new Padding(4);
            txtChapters.Name = "txtChapters";
            txtChapters.Size = new Size(121, 26);
            txtChapters.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(40, 83);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 19);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblAuthor.Location = new Point(40, 140);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 19);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Author:";
            // 
            // lblGenre
            // 
            lblGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblGenre.Location = new Point(40, 197);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 19);
            lblGenre.TabIndex = 11;
            lblGenre.Text = "Genre:";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblDate.Location = new Point(40, 254);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(129, 19);
            lblDate.TabIndex = 12;
            lblDate.Text = "Acquisition Date:";
            // 
            // lblChapters
            // 
            lblChapters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblChapters.AutoSize = true;
            lblChapters.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblChapters.Location = new Point(547, 82);
            lblChapters.Margin = new Padding(4, 0, 4, 0);
            lblChapters.Name = "lblChapters";
            lblChapters.Size = new Size(67, 19);
            lblChapters.TabIndex = 13;
            lblChapters.Text = "Volume:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpDate.Font = new Font("Microsoft Tai Le", 11F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(197, 248);
            dtpDate.Margin = new Padding(4, 3, 4, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(224, 26);
            dtpDate.TabIndex = 26;
            // 
            // lblEditorial
            // 
            lblEditorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblEditorial.Location = new Point(547, 139);
            lblEditorial.Margin = new Padding(4, 0, 4, 0);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 19);
            lblEditorial.TabIndex = 14;
            lblEditorial.Text = "Editorial:";
            // 
            // txtPrice
            // 
            txtPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtPrice.Font = new Font("Microsoft Tai Le", 11F);
            txtPrice.Location = new Point(705, 225);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(312, 26);
            txtPrice.TabIndex = 16;
            txtPrice.Visible = false;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblPrice.Location = new Point(547, 232);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 19);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Price:";
            lblPrice.Visible = false;
            // 
            // lblRating
            // 
            lblRating.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblRating.Location = new Point(547, 196);
            lblRating.Margin = new Padding(4, 0, 4, 0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(59, 19);
            lblRating.TabIndex = 19;
            lblRating.Text = "Rating:";
            // 
            // nudRating
            // 
            nudRating.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudRating.Font = new Font("Microsoft Tai Le", 11F);
            nudRating.Location = new Point(705, 188);
            nudRating.Margin = new Padding(4, 3, 4, 3);
            nudRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(45, 26);
            nudRating.TabIndex = 27;
            // 
            // cbEditorial
            // 
            cbEditorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbEditorial.Font = new Font("Microsoft Tai Le", 11F);
            cbEditorial.FormattingEnabled = true;
            cbEditorial.Items.AddRange(new object[] { "Panini", "Ivrea", "Norma", "Kamite" });
            cbEditorial.Location = new Point(705, 135);
            cbEditorial.Margin = new Padding(3, 4, 3, 4);
            cbEditorial.Name = "cbEditorial";
            cbEditorial.Size = new Size(121, 27);
            cbEditorial.TabIndex = 30;
            // 
            // cbGenre
            // 
            cbGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbGenre.Font = new Font("Microsoft Tai Le", 11F);
            cbGenre.FormattingEnabled = true;
            cbGenre.Items.AddRange(new object[] { "Shonen", "Seinen", "Comedy", "Sci-Fi", "Romcom", "Isekai" });
            cbGenre.Location = new Point(197, 193);
            cbGenre.Margin = new Padding(3, 4, 3, 4);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(193, 27);
            cbGenre.TabIndex = 33;
            // 
            // FrmManga
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1233, 619);
            Controls.Add(btnSimilarManga);
            Controls.Add(btnLoadData);
            Controls.Add(btnSaveReviewManga);
            Controls.Add(lblAddReview);
            Controls.Add(txtReview);
            Controls.Add(cbGenre);
            Controls.Add(btnExportManga);
            Controls.Add(cbEditorial);
            Controls.Add(btnDeleteManga);
            Controls.Add(nudRating);
            Controls.Add(dtpDate);
            Controls.Add(lstvDataManga);
            Controls.Add(btnGetStats);
            Controls.Add(lblRating);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblEditorial);
            Controls.Add(lblChapters);
            Controls.Add(lblDate);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnSaveManga);
            Controls.Add(txtChapters);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmManga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manga";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSaveManga;
        private Button btnGetStats;
        private ListView lstvDataManga;
        private Button btnDeleteManga;
        private Button btnExportManga;
        private TextBox txtReview;
        private Label lblAddReview;
        private Button btnSaveReviewManga;
        private Button btnLoadData;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnSimilarManga;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtChapters;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblDate;
        private Label lblChapters;
        private DateTimePicker dtpDate;
        private Label lblEditorial;
        private TextBox txtPrice;
        private Label lblPrice;
        private Label lblRating;
        private NumericUpDown nudRating;
        private ComboBox cbEditorial;
        private ComboBox cbGenre;
    }
}
