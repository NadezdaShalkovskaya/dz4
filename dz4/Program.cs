int[,] array = new int[7, 8];
Random random = new Random();
for (int i = 0; i < 7; i++)
{
     for (int j = 0; j < 8; j++)
    {
        array[i, j] = random.Next(1, 101);
    }
}
Console.WriteLine("Двухмерный массив");
for (int i = 0;i < 7; i++)
{
    for(int j = 0;j < 8; j++)
    {
        Console.WriteLine(array[i, j] + "\t");
    }
    Console.WriteLine();
}
for(int j = 0;j<8; j++)
{
    for( int i = 0;i < 7;i++)
    {
        if (array[i,j] %2 != 0)
        { }
    }
}
for(int j = 0;j<8; j++)
{
    Console.WriteLine($"Количество нечётных элементов в столбце {j + 1}");
}    
