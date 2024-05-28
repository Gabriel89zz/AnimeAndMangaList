

namespace AnimeAndMangaList
{
    internal class Book
    {
		protected int volume;

		public int Volume
		{
			get { return volume; }
			set { volume = value; }
		}

		protected string editorial;

		public string Editorial
		{
			get { return editorial; }
			set { editorial = value; }
		}

        protected double price;

        //PROPIEDAD DE SOLO ESCRITURA
        public double Price
        {
            private get { return price; }
            set { price = value; }
        }

        public Book()
        {
			volume = 0;
			editorial = "";
			price = 0;
        }

		public Book(int chaptersnumber,string editorial,double price)
        {
			this.volume = chaptersnumber;
			this.editorial = editorial;
			this.price = price;
        }

        //METODO QUE RECIBE Y REGRESA
        public static double GetCollectionCost(Manga[] mangas)
        {
            double sumPrice = 0;
            foreach (Manga manga in mangas)
            {
                if (manga != null)
                {
                    sumPrice += manga.price;
                }
            }
            return Math.Round(sumPrice, 2);
        }
    }
}
