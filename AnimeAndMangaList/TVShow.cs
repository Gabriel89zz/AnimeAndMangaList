
namespace AnimeAndMangaList
{
    internal class TVShow
    {
		protected string productionstudio;
		public string ProductionStudio
		{
			get { return productionstudio; }
			set { productionstudio = value; }
		}

		protected int numberofseasons;
		public int NumberOfSeasons
        {
			get { return numberofseasons; }
			set { numberofseasons = value; }
		}

		protected string platform;
		public string Platform
		{
			get { return platform; }
			set { platform = value; }
		}

        public TVShow()
        {
			productionstudio = "";
			numberofseasons = 0;
			platform = "";
        }

        public TVShow(string productionstudio,int numberofseasons,string platform)
        {
            this.productionstudio=productionstudio;
			this.numberofseasons=numberofseasons;
			this.platform = platform;
        }

    }
}
