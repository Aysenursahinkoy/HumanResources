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
//kon
namespace İnsanKaynaklari
{
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
        }


        private void Bonus_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'humanResourcesMnagementDataSet2.Employee' table. You can move, or remove it, as needed.
            radioPrivate.Checked = true;
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil + 2; i >= (yil - 30); i--)
            {
                comboYil.Items.Add(i);
            }
            RaiseClass.ComboEmployee(comboName);
            VeriTabani.Listele_Ara(dataGridView1, "select bonus_Id,e.emp_Id,name,surname,salary,start_date from employee e,bonus b where e.emp_Id=b.bonus_Id");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void list()
        {
            da = new SqlDataAdapter("select emp_Id,period,bonus_amount,explanation,date from bonus", VeriTabani.con);
            ds = new DataSet();
            VeriTabani.con.Open();
            da.Fill(ds, "bonus");
            dataGridView1.DataSource = ds.Tables["bonus"];
            VeriTabani.con.Close();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {


                BonusModel bm = new BonusModel();
                bm.Payment_status = BonusModel.kid;
                bm.Period = comboAy.Text + "/" + comboYil.Text;
                bm.Bonus_amount = decimal.Parse(textBonus.Text);
                bm.Explanation = textExplanation.Text;
                bm.Date = DateTime.Now;
                if (radioPrivate.Checked)
                {

                    bm.Emp_Id = int.Parse(lbl.Text);
                    SqlCommand cmd = new SqlCommand();
                    string sql = "insert into Bonus(emp_Id,period,bonus_amount,explanation,date)" +
                        "values('" + bm.Emp_Id + "','" + bm.Period + "',@bonus,'" + bm.Explanation + "',@date)";
                    cmd.Parameters.Add("@bonus", SqlDbType.Decimal).Value = bm.Bonus_amount;
                    cmd.Parameters.Add("@date", SqlDbType.Date).Value = bm.Date;

                    VeriTabani.ADU(cmd, sql);
                    MessageBox.Show("Added", "Add premium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();

                }
                else if (radioAllStaff.Checked)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        string sql = "insert into Bonus(emp_Id,period,bonus_amount,explanation,date)" +
                            "values('" + dataGridView1.Rows[i].Cells[0].Value + "','" + bm.Period + "',@bonus,'" + bm.Explanation + "',@date)";
                        SqlCommand cmd = new SqlCommand();
                        cmd.Parameters.Add("@bonus", SqlDbType.Decimal).Value = bm.Bonus_amount;
                        cmd.Parameters.Add("@date", SqlDbType.Date).Value = bm.Date;
                        VeriTabani.ADU(cmd, sql);
                    }
                    MessageBox.Show("Added", "Add premium", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }

        Label lbl;
        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl = new Label();
            RaiseClass.ComboSecilirseEmp(comboName, lbl);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
