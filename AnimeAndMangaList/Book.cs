

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
        public double Price
        {
            set { price = value; }
            get { return price; }
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

       
    }
}
