using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiDiarioIntimo.Clases;

namespace MiDiarioIntimo.Controller
{
    public class MetodoPagoController
    {
        private static List<MetodoPago> listaMetodoPago = new List<MetodoPago>();

        /// Lista de los unicos metodos de pago existente
        public static void FillMetodoPago()
        {
            if (listaMetodoPago.Count == 0)
            {
                listaMetodoPago.Add(new MetodoPago(1, "PayPal"));
                listaMetodoPago.Add(new MetodoPago(2, "Visa"));
                listaMetodoPago.Add(new MetodoPago(3, "MasterCard"));
                listaMetodoPago.Add(new MetodoPago(4, "Nacional"));

            }
        }

        public static List<MetodoPago> GetAll()
        {
            return listaMetodoPago;
        }
    }
}