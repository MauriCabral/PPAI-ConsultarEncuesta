using ConsultarEncuesta_PPAI.Entidad;
using ConsultarEncuesta_PPAI.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarEncuesta_PPAI.Control
{
    public class GestorConsultarEncuesta
    {
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private List<Llamada> llamadasIniciadas;
        private List<CambioEstado> cambioEstados;
        private List<Estado> estados;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantallaConsultarEncuesta)
        {
            this.pantallaConsultarEncuesta = pantallaConsultarEncuesta;
            llamadasIniciadas = CargaDeDatos.loadLLamadas();
            estados = CargaDeDatos.loadEstados();
        }

        public void opConsultarEncuesta()
        {
              
        }

        public void buscarLlamadasConEncuestasResp(DateTime desde, DateTime hasta)
        {
            Dictionary<Llamada, DateTime> llamadasPeriodo = new Dictionary<Llamada, DateTime>();
            llamadasIniciadas = CargaDeDatos.loadLLamadas();

            if (this.llamadasIniciadas.Count != 0)
            {
                foreach (Llamada llamadaCarg in llamadasIniciadas)
                {
                    if (llamadaCarg.esDePeriodo(desde, hasta))
                    {
                        llamadasPeriodo.Add(llamadaCarg, llamadaCarg.getFechaHoraInicioCE());
                    }
                }
            }
            pantallaConsultarEncuesta.mostrarLlamadasPeriodo(llamadasPeriodo);
        }

        public DateTime tomarSeleccionLlamada(DateTime llamadaSeleccionada)
        {
            return llamadaSeleccionada;
        }

        public void llamadaSeleccionada(Llamada llamadaSeleccionada)
        {

        }

        public void buscarDatosLlamada()
        { 

        }


















        public void finCU()
        {
            MessageBox.Show("CSV generado con éxito", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pantallaConsultarEncuesta.Dispose();
        }
    }
}
