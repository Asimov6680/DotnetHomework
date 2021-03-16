using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_1
{
    public abstract class Shape
    {

        private double area;
        public double Area
        {
            get
            {
                if (IsValidShape())
                {
                    area = CalculateArea();
                }
                else
                {
                    area = 0;
                }
                return area;
            }
        }

        public abstract double CalculateArea();
        public abstract bool IsValidShape();

    }

    public class Rectangle : Shape
    {
        private double weight;
        private double height;
        public Rectangle(double weight,double height)
        {
            this.weight = weight;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return weight * height;
        }
        public override bool IsValidShape()
        {
            bool b = true;
            if (weight <= 0 || height <= 0)
            {
                b = false;
            }
            return b;
        }
    }

    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
    }

    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public Triangle(double sideA,double sideB,double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double CalculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            double triangleArea = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));   
            return triangleArea;
        }
        
        public override bool IsValidShape()
        {
            bool b = false;
            if (sideA > 0 && sideB > 0 && sideC > 0 && (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideA + sideC > sideB))
            {
                b = true;
            }
            return b;
        }
    }

     public class Test
    {
        public static void Main()
        {
            try
            {
                Shape[] shapes = { new Rectangle(5, 3.6), new Square(1.6), new Triangle(3.0, -4.0, 5.0) };
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"第{i + 1}个图形是否合法？");
                    Console.WriteLine($"{shapes[i].IsValidShape()}，面积为{shapes[i].CalculateArea()}");
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
