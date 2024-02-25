namespace Engine;
    // enum Faction
    // {
    //     FireNation = 0,
    //     WaterTribe = 1,
    //     EarthDeck = 2,
    //     AirNomads = 3,
    // }
    public enum UnitCardHability
    {
        IncreaseRow = 0,
        EliminateMostPowerful = 1,
        EliminateLeastPowerful = 2,
        MultiPoints = 3,
        CleanRow = 4,
        WheatherSet = 5,
        CardTheft = 6, 
        None = 7,
    }

    public enum SpecialCardHability
    {
        CommanderHorn = 0,//(aumento)duplica la fuerza de todas las cartas de la fila en la q se coloque
        Lure = 2,//(señuelo)
        Frost = 3,//(clima)Cambia la fuerza de todas las cartas de combate cuerpo a cuerpo de ambos jugadores a 1.
        Fog = 4,//(clima)Cambia la fuerza de todas las cartas de combate a distancia de ambos jugadores a 1.
        Rain = 5,//(clima)Cambia la fuerza de todas las cartas de combate de asedio de ambos jugadores a 1.
        ClearWheather = 6,// (despeje)Descarta todas las cartas de clima que haya en el campo de batalla y anula sus efectos.

    }

    public enum Position
    {
        M = 0,//cuerpo a cuerpo
        R = 1,//distancia
        S = 2,//asedio
        MR = 3,
        MS = 4,
        RS = 5,
        MRS = 6,
    }
    public enum LeaderHability
    {
        ExtraCardFirstRound=0,//robar una carta extra al inicio de la segunda ronda
        ExtraCardSecondRound=1,//robar una carta extra al inicio de la segunda ronda
        TieWon=2,//empate ganado
        StayBetweenRounds=3, // mantener una carta aleatoria entre rondas 
    }
    public class Card
    {
        public string name{get;private set;}
  
        public string description{get;private set;}

        public Card(string name,string description)
        {
            this.name = name;
          
            this.description= description;
        }
    }
    public class UnitCard : Card
    {
        public Position position{get;private set;}
        public int points{get;private set;}
        public UnitCardHability hability{get;private set;}
        public UnitCard(string name,string description,Position position,int points, UnitCardHability hability) : base(name,description)
        {
            this.position = position;
            this.points = points;
            this.hability = hability;
        }
    }

    public class HeroeCard : UnitCard 
    {
        public HeroeCard(string name,string description,Position position,int points, UnitCardHability UnitCardHability) : base (name,description,position,points,UnitCardHability){}
    }
    public class SpecialCard : Card 
    {
        public SpecialCardHability hability{get;private set;}
        public SpecialCard(string name, string description,SpecialCardHability hability) : base(name, description)
        {
            this.hability = hability;
        }
    }
    public class WheatherCard : SpecialCard
    {
        public Position position{get;private set;}
        public WheatherCard(string name, string description,Position position,SpecialCardHability hability):base(name,description,hability)
        {
            this.position = position;
        }
    }
    public class CommanderHorn : SpecialCard
    {
        public Position position{get;private set;}
        public CommanderHorn(string name, string description,Position position,SpecialCardHability hability):base(name,description,hability)
        {
            this.position = position;
        }
    }

    public class LeaderCard : Card
    {
        public LeaderHability hability{get;private set;}
        public LeaderCard(string name, string description,LeaderHability hability) : base(name,description)
        {
            this.hability = hability;
        } 
    }

    public class Faction
    {
        public LeaderCard leader;
        public Card[] Deck = new Card[24];
        public Faction(Card[] Deck, LeaderCard leader)
        {
           for (int i = 0; i < Deck.Length; i++)
           {
            this.Deck[i] = Deck[i];   
           } 
           this.leader = leader;
        }
    }
    public class FireNation : Faction
    {
       public FireNation (Card[] FireDeck, LeaderCard leader) : base (FireDeck, leader) {}
    }
    public class WaterTribe : Faction
    {
        public WaterTribe (Card[] WaterDeck,LeaderCard leader) : base (WaterDeck,leader){}   
    }
    public class AirNomads : Faction
    {
        public AirNomads (Card[] AirDeck,LeaderCard leader) : base(AirDeck,leader){}
    }
    public class EarthKingdom : Faction
    {
        public EarthKingdom(Card[] EarthDeck, LeaderCard leader): base (EarthDeck,leader){}
    }

    public class Player
    {
        public int Points;
        public Faction Faction;
        public List<Card> Graveyard;
        public Board Board;
        List<Card> Hand;
        public Player(int points, Faction faction, List<Card> graveyard, Board board,List<Card>hand)
        {
            Points = points;
            Faction = faction;
            Graveyard = graveyard;
            Board = board;
            Hand = hand;

        }
        
        public List<Card> GetHand()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Card card = Faction.Deck[random.Next(0,24)];
                this.Hand.Add(card);
            }
            return Hand;
        }
        public void PlayCard()
        {

        }
        
    }

    public class Board
    {
        public Card[,] board = new Card[3,9]; 
        public Card[] commanderHornSpace = new Card[3];
        public Card[] wheatherSpace = new Card[3];

    }   
    