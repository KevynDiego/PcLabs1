using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Cliente cliente = new Cliente();
        //*********************//
        RAM ram1 = new RAM();
        RAM ram2 = new RAM();
        RAM ram3 = new RAM();
        //*********************//
        tarjetaVideo tarjeta1 = new tarjetaVideo();
        tarjetaVideo tarjeta2 = new tarjetaVideo();
        tarjetaVideo tarjeta3 = new tarjetaVideo();
        //*********************//
        Procesador procesador1 = new Procesador();
        Procesador procesador2 = new Procesador();
        Procesador procesador3 = new Procesador();
        Procesador procesador4 = new Procesador();
        //*********************//
        placaMadre placa1 = new placaMadre();
        placaMadre placa2 = new placaMadre();
        placaMadre placa3 = new placaMadre();
        //*********************//
        dicoDuro disco1 = new dicoDuro();
        dicoDuro disco2 = new dicoDuro();
        dicoDuro disco3 = new dicoDuro();
        dicoDuro disco4 = new dicoDuro();
        List<carritoCompra> carritos = new List<carritoCompra>();
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string dni = txtDni.Text.Trim();
            string domicilio = txtDomicilio.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string nroTarjeta = txtNroTarjeta.Text.Trim();
            bool cup = btnCupon.Enabled;
            //string isCupon = cup ? "Si" : "No";
            cliente.Apellidos = apellidos;
            cliente.Nombres = nombres;
            cliente.Dni = dni;
            cliente.Domicilio = domicilio;
            cliente.Correo = correo;
            cliente.Celular = celular;
            cliente.NumeroTarjeta = nroTarjeta;
            cliente.TieneCupon = cup;
            MessageBox.Show("          DATOS PERSONALES" + "\n" + "\n" + "Apellidos: " + apellidos +
                "\n" + "Nombres: " + nombres + "\n" + "Dni: " + "\n" + "Domicilio: " + "\n" + "Correo: "
                + correo + "\n" + "Celular: " + celular + "\n" + "N° Tarjeta: ");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //
            ram1.Costo = 280;
            ram1.Marca = "Kingstone";
            ram1.Capacidad = 4;
            ram1.Tipo = "DDR5";
            comboRAM.Items.Add("Marca: " + ram1.Marca + " Capacidad: " + ram1.Capacidad + " Costo:," + ram1.Costo
            + ",Modelo: " + ram1.Modelo + " Tipo: " + ram1.Tipo);
            //
            ram2.Costo = 300;
            ram2.Marca = "Kingstone";
            ram2.Capacidad = 8;
            ram2.Tipo = "DDR6";
            comboRAM.Items.Add("Marca: " + ram2.Marca + " Capacidad: " + ram2.Capacidad + " Costo:," + ram2.Costo
            + ",Modelo: " + ram2.Modelo + " Tipo: " + ram2.Tipo);
            //
            ram3.Costo = 350;
            ram3.Marca = "Kingstone";
            ram3.Capacidad = 16;
            ram3.Tipo = "DDR7";
            comboRAM.Items.Add("Marca: " + ram3.Marca + " Capacidad: " + ram3.Capacidad + " Costo:," + ram3.Costo
            + ",Modelo: " + ram1.Modelo + " Tipo: " + ram3.Tipo);
            //------------------------//
            tarjeta1.Costo = 189;
            tarjeta1.Marca = "NVidia";
            tarjeta1.Modelo = "GT730";
            tarjeta1.Capacidad = 2;
            tarjeta1.Tipo = "DDR3";
            comboTarjetaVideo.Items.Add("Marca: " + tarjeta1.Marca + " Capacidad: " + tarjeta1.Capacidad + " Costo:," + tarjeta1.Costo
               + ",Modelo: " + tarjeta1.Modelo + " Tipo: " + tarjeta1.Tipo);

            tarjeta2.Costo = 336;
            tarjeta2.Marca = "NVidia";
            tarjeta2.Capacidad = 2;
            tarjeta2.Modelo = "GTX950";
            tarjeta2.Tipo = "DDR5";
            comboTarjetaVideo.Items.Add("Marca: " + tarjeta2.Marca + " Capacidad: " + tarjeta2.Capacidad + " Costo:," + tarjeta2.Costo
               + ",Modelo: " + tarjeta2.Modelo + " Tipo: " + tarjeta2.Tipo);

            tarjeta3.Costo = 699;
            tarjeta3.Marca = "NVidia";
            tarjeta3.Capacidad = 2;
            tarjeta3.Modelo = "GTX960";
            tarjeta3.Tipo = "DDR5";
            comboTarjetaVideo.Items.Add("Marca: " + tarjeta3.Marca + " Capacidad: " + tarjeta3.Capacidad + " Costo:," + tarjeta3.Costo
            + ",Modelo: " + tarjeta3.Modelo + " Tipo: " + tarjeta3.Tipo);
            //------------------------//
            procesador1.Costo = 1100;
            procesador1.Marca = "Intel";
            procesador1.Generacion = 10;
            procesador1.Modelo = "Core i3";
            comboProcesador.Items.Add("Marca: " + procesador1.Marca + " Generación: " + procesador1.Generacion + " Costo:," + procesador1.Costo
            + ",Modelo: " + procesador1.Modelo);

            procesador2.Costo = 1198;
            procesador2.Marca = "Intel";
            procesador2.Generacion = 10;
            procesador2.Modelo = "Core i5";
            comboProcesador.Items.Add("Marca: " + procesador2.Marca + " Generación: " + procesador2.Generacion + " Costo:," + procesador2.Costo
            + ",Modelo: " + procesador2.Modelo);

            procesador3.Costo = 2499;
            procesador3.Marca = "Intel";
            procesador3.Generacion = 10;
            procesador3.Modelo = "Core i7";
            comboProcesador.Items.Add("Marca: " + procesador3.Marca + " Generación: " + procesador3.Generacion + " Costo:," + procesador3.Costo
            + ",Modelo: " + procesador3.Modelo);

            procesador4.Costo = 2529;
            procesador4.Marca = "Intel";
            procesador4.Generacion = 11;
            procesador4.Modelo = "Core i7";
            comboProcesador.Items.Add("Marca: " + procesador4.Marca + " Generación: " + procesador4.Generacion + " Costo:," + procesador4.Costo
            + ",Modelo: " + procesador4.Modelo);
            //------------------------//
            placa1.Costo = 439;
            placa1.Marca = "MSI";
            placa1.Modelo = "A520M-A PRO";
            comboPlacaMadre.Items.Add("Marca: " + placa1.Marca + " Costo:," + placa1.Costo
            + ",Modelo: " + placa1.Modelo);

            placa2.Costo = 459;
            placa2.Marca = "MSI";
            placa2.Modelo = "B560M-A PRO";
            comboPlacaMadre.Items.Add("Marca: " + placa2.Marca + " Costo:," + placa2.Costo
            + ",Modelo: " + placa2.Modelo);

            placa2.Costo = 1230;
            placa2.Marca = "MSI";
            placa2.Modelo = "Mag Z490 Tomahawk";
            comboPlacaMadre.Items.Add("Marca: " + placa2.Marca + " Costo:," + placa2.Costo
            + ",Modelo: " + placa2.Modelo);
            //------------------------//
            disco1.Costo = 199;
            disco1.Capacidad = "3.5TRB";
            disco1.Modelo = "STI00DM10";
            disco1.Marca = "Seagate";
            comboDiscoDuro.Items.Add("Marca: " + disco1.Marca + " Costo:," + disco1.Costo
            + ",Modelo: " + disco1.Modelo + " Capacidad: " + disco1.Capacidad);

            disco2.Costo = 204;
            disco2.Capacidad = "1TB";
            disco2.Modelo = "STI00DM10";
            disco2.Marca = "Seagate";
            comboDiscoDuro.Items.Add("Marca: " + disco2.Marca + " Costo:," + disco2.Costo
            + ",Modelo: " + disco2.Modelo + " Capacidad: " + disco2.Capacidad);

            disco3.Costo = 289;
            disco3.Capacidad = "2TB";
            disco3.Modelo = "ST200DM08";
            disco3.Marca = "Seagate";
            comboDiscoDuro.Items.Add("Marca: " + disco3.Marca + " Costo:," + disco3.Costo
            + ",Modelo: " + disco3.Modelo + " Capacidad: " + disco3.Capacidad);

            disco4.Costo = 319;
            disco4.Capacidad = "2TB";
            disco4.Modelo = "ST400DM11";
            disco4.Marca = "Seagate";
            comboDiscoDuro.Items.Add("Marca: " + disco4.Marca + " Costo:," + disco4.Costo
            + ",Modelo: " + disco4.Modelo + " Capacidad: " + disco4.Capacidad);




            

        }
       
        private void label4_Click(object sender, EventArgs e)
        {
            


        }

        private void btnCarritoCompra_Click(object sender, EventArgs e)
        {
            carritoCompra micarrito1 = new carritoCompra();
            micarrito1.AddPrecio(Int32.Parse(comboRAM.SelectedItem.ToString().Split(',')[1]));

            micarrito1.AddPrecio(Int32.Parse(comboTarjetaVideo.SelectedItem.ToString().Split(',')[1]));

            micarrito1.AddPrecio(Int32.Parse(comboProcesador.SelectedItem.ToString().Split(',')[1]));

            micarrito1.AddPrecio(Int32.Parse(comboPlacaMadre.SelectedItem.ToString().Split(',')[1]));

            micarrito1.AddPrecio(Int32.Parse(comboDiscoDuro.SelectedItem.ToString().Split(',')[1]));
            carritos.Add(micarrito1);

            string precio = lblPrecio.Text.Trim();
            lblPrecio.Text = carritos[carritos.Count-1].PrecioCarrito.ToString();


            bool cup = btnCupon.Enabled;
            //Resetear
            comboRAM.SelectedIndex = -1;
            comboTarjetaVideo.SelectedIndex = -1;
            comboProcesador.SelectedIndex = -1;
            comboPlacaMadre.SelectedIndex = -1;
            comboDiscoDuro.SelectedIndex = -1;
            carritoCompra.agregarFinal(micarrito1.PrecioCarrito);
            labelContador.Text = carritoCompra.NumeroCarritos.ToString();
            //
            int porcentaje = carritoCompra.PrecioTotal * 85 / 100;
            lblPrecioTotal.Text = cup ? Convert.ToString(porcentaje) : carritoCompra.PrecioTotal.ToString();

        }
        private void btnCupon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboTarjetaVideo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
