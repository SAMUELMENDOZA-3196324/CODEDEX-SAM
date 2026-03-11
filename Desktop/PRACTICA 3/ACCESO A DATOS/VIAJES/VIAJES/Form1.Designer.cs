namespace VIAJES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.butAlta = new System.Windows.Forms.Button();
            this.butBaja = new System.Windows.Forms.Button();
            this.butModificacion = new System.Windows.Forms.Button();
            this.butConsulta = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.listViajes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ORIGEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESTINO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "VEHICULO";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(220, 236);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(197, 27);
            this.txtOrigen.TabIndex = 4;
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(220, 280);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(197, 27);
            this.txtDestino.TabIndex = 5;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculo.Location = new System.Drawing.Point(220, 324);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(197, 27);
            this.txtVehiculo.TabIndex = 6;
            // 
            // butAlta
            // 
            this.butAlta.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butAlta.FlatAppearance.BorderSize = 3;
            this.butAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAlta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAlta.ForeColor = System.Drawing.Color.White;
            this.butAlta.Location = new System.Drawing.Point(29, 396);
            this.butAlta.Name = "butAlta";
            this.butAlta.Size = new System.Drawing.Size(92, 38);
            this.butAlta.TabIndex = 7;
            this.butAlta.Text = "ALTA";
            this.butAlta.UseVisualStyleBackColor = true;
            this.butAlta.Click += new System.EventHandler(this.butAlta_Click);
            // 
            // butBaja
            // 
            this.butBaja.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butBaja.FlatAppearance.BorderSize = 3;
            this.butBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBaja.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBaja.ForeColor = System.Drawing.Color.White;
            this.butBaja.Location = new System.Drawing.Point(161, 396);
            this.butBaja.Name = "butBaja";
            this.butBaja.Size = new System.Drawing.Size(92, 38);
            this.butBaja.TabIndex = 8;
            this.butBaja.Text = "BAJA";
            this.butBaja.UseVisualStyleBackColor = true;
            this.butBaja.Click += new System.EventHandler(this.butBaja_Click);
            // 
            // butModificacion
            // 
            this.butModificacion.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butModificacion.FlatAppearance.BorderSize = 3;
            this.butModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butModificacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butModificacion.ForeColor = System.Drawing.Color.White;
            this.butModificacion.Location = new System.Drawing.Point(280, 396);
            this.butModificacion.Name = "butModificacion";
            this.butModificacion.Size = new System.Drawing.Size(137, 38);
            this.butModificacion.TabIndex = 9;
            this.butModificacion.Text = "MODIFICACION";
            this.butModificacion.UseVisualStyleBackColor = true;
            this.butModificacion.Click += new System.EventHandler(this.butModificacion_Click);
            // 
            // butConsulta
            // 
            this.butConsulta.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butConsulta.FlatAppearance.BorderSize = 3;
            this.butConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConsulta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConsulta.ForeColor = System.Drawing.Color.White;
            this.butConsulta.Location = new System.Drawing.Point(439, 396);
            this.butConsulta.Name = "butConsulta";
            this.butConsulta.Size = new System.Drawing.Size(120, 38);
            this.butConsulta.TabIndex = 10;
            this.butConsulta.Text = "CONSULTA";
            this.butConsulta.UseVisualStyleBackColor = true;
            this.butConsulta.Click += new System.EventHandler(this.butConsulta_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butAceptar.FlatAppearance.BorderSize = 3;
            this.butAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAceptar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAceptar.ForeColor = System.Drawing.Color.White;
            this.butAceptar.Location = new System.Drawing.Point(60, 461);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(92, 38);
            this.butAceptar.TabIndex = 11;
            this.butAceptar.Text = "ACEPTAR";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butCancelar.FlatAppearance.BorderSize = 3;
            this.butCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelar.ForeColor = System.Drawing.Color.White;
            this.butCancelar.Location = new System.Drawing.Point(241, 461);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(117, 38);
            this.butCancelar.TabIndex = 12;
            this.butCancelar.Text = "CANCELAR";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butSalir
            // 
            this.butSalir.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.butSalir.FlatAppearance.BorderSize = 3;
            this.butSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSalir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.ForeColor = System.Drawing.Color.White;
            this.butSalir.Location = new System.Drawing.Point(449, 461);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(92, 38);
            this.butSalir.TabIndex = 13;
            this.butSalir.Text = "SALIR";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // listViajes
            // 
            this.listViajes.HideSelection = false;
            this.listViajes.Location = new System.Drawing.Point(47, 67);
            this.listViajes.Name = "listViajes";
            this.listViajes.Size = new System.Drawing.Size(458, 148);
            this.listViajes.TabIndex = 14;
            this.listViajes.UseCompatibleStateImageBehavior = false;
            this.listViajes.SelectedIndexChanged += new System.EventHandler(this.listViajes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(589, 528);
            this.Controls.Add(this.listViajes);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butConsulta);
            this.Controls.Add(this.butModificacion);
            this.Controls.Add(this.butBaja);
            this.Controls.Add(this.butAlta);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BORJA ORBEGOZO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Button butAlta;
        private System.Windows.Forms.Button butBaja;
        private System.Windows.Forms.Button butModificacion;
        private System.Windows.Forms.Button butConsulta;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.ListView listViajes;
    }
}

