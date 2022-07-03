int s = new Random().Next(1,10);
int st = new Random().Next(1,10);
int [,] matrix = new int [s,st];
for (int i = 0; i < s; i++)
{
for (int j = 0; j < st; j++)
{
    matrix[i,j] = new Random().Next(-10,10);
    Console.Write(matrix[i,j] + " " );
}
Console.WriteLine();
}
Console.Write("Введите номер строки, n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца, m = ");
int m = Convert.ToInt32(Console.ReadLine());
int A = 0;
int B = 0;
for (int i = 0; i < s; i++)
{
    for (int j = 0; j < st; j++)
    {
        if (i == n && j == m)
        {
        A = A + matrix[i,j];
        B = B + 1;
        }
    }
}
if (B > 0)
{
Console.Write($"Элемент на позиции [{n},{m}] равен {A}");
}
else
{
Console.Write($"Элемент на позиции [{n},{m}] не найден в данном массиве");
}
Console.WriteLine();

