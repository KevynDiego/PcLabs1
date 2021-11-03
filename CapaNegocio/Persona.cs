using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        private string dni;
        private string nombres;
        private string apellidos;
        private string domicilio;
        private string correo;
        private string celular;

        public string Dni { get => dni; set => dni = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}