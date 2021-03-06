using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class dicoDuro : Componentes
    {
        public override int Costo { get => costo; set => costo = value; }
        public override int Generacion { get => generacion; set => generacion = value; }

        public override string Modelo { get => modelo; set => modelo = value; }

        public override string Marca { get => marca; set => marca = value; }

        private int id;
        public static int Cantidad = 1;
        private string tipo;
        private string capacidad;

        public dicoDuro()
        {
            this.id = dicoDuro.Cantidad++;
        }

        public int Id { get => id; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Capacidad { get => capacidad; set => capacidad = value; }
    }
}
