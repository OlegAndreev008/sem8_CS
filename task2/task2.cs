// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] massiv = new int[3, 4];
void Fill(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] summs = new int[massiv.GetLength(0)];
Fill(massiv);
Print(massiv);
Console.WriteLine();
int summ = 0;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        summ += massiv[i, j];
        summs[i] = summ;
    }
    Console.Write($"сумма {i + 1} строки {summs[i]} ");
    Console.WriteLine();
    summ = 0;
}
Console.WriteLine();
int min = summs[0];
int stroke = 0;
for (int i = 1; i < summs.Length; i++)
{
    if (summs[i] < min)
    {
        min = summs[i];
        stroke = i;
    }    
}
Console.Write($"строка с наим значением {min} под номером {stroke + 1}");