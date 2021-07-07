using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiDiarioIntimo.Clases
{
    public class MetodoPago
    {
        private int idmetodopago;
        private string metodopago;


        public MetodoPago(int id_metodopago, string metodo_pago)
        {
            this.idmetodopago = id_metodopago;
            this.metodopago = metodo_pago;
        }


        public int Idmetodopago { get => idmetodopago; set => idmetodopago = value; }
        public string NombreMetodoPago { get => metodopago; set => metodopago = value; }
    }
}