namespace AnimeAndMangaList
{
    partial class FrmAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnime));
            btnLoadDataAnime = new Button();
            btnSaveReviewAnime = new Button();
            lblAddReview = new Label();
            txtReviewAnime = new TextBox();
            cbGenreAnime = new ComboBox();
            btnExportAnime = new Button();
            cbPlataform = new ComboBox();
            btnDeleteAnime = new Button();
            btnSaveAnime = new Button();
            nudRatingAnime = new NumericUpDown();
            dtpDateAnime = new DateTimePicker();
            lstvDataAnime = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnGetStatsAnime = new Button();
            lblRating = new Label();
            lblProductionStudio = new Label();
            txtProductionStudio = new TextBox();
            lblPlatform = new Label();
            lblNumberOfChapters = new Label();
            lblDate = new Label();
            lblGenre = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            txtChaptersAnime = new TextBox();
            txtAuthorAnime = new TextBox();
            txtTitleAnime = new TextBox();
            btnSimilarAnimes = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRatingAnime).BeginInit();
            SuspendLayout();
            // 
            // btnLoadDataAnime
            // 
            btnLoadDataAnime.BackColor = SystemColors.ActiveCaptionText;
            btnLoadDataAnime.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoadDataAnime.Cursor = Cursors.Hand;
            btnLoadDataAnime.FlatAppearance.BorderSize = 0;
            btnLoadDataAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnLoadDataAnime.FlatStyle = FlatStyle.Flat;
            btnLoadDataAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            btnLoadDataAnime.ForeColor = SystemColors.ButtonHighlight;
            btnLoadDataAnime.Location = new Point(12, 13);
            btnLoadDataAnime.Margin = new Padding(3, 4, 3, 4);
            btnLoadDataAnime.Name = "btnLoadDataAnime";
            btnLoadDataAnime.Size = new Size(104, 44);
            btnLoadDataAnime.TabIndex = 65;
            btnLoadDataAnime.Text = "Load data";
            btnLoadDataAnime.UseVisualStyleBackColor = false;
            btnLoadDataAnime.Click += btnLoadDataAnime_Click;
            // 
            // btnSaveReviewAnime
            // 
            btnSaveReviewAnime.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveReviewAnime.BackColor = SystemColors.ActiveCaptionText;
            btnSaveReviewAnime.Cursor = Cursors.Hand;
            btnSaveReviewAnime.FlatAppearance.BorderSize = 0;
            btnSaveReviewAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveReviewAnime.FlatStyle = FlatStyle.Flat;
            btnSaveReviewAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            btnSaveReviewAnime.ForeColor = SystemColors.Window;
            btnSaveReviewAnime.Location = new Point(20, 562);
            btnSaveReviewAnime.Margin = new Padding(3, 4, 3, 4);
            btnSaveReviewAnime.Name = "btnSaveReviewAnime";
            btnSaveReviewAnime.Size = new Size(75, 32);
            btnSaveReviewAnime.TabIndex = 64;
            btnSaveReviewAnime.Text = "Save";
            btnSaveReviewAnime.UseVisualStyleBackColor = false;
            btnSaveReviewAnime.Click += btnSaveReviewAnime_Click;
            // 
            // lblAddReview
            // 
            lblAddReview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAddReview.AutoSize = true;
            lblAddReview.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddReview.Location = new Point(21, 332);
            lblAddReview.Name = "lblAddReview";
            lblAddReview.Size = new Size(100, 19);
            lblAddReview.TabIndex = 63;
            lblAddReview.Text = "Add a review";
            // 
            // txtReviewAnime
            // 
            txtReviewAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtReviewAnime.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Bold);
            txtReviewAnime.Location = new Point(21, 355);
            txtReviewAnime.Margin = new Padding(3, 4, 3, 4);
            txtReviewAnime.Multiline = true;
            txtReviewAnime.Name = "txtReviewAnime";
            txtReviewAnime.Size = new Size(317, 188);
            txtReviewAnime.TabIndex = 62;
            txtReviewAnime.Text = "Title of anime:\r\n\r\nReview:";
            // 
            // cbGenreAnime
            // 
            cbGenreAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cbGenreAnime.Font = new Font("Microsoft Tai Le", 11F);
            cbGenreAnime.FormattingEnabled = true;
            cbGenreAnime.Items.AddRange(new object[] { "Shonen", "Seinen", "Comedy", "Sci-Fi", "Romcom", "Isekai" });
            cbGenreAnime.Location = new Point(197, 192);
            cbGenreAnime.Margin = new Padding(3, 4, 3, 4);
            cbGenreAnime.Name = "cbGenreAnime";
            cbGenreAnime.Size = new Size(193, 27);
            cbGenreAnime.TabIndex = 61;
            // 
            // btnExportAnime
            // 
            btnExportAnime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportAnime.BackColor = SystemColors.ActiveCaptionText;
            btnExportAnime.Cursor = Cursors.Hand;
            btnExportAnime.FlatAppearance.BorderSize = 0;
            btnExportAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnExportAnime.FlatStyle = FlatStyle.Flat;
            btnExportAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            btnExportAnime.ForeColor = SystemColors.ButtonHighlight;
            btnExportAnime.Location = new Point(1134, 571);
            btnExportAnime.Margin = new Padding(3, 4, 3, 4);
            btnExportAnime.Name = "btnExportAnime";
            btnExportAnime.Size = new Size(86, 35);
            btnExportAnime.TabIndex = 60;
            btnExportAnime.Text = "Export To";
            btnExportAnime.UseVisualStyleBackColor = false;
            btnExportAnime.Click += btnExportAnime_Click;
            // 
            // cbPlataform
            // 
            cbPlataform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            cbPlataform.Font = new Font("Microsoft Tai Le", 11F);
            cbPlataform.FormattingEnabled = true;
            cbPlataform.Items.AddRange(new object[] { "Netflix", "Crunchyroll", "Prime Video", "Disney Plus" });
            cbPlataform.Location = new Point(705, 131);
            cbPlataform.Margin = new Padding(3, 4, 3, 4);
            cbPlataform.Name = "cbPlataform";
            cbPlataform.Size = new Size(121, 27);
            cbPlataform.TabIndex = 59;
            // 
            // btnDeleteAnime
            // 
            btnDeleteAnime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteAnime.BackColor = SystemColors.ActiveCaptionText;
            btnDeleteAnime.Cursor = Cursors.Hand;
            btnDeleteAnime.FlatAppearance.BorderSize = 0;
            btnDeleteAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnDeleteAnime.FlatStyle = FlatStyle.Flat;
            btnDeleteAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            btnDeleteAnime.ForeColor = SystemColors.ControlLightLight;
            btnDeleteAnime.Location = new Point(1086, 93);
            btnDeleteAnime.Margin = new Padding(4, 3, 4, 3);
            btnDeleteAnime.Name = "btnDeleteAnime";
            btnDeleteAnime.Size = new Size(97, 39);
            btnDeleteAnime.TabIndex = 58;
            btnDeleteAnime.Text = "Delete";
            btnDeleteAnime.UseVisualStyleBackColor = false;
            btnDeleteAnime.Click += btnDeleteAnime_Click;
            // 
            // btnSaveAnime
            // 
            btnSaveAnime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveAnime.BackColor = SystemColors.ActiveCaptionText;
            btnSaveAnime.Cursor = Cursors.Hand;
            btnSaveAnime.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnSaveAnime.FlatAppearance.BorderSize = 0;
            btnSaveAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveAnime.FlatStyle = FlatStyle.Flat;
            btnSaveAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold);
            btnSaveAnime.ForeColor = SystemColors.ControlLightLight;
            btnSaveAnime.Location = new Point(1086, 27);
            btnSaveAnime.Margin = new Padding(4);
            btnSaveAnime.Name = "btnSaveAnime";
            btnSaveAnime.Size = new Size(97, 44);
            btnSaveAnime.TabIndex = 57;
            btnSaveAnime.Text = "Save";
            btnSaveAnime.UseVisualStyleBackColor = false;
            btnSaveAnime.Click += btnSaveAnime_Click;
            // 
            // nudRatingAnime
            // 
            nudRatingAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            nudRatingAnime.Font = new Font("Microsoft Tai Le", 11F);
            nudRatingAnime.Location = new Point(705, 241);
            nudRatingAnime.Margin = new Padding(4, 3, 4, 3);
            nudRatingAnime.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRatingAnime.Name = "nudRatingAnime";
            nudRatingAnime.Size = new Size(45, 26);
            nudRatingAnime.TabIndex = 56;
            // 
            // dtpDateAnime
            // 
            dtpDateAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpDateAnime.Font = new Font("Microsoft Tai Le", 11F);
            dtpDateAnime.Format = DateTimePickerFormat.Short;
            dtpDateAnime.Location = new Point(197, 247);
            dtpDateAnime.Margin = new Padding(4, 3, 4, 3);
            dtpDateAnime.Name = "dtpDateAnime";
            dtpDateAnime.Size = new Size(224, 26);
            dtpDateAnime.TabIndex = 55;
            // 
            // lstvDataAnime
            // 
            lstvDataAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lstvDataAnime.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lstvDataAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstvDataAnime.FullRowSelect = true;
            lstvDataAnime.Location = new Point(364, 289);
            lstvDataAnime.Margin = new Padding(4, 3, 4, 3);
            lstvDataAnime.Name = "lstvDataAnime";
            lstvDataAnime.Size = new Size(856, 267);
            lstvDataAnime.TabIndex = 54;
            lstvDataAnime.UseCompatibleStateImageBehavior = false;
            lstvDataAnime.View = View.Details;
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
            columnHeader5.Text = "Number of Chapters";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Platform";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Production Studio";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Rating";
            // 
            // btnGetStatsAnime
            // 
            btnGetStatsAnime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetStatsAnime.BackColor = SystemColors.ActiveCaptionText;
            btnGetStatsAnime.Cursor = Cursors.Hand;
            btnGetStatsAnime.FlatAppearance.BorderSize = 0;
            btnGetStatsAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnGetStatsAnime.FlatStyle = FlatStyle.Flat;
            btnGetStatsAnime.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGetStatsAnime.ForeColor = SystemColors.ControlLightLight;
            btnGetStatsAnime.Location = new Point(1086, 160);
            btnGetStatsAnime.Margin = new Padding(4);
            btnGetStatsAnime.Name = "btnGetStatsAnime";
            btnGetStatsAnime.Size = new Size(97, 48);
            btnGetStatsAnime.TabIndex = 51;
            btnGetStatsAnime.Text = "Get Stats";
            btnGetStatsAnime.UseVisualStyleBackColor = false;
            btnGetStatsAnime.Click += btnGetStatsAnime_Click;
            // 
            // lblRating
            // 
            lblRating.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblRating.Location = new Point(547, 243);
            lblRating.Margin = new Padding(4, 0, 4, 0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(59, 19);
            lblRating.TabIndex = 50;
            lblRating.Text = "Rating:";
            // 
            // lblProductionStudio
            // 
            lblProductionStudio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblProductionStudio.AutoSize = true;
            lblProductionStudio.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblProductionStudio.Location = new Point(547, 189);
            lblProductionStudio.Margin = new Padding(4, 0, 4, 0);
            lblProductionStudio.Name = "lblProductionStudio";
            lblProductionStudio.Size = new Size(139, 19);
            lblProductionStudio.TabIndex = 49;
            lblProductionStudio.Text = "Production Studio:";
            // 
            // txtProductionStudio
            // 
            txtProductionStudio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtProductionStudio.Font = new Font("Microsoft Tai Le", 11F);
            txtProductionStudio.Location = new Point(705, 187);
            txtProductionStudio.Margin = new Padding(4);
            txtProductionStudio.Name = "txtProductionStudio";
            txtProductionStudio.Size = new Size(312, 26);
            txtProductionStudio.TabIndex = 48;
            // 
            // lblPlatform
            // 
            lblPlatform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblPlatform.AutoSize = true;
            lblPlatform.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblPlatform.Location = new Point(547, 135);
            lblPlatform.Margin = new Padding(4, 0, 4, 0);
            lblPlatform.Name = "lblPlatform";
            lblPlatform.Size = new Size(75, 19);
            lblPlatform.TabIndex = 47;
            lblPlatform.Text = "Platform:";
            // 
            // lblNumberOfChapters
            // 
            lblNumberOfChapters.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblNumberOfChapters.AutoSize = true;
            lblNumberOfChapters.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblNumberOfChapters.Location = new Point(547, 81);
            lblNumberOfChapters.Margin = new Padding(4, 0, 4, 0);
            lblNumberOfChapters.Name = "lblNumberOfChapters";
            lblNumberOfChapters.Size = new Size(150, 19);
            lblNumberOfChapters.TabIndex = 46;
            lblNumberOfChapters.Text = "Number of chapters";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblDate.Location = new Point(40, 253);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(129, 19);
            lblDate.TabIndex = 45;
            lblDate.Text = "Acquisition Date:";
            // 
            // lblGenre
            // 
            lblGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblGenre.Location = new Point(40, 196);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 19);
            lblGenre.TabIndex = 44;
            lblGenre.Text = "Genre:";
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblAuthor.Location = new Point(40, 139);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 19);
            lblAuthor.TabIndex = 43;
            lblAuthor.Text = "Author:";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(40, 82);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 19);
            lblTitle.TabIndex = 42;
            lblTitle.Text = "Title:";
            // 
            // txtChaptersAnime
            // 
            txtChaptersAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtChaptersAnime.Font = new Font("Microsoft Tai Le", 11F);
            txtChaptersAnime.Location = new Point(705, 76);
            txtChaptersAnime.Margin = new Padding(4);
            txtChaptersAnime.Name = "txtChaptersAnime";
            txtChaptersAnime.Size = new Size(121, 26);
            txtChaptersAnime.TabIndex = 40;
            // 
            // txtAuthorAnime
            // 
            txtAuthorAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAuthorAnime.Font = new Font("Microsoft Tai Le", 11F);
            txtAuthorAnime.Location = new Point(197, 137);
            txtAuthorAnime.Margin = new Padding(4);
            txtAuthorAnime.Name = "txtAuthorAnime";
            txtAuthorAnime.Size = new Size(312, 26);
            txtAuthorAnime.TabIndex = 39;
            // 
            // txtTitleAnime
            // 
            txtTitleAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTitleAnime.Font = new Font("Microsoft Tai Le", 11F);
            txtTitleAnime.Location = new Point(197, 82);
            txtTitleAnime.Margin = new Padding(4);
            txtTitleAnime.Name = "txtTitleAnime";
            txtTitleAnime.Size = new Size(312, 26);
            txtTitleAnime.TabIndex = 38;
            // 
            // btnSimilarAnimes
            // 
            btnSimilarAnimes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSimilarAnimes.BackColor = SystemColors.ActiveCaptionText;
            btnSimilarAnimes.Cursor = Cursors.Hand;
            btnSimilarAnimes.FlatAppearance.BorderSize = 0;
            btnSimilarAnimes.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSimilarAnimes.FlatStyle = FlatStyle.Flat;
            btnSimilarAnimes.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimilarAnimes.ForeColor = SystemColors.ControlLightLight;
            btnSimilarAnimes.Location = new Point(1086, 228);
            btnSimilarAnimes.Margin = new Padding(4);
            btnSimilarAnimes.Name = "btnSimilarAnimes";
            btnSimilarAnimes.Size = new Size(97, 48);
            btnSimilarAnimes.TabIndex = 66;
            btnSimilarAnimes.Text = "Similar Animes";
            btnSimilarAnimes.UseVisualStyleBackColor = false;
            btnSimilarAnimes.Click += btnSimilarAnimes_Click;
            // 
            // FrmAnime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1233, 619);
            Controls.Add(btnSimilarAnimes);
            Controls.Add(btnLoadDataAnime);
            Controls.Add(btnSaveReviewAnime);
            Controls.Add(lblAddReview);
            Controls.Add(txtReviewAnime);
            Controls.Add(cbGenreAnime);
            Controls.Add(btnExportAnime);
            Controls.Add(cbPlataform);
            Controls.Add(btnDeleteAnime);
            Controls.Add(btnSaveAnime);
            Controls.Add(nudRatingAnime);
            Controls.Add(dtpDateAnime);
            Controls.Add(lstvDataAnime);
            Controls.Add(btnGetStatsAnime);
            Controls.Add(lblRating);
            Controls.Add(lblProductionStudio);
            Controls.Add(txtProductionStudio);
            Controls.Add(lblPlatform);
            Controls.Add(lblNumberOfChapters);
            Controls.Add(lblDate);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(txtChaptersAnime);
            Controls.Add(txtAuthorAnime);
            Controls.Add(txtTitleAnime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAnime";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anime";
            ((System.ComponentModel.ISupportInitialize)nudRatingAnime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadDataAnime;
        private Button btnSaveReviewAnime;
        private Label lblAddReview;
        private TextBox txtReviewAnime;
        private ComboBox cbGenreAnime;
        private Button btnExportAnime;
        private ComboBox cbPlataform;
        private Button btnDeleteAnime;
        private Button btnSaveAnime;
        private NumericUpDown nudRatingAnime;
        private DateTimePicker dtpDateAnime;
        private ListView lstvDataAnime;
        private Button btnGetStatsAnime;
        private Label lblRating;
        private Label lblPrice;
        private TextBox txtProductionStudio;
        private Label lblPlatform;
        private Label lblChapters;
        private Label lblDate;
        private Label lblGenre;
        private Label lblAuthor;
        private Label lblTitle;
        private TextBox txtChaptersAnime;
        private TextBox txtAuthorAnime;
        private TextBox txtTitleAnime;
        private Label lblProductionStudio;
        private Label lblNumberOfChapters;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnSimilarAnimes;
    }
}