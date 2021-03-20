using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{

    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (Node<T> node = head; node != null; node = node.Next)
            {
                action(node.Data);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            GenericList<int> gl = new GenericList<int>();

            gl.Add(3);
            gl.Add(4);
            gl.Add(5);


            Console.Write("元素分别为：");
            gl.ForEach(nodeData => Console.Write(nodeData+" "));
            gl.ForEach(nodeData => sum += nodeData);
            gl.ForEach(nodeData =>
            {
                if (nodeData > max)
                {
                    max = nodeData;
                }
                if (nodeData < min)
                {
                    min = nodeData;
                }
            });

            Console.WriteLine();
            Console.WriteLine("总和是："+sum);
            Console.WriteLine("最小值是："+min);
            Console.WriteLine("最大值是："+max);
        }
    }
}
