// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int M = 3, N = 4;
int[,] array = new int[M,N];

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1,10);
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("________________");

for (int i = 0; i < array.GetLength(0); i+=2)
{

    for (int j = 0; j < array.GetLength(1); j+=2)
    {
        array[i,j] *= array[i,j];
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}