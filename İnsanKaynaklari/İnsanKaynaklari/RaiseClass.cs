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
    class RaiseClass
    {


        #region Raise_Encapsulation
        private int _raiseId;
        private int _Period;
        private int _employee;
        private decimal _Percent;
        private decimal? _Total;
        private string _explanation;
        private DateTime _Date;

        public int RaiseId { get => _raiseId; set => _raiseId = value; }
        public int Period { get => _Period; set => _Period = value; }
        public int Employee { get => _employee; set => _employee = value; }
        public decimal Percent { get => _Percent; set => _Percent = value; }
        public decimal? Total { get => _Total; set => _Total = value; }
        public string Explanation { get => _explanation; set => _explanation = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        #endregion



        public static SqlDataReader ComboEmployee(ComboBox cmb)
        {
            VeriTabani.con.Open();
            SqlCommand cmd = new SqlCommand("select emp_Id,name,surname from Employee", VeriTabani.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(dr[0] + "." + dr[1] + " " + dr[2]);
            }

            VeriTabani.con.Close();
            return dr;
        }
        public static SqlDataReader ComboSecilirseEmp(ComboBox combo,Label lb)
        {
            VeriTabani.con.Open();
            SqlCommand cmd = new SqlCommand("select emp_Id,name,surname from Employee", VeriTabani.con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (combo.SelectedItem.ToString() == dr[0] + "." + dr[1] + " " + dr[2])
                {
                    lb.Text = dr[0].ToString();
                }
            }
            VeriTabani.con.Close();
            return dr;
        }
       
    }
}
