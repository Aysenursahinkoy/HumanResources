using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
//komtol edildi.
namespace İnsanKaynaklari
{

    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }



        private void Addbox_Click(object sender, EventArgs e)
        {
            try { 
            VeriTabani.con.Open();
            SqlCommand tekrar = new SqlCommand("select count(*) from employee where phone_number='" + txtmasktel.Text + "'", VeriTabani.con);
            int sonuc = (int)tekrar.ExecuteScalar();
            if (sonuc == 0)
            {
                VeriTabani.con.Close();
                EmployeeModel emp = new EmployeeModel();
                emp.Name = txtname.Text;
                emp.Surname = txtSurname.Text;
                emp.Phone_number = txtmasktel.Text;
                emp.Email = txtEmail.Text;
                emp.Dep_Id = (int)comboBox1.SelectedValue;
                emp.Salary = decimal.Parse(mskSalary.Text);
                emp.Start_date = DateTime.Now;
                string sql = "insert into Employee(name,surname,phone_number,Adress,email,dep_Id,is_active,salary,start_date) values" +
                    " ('" + emp.Name + "','" + emp.Surname + "','" + emp.Phone_number + "',@Adress,'" + emp.Email + "','" + emp.Dep_Id + "',@is_active,@salary,@start_date)";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@is_active", label6.Text);
                cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = emp.Salary;
                cmd.Parameters.Add("@start_date", SqlDbType.Date).Value = emp.Start_date;
                cmd.Parameters.AddWithValue("@Adress", txtAdres.Text);

                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("Add successful", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VeriTabani.Listele_Ara(dataGridView1, "select e.emp_Id,e.name,e.surname,e.phone_number,e.Adress,e.email,d.department,e.is_active,e.salary,e.start_date from employee e left join Department d on d.dep_Id = e.dep_Id");
                    VeriTabani.con.Close();

            }
            else if (sonuc > 0)
            {
                MessageBox.Show("There is this record", "Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VeriTabani.con.Close();

            }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

        private void Listbox_Click(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select e.emp_Id,e.name,e.surname,e.phone_number,e.Adress,e.email,d.department,e.is_active,e.salary,e.start_date from employee e left join Department d on d.dep_Id = e.dep_Id");

        }
        private void CleanBox_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtSurname.Text = "";
            txtemp_Id.Text = "";
            txtmasktel.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            mskSalary.Text = "";
            dtpstart.Text = "";
        }
        private void UpdateBox_Click(object sender, EventArgs e)
        {
            try
            {
         
            EmployeeModel emp = new EmployeeModel();
            emp.Emp_Id = int.Parse(txtemp_Id.Text);
            emp.Name = txtname.Text;
            emp.Surname = txtSurname.Text;
            emp.Phone_number = txtmasktel.Text;
            emp.Adress = txtAdres.Text;
            emp.Email = txtEmail.Text;
            emp.Is_active = label6.Text;
            emp.Dep_Id = (int)comboBox1.SelectedValue;
            emp.Salary = decimal.Parse(mskSalary.Text);
            emp.Start_date = DateTime.Now;
            string sql = "update employee set name='" + emp.Name + "',surname='" + emp.Surname + "',phone_number='" + emp.Phone_number + "',adress='" + emp.Adress + "', email='" + emp.Email + "',dep_Id='" + emp.Dep_Id + "',is_active='" + emp.Is_active + "',salary=@salary,start_date=@start_date  " +
                "where emp_Id='" + emp.Emp_Id + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = emp.Salary;
            cmd.Parameters.Add("@start_date", SqlDbType.Date).Value = emp.Start_date;


            VeriTabani.ADU(cmd, sql);
                VeriTabani.Listele_Ara(dataGridView1, "select e.emp_Id,e.name,e.surname,e.phone_number,e.Adress,e.email,d.department,e.is_active,e.salary,e.start_date from employee e left join Department d on d.dep_Id = e.dep_Id");
                MessageBox.Show("update successful", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtname.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtmasktel.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            txtemp_Id.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            label6.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            mskSalary.Text = dataGridView1.Rows[sec].Cells[8].Value.ToString();
            dtpstart.Text = dataGridView1.Rows[sec].Cells[9].Value.ToString();
        }

        private void DeleteBox_Click(object sender, EventArgs e)
        {
            try
            {          
            
            EmployeeModel emp = new EmployeeModel();
            emp.Emp_Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string sql = "delete from employee where emp_Id='" + emp.Emp_Id + "'";
            SqlCommand cmd = new SqlCommand();
            VeriTabani.ADU(cmd, sql);
                VeriTabani.Listele_Ara(dataGridView1, "select e.emp_Id,e.name,e.surname,e.phone_number,e.Adress,e.email,d.department,e.is_active,e.salary,e.start_date from employee e left join Department d on d.dep_Id = e.dep_Id");
                MessageBox.Show("delete successful", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label6.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label6.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label6.Text = "false";
            }
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
            EmployeeModel.ComboGetir(comboBox1);
            // TODO: This line of code loads data into the 'humanResourcesMnagementDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.humanResourcesMnagementDataSet.Employee);
            label6.Visible = false;
            VeriTabani.Listele_Ara(dataGridView1, "select e.emp_Id,e.name,e.surname,e.phone_number,e.Adress,e.email,d.department,e.is_active,e.salary,e.start_date from employee e left join Department d on d.dep_Id = e.dep_Id");
           
        }
    }
}

