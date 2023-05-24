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

        //Estados
        public static Estado estado1 = new Estado("Iniciada");

        //Cambio Estados
        public static CambioEstado cambioEstado1 = new CambioEstado(DateTime.Parse("2023/05/20"), estado1);
        public static CambioEstado cambioEstado2 = new CambioEstado(DateTime.Parse("2023/05/21"), estado1);

        //Llamadas
        public static Llamada llamada1 = new Llamada("Operador 1", "Detalle 1", 0.3, true, "Observacion 1", cambioEstado1, cliente1);
        public static Llamada llamada2 = new Llamada("Operador 2", "Detalle 2", 0.5, false, "Observacion 2", cambioEstado1, cliente2);
        public static Llamada llamada3 = new Llamada("Operador 3", "Detalle 3", 1, true, "Observacion 3", cambioEstado2, cliente3);

        public static Cliente cliente1 = new Cliente(123456, "Nombre1", 123456);
        public static Cliente cliente2 = new Cliente(456789, "Nombre2", 456789);
        public static Cliente cliente3 = new Cliente(789456, "Nombre3", 789456);

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
