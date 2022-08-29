using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
    public partial class Overtime : Form
    {
        public Overtime()
        {
            InitializeComponent();
        }

        private void Overtime_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil + 2; i >= (yil - 30); i--)
            {
                comboYil.Items.Add(i);
            }
            RaiseClass.ComboEmployee(comboName);
        }

        Label lbl;
        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            RaiseClass.ComboSecilirseEmp(comboName,lbl);
           // MessageBox.Show(lbl.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         void up()
        {

            string sql = "UPDATE Overtime SET payment_status = ''";
            SqlCommand cmd = new SqlCommand();
            VeriTabani.ADU(cmd, sql);

        }
        private void button1_Click(object sender, EventArgs e)
        {
//            TimeSpan girisCikisFarki = DateTime.Parse(dateEndTime.Text).Subtract(DateTime.Parse(dateStartTime.Text));
            
            UserModel user = new UserModel();
            EmployeeModel emp = new EmployeeModel();
            OvertimeModel over =new OvertimeModel();
            user.Id = UserModel.kid;
            emp.Emp_Id = int.Parse(lbl.Text);
            over.Start_date =dateStart.Text + " " + dateStartTime.Text;
            over.Period = comboAy.Text + "/" + comboYil.Text;
            over.End_date = dateEnd.Text + " " + dateEndTime.Text;
            over.Hourly_wage = decimal.Parse(textHourly.Text);
            over.Amount = decimal.Parse(textAmount.Text);
            over.Explanation = textExplanation.Text;
            over.Date=DateTime.Now;
            string sql = "insert into Overtime (per_Id,start_date,end_date,hourly_wage,amount,period,explanation,date)" +
                "values('" + emp.Emp_Id + "','" + over.Start_date + "','" + over.End_date + "',@hourly_wage,@amount,'"+over.Period+"','"+ over.Explanation + "',@date)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@hourly_wage", SqlDbType.Decimal).Value = over.Hourly_wage;
            cmd.Parameters.Add("@amount",SqlDbType.Decimal).Value = over.Amount;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = over.Date;

            VeriTabani.ADU(cmd,sql);
            up();
            MessageBox.Show("overtime add","overtime",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void textAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textHourly_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string start = dateStart.Text + " " + dateStartTime.Text;
                string end = dateEnd.Text + " " + dateEndTime.Text;
                TimeSpan time = DateTime.Parse(end) - DateTime.Parse(start);
                double Mhourly = double.Parse(textHourly.Text);
                double amount = time.TotalHours * Mhourly;
                textAmount.Text = amount.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                 VeriTabani.con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
