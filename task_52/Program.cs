Console.WriteLine("Программа которая находит среднеарифметическое каждого столбца в двумерном массиве.");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

Console.WriteLine("Исходный массив:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

double arithmeticMean = 0;

for (int j = 0;  j<n; j++)
{
    arithmeticMean = 0;
    for (int i = 0; i<m; i++)
    {
        arithmeticMean = arithmeticMean + matrix[i, j];
    }
    arithmeticMean = arithmeticMean / m;
    Console.WriteLine($"Среднееарифметическое столбца {j+1}  =  {arithmeticMean}");
}



