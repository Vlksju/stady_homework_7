Console.WriteLine("Программа проверяет наличие элемента в массиве по его индексам");

Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив = ");

int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(-10, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите номер строки = ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца = ");
int n1 = Convert.ToInt32(Console.ReadLine());

if ((m1 <= m) & (n1 <= n))
{
    Console.Write($"Элемент {matrix[m1-1, n1-1]}");
}
else { Console.Write("Элемента не существует!"); }
