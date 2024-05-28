namespace AnimeAndMangaList
{
    public partial class Form1 : Form
    {
        Manga[] mangas;
        Anime[,] animeMatriz;
        int row;
        int column;
        public Form1()
        {
            InitializeComponent();
            mangas = new Manga[100];
            row = 0;
            column = 0;
            animeMatriz = new Anime[10, 10];

            txtAuthor.Visible = false;
            txtChapters.Visible = false;
            nudRating.Visible = false;
            txtPrice.Visible = false;
            dtpDate.Visible = false;
            txtTitle.Visible = false;
            cbGenre.Visible = false;
            cbEditorial.Visible = false;

            lblAuthor.Visible = false;
            lblChapters.Visible = false;
            lblRating.Visible = false;
            lblPrice.Visible = false;
            lblDate.Visible = false;
            lblTitle.Visible = false;
            lblGenre.Visible = false;
            lblEditorial.Visible = false;
            lblAddReview.Visible = false;

            lstvData.Visible = false;
            btnSaveManga.Visible = false;
            btnCalculateCost.Visible = false;
            btnDeleteManga.Visible = false;
            btnSaveAnime.Visible = false;
            btnExport.Visible = false;
            txtReview.Visible = false;
            btnSaveReview.Visible = false;
            btnLoadData.Visible = false;
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

                lstvData.Items.Add(item);
                ClearTxts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            if (btnAddAnime.Visible == true)
            {
                MessageBox.Show("The cost of your manga collection is: " + Manga.GetCollectionCost(mangas) + " MXN", "Cost of Collection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TVShow.CalulateCostSubscription(animeMatriz);
            }
        }

        private void ShowLabelsAndButtons()
        {
            txtAuthor.Visible = true;
            txtChapters.Visible = true;
            nudRating.Visible = true;
            txtPrice.Visible = true;
            dtpDate.Visible = true;
            txtTitle.Visible = true;
            cbGenre.Visible = true;
            lblAuthor.Visible = true;
            lblChapters.Visible = true;
            lblRating.Visible = true;
            lblPrice.Visible = true;
            lblDate.Visible = true;
            lblTitle.Visible = true;
            lblGenre.Visible = true;
            lblEditorial.Visible = true;
            cbEditorial.Visible = true;
            lstvData.Visible = true;
            btnCalculateCost.Visible = true;
            btnDeleteManga.Visible = true;
            btnExport.Visible = true;
            lblAddReview.Visible = true;
            txtReview.Visible = true;
            btnSaveReview.Visible = true;
            btnLoadData.Visible = true;
            lstvData.View = System.Windows.Forms.View.Details;
            lstvData.Columns.Add("Title", 100);
            lstvData.Columns.Add("Author", 100);
            lstvData.Columns.Add("Genre", 100);
            lstvData.Columns.Add("Date", 100);
            String[]MangaGenres = Manga.GetMangaGenres();
            cbGenre.DataSource = MangaGenres;
        }

        //METODO QUE NO RECIBE NI REGRESA
        private void ClearTxts()
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

        private void btnAddManga_Click(object sender, EventArgs e)
        {
            lstvData.Items.Clear();
            lstvData.Columns.Clear();
            ShowLabelsAndButtons();
            lstvData.Columns.Add("Volume", 100);
            lstvData.Columns.Add("Editorial", 100);
            lstvData.Columns.Add("Rating", 100);
            lblChapters.Text = "Volume:";
            lblEditorial.Text = "Editorial:";
            lblPrice.Text = "Price:";
            lblDate.Text = "Acquisition Date:";
            btnSaveManga.Visible = true;
            btnSaveAnime.Visible = false;
            btnAddManga.Visible = false;
            btnAddAnime.Visible = true;
            cbEditorial.Items.Clear();
            cbEditorial.Items.AddRange(new object[] { "Panini", "Ivrea", "Norma", "Kamite" });
            ClearTxts();
        }


        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            lstvData.Items.Clear();
            lstvData.Columns.Clear();
            ShowLabelsAndButtons();
            lstvData.Columns.Add("Number of Seasons", 100);
            lstvData.Columns.Add("Production Studio", 100);
            lstvData.Columns.Add("Platform", 100);
            lstvData.Columns.Add("Rating", 100);
            lblChapters.Text = "Number of Seasons:";
            lblEditorial.Text = "Platform:";
            lblPrice.Text = "Production Studio:";
            lblDate.Text = "Viewed date:";
            btnSaveAnime.Visible = true;
            btnSaveManga.Visible = false;
            btnAddAnime.Visible = false;
            btnAddManga.Visible = true;
            cbEditorial.Items.Clear();
            cbEditorial.Items.AddRange(new object[] { "Crunchyroll", "Netflix", "Prime Video", "Disney Plus" });
            ClearTxts();
        }

        private void btnSaveAnime_Click(object sender, EventArgs e)
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

                if (!int.TryParse(txtChapters.Text, out int episodes) || episodes < 0)
                {
                    MessageBox.Show("Episodes must be a non-negative integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                bool added = false;
                for (row = 0; row < animeMatriz.GetLength(0); row++)
                {
                    for (column = 0; column < animeMatriz.GetLength(1); column++)
                    {
                        if (animeMatriz[row, column] == null)
                        {
                            animeMatriz[row, column] = new Anime(
                                       txtTitle.Text,
                                       txtAuthor.Text,
                                       cbGenre.Text,
                                       dtpDate.Value,
                                       Convert.ToInt32(txtChapters.Text),
                                       txtPrice.Text,
                                       cbEditorial.Text,
                                       Convert.ToInt32(nudRating.Value)
                           );

                            ListViewItem item = new ListViewItem(animeMatriz[row, column].Title);
                            item.SubItems.Add(animeMatriz[row, column].Author);
                            item.SubItems.Add(animeMatriz[row, column].Genre);
                            item.SubItems.Add(animeMatriz[row, column].ReleaseYear.ToShortDateString());
                            item.SubItems.Add(animeMatriz[row, column].NumberOfSeasons.ToString());
                            item.SubItems.Add(animeMatriz[row, column].ProductionStudio);
                            item.SubItems.Add(animeMatriz[row, column].Platform.ToString());
                            item.SubItems.Add(animeMatriz[row, column].Rating.ToString());

                            lstvData.Items.Add(item);
                            ClearTxts();
                            added = true;
                            break;
                        }
                    }
                    if (added)
                    {
                        break;
                    }
                }

                if (!added)
                {
                    MessageBox.Show("The matrix is full. You need to delete some entries to add new ones.", "Matrix Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteManga_Click(object sender, EventArgs e)
        {
            if (btnAddAnime.Visible == true)
            {
                if (lstvData.SelectedItems.Count > 0)
                {
                    List<int> indicesToRemove = new List<int>();
                    foreach (ListViewItem item in lstvData.SelectedItems)
                    {
                        indicesToRemove.Add(item.Index);
                    }

                    indicesToRemove.Sort();
                    indicesToRemove.Reverse();

                    foreach (int selectedIndex in indicesToRemove)
                    {
                        lstvData.Items.RemoveAt(selectedIndex);
                        mangas[selectedIndex] = null;
                    }

                    MessageBox.Show("Selected mangas have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select a manga to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (lstvData.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem selectedItem in lstvData.SelectedItems)
                    {
                        int selectedIndex = selectedItem.Index;
                        lstvData.Items.RemoveAt(selectedIndex);

                        int rowToDelete = selectedIndex / animeMatriz.GetLength(1);
                        int columnToDelete = selectedIndex % animeMatriz.GetLength(1);

                        if (rowToDelete < animeMatriz.GetLength(0) && columnToDelete < animeMatriz.GetLength(1))
                        {
                            animeMatriz[rowToDelete, columnToDelete] = null;
                        }
                        else
                        {
                            MessageBox.Show("Error: Selected index out of range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    MessageBox.Show("Selected animes have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (btnAddAnime.Visible == true)
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
                                Manga.ExportMangaToJson(filePath,mangas);
                                break;
                            case ".xml":
                                Manga.ExportMangaToXml(filePath,mangas);
                                break;
                            case ".xlsx":
                                Manga.ExportMangaToExcel(filePath,mangas);
                                break;
                            case ".docx":
                                Manga.ExportMangaToWord(filePath,mangas);
                                break;
                            case ".txt":
                                Manga.ExportMangaToTxt(filePath,mangas);
                                break;
                            default:
                                MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            else
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
                                Anime.ExportAnimeToJson(filePath,animeMatriz);
                                break;
                            case ".xml":
                                Anime.ExportAnimeToXml(filePath,animeMatriz);
                                break;
                            case ".xlsx":
                                Anime.ExportAnimeToExcel(filePath, animeMatriz);
                                break;
                            case ".docx":
                                Anime.ExportAnimeToWord(filePath, animeMatriz);
                                break;
                            case ".txt":
                                Anime.ExportAnimeToTxt(filePath, animeMatriz);
                                break;
                            default:
                                MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TXT files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (btnAddAnime.Visible==true)
                    {
                        Manga.LoadMangaDataFromTextFile(filePath, mangas,lstvData);
                    }
                    else
                    {
                        Anime.LoadAnimeDataFromTextFile(filePath,animeMatriz,lstvData);
                    }
                }
            }
        }

       
    }
}
