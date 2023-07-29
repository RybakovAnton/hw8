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
    int minSumLine = 0;
    int SumLineElements(int[,] matrix, int i)
    {
        int sumLine = matrix[i,0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sumLine += matrix[i,j];
        }
        return sumLine;
    }

    int sumLine = SumLineElements(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(matrix, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }

    }
    Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
} 


GetArray();
PrintArray();
System.Console.WriteLine("__________");
ChangeArray();



