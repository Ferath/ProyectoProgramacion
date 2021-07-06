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
            listaNoticias.Add(new Noticia(1, "El abuso", "Descripcion del abuso en una relacion", "06/06/2020"));
            listaNoticias.Add(new Noticia(2, "El abuso parte 2", "Descripcion del abuso en una relacion", "05/05/2020"));
            listaNoticias.Add(new Noticia(3, "El abuso parte 3", "Descripcion del abuso en una relacio", "12/12/2020"));
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