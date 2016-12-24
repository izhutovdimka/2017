namespace bd2
{
    partial class InsertOrders
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCname = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbDateOrd = new System.Windows.Forms.TextBox();
            this.txbIdProd = new System.Windows.Forms.TextBox();
            this.txbAmt = new System.Windows.Forms.TextBox();
            this.txbCost = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя заказчика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id продукта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Стоимость";
            // 
            // txbCname
            // 
            this.txbCname.Location = new System.Drawing.Point(149, 48);
            this.txbCname.Name = "txbCname";
            this.txbCname.Size = new System.Drawing.Size(100, 20);
            this.txbCname.TabIndex = 9;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(149, 82);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(100, 20);
            this.txbPhone.TabIndex = 10;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(149, 127);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 20);
            this.txbAddress.TabIndex = 11;
            // 
            // txbDateOrd
            // 
            this.txbDateOrd.Location = new System.Drawing.Point(149, 164);
            this.txbDateOrd.Name = "txbDateOrd";
            this.txbDateOrd.Size = new System.Drawing.Size(100, 20);
            this.txbDateOrd.TabIndex = 12;
            // 
            // txbIdProd
            // 
            this.txbIdProd.Location = new System.Drawing.Point(149, 200);
            this.txbIdProd.Name = "txbIdProd";
            this.txbIdProd.Size = new System.Drawing.Size(100, 20);
            this.txbIdProd.TabIndex = 13;
            // 
            // txbAmt
            // 
            this.txbAmt.Location = new System.Drawing.Point(149, 242);
            this.txbAmt.Name = "txbAmt";
            this.txbAmt.Size = new System.Drawing.Size(100, 20);
            this.txbAmt.TabIndex = 14;
            // 
            // txbCost
            // 
            this.txbCost.Location = new System.Drawing.Point(149, 278);
            this.txbCost.Name = "txbCost";
            this.txbCost.Size = new System.Drawing.Size(100, 20);
            this.txbCost.TabIndex = 15;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(149, 330);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // InsertOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 382);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txbCost);
            this.Controls.Add(this.txbAmt);
            this.Controls.Add(this.txbIdProd);
            this.Controls.Add(this.txbDateOrd);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbCname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "InsertOrders";
            this.Text = "InsertOrders";
            this.Load += new System.EventHandler(this.InsertOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCname;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbDateOrd;
        private System.Windows.Forms.TextBox txbIdProd;
        private System.Windows.Forms.TextBox txbAmt;
        private System.Windows.Forms.TextBox txbCost;
        private System.Windows.Forms.Button btnInsert;
    }
}