using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
