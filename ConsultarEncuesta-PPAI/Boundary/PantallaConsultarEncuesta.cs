﻿using ConsultarEncuesta_PPAI.Control;
using ConsultarEncuesta_PPAI.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarEncuesta_PPAI
{
    public partial class PantallaConsultarEncuesta : Form
    {
        public GestorConsultarEncuesta gestor;
        public PantallaConsultarEncuesta()
        {
            InitializeComponent();
            habilitarPantalla();
        }
        public void habilitarPantalla()
        {
            gestor = new GestorConsultarEncuesta(this);   
            gestor.opConsultarEncuesta();
        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            this.gestor.opConsultarEncuesta();
            this.lblTitPrincipal.Visible = false;
            this.btnConsultarEncuesta.Visible = false;
            this.btnSalir.Visible = false;
            this.pictureBox1.Visible = false;
            this.lblConsultarEncuesta.Visible = true;
            this.lblDesde.Visible = true;
            this.lblHasta.Visible = true;
            this.btnBuscar.Visible = true;
            this.dateTimePickerDesde.Visible = true;
            this.dateTimePickerHasta.Visible = true;
            this.gridLlamadas.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public DateTime tomarSeleccionFechaInicioPerdiodo()
        {
            var fechaDesde = dateTimePickerDesde.Value; //Convert.ToString(dateTimePickerDesde.Value);
            return fechaDesde;
        }

        public DateTime tomarSeleccionFechaFinPerdiodo()
        {
            var fechaHasta = dateTimePickerHasta.Value; //Convert.ToString(dateTimePickerHasta.Value);
            return fechaHasta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.gestor.buscarLlamadasConEncuestasResp(this.tomarSeleccionFechaInicioPerdiodo(), this.tomarSeleccionFechaFinPerdiodo());
        }

        public void mostrarLlamadasPeriodo(Dictionary<Llamada, DateTime> llamadas)
        {
            gridLlamadas.AutoGenerateColumns = false;
            gridLlamadas.Rows.Clear();
            foreach (var llamada in llamadas)
            {
                gridLlamadas.Rows.Add(llamada.Value);
            }
        }

        private void tomarSeleccionLlamada(object sender, DataGridViewCellEventArgs e)
        {
            DateTime periodoDeLlamada = (DateTime)gridLlamadas.CurrentRow.Cells[0].Value;
            gestor.tomarSeleccionLlamada(periodoDeLlamada);
            this.lblDatosLLamada.Visible = true;
            this.lblCliente.Visible = true;
            this.txtDatoCliente.Visible = true;
            this.lblEstadoActual.Visible = true;
            this.txtDatoEstado.Visible = true;
            this.lblDuracion.Visible = true;
            this.txtDatoDuracion.Visible = true;
            this.gridDatosLlamadaSeleccion.Visible = true;
            this.btnImprimir.Visible = true;
            this.btnGenerarCsv.Visible = true;  
        }

        private void tomarSeleccionDeVisualizacion(object sender, EventArgs e)
        {
            gestor.finCU();
        }
    }
}
