using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class matrix
    {
        private int[,] matrixOfIntegers;

        // конструктор. кол-во строк и кол-во столбцов
        public matrix(int linesLenght, int columnsLenght)
        {
            matrixOfIntegers = new int[linesLenght, columnsLenght];
        }
        // конструктор. матрицы целых чисел
        public matrix(int[,] matrixOfIntegers)
        {
            this.matrixOfIntegers = new int[matrixOfIntegers.GetLength(0), matrixOfIntegers.GetLength(1)];
            this.matrixOfIntegers = matrixOfIntegers;
        }

        // свойсвто для определения количества строк матрицы
        public int numberOfLines
        {
            get { return matrixOfIntegers.GetLength(0); }
        }
        // свойство для определния количества столбцов матрицы
        public int numberOfColumns
        {
            get { return matrixOfIntegers.GetLength(1); }
        }
        // индексатор для доступа к элементам поля-массива
        public int this[int row, int col]
        {
            get { return matrixOfIntegers[row, col]; }
            set { matrixOfIntegers[row, col] = value; }
        }
        // вычисление произведеия отрицательных элементов матрицы
        public int productMatrix()
        {
            int composition = 1;

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (matrixOfIntegers[i, j] < 0)
                    {
                        composition = composition * matrixOfIntegers[i, j];
                    }
                }
            }
            return composition;
        }
        // вычисление произведеия отрицательных элементов матрицы, в четных строках
        public int productMatrixEvenNumbers()
        {
            int composition = 1;

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    if (matrixOfIntegers[i, j] < 0)
                    {
                        if ((i + 1) % 2 == 0)
                        {
                            composition = composition * matrixOfIntegers[i, j];
                        }
                    }
                }
            }

            return composition;
        }
    }
}
