

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
        //Propiedad de solo lectura
		public double Price
        {
            get { return price; }
        }

        public Book()
        {
			volume = 0;
			editorial = "";
			price =DeterminePrice();
        }

		public Book(int volume,string editorial)
        {
			this.volume = volume;
			this.editorial = editorial;
			this.price = DeterminePrice();
        }

        private double DeterminePrice()
        {
            switch (editorial)
            {
                case "Panini":
                    return 145;
                case "Norma":
                    return 139;
                case "Kamite":
                    return 189;
                case "Ivrea":
                    return 120;
                default:
                    return 100; 
            }
        }
    }
}
