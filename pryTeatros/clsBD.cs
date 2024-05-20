using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace pryTeatros
{
    public class clsBD
    {
        OleDbConnection coneBD;

        public void conexionBD(Label lbl1)
        {
			try
			{


                coneBD = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=bdTeatro1");

                coneBD.Open();
                lbl1.BackColor = Color.Green;
            }
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
        }

        

    }
}
