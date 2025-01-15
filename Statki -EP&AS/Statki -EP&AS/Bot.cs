using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Statki__EP_AS
{
    internal class Bot
    {
        public int difficulty;
        public Bot(int diff) {
            difficulty = diff;
        }

        public int[] Put_ship(int n, int m, char[,] plansza)
        {
            Random rnd = new Random();
            rnd.Next(1, 13);
            int[] result = new int[2];
            if (difficulty == 0)
            {
                result[0] = rnd.Next(n+1);
                result[1] = rnd.Next(m+1);

            }
            return result;
        }
        public int[] Select(int n, int m, char[,] plansza)
        {
            int[] result = new int[2];
            result[0] = 0; result[1] = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (plansza[i,j] == '-')
                    {
                        if (difficulty == 0)
                        {
                            result[0] = i; result[1] = j;
                            return result;
                        }
                    }
                }
            }
            return result;
        }
    }
}
