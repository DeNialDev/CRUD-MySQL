using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADODB.FormsCrud
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString: "SERVER = localhost; DATABASE = diagnosticoexamen; UID = root; PWD = 123456;"))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = ("deleteReg('"+Convert.ToInt32(txtId.Text.Trim())+"");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro eliminado con éxito");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Se ha generado un error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    this.Close();
                }
            }
        }
    }
}
