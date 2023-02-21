int [,] newArray()
{
    Console.Write ("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Введите количество колонок: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int [,] createArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createArray[i,j] = new Random().Next(0,9);
            
        }
       
    }
     Console.WriteLine ("Введите номер строки: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Введите номер столбца: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > rows || b > columns)
            {
                Console.WriteLine ($"{a} {b} - > числа с такими индексами нет в массиве.");
            }
            else 
            {
                Console.WriteLine ($"{a} {b}");
            }
    return createArray;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] show2 = newArray();
ShowArray (show2);
