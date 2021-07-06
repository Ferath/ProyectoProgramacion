using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiDiarioIntimo.Clases;

namespace MiDiarioIntimo.Controller
{
    public class NoticiaController
    {
        // La lista de las noticias
        public static List<Noticia> listaNoticias = new List<Noticia>();
        // Cargando las Noticias, pre-creadas
        public static void ListarNoticias()
        {
  
        }

        public static string Add_Noticia(string id_noticia, string titulo, string descripcion, string fecha)
        {
            try
            {
                Noticia noticia = new Noticia()
                {
                    Id_noticia = int.Parse(id_noticia),
                    Titulo = titulo,
                    Descripcion = descripcion,
                    Fecha = fecha
                };
                listaNoticias.Add(noticia);

                return "Su noticia se ha agregado correctamente";
            }
            catch (Exception e)
            { return "Error: " + e.Message; }

        }

        // Para obtener todas las noticias
        public static List<Noticia> GetAll()
        {
            return listaNoticias;
        }

    }
}