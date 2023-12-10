// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите строку: ");
int lin = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pil = Convert.ToInt32(Console.ReadLine()) - 1;
Random random = new Random();
int[,] array = new int[6, 8];
Console.WriteLine("Массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (lin < 0 | lin > array.GetLength(0) - 1 | pil < 0 | pil > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
else
{
    Console.WriteLine("Значение элемента = {0}", array[lin, pil]);
}
Console.ReadLine();
