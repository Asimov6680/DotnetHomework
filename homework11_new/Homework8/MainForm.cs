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

            //this.clientClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_ClientName";
            orderService_bindingSource.DataSource = orderdatabaseDataSetF;

            this.clientClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_ClientName";
            this.ordersTableAdapter4.Fill(this.orderdatabaseDataSetF.orders);
            orderService_bindingSource.ResetBindings(true);
            /* if (orderService.OrderList.Count != 0)
             {
                 EnableButton();
             }*/
            
        }

        

        

        private void update_order_button_Click(object sender, EventArgs e)
        {

            string s = dataGridView1.CurrentCell.Value.ToString();
            /* Order order = (Order)orderService_bindingSource.Current;
             //Order order=
            
             order_bindingSource.DataSource = order;
             order_bindingSource.ResetBindings(true);*/

            //label1.Text = orderService.SearchOrderByOrderID(s)[0].OrderDetailsList[0] == null ? "a" : "b";
            Order order = orderService.SearchOrderByOrderID(s)[0];
            CreateForm form2 = new CreateForm(orderService,order);
            form2.ShowDialog(this);
            //orderService_bindingSource.DataSource = orderService;
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
                lo = orderService.SearchOrderByOrderID_1(Search_textBox.Text);
                label1.Text = lo[0].ToString();
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
                lo = orderService.SearchOrderByGoodsName_1(Search_textBox.Text);
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
            //orderService_bindingSource
            this.clientClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client";
            orderService_bindingSource.DataSource = lo;
            
            //orderService_bindingSource.DataMember = "Client";
            //orderService_bindingSource.DataSource = searchOrderService;
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
            string s = dataGridView1.CurrentCell.Value.ToString();
            /* Order order = (Order)orderService_bindingSource.Current;
             //Order order=
            
             order_bindingSource.DataSource = order;
             order_bindingSource.ResetBindings(true);*/

            //label1.Text = orderService.SearchOrderByOrderID(s)[0].OrderDetailsList[0] == null ? "a" : "b";
            Order order = orderService.SearchOrderByOrderID(s)[0];
            
            //label1.Text = order.ToString();
            orderdetail_bindingsource.DataSource = order.OrderDetailsList;
            
            orderdetail_bindingsource.ResetBindings(true);

            
        }

       

        private void delete_order_button_Click(object sender, EventArgs e)
        {
            string s = dataGridView1.CurrentCell.Value.ToString();
           
            Order order = orderService.SearchOrderByOrderID(s)[0];
           /* label1.Text = order.ToString();*/
            orderService.DeleteOrder(order.OrderID);
            orderService.SaveChanges();
            orderService_bindingSource.DataSource = orderdatabaseDataSetF;
            orderService_bindingSource.ResetBindings(true);
            orderdetail_bindingsource.ResetBindings(true);
            
            
            
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
            //orderService_bindingSource.DataSource = orderService;
            orderService_bindingSource.ResetBindings(true);
            /*if (orderService.OrderList.Count != 0)
            {
                EnableButton();
            }*/
        }

        private void orderService_bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.clientClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_ClientName";
            // TODO: 这行代码将数据加载到表“orderdatabaseDataSetF.orders”中。您可以根据需要移动或删除它。
            this.ordersTableAdapter4.Fill(this.orderdatabaseDataSetF.orders);
            // TODO: 这行代码将数据加载到表“orderdatabaseDataSet0.orders”中。您可以根据需要移动或删除它。
            //this.ordersTableAdapter1.Fill(this.orderdatabaseDataSet.orders);
            // TODO: 这行代码将数据加载到表“orderdatabaseDataSet.orders”中。您可以根据需要移动或删除它。
            //this.ordersTableAdapter2.Fill(this.orderdatabaseDataSet1.orders);
            //orderService_bindingSource.DataSource = orderdatabaseDataSet;
            //orderService_bindingSource.ResetBindings(true);
           //this.clientClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            orderService_bindingSource.DataSource = orderdatabaseDataSet0;
            this.ordersTableAdapter4.Fill(this.orderdatabaseDataSetF.orders);
            orderService_bindingSource.ResetBindings(true);
        }
    }
}
