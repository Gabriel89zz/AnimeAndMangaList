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
    public partial class FrmAnime : Form
    {
        Anime[] animes;
        public FrmAnime()
        {
            InitializeComponent();
            animes = new Anime[50];
            cbGenreAnime.DataSource = Manga.GetMangaGenres();
        }

        private void btnSaveAnime_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitleAnime.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthorAnime.Text) ||
                    string.IsNullOrWhiteSpace(cbGenreAnime.Text) ||
                    string.IsNullOrWhiteSpace(txtChaptersAnime.Text) ||
                    string.IsNullOrWhiteSpace(cbPlataform.Text) ||
                    string.IsNullOrWhiteSpace(txtProductionStudio.Text))
                {
                    MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpDateAnime.Value > DateTime.Now)
                {
                    MessageBox.Show("The selected date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtChaptersAnime.Text, out int chapters) || chapters < 0)
                {
                    MessageBox.Show("Chapters must be a non-negative integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int emptyIndex = Array.FindIndex(animes, m => m == null);

                if (emptyIndex == -1)
                {
                    MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                animes[emptyIndex] = new Anime(
                    txtTitleAnime.Text,
                    txtAuthorAnime.Text,
                    cbGenreAnime.Text,
                    dtpDateAnime.Value,
                    Convert.ToInt32(txtChaptersAnime.Text),
                    txtProductionStudio.Text,
                    cbPlataform.Text,
                    Convert.ToInt32(nudRatingAnime.Value)
                );

                ListViewItem item = new ListViewItem(animes[emptyIndex].Title);
                item.SubItems.Add(animes[emptyIndex].Author);
                item.SubItems.Add(animes[emptyIndex].Genre);
                item.SubItems.Add(animes[emptyIndex].ReleaseYear.ToShortDateString());
                item.SubItems.Add(animes[emptyIndex].NumberOfSeasons.ToString());
                item.SubItems.Add(animes[emptyIndex].ProductionStudio);
                item.SubItems.Add(animes[emptyIndex].Platform);
                item.SubItems.Add(animes[emptyIndex].Rating.ToString());

                lstvDataAnime.Items.Add(item);
                ClearInputsAnime();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputsAnime()
        {
            txtAuthorAnime.Text = "";
            txtChaptersAnime.Text = "";
            cbPlataform.Text = "";
            txtProductionStudio.Text = "";
            txtTitleAnime.Text = "";
            nudRatingAnime.Value = 0;
            dtpDateAnime.Value = DateTime.Now;
        }
        private void btnLoadDataAnime_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TXT files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Anime.LoadAnimeDataFromTextFile(filePath, animes, lstvDataAnime);
                }
            }
        }

        private void btnExportAnime_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files|*.json|XML Files|*.xml|Excel Files|*.xlsx|Word Files|*.docx|Text Files|*.txt";
                sfd.Title = "Save an Export File";
                sfd.FileName = "ExportedData";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;
                    string extension = Path.GetExtension(filePath);

                    switch (extension.ToLower())
                    {
                        case ".json":
                            Anime.ExportAnimeToJson(filePath, animes);
                            break;
                        case ".xml":
                            Anime.ExportAnimeToXml(filePath, animes);
                            break;
                        case ".xlsx":
                            Anime.ExportAnimeToExcel(filePath, animes);
                            break;
                        case ".docx":
                            Anime.ExportAnimeToWord(filePath, animes);
                            break;
                        case ".txt":
                            Anime.ExportAnimeToTxt(filePath, animes);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDeleteAnime_Click(object sender, EventArgs e)
        {
            if (lstvDataAnime.SelectedItems.Count > 0)
            {
                for (int i = lstvDataAnime.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem selectedAnime = lstvDataAnime.SelectedItems[i];
                    int selectedIndex = selectedAnime.Index;
                    lstvDataAnime.Items.RemoveAt(selectedIndex);
                    animes[selectedIndex] = null;
                }

                MessageBox.Show("Selected animes have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a anime to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetStatsAnime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Anime.GetStatsAnime(animes));
        }
    }
}
