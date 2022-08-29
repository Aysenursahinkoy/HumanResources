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

//kontol edildi user eklendi.

namespace İnsanKaynaklari
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }
        private void Show_Load(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView2, "select b.bonus_Id,u.Id,u.username,b.emp_Id,e.name,e.surname,e.salary,b.period,b.bonus_amount,b.payment_status,b.explanation from bonus b left join Employee e on e.emp_Id = b.emp_Id left join User_Log u on u.Id=b.user_Id");

            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil + 2; i >= (yil - 30); i--)
            {
                comboYil.Items.Add(i);
            }
        }
  
        private void textEmployeeId_TextChanged(object sender, EventArgs e)
        {
            BonusModel.EmployeeNameSurname(textEmployeeId, textNameBonus);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            BonusModel bn = new BonusModel();
            bn.Period = comboAy.Text + "/" + comboYil.Text;
            bn.Bonus_Id = int.Parse(textBonusId.Text);
            string sql = "update bonus set period= '" + bn.Period + "'where Bonus_Id='" + bn.Bonus_Id + "'";
            SqlCommand cmd = new SqlCommand();
            VeriTabani.ADU(cmd, sql);
            VeriTabani.Listele_Ara(dataGridView2, "select bonus_Id,u.Id,e.emp_Id,u.username,e.name,e.surname,bonus_amount,payment_status,explanation,period,date from Bonus b,User_Log u,Employee e");
            MessageBox.Show("Change period for bonus", "period change", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBonus_Click(object sender, EventArgs e)
        {
            try
            {
                BonusModel bn = new BonusModel();
                bn.Payment_status = "paid";
                bn.Bonus_Id = int.Parse(textBonusId.Text);
                string sql = "update bonus set payment_status= '" + bn.Payment_status + "'where bonus_Id='" + bn.Bonus_Id + "'";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                VeriTabani.Listele_Ara(dataGridView2, "select b.bonus_Id,u.Id,u.username,b.emp_Id,e.name,e.surname,e.salary,b.period,b.bonus_amount,b.payment_status,b.explanation from bonus b left join Employee e on e.emp_Id = b.emp_Id left join User_Log u on u.Id=b.user_Id");
                MessageBox.Show("Bonus paid", "period change", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
    
        }

        private void btnAllBonus_Click(object sender, EventArgs e)
        {
            try
            {
                BonusModel bn = new BonusModel();
                bn.Payment_status = "paid";
               
                string sql = "update bonus set payment_status= '" + bn.Payment_status + "'where  payment_status=''";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                VeriTabani.Listele_Ara(dataGridView2, "select b.bonus_Id,u.Id,u.username,b.emp_Id,e.name,e.surname,e.salary,b.period,b.bonus_amount,b.payment_status,b.explanation from bonus b left join Employee e on e.emp_Id = b.emp_Id left join User_Log u on u.Id=b.user_Id");

                MessageBox.Show("All bonus paid", "period change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
           
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBonusId.Text = dataGridView2.CurrentRow.Cells["bonus_Id"].Value.ToString();
                textEmployeeId.Text = dataGridView2.CurrentRow.Cells["emp_Id"].Value.ToString();
                textNameBonus.Text = dataGridView2.CurrentRow.Cells["name"].Value.ToString();
                textBox1.Text = dataGridView2.CurrentRow.Cells["surname"].Value.ToString();
                textExplanation.Text = dataGridView2.CurrentRow.Cells["explanation"].Value.ToString();
                string period = dataGridView2.CurrentRow.Cells["period"].Value.ToString();
                textBonus.Text = dataGridView2.CurrentRow.Cells["bonus_amount"].Value.ToString();

                comboAy.Text = period.Substring(0, 1);
                comboYil.Text = period.Substring(1, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }

        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            EmployeeModel emp = new EmployeeModel();            
            BonusModel b = new BonusModel();
            b.Bonus_Id = int.Parse(textBonusId.Text);
            b.Emp_Id = int.Parse(textEmployeeId.Text);
            emp.Name = textNameBonus.Text;
            emp.Surname = textBox1.Text;
            b.Period = comboAy.Text + "/" + comboYil.Text;
            b.Bonus_amount = decimal.Parse(textBonus.Text);        
            b.Explanation = textExplanation.Text;
                
            string sql = "update Bonus set emp_Id='" + b.Emp_Id + "',period='"+b.Period+"',bonus_amount='"+b.Bonus_amount+"',explanation='"+b.Explanation+"' where bonus_Id='"+b.Bonus_Id+"'";

            SqlCommand cmd = new SqlCommand();
           

          
                VeriTabani.ADU(cmd, sql);
                
                MessageBox.Show("record update", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabani.Listele_Ara(dataGridView2, "select b.bonus_Id,u.Id,u.username,b.emp_Id,e.name,e.surname,e.salary,b.period,b.bonus_amount,b.payment_status,b.explanation from bonus b left join Employee e on e.emp_Id = b.emp_Id left join User_Log u on u.Id=b.user_Id");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {

            BonusModel b = new BonusModel();
            b.Bonus_Id = int.Parse(textBonusId.Text);
            string sql = "delete from Bonus where Bonus_Id='" + b.Bonus_Id + "'";
            SqlCommand cmd = new SqlCommand();
            try
            {
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("record deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabani.Listele_Ara(dataGridView2, "select b.bonus_Id,u.Id,u.username,b.emp_Id,e.name,e.surname,e.salary,b.period,b.bonus_amount,b.payment_status,b.explanation from bonus b left join Employee e on e.emp_Id = b.emp_Id left join User_Log u on u.Id=b.user_Id");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);

            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
