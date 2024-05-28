
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

        //METODO QUE RECIBE PERO NO REGRESA
        public static void CalulateCostSubscription(Anime[,] animes)
        {
            Dictionary<string, double> platformCosts = new Dictionary<string, double>();

            for (int row = 0; row < animes.GetLength(0); row++)
            {
                for (int column = 0; column < animes.GetLength(1); column++)
                {
                    Anime anime = animes[row, column];

                    if (anime != null)
                    {
                        string platform = anime.Platform;
                        double cost = 0;

                        switch (platform)
                        {
                            case "Crunchyroll":
                                cost = 145;
                                break;
                            case "Netflix":
                                cost = 219;
                                break;
                            case "Prime Video":
                                cost = 99;
                                break;
                            case "Disney Plus":
                                cost = 179;
                                break;
                            default:
                                continue;
                        }
                        if (!platformCosts.ContainsKey(platform))
                        {
                            platformCosts.Add(platform, cost);
                        }
                    }
                }
            }
            double sumSubs = 0;
            foreach (var cost in platformCosts.Values)
            {
                sumSubs += cost;
            }

            MessageBox.Show("Your expense per month of subscriptions is: " + sumSubs + " MXN", "Total Cost of Subscriptions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
