namespace CensoINEGI.Vistas
{
    partial class RegistrarHabitanteForm
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbRelacionConVivienda = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.Genero = new System.Windows.Forms.Label();
            this.Relacion = new System.Windows.Forms.Label();
            this.btnAgregarOtro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(273, 177);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(273, 217);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(180, 26);
            this.txtEdad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(273, 257);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(180, 28);
            this.cmbGenero.TabIndex = 4;
            // 
            // cmbRelacionConVivienda
            // 
            this.cmbRelacionConVivienda.FormattingEnabled = true;
            this.cmbRelacionConVivienda.Location = new System.Drawing.Point(273, 298);
            this.cmbRelacionConVivienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRelacionConVivienda.Name = "cmbRelacionConVivienda";
            this.cmbRelacionConVivienda.Size = new System.Drawing.Size(180, 28);
            this.cmbRelacionConVivienda.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(273, 372);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(1070, 638);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(112, 35);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Genero
            // 
            this.Genero.AutoSize = true;
            this.Genero.Location = new System.Drawing.Point(94, 269);
            this.Genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(63, 20);
            this.Genero.TabIndex = 8;
            this.Genero.Text = "Genero";
            // 
            // Relacion
            // 
            this.Relacion.AutoSize = true;
            this.Relacion.Location = new System.Drawing.Point(94, 311);
            this.Relacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Relacion.Name = "Relacion";
            this.Relacion.Size = new System.Drawing.Size(161, 20);
            this.Relacion.TabIndex = 9;
            this.Relacion.Text = "Relacion con vivienda";
            // 
            // btnAgregarOtro
            // 
            this.btnAgregarOtro.Location = new System.Drawing.Point(422, 372);
            this.btnAgregarOtro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarOtro.Name = "btnAgregarOtro";
            this.btnAgregarOtro.Size = new System.Drawing.Size(112, 57);
            this.btnAgregarOtro.TabIndex = 10;
            this.btnAgregarOtro.Text = "Agregar Otro Habitante";
            this.btnAgregarOtro.UseVisualStyleBackColor = true;
            this.btnAgregarOtro.Click += new System.EventHandler(this.btnAgregarOtro_Click);
            // 
            // RegistrarHabitanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnAgregarOtro);
            this.Controls.Add(this.Relacion);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbRelacionConVivienda);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrarHabitanteForm";
            this.Text = "Registrar Habitantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbRelacionConVivienda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label Genero;
        private System.Windows.Forms.Label Relacion;
        private System.Windows.Forms.Button btnAgregarOtro;
    }
}