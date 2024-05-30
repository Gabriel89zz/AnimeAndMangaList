using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeAndMangaList
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnAddManga_Click(object sender, EventArgs e)
        {
            FrmManga FrmManga = new FrmManga();
            FrmManga.Show();
        }

        private void btnAddAnime_Click_1(object sender, EventArgs e)
        {
            FrmAnime FrmAnime = new FrmAnime();
            FrmAnime.Show();
        }
    }
}
