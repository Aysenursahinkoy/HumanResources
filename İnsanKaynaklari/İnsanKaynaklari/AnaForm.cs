using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
    public partial class AnaForm : Form
    {

        public AnaForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raise rs = new Raise();
            rs.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeAdd emp = new EmployeeAdd();
            emp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bonus bns = new Bonus();
            bns.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Show shw = new Show();
            shw.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overtime over = new Overtime();
            over.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Department dpr = new Department();
            dpr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           OvertimeList overlst = new OvertimeList();
                overlst.Show();
        }

        private void PermitAdd_Click(object sender, EventArgs e)
        {
            PermitAdd padd = new PermitAdd();
            padd.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            RaiseA a = new RaiseA();
            a.Show();
        }
    }
}
