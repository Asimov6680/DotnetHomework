using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework5_1
{
    public class OrderService
    {
        private List<Order> orderList = new List<Order>();

        public List<Order> OrderList
        {
            get => orderList;
        }
        public void AddOrder(Order order)
        {
            bool b = true;
            foreach(Order o in orderList)
            {
                if (o.Equals(order))
                {
                    b = false;
                    break;
                }
            }
            if (b == true)
            {
                orderList.Add(order);
            }
        }

        public void DeleteOrder(string orderID)
        {
            bool b = false;
            foreach(Order o in orderList)
            {
                if (o.OrderID == orderID)
                {
                    b = true;
                    orderList.Remove(o);
                    break;
                }
            }
            if (!b)
            {
                throw new OrderException($"找不到ID为{orderID}的订单！");
            }
        }

        public void UpdateOrder(string orderID,string goodsName,int count)
        {
            bool b = false;
            foreach (Order o in orderList)
            {
                if (o.OrderID == orderID)
                {
                    b = true;
                    o.UpdateOrderDetails(goodsName, count);
                }
            }
            if (!b)
            {
                throw new OrderException($"找不到ID为{orderID}的订单！");
            }
        }

        public List<Order> SearchOrderByOrderID(string orderID)
        {
            return orderList.Where(o => o.OrderID == orderID).OrderBy(o => o.TotalPrices).ToList();
        }

        public List<Order> SearchOrderByClientName(string clientName)
        {
            return orderList.Where(o => o.Client.ClientName == clientName).OrderBy(o => o.TotalPrices).ToList();
        }

        public List<Order> SearchOrderByTotalPrice(double totalPrice)
        {
            return orderList.Where(o => o.TotalPrices == totalPrice).OrderBy(o => o.TotalPrices).ToList();
        }

        public List<Order> SearchOrderByGoodsName(string goodsName)
        {
            return orderList.Where(o =>
            {
                bool b = false;
                foreach (OrderDetails od in o.OrderDetailsList)
                {
                    if (od.Goods.Name == goodsName)
                    {
                        b = true;
                        break;
                    }
                }
                return b;
            }).OrderBy(o => o.TotalPrices).ToList();
        }
        public List<Order> SearchOrder(int control)
        {
            IEnumerable<Order> orders = null;
            switch (control)
            {
                case 1:
                    Console.WriteLine("输入订单号:");
                    string orderID = Console.ReadLine();
                    orders = this.SearchOrderByOrderID(orderID);
                    break;
                case 2:
                    Console.WriteLine("输入用户名:");
                    string clientName = Console.ReadLine();
                    orders = this.SearchOrderByClientName(clientName);
                    break;
                case 3:
                    Console.WriteLine("输入订单金额:");
                    double totalPrice = Int32.Parse(Console.ReadLine());
                    orders = this.SearchOrderByTotalPrice(totalPrice);
                    break;
                case 4:
                    Console.WriteLine("输入商品名称:");
                    string goodsName = Console.ReadLine();
                    orders = this.SearchOrderByGoodsName(goodsName);
                    break;
            }
            return orders.ToList();
            
        }

        /*public void CheckOrders()
        {
            List<Order> orderList = this.OrderList;
            bool b = orderList.Distinct().Count() == orderList.Count();
            Console.WriteLine(b ? "" : "存在订单号相同的订单！");
        }*/
        public void ShowOrderList(List<Order> orderList)
        {
            foreach(Order o in orderList)
            {
                Console.WriteLine(o);
            }
        }
        public void ShowOrderList()
        {

            foreach (Order o in this.orderList)
            {
                Console.WriteLine(o);
            }
        }

        public void Export()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmls.Serialize(fs, this.orderList);
            }
        }

        public void Import()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                List<Order> lo = (List<Order>)xmls.Deserialize(fs);
                foreach (Order o in lo)
                {
                    if (!this.orderList.Contains(o))
                    {
                        this.orderList.Add(o);
                    }
                }
            }
        }
    }
}
