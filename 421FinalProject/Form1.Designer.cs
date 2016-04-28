namespace _421FinalProject
{
    partial class PSUBMainForm
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
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.pnlOrderDetail = new System.Windows.Forms.Panel();
            this.lbOrderDetail = new System.Windows.Forms.Label();
            this.tbItemStatus = new System.Windows.Forms.RichTextBox();
            this.lbOrderItems = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbInitialOrder = new System.Windows.Forms.RichTextBox();
            this.pnlCustomerQueue = new System.Windows.Forms.Panel();
            this.lbCustomerList = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlOrders = new _421FinalProject.OrderPanel();
            this.pnlOrderDetail.SuspendLayout();
            this.pnlCustomerQueue.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewOrder.BackColor = System.Drawing.Color.Black;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(826, 806);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(232, 91);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = " New Order";
            this.btnNewOrder.UseVisualStyleBackColor = false;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrderDetail.Controls.Add(this.lbOrderDetail);
            this.pnlOrderDetail.Controls.Add(this.tbItemStatus);
            this.pnlOrderDetail.Controls.Add(this.lbOrderItems);
            this.pnlOrderDetail.Controls.Add(this.lbCustomer);
            this.pnlOrderDetail.Controls.Add(this.lbStatus);
            this.pnlOrderDetail.Controls.Add(this.tbInitialOrder);
            this.pnlOrderDetail.Location = new System.Drawing.Point(316, 18);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(742, 782);
            this.pnlOrderDetail.TabIndex = 3;
            // 
            // lbOrderDetail
            // 
            this.lbOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOrderDetail.AutoSize = true;
            this.lbOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderDetail.ForeColor = System.Drawing.Color.White;
            this.lbOrderDetail.Location = new System.Drawing.Point(280, 3);
            this.lbOrderDetail.Name = "lbOrderDetail";
            this.lbOrderDetail.Size = new System.Drawing.Size(205, 37);
            this.lbOrderDetail.TabIndex = 6;
            this.lbOrderDetail.Text = "Order Details";
            // 
            // tbItemStatus
            // 
            this.tbItemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemStatus.BackColor = System.Drawing.SystemColors.Control;
            this.tbItemStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItemStatus.Location = new System.Drawing.Point(-1, 63);
            this.tbItemStatus.Name = "tbItemStatus";
            this.tbItemStatus.ReadOnly = true;
            this.tbItemStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbItemStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbItemStatus.ShowSelectionMargin = true;
            this.tbItemStatus.Size = new System.Drawing.Size(740, 338);
            this.tbItemStatus.TabIndex = 5;
            this.tbItemStatus.Text = "";
            // 
            // lbOrderItems
            // 
            this.lbOrderItems.AutoSize = true;
            this.lbOrderItems.Location = new System.Drawing.Point(8, 71);
            this.lbOrderItems.Name = "lbOrderItems";
            this.lbOrderItems.Size = new System.Drawing.Size(0, 20);
            this.lbOrderItems.TabIndex = 3;
            // 
            // lbCustomer
            // 
            this.lbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.ForeColor = System.Drawing.Color.White;
            this.lbCustomer.Location = new System.Drawing.Point(0, 23);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(165, 37);
            this.lbCustomer.TabIndex = 2;
            this.lbCustomer.Text = "Customer:";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(3, 426);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(208, 37);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Order Status:";
            // 
            // tbInitialOrder
            // 
            this.tbInitialOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitialOrder.BackColor = System.Drawing.SystemColors.Control;
            this.tbInitialOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInitialOrder.Location = new System.Drawing.Point(3, 469);
            this.tbInitialOrder.Name = "tbInitialOrder";
            this.tbInitialOrder.ReadOnly = true;
            this.tbInitialOrder.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbInitialOrder.Size = new System.Drawing.Size(740, 310);
            this.tbInitialOrder.TabIndex = 4;
            this.tbInitialOrder.Text = "";
            // 
            // pnlCustomerQueue
            // 
            this.pnlCustomerQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCustomerQueue.Controls.Add(this.lbCustomerList);
            this.pnlCustomerQueue.Controls.Add(this.lstCustomers);
            this.pnlCustomerQueue.Location = new System.Drawing.Point(14, 18);
            this.pnlCustomerQueue.Name = "pnlCustomerQueue";
            this.pnlCustomerQueue.Size = new System.Drawing.Size(296, 785);
            this.pnlCustomerQueue.TabIndex = 4;
            // 
            // lbCustomerList
            // 
            this.lbCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerList.AutoSize = true;
            this.lbCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerList.ForeColor = System.Drawing.Color.White;
            this.lbCustomerList.Location = new System.Drawing.Point(3, 3);
            this.lbCustomerList.Name = "lbCustomerList";
            this.lbCustomerList.Size = new System.Drawing.Size(224, 37);
            this.lbCustomerList.TabIndex = 6;
            this.lbCustomerList.Text = "Customer List:\r\n";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomers.BackColor = System.Drawing.SystemColors.Control;
            this.lstCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(0, 63);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(296, 720);
            this.lstCustomers.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.btnNewOrder);
            this.pnlMain.Controls.Add(this.pnlCustomerQueue);
            this.pnlMain.Controls.Add(this.pnlOrderDetail);
            this.pnlMain.Location = new System.Drawing.Point(18, 18);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 918);
            this.pnlMain.TabIndex = 7;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrders.AutoSize = true;
            this.pnlOrders.BackColor = System.Drawing.Color.Black;
            this.pnlOrders.Location = new System.Drawing.Point(1108, 26);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(1068, 978);
            this.pnlOrders.TabIndex = 5;
            // 
            // PSUBMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1115, 978);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlOrders);
            this.Name = "PSUBMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Behrend Donut Shoppe";
            this.pnlOrderDetail.ResumeLayout(false);
            this.pnlOrderDetail.PerformLayout();
            this.pnlCustomerQueue.ResumeLayout(false);
            this.pnlCustomerQueue.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.RichTextBox tbInitialOrder;
        private System.Windows.Forms.Label lbOrderItems;
        private System.Windows.Forms.Panel pnlCustomerQueue;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lbOrderDetail;
        private System.Windows.Forms.Label lbCustomerList;
        private System.Windows.Forms.RichTextBox tbItemStatus;
        private OrderPanel pnlOrders;
        public System.Windows.Forms.Panel pnlMain;
    }
}

