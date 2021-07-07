using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiDiarioIntimo.Clases;

namespace MiDiarioIntimo.Controller
{
    public class DonacionController
    {
        public static List<Donacion> listaDonaciones = new List<Donacion>();

        public static string add_donacion(string cantidad_donacion, string metodopago1)
        {

            try
            {
                Donacion donacion = new Donacion()
                {
                    Cantidad_donacion = float.Parse(cantidad_donacion),
                    Metodopago1 = metodopago1
                };
                listaDonaciones.Add(donacion);

                return "Gracias por su donación";
            }
            catch (Exception e)
            { return "Error: " + e.Message; }

        }

        public static List<Donacion> GetAll()
        {
            return listaDonaciones;
        }

    }
}