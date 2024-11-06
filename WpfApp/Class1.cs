
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WpfApp
{
    public class matrix
    {
        private int[,] matrixOfIntegers;

        // �����������. ���-�� ����� � ���-�� ��������
        public matrix(int linesLenght, int columnsLenght)
        {
            matrixOfIntegers = new int[linesLenght, columnsLenght];
        }
        // �����������. ������� ����� �����
        public matrix(int[,] matrixOfIntegers)
        {
            this.matrixOfIntegers = new int[matrixOfIntegers.GetLength(0), matrixOfIntegers.GetLength(1)];
            this.matrixOfIntegers = matrixOfIntegers;
        }

        // �������� ��� ����������� ���������� ����� �������
        public int numberOfLines
        {
            get { return matrixOfIntegers.GetLength(0); }
        }
        // �������� ��� ���������� ���������� �������� �������
        public int numberOfColumns
        {
            get { return matrixOfIntegers.GetLength(1); }
        }
        // ���������� ��� ������� � ��������� ����-�������
        public int this[int row, int col]
        {
            get { return matrixOfIntegers[row, col]; }
            set { matrixOfIntegers[row, col] = value; }
        }
        // ���������� ����������� ������������� ��������� �������
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
        // ���������� ����������� ������������� ��������� �������, � ������ �������
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
