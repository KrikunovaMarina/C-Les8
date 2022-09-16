Console.WriteLine("введите количество строк первой матрицы");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов первой матрицы");
int m = int.Parse(Console.ReadLine());
int[,] Matrix1 = new int[n, m];
FillMatrix1(Matrix1);
PrintMatrix1(Matrix1);
Console.WriteLine("введите количество строк второй матрицы");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов второй матрицы");
int b = int.Parse(Console.ReadLine());
int[,] Matrix2 = new int[a, b];
FillMatrix2(Matrix2);
PrintMatrix2(Matrix2);
void FillMatrix1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix1(int[,] array)
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
void FillMatrix2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintMatrix2(int[,] array)
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
int[,] resultMatrix = new int[m,b];
FillMatrix3(Matrix1, Matrix2, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix3(resultMatrix);
void FillMatrix3(int[,] Matrix1, int[,] Matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Matrix1.GetLength(1); k++)
      {
        sum += Matrix1[i,k] * Matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
void PrintMatrix3(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
               for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write(resultMatrix[i, j] + " ");
        }
            Console.WriteLine("");
    }
}