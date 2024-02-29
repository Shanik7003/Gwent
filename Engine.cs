using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Engine;
    // enum Faction
    // {
    //     FireNation = 0,
    //     WaterTribe = 1,
    //     EarthDeck = 2,
    //     AirNomads = 3,
    // }
    public enum Habilities
    {
        //unitcard habilities
            IncreaseRow = 0,
            EliminateMostPowerful = 1,
            EliminateLeastPowerful = 2,
            MultiPoints = 3,
            CleanRow = 4,
            WheatherSet = 5,
            CardTheft = 6, //robar una carta del deck y agregarla a tu mano 
            None = 7,
        
       //specialcard habilities
            CommanderHorn = 0,//(aumento)duplica la fuerza de todas las cartas de la fila en la q se coloque
            Lure = 2,//(señuelo)
            Frost = 3,//(clima)Cambia la fuerza de todas las cartas de combate cuerpo a cuerpo de ambos jugadores a 1.
            Fog = 4,//(clima)Cambia la fuerza de todas las cartas de combate a distancia de ambos jugadores a 1.
            Rain = 5,//(clima)Cambia la fuerza de todas las cartas de combate de asedio de ambos jugadores a 1.
            ClearWheather = 6,// (despeje)Descarta todas las cartas de clima que haya en el campo de batalla y anula sus efectos.

        
       //leader habilities
            ExtraCardFirstRound = 0,//robar una carta extra al inicio de la segunda ronda
            ExtraCardSecondRound = 1,//robar una carta extra al inicio de la segunda ronda
            TieWon = 2,//empate ganado
            StayBetweenRounds = 3, // mantener una carta aleatoria entre rondas 
        
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
        Leaderposition =7,
    }
    
    public class Card
    {
        public string name{get;private set;}
  
        public string description{get;private set;}
        public Position position{get;private set;}
        public int points{get;private set;}

        public Card(string name,string description, Position position,int points)
        {
            this.name = name;
            this.description= description;
            this.position = position;
            this.points = points;
        }
    }
    public class UnitCard : Card
    {
        public Habilities hability{get; private set;}
        public UnitCard(string name,string description,Position position,int points, Habilities hability) : base(name,description, position,points)
        {
            this.hability = hability;
        }
        
    }
   
    public class WheatherCard : UnitCard
    {
        public WheatherCard(string name, string description,Position position,Habilities hability,int points) : base(name,description,position,0,hability){}
    }
    public class CommanderHorn : UnitCard
    {
        public CommanderHorn(string name, string description,Position position,Habilities hability,int points) : base(name,description,Position.MRS,0,hability){}
    }

    public class LeaderCard : UnitCard
    {
            public LeaderCard(string name, string description,Position position,Habilities hability) : base(name,description,Position.Leaderposition,0,hability){} 
    }

    public class Faction
    {
        public LeaderCard leader;
        public UnitCard[] Deck = new UnitCard[24];
        public Faction(UnitCard[] Deck, LeaderCard leader)
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
       public FireNation (UnitCard[] FireDeck, LeaderCard leader) : base (FireDeck, leader) {}
    }
    public class WaterTribe : Faction
    {
        public WaterTribe (UnitCard[] WaterDeck,LeaderCard leader) : base (WaterDeck,leader){}   
    }
    public class AirNomads : Faction
    {
        public AirNomads (UnitCard[] AirDeck,LeaderCard leader) : base(AirDeck,leader){}
    }
    public class EarthKingdom : Faction
    {
        public EarthKingdom(UnitCard[] EarthDeck, LeaderCard leader): base (EarthDeck,leader){}
    }

    public class Player
    {
        public int Points;
        public Faction Faction;
        public List<UnitCard> Graveyard;
        public Board Board;
        List<UnitCard> Hand;
        public Player(int points, Faction faction, List<UnitCard> graveyard, Board board,List<UnitCard>hand)
        {
            Points = points;
            Faction = faction;
            Graveyard = graveyard;
            Board = board;
            Hand = hand;

        }
        public List<UnitCard> GetHand()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                UnitCard card = Faction.Deck[random.Next(0,24)];
                this.Hand.Add(card);
            }
            return Hand;
        }
         public  UnitCard SelectCard()
        {
           int count = 0;
           System.Console.WriteLine("Select your Card: ");
           foreach (var item in this.Hand)
           {
                System.Console.WriteLine(Convert.ToString(count) + " / "+ item.name + " / " + item.description);
                count++;
           }
           string response = Console.ReadLine()!;
           int SelectedCard = Convert.ToInt32(response);
           UnitCard selectedCard = Hand[SelectedCard];
        //    if(selectedCard is UnitCard)
        //    {
        //         Card selected = Hand[SelectedCard];
        //         return selected;
        //    }
        //     if(selectedCard is WheatherCard)
        //    {
        //         Card selected = Hand[SelectedCard];
        //         return selected;
        //    }

           return selectedCard;
        }

        public void PlayCard()//se lle deberia pasar el jugador en lugar de la carta y q solo pueda escoger de las cartas de la mano de ese jugador
        {
            bool IsSpecialCard = false;
            UnitCard card = SelectCard();//aqui deberia comprobar q tipo de carta es la q seleccionaron y manejar eso por casos 
            if (card is WheatherCard)
            {
                IsSpecialCard = true;
                if (card.position == Position.M)
                {
                    Board.wheatherSpace[(int)Position.M] =  card;
                }
                if (card.position == Position.R)
                {
                    Board.wheatherSpace[(int)Position.R] = card;
                }
                if (card.position == Position.S)
                {
                    Board.wheatherSpace[(int)Position.R] = card;
                }
            }
            if (card is CommanderHorn)
            {
                IsSpecialCard = true;
                Position position = ChooseCommanderHornPosition(card);
                Board.commanderHornSpace[(int)position] = card;
            }
            if(card is UnitCard && !IsSpecialCard)//si la carta es de unidad pero no es ninguna de las cartas especiales 
            {
                if (card.position == Position.M)
                {
                    int i = (int)Position.M;
                        for (int j = 0; j < 9; j++)
                        {
                            if (Board.board[i,j] == null)
                            {
                                Board.board[i,j] = card;
                                Hand.Remove(card);
                                Points += card.points;
                                FreeHablity(card.hability);
                                return;
                            }
                        }
                    
                }
                if (card.position == Position.R)
                {
                    int i = (int)Position.R;
                        for (int j = 0; j < 9; j++)
                        {
                            if (Board.board[i,j]==null)
                            {
                                Board.board[i,j] = card;
                                Hand.Remove(card);
                                Points += card.points;
                                FreeHablity(card.hability);
                                return;
                            }
                        }
                }
                if (card.position == Position.S)
                {
                    int i = (int)Position.S;
                        for (int j = 0; j < 9; j++)
                        {
                            if (Board.board[i,j] == null)
                            {
                                Board.board[i,j] = card;
                                Hand.Remove(card);
                                Points += card.points;
                                FreeHablity(card.hability);
                                return;
                            }
                        }
                }
            }
            //faltan 4 casos MR,MS,RS,MRS(PREGUNTAR EN EL INTERFAZ Y UNA VEZ Q SEPA QUE DECIDIO EL JUGDOR LLAMAR A ESTA FUNCION)

        }
    
        public void PlayCard(CommanderHorn card )
        {
            //aqui tendria q seleccionar la fila en la q la quier poner teniendo en cuenta cuales estan disponibles 

        }
         public static Position ChooseCommanderHornPosition(UnitCard card)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("La carta que seleccionaste es del tipo CommanderHornCard, en que fila deseas ponerla?");
            Console.ResetColor();
            System.Console.WriteLine("0 - Combate Cuerpo a Cuerpo \n1 - Combate a Distancia  \n2 - Combate de Asedio ");
            string response = Console.ReadLine()!;

            if (response == "0")
            {
                return Position.M;
            }
            if (response == "1")
            {
                return Position.R;
            }
            if (response == "2")
            {
                return Position.S;
            }
            //esta funcion sirve para las cartas que tienen mas de una posibilidad de posicion solo habria que tener en cuenta el caso en que la carta
            //tenga solo dos posibilidades y tambien adecuar el metodo para pasarle una Card y no una CommanderHorn
            return Position.MRS;
        }

       // metodo que conecta el enum unitCard HAblity con las funciones de las habilidades
        public void FreeHablity(Habilities hability)
        {
           if (hability == Habilities.CardTheft)
           {
                CardTheft();
           }
        }
      //metodos para las UnitCardHability
         public void CardTheft() //robar una carta 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(" ---SU CARTA POSEIA LA HABILIDAD DE ROBAR UNA CARTA EXTRA DE SU MAZO---");
            Console.ResetColor();
            Random random = new Random();
            UnitCard stolenCard = Faction.Deck[random.Next(1,24)];
            System.Console.WriteLine("SU NUEVA CARTA ES " + stolenCard.name);
            Hand.Add(stolenCard);
            System.Console.WriteLine("ahora su mano tiene las siguientes cartas: ");
            foreach (var item in Hand)
            {
                System.Console.WriteLine(item.name);
            }
        }
        
    }

    public class Board
    {
        public Card[,] board = new Card[3,9]; 
        public Card[] commanderHornSpace = new Card[3];
        public Card[] wheatherSpace = new Card[3];
    }   
    