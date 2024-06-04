using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Diagnostics;
namespace AnimeAndMangaList
{
    public partial class FrmManga : Form
    {
        Manga[] mangas;
        public FrmManga()
        {
            InitializeComponent();
            mangas = new Manga[30];
        }

        private void btnSaveManga_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                    string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                    string.IsNullOrWhiteSpace(cbGenre.Text) ||
                    string.IsNullOrWhiteSpace(txtChapters.Text) ||
                    string.IsNullOrWhiteSpace(cbEditorial.Text))
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

                int emptyIndex = -1;
                for (int i = 0; i < mangas.Length; i++)
                {
                    if (mangas[i] == null)
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
                        for (int i = 0; i < mangas.Length; i++)
                        {
                            mangas[i] = null;
                        }
                        lstvDataManga.Items.Clear();

                        emptyIndex = 0;
                    }
                    else
                    {
                        return;
                    }
                }

                mangas[emptyIndex] = new Manga(
                    txtTitle.Text,
                    txtAuthor.Text,
                    cbGenre.Text,
                    dtpDate.Value,
                    Convert.ToInt32(txtChapters.Text),
                    cbEditorial.Text,
                    Convert.ToInt32(nudRating.Value)
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
                int numberItemsSelected = lstvDataManga.SelectedItems.Count;
                int[] selectedIndices = new int[lstvDataManga.SelectedItems.Count];

                for (int i = 0; i < numberItemsSelected; i++)
                {
                    selectedIndices[i] = lstvDataManga.SelectedItems[i].Index;
                }

                Array.Sort(selectedIndices);
                Array.Reverse(selectedIndices);
                    
                for (int i = 0; i < numberItemsSelected; i++)
                {
                    lstvDataManga.Items.RemoveAt(selectedIndices[i]);
                }

                Manga[] updatedMangas = new Manga[mangas.Length - numberItemsSelected];

                int newIndex = 0;
                for (int i = 0; i < mangas.Length; i++)
                {
                    if (Array.IndexOf(selectedIndices, i) == -1)
                    {
                        updatedMangas[newIndex++] = mangas[i];
                    }
                }

                mangas = updatedMangas;

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
                    try
                    {
                        string[] lines = File.ReadAllLines(filePath);

                        foreach (string line in lines)
                        {
                            string[] fields = line.Split('|');
                            int emptyIndex = -1;
                            for (int i = 0; i < mangas.Length; i++)
                            {
                                if (mangas[i] == null)
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

                            mangas[emptyIndex] = new Manga(
                                fields[0],
                                fields[1],
                                fields[2],
                                DateTime.Parse(fields[3]),
                                Convert.ToInt32(fields[4]),
                                fields[5],
                                Convert.ToInt32(fields[6])
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
                            ExportMangaToJson(filePath);
                            break;
                        case ".xml":
                            ExportMangaToXml(filePath);
                            break;
                        case ".xlsx":
                            ExportMangaToExcel(filePath);
                            break;
                        case ".docx":
                            ExportMangaToWord(filePath);
                            break;
                        case ".txt":
                            ExportMangaToTxt(filePath);
                            break;
                        default:
                            MessageBox.Show("Unsupported file format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    MessageBox.Show("Data exported successfully to " + filePath, "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExportMangaToJson(string filePath)
        {
            Manga[] filteredMangas = Array.FindAll(mangas, m => m != null);
            string json = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);

            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void ExportMangaToXml(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Mangas");
            doc.AppendChild(root);

            foreach (Manga manga in mangas.Where(m => m != null))
            {
                XmlElement mangaElement = doc.CreateElement("Manga");

                XmlElement titleElement = doc.CreateElement("Title");
                titleElement.InnerText = manga.Title;
                mangaElement.AppendChild(titleElement);

                XmlElement authorElement = doc.CreateElement("Author");
                authorElement.InnerText = manga.Author;
                mangaElement.AppendChild(authorElement);

                XmlElement genreElement = doc.CreateElement("Genre");
                genreElement.InnerText = manga.Genre;
                mangaElement.AppendChild(genreElement);

                XmlElement releaseYearElement = doc.CreateElement("ReleaseYear");
                releaseYearElement.InnerText = manga.ReleaseYear.ToShortDateString();
                mangaElement.AppendChild(releaseYearElement);

                XmlElement volumeElement = doc.CreateElement("Volume");
                volumeElement.InnerText = manga.Volume.ToString();
                mangaElement.AppendChild(volumeElement);

                XmlElement editorialElement = doc.CreateElement("Editorial");
                editorialElement.InnerText = manga.Editorial;
                mangaElement.AppendChild(editorialElement);

                XmlElement ratingElement = doc.CreateElement("Rating");
                ratingElement.InnerText = manga.Rating.ToString();
                mangaElement.AppendChild(ratingElement);

                XmlElement priceElement = doc.CreateElement("Price");
                priceElement.InnerText = manga.Price.ToString();
                mangaElement.AppendChild(priceElement);

                root.AppendChild(mangaElement);
            }

            doc.Save(filePath);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });

        }
        private void ExportMangaToExcel(string filePath)
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("Mangas");

                worksheet.Cell(1, 1).Value = "Title";
                worksheet.Cell(1, 2).Value = "Author";
                worksheet.Cell(1, 3).Value = "Genre";
                worksheet.Cell(1, 4).Value = "ReleaseYear";
                worksheet.Cell(1, 5).Value = "Volume";
                worksheet.Cell(1, 6).Value = "Editorial";
                worksheet.Cell(1, 7).Value = "Rating";
                worksheet.Cell(1, 8).Value = "Price";

                int rowIndex = 2;

                foreach (Manga manga in mangas.Where(m => m != null))
                {
                    worksheet.Cell(rowIndex, 1).Value = manga.Title;
                    worksheet.Cell(rowIndex, 2).Value = manga.Author;
                    worksheet.Cell(rowIndex, 3).Value = manga.Genre;
                    worksheet.Cell(rowIndex, 4).Value = manga.ReleaseYear.ToShortDateString();
                    worksheet.Cell(rowIndex, 5).Value = manga.Volume;
                    worksheet.Cell(rowIndex, 6).Value = manga.Editorial;
                    worksheet.Cell(rowIndex, 7).Value = manga.Rating;
                    worksheet.Cell(rowIndex, 8).Value = manga.Price;

                    rowIndex++;
                }

                workbook.SaveAs(filePath);
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }


        private void ExportMangaToWord(string filePath)
        {
            using (DocX document = DocX.Create(filePath))
            {
                document.InsertParagraph("Manga List").FontSize(15).Bold().Alignment = Alignment.center;

                int mangaCount = mangas.Count(m => m != null);
                Table table = document.AddTable(mangaCount + 1, 8);

                table.Rows[0].Cells[0].Paragraphs[0].Append("Title");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Author");
                table.Rows[0].Cells[2].Paragraphs[0].Append("Genre");
                table.Rows[0].Cells[3].Paragraphs[0].Append("ReleaseYear");
                table.Rows[0].Cells[4].Paragraphs[0].Append("Volume");
                table.Rows[0].Cells[5].Paragraphs[0].Append("Editorial");
                table.Rows[0].Cells[6].Paragraphs[0].Append("Rating");
                table.Rows[0].Cells[7].Paragraphs[0].Append("Price");

                int rowIndex = 1;
                foreach (Manga manga in mangas.Where(m => m != null))
                {
                    table.Rows[rowIndex].Cells[0].Paragraphs[0].Append(manga.Title);
                    table.Rows[rowIndex].Cells[1].Paragraphs[0].Append(manga.Author);
                    table.Rows[rowIndex].Cells[2].Paragraphs[0].Append(manga.Genre);
                    table.Rows[rowIndex].Cells[3].Paragraphs[0].Append(manga.ReleaseYear.ToShortDateString());
                    table.Rows[rowIndex].Cells[4].Paragraphs[0].Append(manga.Volume.ToString());
                    table.Rows[rowIndex].Cells[5].Paragraphs[0].Append(manga.Editorial);
                    table.Rows[rowIndex].Cells[6].Paragraphs[0].Append(manga.Rating.ToString());
                    table.Rows[rowIndex].Cells[7].Paragraphs[0].Append(manga.Price.ToString());
                    rowIndex++;
                }

                document.InsertTable(table);
                document.Save();
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void ExportMangaToTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Manga manga in mangas.Where(m => m != null))
                {
                    writer.WriteLine(manga.ToString());
                }
            }
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void btnGetStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Manga.GetStatsManga(mangas),"Stats",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSimilarManga_Click(object sender, EventArgs e)
        {
            if (lstvDataManga.SelectedIndices.Count ==1)
            {
                MessageBox.Show(mangas[lstvDataManga.SelectedIndices[0]].ShowSimilarWorks(),"Similar Mangas",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (lstvDataManga.SelectedIndices.Count>1)
            {
                MessageBox.Show("You can only select one manga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No manga has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
