using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLcomun;
using BLnegocio;
using System.Data;

namespace websiteCodeSnippet.controlesUsuarios
{
    public partial class panelFooter : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // para control del postaback

            if (!IsPostBack )
            {
                CargaFooter();
            }

        }


        private void CargaFooter()
        {
            String vlCadena = "footer";
            String vlSalida;
            DataTable dtFooter;

            BLcomun.pagina.PaginaMenu clsCargaCategoria = new BLcomun.pagina.PaginaMenu();
            dtFooter = clsCargaCategoria.Met_OptenerFooter(vlCadena);

            // solo es una cadena
            vlSalida = dtFooter.Rows[0]["prm_glosa"].ToString();

            //poner en objeto
            this.lbl_Footer.Text = vlSalida;

            dtFooter = null;

        }

    



    }
}