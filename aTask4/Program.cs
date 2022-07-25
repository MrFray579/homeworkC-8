Console.WriteLine($"\nВведите X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите Y:");
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите Z:");
int Z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

int[,,] array3D = new int[X, Y, Z];
GetArray(X, Y, Z);
WriteArray(array3D);

void GetArray (int X, int Y, int Z)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = new Random().Next(0, 20);
            }
        }
    }
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}