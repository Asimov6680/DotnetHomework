using System;
using System.Collections.Generic;
using System.IO;
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
                    orderService.Import();
                    //orderService.CheckOrders();

                    Console.WriteLine("*-------------------------------------------------------------*");
                    Console.WriteLine("请输入要进行的服务：1.添加订单 2.删除订单 3.修改订单 4.查询订单：");
                    string control = Console.ReadLine();
                    switch (control)
                    {
                        case "1":
                            Console.WriteLine("输入你的用户名：");
                            string clientName = Console.ReadLine();                           
                            Console.WriteLine("输入要买的商品名称:");
                            string goodsName0 = Console.ReadLine();
                            Console.WriteLine("输入要买的商品单价:");
                            double price = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("输入要买的商品数量:");
                            int count0 = Int32.Parse(Console.ReadLine());
                            AddNewOrder(orderService,clientName,goodsName0,price,count0);
                            break;

                        case "2":
                            Console.WriteLine("输入你要删除的订单的订单号：");
                            string orderID0 = Console.ReadLine();
                            DeleteOrder(orderService,orderID0);
                            break;

                        case "3":
                            Console.WriteLine("输入要修改的订单的订单号");
                            string orderID1 = Console.ReadLine();
                            Console.WriteLine("输入要修改的订单的商品名称");
                            string goodsName1 = Console.ReadLine();
                            Console.WriteLine("输入要修改的订单的商品数量：");
                            int count1 = Int32.Parse(Console.ReadLine());
                            UpdateOrder(orderService,orderID1,goodsName1,count1);
                            break;

                        case "4":
                            Console.WriteLine("输入查询方式：1.订单号 2.客户名称 3.订单金额 4.商品名称 5.列出所有订单");
                            int num = Int32.Parse(Console.ReadLine());
                            SearchOrder(orderService,num);
                            break;
                    }

                    orderService.OrderList.Sort();

                    orderService.Export();
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

        public static void AddNewOrder(OrderService orderService,string clientName,string goodsName,double price,int count)
        {
            //Console.WriteLine("输入你的用户名：");
            //string clientName = Console.ReadLine();
            Client client = new Client(clientName);
            Order order = new Order(client);
            //Console.WriteLine("输入要买的商品名称:");
            //string goodsName0 = Console.ReadLine();
            //Console.WriteLine("输入要买的商品单价:");
            //double price = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("输入要买的商品数量:");
            //int count0 = Int32.Parse(Console.ReadLine());
            Goods goods = new Goods(goodsName, price);
            OrderDetails od = new OrderDetails(goods, count);
            order.AddOrderDetails(od);
            orderService.AddOrder(order);
        }

        public static void DeleteOrder(OrderService orderService,string orderID)
        {
            //Console.WriteLine("输入你要删除的订单的订单号：");
            //string orderID0 = Console.ReadLine();
            orderService.DeleteOrder(orderID);
        }

        public static void UpdateOrder(OrderService orderService,string orderID,string goodsName,int count)
        {
            //Console.WriteLine("输入要修改的订单的订单号");
            //string orderID1 = Console.ReadLine();
            //Console.WriteLine("输入要修改的订单的商品名称");
            //string goodsName1 = Console.ReadLine();
            //Console.WriteLine("输入要修改的订单的商品数量：");
            //int count1 = Int32.Parse(Console.ReadLine());
            orderService.UpdateOrder(orderID, goodsName, count);
        }

        public static void SearchOrder(OrderService orderService,int num)
        {
            //Console.WriteLine("输入查询方式：1.订单号 2.客户名称 3.订单金额 4.商品名称 5.列出所有订单");
            //int num = Int32.Parse(Console.ReadLine());
            if (num >= 1 && num <= 4)
            {
                var orderList = orderService.SearchOrder(num);
                orderService.ShowOrderList(orderList);
            }
            else
            {
                orderService.ShowOrderList();
            }
        }
    }
}
