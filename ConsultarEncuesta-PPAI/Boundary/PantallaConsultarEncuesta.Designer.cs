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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.llamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDatosLLamada = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.txtDatoCliente = new System.Windows.Forms.TextBox();
            this.txtDatoEstado = new System.Windows.Forms.TextBox();
            this.txtDatoDuracion = new System.Windows.Forms.TextBox();
            this.gridDatosLlamadaSeleccion = new System.Windows.Forms.DataGridView();
            this.respuestasSelecc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionPregs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerarCsv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLlamadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatosLlamadaSeleccion)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(27, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(694, 589);
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
            this.gridLlamadas.AllowUserToOrderColumns = true;
            this.gridLlamadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLlamadas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLlamadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLlamadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLlamadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.llamadas});
            this.gridLlamadas.Location = new System.Drawing.Point(83, 101);
            this.gridLlamadas.Name = "gridLlamadas";
            this.gridLlamadas.Size = new System.Drawing.Size(612, 189);
            this.gridLlamadas.TabIndex = 10;
            this.gridLlamadas.Visible = false;
            this.gridLlamadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionLlamada);
            // 
            // llamadas
            // 
            this.llamadas.HeaderText = "Periodos de Llamadas con Encuestas";
            this.llamadas.Name = "llamadas";
            // 
            // lblDatosLLamada
            // 
            this.lblDatosLLamada.AutoSize = true;
            this.lblDatosLLamada.Location = new System.Drawing.Point(83, 309);
            this.lblDatosLLamada.Name = "lblDatosLLamada";
            this.lblDatosLLamada.Size = new System.Drawing.Size(107, 13);
            this.lblDatosLLamada.TabIndex = 11;
            this.lblDatosLLamada.Text = "Datos de la Llamada:";
            this.lblDatosLLamada.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(86, 337);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 12;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Visible = false;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(522, 337);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 13);
            this.lblDuracion.TabIndex = 13;
            this.lblDuracion.Text = "Duracion:";
            this.lblDuracion.Visible = false;
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Location = new System.Drawing.Point(314, 337);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(75, 13);
            this.lblEstadoActual.TabIndex = 14;
            this.lblEstadoActual.Text = "Estado actual:";
            this.lblEstadoActual.Visible = false;
            // 
            // txtDatoCliente
            // 
            this.txtDatoCliente.Location = new System.Drawing.Point(134, 334);
            this.txtDatoCliente.Name = "txtDatoCliente";
            this.txtDatoCliente.Size = new System.Drawing.Size(149, 20);
            this.txtDatoCliente.TabIndex = 18;
            this.txtDatoCliente.Visible = false;
            // 
            // txtDatoEstado
            // 
            this.txtDatoEstado.Location = new System.Drawing.Point(395, 334);
            this.txtDatoEstado.Name = "txtDatoEstado";
            this.txtDatoEstado.Size = new System.Drawing.Size(100, 20);
            this.txtDatoEstado.TabIndex = 19;
            this.txtDatoEstado.Visible = false;
            // 
            // txtDatoDuracion
            // 
            this.txtDatoDuracion.Location = new System.Drawing.Point(581, 334);
            this.txtDatoDuracion.Name = "txtDatoDuracion";
            this.txtDatoDuracion.Size = new System.Drawing.Size(38, 20);
            this.txtDatoDuracion.TabIndex = 20;
            this.txtDatoDuracion.Visible = false;
            // 
            // gridDatosLlamadaSeleccion
            // 
            this.gridDatosLlamadaSeleccion.AllowUserToAddRows = false;
            this.gridDatosLlamadaSeleccion.AllowUserToOrderColumns = true;
            this.gridDatosLlamadaSeleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDatosLlamadaSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatosLlamadaSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.respuestasSelecc,
            this.descripcionPregs,
            this.descripcionEncuesta});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDatosLlamadaSeleccion.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridDatosLlamadaSeleccion.Location = new System.Drawing.Point(86, 374);
            this.gridDatosLlamadaSeleccion.Name = "gridDatosLlamadaSeleccion";
            this.gridDatosLlamadaSeleccion.Size = new System.Drawing.Size(609, 142);
            this.gridDatosLlamadaSeleccion.TabIndex = 21;
            this.gridDatosLlamadaSeleccion.Visible = false;
            // 
            // respuestasSelecc
            // 
            this.respuestasSelecc.HeaderText = "Respuestas Seleccionadas";
            this.respuestasSelecc.Name = "respuestasSelecc";
            // 
            // descripcionPregs
            // 
            this.descripcionPregs.HeaderText = "Descripcion de Preguntas";
            this.descripcionPregs.Name = "descripcionPregs";
            // 
            // descripcionEncuesta
            // 
            this.descripcionEncuesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.descripcionEncuesta.HeaderText = "Descripcion Encuesta";
            this.descripcionEncuesta.Name = "descripcionEncuesta";
            this.descripcionEncuesta.Width = 124;
            // 
            // btnGenerarCsv
            // 
            this.btnGenerarCsv.Location = new System.Drawing.Point(325, 537);
            this.btnGenerarCsv.Name = "btnGenerarCsv";
            this.btnGenerarCsv.Size = new System.Drawing.Size(101, 23);
            this.btnGenerarCsv.TabIndex = 22;
            this.btnGenerarCsv.Text = "Generar CSV";
            this.btnGenerarCsv.UseVisualStyleBackColor = true;
            this.btnGenerarCsv.Visible = false;
            // 
            // PantallaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 585);
            this.Controls.Add(this.btnGenerarCsv);
            this.Controls.Add(this.gridDatosLlamadaSeleccion);
            this.Controls.Add(this.txtDatoDuracion);
            this.Controls.Add(this.txtDatoEstado);
            this.Controls.Add(this.txtDatoCliente);
            this.Controls.Add(this.lblEstadoActual);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblDatosLLamada);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridDatosLlamadaSeleccion)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn llamadas;
        private System.Windows.Forms.Label lblDatosLLamada;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.TextBox txtDatoCliente;
        private System.Windows.Forms.TextBox txtDatoEstado;
        private System.Windows.Forms.TextBox txtDatoDuracion;
        private System.Windows.Forms.DataGridView gridDatosLlamadaSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuestasSelecc;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionPregs;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionEncuesta;
        private System.Windows.Forms.Button btnGenerarCsv;
    }
}

