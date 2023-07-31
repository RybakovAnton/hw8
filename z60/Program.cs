// Задача 60: Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, кооторая будет построчно выводить массив, добавляя индексы каждого элемента.



Console.WriteLine("Введите 1 размер массива a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввдетие 2 размер массива b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввдетие 3 размер массива c: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[a, b, c];


void GetArray()
{
  int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      for (int c = 0; c < array.GetLength(2); c++)
      {
        array[a, b, c] = temp[count];
        count++;
      }
    }
  }
}


void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i, j, k]} (A = {i}, B = {j}, C = {k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


GetArray();
PrintArray(array);
