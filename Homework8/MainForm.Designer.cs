namespace Homework8
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.AllOrder_radioButton = new System.Windows.Forms.RadioButton();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.GoodsName_radioButton = new System.Windows.Forms.RadioButton();
            this.SearchType_label = new System.Windows.Forms.Label();
            this.OrderPrices_radioButton = new System.Windows.Forms.RadioButton();
            this.ClientName_radioButton = new System.Windows.Forms.RadioButton();
            this.OrderID_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.import_button = new System.Windows.Forms.Button();
            this.export_order_button = new System.Windows.Forms.Button();
            this.delete_order_button = new System.Windows.Forms.Button();
            this.search_order_button = new System.Windows.Forms.Button();
            this.update_order_button = new System.Windows.Forms.Button();
            this.create_order_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPricesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderService_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderService_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.import_button);
            this.panel1.Controls.Add(this.export_order_button);
            this.panel1.Controls.Add(this.delete_order_button);
            this.panel1.Controls.Add(this.search_order_button);
            this.panel1.Controls.Add(this.update_order_button);
            this.panel1.Controls.Add(this.create_order_button);
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 263);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_button);
            this.groupBox1.Controls.Add(this.AllOrder_radioButton);
            this.groupBox1.Controls.Add(this.Search_textBox);
            this.groupBox1.Controls.Add(this.GoodsName_radioButton);
            this.groupBox1.Controls.Add(this.SearchType_label);
            this.groupBox1.Controls.Add(this.OrderPrices_radioButton);
            this.groupBox1.Controls.Add(this.ClientName_radioButton);
            this.groupBox1.Controls.Add(this.OrderID_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(127, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 158);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search_button.Location = new System.Drawing.Point(411, 55);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(157, 38);
            this.Search_button.TabIndex = 11;
            this.Search_button.Text = "查询";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllOrder_radioButton
            // 
            this.AllOrder_radioButton.AutoSize = true;
            this.AllOrder_radioButton.Location = new System.Drawing.Point(400, 25);
            this.AllOrder_radioButton.Name = "AllOrder_radioButton";
            this.AllOrder_radioButton.Size = new System.Drawing.Size(88, 19);
            this.AllOrder_radioButton.TabIndex = 4;
            this.AllOrder_radioButton.TabStop = true;
            this.AllOrder_radioButton.Text = "所有订单";
            this.AllOrder_radioButton.UseVisualStyleBackColor = true;
            this.AllOrder_radioButton.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged_1);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(157, 68);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(150, 25);
            this.Search_textBox.TabIndex = 10;
            this.Search_textBox.Visible = false;
            
            // 
            // GoodsName_radioButton
            // 
            this.GoodsName_radioButton.AutoSize = true;
            this.GoodsName_radioButton.Location = new System.Drawing.Point(289, 24);
            this.GoodsName_radioButton.Name = "GoodsName_radioButton";
            this.GoodsName_radioButton.Size = new System.Drawing.Size(88, 19);
            this.GoodsName_radioButton.TabIndex = 3;
            this.GoodsName_radioButton.TabStop = true;
            this.GoodsName_radioButton.Text = "商品名称";
            this.GoodsName_radioButton.UseVisualStyleBackColor = true;
            this.GoodsName_radioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // SearchType_label
            // 
            this.SearchType_label.AutoSize = true;
            this.SearchType_label.Location = new System.Drawing.Point(34, 71);
            this.SearchType_label.Name = "SearchType_label";
            this.SearchType_label.Size = new System.Drawing.Size(67, 15);
            this.SearchType_label.TabIndex = 9;
            this.SearchType_label.Text = "查询类型";
            this.SearchType_label.Visible = false;
            // 
            // OrderPrices_radioButton
            // 
            this.OrderPrices_radioButton.AutoSize = true;
            this.OrderPrices_radioButton.Location = new System.Drawing.Point(195, 25);
            this.OrderPrices_radioButton.Name = "OrderPrices_radioButton";
            this.OrderPrices_radioButton.Size = new System.Drawing.Size(88, 19);
            this.OrderPrices_radioButton.TabIndex = 2;
            this.OrderPrices_radioButton.TabStop = true;
            this.OrderPrices_radioButton.Text = "订单金额";
            this.OrderPrices_radioButton.UseVisualStyleBackColor = true;
            this.OrderPrices_radioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ClientName_radioButton
            // 
            this.ClientName_radioButton.AutoSize = true;
            this.ClientName_radioButton.Location = new System.Drawing.Point(107, 24);
            this.ClientName_radioButton.Name = "ClientName_radioButton";
            this.ClientName_radioButton.Size = new System.Drawing.Size(73, 19);
            this.ClientName_radioButton.TabIndex = 1;
            this.ClientName_radioButton.TabStop = true;
            this.ClientName_radioButton.Text = "用户名";
            this.ClientName_radioButton.UseVisualStyleBackColor = true;
            this.ClientName_radioButton.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // OrderID_radioButton
            // 
            this.OrderID_radioButton.AutoSize = true;
            this.OrderID_radioButton.Location = new System.Drawing.Point(28, 25);
            this.OrderID_radioButton.Name = "OrderID_radioButton";
            this.OrderID_radioButton.Size = new System.Drawing.Size(73, 19);
            this.OrderID_radioButton.TabIndex = 0;
            this.OrderID_radioButton.TabStop = true;
            this.OrderID_radioButton.Text = "订单号";
            this.OrderID_radioButton.UseVisualStyleBackColor = true;
            this.OrderID_radioButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, -42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 7;
            // 
            // import_button
            // 
            this.import_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.import_button.Location = new System.Drawing.Point(696, 61);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(101, 32);
            this.import_button.TabIndex = 6;
            this.import_button.Text = "导入订单";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // export_order_button
            // 
            this.export_order_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.export_order_button.Location = new System.Drawing.Point(556, 61);
            this.export_order_button.Name = "export_order_button";
            this.export_order_button.Size = new System.Drawing.Size(101, 32);
            this.export_order_button.TabIndex = 5;
            this.export_order_button.Text = "导出订单";
            this.export_order_button.UseVisualStyleBackColor = true;
            this.export_order_button.Click += new System.EventHandler(this.export_button_Click);
            // 
            // delete_order_button
            // 
            this.delete_order_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delete_order_button.Location = new System.Drawing.Point(414, 61);
            this.delete_order_button.Name = "delete_order_button";
            this.delete_order_button.Size = new System.Drawing.Size(101, 32);
            this.delete_order_button.TabIndex = 4;
            this.delete_order_button.Text = "删除订单";
            this.delete_order_button.UseVisualStyleBackColor = true;
            this.delete_order_button.Click += new System.EventHandler(this.delete_order_button_Click);
            // 
            // search_order_button
            // 
            this.search_order_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search_order_button.Location = new System.Drawing.Point(284, 61);
            this.search_order_button.Name = "search_order_button";
            this.search_order_button.Size = new System.Drawing.Size(101, 32);
            this.search_order_button.TabIndex = 3;
            this.search_order_button.Text = "查询订单";
            this.search_order_button.UseVisualStyleBackColor = true;
            this.search_order_button.Click += new System.EventHandler(this.search_order_button_Click);
            // 
            // update_order_button
            // 
            this.update_order_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.update_order_button.Location = new System.Drawing.Point(150, 61);
            this.update_order_button.Name = "update_order_button";
            this.update_order_button.Size = new System.Drawing.Size(101, 32);
            this.update_order_button.TabIndex = 2;
            this.update_order_button.Text = "修改订单";
            this.update_order_button.UseVisualStyleBackColor = true;
            this.update_order_button.Click += new System.EventHandler(this.update_order_button_Click);
            // 
            // create_order_button
            // 
            this.create_order_button.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.create_order_button.Location = new System.Drawing.Point(12, 61);
            this.create_order_button.Name = "create_order_button";
            this.create_order_button.Size = new System.Drawing.Size(101, 32);
            this.create_order_button.TabIndex = 1;
            this.create_order_button.Text = "添加订单";
            this.create_order_button.UseVisualStyleBackColor = true;
            this.create_order_button.Click += new System.EventHandler(this.create_order_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_label.Location = new System.Drawing.Point(347, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(103, 15);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "订单管理程序";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.totalPricesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderService_bindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(515, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            
            
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPricesDataGridViewTextBoxColumn
            // 
            this.totalPricesDataGridViewTextBoxColumn.DataPropertyName = "TotalPrices";
            this.totalPricesDataGridViewTextBoxColumn.HeaderText = "TotalPrices";
            this.totalPricesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPricesDataGridViewTextBoxColumn.Name = "totalPricesDataGridViewTextBoxColumn";
            this.totalPricesDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPricesDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderService_bindingSource
            // 
            this.orderService_bindingSource.AllowNew = true;
            this.orderService_bindingSource.DataMember = "OrderList";
            this.orderService_bindingSource.DataSource = typeof(Homework5_1.OrderService);
            
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.pricesDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "OrderDetailsList";
            this.dataGridView2.DataSource = this.order_bindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(515, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(559, 254);
            this.dataGridView2.TabIndex = 2;
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
            // pricesDataGridViewTextBoxColumn
            // 
            this.pricesDataGridViewTextBoxColumn.DataPropertyName = "Prices";
            this.pricesDataGridViewTextBoxColumn.HeaderText = "Prices";
            this.pricesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricesDataGridViewTextBoxColumn.Name = "pricesDataGridViewTextBoxColumn";
            this.pricesDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricesDataGridViewTextBoxColumn.Width = 125;
            // 
            // order_bindingSource
            // 
            this.order_bindingSource.DataSource = typeof(Homework5_1.Order);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 517);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderService_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update_order_button;
        private System.Windows.Forms.Button create_order_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button export_order_button;
        private System.Windows.Forms.Button delete_order_button;
        private System.Windows.Forms.Button search_order_button;
        private System.Windows.Forms.BindingSource orderService_bindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource order_bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPricesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label SearchType_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AllOrder_radioButton;
        private System.Windows.Forms.RadioButton GoodsName_radioButton;
        private System.Windows.Forms.RadioButton OrderPrices_radioButton;
        private System.Windows.Forms.RadioButton ClientName_radioButton;
        private System.Windows.Forms.RadioButton OrderID_radioButton;
        private System.Windows.Forms.Label label2;
    }
}

