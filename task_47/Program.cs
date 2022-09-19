Console.WriteLine("Программа которая выводит двумерный массив m*n, заполненный случайными вещественными числами!");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rand.Next(-5,5) + rand.NextDouble ();
        Console.Write (matrix[i, j] + " ");
    }
    Console.WriteLine();
}
