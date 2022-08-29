using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnsanKaynaklari
{
    class VeriTabani
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-EM6044K\\SQLEXPRESS;Initial Catalog=HumanResourcesMnagement;Integrated Security=True");

        public static void ADU(SqlCommand cmd, string sql)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable Listele_Ara(DataGridView gridView, string sql)
        {

            DataTable tbl = new DataTable();
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, con);
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            con.Close();
            return tbl;
        }

    }
}
