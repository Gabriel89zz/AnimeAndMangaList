using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Xml;
using Xceed.Words.NET;
using Xceed.Document.NET;
using Microsoft.DotNet.PlatformAbstractions;
using iText.Commons.Bouncycastle.Cert.Ocsp;

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
            set { author = value; }
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
        public Manga(string title,string autor,string genre,DateTime releaseyear, int chaptersnumber, string editorial, int rating):base(chaptersnumber,editorial)
        {
            this.title = title;
            this.author = autor;
            this.genre = genre;
            this.releaseyear = releaseyear;
            this.rating = rating;
        }

        public override string ToString()
        {
            return "Title: "+title+", Author: "+author+ ", Genre: " + genre + ", Acquisition Date: " + releaseyear+", Volume: "+volume+", Editorial: "+editorial+", Price: "+price+", Rating:"+rating;
        }
        //METODO  QUE REGRESA Y RECIBE
        public static string GetStatsManga(Manga[] mangas)
        {
            double sumPrice = 0;
            int Kamite = 0;
            int Panini = 0;
            int Ivrea = 0;
            int Norma = 0;
            int shonen = 0;
            int seinen = 0;
            int comedy = 0;
            int scifi = 0;
            int romcom = 0;
            int isekai = 0;
            foreach (Manga manga in mangas)
            {
                if (manga != null)
                {
                    sumPrice += manga.price;
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

                    switch (manga.genre)
                    {
                        case "Shonen":
                            shonen++;
                            break;
                        case "Seinen":
                            seinen++;
                            break;
                        case "Comedy":
                            comedy++;
                            break;
                        case "Sci-Fi":
                            scifi++;
                            break; 
                        case "Romcom":
                            romcom++;
                            break;
                        case "Isekai":
                            isekai++;
                            break;
                        default:
                            continue;
                    }
                }
            }
            return "The ost of your collection of mangas: " + Math.Round(sumPrice, 2)+" MXN"+"\n\nMangas by editorial: \nPanini:" + Panini + "\nNorma: " + Norma + "\nKamite: " + Kamite + "\nIvrea: "+Ivrea+
                "\n\nMangas by genre: \nShonen: "+shonen+"\nSeinen: "+seinen+"\nComedy: "+comedy+"\nSci-Fi: "+scifi+"\nRomcom: "+romcom+"\nIsekai: "+isekai;
        }

        //METODO QUE REGRESA PERO NO RECIBE
        public string ShowSimilarWorks()
        {
            string similarWorksMessage = "";
           
            switch (genre)
            {
                case "Shonen":
                    string[] shonenGenre = {"One Piece", "Naruto", "Bleach", "Black Clover", "Fairy Tail",
                    "Dragon Ball", "My Hero Academia", "Attack on Titan", "Hunter x Hunter", "Demon Slayer",
                    "One Punch Man", "Haikyuu!!", "Yu Yu Hakusho", "The Seven Deadly Sins", "JoJo's Bizarre Adventure",
                    "Fullmetal Alchemist", "Mob Psycho 100", "Tokyo Ghoul", "Assassination Classroom", "Dragon Ball Z"};

                    for (int i = 0; i < shonenGenre.Length; i++)
                    {
                        if (title == shonenGenre[i])
                        {
                            shonenGenre[i] = "";
                        }
                        else
                        {
                            similarWorksMessage += shonenGenre[i] + "\n";
                        }
                    }
                    break;
                case "Seinen":
                    string[] seinenGenre = {
                    "Tokyo Ghoul", "Attack on Titan", "Death Note", "Berserk", "Monster",
                    "Parasyte", "Elfen Lied", "Akira", "Claymore", "Psycho-Pass",
                    "Vinland Saga", "Neon Genesis Evangelion", "The Promised Neverland", "Gantz", "Black Lagoon",
                    "Hellsing", "Vagabond", "Blame!", "Deadman Wonderland", "Dorohedoro"};
                    for (int i = 0; i < seinenGenre.Length; i++)
                    {
                        if (title == seinenGenre[i])
                        {
                            seinenGenre[i] = "";
                        }
                        else
                        {
                            similarWorksMessage += seinenGenre[i] + "\n";
                        }
                    }
                    break;
                case "Comedey":
                    string[] comedyGenre = {"Gintama", "Nichijou", "One Punch Man", "Konosuba", "Grand Blue",
                    "Daily Lives of High School Boys", "The Disastrous Life of Saiki K.", "KonoSuba: God's Blessing on This Wonderful World!", "Great Teacher Onizuka", "Arakawa Under the Bridge",
                    "Nichibros", "Prison School", "Danshi Koukousei no Nichijou", "Azumanga Daioh", "K-On!",
                    "Cromartie High School", "Sakamoto desu ga?", "Seto no Hanayome", "Shimoneta", "Lucky Star"};
                    for (int i = 0; i < comedyGenre.Length; i++)
                    {
                        if (title == comedyGenre[i])
                        {
                            comedyGenre[i] = "";
                        }
                        else
                        {
                            similarWorksMessage += comedyGenre[i] + "\n";
                        }
                    }
                    break;
                case "Sci-Fi":
                    string[] scifiGenre = {"Steins;Gate", "Ghost in the Shell", "Cowboy Bebop", "Neon Genesis Evangelion", "Psycho-Pass",
                    "Serial Experiments Lain", "Trigun", "Planetes", "Aldnoah.Zero", "Ergo Proxy",
                    "Legend of the Galactic Heroes", "Texhnolyze", "No. 6", "Outlaw Star", "Space Dandy",
                    "Astra Lost in Space", "Mobile Suit Gundam", "Robotech", "Armitage III", "Blue Gender" };
                    for (int i = 0; i < scifiGenre.Length; i++)
                    {
                        if (title == scifiGenre[i])
                        {
                            scifiGenre[i] = "";
                        }
                        else
                        {
                            similarWorksMessage += scifiGenre[i] + "\n";
                        }
                    }
                    break;
                case "Romcom":
                    string[] romcomGenre = {"Toradora!", "My Youth Romantic Comedy Is Wrong, As I Expected", "Love, Chunibyo & Other Delusions", "Nisekoi", "Golden Time",
                    "Ore Monogatari!!", "Sakurasou no Pet na Kanojo", "Clannad", "Lovely★Complex", "Kaguya-sama: Love is War",
                    "The Pet Girl of Sakurasou", "Monthly Girls' Nozaki-kun", "The Quintessential Quintuplets", "My Little Monster", "School Rumble",
                    "Love Hina", "Kimi ni Todoke", "Tonikaku Kawaii", "Ouran High School Host Club", "Kaichou wa Maid-sama!" };
                    for (int i = 0; i < romcomGenre.Length; i++)
                    {
                        if (title == romcomGenre[i])
                        {
                            romcomGenre[i] = "";
                        }
                        else
                        {
                            similarWorksMessage += romcomGenre[i] + "\n";
                        }
                    }
                    break;
                case "Isekai":
                    string[] isekaiGenre = {"Re:Zero", "Sword Art Online", "Overlord", "The Rising of the Shield Hero", "Log Horizon",
                    "No Game No Life", "That Time I Got Reincarnated as a Slime", "Konosuba", "The Devil is a Part-Timer!", "Grimgar, Ashes and Illusions",
                    "In Another World with My Smartphone", "The Saga of Tanya the Evil", "The Familiar of Zero", "Gate: Thus the JSDF Fought There!", "Isekai Quartet",
                    "Accel World", "Problem Children Are Coming from Another World, Aren't They?", "Digimon Adventure", "Restaurant to Another World", "How Not to Summon a Demon Lord"};
                    for (int i = 0; i < isekaiGenre.Length; i++)
                    {
                        if (title == isekaiGenre[i])
                        {
                            isekaiGenre[i] = "";
                        }
                        else
                        {
                            similarWorksMessage += isekaiGenre[i] + "\n";
                        }
                    }
                    break;
                default:
                    return "Gender not specified";
            }
            return similarWorksMessage;
        }
    }

}
