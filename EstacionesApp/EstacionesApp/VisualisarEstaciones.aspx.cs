using EstacioneDAL;
using EstacioneDAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstacionesApp
{
    public partial class VisualisarEstaciones : System.Web.UI.Page
    {
        private void CargarTabla(List<Estacion> estaciones)
        {
            estacionesGrid.DataSource = estaciones;
            estacionesGrid.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                CargarTabla(new EstacioneDAL.DAL.EstacioneDAL().GetAll());
            }
        }

        protected void estacionesGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                String numeroEstacion = e.CommandArgument.ToString();
                EstacioneDAL.DAL.EstacioneDAL estacioneDAL = new EstacioneDAL.DAL.EstacioneDAL();
                estacioneDAL.Remove(Convert.ToInt32(numeroEstacion));

                CargarTabla(new EstacioneDAL.DAL.EstacioneDAL().GetAll());
            }
        }
    }
}