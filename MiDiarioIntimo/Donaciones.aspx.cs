using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MiDiarioIntimo.Clases;
using MiDiarioIntimo.Controller;

namespace MiDiarioIntimo
{
    public partial class Donaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //pre carga de los metodos de pago disponibles
            MetodoPagoController.FillMetodoPago();


            cargarGrid();

            //Aquí se cargaran los metodos de pago
            if (!IsPostBack)
            {
                cargarDropDownList();
            }

        }

        public void cargarDropDownList()
        {

            DrpMetodoPago.DataSource = from m in MetodoPagoController.GetAll()
                                       select new
                                       {
                                           metodo = m.Idmetodopago + ".- " + m.NombreMetodoPago
                                       };

            DrpMetodoPago.DataValueField = "metodo";
            DrpMetodoPago.DataBind();
        }

        protected void BtnDonar_Click(object sender, EventArgs e)
        {
            LbMensaje.Text = DonacionController.add_donacion(TxtCantidad_Donacion.Text, DrpMetodoPago.Text);
            this.Response.Redirect(this.Request.Url.AbsoluteUri);
        }

        public void cargarGrid()
        {

            GrdDonaciones.DataSource = from m in DonacionController.GetAll()
                                       select new
                                       {
                                           Monto = m.Cantidad_donacion,
                                           Metodo = m.Metodopago1
                                       };
            GrdDonaciones.DataBind();

        }


    }
}