namespace İnsanKaynaklari
{
    partial class RaiseA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clean = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.textOvertimeId = new System.Windows.Forms.TextBox();
            this.textEmployeeId = new System.Windows.Forms.TextBox();
            this.textNameSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.AllPay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(172, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Clean.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Clean.Location = new System.Drawing.Point(15, 284);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(98, 49);
            this.Clean.TabIndex = 82;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightSalmon;
            this.Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(15, 213);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(98, 49);
            this.Delete.TabIndex = 80;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update.Location = new System.Drawing.Point(10, 146);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(103, 49);
            this.update.TabIndex = 79;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Pay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pay.Location = new System.Drawing.Point(12, 12);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(101, 49);
            this.Pay.TabIndex = 77;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.AllOvertime_Click);
            // 
            // textOvertimeId
            // 
            this.textOvertimeId.Location = new System.Drawing.Point(284, 257);
            this.textOvertimeId.Name = "textOvertimeId";
            this.textOvertimeId.Size = new System.Drawing.Size(173, 22);
            this.textOvertimeId.TabIndex = 76;
            // 
            // textEmployeeId
            // 
            this.textEmployeeId.Location = new System.Drawing.Point(284, 298);
            this.textEmployeeId.Name = "textEmployeeId";
            this.textEmployeeId.Size = new System.Drawing.Size(173, 22);
            this.textEmployeeId.TabIndex = 75;
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(600, 300);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Size = new System.Drawing.Size(173, 22);
            this.textNameSurname.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(200, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Raise Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Employee Id:";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(600, 257);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(169, 22);
            this.textAmount.TabIndex = 67;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb5.Location = new System.Drawing.Point(526, 257);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(68, 20);
            this.lb5.TabIndex = 59;
            this.lb5.Text = "Amount:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb1.Location = new System.Drawing.Point(475, 300);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(119, 20);
            this.lb1.TabIndex = 55;
            this.lb1.Text = "Name Surname:";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.OrangeRed;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(705, 354);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 48);
            this.exit.TabIndex = 83;
            this.exit.Text = "EXİT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AllPay
            // 
            this.AllPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AllPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AllPay.Location = new System.Drawing.Point(15, 76);
            this.AllPay.Name = "AllPay";
            this.AllPay.Size = new System.Drawing.Size(98, 49);
            this.AllPay.TabIndex = 84;
            this.AllPay.Text = "All Raise Pay";
            this.AllPay.UseVisualStyleBackColor = false;
            this.AllPay.Click += new System.EventHandler(this.OvertimePay_Click);
            // 
            // RaiseA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(805, 414);
            this.Controls.Add(this.AllPay);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.textOvertimeId);
            this.Controls.Add(this.textEmployeeId);
            this.Controls.Add(this.textNameSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RaiseA";
            this.Text = "RaiseA";
            this.Load += new System.EventHandler(this.RaiseA_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.TextBox textOvertimeId;
        private System.Windows.Forms.TextBox textEmployeeId;
        private System.Windows.Forms.TextBox textNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button AllPay;
    }
}