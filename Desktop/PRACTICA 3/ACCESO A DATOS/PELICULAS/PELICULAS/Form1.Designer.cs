namespace PELICULAS
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butConsulta = new System.Windows.Forms.Button();
            this.butAlta = new System.Windows.Forms.Button();
            this.butModificacion = new System.Windows.Forms.Button();
            this.butBaja = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(182, 106);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(199, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(182, 242);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(199, 26);
            this.txtDuracion.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(182, 173);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(199, 26);
            this.txtTitulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(218, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "PELICULAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "TITULO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "DURACION";
            // 
            // butConsulta
            // 
            this.butConsulta.BackColor = System.Drawing.Color.Maroon;
            this.butConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butConsulta.FlatAppearance.BorderSize = 3;
            this.butConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConsulta.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConsulta.ForeColor = System.Drawing.Color.White;
            this.butConsulta.Location = new System.Drawing.Point(12, 326);
            this.butConsulta.Name = "butConsulta";
            this.butConsulta.Size = new System.Drawing.Size(125, 35);
            this.butConsulta.TabIndex = 7;
            this.butConsulta.Text = "CONSULTA";
            this.butConsulta.UseVisualStyleBackColor = false;
            this.butConsulta.Click += new System.EventHandler(this.butConsulta_Click);
            // 
            // butAlta
            // 
            this.butAlta.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butAlta.FlatAppearance.BorderSize = 3;
            this.butAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAlta.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAlta.ForeColor = System.Drawing.Color.White;
            this.butAlta.Location = new System.Drawing.Point(158, 326);
            this.butAlta.Name = "butAlta";
            this.butAlta.Size = new System.Drawing.Size(99, 35);
            this.butAlta.TabIndex = 8;
            this.butAlta.Text = "ALTA";
            this.butAlta.UseVisualStyleBackColor = true;
            this.butAlta.Click += new System.EventHandler(this.butAlta_Click);
            // 
            // butModificacion
            // 
            this.butModificacion.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butModificacion.FlatAppearance.BorderSize = 3;
            this.butModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butModificacion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butModificacion.ForeColor = System.Drawing.Color.White;
            this.butModificacion.Location = new System.Drawing.Point(397, 326);
            this.butModificacion.Name = "butModificacion";
            this.butModificacion.Size = new System.Drawing.Size(174, 35);
            this.butModificacion.TabIndex = 9;
            this.butModificacion.Text = "MODIFICACION";
            this.butModificacion.UseVisualStyleBackColor = true;
            this.butModificacion.Click += new System.EventHandler(this.butModificacion_Click);
            // 
            // butBaja
            // 
            this.butBaja.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butBaja.FlatAppearance.BorderSize = 3;
            this.butBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBaja.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBaja.ForeColor = System.Drawing.Color.White;
            this.butBaja.Location = new System.Drawing.Point(279, 326);
            this.butBaja.Name = "butBaja";
            this.butBaja.Size = new System.Drawing.Size(99, 35);
            this.butBaja.TabIndex = 9;
            this.butBaja.Text = "BAJA";
            this.butBaja.UseVisualStyleBackColor = true;
            this.butBaja.Click += new System.EventHandler(this.butBaja_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butAceptar.FlatAppearance.BorderSize = 3;
            this.butAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAceptar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAceptar.ForeColor = System.Drawing.Color.White;
            this.butAceptar.Location = new System.Drawing.Point(121, 387);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(122, 35);
            this.butAceptar.TabIndex = 10;
            this.butAceptar.Text = "ACEPTAR";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butCancelar.FlatAppearance.BorderSize = 3;
            this.butCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancelar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelar.ForeColor = System.Drawing.Color.White;
            this.butCancelar.Location = new System.Drawing.Point(323, 387);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(120, 35);
            this.butCancelar.TabIndex = 11;
            this.butCancelar.Text = "CANCELAR";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(400, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "MINUTOS";
            // 
            // butSalir
            // 
            this.butSalir.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butSalir.FlatAppearance.BorderSize = 3;
            this.butSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalir.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.ForeColor = System.Drawing.Color.White;
            this.butSalir.Location = new System.Drawing.Point(234, 442);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(99, 35);
            this.butSalir.TabIndex = 13;
            this.butSalir.Text = "SALIR";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(580, 504);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butBaja);
            this.Controls.Add(this.butModificacion);
            this.Controls.Add(this.butAlta);
            this.Controls.Add(this.butConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butConsulta;
        private System.Windows.Forms.Button butAlta;
        private System.Windows.Forms.Button butModificacion;
        private System.Windows.Forms.Button butBaja;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butSalir;
    }
}

