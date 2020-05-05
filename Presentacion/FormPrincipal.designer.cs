namespace GUI_Principal
{
    partial class Contenedor
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
            this.Menu = new System.Windows.Forms.Panel();
            this.Programadores = new FontAwesome.Sharp.IconButton();
            this.Administrador = new FontAwesome.Sharp.IconButton();
            this.Enfermera = new FontAwesome.Sharp.IconButton();
            this.Medico = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Inicio = new FontAwesome.Sharp.IconPictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.TituloFormularioHijo = new System.Windows.Forms.Label();
            this.iconFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.Formularios = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inicio)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Menu.Controls.Add(this.Programadores);
            this.Menu.Controls.Add(this.Administrador);
            this.Menu.Controls.Add(this.Enfermera);
            this.Menu.Controls.Add(this.Medico);
            this.Menu.Controls.Add(this.panel3);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(200, 497);
            this.Menu.TabIndex = 0;
            // 
            // Programadores
            // 
            this.Programadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Programadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Programadores.FlatAppearance.BorderSize = 0;
            this.Programadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Programadores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Programadores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programadores.ForeColor = System.Drawing.Color.Gainsboro;
            this.Programadores.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.Programadores.IconColor = System.Drawing.Color.Gainsboro;
            this.Programadores.IconSize = 50;
            this.Programadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Programadores.Location = new System.Drawing.Point(0, 344);
            this.Programadores.Name = "Programadores";
            this.Programadores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Programadores.Rotation = 0D;
            this.Programadores.Size = new System.Drawing.Size(200, 60);
            this.Programadores.TabIndex = 4;
            this.Programadores.Text = "Programadores";
            this.Programadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Programadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Programadores.UseVisualStyleBackColor = true;
            this.Programadores.Click += new System.EventHandler(this.Programadores_Click);
            // 
            // Administrador
            // 
            this.Administrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Administrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Administrador.FlatAppearance.BorderSize = 0;
            this.Administrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrador.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Administrador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.ForeColor = System.Drawing.Color.Gainsboro;
            this.Administrador.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.Administrador.IconColor = System.Drawing.Color.Gainsboro;
            this.Administrador.IconSize = 50;
            this.Administrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.Location = new System.Drawing.Point(0, 284);
            this.Administrador.Name = "Administrador";
            this.Administrador.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Administrador.Rotation = 0D;
            this.Administrador.Size = new System.Drawing.Size(200, 60);
            this.Administrador.TabIndex = 3;
            this.Administrador.Text = "Administrador";
            this.Administrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Administrador.UseVisualStyleBackColor = true;
            this.Administrador.Click += new System.EventHandler(this.Administrador_Click);
            // 
            // Enfermera
            // 
            this.Enfermera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enfermera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Enfermera.FlatAppearance.BorderSize = 0;
            this.Enfermera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enfermera.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Enfermera.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enfermera.ForeColor = System.Drawing.Color.Gainsboro;
            this.Enfermera.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.Enfermera.IconColor = System.Drawing.Color.Gainsboro;
            this.Enfermera.IconSize = 50;
            this.Enfermera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enfermera.Location = new System.Drawing.Point(0, 224);
            this.Enfermera.Name = "Enfermera";
            this.Enfermera.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Enfermera.Rotation = 0D;
            this.Enfermera.Size = new System.Drawing.Size(200, 60);
            this.Enfermera.TabIndex = 2;
            this.Enfermera.Text = "Enfermera";
            this.Enfermera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enfermera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Enfermera.UseVisualStyleBackColor = true;
            this.Enfermera.Click += new System.EventHandler(this.Enfermera_Click);
            // 
            // Medico
            // 
            this.Medico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medico.Dock = System.Windows.Forms.DockStyle.Top;
            this.Medico.FlatAppearance.BorderSize = 0;
            this.Medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Medico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Medico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medico.ForeColor = System.Drawing.Color.Gainsboro;
            this.Medico.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.Medico.IconColor = System.Drawing.Color.Gainsboro;
            this.Medico.IconSize = 50;
            this.Medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.Location = new System.Drawing.Point(0, 164);
            this.Medico.Name = "Medico";
            this.Medico.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Medico.Rotation = 0D;
            this.Medico.Size = new System.Drawing.Size(200, 60);
            this.Medico.TabIndex = 1;
            this.Medico.Text = "Medico";
            this.Medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Medico.UseVisualStyleBackColor = true;
            this.Medico.Click += new System.EventHandler(this.Medico_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Inicio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(200, 164);
            this.panel3.TabIndex = 0;
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.Transparent;
            this.Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.Inicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Inicio.IconColor = System.Drawing.Color.Gainsboro;
            this.Inicio.IconSize = 151;
            this.Inicio.Location = new System.Drawing.Point(23, 13);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(182, 151);
            this.Inicio.TabIndex = 0;
            this.Inicio.TabStop = false;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.BarraTitulo.Controls.Add(this.TituloFormularioHijo);
            this.BarraTitulo.Controls.Add(this.iconFormularioActual);
            this.BarraTitulo.Controls.Add(this.Minimizar);
            this.BarraTitulo.Controls.Add(this.Close);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(200, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(820, 57);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // TituloFormularioHijo
            // 
            this.TituloFormularioHijo.AutoSize = true;
            this.TituloFormularioHijo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloFormularioHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.TituloFormularioHijo.Location = new System.Drawing.Point(63, 20);
            this.TituloFormularioHijo.Name = "TituloFormularioHijo";
            this.TituloFormularioHijo.Size = new System.Drawing.Size(60, 23);
            this.TituloFormularioHijo.TabIndex = 4;
            this.TituloFormularioHijo.Text = "Inicio";
            // 
            // iconFormularioActual
            // 
            this.iconFormularioActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.iconFormularioActual.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconFormularioActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormularioActual.IconColor = System.Drawing.Color.Gainsboro;
            this.iconFormularioActual.IconSize = 50;
            this.iconFormularioActual.Location = new System.Drawing.Point(7, 6);
            this.iconFormularioActual.Name = "iconFormularioActual";
            this.iconFormularioActual.Size = new System.Drawing.Size(50, 50);
            this.iconFormularioActual.TabIndex = 3;
            this.iconFormularioActual.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Minimizar.Location = new System.Drawing.Point(750, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(113)))), ((int)(((byte)(181)))));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Close.Location = new System.Drawing.Point(788, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Formularios
            // 
            this.Formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Formularios.Location = new System.Drawing.Point(200, 57);
            this.Formularios.Name = "Formularios";
            this.Formularios.Size = new System.Drawing.Size(820, 440);
            this.Formularios.TabIndex = 2;
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 497);
            this.Controls.Add(this.Formularios);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Contenedor";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Inicio)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox Close;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private FontAwesome.Sharp.IconButton Medico;
        private FontAwesome.Sharp.IconButton Programadores;
        private FontAwesome.Sharp.IconButton Administrador;
        private FontAwesome.Sharp.IconButton Enfermera;
        private FontAwesome.Sharp.IconPictureBox iconFormularioActual;
        private System.Windows.Forms.Label TituloFormularioHijo;
        private System.Windows.Forms.Panel Formularios;
        private FontAwesome.Sharp.IconPictureBox Inicio;
    }
}

