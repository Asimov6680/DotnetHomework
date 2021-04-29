using Homework5_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Homework8
{
    public partial class MainForm : Form
    {

        private OrderService orderService;
        private List<Order> selectedOrderList;
        public MainForm()
        {
            orderService = new OrderService();
            selectedOrderList = new List<Order>();
            InitializeComponent();
            UnableButton();
        }

        private void UnableButton()
        {
            update_order_button.Enabled = false;
            search_order_button.Enabled = false;
            delete_order_button.Enabled = false;
            export_order_button.Enabled = false;
        }

        private void EnableButton()
        {
            update_order_button.Enabled = true;
            search_order_button.Enabled = true;
            delete_order_button.Enabled = true;
            export_order_button.Enabled = true;
        }
        private void export_button_Click(object sender, EventArgs e)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmls.Serialize(fs, orderService.OrderList);
            }
        }

        
        

       

        private void create_order_button_Click(object sender, EventArgs e)
        {
            CreateForm form2 = new CreateForm(orderService);
            form2.ShowDialog(this);
            orderService_bindingSource.DataSource = orderService;
            orderService_bindingSource.ResetBindings(true);
            if (orderService.OrderList.Count != 0)
            {
                EnableButton();
            }
        }

        

        

        private void update_order_button_Click(object sender, EventArgs e)
        {
            
            Order order = (Order)dataGridView1.CurrentRow.DataBoundItem;
            CreateForm form2 = new CreateForm(orderService,order);
            form2.ShowDialog(this);
            orderService_bindingSource.DataSource = orderService;
            orderService_bindingSource.ResetBindings(true);
        }

        private void search_order_button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void SetVisible(Boolean b)
        {
            SearchType_label.Visible = b;
            Search_textBox.Visible = b;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderID_radioButton.Checked)
            {
                SearchType_label.Text = "订单号：";
                SetVisible(true);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ClientName_radioButton.Checked)
            {
                SearchType_label.Text = "用户名：";
                SetVisible(true);
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderPrices_radioButton.Checked)
            {
                SearchType_label.Text = "订单金额：";
                SetVisible(true);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (GoodsName_radioButton.Checked)
            {
                SearchType_label.Text = "商品名称";
                SetVisible(true);
            }
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (AllOrder_radioButton.Checked)
            {
                SetVisible(false);
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OrderService searchOrderService=new OrderService();
            List<Order> lo;
            if (OrderID_radioButton.Checked)
            {
                lo = orderService.SearchOrderByOrderID(Search_textBox.Text);
            }
            else if (ClientName_radioButton.Checked)
            {
                lo = orderService.SearchOrderByClientName(Search_textBox.Text);
            }
            else if (OrderPrices_radioButton.Checked)
            {
                lo = orderService.SearchOrderByTotalPrice(Convert.ToDouble(Search_textBox.Text));
            }
            else if (GoodsName_radioButton.Checked)
            {
                lo = orderService.SearchOrderByGoodsName(Search_textBox.Text);
            }
            else
            {
                lo = orderService.SearchAllOrder();
            }
            foreach(Order o in lo)
            {
                searchOrderService.AddOrder(o);
            }
            Search_textBox.Text = "";
            groupBox1.Visible = false;
            orderService_bindingSource.DataSource = searchOrderService;
            orderService_bindingSource.ResetBindings(true);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (AllOrder_radioButton.Checked)
            {
                SetVisible(false);
            }
        }
        

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Order order = (Order)dataGridView1.CurrentRow.DataBoundItem;
            order_bindingSource.DataSource = order;
            order_bindingSource.ResetBindings(true);
        }

       

        private void delete_order_button_Click(object sender, EventArgs e)
        {
            Order order = (Order)dataGridView1.CurrentRow.DataBoundItem;
            orderService.DeleteOrder(order.OrderID);
            order_bindingSource.ResetBindings(true);
            orderService_bindingSource.ResetBindings(true);
            
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                List<Order> lo = (List<Order>)xmls.Deserialize(fs);
                foreach (Order o in lo)
                {
                    if (!orderService.OrderList.Contains(o))
                    {
                        orderService.OrderList.Add(o);
                    }
                }
            }
            orderService_bindingSource.DataSource = orderService;
            orderService_bindingSource.ResetBindings(true);
            if (orderService.OrderList.Count != 0)
            {
                EnableButton();
            }
        }
    }
}
