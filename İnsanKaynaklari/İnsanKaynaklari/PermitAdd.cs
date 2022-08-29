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
//kontol idildi.
namespace İnsanKaynaklari
{
    public partial class PermitAdd : Form
    {
        public PermitAdd()
        {
            InitializeComponent();

        }
        PermitAdModel model = new PermitAdModel();

        private void PermitAdd_Load(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select pt.permitTypeId,pt.user_Id,u.username, e.emp_Id, e.name, e.surname,p.PermitType, pt.start_date, pt.end_date, pt.explanation from PemitType pt left join Permit p on p.permit_ıd = pt.permit_Id left join Employee e on e.emp_Id = pt.emp_Id left join User_Log u on u.Id = pt.user_Id ");

            PermitAdModel.ComboPermit(comboPermit);
            PermitAdModel.ComboEmployee(comboName);
        }


        public static int GunHesapla(TextBox dateEnd, TextBox dateStart)
        {

            TimeSpan fark = Convert.ToDateTime(dateEnd.Text) - Convert.ToDateTime((dateStart.Text));

            int fark1 = Convert.ToInt32(fark.TotalDays);

            if ((fark1 * (-1)) == fark1) fark1 -= 1;

            else fark1 += 1;
            int sonuc2 = fark1;

            int sonuc = fark1;

            return sonuc;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Permit pr = new Permit();
            pr.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            PermitAdModel p = new PermitAdModel();
            PermitModel pm = new PermitModel();



            p.Id1 = int.Parse(dataGridView1.CurrentRow.Cells["permitTypeId"].Value.ToString());
            p.User_Id = UserModel.kid;
            p.Emp_Id = (int)comboName.SelectedValue;
            p.Permit_Id = (int)comboPermit.SelectedValue;
            p.Start_date = dateStart.Text;
            p.End_date = dateEnd.Text;
            p.Explanation = textExplanation.Text;
            p.Process = p.Id1 + " . update";
            string sql = "update PemitType set emp_Id= '" + p.Emp_Id + "',permit_Id='" + p.Permit_Id + "',start_date=@start_date,end_date=@end_date,process='" + p.Process + "',explanation='" + p.Explanation + "' where permitTypeId='" + p.Id1 + "'";

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add("@start_date", SqlDbType.Date).Value = p.Start_date;
            cmd.Parameters.Add("@end_date", SqlDbType.Date).Value = p.End_date;
            try
            {


                VeriTabani.ADU(cmd, sql);
                Clean();
                MessageBox.Show("record update ", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabani.Listele_Ara(dataGridView1, "select pt.permitTypeId,pt.user_Id,u.username, e.emp_Id, e.name, e.surname,p.PermitType, pt.start_date, pt.end_date, pt.explanation from PemitType pt left join Permit p on p.permit_ıd = pt.permit_Id left join Employee e on e.emp_Id = pt.emp_Id left join User_Log u on u.Id = pt.user_Id ");


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

        public void Clean()
        {
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            // doldur();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {

                    item.Text = "";
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Delete this Rexord?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PermitAdModel p = new PermitAdModel();
                    p.Id1 = int.Parse(dataGridView1.CurrentRow.Cells["permitTypeId"].Value.ToString());
                    string sql = "delete from pemitType where permitTypeId='" + p.Id1 + "'";
                    SqlCommand cmd = new SqlCommand();
                    VeriTabani.ADU(cmd, sql);
                    Clean();
                    MessageBox.Show("record delete", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    VeriTabani.Listele_Ara(dataGridView1, "select pt.permitTypeId,pt.user_Id,u.username, e.emp_Id, e.name, e.surname,p.PermitType, pt.start_date, pt.end_date, pt.explanation from PemitType pt left join Permit p on p.permit_ıd = pt.permit_Id left join Employee e on e.emp_Id = pt.emp_Id left join User_Log u on u.Id = pt.user_Id ");
                    VeriTabani.con.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeModel emp = new EmployeeModel();
            TimeSpan f = Convert.ToDateTime(DateTime.Now) - Convert.ToDateTime((emp.Start_date));
            int f1 = Convert.ToInt32(f.TotalDays);

            if ((f1 * (-1)) == f1) f1 -= 1;

            else f1 += 1;

            int sonuc2 = f1 / 30 / 12;

            TimeSpan fark = Convert.ToDateTime(dateEnd.Text) - Convert.ToDateTime((dateStart.Text));

            int fark1 = Convert.ToInt32(fark.TotalDays);

            if ((fark1 * (-1)) == fark1) fark1 -= 1;

            else fark1 += 1;            
            int sonuc = fark1 ;

            PermitAdModel p = new PermitAdModel();
            p.Permit_Id = (int)comboPermit.SelectedValue;
            p.Start_date = dateStart.Text;
            p.End_date = dateEnd.Text;
            if (p.Permit_Id == 8)
            {
                if (sonuc2 <= 5)
                {
                    if (sonuc > 14)
                    {
                        MessageBox.Show("14 günden fazla izin verilemez","warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                    else if (sonuc == 14)
                    {
                        MessageBox.Show("yillik izniniz bitti");
                    }
                    else
                    {
                        int son = 14 - sonuc;
                        MessageBox.Show("kalan izin gününüz" + son + " dur");
                    }
                }
                else if (sonuc2 <= 15)
                {
                    if (sonuc > 24)
                    {
                        MessageBox.Show("24 günden fazla izin verilemez", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (sonuc == 24)
                    {
                        MessageBox.Show("yillik izniniz bitti", "warning");
                    }
                    else
                    {
                        int son = 24 - sonuc;
                        MessageBox.Show("kalan izin gününü" + son + " dur", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (sonuc > 15)
                {
                    if (sonuc > 26)
                    {
                        MessageBox.Show("26 günden fazla izin verilemez", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (sonuc == 26)
                    {
                        MessageBox.Show("yillik izninin tamamını kullandı bitti");
                    }
                    else
                    {
                        int son = 26 - sonuc;
                        MessageBox.Show("kalan izin gününüz" + son + " dur");
                    }
                }
            }

            p.Emp_Id = (int)comboName.SelectedValue;

            p.Start_date = dateStart.Text;
            p.End_date = dateEnd.Text;
            p.Explanation = textExplanation.Text;
            p.Date = DateTime.Now;
            p.Process = p.Emp_Id + "-" + (string)comboName.Text + " Add";

            string sql = "insert into pemitType (emp_ıd,permit_ıd,start_date,end_date,process,explanation) values('" + p.Emp_Id + "','" + p.Permit_Id + "',@start_date,@end_date,'" + p.Process + "','" + p.Explanation + "')";
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Add("@start_date", SqlDbType.Date).Value = p.Start_date;
            cmd.Parameters.Add("@end_date", SqlDbType.Date).Value = p.End_date;

            try
            {
                VeriTabani.ADU(cmd, sql);
                Clean();
                MessageBox.Show("Added", "Add premium", MessageBoxButtons.OK, MessageBoxIcon.Information);


                VeriTabani.Listele_Ara(dataGridView1, "select pt.permitTypeId,pt.user_Id,u.username, e.emp_Id, e.name, e.surname,p.PermitType, pt.start_date, pt.end_date, pt.explanation from PemitType pt left join Permit p on p.permit_ıd = pt.permit_Id left join Employee e on e.emp_Id = pt.emp_Id left join User_Log u on u.Id = pt.user_Id ");
                VeriTabani.con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textExplanation.Text = dataGridView1.CurrentRow.Cells["explanation"].Value.ToString();
                string start = dataGridView1.CurrentRow.Cells["start_date"].Value.ToString();
                string end = dataGridView1.CurrentRow.Cells["end_date"].Value.ToString();
                dateStart.Text = start.Substring(0, 10);
                dateEnd.Text = end.Substring(0, 10);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }
    }
}
