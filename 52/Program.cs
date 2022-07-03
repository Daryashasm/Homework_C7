// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Задайте размерность массива m х n");
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m,n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
    matrix[i,j] = new Random().Next(0,10);
    Console.Write(matrix[i,j] + " " );
}
Console.WriteLine();
}
double sum = 0;
int count = 0;
    for (int j = 0; j < n; j++)
    {
        for (int i = 0; i < m; i++)
        {
            sum = sum + matrix[i,j];
            if (i == m - 1)
            {
            Console.WriteLine($"Среднее арифметическое {count}-го столбца равно {Math.Round(sum/m,2)}");
            sum = 0;
            count = count + 1;
            }
        }
    }





