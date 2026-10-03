using ISRPOPr1;
//10.Дана вещественная матрица размерности n * m. Вывести номера строк,
//содержащих больше положительных элементов, чем отрицательных.
Console.Write("Введите количество строк матрицы n - ");
if (int.TryParse(Console.ReadLine(), out int n))
    {
    Console.Write("Введите количество столбцов матрицы m - ");
    if (int.TryParse(Console.ReadLine(), out int m))
    {
        if (n > 1 && n < 16)
        {
            double[,] matr = new double[n, m];
            Random rnd = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = Math.Round((-5) + rnd.NextDouble() * 10, 2);
                }
            }

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", matr[i, j]);
                }
                Console.WriteLine();
            }

            List<int> rows = MatrRowSerch.RowPos(matr);
            Console.WriteLine("Номера строк: " + string.Join(", ", rows));
        }
        else
        {
            Console.WriteLine("Ошибка создания матрицы.\nСлишком большое или отрицательное число может привести к сбою программыю.\nПопробуйте выбрать число в диапозоне от 1 до 15");
        }
    }
    else
    {
        Console.WriteLine("Ошибка создания матрицы! Введите корректное значение для количества столбцов!");
        return;
    }
       
}
else
{
    Console.WriteLine("Ошибка создания матрицы! Введите корректное значение для количества строк!");
    return;
}
