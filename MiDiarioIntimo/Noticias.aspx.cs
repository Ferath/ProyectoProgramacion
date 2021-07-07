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
    public partial class Noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarNoticias();
        }
        protected void LnkVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void btnCrearNoticia_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = NoticiaController.Add_Noticia(TxtIdNoticia.Text, TxtTitulo.Text, TxTDescripcion.Text,
                TxtFechaNoticia.Text);
            this.Response.Redirect(this.Request.Url.AbsoluteUri);
        }

        public void CargarNoticias()
        {
            GrdNoticias.DataSource = from m in NoticiaController.GetAll()
                                       select new
                                       {
                                           Titulo = m.Titulo,
                                           Descripcion = m.Descripcion,
                                           Fecha = m.Fecha,
                                       };
            GrdNoticias.DataBind();
        }

        protected void btnEliminarNoticia_Click(object sender, EventArgs e)
        {
            LbBorrar.Text = NoticiaController.RemoverNoticia(TxtBuscarNoticia.Text);
            CargarNoticias();
            this.Response.Redirect(this.Request.Url.AbsoluteUri);
        }

        protected void btnBuscarNoticia_Click(object sender, EventArgs e)
        {
            Noticia noticia = NoticiaController.BuscarNoticia(TxtBuscarNoticia.Text);

            if (noticia != null)
            {
                LbBorrar.Text = " Si existe su noticia";
            }
            else
            {
                LbBorrar.Text = " No encontrado";
            }
        }

    }
}