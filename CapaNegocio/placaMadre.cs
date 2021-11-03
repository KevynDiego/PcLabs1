using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class placaMadre : Componentes
    {
        public override int Costo { get => costo; set => costo = value; }
        public override int Generacion { get => generacion; set => generacion = value; }

        public override string Modelo { get => modelo; set => modelo = value; }

        public override string Marca { get => marca; set => marca = value; }


        private int id;
        public static int Cantidad = 1;
        private int chipset;
        public placaMadre()
        {
            this.id = placaMadre.Cantidad++;
        }

        public int Id { get => id; }
        public int Chipset { get => chipset; set => chipset = value; }
    }
}
