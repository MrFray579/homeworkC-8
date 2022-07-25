Console.WriteLine($"\nВведите число строк  1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 1-й и (2-й строки) матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов  2-й матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");

int [,] firstArray = new int[m, n];
FirstGetArray(m, n);
Console.WriteLine("Первая матрица:");
PrintArray(firstArray);


int [,] secondArray = new int[n, p];
SecondGetArray(p, n);
Console.WriteLine("Второй матрица:");
PrintArray(secondArray);

int[,] resultArray = new int[m,p];

ResultArray(firstArray, secondArray, resultArray);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultArray);

void ResultArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultArray[i,j] = sum;
    }
  }
}

void FirstGetArray (int m, int n)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            firstArray[i, j] = new Random().Next(0, 21);
        }
    }
}

void SecondGetArray (int p, int t)
{
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            secondArray[i, j] = new Random().Next(0, 21);
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