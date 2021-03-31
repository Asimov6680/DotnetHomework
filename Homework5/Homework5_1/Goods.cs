using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    public class Goods
    {
        private string name;
        private double price;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }

        public Goods(string name,double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name}的单价为：{price}元   ";
        }
    }
}
