
namespace AnimeAndMangaList
{
    internal interface IJapaneseWorks
    {
        string Title { get; set; }
        string Author { get;}
        string Genre { get; set; }
        DateTime ReleaseYear { get;}
        int Rating { get; set; }
    }
}
