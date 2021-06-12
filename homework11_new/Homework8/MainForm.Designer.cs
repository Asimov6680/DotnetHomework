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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientClientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderService_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdatabaseDataSet = new Homework8.orderdatabaseDataSet();
            this.orderdatabaseDataSet1 = new Homework8.orderdatabaseDataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.odDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdetail_bindingsource = new System.Windows.Forms.BindingSource(this.components);
            this.orderdbDataSet1 = new Homework8.orderdbDataSet1();
            this.ordersTableAdapter = new Homework8.orderdbDataSet1TableAdapters.ordersTableAdapter();
            this.ordersTableAdapter1 = new Homework8.orderdatabaseDataSetTableAdapters.ordersTableAdapter();
            this.orderdbDataSet = new Homework8.orderdbDataSet();
            this.ordersTableAdapter2 = new Homework8.orderdatabaseDataSet1TableAdapters.ordersTableAdapter();
            this.orderdatabaseDataSet0 = new Homework8.orderdatabaseDataSet0();
            this.ordersTableAdapter3 = new Homework8.orderdatabaseDataSet0TableAdapters.ordersTableAdapter();
            this.orderdatabaseDataSetF = new Homework8.orderdatabaseDataSetF();
            this.ordersTableAdapter4 = new Homework8.orderdatabaseDataSetFTableAdapters.ordersTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderService_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetail_bindingsource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetF)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
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
            this.orderIDDataGridViewTextBoxColumn,
            this.clientClientNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderService_bindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(494, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientClientNameDataGridViewTextBoxColumn
            // 
            this.clientClientNameDataGridViewTextBoxColumn.DataPropertyName = "Client_ClientName";
            this.clientClientNameDataGridViewTextBoxColumn.HeaderText = "Client_ClientName";
            this.clientClientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientClientNameDataGridViewTextBoxColumn.Name = "clientClientNameDataGridViewTextBoxColumn";
            this.clientClientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderService_bindingSource
            // 
            this.orderService_bindingSource.AllowNew = true;
            this.orderService_bindingSource.DataMember = "orders";
            this.orderService_bindingSource.DataSource = this.orderdatabaseDataSetF;
            this.orderService_bindingSource.CurrentChanged += new System.EventHandler(this.orderService_bindingSource_CurrentChanged);
            // 
            // orderdatabaseDataSet
            // 
            this.orderdatabaseDataSet.DataSetName = "orderdatabaseDataSet";
            this.orderdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdatabaseDataSet1
            // 
            this.orderdatabaseDataSet1.DataSetName = "orderdatabaseDataSet1";
            this.orderdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView2.DataSource = this.orderdetail_bindingsource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(494, 263);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(580, 254);
            this.dataGridView2.TabIndex = 2;
            // 
            // odDataGridViewTextBoxColumn
            // 
            this.odDataGridViewTextBoxColumn.DataPropertyName = "od";
            this.odDataGridViewTextBoxColumn.HeaderText = "od";
            this.odDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odDataGridViewTextBoxColumn.Name = "odDataGridViewTextBoxColumn";
            this.odDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn6.HeaderText = "Count";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Goods";
            this.dataGridViewTextBoxColumn7.HeaderText = "Goods";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Prices";
            this.dataGridViewTextBoxColumn15.HeaderText = "Prices";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // orderdetail_bindingsource
            // 
            this.orderdetail_bindingsource.DataSource = typeof(Homework5_1.OrderDetails);
            // 
            // orderdbDataSet1
            // 
            this.orderdbDataSet1.DataSetName = "orderdbDataSet1";
            this.orderdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // orderdbDataSet
            // 
            this.orderdbDataSet.DataSetName = "orderdbDataSet";
            this.orderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // orderdatabaseDataSet0
            // 
            this.orderdatabaseDataSet0.DataSetName = "orderdatabaseDataSet0";
            this.orderdatabaseDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter3
            // 
            this.ordersTableAdapter3.ClearBeforeFill = true;
            // 
            // orderdatabaseDataSetF
            // 
            this.orderdatabaseDataSetF.DataSetName = "orderdatabaseDataSetF";
            this.orderdatabaseDataSetF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter4
            // 
            this.ordersTableAdapter4.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderService_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetail_bindingsource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatabaseDataSetF)).EndInit();
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
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDesignableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private orderdbDataSet1 orderdbDataSet1;
        private orderdbDataSet1TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private orderdatabaseDataSet orderdatabaseDataSet;
        private orderdatabaseDataSetTableAdapters.ordersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private orderdbDataSet orderdbDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn odDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.BindingSource orderdetail_bindingsource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private orderdatabaseDataSet1 orderdatabaseDataSet1;
        private orderdatabaseDataSet1TableAdapters.ordersTableAdapter ordersTableAdapter2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private orderdatabaseDataSet0 orderdatabaseDataSet0;
        private orderdatabaseDataSet0TableAdapters.ordersTableAdapter ordersTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientClientNameDataGridViewTextBoxColumn;
        private orderdatabaseDataSetF orderdatabaseDataSetF;
        private orderdatabaseDataSetFTableAdapters.ordersTableAdapter ordersTableAdapter4;
    }
}

