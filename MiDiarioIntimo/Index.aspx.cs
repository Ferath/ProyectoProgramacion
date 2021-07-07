using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MiDiarioIntimo.Controller;
using MiDiarioIntimo.Clases;

namespace MiDiarioIntimo
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarNoticias();
        }

        public void CargarNoticias()
        {

            GrdNoticias.DataSource = from m in NoticiaController.GetAll()
                                     select new
                                     {
                                         Titulo = m.Titulo,
                                         Descripcion = m.Descripcion,
                                         Fecha = m.Fecha

                                     };
            GrdNoticias.DataBind();
        }
    }
}