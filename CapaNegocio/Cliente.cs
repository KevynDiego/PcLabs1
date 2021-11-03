using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cliente : Persona
    {
        private int id;
        private string numeroTarjeta;
        private bool tieneCupon;

        public int Id { get => id; set => id = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }
        public bool TieneCupon { get => tieneCupon; set => tieneCupon = value; }

        public string Enviado()
        {
            return "Se ha enviado correctamente los Datos";
        }
    }
}