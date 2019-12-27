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

                int highestDigit = widthX * heightY;

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


                for (int x = 0; x < widthX; x++)
                {
                    for (int y = 0; y < heightY; y++)
                    {   

                        var digitCounter = gameGrid[x,y].ToString().Length;
                        Console.Write (gameGrid [x,y] + gridPadding(highestDigit, gameGrid[x,y]) + " | ");
                    }
                    Console.WriteLine ();
                }
        }
           
        public static string gridPadding(int highestDigit, int currentDigit){
            int highestDigitLength = highestDigit.ToString().Length;
            string padding = "";
            int currentDigitLength = currentDigit.ToString().Length;
            for(int i = 0; i < highestDigitLength - currentDigitLength; i++)
            {
                padding += " ";
            }
            return padding;
        }



        public class Coordinates
        {
            public int gridCoordinates;
            int xCoordinate;

            int yCoordinate;
            
            public Coordinates(int x, int y)
            {
                this.xCoordinate = x;
                this.yCoordinate = y;

            }
        }
    }
