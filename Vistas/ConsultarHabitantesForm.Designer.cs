namespace CensoINEGI.Vistas
{
    partial class ConsultarHabitantesForm
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTotalHabitantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstHabitantes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstActividades = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbViviendas = new System.Windows.Forms.ComboBox();
            this.lstCantidadHabitantesPorTipo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(613, 415);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblTotalHabitantes
            // 
            this.lblTotalHabitantes.AutoSize = true;
            this.lblTotalHabitantes.Location = new System.Drawing.Point(370, 265);
            this.lblTotalHabitantes.Name = "lblTotalHabitantes";
            this.lblTotalHabitantes.Size = new System.Drawing.Size(0, 13);
            this.lblTotalHabitantes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione una vivienda";
            // 
            // lstHabitantes
            // 
            this.lstHabitantes.FormattingEnabled = true;
            this.lstHabitantes.Location = new System.Drawing.Point(406, 68);
            this.lstHabitantes.Name = "lstHabitantes";
            this.lstHabitantes.Size = new System.Drawing.Size(382, 95);
            this.lstHabitantes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de habitantes";
            // 
            // lstActividades
            // 
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(406, 222);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(382, 95);
            this.lstActividades.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Actividades económicas de la vivienda";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(713, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbViviendas
            // 
            this.cmbViviendas.FormattingEnabled = true;
            this.cmbViviendas.Location = new System.Drawing.Point(15, 44);
            this.cmbViviendas.Name = "cmbViviendas";
            this.cmbViviendas.Size = new System.Drawing.Size(372, 21);
            this.cmbViviendas.TabIndex = 10;
            // 
            // lstCantidadHabitantesPorTipo
            // 
            this.lstCantidadHabitantesPorTipo.FormattingEnabled = true;
            this.lstCantidadHabitantesPorTipo.Location = new System.Drawing.Point(12, 222);
            this.lstCantidadHabitantesPorTipo.Name = "lstCantidadHabitantesPorTipo";
            this.lstCantidadHabitantesPorTipo.Size = new System.Drawing.Size(382, 95);
            this.lstCantidadHabitantesPorTipo.TabIndex = 11;
            this.lstCantidadHabitantesPorTipo.SelectedIndexChanged += new System.EventHandler(this.lstCantidadHabitantesPorTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad Habitantes Por Tipo De Casa";
            // 
            // ConsultarHabitantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstCantidadHabitantesPorTipo);
            this.Controls.Add(this.cmbViviendas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstActividades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstHabitantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalHabitantes);
            this.Controls.Add(this.btnConsultar);
            this.Name = "ConsultarHabitantesForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ConsultarHabitantesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTotalHabitantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstHabitantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstActividades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbViviendas;
        private System.Windows.Forms.ListBox lstCantidadHabitantesPorTipo;
        private System.Windows.Forms.Label label4;
    }
}