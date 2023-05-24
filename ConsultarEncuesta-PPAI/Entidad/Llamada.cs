using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarEncuesta_PPAI.Entidad
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private double duracion; //o Int
        private bool encuestaEnviada;
        private string observacionAuditor;
        //private List<CambioEstado> cambioEstado;
        private CambioEstado cambio;
        private Cliente cliente;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, double duracion, bool encuestaEnviada, string observacionAuditor, CambioEstado cambio, Cliente cliente)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.cambio = cambio;
            this.cliente = cliente;
        }
        public Llamada(string descripcionOperador, string detalleAccionRequerida, double duracion, bool encuestaEnviada, string observacionAuditor)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
        }

        public DateTime getFechaHoraInicioCE() { return this.cambio.getFechaHoraInicio(); }
        
        public bool esDePeriodo(DateTime desde, DateTime hasta)
        {
            if (cambio.esEstadoInicial() && (cambio.getFechaHoraInicio() <= hasta && cambio.getFechaHoraInicio() >= desde))
            {
                return true;
            }
            return false;
        }

        //public string getNombreClienteDeLlamada(DateTime nombreLlamada)
        //{
        //    if()
        //}
    }
}
