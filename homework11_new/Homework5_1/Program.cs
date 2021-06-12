using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            while (true)
            {
                try {
                    Console.WriteLine("*-------------------------------------------------------------*");
                    Console.WriteLine("请输入要进行的服务：1.添加订单 2.删除订单 3.修改订单 4.查询订单：");
                    string control = Console.ReadLine();
                    switch (control)
                    {
                        case "1":
                            AddNewOrder(orderService);
                            break;

                        case "2":
                            DeleteOrder(orderService);
                            break;

                        case "3":
                            UpdateOrder(orderService);
                            break;

                        case "4":
                            SearchOrder(orderService);
                            break;
                    }

                    orderService.OrderList.Sort();
                }catch(OrderException oe)
                {
                    Console.WriteLine(oe.Message);
                }catch(FormatException)
                {
                    Console.WriteLine("信息输入不符合规范！");
                }
                Console.WriteLine("*-------------------------------------------------------------*\n");
            }          
        }

        public static void AddNewOrder(OrderService orderService)
        {
            Console.WriteLine("输入你的用户名：");
            string clientName = Console.ReadLine();
            Client client = new Client(clientName);
            Order order = new Order(client);
            Console.WriteLine("输入要买的商品名称:");
            string goodsName0 = Console.ReadLine();
            Console.WriteLine("输入要买的商品单价:");
            double price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("输入要买的商品数量:");
            int count0 = Int32.Parse(Console.ReadLine());
            Goods goods = new Goods(goodsName0, price);
            OrderDetails od = new OrderDetails(goods, count0);
            order.AddOrderDetails(od);
            orderService.AddOrder(order);
        }

        public static void DeleteOrder(OrderService orderService)
        {
            Console.WriteLine("输入你要删除的订单的订单号：");
            string orderID0 = Console.ReadLine();
            orderService.DeleteOrder(orderID0);
        }

        public static void UpdateOrder(OrderService orderService)
        {
            Console.WriteLine("输入要修改的订单的订单号");
            string orderID1 = Console.ReadLine();
            Console.WriteLine("输入要修改的订单的商品名称");
            string goodsName1 = Console.ReadLine();
            Console.WriteLine("输入要修改的订单的商品数量：");
            int count1 = Int32.Parse(Console.ReadLine());
            orderService.UpdateOrder(orderID1, goodsName1, count1);
        }

        public static void SearchOrder(OrderService orderService)
        {
            Console.WriteLine("输入查询方式：1.订单号 2.客户名称 3.订单金额 4.商品名称");
            int num = Int32.Parse(Console.ReadLine());
            var orderList = orderService.SearchOrder(num);
            orderService.ShowOrderList(orderList);
        }
    }
}
