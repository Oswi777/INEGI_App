namespace CensoINEGI.Vistas
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbMunicipios = new System.Windows.Forms.ComboBox();
            this.cmbLocalidades = new System.Windows.Forms.ComboBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.chartPoblacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridReporte = new System.Windows.Forms.DataGridView();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoblacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMunicipios
            // 
            this.cmbMunicipios.FormattingEnabled = true;
            this.cmbMunicipios.Location = new System.Drawing.Point(77, 89);
            this.cmbMunicipios.Name = "cmbMunicipios";
            this.cmbMunicipios.Size = new System.Drawing.Size(121, 21);
            this.cmbMunicipios.TabIndex = 0;
            this.cmbMunicipios.SelectedIndexChanged += new System.EventHandler(this.cmbMunicipios_SelectedIndexChanged);
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(77, 141);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidades.TabIndex = 1;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(77, 180);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(87, 45);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click_1);
            // 
            // chartPoblacion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPoblacion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPoblacion.Legends.Add(legend1);
            this.chartPoblacion.Location = new System.Drawing.Point(457, 12);
            this.chartPoblacion.Name = "chartPoblacion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPoblacion.Series.Add(series1);
            this.chartPoblacion.Size = new System.Drawing.Size(338, 300);
            this.chartPoblacion.TabIndex = 3;
            this.chartPoblacion.Text = "chart1";
            // 
            // dataGridReporte
            // 
            this.dataGridReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReporte.Location = new System.Drawing.Point(822, 12);
            this.dataGridReporte.Name = "dataGridReporte";
            this.dataGridReporte.Size = new System.Drawing.Size(321, 300);
            this.dataGridReporte.TabIndex = 4;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(74, 63);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(309, 13);
            this.lblSeleccion.TabIndex = 5;
            this.lblSeleccion.Text = "Seleccione un municipio y/o localidad para obtener estadísticas";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1056, 396);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 45);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 453);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.dataGridReporte);
            this.Controls.Add(this.chartPoblacion);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.cmbMunicipios);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartPoblacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMunicipios;
        private System.Windows.Forms.ComboBox cmbLocalidades;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoblacion;
        private System.Windows.Forms.DataGridView dataGridReporte;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnVolver;
    }
}