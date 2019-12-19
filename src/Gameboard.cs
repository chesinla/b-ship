using System;


    public class Gameboard
    {
        public static void CreateGrid()
        {
            int widthX = 5;
            int heightY = 5;

            int [,] gameGrid = new int[widthX, heightY];
            
            for (int x = 0; x < widthX; x++)
            {
                for (int y = 0; y < heightY; y++)
                {
                    Console.Write (gameGrid [x,y] + " | ");
                }
                Console.WriteLine ();
            }
        }    
    }


    // static char[,] gameGrid(int gridSize){

    //    char[,] DefGrid = new char [gridSize, gridSize];

    // return DefGrid;
    // }





