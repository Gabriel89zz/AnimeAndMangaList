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
            set { releaseyear = value; }
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

        public static string GetStatsAnime(Anime[] animes)
        {
            int crunchyroll = 0;
            int netflix = 0;
            int disneyplus = 0;
            int primevideo = 0;
            int sumSubs = 0;
            foreach (var anime in animes)
            {
                if (anime != null)
                {
                    switch (anime.platform)
                    {
                        case "Crunchyroll":
                            crunchyroll=145;
                            break;
                        case "Netflix":
                            netflix=219;
                            break;
                        case "Disney Plus":
                            disneyplus=200;
                            break;
                        case "Prime Video":
                            primevideo=99;
                            break;
                        default:
                            continue;
                    }
                }
            }
            sumSubs = crunchyroll + disneyplus + netflix + primevideo;
            return "Your monthly subscription cost is: " + sumSubs+" MXN";
        }


        public static void ExportAnimeToJson(string filePath, Anime[] animes)
        {
            Anime[] filteredMangas = Array.FindAll(animes, m => m != null);
            string json = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void ExportAnimeToXml(string filePath, Anime[] animes)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Animes");
            doc.AppendChild(root);

            foreach (var anime in animes.Where(m => m != null))
            {
                XmlElement animeElement = doc.CreateElement("Manga");

                XmlElement titleElement = doc.CreateElement("Title");
                titleElement.InnerText = anime.title;
                animeElement.AppendChild(titleElement);

                XmlElement authorElement = doc.CreateElement("Author");
                authorElement.InnerText = anime.author;
                animeElement.AppendChild(authorElement);

                XmlElement genreElement = doc.CreateElement("Genre");
                genreElement.InnerText = anime.genre;
                animeElement.AppendChild(genreElement);

                XmlElement releaseYearElement = doc.CreateElement("ReleaseYear");
                releaseYearElement.InnerText = anime.releaseyear.ToShortDateString();
                animeElement.AppendChild(releaseYearElement);

                XmlElement numberOfSeasonsElements = doc.CreateElement("NumberofChapters");
                numberOfSeasonsElements.InnerText = anime.numberofseasons.ToString();
                animeElement.AppendChild(numberOfSeasonsElements);

                XmlElement editorialElement = doc.CreateElement("Platform");
                editorialElement.InnerText = anime.platform;
                animeElement.AppendChild(editorialElement);

                XmlElement ratingElement = doc.CreateElement("Rating");
                ratingElement.InnerText = anime.rating.ToString();
                animeElement.AppendChild(ratingElement);

                XmlElement priceElement = doc.CreateElement("ProductionStudio");
                priceElement.InnerText = anime.productionstudio.ToString();
                animeElement.AppendChild(priceElement);

                root.AppendChild(animeElement);
            }

            doc.Save(filePath);

        }

        public static void ExportAnimeToExcel(string filePath, Anime[] animes)
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

                foreach (var anime in animes.Where(m => m != null))
                {
                    worksheet.Cell(rowIndex, 1).Value = anime.title;
                    worksheet.Cell(rowIndex, 2).Value = anime.author;
                    worksheet.Cell(rowIndex, 3).Value = anime.genre;
                    worksheet.Cell(rowIndex, 4).Value = anime.releaseyear.ToShortDateString();
                    worksheet.Cell(rowIndex, 5).Value = anime.numberofseasons;
                    worksheet.Cell(rowIndex, 6).Value = anime.platform;
                    worksheet.Cell(rowIndex, 7).Value = anime.rating;
                    worksheet.Cell(rowIndex, 8).Value = anime.productionstudio;

                    rowIndex++;
                }

                workbook.SaveAs(filePath);
            }
        }


        public static void ExportAnimeToWord(string filePath, Anime[] animes)
        {
            using (var document = DocX.Create(filePath))
            {
                document.InsertParagraph("Anime List").FontSize(15).Bold().Alignment = Alignment.center;

                var animeCount = animes.Count(m => m != null);
                var table = document.AddTable(animeCount + 1, 8);

                table.Rows[0].Cells[0].Paragraphs[0].Append("Title");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Author");
                table.Rows[0].Cells[2].Paragraphs[0].Append("Genre");
                table.Rows[0].Cells[3].Paragraphs[0].Append("ReleaseYear");
                table.Rows[0].Cells[4].Paragraphs[0].Append("Number of Chapters");
                table.Rows[0].Cells[5].Paragraphs[0].Append("Platform");
                table.Rows[0].Cells[6].Paragraphs[0].Append("Rating");
                table.Rows[0].Cells[7].Paragraphs[0].Append("Production Studio");

                int rowIndex = 1;
                foreach (var manga in animes.Where(m => m != null))
                {
                    table.Rows[rowIndex].Cells[0].Paragraphs[0].Append(manga.title);
                    table.Rows[rowIndex].Cells[1].Paragraphs[0].Append(manga.author);
                    table.Rows[rowIndex].Cells[2].Paragraphs[0].Append(manga.genre);
                    table.Rows[rowIndex].Cells[3].Paragraphs[0].Append(manga.releaseyear.ToShortDateString());
                    table.Rows[rowIndex].Cells[4].Paragraphs[0].Append(manga.numberofseasons.ToString());
                    table.Rows[rowIndex].Cells[5].Paragraphs[0].Append(manga.platform);
                    table.Rows[rowIndex].Cells[6].Paragraphs[0].Append(manga.rating.ToString());
                    table.Rows[rowIndex].Cells[7].Paragraphs[0].Append(manga.productionstudio);
                    rowIndex++;
                }

                document.InsertTable(table);
                document.Save();
            }

        }

        public static void ExportAnimeToTxt(string filePath, Anime[] animes)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var anime in animes.Where(m => m != null))
                {
                    writer.WriteLine(anime.ToString());
                }
            }
        }

        public static void LoadAnimeDataFromTextFile(string filePath, Anime[] animes, ListView lstvData)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] fields = line.Split('|');

                    int emptyIndex = Array.FindIndex(animes, m => m == null);

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

                    ListViewItem item = new ListViewItem(animes[emptyIndex].title);
                    item.SubItems.Add(animes[emptyIndex].author);
                    item.SubItems.Add(animes[emptyIndex].genre);
                    item.SubItems.Add(animes[emptyIndex].releaseyear.ToShortDateString());
                    item.SubItems.Add(animes[emptyIndex].numberofseasons.ToString());
                    item.SubItems.Add(animes[emptyIndex].productionstudio);
                    item.SubItems.Add(animes[emptyIndex].platform);
                    item.SubItems.Add(animes[emptyIndex].rating.ToString());

                    lstvData.Items.Add(item);
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
