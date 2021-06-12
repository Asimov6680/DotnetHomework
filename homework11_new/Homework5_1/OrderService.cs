using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Order> SearchOrder(int control)
        {
            IEnumerable<Order> orders = null;
            switch (control)
            {
                case 1:
                    Console.WriteLine("输入订单号:");
                    string orderID = Console.ReadLine();
                    orders = orderList.Where(o => o.OrderID == orderID).OrderBy(o => o.TotalPrices);
                    break;
                case 2:
                    Console.WriteLine("输入用户名:");
                    string clientName = Console.ReadLine();
                    orders = orderList.Where(o => o.Client.ClientName == clientName).OrderBy(o => o.TotalPrices);
                    break;
                case 3:
                    Console.WriteLine("输入订单金额:");
                    double totalPrice = Int32.Parse(Console.ReadLine());
                    orders = orderList.Where(o => o.TotalPrices == totalPrice).OrderBy(o => o.TotalPrices);
                    break;
                case 4:
                    Console.WriteLine("输入商品名称:");
                    string goodsName = Console.ReadLine();
                    orders = orderList.Where(o =>
                    {
                        bool b = false;
                        foreach(OrderDetails od in o.OrderDetailsList)
                        {
                            if(od.Goods.Name == goodsName)
                            {
                                b = true;
                                break;
                            }                            
                        }
                        return b;
                    }).OrderBy(o=>o.TotalPrices);
                    break;
            }
            return orders.ToList();
            
        }


        public void ShowOrderList(List<Order> orderList)
        {
            foreach(Order o in orderList)
            {
                Console.WriteLine(o);
            }
        }



    }
}
