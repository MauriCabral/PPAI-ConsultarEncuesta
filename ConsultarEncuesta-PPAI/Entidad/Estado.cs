using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        //public bool esIniciada() { return estado == "Iniciada"; }

        public bool esIniciada()
        {
            if (estado == "Iniciada") 
            { return true; }
            else { return false; }
        }
       
    }
}
