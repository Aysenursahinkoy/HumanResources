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
    public partial class RaiseA : Form
    {
        public RaiseA()
        {
            InitializeComponent();

        }

        private void textExplanation_TextChanged(object sender, EventArgs e)
        {

        }

        private void RaiseA_Load(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select r.raise_Id,r.user_Id,u.username,e.emp_Id,e.name,e.surname,r.payment_status,r.amount,r.payment_status,r.date  from Raise r left join User_Log u on u.Id = r.user_Id left join Employee e on e.emp_Id = r.per_Id");
        }

        private void AllOvertime_Click(object sender, EventArgs e)
        {
            try
            {
                RaiseModel r = new RaiseModel();
                r.Payment_status = "Paid";
                r.Raise_Id = int.Parse(textOvertimeId.Text);
                string sql = "update overtime set paymentstatus='" + r.Payment_status + "'where raise_Id='" + r.Raise_Id + "'";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show(r.Raise_Id + " Raise Pay", " Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean.PerformClick();

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

                RaiseModel r = new RaiseModel();
                r.Payment_status = "Paid";

                string sql = "update Raise set paymentstatus='" + r.Payment_status + "' where paymentstatus = '" + r.Raise_Id + "'";

                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("All Raise Pay", " Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean.PerformClick();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                RaiseModel r = new RaiseModel();
                EmployeeModel emp = new EmployeeModel();
                emp.Emp_Id = int.Parse(textEmployeeId.Text);
                r.Raise_Id = int.Parse(textOvertimeId.Text);
                r.Amount = decimal.Parse(textAmount.Text);
                string sql = "update Raise set per_Id='" + emp.Emp_Id + "'," + "amount=@amount where Raise_Id='" + r.Raise_Id + "'";
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add("amount", SqlDbType.Decimal).Value = r.Amount;
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("Payment record " + r.Raise_Id + " Raise deleted", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clean.PerformClick();

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
                    RaiseModel r = new RaiseModel();
                    r.Raise_Id = int.Parse(textOvertimeId.Text);
                    string sql = "delete from raise where raise_Id='" + r.Raise_Id + "'";
                    SqlCommand cmd = new SqlCommand();
                    VeriTabani.ADU(cmd, sql);
                    MessageBox.Show("Payment record " + r.Raise_Id + " deleted", "Raise Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clean.PerformClick();

                }
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
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textOvertimeId.Text = dataGridView1.CurrentRow.Cells["raise_Id"].Value.ToString();
                textEmployeeId.Text = dataGridView1.CurrentRow.Cells["per_Id"].Value.ToString();              
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }
    }
}
