using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
    public partial class Raise : Form
    {

        public Raise()
        {
            InitializeComponent();
            CombEmp.SelectedIndex = 0;
            radioPerc.Checked = true;
        }

        private void Raise_Load(object sender, EventArgs e)
        {
            int yil = int.Parse(DateTime.Now.Year.ToString());

            for (int i = yil + 2; i >= (yil - 30); i--)
            {
                combYil.Items.Add(i);
            }
            RaiseClass.ComboEmployee(CombEmp);
        }

        private void radioPerc_CheckedChanged(object sender, EventArgs e)
        {
            txtRaise.Enabled = false;
            txtPerc.Enabled = true;

        }

        private void radioPrice_CheckedChanged(object sender, EventArgs e)
        {
            txtRaise.Enabled = true;
            txtPerc.Enabled = false;

        }
        Label lbl;
        private void CombEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbl = new Label();
            RaiseClass.ComboSecilirseEmp(CombEmp, lbl);
        }

        private void butCon_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioPerc.Checked)
                {
                    decimal perc = decimal.Parse(txtPerc.Text);

                    if (CombEmp.SelectedIndex == 0)
                    {
                        string sql = "update Employee set salary=salary+(salary*'" + perc + "')/100";
                        SqlCommand komut = new SqlCommand();
                        VeriTabani.ADU(komut, sql);
                        MessageBox.Show(">> '" + perc + "' % increase in salaries of All Staff", "Salary Increase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string sql = "update Employee set salary=salary+(salary*'" + perc + "')/100 where emp_Id='" + CombEmp.SelectedIndex + "'";
                        SqlCommand komut = new SqlCommand();
                        VeriTabani.ADU(komut, sql);
                        MessageBox.Show("'" + perc + "% raise for  " + CombEmp.Text + "  employess'", "Salary Increase", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                if (radioPrice.Checked)
                {
                    decimal raise = decimal.Parse(txtRaise.Text);

                    if (CombEmp.SelectedIndex == 0)
                    {
                        string sql = "update Employee set salary=salary+'" + raise + "'";
                        SqlCommand komut = new SqlCommand();
                        VeriTabani.ADU(komut, sql);
                        MessageBox.Show(">> '" + raise + "'  % increase in salaries of All Staff ", "Salary Increase", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        string sql = "update Employee set salary=salary+'" + raise + "' where emp_Id='" + CombEmp.SelectedIndex + "'";
                        SqlCommand komut = new SqlCommand();
                        VeriTabani.ADU(komut, sql);
                        MessageBox.Show("'" + CombEmp.Text + "  employee was paid " + raise + " raise '", "Salary Increase", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                VeriTabani.con.Close();
            }
        }
    }
}
