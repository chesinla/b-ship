using System;
using System.Collections.Generic;


public class Game
{
    
    readonly static int NUMBER_OF_PLAYERS;

    private static List<Player> Players;

    static Game()
    {
        
        NUMBER_OF_PLAYERS = 2;
    }

    static void Main()
    {
        View.Welcome();
        View.arePlayersReady();
        
        //CreatePlayers();
        Gameboard.CreateGrid();
    }


    public class Player
    {      
        public string playerName {get; set;}

        public Player(string playerName)
        {
            this.playerName = playerName;
        }

        private static List<Player> CreatePlayers()
        {
            List<Player> players = new List<Player>();
            for(int i = 0; i < NUMBER_OF_PLAYERS; i++){
                Player player1 = new Player("player1");
                Players.Add(player1);
                Player player2 = new Player("player2");
                Players.Add(player2);
            }
            return Players;
        }
    }
    
    


    
    public enum Ships
    {
       Carrier = 5,
       Bomber = 4,
       Submarine = 3,
       Cruiser = 3,
       Destroyer = 2
    }
    





    public class View 
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to Battleship!!!");
            PauseForUserInput("Press any key to continue");
        }

        public static bool arePlayersReady()
        {
            PauseForUserInput("Player 1 press any key");
            Console.WriteLine("Thank you player1, player1 is ready");
            PauseForUserInput("Player 2 press any key");
            Console.WriteLine("Thank you player2, lets get ready ruuuumbbleeee!!!!");
            return true;
        }

        public static void PauseForUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            Console.ReadKey(true);
            // int x = CaptureNumber("this is a user comptentency test, enter a number...");
            // Console.WriteLine("the value entered is {0}", x);
        }

        static int CaptureNumber(string prompt){
            Console.WriteLine(prompt);
            int output;
            while(!Int32.TryParse(Console.ReadLine(), out output)){
                Console.WriteLine("you blewww it! Try Again!!");
            }
            return output;
        }
        

        public static void placeShips()
        {
            PauseForUserInput("Now it's time to place our battleships, Be Strategic!!, Player1 you are up first, place any key to continue");
            Console.WriteLine("Enter coordinates when prompted"); 

        }

    }
}    