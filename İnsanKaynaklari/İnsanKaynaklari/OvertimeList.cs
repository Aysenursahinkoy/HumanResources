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
    //kontrol edildi.
    public partial class OvertimeList : Form
    {
        public OvertimeList()
        {
            InitializeComponent();
        }
          
        
        private void OvertimeList_Load(object sender, EventArgs e)
        {
            //overtime tablosunu listeler
            VeriTabani.Listele_Ara(dataGridView2, "select o.overtime_Id,o.user_Id,u.username,o.per_Id,e.name,e.surname,o.hourly_wage,o.amount,o.payment_status,o.start_date,o.end_date,o.period,o.explanation from Overtime o  left join Employee e on e.emp_Id = o.per_Id left join User_Log u on u.Id=o.user_Id ");
            int yil = int.Parse(DateTime.Now.Year.ToString());
            
            //aşagıdaki for combobox ı 30 yil geriye 2 yil ileriye sıralar.
            for (int i = yil + 2; i >= (yil - 30); i--)
            {
                comboYil.Items.Add(i);
            }
        }
        private void textEmployeeId_TextChanged(object sender, EventArgs e)
        {
            //text box name ve surname i yan yana bastrımak için
            BonusModel.EmployeeNameSurname(textEmployeeId, textNameSurname);
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //çift tıklandıgında kutuları doldurur.
            try
            {            
                
                    textOvertimeId.Text = dataGridView2.CurrentRow.Cells["overtime_Id"].Value.ToString();
                    textEmployeeId.Text = dataGridView2.CurrentRow.Cells["per_Id"].Value.ToString();
                    textHourly.Text = dataGridView2.CurrentRow.Cells["hourly_wage"].Value.ToString();
                    textExplanation.Text = dataGridView2.CurrentRow.Cells["explanation"].Value.ToString();
                    string start = dataGridView2.CurrentRow.Cells["start_date"].Value.ToString();
                    string end = dataGridView2.CurrentRow.Cells["end_date"].Value.ToString();
                    string period = dataGridView2.CurrentRow.Cells["period"].Value.ToString();
                    datestart.Text = start.Substring(0, 10);
                    dateStartTime.Text = start.Substring(11);
                    dateend.Text = end.Substring(0, 10);
                    dateEndTime.Text = end.Substring(11);
                    
                    int number = period.IndexOf("/");
                    comboAy.Text = period.Substring(0, number);
                    comboYil.Text = period.Substring(number + 1);
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

        private void textHourly_TextChanged(object sender, EventArgs e)
        {

            try
            {
                string start = datestart.Text + " " + dateStartTime.Text;
                string end = dateend.Text + " " + dateEndTime.Text;
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

        private void Clean_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }

            //datestart.Value = DateTime.Now;
            //dateend.Value = DateTime.Now;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllOvertime_Click(object sender, EventArgs e)
        {
            try
            {
                OvertimeModel over = new OvertimeModel();
                over.Payment_status = "Paid";

                string sql = "update overtime set payment_status='" + over.Payment_status + "' where payment_status = ''";

                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("All Overtime Pay", "Overtime Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean.PerformClick();
                VeriTabani.Listele_Ara(dataGridView2, "select o.overtime_Id,o.user_Id,u.username,o.per_Id,e.name,e.surname,o.hourly_wage,o.amount,o.payment_status,o.start_date,o.end_date,o.period,o.explanation from Overtime o  left join Employee e on e.emp_Id = o.per_Id left join User_Log u on u.Id=o.user_Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

        private void OvertimePay_Click(object sender, EventArgs e)
        {
            try
            {

                OvertimeModel over = new OvertimeModel();
                over.Payment_status = "Paid";
                over.Overtime_Id = int.Parse(textOvertimeId.Text);
                string sql = "update overtime set payment_status='" + over.Payment_status + "'where overtime_Id='" + over.Overtime_Id + "'";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show(over.Overtime_Id + " Overtime Pay", "Overtime Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean.PerformClick();
                VeriTabani.Listele_Ara(dataGridView2, "select o.overtime_Id,o.user_Id,u.username,o.per_Id,e.name,e.surname,o.hourly_wage,o.amount,o.payment_status,o.start_date,o.end_date,o.period,o.explanation from Overtime o  left join Employee e on e.emp_Id = o.per_Id left join User_Log u on u.Id=o.user_Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Delete this Rexord?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OvertimeModel over = new OvertimeModel();
                    over.Overtime_Id = int.Parse(textOvertimeId.Text);
                    string sql = "delete from overtime where overtime_Id='" + over.Overtime_Id + "'";
                    SqlCommand cmd = new SqlCommand();
                    VeriTabani.ADU(cmd, sql);
                    MessageBox.Show("Payment record " + over.Overtime_Id + " deleted", "Overtime Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clean.PerformClick();
                    VeriTabani.Listele_Ara(dataGridView2, "select o.overtime_Id,o.user_Id,u.username,o.per_Id,e.name,e.surname,o.hourly_wage,o.amount,o.payment_status,o.start_date,o.end_date,o.period,o.explanation from Overtime o  left join Employee e on e.emp_Id = o.per_Id left join User_Log u on u.Id=o.user_Id");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                OvertimeModel over = new OvertimeModel();
                EmployeeModel emp = new EmployeeModel();
                emp.Emp_Id = int.Parse(textEmployeeId.Text);
                over.Overtime_Id = int.Parse(textOvertimeId.Text);
                over.Start_date = datestart.Text + " " + dateStartTime.Text;
                over.Hourly_wage = decimal.Parse(textHourly.Text);
                over.Amount = decimal.Parse(textAmount.Text);
                over.Period = comboAy.Text + "/" + comboYil.Text;
                over.Explanation = textExplanation.Text;
                string sql = "update overtime set per_Id='" + emp.Emp_Id + "',start_date='" + over.Start_date + "',end_date='" + over.End_date + "'," +
                 "hourly_wage=@hourly_wage,amount=@amount,period='" + over.Period + "',explanation='" + over.Explanation + "' where overtime_Id='" + over.Overtime_Id + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add("@hourly_wage", SqlDbType.Decimal).Value = over.Hourly_wage;
                cmd.Parameters.Add("amount", SqlDbType.Decimal).Value = over.Amount;
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("Payment record " + over.Overtime_Id + " deleted", "Overtime Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clean.PerformClick();
                VeriTabani.Listele_Ara(dataGridView2, "select o.overtime_Id,o.user_Id,u.username,o.per_Id,e.name,e.surname,o.hourly_wage,o.amount,o.payment_status,o.start_date,o.end_date,o.period,o.explanation from Overtime o  left join Employee e on e.emp_Id = o.per_Id left join User_Log u on u.Id=o.user_Id");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }

        }

      
    }
}

