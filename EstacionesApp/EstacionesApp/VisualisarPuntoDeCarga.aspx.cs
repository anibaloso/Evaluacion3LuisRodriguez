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
    
    public partial class VisualisarPuntoDeCarga : System.Web.UI.Page
    {
        PuntoDeCargaDAL puntoDeCargaDAL = new PuntoDeCargaDAL();

        private void CargarTabla(List<PuntoDeCarga> puntoDeCargas)
        {
            puntoDeCargaGrid.DataSource = puntoDeCargas;
            puntoDeCargaGrid.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            CargarTabla(new PuntoDeCargaDAL().GetAll());
            }
        }

        protected void puntoDeCargaGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                String numeroPuntoCarga = e.CommandArgument.ToString();
                EstacioneDAL.DAL.PuntoDeCargaDAL puntoDeCargaDAL = new EstacioneDAL.DAL.PuntoDeCargaDAL();
                puntoDeCargaDAL.Remove(Convert.ToInt32(numeroPuntoCarga));

                CargarTabla(new EstacioneDAL.DAL.PuntoDeCargaDAL().GetAll());
            }
        }

        protected void filtroTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipo = filtroTipo.SelectedItem.ToString();
            List<PuntoDeCarga> filtrado = puntoDeCargaDAL.GetAllTipo(tipo);
            CargarTabla(filtrado);
        }
    }
}