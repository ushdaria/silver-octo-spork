using lab2_1;

//Задание 1

double[,] arr =
{
    { 1.2, 2, -3 },
    { 1, 2.8, 3 },
    { 3, 10, 3 }
};

arr.Print();

ArraySorter.BubbleSort(ref arr, GetSum, (left, right) => left > right);

Console.WriteLine();
arr.Print();


double GetMin(double[] arg)
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

double GetMax(double[] arg)
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

double GetSum(double[] arg)
{
    return arg.Sum();
}

Console.WriteLine();

//Задание 2

Countdown timer = new();

var sub1 = new Subscriber("Петя", timer);
var sub2 = new Subscriber("Ваня", timer);

timer.EventHappens(3000);
