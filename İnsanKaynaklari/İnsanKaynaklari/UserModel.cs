using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{

    class UserModel
    {
        private int _Id;
        private string _username;
        private string _password;
        private string _email;

        public int Id { get => _Id; set => _Id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Email { get => _email; set => _email = value; }

        public static bool durum = false;
        public static int kid = 0;
        public static SqlDataReader UserLog(TextBox name, TextBox password)
        {
            UserModel model = new UserModel();
            model.Username = name.Text;
            model.Password = password.Text;
            VeriTabani.con.Open();
            SqlCommand cmd = new SqlCommand("select*from user where username='" + model.Username + "'and password='" + model.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                kid = int.Parse(dr[0].ToString());
            }
            else
            {
                durum = false;
            }
            dr.Close();
            VeriTabani.con.Close();
            return dr;
        }


    }
}
