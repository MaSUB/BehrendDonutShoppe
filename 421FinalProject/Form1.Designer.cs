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
            this.pnlOrderDetail.SuspendLayout();
            this.pnlCustomerQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewOrder.BackColor = System.Drawing.Color.Black;
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.ForeColor = System.Drawing.Color.White;
            this.btnNewOrder.Location = new System.Drawing.Point(387, 456);
            this.btnNewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(155, 45);
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
            this.pnlOrderDetail.Location = new System.Drawing.Point(210, 10);
            this.pnlOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(331, 432);
            this.pnlOrderDetail.TabIndex = 3;
            // 
            // lbOrderDetail
            // 
            this.lbOrderDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbOrderDetail.AutoSize = true;
            this.lbOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderDetail.ForeColor = System.Drawing.Color.White;
            this.lbOrderDetail.Location = new System.Drawing.Point(101, 33);
            this.lbOrderDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderDetail.Name = "lbOrderDetail";
            this.lbOrderDetail.Size = new System.Drawing.Size(140, 26);
            this.lbOrderDetail.TabIndex = 6;
            this.lbOrderDetail.Text = "Order Details";
            // 
            // tbItemStatus
            // 
            this.tbItemStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemStatus.BackColor = System.Drawing.Color.Gray;
            this.tbItemStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItemStatus.Location = new System.Drawing.Point(-1, 91);
            this.tbItemStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbItemStatus.Name = "tbItemStatus";
            this.tbItemStatus.ReadOnly = true;
            this.tbItemStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbItemStatus.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbItemStatus.ShowSelectionMargin = true;
            this.tbItemStatus.Size = new System.Drawing.Size(333, 144);
            this.tbItemStatus.TabIndex = 5;
            this.tbItemStatus.Text = "";
            // 
            // lbOrderItems
            // 
            this.lbOrderItems.AutoSize = true;
            this.lbOrderItems.Location = new System.Drawing.Point(5, 46);
            this.lbOrderItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrderItems.Name = "lbOrderItems";
            this.lbOrderItems.Size = new System.Drawing.Size(0, 13);
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
            this.lbCustomer.Location = new System.Drawing.Point(9, 59);
            this.lbCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(113, 26);
            this.lbCustomer.TabIndex = 2;
            this.lbCustomer.Text = "Customer:";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(2, 237);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(141, 26);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Order Status:";
            // 
            // tbInitialOrder
            // 
            this.tbInitialOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitialOrder.BackColor = System.Drawing.Color.Gray;
            this.tbInitialOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInitialOrder.Location = new System.Drawing.Point(2, 265);
            this.tbInitialOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbInitialOrder.Name = "tbInitialOrder";
            this.tbInitialOrder.ReadOnly = true;
            this.tbInitialOrder.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbInitialOrder.Size = new System.Drawing.Size(330, 164);
            this.tbInitialOrder.TabIndex = 4;
            this.tbInitialOrder.Text = "";
            // 
            // pnlCustomerQueue
            // 
            this.pnlCustomerQueue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCustomerQueue.Controls.Add(this.lbCustomerList);
            this.pnlCustomerQueue.Controls.Add(this.lstCustomers);
            this.pnlCustomerQueue.Location = new System.Drawing.Point(8, 8);
            this.pnlCustomerQueue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCustomerQueue.Name = "pnlCustomerQueue";
            this.pnlCustomerQueue.Size = new System.Drawing.Size(197, 434);
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
            this.lbCustomerList.Location = new System.Drawing.Point(2, 2);
            this.lbCustomerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerList.Name = "lbCustomerList";
            this.lbCustomerList.Size = new System.Drawing.Size(153, 26);
            this.lbCustomerList.TabIndex = 6;
            this.lbCustomerList.Text = "Customer List:\r\n";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCustomers.BackColor = System.Drawing.Color.Gray;
            this.lstCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(0, 41);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(197, 403);
            this.lstCustomers.TabIndex = 0;
            // 
            // PSUBMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(549, 512);
            this.Controls.Add(this.pnlCustomerQueue);
            this.Controls.Add(this.pnlOrderDetail);
            this.Controls.Add(this.btnNewOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.RichTextBox tbInitialOrder;
        private System.Windows.Forms.Label lbOrderItems;
        private System.Windows.Forms.Panel pnlCustomerQueue;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lbOrderDetail;
        private System.Windows.Forms.Label lbCustomerList;
        private System.Windows.Forms.RichTextBox tbItemStatus;
    }
}

