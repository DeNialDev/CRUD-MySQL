using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADODB
{
    public partial class Form1 : Form
    {
        int? id;
        public Form1()
        {
            InitializeComponent();
        }
        public int? getID()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            } 
            catch
            {
                return null;
            }

        }
        private void RefreshDataGrid() {

            this.libroTableAdapter.Fill(this.diagnosticoexamenDataSet.libro);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'diagnosticoexamenDataSet.libro' Puede moverla o quitarla según sea necesario.
            RefreshDataGrid();
        }

        private void btbInsert_Click(object sender, EventArgs e)
        {
            FormsCrud.Insert insertWindow = new FormsCrud.Insert();
            insertWindow.ShowDialog();
            RefreshDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = getID();
            if (id != null)
            {
                FormsCrud.Insert updateWindow = new FormsCrud.Insert(id, dataGridView1);
                updateWindow.ShowDialog();
                RefreshDataGrid();
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            FormsCrud.Delete deleteWindow = new FormsCrud.Delete();
            deleteWindow.ShowDialog();
            RefreshDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormsCrud.Search searchWindow = new FormsCrud.Search();
            searchWindow.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
