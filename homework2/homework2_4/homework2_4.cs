using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_4
{
    class homework2_4
    {
        static void Main(string[] args)
        {
            SetMatrix(out double[,] a);
            Console.WriteLine(isToeplitzMatrix(a)?"该矩阵是一个托普利茨矩阵":"该矩阵不是一个托普利茨矩阵");
        }

        static void SetMatrix(out double[,] matrix)   //根据用户提供的行数，列数及每行的元素等数据创建一个矩阵
        {
            Console.WriteLine("请输入矩阵的行数：");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入矩阵的列数：");
            int columns = Convert.ToInt32(Console.ReadLine());

            matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"请输入第{i+1}行（元素间以“,”为分隔符）");
                string[] str = Console.ReadLine().Split(',');
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt64(str[j]);
                }
            }
        }

        static bool isToeplitzMatrix(double[,] a)
        {
            
            if (a.GetLength(0) == 1 || a.GetLength(1) == 1)   //只有一行或一列的矩阵不是托普利茨矩阵
            {
                return false;
            }

            //矩阵中每个元素同它右下角的元素进行比较。
            //由于最下一行或最右一列的元素没有右下角对应的元素，故不考虑最下一行和最右一列中的元素
            for (int i = 0; i < a.GetLength(0) - 1; i++)    
            {                              
                for (int j = 0; j < a.GetLength(1) - 1; j++)
                {
                    if (a[i, j] != a[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
