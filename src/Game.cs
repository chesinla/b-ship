using System;
using System.Collections.Generic;
using static Gameboard;

public class Game
{
    readonly static int NUMBER_OF_PLAYERS;

    private static List<Player> Players;

    private static List<Ship> TheShips;

    static Game()
    {

        NUMBER_OF_PLAYERS = 2;
    }

    static void Main()
    {
        View.Welcome();
        View.arePlayersReady();

        Gameboard.CreateGrid();
        List<Player> gamePlayers = Game.CreatePlayers();
        for (int i = 0; i < gamePlayers.Count; i++)
        {
            //players will have the same cooridates for their ships
            gamePlayers[i].playerShips = Game.createShips();
            View.displayShipInfo(gamePlayers[i].playerShips);
        }
    }


    public class Player
    {
        public string playerName { get; set; }
        public List<Ship> playerShips { get; set; }

        public Player(string playerName)
        {
            this.playerName = playerName;

        }

    }

    private static List<Player> CreatePlayers()
    {
        List<Player> players = new List<Player>();
        for (int i = 0; i < NUMBER_OF_PLAYERS; i++)
        {
            players.Add(new Player("player" + (i + 1)));
        }
        return players;
    }

    public static List<Ship> createShips()
    {
        List<Ship> theShips = new List<Ship>();

        //hardcoded for testing
        List<Coordinates> carrierCoordinates = new List<Coordinates>{
                new Coordinates(1, 2),
                new Coordinates(3, 4),
                new Coordinates(5, 6),
                new Coordinates(7, 8),
                new Coordinates(9, 10)
            };
        theShips.Add(new Ship("Carrier", 5, carrierCoordinates));




        //old functionality
        theShips.Add(new Ship { shipName = "Bomber", shipSize = 4 });
        theShips.Add(new Ship { shipName = "Submarine", shipSize = 3 });
        theShips.Add(new Ship { shipName = "Cruiser", shipSize = 3 });
        theShips.Add(new Ship { shipName = "Destroyer", shipSize = 2 });

        return theShips;
    }

    public class Ship
    {

        public string shipName { get; set; }
        public int shipSize { get; set; }

        public List<Coordinates> shipCoordinates { get; set; }

        public Ship(string shipName, int shipSize, List<Coordinates> shipCoordinates)
        {
            this.shipName = shipName;
            this.shipSize = shipSize;
            this.shipCoordinates = shipCoordinates;
        }
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

        static int CaptureNumber(string prompt)
        {
            Console.WriteLine(prompt);
            int output;
            while (!Int32.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("you blewww it! Try Again!!");
            }
            return output;
        }


        public static void displayShipInfo(List<Ship> shipsInfo)
        {
            Console.WriteLine("Here is info about your battleships...");
            foreach (Ship S in shipsInfo)
            {
                Console.WriteLine(S.shipName + " " + S.shipSize);
            }
        }



        public void placeShips()
        {

            //List<Ship> theShips = createShips();
            PauseForUserInput("Now it's time to place our battleships, Be Strategic!!, Player1 you are up first, place any key to continue");
            Console.WriteLine("Enter coordinates when prompted");
            //Console.WriteLine("Firstly, here our the ships for each player..." {<theShips.shipName});


        }
    }
}