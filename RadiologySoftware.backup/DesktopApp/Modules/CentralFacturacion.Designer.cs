
namespace DesktopApp.Modules
{
    partial class CentralFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFacturacion = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MasDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxFilter
            // 
            this.cboxFilter.FormattingEnabled = true;
            this.cboxFilter.Location = new System.Drawing.Point(685, 72);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Size = new System.Drawing.Size(128, 23);
            this.cboxFilter.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "🔎 Buscar por:";
            // 
            // dataGridViewFacturacion
            // 
            this.dataGridViewFacturacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFacturacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(180)))));
            this.dataGridViewFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnEliminar,
            this.MasDetalles});
            this.dataGridViewFacturacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.dataGridViewFacturacion.Location = new System.Drawing.Point(37, 101);
            this.dataGridViewFacturacion.Name = "dataGridViewFacturacion";
            this.dataGridViewFacturacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewFacturacion.RowTemplate.Height = 25;
            this.dataGridViewFacturacion.Size = new System.Drawing.Size(868, 348);
            this.dataGridViewFacturacion.TabIndex = 7;
            this.dataGridViewFacturacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFacturacion_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 23);
            this.textBox1.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(823, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "+ Añadir";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "✏️";
            this.btnEditar.ToolTipText = "✏️";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "🗑️";
            this.btnEliminar.ToolTipText = "🗑️";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // MasDetalles
            // 
            this.MasDetalles.HeaderText = "Mas Detalles";
            this.MasDetalles.Name = "MasDetalles";
            this.MasDetalles.Text = "Mas Detalles";
            this.MasDetalles.UseColumnTextForButtonValue = true;
            // 
            // CentralFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(37)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(944, 473);
            this.Controls.Add(this.cboxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFacturacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "CentralFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Facturacion";
            this.Load += new System.EventHandler(this.CentralFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFacturacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn MasDetalles;
    }
}