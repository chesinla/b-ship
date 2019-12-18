using System;
using System.Collections.Generic;


public class Game
{
    readonly static int BOARD_SIZE;
    readonly static int NUMBER_OF_PLAYERS;

    private static List<Player> Players;

    static Game()
    {
        BOARD_SIZE = 10;
        NUMBER_OF_PLAYERS = 2;
    }

    static void Main()
    {
        Welcome();
        arePlayersReady();
        CreatePlayers();
    }


    public class Player
    {      
        public string playerName {get; set;}

        public Player(string playerName)
        {}
    }
    static char[,] grid(int gridSize){

       char[,] DefGrid = new char [gridSize, gridSize];

    return DefGrid;


}
    public enum Ships
    {

       Carrier = 5,
       Bomber = 4,
       Submarine = 3,
       Cruiser = 3,
       Destroyer = 2
    }
    


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









//METHODS FOR GAME FUNCTIONALITY AND LOGIC***


//THIS PAUSEFORUSERINPUT METHOD PROMPTS A MESSAGE TO THE USER VIA CONSOLE AND WAITS FOR APPROPRIATE RESPONSE
    public static void PauseForUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        Console.ReadKey(true);
        // int x = CaptureNumber("this is a user comptentency test, enter a number...");
        // Console.WriteLine("the value entered is {0}", x);

    }

// THIS IS THE CAPTURENUMBER() METHOD, IT WILL BE USED TO ENSURE COORDINATES ENTERED ARE int WHEN BATTLING IS OCCURRING
    static int CaptureNumber(string prompt){
        Console.WriteLine(prompt);
        int output;
        while(!Int32.TryParse(Console.ReadLine(), out output)){
            Console.WriteLine("you blewww it! Try Again!!");
        }
        return output;
    }



}    