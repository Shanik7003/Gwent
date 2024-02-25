using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Engine;
class Game
{
        // Water Tribe
        #region 
        public static LeaderCard waterLeader = new LeaderCard("Katara",  "Water Bender",LeaderHability.ExtraCardFirstRound);
        public static Card waterCard2 = new ("Pakku",  "Water Bender");
        public static Card waterCard3 = new ("Hama",  "Water Bender");
        public static Card waterCard4 = new ("Yue",  "Water Bender");
        public static Card waterCard5 = new ("Kya",  "Water Bender");
        public static Card waterCard6 = new ("Ming-Hua",  "Water Bender");
        public static Card waterCard7 = new ("Korra",  "Water Bender");
        public static Card waterCard8 = new ("Tonraq",  "Water Bender");
        public static Card waterCard9 = new ("Eska",  "Water Bender");
        public static Card waterCard10 = new ("Desna",  "Water Bender");
        public static Card waterCard11 = new ("Unalaq",  "Water Bender");
        public static Card waterCard12 = new ("Tarrlok",  "Water Bender");
        public static Card waterCard13 = new ("Hu",  "Water Bender");
        public static Card waterCard14 = new ("Thod",  "Water Bender");
        public static Card waterCard15 = new ("Vachir",  "Water Bender");
        public static Card waterCard16 = new ("Shirshu",  "Water Bender");
        public static Card waterCard17 = new ("Admiral Zhao",  "Fire Bender");
        public static Card waterCard18 = new ("June",  "Non-bender");
        public static Card waterCard19 = new ("Song",  "Non-bender");
        public static Card waterCard20 = new ("Bato",  "Non-bender");
        public static Card waterCard21 = new ("Pipsqueak",  "Non-bender");
        public static Card waterCard22 = new ("The Duke",  "Non-bender");
        public static Card waterCard23 = new ("Tyro",  "Non-bender");
        public static Card waterCard24 = new ("The Painted Lady",  "Non-bender");
        public static Card waterCard25 = new ("Tui and La",  "Spirit");
        public static Card[] WaterDeck = {waterCard2, waterCard3, waterCard4, waterCard5, waterCard6, waterCard7, waterCard8, waterCard9, waterCard10, waterCard11, waterCard12, waterCard13, waterCard14, waterCard15, waterCard16, waterCard17, waterCard18, waterCard19, waterCard20, waterCard21, waterCard22, waterCard23, waterCard24, waterCard25};
        static WaterTribe WaterTribe = new WaterTribe(WaterDeck,waterLeader);
        #endregion
        // Air Nomads
        #region 
        public static LeaderCard airLeader = new LeaderCard ("Aang", "Air Bender",LeaderHability.ExtraCardSecondRound);
        public static Card airCard2 = new ("Gyatso", "Air Bender");
        public static Card airCard3 = new ("Tenzin", "Air Bender");
        public static Card airCard4 = new ("Jinora", "Air Bender");
        public static Card airCard5 = new ("Ikki", "Air Bender");
        public static Card airCard6 = new ("Meelo", "Air Bender");
        public static Card airCard7 = new ("Opal", "Air Bender");
        public static Card airCard8 = new ("Kai", "Air Bender");
        public static Card airCard9 = new ("Rohan", "Air Bender");
        public static Card airCard10 = new ("Tashi", "Air Bender");
        public static Card airCard11 = new ("Avatar Yangchen", "Air Bender");
        public static Card airCard12 = new ("Yanchen", "Air Bender");
        public static Card airCard13 = new ("Roku", "Air Bender");
        public static Card airCard14 = new ("Kyoshi", "Air Bender");
        public static Card airCard15 = new ("Kuruk", "Air Bender");
        public static Card airCard16 = new ("Avatar Wan", "Fire Bender");
        public static Card airCard17 = new ("Avatar Korra", "Water Bender");
        public static Card airCard18 = new ("Appa", "Sky Bison");
        public static Card airCard19 = new ("Momos", "Flying Lemur");
        public static Card airCard20 = new ("Hawky", "Messenger Hawk");
        public static Card airCard21 = new ("Flying Boar", "Non-bender");
        public static Card airCard22 = new ("Wan Shi Tong", "Spirit");
        public static Card airCard23 = new ("The Lion Turtle", "Spirit");
        public static Card airCard24 = new ("Lemur", "Non-bender");
        public static Card airCard25 = new ("Bosco", "Bear");
        public static Card[] AirDeck = {airCard2, airCard3, airCard4, airCard5, airCard6, airCard7, airCard8, airCard9, airCard10, airCard11, airCard12, airCard13, airCard14, airCard15, airCard16, airCard17, airCard18, airCard19, airCard20, airCard21, airCard22, airCard23, airCard24, airCard25};
        static AirNomads AirNomads = new AirNomads(AirDeck,airLeader);
        #endregion

        // Fire Nation
        #region 
        public static LeaderCard fireLeader = new LeaderCard("Zuko", "Fire Bender",LeaderHability.TieWon);
        public static Card fireCard2 = new ("Azula", "Fire Bender");
        public static Card fireCard3 = new ("Iroh", "Fire Bender");
        public static Card fireCard4 = new ("Ozai", "Fire Bender");
        public static Card fireCard5 = new ("Mai", "Non-bender");
        public static Card fireCard6 = new ("Ty Lee", "Non-bender");
        public static Card fireCard7 = new ("Zhao", "Non-bender");
        public static Card fireCard8 = new ("Ran and Shaw", "Fire Lion Turtle");
        public static Card fireCard9 = new ("Combustion Man", "Fire Bender");
        public static Card fireCard10 = new ("Lo and Li", "Non-bender");
        public static Card fireCard11 = new ("Jeong Jeong", "Fire Bender");
        public static Card fireCard12 = new ("Sozin", "Fire Bender");
        public static Card fireCard13 = new ("Azulon", "Fire Bender");
        public static Card fireCard14 = new ("Shyu", "Non-bender");
        public static Card fireCard15 = new ("Fire Lord Sozin", "Fire Bender");
        public static Card fireCard16 = new ("Fire Lord Azulon", "Fire Bender");
        public static Card fireCard17 = new ("Fire Lord Zuko", "Fire Bender");
        public static Card fireCard18 = new ("Fire Lord Ozai", "Fire Bender");
        public static Card fireCard19 = new ("Fire Lord Iroh", "Fire Bender");
        public static Card fireCard20 = new ("Fire Lord Azula", "Fire Bender");
        public static Card fireCard21 = new ("Fire Lord Sozin", "Fire Bender");
        public static Card fireCard22 = new ("Izumi", "Fire Bender");
        public static Card fireCard23 = new ("Fire Lord Azulon", "Fire Bender");
        public static Card fireCard24 = new ("Azulon", "Fire Bender");
        public static Card fireCard25 = new ("Iroh II", "Fire Bender");
        public static Card[] FireDeck = {fireCard2, fireCard3, fireCard4, fireCard5, fireCard6, fireCard7, fireCard8, fireCard9, fireCard10, fireCard11, fireCard12, fireCard13, fireCard14, fireCard15, fireCard16, fireCard17, fireCard18, fireCard19, fireCard20, fireCard21, fireCard22, fireCard23, fireCard24, fireCard25};
        static FireNation FireNation = new FireNation(FireDeck,fireLeader);
        #endregion
        // Earth Kingdom
        #region 
        public static LeaderCard earthLeader = new LeaderCard("Toph", "Earth Bender",LeaderHability.StayBetweenRounds);
        public static Card earthCard2 = new ("King Bumi", "Earth Bender");
        public static Card earthCard3 = new ("Lin Beifong", "Metal Bender");
        public static Card earthCard4 = new ("Suyin Beifong", "Metal Bender");
        public static Card earthCard5 = new ("Wei", "Earth Bender");
        public static Card earthCard6 = new ("Wing", "Earth Bender");
        public static Card earthCard7 = new ("Huan", "Earth Bender");
        public static Card earthCard8 = new ("Kuvira", "Earth Bender");
        public static Card earthCard9 = new ("Ghazan", "Lavabender");
        public static Card earthCard10 = new ("Ming-Hua", "Water Bender");
        public static Card earthCard11 = new ("P\'Li", "Combustion Bender");
        public static Card earthCard12 = new ("Avatar Kyoshi", "Earth Bender");
        public static Card earthCard13 = new ("Avatar Yangchen", "Air Bender");
        public static Card earthCard14 = new ("Avatar Kuruk", "Water Bender");
        public static Card earthCard15 = new ("Avatar Roku", "Fire Bender");
        public static Card earthCard16 = new ("Avatar Wan", "Fire Bender");
        public static Card earthCard17 = new ("Avatar Korra", "Water Bender");
        public static Card earthCard18 = new ("Avatar Aang", "Air Bender");
        public static Card earthCard19 = new ("Bosco", "Bear");
        public static Card earthCard20 = new ("The Lion Turtle", "Spirit");
        public static Card earthCard21 = new ("Wan Shi Tong", "Spirit");
        public static Card earthCard22 = new ("Hayao", "Non-bender");
        public static Card earthCard23 = new ("Bolin", "Earth Bender");
        public static Card earthCard24 = new ("Wei", "Earth Bender");
        public static Card earthCard25 = new ("Wing", "Earth Bender");
        public static Card []EarthDeck = {earthCard2, earthCard3, earthCard4, earthCard5, earthCard6, earthCard7, earthCard8, earthCard9, earthCard10, earthCard11, earthCard12, earthCard13, earthCard14, earthCard15, earthCard16, earthCard17, earthCard18, earthCard19, earthCard20, earthCard21, earthCard22, earthCard23, earthCard24, earthCard25};
        static EarthKingdom EarthKingdom = new EarthKingdom(EarthDeck,earthLeader);
        #endregion
       
       public static Faction ChooseFaction()
       {    
            Faction faction = FireNation;//parche: puse fireNAtion por defecto porq cuando lo quito me da error el return
            System.Console.WriteLine("To start playing you must select your faction:\n Write\n 0 for the Fire Nation\n 1 for the Water Tribe\n 2 for the Earth Kingdom\n and 3 for the Air Nomads");
            string select = Console.ReadLine()!;
            if(select == "0")
            {
                faction = FireNation;
            }
             if(select == "1")
            {
                faction = WaterTribe;
            }
             if(select == "2")
            {
               faction = EarthKingdom;
            }
             if(select == "3")
            {
                faction = AirNomads;
            }
            return faction;
       }

        public Player FirstPlayer (Player player1, Player player2)
        {
            var randon = new Random();
            int ran = randon.Next(1,3);
            if (ran == 1)
            {
                return player1;
            }
            if (ran == 2)
            {
               return player2; 
            }
            return player1;//parche 
        }
        
        //position

    private static void Main(string[] args)

        {   
            while (true)
            {
                //crea los players
                #region 
                List<Card> graveyard1 = new List<Card>();
                List<Card> hand1 = new List<Card>();
                Board board1= new Board();
                Player player1 = new Player(0,ChooseFaction(),graveyard1,board1,hand1);
                List<Card> graveyard2 = new List<Card>();
                List<Card> hand2 = new List<Card>();
                Board board2= new Board();
                Player player2 = new Player(0,ChooseFaction(),graveyard2,board2,hand2);
                #endregion
                //que cada jugador coja su mano de 10 cartas 
                #region
                hand1 = player1.GetHand();
                hand2 = player2.GetHand();  
                #endregion
            }  

        
        }
}    
