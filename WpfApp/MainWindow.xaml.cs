using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WpfApp.ViewModel;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        MatrixRow matrixRow = new MatrixRow();
        int numberLines = 0; // кол-во строк
        int numberColumns = 0; // кол-во столбцов

        // создание матрицы для ввода чисел
        private void CreateMatrix_Click(object sender, RoutedEventArgs e)
        {
            matrixRow = new MatrixRow();
            if (int.TryParse(txtRows.Text, out int rows) && int.TryParse(txtColumns.Text, out int columns))
            {
                // Очистка ItemsControl перед созданием новой матрицы
                matrixItemsControl.Items.Clear();

                // Создание сетки для матрицы соответствующего размера
                Grid matrixGrid = new Grid();
                matrixGrid.HorizontalAlignment = HorizontalAlignment.Center;
                matrixItemsControl.Items.Add(matrixGrid);

                // Создание TextBox-ов для каждого элемента матрицы
                for (int i = 0; i < rows; i++)
                {
                    matrixGrid.RowDefinitions.Add(new RowDefinition());

                    for (int j = 0; j < columns; j++)
                    {
                        matrixGrid.ColumnDefinitions.Add(new ColumnDefinition());

                        TextBox elementTextBox = new TextBox();
                        matrixGrid.Children.Add(elementTextBox);
                        // установка положения text в grid
                        Grid.SetRow(elementTextBox, i);
                        Grid.SetColumn(elementTextBox, j);

                        matrixRow.textBoxes.Add(elementTextBox); // получение текстового элемента для дальнейшего использования его данных
                    }
                }
                // размерность матрицы
                numberLines = int.Parse(txtRows.Text.Trim());
                numberColumns = int.Parse(txtColumns.Text.Trim());    
            }
        }

        private void oneParameter(object sender, RoutedEventArgs e)
        {
            int[] array = new int[numberColumns * numberLines];
            int amount1 = 0;
            foreach (var textBox in matrixRow.textBoxes)
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    array[amount1] = value;
                    amount1++;
                }
            }

            int amount = 0;
            matrix matrix = new matrix(numberLines, numberColumns);
            for(int i = 0; i < numberLines; i++)
            {
                for(int j = 0; j < numberColumns; j++)
                {
                    matrix[i, j] = array[amount];
                    amount++;
                }
            }

            int product = matrix.productMatrix();
            int product1 = matrix.productMatrixEvenNumbers();
            MessageBox.Show($"Работа конструктора с двумя параметрами\n\nПроизведение отрицательных элементов: {product}\nПроизведения отрицательных элементов, в четных строках: {product1}");
        }

        public void twoParameters(object sender, RoutedEventArgs e)
        {
            int[] array = new int[numberColumns * numberLines];
            int amount1 = 0;
            foreach (var textBox in matrixRow.textBoxes)
            {
                if (int.TryParse(textBox.Text, out int value))
                {
                    array[amount1] = value;
                    amount1++;
                }
            }

            int[,] twoArray = new int[numberLines, numberColumns];
            int amount = 0;
            for (int i = 0; i < numberLines; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    twoArray[i, j] = array[amount];
                    amount++;
                }
            }
            matrix matrix = new matrix(twoArray);

            int product = matrix.productMatrix();
            int product1 = matrix.productMatrixEvenNumbers();
            MessageBox.Show($"Работа конструктора с одним параметром\n\nПроизведение отрицательных элементов: {product}\nПроизведения отрицательных элементов, в четных строках: {product1}");
        }


    }
}