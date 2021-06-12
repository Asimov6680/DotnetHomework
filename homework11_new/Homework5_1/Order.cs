using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    public class Order:IComparable
    {
        private Client client;
        private string orderID;
        private List<OrderDetails> orderDetailsList=new List<OrderDetails>();

       
        public Order(Client client)
        {
            this.client = client;
            long currentTicks = DateTime.Now.Ticks;
            DateTime dtFrom = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            orderID = ""+(currentTicks - dtFrom.Ticks) / 10000;
        }

        public Client Client
        {
            get => client;
            set => client = value;
        }
        public string OrderID
        {
            get => orderID;
            set => orderID = value;
        }

        public List<OrderDetails> OrderDetailsList
        {
            get => orderDetailsList;
        }
        public double TotalPrices
        {
            get
            {
                double p = 0;
                foreach(OrderDetails od in orderDetailsList)
                {
                    p += od.Prices;
                }
                return p;
            }
        }

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            bool b = true;
            foreach (OrderDetails od in orderDetailsList)
            {
                if (od.Equals(orderDetails))
                {
                    b = false;
                    break;
                }
            }
            if (b == true)
            {
                orderDetailsList.Add(orderDetails);
            }
        }

        public void DeleteOrderDetails(string goodsName)
        {
            bool b = false;
            foreach (OrderDetails od in orderDetailsList)
            {
                if (od.Goods.Name == goodsName)
                {
                    b = true;
                    orderDetailsList.Remove(od);
                    break;
                }
            }
            if (!b)
            {
                throw new OrderException($"订单内找不到{goodsName}的商品！");
            }
        }

        public void UpdateOrderDetails(string goodsName,int count)
        {
            bool newGoods = true;
            foreach (OrderDetails od in orderDetailsList)
            {
                if (od.Goods.Name == goodsName)
                {
                    newGoods = false;
                    if (count == 0)
                    {
                        orderDetailsList.Remove(od);
                    }
                    else
                    {
                        od.Count = count;
                    }
                    break;
                }
            }
            if (newGoods)
            {
                Console.WriteLine("输入新货物的单价：");
                double price = Int32.Parse(Console.ReadLine());
                OrderDetails od = new OrderDetails(new Goods(goodsName, price), count);
                orderDetailsList.Add(od);
            }
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.orderID == orderID;
        }

        public override int GetHashCode()
        {
            return  Int32.Parse(orderID);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"\n**************************\n{client}\t 订单号： {OrderID}\n");
            foreach(OrderDetails od in orderDetailsList)
            {
                sb.Append(od);
                sb.Append("\n");
            }
            sb.Append("本订单总金额为：" + TotalPrices);
            sb.Append("\n**************************\n");
            return sb.ToString();
        }

        public int CompareTo(Object obj)
        {
            if (!(obj is Order))
            {
                throw new System.ArgumentException();
            }
            Order o = (Order)obj;
            return this.TotalPrices.CompareTo(o.TotalPrices);
        }
       
    }
}
