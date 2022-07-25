Console.WriteLine($"\nВведите число строк  массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");

int [,] array = new int[m, n];
GetArray(m, n);
PrintArray(array);

int minSumRows = 0;
int sumRows = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRows = SumLineElements(array, i);
  if (sumRows > tempSumRows)
  {
    sumRows = tempSumRows;
    minSumRows = i;
  }
}

Console.WriteLine($"\n{minSumRows+1} - строкa с наименьшей суммой  элементов. сумма = {sumRows} ");

int SumLineElements(int[,] array, int i)
{
  int sumRows = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRows += array[i,j];
  }
  return sumRows;
}

void GetArray (int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 21);

        }
    }
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.Write("\n");
    }
}