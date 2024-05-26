using ClosedXML.Excel;
using iText.Layout.Font;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Xml.Linq;

namespace AnimeAndMangaList
{
    //CLASE,HERENCIA E INTERFAZ
    internal class Manga : Book, IJapaneseWorks
    {
        //PROPIEDAD DE ESCRITURA Y LECTURA
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //PROPIEADAD DE SOLO LECTURA
        private readonly string author;
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

        // METODO QUE REGRESA PERO NO RECIBE
        public static String[] GetMangaGenres()
        {
            String[] MangaGenres = { "Shonen","Seinen","Comedy","Drama","Sci-Fi","Romcom","Slice of Life","Isekai" };
            return MangaGenres;
        }

        public static void ExportMangaToJson(string filePath, Manga[]mangas)
        {
            List<Manga> mangaList = mangas.Where(m => m != null).ToList();
            string json = JsonConvert.SerializeObject(mangaList, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void ExportMangaToXml(string filePath, Manga[] mangas)
        {
            List<Manga> mangaList = mangas.Where(m => m != null).ToList();
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Mangas");
            doc.AppendChild(root);

            foreach (var manga in mangaList)
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

                root.AppendChild(mangaElement);
            }

            doc.Save(filePath);
        }

        public static void ExportMangaToExcel(string filePath, Manga[] mangas)
        {
            List<Manga> mangaList = mangas.Where(m => m != null).ToList();
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

                for (int i = 0; i < mangaList.Count; i++)
                {
                    var manga = mangaList[i];
                    worksheet.Cell(i + 2, 1).Value = manga.Title;
                    worksheet.Cell(i + 2, 2).Value = manga.Author;
                    worksheet.Cell(i + 2, 3).Value = manga.Genre;
                    worksheet.Cell(i + 2, 4).Value = manga.ReleaseYear.ToShortDateString();
                    worksheet.Cell(i + 2, 5).Value = manga.Volume;
                    worksheet.Cell(i + 2, 6).Value = manga.Editorial;
                    worksheet.Cell(i + 2, 7).Value = manga.Rating;
                }

                workbook.SaveAs(filePath);
            }
        }

        public static void ExportMangaToWord(string filePath, Manga[] mangas)
        {
            List<Manga> mangaList = mangas.Where(m => m != null).ToList();
            using (var document = DocX.Create(filePath))
            {
                document.InsertParagraph("Manga List").FontSize(15).Bold().Alignment = Alignment.center;
                var table = document.AddTable(mangaList.Count + 1, 7);

                table.Rows[0].Cells[0].Paragraphs[0].Append("Title");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Author");
                table.Rows[0].Cells[2].Paragraphs[0].Append("Genre");
                table.Rows[0].Cells[3].Paragraphs[0].Append("ReleaseYear");
                table.Rows[0].Cells[4].Paragraphs[0].Append("Volume");
                table.Rows[0].Cells[5].Paragraphs[0].Append("Editorial");
                table.Rows[0].Cells[6].Paragraphs[0].Append("Rating");

                for (int i = 0; i < mangaList.Count; i++)
                {
                    var manga = mangaList[i];
                    table.Rows[i + 1].Cells[0].Paragraphs[0].Append(manga.Title);
                    table.Rows[i + 1].Cells[1].Paragraphs[0].Append(manga.Author);
                    table.Rows[i + 1].Cells[2].Paragraphs[0].Append(manga.Genre);
                    table.Rows[i + 1].Cells[3].Paragraphs[0].Append(manga.ReleaseYear.ToShortDateString());
                    table.Rows[i + 1].Cells[4].Paragraphs[0].Append(manga.Volume.ToString());
                    table.Rows[i + 1].Cells[5].Paragraphs[0].Append(manga.Editorial);
                    table.Rows[i + 1].Cells[6].Paragraphs[0].Append(manga.Rating.ToString());
                }

                document.InsertTable(table);
                document.Save();
            }
        }

        public static void ExportMangaToTxt(string filePath, Manga[] mangas)
        {
            List<Manga> mangaList = mangas.Where(m => m != null).ToList();
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var manga in mangaList)
                {
                    writer.WriteLine(manga.ToString());
                }
            }
        }
    }

}
