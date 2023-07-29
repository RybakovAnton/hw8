// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишиите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Ведите кол-во строчек: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввдетие кол-во колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

void GetArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}

void ChangeArray()
{
    int SumLine(int[,] matrix, int i)
    {
        int sum = matrix[i,0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        return sum;
    }

    int minSum = 1;
    int sum = SumLine(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (sum > SumLine(matrix, i))
        {
            sum = SumLine(matrix, i);
            minSum = i+1;
        }
    }
    Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");

}

GetArray();
PrintArray();
System.Console.WriteLine("__________");
ChangeArray();
