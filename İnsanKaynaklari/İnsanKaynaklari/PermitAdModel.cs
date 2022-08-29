using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
     class PermitAdModel
    {
        private int Id;
        private int emp_Id;
        private int user_Id;
        private int permit_Id;
        private string start_date;
        private string end_date;
        private string process;
        private string explanation;
        private DateTime date;

        public int Id1 { get => Id; set => Id = value; }
        public int Emp_Id { get => emp_Id; set => emp_Id = value; }
        public int User_Id { get => user_Id; set => user_Id = value; }
        public int Permit_Id { get => permit_Id; set => permit_Id = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }
        public string Process { get => process; set => process = value; }
        public string Explanation { get => explanation; set => explanation = value; }
        public DateTime Date { get => date; set => date = value; }
        public static DataTable ComboPermit(ComboBox c)
        {
            DataTable dt = new DataTable();
            VeriTabani.con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Permit", VeriTabani.con);
            adtr.Fill(dt);
            c.DataSource = dt;
            c.ValueMember = "permit_ıd";
            c.DisplayMember = "permitType";
            VeriTabani.con.Close();
            return dt;
        }
        public static DataTable ComboEmployee(ComboBox c)
        {
            DataTable dt = new DataTable();
            VeriTabani.con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * , name +' '+ surname as fullname FROM Employee", VeriTabani.con);
            adtr.Fill(dt);
            c.DataSource = dt;
            c.ValueMember = "emp_Id";
            c.DisplayMember = "fullname";
            
            VeriTabani.con.Close();
            return dt;
        }

    }
}
