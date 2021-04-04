using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    public class OrderDetails
    {
        private Goods goods;
        private int count;
        public int Count
        {
            get => count;
            set => count = value;
        }

        public Goods Goods
        {
            get => goods;
            set => goods = value;
        }

        public double Prices
        {
            get
            {
                return goods.Price * count;
            }
        }

        public OrderDetails(){}
        public OrderDetails(Goods goods,int count)
        {
            this.goods = goods;
            this.count = count;
        }
        public override bool Equals(object obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            return orderDetails != null && orderDetails.goods == goods;
        }
        public override int GetHashCode()
        {
            return goods.Name.Length * 19 + (int)goods.Price * 17 + count * 13 + (int)Prices * 11;
        }

        public override string ToString()
        {
            return $"{goods}  选择了{count}件{goods.Name}，花费{Prices}元";
        }
    }
}
