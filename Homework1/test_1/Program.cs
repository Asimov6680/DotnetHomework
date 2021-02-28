using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入第一个数字：");
            string num1 = Console.ReadLine();

            Console.Write("输入运算符（+，-，*，/）：");
            string op = Console.ReadLine();

            Console.Write("输入第二个数字：");
            string num2 = Console.ReadLine();

            string result = "";
            string e = "invalid input";

            switch (op)
            {
                case "+":
                    result = Convert.ToString(Convert.ToDouble(num1) + Convert.ToDouble(num2));
                    break;

                case "-":
                    result = Convert.ToString(Convert.ToDouble(num1) - Convert.ToDouble(num2));
                    break;

                case "*":
                    result = Convert.ToString(Convert.ToDouble(num1) * Convert.ToDouble(num2));
                    break;

                case "/":
                    if (num2 == "0")
                    {
                        result = e;
                        break;
                    }
                    result = Convert.ToString(Convert.ToDouble(num1) / Convert.ToDouble(num2));
                    break;

                default:
                    result = e;
                    break;
            }
            if (result.Equals(e))
            {
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine(num1 + op + num2 + "=" + result);
            }
        }
    }
}
