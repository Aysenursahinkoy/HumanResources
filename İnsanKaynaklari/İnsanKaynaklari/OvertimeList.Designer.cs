namespace İnsanKaynaklari
{
    partial class OvertimeList
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
            this.label1 = new System.Windows.Forms.Label();
            this.textExplanation = new System.Windows.Forms.TextBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.textHourly = new System.Windows.Forms.TextBox();
            this.dateEndTime = new System.Windows.Forms.MaskedTextBox();
            this.dateStartTime = new System.Windows.Forms.MaskedTextBox();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNameSurname = new System.Windows.Forms.TextBox();
            this.textEmployeeId = new System.Windows.Forms.TextBox();
            this.textOvertimeId = new System.Windows.Forms.TextBox();
            this.AllOvertime = new System.Windows.Forms.Button();
            this.OvertimePay = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.datestart = new System.Windows.Forms.MaskedTextBox();
            this.dateend = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "/";
            // 
            // textExplanation
            // 
            this.textExplanation.Location = new System.Drawing.Point(763, 370);
            this.textExplanation.Multiline = true;
            this.textExplanation.Name = "textExplanation";
            this.textExplanation.Size = new System.Drawing.Size(225, 48);
            this.textExplanation.TabIndex = 40;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(552, 372);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(84, 24);
            this.comboYil.TabIndex = 39;
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(429, 372);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(97, 24);
            this.comboAy.TabIndex = 38;
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(763, 291);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(225, 22);
            this.textAmount.TabIndex = 37;
            // 
            // textHourly
            // 
            this.textHourly.Location = new System.Drawing.Point(763, 332);
            this.textHourly.Name = "textHourly";
            this.textHourly.Size = new System.Drawing.Size(227, 22);
            this.textHourly.TabIndex = 36;
            this.textHourly.TextChanged += new System.EventHandler(this.textHourly_TextChanged);
            // 
            // dateEndTime
            // 
            this.dateEndTime.Location = new System.Drawing.Point(552, 330);
            this.dateEndTime.Mask = "00:00";
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(85, 22);
            this.dateEndTime.TabIndex = 35;
            this.dateEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // dateStartTime
            // 
            this.dateStartTime.Location = new System.Drawing.Point(552, 286);
            this.dateStartTime.Mask = "00:00";
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(85, 22);
            this.dateStartTime.TabIndex = 34;
            this.dateStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb7.Location = new System.Drawing.Point(663, 370);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(94, 20);
            this.lb7.TabIndex = 30;
            this.lb7.Text = "Explanation:";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb6.Location = new System.Drawing.Point(355, 370);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(57, 20);
            this.lb6.TabIndex = 29;
            this.lb6.Text = "Period:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb5.Location = new System.Drawing.Point(689, 291);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(68, 20);
            this.lb5.TabIndex = 28;
            this.lb5.Text = "Amount:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb4.Location = new System.Drawing.Point(655, 332);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(102, 20);
            this.lb4.TabIndex = 27;
            this.lb4.Text = "Hourly Wage:";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb3.Location = new System.Drawing.Point(337, 326);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(75, 20);
            this.lb3.TabIndex = 26;
            this.lb3.Text = "End Date:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb2.Location = new System.Drawing.Point(331, 284);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(81, 20);
            this.lb2.TabIndex = 25;
            this.lb2.Text = "Start Date:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb1.Location = new System.Drawing.Point(27, 372);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(119, 20);
            this.lb1.TabIndex = 24;
            this.lb1.Text = "Name Surname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(35, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 232);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(929, 211);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Employee Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Overtime Id:";
            // 
            // textNameSurname
            // 
            this.textNameSurname.Location = new System.Drawing.Point(152, 368);
            this.textNameSurname.Name = "textNameSurname";
            this.textNameSurname.Size = new System.Drawing.Size(173, 22);
            this.textNameSurname.TabIndex = 46;
            // 
            // textEmployeeId
            // 
            this.textEmployeeId.Location = new System.Drawing.Point(152, 330);
            this.textEmployeeId.Name = "textEmployeeId";
            this.textEmployeeId.Size = new System.Drawing.Size(173, 22);
            this.textEmployeeId.TabIndex = 47;
            this.textEmployeeId.TextChanged += new System.EventHandler(this.textEmployeeId_TextChanged);
            // 
            // textOvertimeId
            // 
            this.textOvertimeId.Location = new System.Drawing.Point(152, 289);
            this.textOvertimeId.Name = "textOvertimeId";
            this.textOvertimeId.Size = new System.Drawing.Size(173, 22);
            this.textOvertimeId.TabIndex = 48;
            // 
            // AllOvertime
            // 
            this.AllOvertime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AllOvertime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AllOvertime.Location = new System.Drawing.Point(120, 442);
            this.AllOvertime.Name = "AllOvertime";
            this.AllOvertime.Size = new System.Drawing.Size(115, 66);
            this.AllOvertime.TabIndex = 49;
            this.AllOvertime.Text = "All Overtime Pay";
            this.AllOvertime.UseVisualStyleBackColor = false;
            this.AllOvertime.Click += new System.EventHandler(this.AllOvertime_Click);
            // 
            // OvertimePay
            // 
            this.OvertimePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OvertimePay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OvertimePay.Location = new System.Drawing.Point(277, 442);
            this.OvertimePay.Name = "OvertimePay";
            this.OvertimePay.Size = new System.Drawing.Size(100, 66);
            this.OvertimePay.TabIndex = 50;
            this.OvertimePay.Text = "Overtime Pay";
            this.OvertimePay.UseVisualStyleBackColor = false;
            this.OvertimePay.Click += new System.EventHandler(this.OvertimePay_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.update.Location = new System.Drawing.Point(424, 442);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(112, 66);
            this.update.TabIndex = 51;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.LightSalmon;
            this.Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(590, 442);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(107, 66);
            this.Delete.TabIndex = 52;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clean
            // 
            this.Clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Clean.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Clean.Location = new System.Drawing.Point(763, 442);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(107, 66);
            this.Clean.TabIndex = 54;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = false;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.OrangeRed;
            this.exit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(947, 492);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(88, 48);
            this.exit.TabIndex = 55;
            this.exit.Text = "EXİT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // datestart
            // 
            this.datestart.Location = new System.Drawing.Point(431, 284);
            this.datestart.Mask = "00/00/0000";
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(100, 22);
            this.datestart.TabIndex = 56;
            this.datestart.ValidatingType = typeof(System.DateTime);
            // 
            // dateend
            // 
            this.dateend.Location = new System.Drawing.Point(429, 330);
            this.dateend.Mask = "00/00/0000";
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(100, 22);
            this.dateend.TabIndex = 57;
            this.dateend.ValidatingType = typeof(System.DateTime);
            // 
            // OvertimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1047, 554);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.OvertimePay);
            this.Controls.Add(this.AllOvertime);
            this.Controls.Add(this.textOvertimeId);
            this.Controls.Add(this.textEmployeeId);
            this.Controls.Add(this.textNameSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textExplanation);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.textHourly);
            this.Controls.Add(this.dateEndTime);
            this.Controls.Add(this.dateStartTime);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OvertimeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.OvertimeList_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textExplanation;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.TextBox textHourly;
        private System.Windows.Forms.MaskedTextBox dateEndTime;
        private System.Windows.Forms.MaskedTextBox dateStartTime;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNameSurname;
        private System.Windows.Forms.TextBox textEmployeeId;
        private System.Windows.Forms.TextBox textOvertimeId;
        private System.Windows.Forms.Button AllOvertime;
        private System.Windows.Forms.Button OvertimePay;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.MaskedTextBox datestart;
        private System.Windows.Forms.MaskedTextBox dateend;
    }
}