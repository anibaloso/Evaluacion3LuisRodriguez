using EstacionesDAL;
using EstacionesDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionesApp
{
    public partial class VisualisarPuntoDeCarga : System.Web.UI.Page
    {
        private void CargarTabla(List<PuntoDeCarga> puntoDeCargas)
        {
            puntoDeCargaGrid.DataSource = puntoDeCargas;
            puntoDeCargaGrid.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTabla(new PuntoDeCargaDAL().GetAll());
        }

        protected void puntoDeCargaGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                String numeroPtoCarga = e.CommandArgument.ToString();
                PuntoDeCargaDAL puntoDeCargaDAL = new PuntoDeCargaDAL();
                puntoDeCargaDAL.Remove(Convert.ToInt32(numeroPtoCarga));

                CargarTabla(new PuntoDeCargaDAL().GetAll());
            }
        }
    }
}