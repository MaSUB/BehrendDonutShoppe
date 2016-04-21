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
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.lbOrderItems = new System.Windows.Forms.Label();
            this.tbInitialOrder = new System.Windows.Forms.RichTextBox();
            this.tbItemStatus = new System.Windows.Forms.RichTextBox();
            this.pnlCustomerQueue = new System.Windows.Forms.Panel();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lbCustomerList = new System.Windows.Forms.Label();
            this.lbOrderDetail = new System.Windows.Forms.Label();
            this.pnlOrderDetail.SuspendLayout();
            this.pnlCustomerQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewOrder.Location = new System.Drawing.Point(265, 706);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(233, 69);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = " New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderDetail.Controls.Add(this.lbOrderDetail);
            this.pnlOrderDetail.Controls.Add(this.tbItemStatus);
            this.pnlOrderDetail.Controls.Add(this.lbOrderItems);
            this.pnlOrderDetail.Controls.Add(this.lbCustomer);
            this.pnlOrderDetail.Controls.Add(this.lbStatus);
            this.pnlOrderDetail.Controls.Add(this.tbInitialOrder);
            this.pnlOrderDetail.Location = new System.Drawing.Point(315, 15);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(496, 664);
            this.pnlOrderDetail.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(3, 362);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(208, 37);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Order Status:";
            // 
            // lbCustomer
            // 
            this.lbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(-2, 91);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(165, 37);
            this.lbCustomer.TabIndex = 2;
            this.lbCustomer.Text = "Customer:";
            // 
            // lbOrderItems
            // 
            this.lbOrderItems.AutoSize = true;
            this.lbOrderItems.Location = new System.Drawing.Point(8, 71);
            this.lbOrderItems.Name = "lbOrderItems";
            this.lbOrderItems.Size = new System.Drawing.Size(0, 20);
            this.lbOrderItems.TabIndex = 3;
            // 
            // tbInitialOrder
            // 
            this.tbInitialOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitialOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInitialOrder.Location = new System.Drawing.Point(3, 402);
            this.tbInitialOrder.Name = "tbInitialOrder";
            this.tbInitialOrder.Size = new System.Drawing.Size(496, 219);
            this.tbInitialOrder.TabIndex = 4;
            this.tbInitialOrder.Text = "";
            // 
            // tbItemStatus
            // 
            this.tbItemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItemStatus.Location = new System.Drawing.Point(-2, 140);
            this.tbItemStatus.Name = "tbItemStatus";
            this.tbItemStatus.Size = new System.Drawing.Size(496, 219);
            this.tbItemStatus.TabIndex = 5;
            this.tbItemStatus.Text = "";
            // 
            // pnlCustomerQueue
            // 
            this.pnlCustomerQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCustomerQueue.Controls.Add(this.lbCustomerList);
            this.pnlCustomerQueue.Controls.Add(this.lstCustomers);
            this.pnlCustomerQueue.Location = new System.Drawing.Point(12, 12);
            this.pnlCustomerQueue.Name = "pnlCustomerQueue";
            this.pnlCustomerQueue.Size = new System.Drawing.Size(296, 667);
            this.pnlCustomerQueue.TabIndex = 4;
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(0, 63);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(293, 604);
            this.lstCustomers.TabIndex = 0;
            // 
            // lbCustomerList
            // 
            this.lbCustomerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerList.AutoSize = true;
            this.lbCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerList.Location = new System.Drawing.Point(3, 3);
            this.lbCustomerList.Name = "lbCustomerList";
            this.lbCustomerList.Size = new System.Drawing.Size(224, 37);
            this.lbCustomerList.TabIndex = 6;
            this.lbCustomerList.Text = "Customer List:\r\n";
            // 
            // lbOrderDetail
            // 
            this.lbOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOrderDetail.AutoSize = true;
            this.lbOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderDetail.Location = new System.Drawing.Point(150, 0);
            this.lbOrderDetail.Name = "lbOrderDetail";
            this.lbOrderDetail.Size = new System.Drawing.Size(205, 37);
            this.lbOrderDetail.TabIndex = 6;
            this.lbOrderDetail.Text = "Order Details";
            // 
            // PSUBMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 787);
            this.Controls.Add(this.pnlCustomerQueue);
            this.Controls.Add(this.pnlOrderDetail);
            this.Controls.Add(this.btnNewOrder);
            this.Name = "PSUBMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Behrend Donut Shoppe";
            this.pnlOrderDetail.ResumeLayout(false);
            this.pnlOrderDetail.PerformLayout();
            this.pnlCustomerQueue.ResumeLayout(false);
            this.pnlCustomerQueue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.RichTextBox tbItemStatus;
        private System.Windows.Forms.RichTextBox tbInitialOrder;
        private System.Windows.Forms.Label lbOrderItems;
        private System.Windows.Forms.Panel pnlCustomerQueue;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lbOrderDetail;
        private System.Windows.Forms.Label lbCustomerList;
    }
}

