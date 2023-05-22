using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarEncuesta_PPAI.Entidad
{
    public class Estado
    {
        private string estado;

        public Estado(string estado)
        {
            this.estado = estado;
        }

        public string getNombre() { return estado; }

        public bool esIniciada() { return estado == "Iniciada"; }
    }
}
