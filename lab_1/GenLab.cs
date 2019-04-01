using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class GenLab
    {
        const int x = 15, h = 15;

        public char[,] _lab = new char[x, h];
        public int X { get { return x; } }
        public int Y { get { return h; } }
        private List<Cells> _blue = new List<Cells>();
        Random r = new Random();

        // размер лабиринта ДОЛЖЕН быть не четный!!
        private void InitializeLab()
        {
            for (int i = 0; i < x; i++)
                for (int j = 0; j < h; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0) _lab[i, j] = ' ';
                    else _lab[i, j] = '#';
                }
        }

        private void GenicLab()
        {
            InitializeLab();

            Cells cell = new Cells(1, 1);
            Stack<Cells> cells = new Stack<Cells>();
            cells.Push(cell);

            while (cells.Count != 0) //Пока есть непосещенные клетки
            {
                cell = cells.Pop();

                var getNeb = getNeighbours(cell);// список непосещенных «соседей»
                if (getNeb.Count > 0) //Если текущая клетка имеет непосещенных «соседей»
                {
                    cells.Push(cell);//Протолкните текущую клетку в стек

                    int kl = r.Next(0, getNeb.Count); //Выберите случайную клетку из соседних
                    DeleteWall(getNeb[kl], cell); //Уберите стенку между текущей клеткой и выбранной. Отметьте ее как посещенную.
                    cells.Push(getNeb[kl]); // Запихиваем в стэк новую клетку.
                }
            }
        }

        public void GenirLab() // 
        {
            GenicLab(); // Вызывает все методы, которые создают лабиринт и золото. На выходе готовый лабиринт
            GenricMoney();
        }


        private void DeleteWall(Cells ceNew, Cells ceOld)
        {
            int x = ceOld.X - ceNew.X;
            x = ceOld.X - x / 2;

            int y = ceOld.Y - ceNew.Y;
            y = ceOld.Y - y / 2;

            _lab[ceNew.X, ceNew.Y] = (char)cell.Ground;
            _lab[ceOld.X, ceOld.Y] = (char)cell.Ground;
            _lab[x, y] = (char)cell.Ground;
        }

        private void GenricMoney()
        {
            const int square = x * h;
            int countMoney = 1;
            switch(square)
            {
                case square when square <= 25:
                    countMoney = 1;
                    break;
                case square when square <= 81:
                    countMoney = 2;
                    break;
                case square when square <= 121:
                    countMoney = 3;
                    break;
                default:
                    countMoney = 4;
                    break;

            }
            for (int i = 1; i < countMoney; i++)
            {
                _lab[r.Next(1, x-1), r.Next(1, h-1)] =(char)cell.Money;
            }
          
        } //От размера массива зависит количество денег

        private List<Cells> getNeighbours(Cells cells) // найти всех соседей
        {
            var Lcells = new List<Cells>();
            if (cells.X + 2 < x && _lab[cells.X + 2, cells.Y] == ' ')
            {
                Lcells.Add(new Cells(cells.X+2,cells.Y));
            }
            if (cells.X - 2 >= 0 && _lab[cells.X - 2, cells.Y] == ' ')
            {
                Lcells.Add(new Cells(cells.X - 2, cells.Y));
            }
            if (cells.Y + 2 < h && _lab[cells.X, cells.Y + 2] == ' ')
            {
                Lcells.Add(new Cells(cells.X,cells.Y+2));
            }
            if (cells.Y - 2 >=0 && _lab[cells.X, cells.Y - 2] == ' ')
            {
                Lcells.Add(new Cells(cells.X,cells.Y-2));
            }
            return Lcells;
        }

    }
}
