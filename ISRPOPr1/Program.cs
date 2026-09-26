using ISRPOPr1;
//10.Дана вещественная матрица размерности n * m. Вывести номера строк,
//содержащих больше положительных элементов, чем отрицательных.

double[,] matr = new double[4, 4]; 
Random rnd = new Random();
for (int i = 0; i< matr.GetLength(0);  i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = Math.Round((-5) + rnd.NextDouble()*10 ,2);
    }
}

for (int i = 0; i< matr.GetLength(0); i++)
{
    for(int j = 0; j< matr.GetLength(1); j++)
    {
        Console.Write("{0,5}", matr[i,j]);
    }
    Console.WriteLine();
}

List<int> rows = MatrRowSerch.RowPos(matr);
Console.WriteLine("Номера строк: " + string.Join(", ", rows));