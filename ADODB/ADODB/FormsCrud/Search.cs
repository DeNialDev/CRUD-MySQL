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
    public partial class Search : Form
    {
        public Search()
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
                    cmd.CommandText = ("Select * from Libro where idLibro = '" + Convert.ToInt32(txtId.Text.Trim()) + "'");
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Registro encontrado");
                        
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetInt32(0) +" "+ reader.GetString(1));

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el registro.");
                    }

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
