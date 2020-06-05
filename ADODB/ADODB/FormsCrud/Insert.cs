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
    public partial class Insert : Form
    {
        int? id;
        DataGridView data;
        public Insert()
        {
            InitializeComponent();
            label3.Text = "Insertar";

        }
        public Insert(int? id=null, DataGridView dt = null)
        {
            InitializeComponent();
            label3.Text = "Actualizar";
            this.id = id;
            this.data = dt;
            txtId.Text = data.Rows[data.CurrentRow.Index].Cells[0].Value.ToString();
            txtLib.Text = data.Rows[data.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString: "SERVER=localhost; DATABASE=diagnosticoexamen; UID=root; PWD=123456;"))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    if (this.id != null)
                    {
                        cmd.CommandText = "Update libro set TituloLibro = '" + txtLib.Text.Trim() + "' where idLibro = '" + Convert.ToInt32(txtId.Text.Trim()) + "'";
                    }
                    else
                    {
                        cmd.CommandText = "Insert into libro(idLibro, TituloLibro) values('" + Convert.ToInt32(txtId.Text.Trim()) + "', '" + txtLib.Text.Trim() + "')";

                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado con exito");

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
