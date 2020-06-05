namespace ADODB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticoexamenDataSet = new ADODB.diagnosticoexamenDataSet();
            this.libroTableAdapter = new ADODB.diagnosticoexamenDataSetTableAdapters.libroTableAdapter();
            this.btbInsert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoexamenDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLibroDataGridViewTextBoxColumn,
            this.tituloLibroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.libroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // idLibroDataGridViewTextBoxColumn
            // 
            this.idLibroDataGridViewTextBoxColumn.DataPropertyName = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.HeaderText = "idLibro";
            this.idLibroDataGridViewTextBoxColumn.Name = "idLibroDataGridViewTextBoxColumn";
            // 
            // tituloLibroDataGridViewTextBoxColumn
            // 
            this.tituloLibroDataGridViewTextBoxColumn.DataPropertyName = "TituloLibro";
            this.tituloLibroDataGridViewTextBoxColumn.HeaderText = "TituloLibro";
            this.tituloLibroDataGridViewTextBoxColumn.Name = "tituloLibroDataGridViewTextBoxColumn";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "libro";
            this.libroBindingSource.DataSource = this.diagnosticoexamenDataSet;
            // 
            // diagnosticoexamenDataSet
            // 
            this.diagnosticoexamenDataSet.DataSetName = "diagnosticoexamenDataSet";
            this.diagnosticoexamenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // btbInsert
            // 
            this.btbInsert.Location = new System.Drawing.Point(363, 111);
            this.btbInsert.Name = "btbInsert";
            this.btbInsert.Size = new System.Drawing.Size(75, 23);
            this.btbInsert.TabIndex = 1;
            this.btbInsert.Text = "Insertar";
            this.btbInsert.UseVisualStyleBackColor = true;
            this.btbInsert.Click += new System.EventHandler(this.btbInsert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 67);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btbInsert);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoexamenDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private diagnosticoexamenDataSet diagnosticoexamenDataSet;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private diagnosticoexamenDataSetTableAdapters.libroTableAdapter libroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btbInsert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

