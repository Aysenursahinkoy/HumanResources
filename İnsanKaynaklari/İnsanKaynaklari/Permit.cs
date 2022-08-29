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
    public partial class Permit : Form
    {
        public Permit()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtPermitTypeId.Text = "";
            txtpermitType.Text = "";
        }
        private void Permit_Load(object sender, EventArgs e)
        {
            VeriTabani.Listele_Ara(dataGridView1, "select *from permit");
        }

 
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                try
                {
                PermitModel p = new PermitModel();
                p.Id1 = int.Parse(txtPermitTypeId.Text);
                string sql = "delete from permit where permit_ıd='" + p.Id1 + "'";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("record deleted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                VeriTabani.Listele_Ara(dataGridView1, "select *from permit");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("select record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            try
            {
                PermitModel p = new PermitModel();
                p.Id1 = int.Parse(txtPermitTypeId.Text);
                p.PermitType = txtpermitType.Text;
                string sql = "update permit set permitType='"+p.PermitType+"'where permit_ıd='"+p.Id1+"'";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd, sql);
                MessageBox.Show("record updated", "record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabani.Listele_Ara(dataGridView1, "select *from permit");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
               
            }
        }

        private void btnPermitType_Click(object sender, EventArgs e)
        {        
            try
            {
               
                PermitModel p = new PermitModel();
                p.PermitType = txtpermitType.Text;
                string sql = "insert into permit values ('"+p.PermitType+"')";
                SqlCommand cmd = new SqlCommand();
                VeriTabani.ADU(cmd,sql);
                MessageBox.Show("record added", "record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabani.Listele_Ara(dataGridView1, "select *from permit");
                Clear();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                
            }
        }

      

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPermitTypeId.Text = dataGridView1.CurrentRow.Cells["permit_ıd"].Value.ToString();
            txtpermitType.Text = dataGridView1.CurrentRow.Cells["PermitType"].Value.ToString();
        }
    }
}
