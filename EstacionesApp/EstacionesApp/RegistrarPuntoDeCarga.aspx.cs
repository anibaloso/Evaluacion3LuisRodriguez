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
    public partial class RegistrarPuntoDeCarga : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Region> regiones = new RegionesDAL().GetAll();
                regionDdl.DataSource = regiones;
                regionDdl.DataTextField = "regionTxt";
                regionDdl.DataBind();
                List<TipoEstacion> tipoEstaciones = new TipoEstacionesDAL().GetAll();
                TipoDdl.DataSource = tipoEstaciones;
                TipoDdl.DataTextField = "nombreTipo";
                TipoDdl.DataBind();
            }
        }

        protected void registrarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                String encargado = encargadoTxt.Text.Trim();
                int nroPtoCarga = Convert.ToInt32(numeroPtoTxt.Text.Trim());
                String nombreRegion = regionDdl.SelectedValue;
                String tipo = TipoDdl.SelectedValue;

                PuntoDeCarga s = new PuntoDeCarga();
                s.NumeroPuntoDeCarga = nroPtoCarga;
                s.Encargado = encargado;
                s.Region = nombreRegion;
                s.Tipo = tipo;

                PuntoDeCargaDAL puntoDeCargaDAL = new PuntoDeCargaDAL();
                puntoDeCargaDAL.Add(s);

                mensajeLbl.Text = "Punto de Carga Ingresado correctamente";
                limpiar();
            }
        }

        private void limpiar()
        {
            numeroPtoTxt.Text = null;
            encargadoTxt.Text = null;
        }
    }
}