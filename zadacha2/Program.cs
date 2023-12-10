// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] array = new int[6, 6]
{
    { 11, 12, 13, 14, 15, 16 },
    { 17, 18, 19, 20, 21, 22 },
    { 23, 24, 25, 26, 27, 28 },
    { 29, 30, 31, 32, 33, 34 },
    { 35, 36, 37, 38, 39, 40 },
    { 41, 42, 43, 44, 45, 46 },
};
Console.WriteLine(); 

for (int i = 0; i < array.GetLength(1); i++)
{
    int temp = array[5, i];
    array[5, i] = array[0, i];
    array[0, i] = temp;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
