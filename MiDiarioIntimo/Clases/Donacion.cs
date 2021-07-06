using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiDiarioIntimo.Clases
{
    public class Donacion
    {
        private int id_donacion;
        private float cantidad_donacion;
        private MetodoPago metodopago;

        public Donacion(float cantidad_donacion, MetodoPago metodopago, int id_donacion)
        {
            this.cantidad_donacion = cantidad_donacion;
            this.metodopago = metodopago;
            this.id_donacion = id_donacion;
        }

        public Donacion()
        {

        }

        public int Id_donacion { get => id_donacion; set => id_donacion = value; }
        public float Cantidad_donacion { get => cantidad_donacion; set => cantidad_donacion = value; }
        public MetodoPago Metodopago1 { get => metodopago; set => metodopago = value; }
    }
}