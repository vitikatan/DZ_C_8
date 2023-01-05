//Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
Console.Clear();

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Введите количество строк массива:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива:");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine("До сортировки");
PrintArray(array);

int sort = 0;
int l = 0;
while (l < m - 1)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < m - 1; j++)
        {
            if (array[j, i] < array[j, i + 1])
            {
                sort = array[j, i];
                array[j, i] = array[j, i + 1];
                array[j, i + 1] = sort;
            }
        }
    }
    l++;
}
l = 0;
while (l < n - 1)
{
    if (array[m-1, l] < array[m-1, l+1])
    {
        sort = array[m-1, l];
        array[m-1, l] = array[m-1, l+1];
        array[m-1, l+1] = sort;
    }
l++;
}

Console.WriteLine("После сортировки");
PrintArray(array);