using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class homework2_1
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数字：");
            
            int num = Convert.ToInt32(Console.ReadLine());
            GetPrimeFactor(num);
        }

        static void GetPrimeFactor(int n)   //将传入的数分解质因数并输出质因数
        {
            Console.Write(n + "=");
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0 && n != i)
                {
                    n /= i;
                    Console.Write(i + "*");
                }
                if (n == i)                  //当分解到最后一个数字时，末尾不用输出乘号
                    Console.WriteLine(i);
            }

        }
    }
}
