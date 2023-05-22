namespace ConsultarEncuesta_PPAI
{
    partial class PantallaConsultarEncuesta
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
            this.lblTitPrincipal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultarEncuesta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblConsultarEncuesta = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridLlamadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitPrincipal
            // 
            this.lblTitPrincipal.AutoSize = true;
            this.lblTitPrincipal.BackColor = System.Drawing.Color.White;
            this.lblTitPrincipal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitPrincipal.Location = new System.Drawing.Point(227, 9);
            this.lblTitPrincipal.Name = "lblTitPrincipal";
            this.lblTitPrincipal.Size = new System.Drawing.Size(298, 21);
            this.lblTitPrincipal.TabIndex = 0;
            this.lblTitPrincipal.Text = "Atención al Cliente Tarjeta De Crédito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsultarEncuesta_PPAI.Properties.Resources.atencion_al_cliente_ilustracion_diseno_plano_23_2148887720;
            this.pictureBox1.Location = new System.Drawing.Point(64, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultarEncuesta
            // 
            this.btnConsultarEncuesta.Location = new System.Drawing.Point(277, 139);
            this.btnConsultarEncuesta.Name = "btnConsultarEncuesta";
            this.btnConsultarEncuesta.Size = new System.Drawing.Size(175, 38);
            this.btnConsultarEncuesta.TabIndex = 2;
            this.btnConsultarEncuesta.Text = "Consultar Encuesta";
            this.btnConsultarEncuesta.UseVisualStyleBackColor = true;
            this.btnConsultarEncuesta.Click += new System.EventHandler(this.btnConsultarEncuesta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(302, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblConsultarEncuesta
            // 
            this.lblConsultarEncuesta.AutoSize = true;
            this.lblConsultarEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarEncuesta.Location = new System.Drawing.Point(303, 13);
            this.lblConsultarEncuesta.Name = "lblConsultarEncuesta";
            this.lblConsultarEncuesta.Size = new System.Drawing.Size(149, 17);
            this.lblConsultarEncuesta.TabIndex = 4;
            this.lblConsultarEncuesta.Text = "Consultar Encuesta";
            this.lblConsultarEncuesta.Visible = false;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(83, 66);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 5;
            this.dateTimePickerDesde.Visible = false;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(359, 66);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 6;
            this.dateTimePickerHasta.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(80, 50);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(121, 13);
            this.lblDesde.TabIndex = 7;
            this.lblDesde.Text = "Ingresar Periodo Desde:";
            this.lblDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(356, 50);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(118, 13);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Ingresar Periodo Hasta:";
            this.lblHasta.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(582, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Llamadas";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridLlamadas
            // 
            this.gridLlamadas.AllowUserToAddRows = false;
            this.gridLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLlamadas.Location = new System.Drawing.Point(83, 113);
            this.gridLlamadas.Name = "gridLlamadas";
            this.gridLlamadas.Size = new System.Drawing.Size(612, 208);
            this.gridLlamadas.TabIndex = 10;
            this.gridLlamadas.Visible = false;
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridLlamadas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.lblConsultarEncuesta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarEncuesta);
            this.Controls.Add(this.lblTitPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultarEncuesta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblConsultarEncuesta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gridLlamadas;
    }
}

