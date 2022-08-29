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
     class BonusModel
    {
        private int _bonus_Id;
        private int _user_Id;
        private int _emp_Id;
        private decimal _bonus_amount;
        private string _payment_status;
        private string _explanation;
        private string _period;
        private DateTime date;
        public static string kid = "";
        public int Bonus_Id { get => _bonus_Id; set => _bonus_Id = value; }
        public int User_Id { get => _user_Id; set => _user_Id = value; }
        public int Emp_Id { get => _emp_Id; set => _emp_Id = value; }
        public decimal Bonus_amount { get => _bonus_amount; set => _bonus_amount = value; }
        public string Payment_status { get => _payment_status; set => _payment_status = value; }
        public string Explanation { get => _explanation; set => _explanation = value; }
        public string Period { get => _period; set => _period = value; }
        public DateTime Date { get => date; set => date = value; }


        
        public static SqlDataReader EmployeeNameSurname(TextBox textEmployeeId,TextBox textname) 
        {
            VeriTabani.con.Open();
            SqlCommand cmd = new SqlCommand("select *from employee where emp_Id='" + textEmployeeId.Text + "'",VeriTabani.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textname.Text = dr[1] + " " + dr[2];
            }
            VeriTabani.con.Close();
            return dr;

        }
        public static SqlDataReader EmployeeNameSurnam(TextBox t)
        {
            VeriTabani.con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * , name + ' ' + surname as fullname FROM Employee'" + t.Text + "'", VeriTabani.con);
            SqlDataReader dr = cmd.ExecuteReader();
           
            VeriTabani.con.Close();
            return dr;

        }



    }
}
