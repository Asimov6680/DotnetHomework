using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
    class homework2_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一串整数数组的元素并以“,”(英)分隔开：");
            SetIntArray(out int[] array);
            Console.WriteLine("该数组元素的最大值为：" + GetMaxValue(array));
            Console.WriteLine("该数组元素的最小值为：" + GetMinValue(array));
            Console.WriteLine("该数组元素的和为：" + GetSum(array));
            Console.WriteLine("该数组元素的平均值为：" + GetAverage(array));
        }

        static int GetMaxValue(int[] array)   //获取最大值
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        static int GetMinValue(int[] array)   //获取最小值
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        static int GetSum(int[] array)   //获取元素总和
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }

        static double GetAverage(int[] array)   //获取平均值
        {
            int n = array.Length;
            double average = (double)GetSum(array) / n;

            return average;
        }

        static void SetIntArray(out int[] array)       //从控制台中读取整数数组
        {
            string[] s = Console.ReadLine().Split(',');
            int sLength = s.Length;
            array = new int[sLength];

            try
            {
                for (int i = 0; i < sLength; i++)
                {
                    array[i] = Convert.ToInt32(s[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input");
                return;
            }
        }
    }
}
