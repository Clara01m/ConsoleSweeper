using System;

namespace consoleSweeper
{
    public class SweeperGrid
    {
        public int[,] grid = new int[15,15];
        //skapar gridden
        public SweeperGrid()
        {//detta är en konstruktor, aka den körs så fort som klassen används
            
            for(int y = 0; y < grid.GetLength(1); y++)  
            {
                for(int x = 0; x < grid.GetLength(1); x++)
                {
                    grid[x, y] = 9;
                }
            }
            //static int CheckPosition (int x, int y)
            //{}
        }
    }
}