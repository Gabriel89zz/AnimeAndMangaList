using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Data;
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Diagnostics;


namespace AnimeAndMangaList
{
    public partial class FrmAnime : Form
    {
        Anime[] animes;
        public FrmAnime()
        {
            InitializeComponent();
            animes = new Anime[50];
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


                int emptyIndex = -1;
                for (int i = 0; i < animes.Length; i++)
                {
                    if (animes[i] == null)
                    {
                        emptyIndex = i;
                        break;
                    }
                }

                if (emptyIndex == -1)
                {
                    DialogResult result = MessageBox.Show("The array is full. Do you want to delete all entries to add new ones?",
                                                          "Array Full", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        // Clear the array
                        for (int i = 0; i < animes.Length; i++)
                        {
                            animes[i] = null;
                        }

                        // Clear the ListView
                        lstvDataAnime.Items.Clear();

                        // Set the emptyIndex to 0 since the array is now empty
                        emptyIndex = 0;
                    }
                    else
                    {
                        return;
                    }
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
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);

                        foreach (string line in lines)
                        {
                            string[] fields = line.Split('|');
                            int emptyIndex = -1;
                            for (int i = 0; i < animes.Length; i++)
                            {
                                if (animes[i] == null)
                                {
                                    emptyIndex = i;
                                    break;
                                }
                            }

                            if (emptyIndex == -1)
                            {
                                MessageBox.Show("The array is full. You need to delete some entries to add new ones.", "Array Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            animes[emptyIndex] = new Anime(
                            fields[0],
                            fields[1],
                            fields[2],
                            DateTime.Parse(fields[3]),
                            Convert.ToInt32(fields[4]),
                            fields[5],
                            fields[6],
                            Convert.ToInt32(fields[7])
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
                        }

                        MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                            ExportAnimeToJson(filePath);
                            break;
                        case ".xml":
                            ExportAnimeToXml(filePath);
                            break;
                        case ".xlsx":
                            ExportAnimeToExcel(filePath);
                            break;
                        case ".docx":
                            ExportAnimeToWord(filePath);
                            break;
                        case ".txt":
                            ExportAnimeToTxt(filePath);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportAnimeToJson(string filePath)
        {
            Anime[] filteredMangas = Array.FindAll(animes, m => m != null);
            string json = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void ExportAnimeToXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Animes");
            doc.AppendChild(root);

            foreach (Anime anime in animes.Where(m => m != null))
            {
                XmlElement animeElement = doc.CreateElement("Anime");

                XmlElement titleElement = doc.CreateElement("Title");
                titleElement.InnerText = anime.Title;
                animeElement.AppendChild(titleElement);

                XmlElement authorElement = doc.CreateElement("Author");
                authorElement.InnerText = anime.Author;
                animeElement.AppendChild(authorElement);

                XmlElement genreElement = doc.CreateElement("Genre");
                genreElement.InnerText = anime.Genre;
                animeElement.AppendChild(genreElement);

                XmlElement releaseYearElement = doc.CreateElement("ReleaseYear");
                releaseYearElement.InnerText = anime.ReleaseYear.ToShortDateString();
                animeElement.AppendChild(releaseYearElement);

                XmlElement numberOfSeasonsElements = doc.CreateElement("NumberofChapters");
                numberOfSeasonsElements.InnerText = anime.NumberOfSeasons.ToString();
                animeElement.AppendChild(numberOfSeasonsElements);

                XmlElement editorialElement = doc.CreateElement("Platform");
                editorialElement.InnerText = anime.Platform;
                animeElement.AppendChild(editorialElement);

                XmlElement ratingElement = doc.CreateElement("Rating");
                ratingElement.InnerText = anime.Rating.ToString();
                animeElement.AppendChild(ratingElement);

                XmlElement priceElement = doc.CreateElement("ProductionStudio");
                priceElement.InnerText = anime.ProductionStudio.ToString();
                animeElement.AppendChild(priceElement);

                root.AppendChild(animeElement);
            }

            doc.Save(filePath);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void ExportAnimeToExcel(string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Animes");

                worksheet.Cell(1, 1).Value = "Title";
                worksheet.Cell(1, 2).Value = "Author";
                worksheet.Cell(1, 3).Value = "Genre";
                worksheet.Cell(1, 4).Value = "ReleaseYear";
                worksheet.Cell(1, 5).Value = "Number of Chapters";
                worksheet.Cell(1, 6).Value = "Platform";
                worksheet.Cell(1, 7).Value = "Rating";
                worksheet.Cell(1, 8).Value = "Production Studio";

                int rowIndex = 2;

                foreach (Anime anime in animes.Where(m => m != null))
                {
                    worksheet.Cell(rowIndex, 1).Value = anime.Title;
                    worksheet.Cell(rowIndex, 2).Value = anime.Author;
                    worksheet.Cell(rowIndex, 3).Value = anime.Genre;
                    worksheet.Cell(rowIndex, 4).Value = anime.ReleaseYear.ToShortDateString();
                    worksheet.Cell(rowIndex, 5).Value = anime.NumberOfSeasons;
                    worksheet.Cell(rowIndex, 6).Value = anime.Platform;
                    worksheet.Cell(rowIndex, 7).Value = anime.Rating;
                    worksheet.Cell(rowIndex, 8).Value = anime.ProductionStudio;

                    rowIndex++;
                }

                workbook.SaveAs(filePath);
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }


        private void ExportAnimeToWord(string filePath)
        {
            using (DocX document = DocX.Create(filePath))
            {
                document.InsertParagraph("Anime List").FontSize(15).Bold().Alignment = Alignment.center;

                int animeCount = animes.Count(m => m != null);
                Table table = document.AddTable(animeCount + 1, 8);

                table.Rows[0].Cells[0].Paragraphs[0].Append("Title");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Author");
                table.Rows[0].Cells[2].Paragraphs[0].Append("Genre");
                table.Rows[0].Cells[3].Paragraphs[0].Append("ReleaseYear");
                table.Rows[0].Cells[4].Paragraphs[0].Append("Number of Chapters");
                table.Rows[0].Cells[5].Paragraphs[0].Append("Platform");
                table.Rows[0].Cells[6].Paragraphs[0].Append("Rating");
                table.Rows[0].Cells[7].Paragraphs[0].Append("Production Studio");

                int rowIndex = 1;
                foreach (Anime manga in animes.Where(m => m != null))
                {
                    table.Rows[rowIndex].Cells[0].Paragraphs[0].Append(manga.Title);
                    table.Rows[rowIndex].Cells[1].Paragraphs[0].Append(manga.Author);
                    table.Rows[rowIndex].Cells[2].Paragraphs[0].Append(manga.Genre);
                    table.Rows[rowIndex].Cells[3].Paragraphs[0].Append(manga.ReleaseYear.ToShortDateString());
                    table.Rows[rowIndex].Cells[4].Paragraphs[0].Append(manga.NumberOfSeasons.ToString());
                    table.Rows[rowIndex].Cells[5].Paragraphs[0].Append(manga.Platform);
                    table.Rows[rowIndex].Cells[6].Paragraphs[0].Append(manga.Rating.ToString());
                    table.Rows[rowIndex].Cells[7].Paragraphs[0].Append(manga.ProductionStudio);
                    rowIndex++;
                }

                document.InsertTable(table);
                document.Save();
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void ExportAnimeToTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Anime anime in animes.Where(m => m != null))
                {
                    writer.WriteLine(anime.ToString());
                }
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }


        private void btnDeleteAnime_Click(object sender, EventArgs e)
        {
            if (lstvDataAnime.SelectedItems.Count > 0)
            {
                int numberItemsSelected = lstvDataAnime.SelectedItems.Count;
                int[] selectedIndices = new int[lstvDataAnime.SelectedItems.Count];

                for (int i = 0; i < numberItemsSelected; i++)
                {
                    selectedIndices[i] = lstvDataAnime.SelectedItems[i].Index;
                }

                Array.Sort(selectedIndices);
                Array.Reverse(selectedIndices);

                for (int i = 0; i < numberItemsSelected; i++)
                {
                    lstvDataAnime.Items.RemoveAt(selectedIndices[i]);
                }

                Anime[] updatedAnimes = new Anime[animes.Length - numberItemsSelected];

                int newIndex = 0;
                for (int i = 0; i < animes.Length; i++)
                {
                    if (Array.IndexOf(selectedIndices, i) == -1)
                    {
                        updatedAnimes[newIndex++] = animes[i];
                    }
                }

                animes = updatedAnimes;

                MessageBox.Show("Selected animes have been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a anime to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGetStatsAnime_Click(object sender, EventArgs e)
        {
            Anime.GetStatsAnime(animes);
        }

        private void btnSaveReviewAnime_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Title = "Save Review Anime File";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog1.FileName;

                    File.WriteAllText(filePath, txtReviewAnime.Text);

                    MessageBox.Show("Review saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the review: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimilarAnimes_Click(object sender, EventArgs e)
        {
            if (lstvDataAnime.SelectedIndices.Count > 0)
            {
                MessageBox.Show(animes[lstvDataAnime.SelectedIndices[0]].ShowSimilarWorks(), "Similar Mangas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No manga has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
