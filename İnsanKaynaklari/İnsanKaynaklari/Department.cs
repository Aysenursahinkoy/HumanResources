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
    public partial class Department : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void list()
        {
            da = new SqlDataAdapter("Select *From department", VeriTabani.con);
            ds = new DataSet();
            VeriTabani.con.Open();
            da.Fill(ds, "department");
            dataGridView1.DataSource = ds.Tables["department"];
            VeriTabani.con.Close();
        }
        void add()
        {
            cmd = new SqlCommand();
            VeriTabani.con.Open();
            cmd.Connection = VeriTabani.con;
            cmd.CommandText = "insert into Department (department,explanation)values (@department,@explanation)";
            cmd.Parameters.AddWithValue("@department", txtdep.Text);
            cmd.Parameters.AddWithValue("@explanation", txtexp.Text);
            cmd.ExecuteNonQuery();
            VeriTabani.con.Close();
            list();
            update();
        }
        void update()
        {
            cmd = new SqlCommand();
            VeriTabani.con.Open();
            cmd.Connection =VeriTabani.con;
            cmd.CommandText = "update department set (dep_Id,department,explanation)values(@department_Id,@department,@explanation)";
            VeriTabani.con.Close();
            list();
        }
        void clean()
        {
            txtDepId.Text = "";
            txtdep.Text = "";
            txtexp.Text = "";
        }
        void delete()
        {
            if (VeriTabani.con.State == ConnectionState.Closed)
               VeriTabani.con.Open();
            cmd = new SqlCommand();
            cmd.Connection =VeriTabani.con;
            cmd.CommandText = "delete from Department where dep_Id=@dep_Id";
            cmd.Parameters.AddWithValue("dep_Id", txtDepId.Text);

            cmd.ExecuteNonQuery();
            VeriTabani.con.Close();
            update();
        }
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'humanResourcesMnagementDataSet1.Department' table. You can move, or remove it, as needed.     

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add();

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            delete();

        }

        private void btnex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtDepId.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txtdep.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtexp.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            list();
        }
    }
}
