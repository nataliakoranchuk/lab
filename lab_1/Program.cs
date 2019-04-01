using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GenLab lab = new GenLab();
            var hero = Hero.GetHero;
            Console.WriteLine("Нажмите r, чтобы сгенерить лабиринт");
            ConsoleKeyInfo key;
            do {
                key = Console.ReadKey();

                switch (key.Key) {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        {
                            if (lab._lab[hero.X-1, hero.Y] != (char)cell.Wall) hero.X--;
                            break;
                        }
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        {
                            if (lab._lab[hero.X , hero.Y+1] != (char)cell.Wall) hero.Y++;
                            break;
                        }
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        {
                            if (lab._lab[hero.X+1, hero.Y] != (char)cell.Wall) hero.X++;
                            break;
                        }
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        {
                            if (lab._lab[hero.X, hero.Y-1] != (char)cell.Wall) hero.Y--;
                            break;
                        }
                    case ConsoleKey.R:
                    {
                            lab.GenirLab();
                            break;
                    }
                }
                Drowing.PrintLab(lab._lab,lab.X,lab.Y);

            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
