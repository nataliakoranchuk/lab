using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    static class Drowing
    {
       static  public void PrintLab(Char[,] _lab, int x, int h)
        {
            var hero = Hero.GetHero;
            Console.Clear();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < h; j++)
                {
                    if (hero.X == i && hero.Y == j) //если это герой
                    {
                        Console.Write(hero.Symbol); //показать символ героя
                        if (_lab[i, j] == (char)cell.Money) // если герой нашёл монетку
                        {
                            _lab[i, j] = (char)cell.Ground;
                            hero.Money++;
                        }
                    }

                    else //иначе это может быть земля,деньги,стены
                    {
                        if (_lab[i, j] == (char)cell.Money) //если это монетка, то цвет желтый
                            Console.ForegroundColor = ConsoleColor.Yellow;
                         else if (_lab[i, j] == (char)cell.Ground) //если это земля, то цвет зеленый
                             Console.ForegroundColor = ConsoleColor.DarkGreen;

                        Console.Write(_lab[i, j]);
                        Console.ResetColor();
                    }

                }
            }
            Console.WriteLine();
            Console.WriteLine(" Money :" + hero.Money);
        }
    }
}
