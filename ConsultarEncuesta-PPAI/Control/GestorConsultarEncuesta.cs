using ConsultarEncuesta_PPAI.Entidad;
using ConsultarEncuesta_PPAI.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarEncuesta_PPAI.Control
{
    public class GestorConsultarEncuesta
    {
        private PantallaConsultarEncuesta pantallaConsultarEncuesta;
        private List<Llamada> llamadasIniciadas;
        private List<CambioEstado> cambioEstados;
        private List<Estado> estados;
        private PantallaConsultarEncuesta pantallaEncuestas;

        public GestorConsultarEncuesta(PantallaConsultarEncuesta pantallaConsultarEncuesta)
        {
            this.pantallaConsultarEncuesta = pantallaConsultarEncuesta;
            llamadasIniciadas = CargaDeDatos.loadLLamadas();
            estados = CargaDeDatos.loadEstados();
        }

        public void opConsultarEncuesta()
        {
              
        }

        public List<DateTime> buscarLlamadasConEncuestasResp()
        {
            List<DateTime> llamadas = new List<DateTime>();
            //List<Llamada> llamadasCargadas = CargaDeDatos.loadLLamadas();
            
            if (this.llamadasIniciadas.Count != 0)
            {
                foreach (Llamada llamadaCarg in llamadasIniciadas)
                {
                    if (llamadaCarg.esDePeriodo(this.pantallaEncuestas.tomarSeleccionFechaInicioPerdiodo(), this.pantallaEncuestas.tomarSeleccionFechaFinPerdiodo()))
                    {
                        llamadas.Add(llamadaCarg.getFechaHoraInicioCE());
                    }
                }
            }
            return llamadas;
        }
        
    }
}
