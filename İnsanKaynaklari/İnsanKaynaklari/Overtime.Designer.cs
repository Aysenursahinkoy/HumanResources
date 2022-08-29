namespace İnsanKaynaklari
{
    partial class Overtime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overtime));
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.textHourly = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.textExplanation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStartTime = new System.Windows.Forms.MaskedTextBox();
            this.dateEndTime = new System.Windows.Forms.MaskedTextBox();
            this.dateEnd = new System.Windows.Forms.MaskedTextBox();
            this.dateStart = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Location = new System.Drawing.Point(0, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(100, 23);
            this.lb1.TabIndex = 34;
            // 
            // lb2
            // 
            this.lb2.Location = new System.Drawing.Point(0, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(100, 23);
            this.lb2.TabIndex = 33;
            // 
            // lb3
            // 
            this.lb3.Location = new System.Drawing.Point(0, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(100, 23);
            this.lb3.TabIndex = 32;
            // 
            // lb4
            // 
            this.lb4.Location = new System.Drawing.Point(0, 0);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(100, 23);
            this.lb4.TabIndex = 31;
            // 
            // lb5
            // 
            this.lb5.Location = new System.Drawing.Point(0, 0);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(100, 23);
            this.lb5.TabIndex = 30;
            // 
            // lb6
            // 
            this.lb6.Location = new System.Drawing.Point(0, 0);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(100, 23);
            this.lb6.TabIndex = 29;
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(161, 65);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(299, 24);
            this.comboName.TabIndex = 11;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            // 
            // textHourly
            // 
            this.textHourly.Location = new System.Drawing.Point(165, 178);
            this.textHourly.Name = "textHourly";
            this.textHourly.Size = new System.Drawing.Size(299, 22);
            this.textHourly.TabIndex = 16;
            this.textHourly.TextChanged += new System.EventHandler(this.textHourly_TextChanged);
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
            this.comboAy.Location = new System.Drawing.Point(165, 256);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(131, 24);
            this.comboAy.TabIndex = 18;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(331, 256);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(129, 24);
            this.comboYil.TabIndex = 19;
            // 
            // textExplanation
            // 
            this.textExplanation.Location = new System.Drawing.Point(165, 294);
            this.textExplanation.Multiline = true;
            this.textExplanation.Name = "textExplanation";
            this.textExplanation.Size = new System.Drawing.Size(299, 80);
            this.textExplanation.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(192, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 63);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(335, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 63);
            this.button2.TabIndex = 22;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(63, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Start date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "End date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Hourly Wage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Amount:";
            // 
            // textAmount
            // 
            this.textAmount.Location = new System.Drawing.Point(165, 211);
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(299, 22);
            this.textAmount.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Period:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(50, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "Explanation:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name Surname:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateStartTime
            // 
            this.dateStartTime.Location = new System.Drawing.Point(320, 104);
            this.dateStartTime.Mask = "00:00";
            this.dateStartTime.Name = "dateStartTime";
            this.dateStartTime.Size = new System.Drawing.Size(72, 22);
            this.dateStartTime.TabIndex = 44;
            this.dateStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // dateEndTime
            // 
            this.dateEndTime.Location = new System.Drawing.Point(320, 144);
            this.dateEndTime.Mask = "00:00";
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.Size = new System.Drawing.Size(72, 22);
            this.dateEndTime.TabIndex = 45;
            this.dateEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(163, 150);
            this.dateEnd.Mask = "00/00/0000";
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(133, 22);
            this.dateEnd.TabIndex = 59;
            this.dateEnd.ValidatingType = typeof(System.DateTime);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(165, 104);
            this.dateStart.Mask = "00/00/0000";
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(133, 22);
            this.dateStart.TabIndex = 58;
            this.dateStart.ValidatingType = typeof(System.DateTime);
            // 
            // Overtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(529, 525);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.dateEndTime);
            this.Controls.Add(this.dateStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textExplanation);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.textHourly);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overtime";
            this.Load += new System.EventHandler(this.Overtime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.TextBox textHourly;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox textExplanation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox dateStartTime;
        private System.Windows.Forms.MaskedTextBox dateEndTime;
        private System.Windows.Forms.MaskedTextBox dateEnd;
        private System.Windows.Forms.MaskedTextBox dateStart;
    }
}