namespace GUI_Principal
{
    partial class FormPrincipal
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
            this.Contenedor = new System.Windows.Forms.Panel();
            this.Formularios = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.Panel();
            this.Programadores = new FontAwesome.Sharp.IconButton();
            this.Administrador = new FontAwesome.Sharp.IconButton();
            this.Enfermera = new FontAwesome.Sharp.IconButton();
            this.Medico = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Iniciobtn = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.TituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.Contenedor.SuspendLayout();
            this.Formularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Iniciobtn)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Contenedor.Controls.Add(this.Formularios);
            this.Contenedor.Controls.Add(this.Menu);
            this.Contenedor.Controls.Add(this.BarraTitulo);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1036, 536);
            this.Contenedor.TabIndex = 0;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Formularios
            // 
            this.Formularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.Formularios.Controls.Add(this.pictureBox1);
            this.Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formularios.Location = new System.Drawing.Point(244, 38);
            this.Formularios.Name = "Formularios";
            this.Formularios.Size = new System.Drawing.Size(792, 498);
            this.Formularios.TabIndex = 0;
            this.Formularios.Paint += new System.Windows.Forms.PaintEventHandler(this.Formularios_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = null;
            this.pictureBox1.Location = new System.Drawing.Point(164, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 283);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Controls.Add(this.Programadores);
            this.Menu.Controls.Add(this.Administrador);
            this.Menu.Controls.Add(this.Enfermera);
            this.Menu.Controls.Add(this.Medico);
            this.Menu.Controls.Add(this.panel1);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 38);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(244, 498);
            this.Menu.TabIndex = 1;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // Programadores
            // 
            this.Programadores.BackColor = System.Drawing.Color.Transparent;
            this.Programadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Programadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Programadores.FlatAppearance.BorderSize = 0;
            this.Programadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Programadores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Programadores.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Programadores.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.Programadores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Programadores.IconSize = 50;
            this.Programadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Programadores.Location = new System.Drawing.Point(0, 320);
            this.Programadores.Name = "Programadores";
            this.Programadores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Programadores.Rotation = 0D;
            this.Programadores.Size = new System.Drawing.Size(244, 60);
            this.Programadores.TabIndex = 8;
            this.Programadores.Text = "Programadores";
            this.Programadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Programadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Programadores.UseVisualStyleBackColor = false;
            this.Programadores.Click += new System.EventHandler(this.Programadores_Click);
            // 
            // Administrador
            // 
            this.Administrador.BackColor = System.Drawing.Color.Transparent;
            this.Administrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Administrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Administrador.FlatAppearance.BorderSize = 0;
            this.Administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Administrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Administrador.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.Administrador.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Administrador.IconSize = 50;
            this.Administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.Location = new System.Drawing.Point(0, 260);
            this.Administrador.Name = "Administrador";
            this.Administrador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Administrador.Rotation = 0D;
            this.Administrador.Size = new System.Drawing.Size(244, 60);
            this.Administrador.TabIndex = 7;
            this.Administrador.Text = "Administrador";
            this.Administrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Administrador.UseVisualStyleBackColor = false;
            this.Administrador.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // Enfermera
            // 
            this.Enfermera.BackColor = System.Drawing.Color.Transparent;
            this.Enfermera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enfermera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Enfermera.FlatAppearance.BorderSize = 0;
            this.Enfermera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enfermera.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Enfermera.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enfermera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Enfermera.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.Enfermera.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Enfermera.IconSize = 50;
            this.Enfermera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enfermera.Location = new System.Drawing.Point(0, 200);
            this.Enfermera.Name = "Enfermera";
            this.Enfermera.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Enfermera.Rotation = 0D;
            this.Enfermera.Size = new System.Drawing.Size(244, 60);
            this.Enfermera.TabIndex = 6;
            this.Enfermera.Text = "Enfermera";
            this.Enfermera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enfermera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Enfermera.UseVisualStyleBackColor = false;
            this.Enfermera.Click += new System.EventHandler(this.Enfermera_Click);
            // 
            // Medico
            // 
            this.Medico.BackColor = System.Drawing.Color.Transparent;
            this.Medico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Medico.FlatAppearance.BorderSize = 0;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Medico.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Medico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.Medico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Medico.IconSize = 50;
            this.Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.Location = new System.Drawing.Point(0, 140);
            this.Medico.Name = "Medico";
            this.Medico.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Medico.Rotation = 0D;
            this.Medico.Size = new System.Drawing.Size(244, 60);
            this.Medico.TabIndex = 5;
            this.Medico.Text = "Medico";
            this.Medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Medico.UseVisualStyleBackColor = false;
            this.Medico.Click += new System.EventHandler(this.Medico_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Iniciobtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 140);
            this.panel1.TabIndex = 4;
            // 
            // Iniciobtn
            // 
            this.Iniciobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciobtn.Image = null;
            this.Iniciobtn.Location = new System.Drawing.Point(15, 0);
            this.Iniciobtn.Name = "Iniciobtn";
            this.Iniciobtn.Size = new System.Drawing.Size(214, 100);
            this.Iniciobtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Iniciobtn.TabIndex = 0;
            this.Iniciobtn.TabStop = false;
            this.Iniciobtn.Click += new System.EventHandler(this.Iniciobtn_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.BarraTitulo.Controls.Add(this.TituloFormularioHijo);
            this.BarraTitulo.Controls.Add(this.iconFormularioActual);
            this.BarraTitulo.Controls.Add(this.Minimizar);
            this.BarraTitulo.Controls.Add(this.Close);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1036, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // TituloFormularioHijo
            // 
            this.TituloFormularioHijo.AutoSize = true;
            this.TituloFormularioHijo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormularioHijo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TituloFormularioHijo.Location = new System.Drawing.Point(48, 11);
            this.TituloFormularioHijo.Name = "TituloFormularioHijo";
            this.TituloFormularioHijo.Size = new System.Drawing.Size(44, 16);
            this.TituloFormularioHijo.TabIndex = 3;
            this.TituloFormularioHijo.Text = "Inicio";
            this.TituloFormularioHijo.Click += new System.EventHandler(this.TituloFormularioHijo_Click);
            // 
            // iconFormularioActual
            // 
            this.iconFormularioActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(180)))));
            this.iconFormularioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconFormularioActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormularioActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.iconFormularioActual.Location = new System.Drawing.Point(12, 3);
            this.iconFormularioActual.Name = "iconFormularioActual";
            this.iconFormularioActual.Size = new System.Drawing.Size(32, 32);
            this.iconFormularioActual.TabIndex = 2;
            this.iconFormularioActual.TabStop = false;
            this.iconFormularioActual.Click += new System.EventHandler(this.iconFormularioActual_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Minimizar.Location = new System.Drawing.Point(963, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Close.Location = new System.Drawing.Point(1001, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 536);
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Contenedor.ResumeLayout(false);
            this.Formularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Iniciobtn)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel Formularios;
        private FontAwesome.Sharp.IconPictureBox Close;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Iniciobtn;
        private FontAwesome.Sharp.IconButton Medico;
        private FontAwesome.Sharp.IconButton Programadores;
        private FontAwesome.Sharp.IconButton Administrador;
        private FontAwesome.Sharp.IconButton Enfermera;
        private FontAwesome.Sharp.IconPictureBox iconFormularioActual;
        private System.Windows.Forms.Label TituloFormularioHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

