using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class Map
    {
        private int[,] mapData;
        public int maxRows;
        public int maxColumns;

        public Map(int rows, int cols)
        {
            maxRows = rows;
            maxColumns = cols;
            mapData = new int[rows, cols];
        }

        public Map(Map original)
        {
            maxRows = original.maxRows;
            maxColumns = original.maxColumns;
            mapData = new int[maxRows, maxColumns];

            for(int r = 0; r < maxRows; r++)
            {
                for(int c = 0; c < maxColumns; c++)
                {
                    mapData[r, c] = original.mapData[r, c];
                }
            }
        }

       public void setPosition(int row, int col, int value)
        {
            mapData[row, col] = value; 
        }

        public int getPosition(int row, int column)
        {
            return mapData[row, column];
        }

        public override string ToString()
        {
            string s = "";
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxColumns; col++)
                {
                    if(mapData[row, col] == 1)
                    {
                        Console.Write("#");
                    }
                    if(mapData[row, col] == 0)
                    {
                        Console.Write(" ");
                    }
                    if(mapData[row, col] == 5)
                    {
                        Console.Write("S");
                    }
                    if(mapData[row, col] == 3)
                    {
                        Console.Write("E");
                    }
                    Console.Write(mapData[row, col]);
                }
                Console.WriteLine();
            }
            return s;
        }

        public string getInfo()
        {
            string s = "";
            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxColumns; col++)
                {
                    if (mapData[row, col] == 1)
                    {
                        Console.Write("#");
                    }
                    if (mapData[row, col] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (mapData[row, col] == 8)
                    {
                        Console.Write("*");
                    }
                    if (mapData[row, col] == 2)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(mapData[row, col]);
                }
                Console.WriteLine();
            }
            return s;
        }
    }

}
