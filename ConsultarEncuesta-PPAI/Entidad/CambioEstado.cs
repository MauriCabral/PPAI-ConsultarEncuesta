using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarEncuesta_PPAI.Entidad
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estado;

        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        public DateTime getFechaHoraInicio() { return fechaHoraInicio; }

        public string getNombreEstado() { return estado.getNombre(); }

        public bool esEstadoInicial()
        {
            if (estado.esIniciada() && fechaHoraInicio != null)
                return true;
            else
                return false;
        }
        public bool esEstadoInicial1()
        {
            return fechaHoraInicio != null;
            //return this.estado.esIniciada();
        }
    }
}
