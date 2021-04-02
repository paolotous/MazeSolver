using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MazeSolver
{
     class MapUtilities
    {

        public static Map randomMap(int rows, int columns)
        {
            Map m = new Map(rows, columns);

            return m;
        }
        public static Map loadMap(String filePath)
        {
            string line;
            Map m;
            int rows;
            int cols;
            using (StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
            {
                line = sr.ReadLine();
                string[] firstLine = line.Split();
                rows = Convert.ToInt32(firstLine[0]);
                cols = Convert.ToInt32(firstLine[1]);
                m = new Map(rows, cols);
                for(int r = 0; r < rows; r++)
                {
                    line = sr.ReadLine();
                    for(int c = 0; c < cols; c++)
                    {
                        m.setPosition(r, c, line[c]-'0');
                    }
                }
            }

            
            
            return m;
        }

        public static bool recSolver(Map m, int crow, int ccol, int erow, int ecol)
        {
            bool result;
            if(crow < 0 || ccol < 0 || crow >= m.maxRows || ccol >= m.maxColumns)
            {
                return false;
            }
            if(m.getPosition(crow, ccol) == 1 || m.getPosition(crow, ccol) == 2)
            {
                return false;
            }

            if(crow == erow && ccol == ecol)
            {
                m.setPosition(crow, ccol, 8);
                return true;
            }

            m.setPosition(crow, ccol, 2);
            result = recSolver(m, crow - 1, ccol, erow, ecol);
            if(result == true)
            {
                m.setPosition(crow, ccol, 8);
                return true;
            }

            result = recSolver(m, crow, ccol+1, erow, ecol);
            if (result == true)
            {
                m.setPosition(crow, ccol, 8);
                return true;
            }

            result = recSolver(m, crow, ccol-1, erow, ecol);
            if (result == true)
            {
                m.setPosition(crow, ccol, 8);
                return true;
            }

            return false;
        }
    }
}
