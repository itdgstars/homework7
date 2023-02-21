double [,] createArray ()
{
    Console.Write ("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write ("Введите количество колонок: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double [,] createdArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdArray[i,j] = new Random().Next(0,9);
        }
    }
    return createdArray;
}
 double [,] taskArray (double [,] array)
 {
    
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0; 
        double result = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
        
            result = result + array[i,j];
            ;
            sum++;
        }
        result = result / sum;    
       Console.Write($"{result:f1} ");          
    }
    
    return array;
 }
    
void ShowArray (double [,] array)
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

double [,] show2 = createArray();
ShowArray (show2);
taskArray(show2);

