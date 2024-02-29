using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Engine;
public class Game
{
    public static Player player1 = null!;
    public static Player player2 = null!;
    // game constructor
    public Game()
        {
            //crea los players
            #region 
            List<UnitCard> graveyard1 = new List<UnitCard>();
            List<UnitCard> hand1 = new List<UnitCard>();
            Board board1 = new Board();
            player1 = new Player(0,ChooseFaction(),graveyard1,board1,hand1);
            List<UnitCard> graveyard2 = new List<UnitCard>();
            List<UnitCard> hand2 = new List<UnitCard>();
            Board board2= new Board();
            player2 = new Player(0,ChooseFaction(),graveyard2,board2,hand2);
            #endregion
            //que cada jugador coja su mano de 10 cartas 
            #region
            hand1 = player1.GetHand();
            hand2 = player2.GetHand();  
            #endregion
        }

    // Water Tribe
    #region 
    public static LeaderCard waterLeader = new LeaderCard("Katara",  "Water Bender",Position.Leaderposition,Engine.Habilities.ExtraCardFirstRound);
    public static UnitCard waterCard2 = new ("Pakku",  "Water Bender",Position.M,23,
    Habilities.CardTheft);
    public static UnitCard waterCard3 = new ("Hama",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard4 = new ("Yue",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard5 = new ("Kya",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard6 = new ("Ming-Hua",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard7 = new ("Korra",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard8 = new ("Tonraq",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard9 = new ("Eska",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard10 = new ("Desna",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard11 = new ("Unalaq",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard12 = new ("Tarrlok",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard13 = new ("Hu",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard14 = new ("Thod",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard15 = new ("Vachir",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard16 = new ("Shirshu",  "Water Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard17 = new ("Admiral Zhao",  "Fire Bender",Position.R,20,Habilities.CardTheft);
    public static UnitCard waterCard18 = new ("June",   "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard19 = new ("Song",  "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard20 = new ("Bato",  "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard21 = new ("Pipsqueak",  "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard22 = new ("The Duke",  "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard23 = new ("Tyro",  "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard24 = new ("The Painted Lady",  "Non-bender", Position.S,57,Habilities.CardTheft);
    public static UnitCard waterCard25 = new ("Tui and La",  "Spirit", Position.S,57,Habilities.CardTheft);
    public static UnitCard[] WaterDeck = {waterCard2, waterCard3, waterCard4, waterCard5, waterCard6, waterCard7, waterCard8, waterCard9, waterCard10, waterCard11, waterCard12, waterCard13, waterCard14, waterCard15, waterCard16, waterCard17, waterCard18, waterCard19, waterCard20, waterCard21, waterCard22, waterCard23, waterCard24, waterCard25};
    static WaterTribe WaterTribe = new WaterTribe(WaterDeck,waterLeader);
    #endregion
    // Air Nomads
    #region 
    public static LeaderCard airLeader = new LeaderCard ("Aang", "Air Bender",Position.Leaderposition,Engine.Habilities.ExtraCardSecondRound);
    public static UnitCard airCard2 = new ("Gyatso", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard3 = new ("Tenzin", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard4 = new ("Jinora", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard5 = new ("Ikki", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard6 = new ("Meelo", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard7 = new ("Opal", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard8 = new ("Kai", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard9 = new ("Rohan", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard10 = new ("Tashi", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard11 = new ("Avatar Yangchen", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard12 = new ("Yanchen", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard13 = new ("Roku", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard14 = new ("Kyoshi", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard15 = new ("Kuruk", "Air Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard16 = new ("Avatar Wan", "Fire Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard17 = new ("Avatar Korra", "Water Bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard18 = new ("Appa", "Sky Bison",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard19 = new ("Momos", "Flying Lemur",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard20 = new ("Hawky", "Messenger Hawk",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard21 = new ("Flying Boar", "Non-bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard22 = new ("Wan Shi Tong", "Spirit",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard23 = new ("The Lion Turtle", "Spirit",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard24 = new ("Lemur", "Non-bender",Position.M,35,Habilities.MultiPoints);
    public static UnitCard airCard25 = new ("Bosco", "Bear",Position.M,35,Habilities.MultiPoints);
    public static UnitCard[] AirDeck = {airCard2, airCard3, airCard4, airCard5, airCard6, airCard7, airCard8, airCard9, airCard10, airCard11, airCard12, airCard13, airCard14, airCard15, airCard16, airCard17, airCard18, airCard19, airCard20, airCard21, airCard22, airCard23, airCard24, airCard25};
    static AirNomads AirNomads = new AirNomads(AirDeck,airLeader);
    #endregion

    // Fire Nation
    #region 
    public static LeaderCard fireLeader = new LeaderCard("Zuko", "Fire Bender",Position.Leaderposition,Engine.Habilities.TieWon);
    public static UnitCard fireCard2 = new ("Azula", "Fire Bender",Position.S,56,Habilities.CardTheft);
    public static UnitCard fireCard3 = new ("Iroh", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard4 = new ("Ozai", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard5 = new ("Mai", "Non-bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard6 = new ("Ty Lee", "Non-bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard7 = new ("Zhao", "Non-bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard8 = new ("Ran and Shaw", "Fire Lion Turtle",Position.S,56,Habilities.None);
    public static UnitCard fireCard9 = new ("Combustion Man", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard10 = new ("Lo and Li", "Non-bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard11 = new ("Jeong Jeong", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard12 = new ("Sozin", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard13 = new ("Azulon", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard14 = new ("Shyu", "Non-bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard15 = new ("Fire Lord Sozin", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard16 = new ("Fire Lord Azulon", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard17 = new ("Fire Lord Zuko", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard18 = new ("Fire Lord Ozai", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard19 = new ("Fire Lord Iroh", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard20 = new ("Fire Lord Azula", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard21 = new ("Fire Lord Sozin", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard22 = new ("Izumi", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard23 = new ("Fire Lord Azulon", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard24 = new ("Azulon", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard fireCard25 = new ("Iroh II", "Fire Bender",Position.S,56,Habilities.None);
    public static UnitCard[] FireDeck = {fireCard2, fireCard3, fireCard4, fireCard5, fireCard6, fireCard7, fireCard8, fireCard9, fireCard10, fireCard11, fireCard12, fireCard13, fireCard14, fireCard15, fireCard16, fireCard17, fireCard18, fireCard19, fireCard20, fireCard21, fireCard22, fireCard23, fireCard24, fireCard25};
    static FireNation FireNation = new FireNation(FireDeck,fireLeader);
    #endregion
    // Earth Kingdom
    #region 
    public static LeaderCard earthLeader = new LeaderCard("Toph", "Earth Bender",Position.Leaderposition,Engine.Habilities.StayBetweenRounds);
    public static UnitCard earthCard2 = new ("King Bumi", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard3 = new ("Lin Beifong", "Metal Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard4 = new ("Suyin Beifong", "Metal Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard5 = new ("Wei", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard6 = new ("Wing", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard7 = new ("Huan", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard8 = new ("Kuvira", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard9 = new ("Ghazan", "Lavabender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard10 = new ("Ming-Hua", "Water Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard11 = new ("P\'Li", "Combustion Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard12 = new ("Avatar Kyoshi", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard13 = new ("Avatar Yangchen", "Air Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard14 = new ("Avatar Kuruk", "Water Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard15 = new ("Avatar Roku", "Fire Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard16 = new ("Avatar Wan", "Fire Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard17 = new ("Avatar Korra", "Water Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard18 = new ("Avatar Aang", "Air Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard19 = new ("Bosco", "Bear",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard20 = new ("The Lion Turtle", "Spirit",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard21 = new ("Wan Shi Tong", "Spirit",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard22 = new ("Hayao", "Non-bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard23 = new ("Bolin", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard24 = new ("Wei", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard earthCard25 = new ("Wing", "Earth Bender",Position.R,43,Habilities.IncreaseRow);
    public static UnitCard []EarthDeck = {earthCard2, earthCard3, earthCard4, earthCard5, earthCard6, earthCard7, earthCard8, earthCard9, earthCard10, earthCard11, earthCard12, earthCard13, earthCard14, earthCard15, earthCard16, earthCard17, earthCard18, earthCard19, earthCard20, earthCard21, earthCard22, earthCard23, earthCard24, earthCard25};
    static EarthKingdom EarthKingdom = new EarthKingdom(EarthDeck,earthLeader);
    #endregion
    
    public static Faction ChooseFaction()
    {    
        Faction faction = FireNation;//parche: puse fireNAtion por defecto porq cuando lo quito me da error el return
        System.Console.WriteLine("To start playing you must select your faction:\n Write\n 0 for the Fire Nation\n 1 for the Water Tribe\n 2 for the Earth Kingdom\n 3 for the Air Nomads");
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
   
    public static int FirstPlayer ()
    {
        var randon = new Random();
        int ran = randon.Next(1,3);
        return ran; 
    }
    
    //Imprimir el Board
    public static void PrintBoard(Board board)
    {
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < board.board.GetLength(1); j++)
            {
                try
                {
                    System.Console.Write(board.board[i,j].name);
                    Console.Write(" - ");
                }
                catch (System.Exception)
                {
                    Console.Write(0 + " - ");
                }
            }
            Console.WriteLine();
        }
    }

    public static void PrintPoints(Player player1, Player player2)
    {
        System.Console.WriteLine("Player1 Ptos: " + player1.Points);
        System.Console.WriteLine("Player2 Ptos: " + player2.Points);
    }  
        
        
}    
