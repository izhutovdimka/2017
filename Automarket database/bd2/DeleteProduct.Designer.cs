namespace bd2
{
    partial class DelProdForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb1_form3 = new System.Windows.Forms.TextBox();
            this.btnDelPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txb1_form3
            // 
            this.txb1_form3.Location = new System.Drawing.Point(100, 38);
            this.txb1_form3.Name = "txb1_form3";
            this.txb1_form3.Size = new System.Drawing.Size(100, 20);
            this.txb1_form3.TabIndex = 3;
            // 
            // btnDelPos
            // 
            this.btnDelPos.Location = new System.Drawing.Point(81, 102);
            this.btnDelPos.Name = "btnDelPos";
            this.btnDelPos.Size = new System.Drawing.Size(146, 23);
            this.btnDelPos.TabIndex = 4;
            this.btnDelPos.Text = "Удалитть позицию";
            this.btnDelPos.UseVisualStyleBackColor = true;
            this.btnDelPos.Click += new System.EventHandler(this.btnDelPos_Click);
            // 
            // DelProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 172);
            this.Controls.Add(this.btnDelPos);
            this.Controls.Add(this.txb1_form3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Name = "DelProdForm";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.DelProdForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb1_form3;
        private System.Windows.Forms.Button btnDelPos;
    }
}