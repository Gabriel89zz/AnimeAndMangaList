namespace AnimeAndMangaList
{
    partial class FrmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            btnAddManga = new Button();
            btnAddAnime = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddManga
            // 
            btnAddManga.Anchor = AnchorStyles.Left;
            btnAddManga.BackColor = Color.DarkOrchid;
            btnAddManga.FlatAppearance.BorderSize = 0;
            btnAddManga.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
            btnAddManga.FlatStyle = FlatStyle.Flat;
            btnAddManga.Font = new Font("Microsoft Tai Le", 21.75F, FontStyle.Bold);
            btnAddManga.ForeColor = SystemColors.ButtonHighlight;
            btnAddManga.Location = new Point(111, 152);
            btnAddManga.Name = "btnAddManga";
            btnAddManga.Size = new Size(262, 105);
            btnAddManga.TabIndex = 0;
            btnAddManga.Text = "ADD MANGA";
            btnAddManga.UseVisualStyleBackColor = false;
            btnAddManga.Click += btnAddManga_Click;
            // 
            // btnAddAnime
            // 
            btnAddAnime.Anchor = AnchorStyles.Right;
            btnAddAnime.BackColor = Color.DarkOrchid;
            btnAddAnime.FlatAppearance.BorderSize = 0;
            btnAddAnime.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaptionText;
            btnAddAnime.FlatStyle = FlatStyle.Flat;
            btnAddAnime.Font = new Font("Microsoft Tai Le", 21.75F, FontStyle.Bold);
            btnAddAnime.ForeColor = SystemColors.ButtonHighlight;
            btnAddAnime.Location = new Point(426, 152);
            btnAddAnime.Name = "btnAddAnime";
            btnAddAnime.Size = new Size(262, 105);
            btnAddAnime.TabIndex = 1;
            btnAddAnime.Text = "ADD ANIME";
            btnAddAnime.UseVisualStyleBackColor = false;
            btnAddAnime.Click += btnAddAnime_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(778, 48);
            label1.TabIndex = 2;
            label1.Text = "Welcome, what would you like to do?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(10, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(587, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(206, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnAddAnime);
            Controls.Add(btnAddManga);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddManga;
        private Button btnAddAnime;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}