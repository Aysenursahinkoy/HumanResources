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
    class EmployeeModel
    {
        private int _emp_Id;
        private string _name;
        private string _surname;
        private string _phone_number;
        private string _adress;
        private string _email;
        private int _dep_Id;
        private decimal _salary;
        private DateTime _start_date;
        private DateTime _end_date;
        private string explanation;
        private string is_active;

        public static int kid = 0;

        public int Emp_Id { get => _emp_Id; set => _emp_Id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Phone_number { get => _phone_number; set => _phone_number = value; }
        public string Adress { get => _adress; set => _adress = value; }
        public string Email { get => _email; set => _email = value; }
        public int Dep_Id { get => _dep_Id; set => _dep_Id = value; }
        public decimal Salary { get => _salary; set => _salary = value; }
        public DateTime Start_date { get => _start_date; set => _start_date = value; }
        public DateTime End_date { get => _end_date; set => _end_date = value; }
        public string Explanation { get => explanation; set => explanation = value; }
        public string Is_active { get => is_active; set => is_active = value; }

        public static string sql = "select *from Department";
        public static string value = "dep_Id";
        public static string text = "department";
        public static DataTable ComboGetir(ComboBox c)
        {
            DataTable dt = new DataTable();
            VeriTabani.con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, VeriTabani.con);
            adtr.Fill(dt);
            c.DataSource = dt;
            c.ValueMember = value;
            c.DisplayMember = text;
            VeriTabani.con.Close();
            return dt;
        }
        public static void doldur(ComboBox cmb)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT  *FROM employee";
            komut.Connection = VeriTabani.con;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            VeriTabani.con.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr["emp_Id"] + "." + dr["name"] + " " + dr["surname"]);

            }

            VeriTabani.con.Close();
        }


        

    }
}
