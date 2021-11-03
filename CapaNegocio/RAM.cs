using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class RAM : Componentes
    {
        public override int Costo { get => costo; set => costo = value; }//
        public override int Generacion { get => generacion; set => generacion = value; }//no

        public override string Modelo { get => modelo; set => modelo = value; }//

        public override string Marca { get => marca; set => marca = value; }//

        private int id;//no
        public static int Cantidad = 1;//no
        private int capacidad; //
        private string tipo;//

        public RAM()
        {
            this.id = RAM.Cantidad++;
        }

        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public int Id { get => id; }


    }
}