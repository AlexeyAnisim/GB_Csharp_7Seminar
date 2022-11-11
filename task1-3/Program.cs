
Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Задание 1 (введите 1)");
        System.Console.WriteLine("Задание 2 (введите 2)");
        System.Console.WriteLine("Задание 3 (введите 3)");
        System.Console.WriteLine("End (если введено - 0)");
        int numTask = Convert.ToInt32(Console.ReadLine());

        switch (numTask)
        {
            case 0: return; 
            case 1: АrrayRealNumbers(); break;
            case 2: PositionElement(); break;
            case 3: ArithmeticMeanColumn(); break;
            default: System.Console.WriteLine("Ошибка ввода"); break;
        }
    }
}
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
void АrrayRealNumbers()
{
int rows = SetNumber("m");
int column = SetNumber("n");
double[,] matrix = GetRandomMatrix(rows,column, 999,-999);
PrintMatrix(matrix);

int SetNumber (string name)
{
    string[]arr=name.Split("");
    System.Console.WriteLine($"Enter number {name}");
    int num = int.Parse(Console.ReadLine());
    return num;
}
double[,] GetRandomMatrix(int rows, int column, double maxValue=100, double minValue=-100)
{
    double[,]matrix = new double[rows,column];
    var random = new Random();
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<column; j++)
        {
            matrix[i,j]=random.Next(-100, 101);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
      for(int j=0; j<matrix.GetLength(1); j++)
      {
        System.Console.Write($"{matrix[i,j]} ");
      } 
      System.Console.WriteLine(); 
    }
}
}
// End

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
void PositionElement()
{
Console.WriteLine("введите индекс строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите индекс столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[10, 10];

FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) && m > numbers.GetLength(1)) 
{
Console.WriteLine("такого элемента нет");
}
else 
{
Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(-100, 100);
}
}
}

void PrintArray(int[,] array)
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
}
// End

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
void ArithmeticMeanColumn()
{    
    Console.WriteLine("введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int m = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[n, m];
    
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum = (sum + numbers[i, j]);
        }
        sum = sum / n;
        Console.Write(sum + "; ");
    }
    
    Console.WriteLine();
    
    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(-100, 101);
            }
        }
    }
    
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
}
// End




    


