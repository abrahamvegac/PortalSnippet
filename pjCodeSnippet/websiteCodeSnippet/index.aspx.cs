using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLcomun;
using BLnegocio;
using System.Data;

namespace websiteCodeSnippet
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarContenidoPagina();
            }
        }




        //METODOS DE LA PAGINA ------------------------------------------------------------------------
        private void CargarContenidoPagina()
        {
            String vlCadenaTitulo;
            String vlCadenaCuerpo;
            
            DataTable dttextoInicio;

            BLcomun.pagina.PaginaMenu clsCargatextoInicio = new BLcomun.pagina.PaginaMenu();
            dttextoInicio = clsCargatextoInicio.Met_OptenerTexoPaginaInicio();

            vlCadenaTitulo = dttextoInicio.Rows[0]["prm_glosa"].ToString();
            vlCadenaCuerpo = dttextoInicio.Rows[1]["prm_glosa"].ToString();

            this.lbl_titulopanel.Text = vlCadenaTitulo;
            this.lbl_cuerpopanel.Text = vlCadenaCuerpo;

            dttextoInicio = null;
        }


    }
}