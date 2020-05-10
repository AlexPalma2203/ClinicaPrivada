namespace PresentacionGUI
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Acceder = new System.Windows.Forms.Button();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Error = new System.Windows.Forms.Label();
            this.ErrorIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Logo.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.Logo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Logo.IconSize = 235;
            this.Logo.Location = new System.Drawing.Point(12, 55);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(235, 263);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.Usuario.Location = new System.Drawing.Point(281, 62);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(468, 20);
            this.Usuario.TabIndex = 1;
            this.Usuario.Text = ".:.USUARIO.:.";
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(281, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 2);
            this.panel2.TabIndex = 3;
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.Contraseña.Location = new System.Drawing.Point(281, 152);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(468, 20);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.Text = ".:.CONTRASEÑA.:.";
            this.Contraseña.TextChanged += new System.EventHandler(this.Contraseña_TextChanged);
            this.Contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(116)))), ((int)(((byte)(127)))));
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(281, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 2);
            this.panel3.TabIndex = 4;
            // 
            // Acceder
            // 
            this.Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.Acceder.FlatAppearance.BorderSize = 0;
            this.Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Acceder.Location = new System.Drawing.Point(458, 249);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(90, 40);
            this.Acceder.TabIndex = 0;
            this.Acceder.Text = "ACCEDER";
            this.Acceder.UseVisualStyleBackColor = false;
            this.Acceder.Click += new System.EventHandler(this.Acceder_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Close.Location = new System.Drawing.Point(745, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 8;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Minimizar.Location = new System.Drawing.Point(707, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Minimizar.TabIndex = 9;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Error.Location = new System.Drawing.Point(316, 197);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(41, 18);
            this.Error.TabIndex = 11;
            this.Error.Text = "Error";
            this.Error.Visible = false;
            this.Error.Click += new System.EventHandler(this.Error_Click_1);
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ErrorIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.ErrorIcon.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.ErrorIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.ErrorIcon.IconSize = 23;
            this.ErrorIcon.Location = new System.Drawing.Point(290, 195);
            this.ErrorIcon.Name = "ErrorIcon";
            this.ErrorIcon.Size = new System.Drawing.Size(27, 23);
            this.ErrorIcon.TabIndex = 12;
            this.ErrorIcon.TabStop = false;
            this.ErrorIcon.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.ErrorIcon);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Acceder);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Acceder;
        private new FontAwesome.Sharp.IconPictureBox Close;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private System.Windows.Forms.Label Error;
        private FontAwesome.Sharp.IconPictureBox ErrorIcon;
        private FontAwesome.Sharp.IconPictureBox Logo;
    }
}

