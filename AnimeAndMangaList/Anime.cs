using Newtonsoft.Json;
using ClosedXML.Excel;
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace AnimeAndMangaList
{
    internal class Anime:TVShow,IJapaneseWorks
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
        }

        private string genre;
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        private DateTime releaseyear;
        public DateTime ReleaseYear
        {
            get { return releaseyear; }
        }

        private int rating;
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public Anime() : base()
        {
            title = "";
            author = "";
            genre = "";
            releaseyear = DateTime.MinValue;
            rating = 0;
        }

        public Anime(string title, string autor, string genre, DateTime releaseyear, int numberofseasons, string production, string platform,int rating) : base(production, numberofseasons,platform)
        {
            this.title = title;
            this.author = autor;
            this.genre = genre;
            this.releaseyear = releaseyear;
            this.rating = rating;
        }

        public override string ToString()
        {
            return "Title: " + title + ", Author: " + author + ", Genre: " + genre + ", Release Date: " + releaseyear + ", Number of Seasons: " + numberofseasons + ", Production Studio: " + productionstudio + ", Platform: " + platform + ", Rating:" + rating ;
        }

        public static void ExportAnimeToJson(string filePath,Anime[,]animeMatriz)
        {
            List<Anime> animeList = new List<Anime>();
            foreach (var anime in animeMatriz)
            {
                if (anime != null)
                {
                    animeList.Add(anime);
                }
            }
            string json = JsonConvert.SerializeObject(animeList, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void ExportAnimeToXml(string filePath, Anime[,] animeMatriz)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Animes");
            doc.AppendChild(root);

            for (int row = 0; row < animeMatriz.GetLength(0); row++)
            {
                for (int col = 0; col < animeMatriz.GetLength(1); col++)
                {
                    if (animeMatriz[row, col] != null)
                    {
                        XmlElement animeElement = doc.CreateElement("Anime");

                        XmlElement titleElement = doc.CreateElement("Title");
                        titleElement.InnerText = animeMatriz[row, col].Title;
                        animeElement.AppendChild(titleElement);

                        XmlElement authorElement = doc.CreateElement("Author");
                        authorElement.InnerText = animeMatriz[row, col].Author;
                        animeElement.AppendChild(authorElement);

                        XmlElement genreElement = doc.CreateElement("Genre");
                        genreElement.InnerText = animeMatriz[row, col].Genre;
                        animeElement.AppendChild(genreElement);

                        XmlElement releaseYearElement = doc.CreateElement("ReleaseYear");
                        releaseYearElement.InnerText = animeMatriz[row, col].ReleaseYear.ToShortDateString();
                        animeElement.AppendChild(releaseYearElement);

                        XmlElement numberOfSeasonsElement = doc.CreateElement("NumberOfSeasons");
                        numberOfSeasonsElement.InnerText = animeMatriz[row, col].NumberOfSeasons.ToString();
                        animeElement.AppendChild(numberOfSeasonsElement);

                        XmlElement platformElement = doc.CreateElement("Platform");
                        platformElement.InnerText = animeMatriz[row, col].Platform;
                        animeElement.AppendChild(platformElement);

                        XmlElement productionStudioElement = doc.CreateElement("ProductionStudio");
                        productionStudioElement.InnerText = animeMatriz[row, col].ProductionStudio;
                        animeElement.AppendChild(productionStudioElement);

                        XmlElement ratingElement = doc.CreateElement("Rating");
                        ratingElement.InnerText = animeMatriz[row, col].Rating.ToString();
                        animeElement.AppendChild(ratingElement);

                        root.AppendChild(animeElement);
                    }
                }
            }

            doc.Save(filePath);
        }

        public static void ExportAnimeToExcel(string filePath, Anime[,] animeMatriz)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Animes");

                worksheet.Cell(1, 1).Value = "Title";
                worksheet.Cell(1, 2).Value = "Author";
                worksheet.Cell(1, 3).Value = "Genre";
                worksheet.Cell(1, 4).Value = "ReleaseYear";
                worksheet.Cell(1, 5).Value = "NumberOfSeasons";
                worksheet.Cell(1, 6).Value = "Platform";
                worksheet.Cell(1, 7).Value = "ProductionStudio";
                worksheet.Cell(1, 8).Value = "Rating";

                int row = 2;
                for (int i = 0; i < animeMatriz.GetLength(0); i++)
                {
                    for (int j = 0; j < animeMatriz.GetLength(1); j++)
                    {
                        if (animeMatriz[i, j] != null)
                        {
                            worksheet.Cell(row, 1).Value = animeMatriz[i, j].Title;
                            worksheet.Cell(row, 2).Value = animeMatriz[i, j].Author;
                            worksheet.Cell(row, 3).Value = animeMatriz[i, j].Genre;
                            worksheet.Cell(row, 4).Value = animeMatriz[i, j].ReleaseYear.ToShortDateString();
                            worksheet.Cell(row, 5).Value = animeMatriz[i, j].NumberOfSeasons;
                            worksheet.Cell(row, 6).Value = animeMatriz[i, j].Platform;
                            worksheet.Cell(row, 7).Value = animeMatriz[i, j].ProductionStudio;
                            worksheet.Cell(row, 8).Value = animeMatriz[i, j].Rating.ToString();
                            row++;
                        }
                    }
                }

                workbook.SaveAs(filePath);
            }
        }


        public static void ExportAnimeToWord(string filePath, Anime[,] animeMatriz)
        {
            using (var document = DocX.Create(filePath))
            {
                document.InsertParagraph("Anime List").FontSize(15).Bold().Alignment = Alignment.center;
                var table = document.AddTable(1, 8);

                table.Rows[0].Cells[0].Paragraphs[0].Append("Title");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Author");
                table.Rows[0].Cells[2].Paragraphs[0].Append("Genre");
                table.Rows[0].Cells[3].Paragraphs[0].Append("ReleaseYear");
                table.Rows[0].Cells[4].Paragraphs[0].Append("NumberOfSeasons");
                table.Rows[0].Cells[5].Paragraphs[0].Append("Platform");
                table.Rows[0].Cells[6].Paragraphs[0].Append("ProductionStudio");
                table.Rows[0].Cells[7].Paragraphs[0].Append("Rating");

                int row = 1;
                for (int i = 0; i < animeMatriz.GetLength(0); i++)
                {
                    for (int j = 0; j < animeMatriz.GetLength(1); j++)
                    {
                        if (animeMatriz[i, j] != null)
                        {
                            table.InsertRow();
                            table.Rows[row].Cells[0].Paragraphs[0].Append(animeMatriz[i, j].Title);
                            table.Rows[row].Cells[1].Paragraphs[0].Append(animeMatriz[i, j].Author);
                            table.Rows[row].Cells[2].Paragraphs[0].Append(animeMatriz[i, j].Genre);
                            table.Rows[row].Cells[3].Paragraphs[0].Append(animeMatriz[i, j].ReleaseYear.ToShortDateString());
                            table.Rows[row].Cells[4].Paragraphs[0].Append(animeMatriz[i, j].NumberOfSeasons.ToString());
                            table.Rows[row].Cells[5].Paragraphs[0].Append(animeMatriz[i, j].Platform);
                            table.Rows[row].Cells[6].Paragraphs[0].Append(animeMatriz[i, j].ProductionStudio);
                            table.Rows[row].Cells[7].Paragraphs[0].Append(animeMatriz[i, j].Rating.ToString());
                            row++;
                        }
                    }
                }

                document.InsertTable(table);
                document.Save();
            }
        }

        public static void ExportAnimeToTxt(string filePath, Anime[,] animeMatriz)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < animeMatriz.GetLength(0); i++)
                {
                    for (int j = 0; j < animeMatriz.GetLength(1); j++)
                    {
                        if (animeMatriz[i, j] != null)
                        {
                            writer.WriteLine(animeMatriz[i, j].ToString());
                        }
                    }
                }
            }
        }

        public static void LoadAnimeDataFromTextFile(string filePath, Anime[,] animeMatriz, ListView lstvData)
        {
            int row, column;
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                row = 0;
                column = 0;
                foreach (string line in lines)
                {
                    string[] fields = line.Split('|');

                    if (row >= animeMatriz.GetLength(0) || column >= animeMatriz.GetLength(1))
                    {
                        MessageBox.Show("The matrix is full. You need to delete some entries to add new ones.", "Matrix Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    animeMatriz[row, column] = new Anime(
                        fields[0],
                        fields[1],
                        fields[2],
                        DateTime.Parse(fields[3]),
                        Convert.ToInt32(fields[4]),
                        fields[5],
                        fields[6],
                        Convert.ToInt32(fields[7])
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

                    column++;
                    if (column >= animeMatriz.GetLength(1))
                    {
                        row++;
                        column = 0;
                    }
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
