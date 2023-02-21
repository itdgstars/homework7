double [,] newArray (int row, int column)
    {
        double [,] createArray = new double [row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                createArray[i,j] = Math.Round((new Random().Next(0, 9)) + (new Random().NextDouble()),2);
            }
        }
        return createArray;
    }
    void Show2dArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

    Console.Write ("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Введите количество колонок: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double [,] createdArray = newArray(rows, columns);

    Show2dArray(createdArray);
