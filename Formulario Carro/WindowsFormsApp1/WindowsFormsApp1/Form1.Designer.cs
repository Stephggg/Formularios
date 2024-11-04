using System;

namespace TallerMecanico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelTipoReparacion;
        private System.Windows.Forms.Label labelSeguro;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.ComboBox cmbTipoReparacion;
        private System.Windows.Forms.CheckBox chkSeguro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelNombreDueno;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelFechaRegistro;
        private System.Windows.Forms.TextBox txtNombreDueno;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label labelEmpresa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelTipoReparacion = new System.Windows.Forms.Label();
            this.labelSeguro = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.cmbTipoReparacion = new System.Windows.Forms.ComboBox();
            this.chkSeguro = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelNombreDueno = new System.Windows.Forms.Label();
            this.txtNombreDueno = new System.Windows.Forms.TextBox();
            this.labelCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMarca
            // 
            this.labelMarca.Location = new System.Drawing.Point(25, 340);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(100, 23);
            this.labelMarca.TabIndex = 13;
            this.labelMarca.Text = "Marca del auto:";
            // 
            // labelModelo
            // 
            this.labelModelo.Location = new System.Drawing.Point(25, 380);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(100, 23);
            this.labelModelo.TabIndex = 12;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelAno
            // 
            this.labelAno.Location = new System.Drawing.Point(25, 420);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(100, 23);
            this.labelAno.TabIndex = 11;
            this.labelAno.Text = "Año:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.Location = new System.Drawing.Point(25, 460);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(100, 23);
            this.labelMatricula.TabIndex = 10;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelTipoReparacion
            // 
            this.labelTipoReparacion.Location = new System.Drawing.Point(25, 500);
            this.labelTipoReparacion.Name = "labelTipoReparacion";
            this.labelTipoReparacion.Size = new System.Drawing.Size(100, 23);
            this.labelTipoReparacion.TabIndex = 9;
            this.labelTipoReparacion.Text = "Tipo de reparación:";
            // 
            // labelSeguro
            // 
            this.labelSeguro.Location = new System.Drawing.Point(25, 540);
            this.labelSeguro.Name = "labelSeguro";
            this.labelSeguro.Size = new System.Drawing.Size(100, 23);
            this.labelSeguro.TabIndex = 8;
            this.labelSeguro.Text = "¿Tiene seguro?";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(155, 340);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(200, 26);
            this.txtMarca.TabIndex = 7;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(155, 380);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(200, 26);
            this.txtModelo.TabIndex = 6;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(155, 420);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(200, 26);
            this.txtAno.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(155, 460);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(200, 26);
            this.txtMatricula.TabIndex = 4;
            // 
            // cmbTipoReparacion
            // 
            this.cmbTipoReparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReparacion.Location = new System.Drawing.Point(155, 500);
            this.cmbTipoReparacion.Name = "cmbTipoReparacion";
            this.cmbTipoReparacion.Size = new System.Drawing.Size(200, 28);
            this.cmbTipoReparacion.TabIndex = 3;
            // 
            // chkSeguro
            // 
            this.chkSeguro.Location = new System.Drawing.Point(155, 540);
            this.chkSeguro.Name = "chkSeguro";
            this.chkSeguro.Size = new System.Drawing.Size(15, 14);
            this.chkSeguro.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(70, 597);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 41);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(261, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 41);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelNombreDueno
            // 
            this.labelNombreDueno.Location = new System.Drawing.Point(25, 180);
            this.labelNombreDueno.Name = "labelNombreDueno";
            this.labelNombreDueno.Size = new System.Drawing.Size(120, 23);
            this.labelNombreDueno.TabIndex = 9;
            this.labelNombreDueno.Text = "Nombre del dueño:";
            // 
            // txtNombreDueno
            // 
            this.txtNombreDueno.Location = new System.Drawing.Point(155, 180);
            this.txtNombreDueno.Name = "txtNombreDueno";
            this.txtNombreDueno.Size = new System.Drawing.Size(256, 26);
            this.txtNombreDueno.TabIndex = 8;
            // 
            // labelCedula
            // 
            this.labelCedula.Location = new System.Drawing.Point(25, 220);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(120, 23);
            this.labelCedula.TabIndex = 7;
            this.labelCedula.Text = "Número de cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(155, 220);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(256, 26);
            this.txtCedula.TabIndex = 6;
            // 
            // labelTelefono
            // 
            this.labelTelefono.Location = new System.Drawing.Point(25, 260);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(120, 23);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Número de teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 260);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(256, 26);
            this.txtTelefono.TabIndex = 4;
            // 
            // labelFechaRegistro
            // 
            this.labelFechaRegistro.Location = new System.Drawing.Point(25, 300);
            this.labelFechaRegistro.Name = "labelFechaRegistro";
            this.labelFechaRegistro.Size = new System.Drawing.Size(120, 23);
            this.labelFechaRegistro.TabIndex = 2;
            this.labelFechaRegistro.Text = "Fecha de registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(155, 300);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(256, 26);
            this.dtpFechaRegistro.TabIndex = 3;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.labelEmpresa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEmpresa.Location = new System.Drawing.Point(190, 35);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(238, 103);
            this.labelEmpresa.TabIndex = 0;
            this.labelEmpresa.Text = "MECHAA CARS";
            this.labelEmpresa.Click += new System.EventHandler(this.labelEmpresa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(440, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.labelFechaRegistro);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.txtNombreDueno);
            this.Controls.Add(this.labelNombreDueno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkSeguro);
            this.Controls.Add(this.cmbTipoReparacion);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.labelSeguro);
            this.Controls.Add(this.labelTipoReparacion);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Name = "Form1";
            this.Text = "Registro de Autos en Reparación";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
