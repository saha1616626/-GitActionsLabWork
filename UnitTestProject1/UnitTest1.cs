using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Исходыне данные
            int[,] matrixTest = { { 0, -2, 0 }, { 0, -2, 0 }, { 0, -2, 0 } };
            int expected = -8;

            // Получение значения с помощью тестируемого метода
            matrix matrix = new matrix(matrixTest);
            int result = matrix.productMatrix();

            // срвнение ожидаемого резульатат с полученным
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            matrix matrix = new matrix(3, 3);
            matrix[0, 0] = 0;
            matrix[0, 1] = -2;
            matrix[0, 2] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = -2;
            matrix[1, 2] = 0;
            matrix[2, 0] = 0;
            matrix[2, 1] = -2;
            matrix[2, 2] = 0;

            // Исходыне данные
            int[,] matrixTest = { { 0, -2, 0 }, { 0, -2, 0 }, { 0, -2, 0 } };
            int expected = -2;

            // Получение значения с помощью тестируемого метода

            int result = matrix.productMatrixEvenNumbers();

            // срвнение ожидаемого резульатат с полученным
            Assert.AreEqual(expected, result);
        }
    }
}
