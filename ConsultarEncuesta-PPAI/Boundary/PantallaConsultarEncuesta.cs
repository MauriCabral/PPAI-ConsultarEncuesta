using ConsultarEncuesta_PPAI.Control;
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

        public void mostrarLlamadasPeriodo(string[,] lp)
        {
            for (int i = 0; i < lp.GetLength(0); i++)
            {
                var fila = new string[]
                {
                    lp[i, 1].ToString(),
                };
                gridLlamadas.Rows.Add(fila);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //this.mostrarLlamadasPeriodo();
        }

        //internal void mostrarLlamadasPorPeriodo(List<Llamada> listaLlamadas)
        //{
        //    gridLlamadas.Rows.Clear();
        //    foreach (var llamada in listaLlamadas)
        //    {
        //        gridLlamadas.Rows.Add(llamada);
        //    }
        //}
    }
}
