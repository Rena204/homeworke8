int[,,] print = new int[2, 2, 2];

void Print(int[,,] arr)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < print.GetLength(2); k++)
            {
                Console.Write($"{print[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}


void Array(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}


Array(print);
Print(print);
