/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

void Task_47()
{
    Console.Write("Ведите колличество строк массива m -> ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Ведите колличество столбцов массива n -> ");
    int n = int.Parse(Console.ReadLine());

    double[,] GetArray(int rows, int columns)
    {
        double[,] matrix = new double[rows, columns];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(GetRandomNumber(-100, 100), 1);
            }
        }
        return matrix;
    }
    double GetRandomNumber(double min, double max)
    {
        Random random = new Random();
        return random.NextDouble() * (max - min) + min;
    }

    void PrintArray(double[,] arr)
    {
        for (int y = 0; y < arr.GetLength(0); y++)
        {
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                Console.Write($"{arr[y, x]}\t");
            }
            Console.WriteLine();
        }
    }

    double[,] array = GetArray(m, n);
    PrintArray(array);
}

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.*/

void Task_50()
{
    Console.Write("Ведите колличество строк массива m -> ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Ведите колличество столбцов массива n -> ");
    int n = int.Parse(Console.ReadLine());

    double[,] GetArray(int rows, int columns)
    {
        double[,] matrix = new double[rows, columns];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(GetRandomNumber(-100, 100), 1);
            }
        }
        return matrix;
    }
    double GetRandomNumber(double min, double max)
    {
        Random random = new Random();
        return random.NextDouble() * (max - min) + min;
    }
    void PrintArray(double[,] arr)
    {
        for (int y = 0; y < arr.GetLength(0); y++)
        {
            for (int x = 0; x < arr.GetLength(1); x++)
            {
                Console.Write($"{arr[y, x]}\t");
            }
            Console.WriteLine();
        }
    }

    double[,] array = GetArray(m, n);
    PrintArray(array);


    int posX = 5;
    int posY = 5;
    var param = GetValue(array, posX, posY);
    
    if (param.msg == "") Console.WriteLine($"Элемент матрицы x: {posX}  y: {posY} = {param.val}");
    else Console.WriteLine($" {param.msg}");

    static (double val, string msg) GetValue<T>(T[,] matr, int xWidth, int yHeight)
    {
        string msg = String.Empty;
    
        if (xWidth > matr.GetLength(1) || xWidth < 0) {
            double val = 0;
            msg += "Неверный параметр Х";
        }


        if (yHeight > matr.GetLength(0) || yHeight < 0) {
            double val = 0;
            msg += "  Неверный параметр Y";
        }

        object v = matr[xWidth, yHeight];
        
        
        return (Convert.ToDouble(v), "") ;

    }
}

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

void Task_52()
{
    int[,] array = InitRandomMatr<int>(4, 3); 
    double[] aver = AverRows<int>(array);

    Console.Write("Average in rows-> ");
    for (int i = 0; i < aver.Length; i++) Console.Write($"{aver[i]} ");

    static T[,] InitRandomMatr<T>(int Heigth, int Width)
    {
        T[,] matr = new T[Heigth, Width];
        Random rd = new Random();
    
        for(int i = 0; i < matr.GetLength(0); i++)
          {
            for(int j = 0; j < matr.GetLength(1); j++)
              {                        
               int val =  rd.Next(0, 100);
               matr[i,j]= (T)Convert.ChangeType(val,typeof(T)); 
              Console.Write($"{matr[i, j]} ");
              }
              Console.WriteLine();
            }
        Console.WriteLine();

        return matr;
    }
    static double[] AverRows<T>(T[,] matr)
    {
        double[] aver = new double[matr.GetLength(0)];

        for(int i = 0; i < matr.GetLength(1); i++) 
        {
        double summ = 0;
        for(int j = 0; j < matr.GetLength(0); j++) 
        {
        object v = matr[j, i];
        summ += Convert.ToDouble(v);
        }
        aver[i] = summ / matr.GetLength(0);
        }
        return aver;
    }
}

Console.WriteLine("Введите номер задачи -> ");
string num_str = Console.ReadLine();
int num = int.Parse(num_str);
if(num == 47)
{
    Task_47();
    return;
} 
if(num == 50)
{
    Task_50();
    return;
}
if(num == 52)
{
    Task_52();
    return;
}  
else Console.WriteLine("Неверный номер задачи");