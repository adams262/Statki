using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statki__EP_AS
{
    internal class Plansza
    {

        public char[,] pole;
        public int n;
        public int m;
        public Plansza(int x, int y)
        {

            n = x;
            m = y;

            pole = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    pole[i, j] = '-';
                }
            }
            
        }

         public void WyswietlPlansze()
        {
            Console.WriteLine("  A B C D E F G H I J");
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + " ");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(pole[i, j]+ " ");
                }
                Console.WriteLine();
            }

        }

        public int[] poz_stat = { 5, 3, 2, 1 };


        public bool UmiescStatek(int rodz,int x,int y,bool poziomy)
        {
            if (poz_stat[rodz - 1] > 0)
            {
                poz_stat[rodz - 1]--;
            }
            else
            {
                Console.WriteLine("Osiegniety limit liczby statkow tego typu");
                return false;
            }
            if (poziomy)
            {
                for (int i = y; i < y + rodz; i++)
                {
                    if (pole[x, i] == '-')
                    {
                        pole[x, i] = (char)(rodz+96);
                    }
                    else
                    {
                        Console.WriteLine("To pole jest zajete");
                        for (int j = i-1; j >=y; j--) {
                            pole[x, i] = '-';

                        }
                        return false;
                    }
                }
            }
            else
            {
                for (int i = x; i < x + rodz; i++)
                {
                    if (pole[i, y] == '-')
                    {
                        pole[i, y] = (char)(rodz + 96);
                    }
                    else
                    {
                        Console.WriteLine("To pole jest zajete");
                        for (int j = i - 1; j >= x; j--)
                        {
                            pole[i, y] = '-';

                        }
                        return false;
                    }
                }

            }
            return true; 
        }

        bool Atak(string ruch)
        {

            int kolumna = ruch[0] - 'A';
            int wiersz = int.Parse(ruch.Substring(1)) - 1;

            if (plansza)

        }




    }
}
