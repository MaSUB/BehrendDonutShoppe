namespace _421FinalProject
{
    partial class OrderPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOrderItems = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.btnDonuts = new System.Windows.Forms.Button();
            this.pnlDonut = new System.Windows.Forms.Panel();
            this.cbDonutFilter = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbDonuts = new System.Windows.Forms.Label();
            this.pnlCoffee = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlDonut.SuspendLayout();
            this.pnlCoffee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderItems
            // 
            this.txtOrderItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderItems.Location = new System.Drawing.Point(760, 57);
            this.txtOrderItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrderItems.Name = "txtOrderItems";
            this.txtOrderItems.Size = new System.Drawing.Size(304, 574);
            this.txtOrderItems.TabIndex = 0;
            this.txtOrderItems.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(755, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Items\r\n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCoffee);
            this.panel1.Controls.Add(this.btnDonuts);
            this.panel1.Controls.Add(this.pnlDonut);
            this.panel1.Controls.Add(this.pnlCoffee);
            this.panel1.Location = new System.Drawing.Point(20, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 875);
            this.panel1.TabIndex = 2;
            // 
            // btnCoffee
            // 
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffee.ForeColor = System.Drawing.Color.White;
            this.btnCoffee.Location = new System.Drawing.Point(381, 188);
            this.btnCoffee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(333, 140);
            this.btnCoffee.TabIndex = 12;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.UseVisualStyleBackColor = true;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnDonuts
            // 
            this.btnDonuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonuts.ForeColor = System.Drawing.Color.White;
            this.btnDonuts.Location = new System.Drawing.Point(381, 9);
            this.btnDonuts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDonuts.Name = "btnDonuts";
            this.btnDonuts.Size = new System.Drawing.Size(333, 141);
            this.btnDonuts.TabIndex = 11;
            this.btnDonuts.Text = "Donuts";
            this.btnDonuts.UseVisualStyleBackColor = true;
            this.btnDonuts.Click += new System.EventHandler(this.btnDonuts_Click);
            // 
            // pnlDonut
            // 
            this.pnlDonut.Controls.Add(this.cbDonutFilter);
            this.pnlDonut.Controls.Add(this.listBox1);
            this.pnlDonut.Controls.Add(this.lbDonuts);
            this.pnlDonut.Location = new System.Drawing.Point(0, 0);
            this.pnlDonut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDonut.Name = "pnlDonut";
            this.pnlDonut.Size = new System.Drawing.Size(373, 330);
            this.pnlDonut.TabIndex = 13;
            // 
            // cbDonutFilter
            // 
            this.cbDonutFilter.BackColor = System.Drawing.SystemColors.Control;
            this.cbDonutFilter.FormattingEnabled = true;
            this.cbDonutFilter.Location = new System.Drawing.Point(120, 7);
            this.cbDonutFilter.Name = "cbDonutFilter";
            this.cbDonutFilter.Size = new System.Drawing.Size(226, 28);
            this.cbDonutFilter.TabIndex = 8;
            this.cbDonutFilter.Text = "Donut Filter by Type";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Regular Donut",
            "Maple Donut",
            "Chocolate Donut",
            "Behrend Cream Donut"});
            this.listBox1.Location = new System.Drawing.Point(0, 43);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 284);
            this.listBox1.TabIndex = 2;
            // 
            // lbDonuts
            // 
            this.lbDonuts.AutoSize = true;
            this.lbDonuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonuts.ForeColor = System.Drawing.Color.White;
            this.lbDonuts.Location = new System.Drawing.Point(-2, 9);
            this.lbDonuts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDonuts.Name = "lbDonuts";
            this.lbDonuts.Size = new System.Drawing.Size(94, 29);
            this.lbDonuts.TabIndex = 6;
            this.lbDonuts.Text = "Donuts:";
            // 
            // pnlCoffee
            // 
            this.pnlCoffee.Controls.Add(this.button2);
            this.pnlCoffee.Controls.Add(this.button1);
            this.pnlCoffee.Controls.Add(this.listBox3);
            this.pnlCoffee.Controls.Add(this.listBox2);
            this.pnlCoffee.Controls.Add(this.label2);
            this.pnlCoffee.Controls.Add(this.label3);
            this.pnlCoffee.Location = new System.Drawing.Point(0, 334);
            this.pnlCoffee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCoffee.Name = "pnlCoffee";
            this.pnlCoffee.Size = new System.Drawing.Size(714, 536);
            this.pnlCoffee.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(521, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 89);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remove Condiment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(344, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 89);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Condiment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.Control;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(344, 98);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(370, 364);
            this.listBox3.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.Control;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(0, 98);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(346, 444);
            this.listBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-2, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coffee Style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(339, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Condiments:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(760, 727);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(304, 83);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(760, 644);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(304, 83);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(760, 809);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(304, 83);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish Order";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // OrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderItems);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderPanel";
            this.Size = new System.Drawing.Size(1080, 950);
            this.panel1.ResumeLayout(false);
            this.pnlDonut.ResumeLayout(false);
            this.pnlDonut.PerformLayout();
            this.pnlCoffee.ResumeLayout(false);
            this.pnlCoffee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOrderItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDonuts;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnDonuts;
        private System.Windows.Forms.Panel pnlDonut;
        private System.Windows.Forms.Panel pnlCoffee;
        private System.Windows.Forms.ComboBox cbDonutFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
