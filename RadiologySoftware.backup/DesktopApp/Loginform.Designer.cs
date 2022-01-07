
namespace DesktopApp
{
    partial class Loginform
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
            this.tabLogin = new System.Windows.Forms.TabControl();
            this.tabAcceso = new System.Windows.Forms.TabPage();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabAyuda = new System.Windows.Forms.TabPage();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabLogin.SuspendLayout();
            this.tabAcceso.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.tabAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.tabAcceso);
            this.tabLogin.Controls.Add(this.tabRegistro);
            this.tabLogin.Controls.Add(this.tabAyuda);
            this.tabLogin.Location = new System.Drawing.Point(30, 36);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.SelectedIndex = 0;
            this.tabLogin.Size = new System.Drawing.Size(388, 147);
            this.tabLogin.TabIndex = 0;
            // 
            // tabAcceso
            // 
            this.tabAcceso.Controls.Add(this.tboxPassword);
            this.tabAcceso.Controls.Add(this.lblContrasena);
            this.tabAcceso.Controls.Add(this.tboxUsername);
            this.tabAcceso.Controls.Add(this.lblNombre);
            this.tabAcceso.Location = new System.Drawing.Point(4, 24);
            this.tabAcceso.Name = "tabAcceso";
            this.tabAcceso.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcceso.Size = new System.Drawing.Size(380, 119);
            this.tabAcceso.TabIndex = 0;
            this.tabAcceso.Text = "Acceso";
            this.tabAcceso.UseVisualStyleBackColor = true;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(135, 67);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(223, 23);
            this.tboxPassword.TabIndex = 1;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.lblContrasena.Location = new System.Drawing.Point(32, 67);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(70, 15);
            this.lblContrasena.TabIndex = 0;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(135, 29);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(223, 23);
            this.tboxUsername.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.lblNombre.Location = new System.Drawing.Point(32, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Usuario:";
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.richTextBox1);
            this.tabRegistro.Location = new System.Drawing.Point(4, 24);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(380, 119);
            this.tabRegistro.TabIndex = 1;
            this.tabRegistro.Text = "Registro";
            this.tabRegistro.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 138);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabAyuda
            // 
            this.tabAyuda.Controls.Add(this.btnAyuda);
            this.tabAyuda.Location = new System.Drawing.Point(4, 24);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.Size = new System.Drawing.Size(380, 119);
            this.tabAyuda.TabIndex = 2;
            this.tabAyuda.Text = "Ayuda e Información";
            this.tabAyuda.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(121, 40);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(131, 39);
            this.btnAyuda.TabIndex = 0;
            this.btnAyuda.Text = "🙌 Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.btnAcceder.Location = new System.Drawing.Point(182, 189);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(115, 29);
            this.btnAcceder.TabIndex = 1;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(220)))));
            this.btnCancelar.Location = new System.Drawing.Point(303, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 29);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(37)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(462, 230);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.tabLogin);
            this.Name = "Loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tabLogin.ResumeLayout(false);
            this.tabAcceso.ResumeLayout(false);
            this.tabAcceso.PerformLayout();
            this.tabRegistro.ResumeLayout(false);
            this.tabAyuda.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLogin;
        private System.Windows.Forms.TabPage tabAcceso;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabAyuda;
        private System.Windows.Forms.Button btnAyuda;
    }
}