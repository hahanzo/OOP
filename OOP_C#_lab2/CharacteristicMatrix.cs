using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_C__lab2
{
    internal class CharacteristicMatrix
    {
        #region поля
        int[,] matrix;
        int[] columnSums;
        #endregion
        #region властивості та індексатори
        /// <summary>
        /// Кількість рядків матриці
        /// </summary>
        public int RowCount { get; set; }
        /// <summary>
        /// Кількість стовпців матриці
        /// </summary>
        public int ColCount { get; set; }
        /// <summary>/// Масив зі значеннями абсолютної суми елементів кожного рядка ///</summary>
        public int[] WithoutNegetivRowsSum
        {
            get
            {
                if (columnSums == null)
                    СomputeWithoutNegetivRowsSum();
                return columnSums;
            }
        }/// <summary>/// Індексатор для отримання значення елементів масиву за індексом ///</summary>
        public int this[int i, int j]
        {
            get
            {

                if (i < RowCount && i >= 0 && j < ColCount && j >= 0)
                    return matrix[i, j];
                else throw new IndexOutOfRangeException("Індекс виходить за межі масиву!");
            }
        }
        #endregion
        #region конструктори
        /// <summary>
        /// Конструктор класу
        /// </summary>
        public CharacteristicMatrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentException("Кількість рядків та стовпців матриці має бути більше нуля.");
            }
            matrix = new int[rows, cols];
            RowCount = matrix.GetLength(0);
            ColCount = matrix.GetLength(1);
        }
        #endregion
        #region методи
        /// <summary>
        /// Заповнює елементи масиву випадковими числами
        /// </summary>
        /// <param name="min">мінімальне значення елементу</param>
        /// <param name="to">максимальне значення елементу</param>
        public void FillElementsRandom(int max, int min)
        {
            if (max <= min)
            {
                throw new ArgumentException("Максимельне значення має бути більше або рівне мінімальному.");
            }
            Random rand = new Random();
            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < ColCount; j++)
                    matrix[i, j] = rand.Next(min, max + 1);
        }
        /// <summary>
        /// Сортування рядків матриці за зростанням
        /// суми абсолютних значень елементів рядків
        /// </summary>
        public int MaxParallelDiagonalSum()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxSum = int.MinValue;

            for (int j = 0; j < cols; j++)
            {
                int diagonalSum = 0;
                for (int i = 0; i < rows && j + i < cols; i++)
                {
                    diagonalSum += matrix[i, j + i];
                }
                maxSum = Math.Max(maxSum, diagonalSum);
            }

            for (int i = 1; i < rows; i++)
            {
                int diagonalSum = 0;
                for (int j = 0; j < cols && i + j < rows; j++)
                {
                    diagonalSum += matrix[i + j, j];
                }
                maxSum = Math.Max(maxSum, diagonalSum);
            }

            return maxSum;
        }
        /// <summary>
        /// Обчислення суми елементів кожного рядка без відємних чисел
        /// </summary>
        /// <returns>повертає одновимірний масив зі значенням суми у кожному рядку</returns> public
        public void СomputeWithoutNegetivRowsSum()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            columnSums = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                bool hasNegative = false;
                int columnSum = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                    columnSum += matrix[i, j];
                }
                if (!hasNegative)
                {
                    columnSums[j] = columnSum;
                }
            }
        }
        /// <summary>
        /// Міняє місцями значення двох змінних
        /// </summary>
        private void Swap(ref int firstElement, ref int secondElement)
        {
            int tempElement = firstElement;
            firstElement = secondElement;
            secondElement = tempElement;
        }
        #endregion
    }
}
