using Engine;

class Program
{
	static int Main(string[] args)
	{   
		//metodo para preguntarle al jugador si quiere pasar
		static bool PasarJugar()
		{
			System.Console.WriteLine("Deseas pasar para terminar la Ronda? \n 0 - si deseas pasar \n 1 - se deseas jugar una carta" );
			string response = Console.ReadLine()!;
			if(response == "1")
			{
				return true;
			}
			if(response == "0")
			{
				return false;
			}
			return false;

		}

		//global variables
		bool pass1 = false;
		bool pass2 = false;
		int count = Game.FirstPlayer();
		if (count == 1)
		{
			System.Console.WriteLine("----------LA MONEDA HA DECIDIDO, EL PLAYER" + count + " COMENZARÁ LA PARTIDA----------") ;
		}
		if (count==2)
		{
			System.Console.WriteLine("----------LA MONEDA HA DECIDIDO, EL PLAYER" + count + " COMENZARÁ LA PARTIDA----------") ;
		}

		//Crea el juego!!!
		Game game = new Game();

		//Empieza el juego!!!
		while (true)
		{  
			if(count%2 == 0)
			{
				if(pass1)//si el jugador ya pasó
				{
					Console.ForegroundColor = ConsoleColor.Red;
					System.Console.WriteLine("----------CONTINUA EL PLAYER 1----------");
					Console.ResetColor();
				}
				else//si no ha pasado
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					System.Console.WriteLine("----------TURNO DEL PLAYER 2----------");
					Console.ResetColor();
				}
				if (!pass1 && PasarJugar()) // si el juagdor decide juagar && no ha pasado
				{
					Game.player2.PlayCard();
					Game.PrintBoard(Game.player2.Board);
					Game.PrintPoints(Game.player1,Game.player2); 
				}
				else //el jugador decide pasar
				{ 
					pass1 = true;
				}
				
			}
			else if (count%2 != 0)
			{
				if(pass2)//si el jugador ya pasó
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					System.Console.WriteLine("----------CONTINUA EL PLAYER2----------");
					Console.ResetColor();
				}
				else//si no ha pasado
				{
					Console.ForegroundColor = ConsoleColor.Red;
					System.Console.WriteLine("----------TURNO DEL PLAYER1----------");
					Console.ResetColor();
				}
				if (!pass2 && PasarJugar())// si el jugador decide juagar && no ha pasado
				{
					Console.ForegroundColor = ConsoleColor.Red;
					System.Console.WriteLine("----------TURNO DEL PLAYER1----------");
					Console.ResetColor();
					
					Game.player1.PlayCard();
					Game.PrintBoard(Game.player1.Board);
					Game.PrintPoints(Game.player1,Game.player2);
				}
				else 
				{
					pass2 = true;
				}
			}
			if(pass1 && pass2) // se termino la primera ronda
			{
				System.Console.WriteLine("----------SE TERMINÓ LA PRIMERA RONDA----------");
				break;
			}
			count++;
		}  
		return 0;
	}
	
}