
namespace DesktopApp.Modules
{
    partial class CentralPacientesForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewCentralPacientes = new System.Windows.Forms.DataGridView();
            this.btnDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxFilter = new System.Windows.Forms.ComboBox();
            this.btnFacial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentralPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(1038, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 28);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "+ Añadir";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(182, 48);
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(524, 23);
            this.tboxSearch.TabIndex = 1;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // dataGridViewCentralPacientes
            // 
            this.dataGridViewCentralPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCentralPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCentralPacientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(191)))), ((int)(((byte)(180)))));
            this.dataGridViewCentralPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCentralPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDetalles,
            this.btnEditar,
            this.btnEliminar});
            this.dataGridViewCentralPacientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.dataGridViewCentralPacientes.Location = new System.Drawing.Point(24, 83);
            this.dataGridViewCentralPacientes.Name = "dataGridViewCentralPacientes";
            this.dataGridViewCentralPacientes.RowTemplate.Height = 25;
            this.dataGridViewCentralPacientes.Size = new System.Drawing.Size(1153, 427);
            this.dataGridViewCentralPacientes.TabIndex = 2;
            this.dataGridViewCentralPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCentralPacientes_CellContentClick);
            // 
            // btnDetalles
            // 
            this.btnDetalles.HeaderText = "Mas Detalles";
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Text = "Mas Detalles";
            this.btnDetalles.UseColumnTextForButtonValue = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "✏️";
            this.btnEditar.UseColumnTextForButtonValue = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEliminar.Text = "🗑️";
            this.btnEliminar.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.label1.Location = new System.Drawing.Point(46, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "🔎 Buscar por:";
            // 
            // cboxFilter
            // 
            this.cboxFilter.FormattingEnabled = true;
            this.cboxFilter.Items.AddRange(new object[] {
            "cedula",
            "nombre",
            "seguros"});
            this.cboxFilter.Location = new System.Drawing.Point(712, 48);
            this.cboxFilter.Name = "cboxFilter";
            this.cboxFilter.Size = new System.Drawing.Size(181, 23);
            this.cboxFilter.TabIndex = 4;
            // 
            // btnFacial
            // 
            this.btnFacial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnFacial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFacial.Location = new System.Drawing.Point(912, 48);
            this.btnFacial.Name = "btnFacial";
            this.btnFacial.Size = new System.Drawing.Size(108, 28);
            this.btnFacial.TabIndex = 0;
            this.btnFacial.Text = "🔍 Reconocer";
            this.btnFacial.UseVisualStyleBackColor = false;
            this.btnFacial.Click += new System.EventHandler(this.btnFacial_Click);
            // 
            // CentralPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(37)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1201, 546);
            this.Controls.Add(this.cboxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCentralPacientes);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.btnFacial);
            this.Controls.Add(this.btnSave);
            this.Name = "CentralPacientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Pacientes:";
            this.Load += new System.EventHandler(this.CentralPacientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentralPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.DataGridView dataGridViewCentralPacientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxFilter;
        private System.Windows.Forms.DataGridViewButtonColumn btnDetalles;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Button btnFacial;
    }
}