using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
    public partial class UserLogin : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-EM6044K\\SQLEXPRESS;Initial Catalog=HumanResourcesMnagement;Integrated Security=True");

        public void Login()
        {
          try
            {

                connect.Open();
                SqlDataAdapter usr = new SqlDataAdapter();
                SqlCommand user = new SqlCommand();
                user.Connection = connect;
                user.CommandText = "SELECT * FROM User_Log WHERE username=@username";
                user.Parameters.AddWithValue("@username", textBox1.Text);
                usr.SelectCommand = user;
                DataSet userDS = new DataSet();
                userDS.Clear();
                usr.Fill(userDS);
                if (userDS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("there is no such User");
                    connect.Close();
                    return;
                   
            
                }

                string password = userDS.Tables[0].Rows[0][2].ToString();

                if (password == textBox2.Text)
                {
                    
                    AnaForm ana = new AnaForm();
                    ana.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong user and password !!");
                    connect.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (checkBox1.Checked)
            {
                File.WriteAllText(Application.StartupPath + "\\password.txt", password.Text);
            }
        }
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSifre frm = new FrmSifre();
            frm.ShowDialog();

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.username!= string.Empty)
            {
               textBox1.Text=Properties.Settings.Default.username;
                textBox2.Text = Properties.Settings.Default.password;
                checkBox1.Checked  = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                              Properties.Settings.Default.username=textBox1.Text;
                Properties.Settings.Default.password=textBox2.Text;
                Properties.Settings.Default.Save();


            }
        }
    }
}
