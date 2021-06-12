namespace Homework8
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.add_order_label = new System.Windows.Forms.Label();
            this.new_clientName_label = new System.Windows.Forms.Label();
            this.new_clientName_textBox = new System.Windows.Forms.TextBox();
            this.new_goods_name_label = new System.Windows.Forms.Label();
            this.new_goodsName_textBox = new System.Windows.Forms.TextBox();
            this.new_goods_price_label = new System.Windows.Forms.Label();
            this.new_goods_price_textBox = new System.Windows.Forms.TextBox();
            this.new_goods_count_label = new System.Windows.Forms.Label();
            this.new_goods_count_textbox = new System.Windows.Forms.TextBox();
            this.add_order_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addOrderDetails_button = new System.Windows.Forms.Button();
            this.updateOrderDetails_button = new System.Windows.Forms.Button();
            this.deleteOrderdetails_button = new System.Windows.Forms.Button();
            this.clientName_button = new System.Windows.Forms.Button();
            this.orderID_label = new System.Windows.Forms.Label();
            this.orderID_content_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add_order_label
            // 
            this.add_order_label.AutoSize = true;
            this.add_order_label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_order_label.Location = new System.Drawing.Point(331, 21);
            this.add_order_label.Name = "add_order_label";
            this.add_order_label.Size = new System.Drawing.Size(87, 15);
            this.add_order_label.TabIndex = 0;
            this.add_order_label.Text = "添加新订单";
            // 
            // new_clientName_label
            // 
            this.new_clientName_label.AutoSize = true;
            this.new_clientName_label.Location = new System.Drawing.Point(225, 111);
            this.new_clientName_label.Name = "new_clientName_label";
            this.new_clientName_label.Size = new System.Drawing.Size(67, 15);
            this.new_clientName_label.TabIndex = 1;
            this.new_clientName_label.Text = "用户名称";
            // 
            // new_clientName_textBox
            // 
            this.new_clientName_textBox.Location = new System.Drawing.Point(368, 101);
            this.new_clientName_textBox.Name = "new_clientName_textBox";
            this.new_clientName_textBox.Size = new System.Drawing.Size(100, 25);
            this.new_clientName_textBox.TabIndex = 2;
            // 
            // new_goods_name_label
            // 
            this.new_goods_name_label.AutoSize = true;
            this.new_goods_name_label.Location = new System.Drawing.Point(29, 161);
            this.new_goods_name_label.Name = "new_goods_name_label";
            this.new_goods_name_label.Size = new System.Drawing.Size(67, 15);
            this.new_goods_name_label.TabIndex = 3;
            this.new_goods_name_label.Text = "商品名称";
            // 
            // new_goodsName_textBox
            // 
            this.new_goodsName_textBox.Location = new System.Drawing.Point(117, 151);
            this.new_goodsName_textBox.Name = "new_goodsName_textBox";
            this.new_goodsName_textBox.Size = new System.Drawing.Size(100, 25);
            this.new_goodsName_textBox.TabIndex = 4;
            // 
            // new_goods_price_label
            // 
            this.new_goods_price_label.AutoSize = true;
            this.new_goods_price_label.Location = new System.Drawing.Point(256, 161);
            this.new_goods_price_label.Name = "new_goods_price_label";
            this.new_goods_price_label.Size = new System.Drawing.Size(67, 15);
            this.new_goods_price_label.TabIndex = 5;
            this.new_goods_price_label.Text = "商品单价";
            // 
            // new_goods_price_textBox
            // 
            this.new_goods_price_textBox.Location = new System.Drawing.Point(355, 151);
            this.new_goods_price_textBox.Name = "new_goods_price_textBox";
            this.new_goods_price_textBox.Size = new System.Drawing.Size(100, 25);
            this.new_goods_price_textBox.TabIndex = 6;
            // 
            // new_goods_count_label
            // 
            this.new_goods_count_label.AutoSize = true;
            this.new_goods_count_label.Location = new System.Drawing.Point(481, 161);
            this.new_goods_count_label.Name = "new_goods_count_label";
            this.new_goods_count_label.Size = new System.Drawing.Size(67, 15);
            this.new_goods_count_label.TabIndex = 7;
            this.new_goods_count_label.Text = "商品数量";
            // 
            // new_goods_count_textbox
            // 
            this.new_goods_count_textbox.Location = new System.Drawing.Point(610, 151);
            this.new_goods_count_textbox.Name = "new_goods_count_textbox";
            this.new_goods_count_textbox.Size = new System.Drawing.Size(100, 25);
            this.new_goods_count_textbox.TabIndex = 8;
            // 
            // add_order_button
            // 
            this.add_order_button.Location = new System.Drawing.Point(298, 402);
            this.add_order_button.Name = "add_order_button";
            this.add_order_button.Size = new System.Drawing.Size(129, 23);
            this.add_order_button.TabIndex = 9;
            this.add_order_button.Text = "确认提交订单";
            this.add_order_button.UseVisualStyleBackColor = true;
            this.add_order_button.Click += new System.EventHandler(this.add_order_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataMember = "OrderDetailsList";
            this.dataGridView1.DataSource = this.order_bindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(81, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(639, 123);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // order_bindingSource
            // 
            this.order_bindingSource.DataSource = typeof(Homework5_1.Order);
            // 
            // addOrderDetails_button
            // 
            this.addOrderDetails_button.Location = new System.Drawing.Point(117, 205);
            this.addOrderDetails_button.Name = "addOrderDetails_button";
            this.addOrderDetails_button.Size = new System.Drawing.Size(124, 23);
            this.addOrderDetails_button.TabIndex = 11;
            this.addOrderDetails_button.Text = "添加订单明细";
            this.addOrderDetails_button.UseVisualStyleBackColor = true;
            this.addOrderDetails_button.Click += new System.EventHandler(this.addOrderDetails_button_Click);
            // 
            // updateOrderDetails_button
            // 
            this.updateOrderDetails_button.Location = new System.Drawing.Point(324, 204);
            this.updateOrderDetails_button.Name = "updateOrderDetails_button";
            this.updateOrderDetails_button.Size = new System.Drawing.Size(131, 23);
            this.updateOrderDetails_button.TabIndex = 12;
            this.updateOrderDetails_button.Text = "修改订单明细";
            this.updateOrderDetails_button.UseVisualStyleBackColor = true;
            this.updateOrderDetails_button.Click += new System.EventHandler(this.updateOrderDetails_button_Click);
            // 
            // deleteOrderdetails_button
            // 
            this.deleteOrderdetails_button.Location = new System.Drawing.Point(543, 204);
            this.deleteOrderdetails_button.Name = "deleteOrderdetails_button";
            this.deleteOrderdetails_button.Size = new System.Drawing.Size(119, 23);
            this.deleteOrderdetails_button.TabIndex = 13;
            this.deleteOrderdetails_button.Text = "删除订单明细";
            this.deleteOrderdetails_button.UseVisualStyleBackColor = true;
            this.deleteOrderdetails_button.Click += new System.EventHandler(this.deleteOrderdetails_button_Click);
            // 
            // clientName_button
            // 
            this.clientName_button.Location = new System.Drawing.Point(541, 100);
            this.clientName_button.Name = "clientName_button";
            this.clientName_button.Size = new System.Drawing.Size(121, 23);
            this.clientName_button.TabIndex = 14;
            this.clientName_button.Text = "确认客户名";
            this.clientName_button.UseVisualStyleBackColor = true;
            this.clientName_button.Click += new System.EventHandler(this.clientName_button_Click);
            // 
            // orderID_label
            // 
            this.orderID_label.AutoSize = true;
            this.orderID_label.Location = new System.Drawing.Point(256, 68);
            this.orderID_label.Name = "orderID_label";
            this.orderID_label.Size = new System.Drawing.Size(52, 15);
            this.orderID_label.TabIndex = 15;
            this.orderID_label.Text = "订单号";
            this.orderID_label.Visible = false;
            // 
            // orderID_content_label
            // 
            this.orderID_content_label.AutoSize = true;
            this.orderID_content_label.Location = new System.Drawing.Point(455, 68);
            this.orderID_content_label.Name = "orderID_content_label";
            this.orderID_content_label.Size = new System.Drawing.Size(55, 15);
            this.orderID_content_label.TabIndex = 16;
            this.orderID_content_label.Text = "label1";
            this.orderID_content_label.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "od";
            this.odDataGridViewTextBoxColumn.HeaderText = "od";
            this.odDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            this.odDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "Goods";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "Goods";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            this.goodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Prices";
            this.dataGridViewTextBoxColumn1.HeaderText = "Prices";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderID_content_label);
            this.Controls.Add(this.orderID_label);
            this.Controls.Add(this.clientName_button);
            this.Controls.Add(this.deleteOrderdetails_button);
            this.Controls.Add(this.updateOrderDetails_button);
            this.Controls.Add(this.addOrderDetails_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_order_button);
            this.Controls.Add(this.new_goods_count_textbox);
            this.Controls.Add(this.new_goods_count_label);
            this.Controls.Add(this.new_goods_price_textBox);
            this.Controls.Add(this.new_goods_price_label);
            this.Controls.Add(this.new_goodsName_textBox);
            this.Controls.Add(this.new_goods_name_label);
            this.Controls.Add(this.new_clientName_textBox);
            this.Controls.Add(this.new_clientName_label);
            this.Controls.Add(this.add_order_label);
            this.Name = "CreateForm";
            this.Text = "Form2";
            this.Click += new System.EventHandler(this.CreateForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label add_order_label;
        private System.Windows.Forms.Label new_clientName_label;
        private System.Windows.Forms.TextBox new_clientName_textBox;
        private System.Windows.Forms.Label new_goods_name_label;
        private System.Windows.Forms.TextBox new_goodsName_textBox;
        private System.Windows.Forms.Label new_goods_price_label;
        private System.Windows.Forms.TextBox new_goods_price_textBox;
        private System.Windows.Forms.Label new_goods_count_label;
        private System.Windows.Forms.TextBox new_goods_count_textbox;
        private System.Windows.Forms.Button add_order_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource order_bindingSource;
        private System.Windows.Forms.Button addOrderDetails_button;
        private System.Windows.Forms.Button updateOrderDetails_button;
        private System.Windows.Forms.Button deleteOrderdetails_button;
        private System.Windows.Forms.Button clientName_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label orderID_label;
        private System.Windows.Forms.Label orderID_content_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn odDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}