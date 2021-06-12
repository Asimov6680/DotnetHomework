using Homework5_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class CreateForm : Form
    {
        private OrderService orderService;
        private Order order;
        

        public CreateForm(OrderService orderService)
        {
            this.orderService = orderService;
            
            InitializeComponent();
            add_order_label.Text = "添加新订单";
            UnableTextBox();
            addOrderDetails_button.Enabled = false;
            //UnableButton();
            //order_bindingSource.DataSource = order;
           
        }

        public CreateForm(OrderService orderService,Order order)
        {
            this.orderService = orderService;
            this.order = order;
            InitializeComponent();
            add_order_label.Text = "修改订单";
            new_clientName_textBox.Text = order.Client.ClientName;
            new_clientName_textBox.Enabled = false;
            clientName_button.Enabled = false;

            //UnableButton();
            
            order_bindingSource.DataSource = order;

            orderID_content_label.Text = order.OrderID;
            orderID_content_label.Visible = true;
            orderID_label.Visible = true;
            
        }

        private void UnableButton()
        {
            updateOrderDetails_button.Enabled = false;
            deleteOrderdetails_button.Enabled = false;
            add_order_button.Enabled = false;
        }

        private void EnableButton()
        {
            updateOrderDetails_button.Enabled = true;
            deleteOrderdetails_button.Enabled = true;
            add_order_button.Enabled = true;
        }
        

        private void add_order_button_Click(object sender, EventArgs e)
        {

            
            //Goods goods = new Goods(new_goodsName_textBox.Text, Convert.ToDouble(new_goods_price_textBox.Text));
            //Order order = new Order(client);
            //order.AddOrderDetails(new OrderDetails(goods, Convert.ToInt32(new_goods_count_textbox.Text)));
            this.orderService.AddOrder(order);
            this.orderService.SaveChanges();
            this.Close();
            
        }

        

        /*private void CheckToHandle()
        {
            if (order.OrderDetailsList.Count == 0)
            {
                add_order_button.Enabled = false;
            }
            else
            {
                add_order_button.Enabled = true;
            }
        }*/

        private void ClearTextBox()
        {
            new_goodsName_textBox.Text = "";
            new_goods_price_textBox.Text = "";
            new_goods_count_textbox.Text = "";
        }
        private void EnableTextBox()
        {
            new_goods_price_textBox.Enabled = true;
            new_goodsName_textBox.Enabled = true;
        }

        private void UnableTextBox()
        {
            new_goods_price_textBox.Enabled = false;
            new_goodsName_textBox.Enabled = false;
        }
        private void addOrderDetails_button_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods(new_goodsName_textBox.Text, Convert.ToDouble(new_goods_price_textBox.Text));
            this.order.AddOrderDetails(new OrderDetails(goods, Convert.ToInt32(new_goods_count_textbox.Text)));
            order_bindingSource.DataSource = order.OrderDetailsList;
            order_bindingSource.ResetBindings(true);
            //UnableButton();
            ClearTextBox();
            //CheckToHandle();
        }

        private void clientName_button_Click(object sender, EventArgs e)
        {
            if (new_clientName_textBox.Text != "")
            {
                this.order = new Order(new Client(new_clientName_textBox.Text));
                //order_bindingSource.DataSource = order;
                new_clientName_textBox.Enabled = false;
                clientName_button.Enabled = false;
                EnableTextBox();
                addOrderDetails_button.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderDetails  od = (OrderDetails)dataGridView1.CurrentRow.DataBoundItem;
            new_goodsName_textBox.Text = od.Goods.Name;
            addOrderDetails_button.Enabled = false;
            UnableTextBox();
            //EnableButton();
            new_goods_count_textbox.Text = "" + od.Count;
            new_goods_price_textBox.Text = "" + od.Goods.Price;
            

        }

        private void updateOrderDetails_button_Click(object sender, EventArgs e)
        {
            if (!new_goodsName_textBox.Enabled)
            {
                OrderDetails od = (OrderDetails)dataGridView1.CurrentRow.DataBoundItem;

                int count = Convert.ToInt32(new_goods_count_textbox.Text);
                order.UpdateOrderDetails(od.Goods.Name, count);
                order_bindingSource.ResetBindings(true);
                EnableTextBox();
                ClearTextBox();
            }
            addOrderDetails_button.Enabled = true;
            //UnableButton();
            //CheckToHandle();
        }

        private void deleteOrderdetails_button_Click(object sender, EventArgs e)
        {
            if (!new_goodsName_textBox.Enabled)
            {
                OrderDetails od = (OrderDetails)dataGridView1.CurrentRow.DataBoundItem;
                order.DeleteOrderDetails(od.Goods.Name);
                ClearTextBox();
                order_bindingSource.ResetBindings(true);
                EnableTextBox();
            }
            addOrderDetails_button.Enabled = true;
            //UnableButton();
            //CheckToHandle();
        }

        private void CreateForm_Click(object sender, EventArgs e)
        {
            if (clientName_button.Enabled == false)
            {
                EnableTextBox();
                new_goods_count_textbox.Enabled = true;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = order.ToString();
        }
    }
}
