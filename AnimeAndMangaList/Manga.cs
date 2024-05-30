using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Microsoft.DotNet.PlatformAbstractions;

namespace AnimeAndMangaList
{
    //CLASE,HERENCIA E INTERFAZ
    internal class Manga : Book, IJapaneseWorks
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //PROPIEADAD DE SOLO LECTURA
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

        //CONSTRUCTOR SIN PARAMETROS
        public Manga():base()
        {
            title = "";
            author = "";
            genre = "";
            releaseyear = DateTime.MinValue;
            rating = 0;
        }

        //CONSTRUCTOR CON PARAMETROS
        public Manga(string title,string autor,string genre,DateTime releaseyear, int chaptersnumber, string editorial, int rating,double price):base(chaptersnumber,editorial,price)
        {
            this.title = title;
            this.author = autor;
            this.genre = genre;
            this.releaseyear = releaseyear;
            this.rating = rating;
        }

        //Polimorfimso
        public override string ToString()
        {
            return "Title: "+title+", Author: "+author+ ", Genre: " + genre + ", Acquisition Date: " + releaseyear+", Volume: "+volume+", Editorial: "+editorial+", Price: "+price+", Rating:"+rating;
        }
        //METODO  QUE REGRESA Y RECIBE
        public static string GetStats(Manga[] mangas)
        {
            double sumPrice = 0;
            foreach (Manga manga in mangas)
            {
                if (manga != null)
                {
                    sumPrice += manga.price;
                }
            }

            int Kamite = 0;
            int Panini = 0;
            int Ivrea = 0;
            int Norma = 0;

            foreach (var manga in mangas)
            {
                if (manga != null)
                {
                    switch (manga.editorial)
                    {
                        case "Panini":
                            Panini++;
                            break;
                        case "Norma":
                            Norma++;
                            break;
                        case "Ivrea":
                           Ivrea++;
                            break;
                        case "Kamite":
                             Kamite++;
                            break;
                        default:
                            continue;
                    }
                }
            }
            return "The ost of your collection of mangas: " + Math.Round(sumPrice, 2) + "\nMangas by editorial: Panini:" + Panini + "Norma: " + Norma + " Kamite: " + Kamite + " Ivrea: " + Ivrea;
        }

        // METODO QUE REGRESA PERO NO RECIBE
        public static String[] GetMangaGenres()
        {
            String[] MangaGenres = { "Shonen","Seinen","Comedy","Drama","Sci-Fi","Romcom","Slice of Life","Isekai" };
            return MangaGenres;
        }

        //METODO QUE RECIBE PERO NO REGRESA
        public static void ExportMangaToJson(string filePath, Manga[]mangas)
        {
            Manga[] filteredMangas = Array.FindAll(mangas, m => m != null);
            string json = JsonConvert.SerializeObject(filteredMangas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void ExportMangaToXml(string filePath, Manga[] mangas)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Mangas");
            doc.AppendChild(root);

            foreach (var manga in mangas.Where(m => m != null))
            {
                XmlElement mangaElement = doc.CreateElement("Manga");

                XmlElement titleElement = doc.CreateElement("Title");
                titleElement.InnerText = manga.title;
                mangaElement.AppendChild(titleElement);

                XmlElement authorElement = doc.CreateElement("Author");
                authorElement.InnerText = manga.author;
                mangaElement.AppendChild(authorElement);

                XmlElement genreElement = doc.CreateElement("Genre");
                genreElement.InnerText = manga.genre;
                mangaElement.AppendChild(genreElement);

                XmlElement releaseYearElement = doc.CreateElement("ReleaseYear");
                releaseYearElement.InnerText = manga.releaseyear.ToShortDateString();
                mangaElement.AppendChild(releaseYearElement);

                XmlElement volumeElement = doc.CreateElement("Volume");
                volumeElement.InnerText = manga.volume.ToString();
                mangaElement.AppendChild(volumeElement);

                XmlElement editorialElement = doc.CreateElement("Editorial");
                editorialElement.InnerText = manga.editorial;
                mangaElement.AppendChild(editorialElement);

                XmlElement ratingElement = doc.CreateElement("Rating");
                ratingElement.InnerText = manga.rating.ToString();
                mangaElement.AppendChild(ratingElement);

                XmlElement priceElement = doc.CreateElement("Price");
                priceElement.InnerText = manga.price.ToString();
                mangaElement.AppendChild(priceElement);

                root.AppendChild(mangaElement);
            }

            doc.Save(filePath);

        }
        public static void ExportMangaToExcel(string filePath, Manga[] mangas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Mangas");

                worksheet.Cell(1, 1).Value = "Title";
                worksheet.Cell(1, 2).Value = "Author";
                worksheet.Cell(1, 3).Value = "Genre";
                worksheet.Cell(1, 4).Value = "ReleaseYear";
                worksheet.Cell(1, 5).Value = "Volume";
                worksheet.Cell(1, 6).Value = "Editorial";
                worksheet.Cell(1, 7).Value = "Rating";
                worksheet.Cell(1, 8).Value = "Price";

                int rowIndex = 2;

                foreach (var manga in mangas.Where(m => m != null))
                {
                    worksheet.Cell(rowIndex, 1).Value = manga.title;
                    worksheet.Cell(rowIndex, 2).Value = manga.author;
                    worksheet.Cell(rowIndex, 3).Value = manga.genre;
                    worksheet.Cell(rowIndex, 4).Value = manga.releaseyear.ToShortDateString();
                    worksheet.Cell(rowIndex, 5).Value = manga.volume;
                    worksheet.Cell(rowIndex, 6).Value = manga.editorial;
                    worksheet.Cell(rowIndex, 7).Value = manga.rating;
                    worksheet.Cell(rowIndex, 8).Value = manga.price;

                    rowIndex++;
                }

                workbook.SaveAs(filePath);
            }
        }


        public static void ExportMangaToWord(string filePath, Manga[] mangas)
        {
            using (var document = DocX.Create(filePath))
            {
                document.InsertParagraph("Manga List").FontSize(15).Bold().Alignment = Alignment.center;

                var mangaCount = mangas.Count(m => m != null);
                var table = document.AddTable(mangaCount + 1, 8);

                table.Rows[0].Cells[0].Paragraphs[0].Append("Title");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Author");
                table.Rows[0].Cells[2].Paragraphs[0].Append("Genre");
                table.Rows[0].Cells[3].Paragraphs[0].Append("ReleaseYear");
                table.Rows[0].Cells[4].Paragraphs[0].Append("Volume");
                table.Rows[0].Cells[5].Paragraphs[0].Append("Editorial");
                table.Rows[0].Cells[6].Paragraphs[0].Append("Rating");
                table.Rows[0].Cells[7].Paragraphs[0].Append("Price");

                int rowIndex = 1;
                foreach (var manga in mangas.Where(m => m != null))
                {
                    table.Rows[rowIndex].Cells[0].Paragraphs[0].Append(manga.title);
                    table.Rows[rowIndex].Cells[1].Paragraphs[0].Append(manga.author);
                    table.Rows[rowIndex].Cells[2].Paragraphs[0].Append(manga.genre);
                    table.Rows[rowIndex].Cells[3].Paragraphs[0].Append(manga.releaseyear.ToShortDateString());
                    table.Rows[rowIndex].Cells[4].Paragraphs[0].Append(manga.volume.ToString());
                    table.Rows[rowIndex].Cells[5].Paragraphs[0].Append(manga.editorial);
                    table.Rows[rowIndex].Cells[6].Paragraphs[0].Append(manga.rating.ToString());
                    table.Rows[rowIndex].Cells[7].Paragraphs[0].Append(manga.price.ToString());
                    rowIndex++;
                }

                document.InsertTable(table);
                document.Save();
            }

        }

        public static void ExportMangaToTxt(string filePath, Manga[] mangas)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var manga in mangas.Where(m => m != null))
                {
                    writer.WriteLine(manga.ToString());
                }
            }
        }

        public static void LoadMangaDataFromTextFile(string filePath, Manga[] mangas, ListView lstvData)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] fields = line.Split('|');

                    int emptyIndex = Array.FindIndex(mangas, m => m == null);

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
                        Convert.ToInt32(fields[6]),
                        Convert.ToDouble(fields[7])
                    );

                    ListViewItem item = new ListViewItem(mangas[emptyIndex].title);
                    item.SubItems.Add(mangas[emptyIndex].author);
                    item.SubItems.Add(mangas[emptyIndex].genre);
                    item.SubItems.Add(mangas[emptyIndex].releaseyear.ToShortDateString());
                    item.SubItems.Add(mangas[emptyIndex].volume.ToString());
                    item.SubItems.Add(mangas[emptyIndex].editorial);
                    item.SubItems.Add(mangas[emptyIndex].rating.ToString());
                    item.SubItems.Add(mangas[emptyIndex].price.ToString());

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
