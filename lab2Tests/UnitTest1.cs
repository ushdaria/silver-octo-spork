using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using lab2_1;

namespace lab2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortMinDesc()
        {
            double[,] arr =
            {
                { 1.2, 2, -3 },
                { 1, 2.8, 3 },
                { 3, 10, 3 }
            };

            double[,] expected =
            {
                { 3, 10, 3 },
                { 1, 2.8, 3 },
                { 1.2, 2, -3 }
            };

            ArraySorter.BubbleSort(ref arr, GetMin, (left, right) => left > right);
            CollectionAssert.AreEqual(expected, arr);
            //Assert.IsTrue(AreEquals(arr, expected));
        }


        [TestMethod]
        public void SortMinAsc()
        {
            double[,] arr =
            {
                { 1.2, 2, -3 },
                { 1, 2.8, 3 },
                { 3, 10, 3 }
            };

            double[,] expected =
            {
                { 1.2, 2, -3 },
                { 1, 2.8, 3 },
                { 3, 10, 3 }
            };

            ArraySorter.BubbleSort(ref arr, GetMin, (left, right) => left < right);
            CollectionAssert.AreEqual(expected, arr);
            //Assert.IsTrue(AreEquals(arr, expected));
        }

        [TestMethod]
        public void SortMaxDesc()
        {
            double[,] arr =
            {
                { 1.2, 2, -3 },
                { 1, 2.8, 3 },
                { 3, 10, 3 }
            };

            double[,] expected =
            {
                { 3, 10, 3 },
                { 1, 2.8, 3 },
                { 1.2, 2, -3 }
            };

            ArraySorter.BubbleSort(ref arr, GetMax, (left, right) => left > right);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void SortSumAsc()
        {
            double[,] arr =
            {
                { 1.2, 2, 30 },
                { 1, 2.8, 3 },
                { 0, 0, 0 }
            };

            double[,] expected =
            {
                { 0, 0, 0 },
                { 1, 2.8, 3 },
                { 1.2, 2, 30 }
            };

            ArraySorter.BubbleSort(ref arr, GetSum, (left, right) => left < right);
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void EventWorks()
        {

            string expected = "Всем привет!";
            string? actual = null;

            Countdown timer = new();
            timer.Handler += (sender, s) => actual = s;

            timer.EventHappens(3000);

            Assert.AreEqual(expected, actual);
        }

        //public bool AreEquals(double[,] mas1, double[,] mas2)
        //{
        //    if (mas1.GetLength(0) != mas2.GetLength(0) || mas1.GetLength(1) != mas2.GetLength(1))
        //    {
        //        return false;
        //    }
        //    for (int i = 0; i < mas1.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < mas1.GetLength(1); j++)
        //        {
        //            if (mas1[i,j] != mas2[i,j])
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        public double GetMin(double[] arg)
        {
            double min = double.MaxValue;
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] < min)
                {
                    min = arg[i];
                }
            }
            return min;
        }
        public double GetMax(double[] arg)
        {
            double max = double.MinValue;
            for (int i = 0; i < arg.Length; i++)
            {
                if (arg[i] > max)
                {
                    max = arg[i];
                }
            }
            return max;
        }
        public double GetSum(double[] arg)
        {
            return arg.Sum();
        }
    }
}