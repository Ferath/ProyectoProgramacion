using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiDiarioIntimo
{
    public class Noticia
    {
        private int id_noticia;
        private string titulo;
        private string descripcion;
        private string fecha;

        public Noticia(int id_noticia, string titulo, string descripcion, string fecha)
        {
            this.Id_noticia = id_noticia;
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.Fecha = fecha;
        }

        public Noticia()
        {
        }

        public int Id_noticia { get => id_noticia; set => id_noticia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}