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
    public partial class RegistrarEstaciones : System.Web.UI.Page
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
                String direccion = direccionTxt.Text.Trim();
                int nroEstacion = Convert.ToInt32(numeroTxt.Text.Trim());
                String nombreRegion = regionDdl.SelectedValue;
                String tipo = TipoDdl.SelectedValue;

                Estacion s = new Estacion();
                s.NumeroEstacion = nroEstacion;
                s.Direccion = direccion;
                s.Region = nombreRegion;
                s.Tipo = tipo;


                EstacioneDAL.DAL.EstacioneDAL estacioneDAL = new EstacioneDAL.DAL.EstacioneDAL();
                estacioneDAL.Add(s);

                mensajeLbl.Text = "Estacion Ingresada";
                limpiar();

            }
            else
            {

            }
        }
        
        private void limpiar()
        {
            direccionTxt.Text = null;
            numeroTxt.Text = null;

        }
    }
}