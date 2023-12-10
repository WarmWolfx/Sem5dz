// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[6, 6];
Random rand = new Random();
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)

    {
        array[i, j] = rand.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
{
    int index = 0, min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }


        if (i == 0)
        {
            min = sum;
        }
        else if (sum < min)
        {
            min = sum;
            index = i;
        }
    }
    string line = string.Empty;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        line += array[index, j] + " ";
    }
    Console.WriteLine();
    Console.WriteLine($"Строка с наименьшей суммой элементов = {index + 1}  (Сумма {min}). ");
}
Console.WriteLine();
