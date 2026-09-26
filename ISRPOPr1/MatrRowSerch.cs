using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISRPOPr1
{
    public class MatrRowSerch
    {
        public static List<int> RowPos(double[,] matr)
        {
            List<int> result = new List<int>();
            int rows = matr.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int pos = 0;
                int neg = 0; 

                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (matr[i, j] > 0)
                    {
                        pos++;
                    }
                    else if (matr[i, j] < 0) 
                    {
                        neg++;
                    }
                }
                if (pos > neg)
                {
                    result.Add(i+1); 
                }
            }

            return result;
        }
    }
}
