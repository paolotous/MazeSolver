using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int srow;
            int scol;
            int erow;
            int ecol;
            string line;
            string[] splitLine;
            Map mc;
            Map m = MapUtilities.loadMap("D:/map1.txt");
            Console.WriteLine("Please enter a starting row and column: ");
            line = Console.ReadLine();
            splitLine = line.Split();
            srow = Convert.ToInt32(splitLine[0]);
            scol = Convert.ToInt32(splitLine[1]);
            Console.WriteLine("Please enter an ending row and column: ");
            line = Console.ReadLine();
            splitLine = line.Split();
            erow = Convert.ToInt32(splitLine[0]);
            ecol = Convert.ToInt32(splitLine[1]);

            //m.setPosition(srow, scol, 5);
            //m.setPosition(erow, ecol, 3);
            Console.WriteLine(m);
            mc = new Map(m);
            bool result = MapUtilities.recSolver(m, srow, scol, erow, ecol);
            if(result)
            {
                Console.WriteLine(mc.getInfo());
            }
            else
            {
                Console.WriteLine("No Pathway available...");
            }
            Console.Read();
        }
    }
}
