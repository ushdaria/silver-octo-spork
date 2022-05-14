using System;
using System.Collections.Generic;
using System.Linq;

namespace lab2_1;

public static class ArraySorter
{
    public static void BubbleSort(ref double[,] arr, Func<double[], double> criteria, Func<double, double, bool> order)
    {
        int sizeY = arr.GetLength(0); //кол-во строк
        int sizeX = arr.GetLength(1); //кол-во столбцов

        //выбор сравниваемого числа для каждой из строк матрицы
        double[][] chosenElems = new double[sizeY][];
        for (int i = 0; i < sizeY; i++)
        {
            chosenElems[i] = new double[2];
            chosenElems[i][0] = i;

            double[] row = new double[sizeX];
            for (int j = 0; j < sizeX; j++)
            {
                row[j] = arr[i, j];
            }

            chosenElems[i][1] = criteria(row);
        }
        //сортировка пузырьком
        for (int i = 0; i < sizeY - 1; i++)
        {
            for (int j = 0; j < sizeY - i - 1; j++)
            {
                if (order(chosenElems[j+1][1], chosenElems[j][1]))
                {
                    double[] temp = chosenElems[j + 1];
                    chosenElems[j + 1] = chosenElems[j];
                    chosenElems[j] = temp;
                }
            }
        }
        //заполнение новой матрицы
        double[,] result = new double[sizeX, sizeY];
        for (int i = 0; i < sizeY; i++)
        {
            var rowIndex = chosenElems[i][0];
            for (int j = 0; j < sizeX; j++)
            {
                result[i, j] = arr[(int)rowIndex, j];
            } 
        }

        arr = result; 
    }
}
