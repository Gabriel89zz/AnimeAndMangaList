namespace AnimeAndMangaList
{
    partial class Form1
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtChapters = new TextBox();
            btnSaveManga = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblDate = new Label();
            lblGenre = new Label();
            lblEditorial = new Label();
            lblChapters = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblRating = new Label();
            btnCalculateCost = new Button();
            btnAddManga = new Button();
            btnAddAnime = new Button();
            lstvData = new ListView();
            dtpDate = new DateTimePicker();
            nudRating = new NumericUpDown();
            btnSaveAnime = new Button();
            btnDeleteManga = new Button();
            cbEditorial = new ComboBox();
            btnExport = new Button();
            cbGenre = new ComboBox();
            txtReview = new TextBox();
            lblAddReview = new Label();
            btnSaveReview = new Button();
            btnLoadData = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRating).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft Tai Le", 11F);
            txtTitle.Location = new Point(197, 83);
            txtTitle.Margin = new Padding(4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(312, 26);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Microsoft Tai Le", 11F);
            txtAuthor.Location = new Point(197, 138);
            txtAuthor.Margin = new Padding(4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(312, 26);
            txtAuthor.TabIndex = 2;
            // 
            // txtChapters
            // 
            txtChapters.Font = new Font("Microsoft Tai Le", 11F);
            txtChapters.Location = new Point(705, 77);
            txtChapters.Margin = new Padding(4);
            txtChapters.Name = "txtChapters";
            txtChapters.Size = new Size(121, 26);
            txtChapters.TabIndex = 5;
            // 
            // btnSaveManga
            // 
            btnSaveManga.BackColor = SystemColors.ActiveCaptionText;
            btnSaveManga.FlatAppearance.BorderColor = SystemColors.WindowText;
            btnSaveManga.FlatAppearance.BorderSize = 0;
            btnSaveManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveManga.FlatStyle = FlatStyle.Flat;
            btnSaveManga.ForeColor = SystemColors.ControlLightLight;
            btnSaveManga.Location = new Point(1086, 77);
            btnSaveManga.Margin = new Padding(4);
            btnSaveManga.Name = "btnSaveManga";
            btnSaveManga.Size = new Size(97, 44);
            btnSaveManga.TabIndex = 7;
            btnSaveManga.Text = "Save";
            btnSaveManga.UseVisualStyleBackColor = false;
            btnSaveManga.Click += btnSaveManga_Click;
            // 
            // lblTitle
            // 
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
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblAuthor.Location = new Point(40, 140);
            lblAuthor.Margin = new Padding(4, 0, 4, 0);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 19);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Author:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblDate.Location = new Point(40, 254);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(129, 19);
            lblDate.TabIndex = 12;
            lblDate.Text = "Acquisition Date:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblGenre.Location = new Point(40, 197);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 19);
            lblGenre.TabIndex = 11;
            lblGenre.Text = "Genre:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblEditorial.Location = new Point(547, 136);
            lblEditorial.Margin = new Padding(4, 0, 4, 0);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 19);
            lblEditorial.TabIndex = 14;
            lblEditorial.Text = "Editorial:";
            // 
            // lblChapters
            // 
            lblChapters.AutoSize = true;
            lblChapters.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblChapters.Location = new Point(547, 82);
            lblChapters.Margin = new Padding(4, 0, 4, 0);
            lblChapters.Name = "lblChapters";
            lblChapters.Size = new Size(67, 19);
            lblChapters.TabIndex = 13;
            lblChapters.Text = "Volume:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblPrice.Location = new Point(547, 190);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 19);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Microsoft Tai Le", 11F);
            txtPrice.Location = new Point(705, 188);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(312, 26);
            txtPrice.TabIndex = 16;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold);
            lblRating.Location = new Point(547, 244);
            lblRating.Margin = new Padding(4, 0, 4, 0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(59, 19);
            lblRating.TabIndex = 19;
            lblRating.Text = "Rating:";
            // 
            // btnCalculateCost
            // 
            btnCalculateCost.BackColor = SystemColors.ActiveCaptionText;
            btnCalculateCost.Cursor = Cursors.Hand;
            btnCalculateCost.FlatAppearance.BorderSize = 0;
            btnCalculateCost.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnCalculateCost.FlatStyle = FlatStyle.Flat;
            btnCalculateCost.Font = new Font("Microsoft Tai Le", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateCost.ForeColor = SystemColors.ControlLightLight;
            btnCalculateCost.Location = new Point(1086, 216);
            btnCalculateCost.Margin = new Padding(4);
            btnCalculateCost.Name = "btnCalculateCost";
            btnCalculateCost.Size = new Size(97, 48);
            btnCalculateCost.TabIndex = 20;
            btnCalculateCost.Text = "Calculate Cost";
            btnCalculateCost.UseVisualStyleBackColor = false;
            btnCalculateCost.Click += btnCalculateCost_Click;
            // 
            // btnAddManga
            // 
            btnAddManga.BackColor = Color.DarkOrchid;
            btnAddManga.Cursor = Cursors.Hand;
            btnAddManga.FlatAppearance.BorderSize = 0;
            btnAddManga.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddManga.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
            btnAddManga.FlatStyle = FlatStyle.Flat;
            btnAddManga.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btnAddManga.ForeColor = SystemColors.ButtonFace;
            btnAddManga.Location = new Point(317, 14);
            btnAddManga.Margin = new Padding(4);
            btnAddManga.Name = "btnAddManga";
            btnAddManga.Size = new Size(117, 44);
            btnAddManga.TabIndex = 21;
            btnAddManga.Text = "Add Manga";
            btnAddManga.UseVisualStyleBackColor = false;
            btnAddManga.Click += btnAddManga_Click;
            // 
            // btnAddAnime
            // 
            btnAddAnime.BackColor = Color.DarkOrchid;
            btnAddAnime.Cursor = Cursors.Hand;
            btnAddAnime.FlatAppearance.BorderSize = 0;
            btnAddAnime.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddAnime.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
            btnAddAnime.FlatStyle = FlatStyle.Flat;
            btnAddAnime.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btnAddAnime.ForeColor = SystemColors.ButtonFace;
            btnAddAnime.Location = new Point(809, 14);
            btnAddAnime.Margin = new Padding(4);
            btnAddAnime.Name = "btnAddAnime";
            btnAddAnime.Size = new Size(117, 44);
            btnAddAnime.TabIndex = 22;
            btnAddAnime.Text = "Add Anime";
            btnAddAnime.UseVisualStyleBackColor = false;
            btnAddAnime.Click += btnAddAnime_Click;
            // 
            // lstvData
            // 
            lstvData.FullRowSelect = true;
            lstvData.Location = new Point(364, 291);
            lstvData.Margin = new Padding(4, 3, 4, 3);
            lstvData.Name = "lstvData";
            lstvData.Size = new Size(856, 267);
            lstvData.TabIndex = 23;
            lstvData.UseCompatibleStateImageBehavior = false;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Microsoft Tai Le", 11F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(197, 248);
            dtpDate.Margin = new Padding(4, 3, 4, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(224, 26);
            dtpDate.TabIndex = 26;
            // 
            // nudRating
            // 
            nudRating.Font = new Font("Microsoft Tai Le", 11F);
            nudRating.Location = new Point(705, 242);
            nudRating.Margin = new Padding(4, 3, 4, 3);
            nudRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRating.Name = "nudRating";
            nudRating.Size = new Size(45, 26);
            nudRating.TabIndex = 27;
            // 
            // btnSaveAnime
            // 
            btnSaveAnime.BackColor = SystemColors.ActiveCaptionText;
            btnSaveAnime.Cursor = Cursors.Hand;
            btnSaveAnime.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnSaveAnime.FlatAppearance.BorderSize = 0;
            btnSaveAnime.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveAnime.FlatStyle = FlatStyle.Flat;
            btnSaveAnime.ForeColor = SystemColors.ControlLightLight;
            btnSaveAnime.Location = new Point(1086, 77);
            btnSaveAnime.Margin = new Padding(4);
            btnSaveAnime.Name = "btnSaveAnime";
            btnSaveAnime.Size = new Size(97, 44);
            btnSaveAnime.TabIndex = 28;
            btnSaveAnime.Text = "Save";
            btnSaveAnime.UseVisualStyleBackColor = false;
            btnSaveAnime.Click += btnSaveAnime_Click;
            // 
            // btnDeleteManga
            // 
            btnDeleteManga.BackColor = SystemColors.ActiveCaptionText;
            btnDeleteManga.Cursor = Cursors.Hand;
            btnDeleteManga.FlatAppearance.BorderSize = 0;
            btnDeleteManga.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnDeleteManga.FlatStyle = FlatStyle.Flat;
            btnDeleteManga.ForeColor = SystemColors.ControlLightLight;
            btnDeleteManga.Location = new Point(1086, 149);
            btnDeleteManga.Margin = new Padding(4, 3, 4, 3);
            btnDeleteManga.Name = "btnDeleteManga";
            btnDeleteManga.Size = new Size(97, 39);
            btnDeleteManga.TabIndex = 29;
            btnDeleteManga.Text = "Delete";
            btnDeleteManga.UseVisualStyleBackColor = false;
            btnDeleteManga.Click += btnDeleteManga_Click;
            // 
            // cbEditorial
            // 
            cbEditorial.Font = new Font("Microsoft Tai Le", 11F);
            cbEditorial.FormattingEnabled = true;
            cbEditorial.Items.AddRange(new object[] { "Panini", "Ivrea", "Norma", "Kamite" });
            cbEditorial.Location = new Point(705, 132);
            cbEditorial.Margin = new Padding(3, 4, 3, 4);
            cbEditorial.Name = "cbEditorial";
            cbEditorial.Size = new Size(121, 27);
            cbEditorial.TabIndex = 30;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ActiveCaptionText;
            btnExport.Cursor = Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.ForeColor = SystemColors.ButtonHighlight;
            btnExport.Location = new Point(1123, 570);
            btnExport.Margin = new Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(86, 35);
            btnExport.TabIndex = 32;
            btnExport.Text = "Export To";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // cbGenre
            // 
            cbGenre.Font = new Font("Microsoft Tai Le", 11F);
            cbGenre.FormattingEnabled = true;
            cbGenre.Items.AddRange(new object[] { "Shonen", "Seinen", "Romcom", "Shojo", "Science fiction", "Comedy" });
            cbGenre.Location = new Point(197, 193);
            cbGenre.Margin = new Padding(3, 4, 3, 4);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(193, 27);
            cbGenre.TabIndex = 33;
            // 
            // txtReview
            // 
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
            lblAddReview.AutoSize = true;
            lblAddReview.Location = new Point(21, 333);
            lblAddReview.Name = "lblAddReview";
            lblAddReview.Size = new Size(100, 19);
            lblAddReview.TabIndex = 35;
            lblAddReview.Text = "Add a review";
            // 
            // btnSaveReview
            // 
            btnSaveReview.BackColor = SystemColors.ActiveCaptionText;
            btnSaveReview.Cursor = Cursors.Hand;
            btnSaveReview.FlatAppearance.BorderSize = 0;
            btnSaveReview.FlatAppearance.MouseOverBackColor = Color.DarkOrchid;
            btnSaveReview.FlatStyle = FlatStyle.Flat;
            btnSaveReview.ForeColor = SystemColors.Window;
            btnSaveReview.Location = new Point(21, 561);
            btnSaveReview.Margin = new Padding(3, 4, 3, 4);
            btnSaveReview.Name = "btnSaveReview";
            btnSaveReview.Size = new Size(75, 32);
            btnSaveReview.TabIndex = 36;
            btnSaveReview.Text = "Save";
            btnSaveReview.UseVisualStyleBackColor = false;
            btnSaveReview.Click += btnSaveReview_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1233, 619);
            Controls.Add(btnLoadData);
            Controls.Add(btnSaveReview);
            Controls.Add(lblAddReview);
            Controls.Add(txtReview);
            Controls.Add(cbGenre);
            Controls.Add(btnExport);
            Controls.Add(cbEditorial);
            Controls.Add(btnDeleteManga);
            Controls.Add(btnSaveAnime);
            Controls.Add(nudRating);
            Controls.Add(dtpDate);
            Controls.Add(lstvData);
            Controls.Add(btnAddAnime);
            Controls.Add(btnAddManga);
            Controls.Add(btnCalculateCost);
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
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtChapters;
        private Button btnSaveManga;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblDate;
        private Label lblGenre;
        private Label lblEditorial;
        private Label lblChapters;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblRating;
        private Button btnCalculateCost;
        private Button btnAddManga;
        private Button btnAddAnime;
        private ListView lstvData;
        private DateTimePicker dtpDate;
        private NumericUpDown nudRating;
        private Button btnSaveAnime;
        private Button btnDeleteManga;
        private ComboBox cbEditorial;
        private Button btnExport;
        private ComboBox cbGenre;
        private TextBox txtReview;
        private Label lblAddReview;
        private Button btnSaveReview;
        private Button btnLoadData;
    }
}
