namespace AnimeAndMangaList
{
    internal interface IJapaneseWorks
    {
        string Title { get; set; }

        //CHECAR SI ESTA BIEN IMPLEMENTADA
        string Author { get; set; }
        string Genre { get; set; }
        DateTime ReleaseYear { get; set; }
        int Rating { get; set; }
        string ShowSimilarWorks();
    }
}
