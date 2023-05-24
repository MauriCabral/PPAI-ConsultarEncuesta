using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultarEncuesta_PPAI.Entidad
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;

        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }

        public string getNombre() { return this.nombreCompleto; }

    }
}
