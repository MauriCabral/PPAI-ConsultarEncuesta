using ConsultarEncuesta_PPAI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarEncuesta_PPAI.Recursos
{
    public class CargaDeDatos
    {
        public static DateTime fechaHoraInicio = DateTime.Now;

        //Llamadas
        public static Llamada llamada1 = new Llamada("Operador 1", "Detalle 1", 0.3, true, "Observacion 1");
        public static Llamada llamada2 = new Llamada("Operador 2", "Detalle 2", 0.5, false, "Observacion 2");
        public static Llamada llamada3 = new Llamada("Operador 3", "Detalle 3", 1, true, "Observacion 3");

        //Estados
        public static Estado estado1 = new Estado("Iniciada");

        //Cambio Estados
        public static CambioEstado cambioEstado1 = new CambioEstado(fechaHoraInicio, estado1);

        public static List<Llamada> loadLLamadas()
        {
            List<Llamada> llamadas = new List<Llamada>();
            llamadas.Add(llamada1);
            llamadas.Add(llamada2);
            llamadas.Add(llamada3);

            return llamadas;
        }

        public static List<Estado> loadEstados()
        {
            List<Estado> estados = new List<Estado>();
            estados.Add(estado1);

            return estados;
        }

        public static List<CambioEstado> loadCambioEstado()
        {
            List<CambioEstado> cambioEstados = new List<CambioEstado>();    
            cambioEstados.Add(cambioEstado1);

            return cambioEstados;
        }
    }
}
