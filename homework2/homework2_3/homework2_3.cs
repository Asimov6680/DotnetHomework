using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class homework2_3
    {
        static void Main(string[] args)
        {
            InitPrimeArray(out int[] array);
            Console.WriteLine("用埃氏筛法得到2~100以内的素数为：");
            ESieve(array);
        }

        static void InitPrimeArray(out int[] array)   //将2~100放置在数组中
        {
            array = new int[99];
            for (int i = 0; i < 99; i++)
            {
                array[i] = i + 2;
            }
        }

        static bool IsMultiple(int num1, int num2)  //判断num1是不是num2的两倍及以上的倍数
        {
            bool b = true;
            if (num1 % num2 != 0 || num1 == num2)
            {
                b = false;
            }
            return b;
        }
        static void ESieve(int[] array)             //埃氏筛法实现
        {
            int maxFactor = (int)Math.Sqrt(100);    //以100的算术平方根作为最大的筛子，提高筛选效率
            for (int i = 2; i <= maxFactor; i++)    //i为筛子
            {
                for (int j = 0; j < 99; j++)
                {

                    //当一个数能被筛子整除且商大于等于2时，将其对应索引的数组元素值置-1
                    //考虑到2，3，5，7也能被筛子2，3，5，7整除，若仅是因为能被筛子整除就略去，则会得到错误的结果
                    if (array[j] != -1 && IsMultiple(j + 2, i))
                    {
                        array[j] = -1;
                    }
                }
            }

            GetArrayElements(array);

        }

        static void GetArrayElements(int[] array)   //当数组元素不为-1.即数组元素为筛选出的素数时，将其输出
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -1)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
