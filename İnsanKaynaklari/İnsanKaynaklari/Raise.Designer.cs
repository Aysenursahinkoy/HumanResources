namespace İnsanKaynaklari
{
    partial class Raise
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
            this.butEx = new System.Windows.Forms.Button();
            this.butCon = new System.Windows.Forms.Button();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtRaise = new System.Windows.Forms.TextBox();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.CombEmp = new System.Windows.Forms.ComboBox();
            this.combYil = new System.Windows.Forms.ComboBox();
            this.ComAy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.radioPerc = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butEx
            // 
            this.butEx.Location = new System.Drawing.Point(247, 336);
            this.butEx.Name = "butEx";
            this.butEx.Size = new System.Drawing.Size(109, 43);
            this.butEx.TabIndex = 29;
            this.butEx.Text = "Exit";
            this.butEx.UseVisualStyleBackColor = true;
            // 
            // butCon
            // 
            this.butCon.Location = new System.Drawing.Point(125, 336);
            this.butCon.Name = "butCon";
            this.butCon.Size = new System.Drawing.Size(109, 43);
            this.butCon.TabIndex = 28;
            this.butCon.Text = "Confirmation";
            this.butCon.UseVisualStyleBackColor = true;
            this.butCon.Click += new System.EventHandler(this.butCon_Click);
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(125, 245);
            this.txtExp.Multiline = true;
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(224, 60);
            this.txtExp.TabIndex = 27;
            // 
            // txtRaise
            // 
            this.txtRaise.Location = new System.Drawing.Point(125, 208);
            this.txtRaise.Name = "txtRaise";
            this.txtRaise.Size = new System.Drawing.Size(224, 22);
            this.txtRaise.TabIndex = 26;
            // 
            // txtPerc
            // 
            this.txtPerc.Location = new System.Drawing.Point(125, 164);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(224, 22);
            this.txtPerc.TabIndex = 25;
            // 
            // CombEmp
            // 
            this.CombEmp.FormattingEnabled = true;
            this.CombEmp.Items.AddRange(new object[] {
            "All Staff"});
            this.CombEmp.Location = new System.Drawing.Point(125, 122);
            this.CombEmp.Name = "CombEmp";
            this.CombEmp.Size = new System.Drawing.Size(224, 24);
            this.CombEmp.TabIndex = 24;
            this.CombEmp.SelectedIndexChanged += new System.EventHandler(this.CombEmp_SelectedIndexChanged);
            // 
            // combYil
            // 
            this.combYil.FormattingEnabled = true;
            this.combYil.Location = new System.Drawing.Point(247, 79);
            this.combYil.Name = "combYil";
            this.combYil.Size = new System.Drawing.Size(102, 24);
            this.combYil.TabIndex = 23;
            // 
            // ComAy
            // 
            this.ComAy.FormattingEnabled = true;
            this.ComAy.Items.AddRange(new object[] {
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
            this.ComAy.Location = new System.Drawing.Point(125, 79);
            this.ComAy.Name = "ComAy";
            this.ComAy.Size = new System.Drawing.Size(102, 24);
            this.ComAy.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Explanation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Raise Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Percent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Employee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Period:";
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Location = new System.Drawing.Point(259, 27);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(76, 20);
            this.radioPrice.TabIndex = 16;
            this.radioPrice.TabStop = true;
            this.radioPrice.Text = "by price";
            this.radioPrice.UseVisualStyleBackColor = true;
            this.radioPrice.CheckedChanged += new System.EventHandler(this.radioPrice_CheckedChanged);
            // 
            // radioPerc
            // 
            this.radioPerc.AutoSize = true;
            this.radioPerc.Location = new System.Drawing.Point(119, 27);
            this.radioPerc.Name = "radioPerc";
            this.radioPerc.Size = new System.Drawing.Size(115, 20);
            this.radioPerc.TabIndex = 15;
            this.radioPerc.TabStop = true;
            this.radioPerc.Text = "by percentage";
            this.radioPerc.UseVisualStyleBackColor = true;
            this.radioPerc.CheckedChanged += new System.EventHandler(this.radioPerc_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "/";
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(0, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(100, 23);
            this.lb.TabIndex = 0;
            // 
            // Raise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(396, 391);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butEx);
            this.Controls.Add(this.butCon);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtRaise);
            this.Controls.Add(this.txtPerc);
            this.Controls.Add(this.CombEmp);
            this.Controls.Add(this.combYil);
            this.Controls.Add(this.ComAy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioPrice);
            this.Controls.Add(this.radioPerc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raise";
            this.Load += new System.EventHandler(this.Raise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butEx;
        private System.Windows.Forms.Button butCon;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtRaise;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.ComboBox CombEmp;
        private System.Windows.Forms.ComboBox combYil;
        private System.Windows.Forms.ComboBox ComAy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.RadioButton radioPerc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb;
    }
}