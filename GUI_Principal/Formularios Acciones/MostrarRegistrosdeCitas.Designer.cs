namespace GUI_Principal.Formularios_Acciones
{
    partial class MostrarRegistrosdeCitas
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.iconFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.Close = new FontAwesome.Sharp.IconPictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.BarraTitulo.Controls.Add(this.Titulo);
            this.BarraTitulo.Controls.Add(this.iconFormularioActual);
            this.BarraTitulo.Controls.Add(this.Minimizar);
            this.BarraTitulo.Controls.Add(this.Close);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(933, 37);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo.Location = new System.Drawing.Point(41, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(91, 23);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Registros";
            // 
            // iconFormularioActual
            // 
            this.iconFormularioActual.BackColor = System.Drawing.Color.Transparent;
            this.iconFormularioActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.iconFormularioActual.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.iconFormularioActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.iconFormularioActual.IconSize = 31;
            this.iconFormularioActual.Location = new System.Drawing.Point(6, 7);
            this.iconFormularioActual.Name = "iconFormularioActual";
            this.iconFormularioActual.Size = new System.Drawing.Size(38, 31);
            this.iconFormularioActual.TabIndex = 3;
            this.iconFormularioActual.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.GripLines;
            this.Minimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.Minimizar.Location = new System.Drawing.Point(851, 4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 32);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(177)))), ((int)(((byte)(248)))));
            this.Close.Location = new System.Drawing.Point(889, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MostrarRegistrosdeCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(933, 494);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MostrarRegistrosdeCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarRegistrosdeCitas";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormularioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconPictureBox iconFormularioActual;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private FontAwesome.Sharp.IconPictureBox Close;
    }
}