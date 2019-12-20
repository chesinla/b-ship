using System;
using System.Collections.Generic;

    public class Gameboard
    {

        private static List<Coordinates> coordinates;

        public static void CreateGrid()
        {
            int widthX = 10;
            int heightY = 10;

            int [,] gameGrid = new int[widthX, heightY];


                            int counter = 1; 
                            for (int x = 0; x < widthX; x++)
                {
                    for (int y = 0; y < heightY; y++)
                    {   
                        gameGrid[x,y] = counter;
                        counter++;
                    }
                    Console.WriteLine ();
                }

            // gameGrid[0,0] = 1;
            // for(int i = gameGrid[0,0]; i < 25; i++)
            // {}
            
            
            //for(i = 1; i < gameGrid.SetValue(0,0); i++){
                        // gameGrid[0,0] = 1;
                        // for(int i = gameGrid[0,0]; i < 25; i++)
                        // {
                             
                        // }

                for (int x = 0; x < widthX; x++)
                {
                    for (int y = 0; y < heightY; y++)
                    {
                        Console.Write (gameGrid [x,y] + " | ");
                    }
                    Console.WriteLine ();
                }
        }
           

        public class Coordinates
        {
            public int gridCoordinates;

        }
    }


    // static char[,] gameGrid(int gridSize){

    //    char[,] DefGrid = new char [gridSize, gridSize];

    // return DefGrid;
    // }





