namespace AnimeAndMangaList
{
    public partial class FrmManga : Form
    {
        Manga[] mangas;

        public FrmManga()
        {
            InitializeComponent();
            mangas = new Manga[50];
            cbGenre.DataSource = Manga.GetMangaGenres();
        }

        private void btnSaveManga_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                    string.IsNullOrWhiteSpace(cbGenre.Text) ||
                    string.IsNullOrWhiteSpace(txtChapters.Text) ||
                    string.IsNullOrWhiteSpace(cbEditorial.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("All fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpDate.Value > DateTime.Now)
                {
                    MessageBox.Show("The selected date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtChapters.Text, out int chapters) || chapters < 0)
                {
                    MessageBox.Show("Chapters must be a non-negative integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtPrice.Text, out double price) || price < 0)
                {
                    MessageBox.Show("Check that the price does not contain letters and that it does not contain a negative value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int emptyIndex = Array.FindIndex(mangas, m => m == null);

                if (emptyIndex == -1)
                {
                    MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                mangas[emptyIndex] = new Manga(
                    txtTitle.Text,
                    txtAuthor.Text,
                    cbGenre.Text,
                    dtpDate.Value,
                    Convert.ToInt32(txtChapters.Text),
                    cbEditorial.Text,
                    Convert.ToInt32(nudRating.Value),
                    Convert.ToDouble(txtPrice.Text)
                );

                ListViewItem item = new ListViewItem(mangas[emptyIndex].Title);
                item.SubItems.Add(mangas[emptyIndex].Author);
                item.SubItems.Add(mangas[emptyIndex].Genre);
                item.SubItems.Add(mangas[emptyIndex].ReleaseYear.ToShortDateString());
                item.SubItems.Add(mangas[emptyIndex].Volume.ToString());
                item.SubItems.Add(mangas[emptyIndex].Editorial);
                item.SubItems.Add(mangas[emptyIndex].Rating.ToString());
                item.SubItems.Add(mangas[emptyIndex].Price.ToString());

                lstvDataManga.Items.Add(item);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO QUE NO RECIBE NI REGRESA
        private void ClearInputs()
        {
            txtAuthor.Text = "";
            txtChapters.Text = "";
            cbGenre.Text = "";
            txtPrice.Text = "";
            txtTitle.Text = "";
            nudRating.Value = 0;
            dtpDate.Value = DateTime.Now;
            cbEditorial.Text = "";
        }

        private void btnSaveReview_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Title = "Save Review File";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;

                    File.WriteAllText(filePath, txtReview.Text);

                    MessageBox.Show("Review saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the review: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteManga_Click(object sender, EventArgs e)
        {
            if (lstvDataManga.SelectedItems.Count > 0)
            {
                for (int i = lstvDataManga.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem selectedManga = lstvDataManga.SelectedItems[i];
                    int selectedIndex = selectedManga.Index;
                    lstvDataManga.Items.RemoveAt(selectedIndex);
                    mangas[selectedIndex] = null;
                }

                MessageBox.Show("Selected mangas have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a manga to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TXT files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Manga.LoadMangaDataFromTextFile(filePath, mangas, lstvDataManga);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
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
                            Manga.ExportMangaToJson(filePath, mangas);
                            break;
                        case ".xml":
                            Manga.ExportMangaToXml(filePath, mangas);
                            break;
                        case ".xlsx":
                            Manga.ExportMangaToExcel(filePath, mangas);
                            break;
                        case ".docx":
                            Manga.ExportMangaToWord(filePath, mangas);
                            break;
                        case ".txt":
                            Manga.ExportMangaToTxt(filePath, mangas);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGetStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Manga.GetStats(mangas));
        }
    }
}
