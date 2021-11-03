using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Componentes
    {
        protected int costo;
        protected int generacion;
        protected string modelo;
        protected string marca;

        public abstract int Costo { get; set; }
        public abstract int Generacion { get; set; }
        public abstract string Modelo { get; set; }
        public abstract string Marca { get; set; }


    }
}