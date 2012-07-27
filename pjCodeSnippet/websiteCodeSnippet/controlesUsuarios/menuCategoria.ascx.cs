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
    public partial class menuCategoria : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //controlar para post back
            if (!IsPostBack)
            {
                CargaMenuCategoria();
            }
        }


        /// <summary>
        /// Carga las categorias y la cantidad ingresadas
        /// </summary>
        private void CargaMenuCategoria()
        {
            //
            String vlCadena;
            String vlCadenaTotal;
            DataTable dtMenu;

            BLcomun.pagina.PaginaMenu clsCargaCategoria = new BLcomun.pagina.PaginaMenu();
            dtMenu = clsCargaCategoria.Met_OpcionCategoria(); 

            foreach (DataRow mifila in dtMenu.Rows)
            {
                //this.listaMenu.Items.Add(new ListItem( mifila["mnu_titulo"].ToString(),
                //                                       "<a href=\"#\" accesskey=\"1\" title=\"\">" + mifila["mnu_titulo"].ToString() + "</a>"));
                vlCadena      = mifila["cat_nombre"].ToString();
                vlCadenaTotal = mifila["cat_nombre"].ToString() + " (" + mifila["totalCategoria"].ToString() + ")";

                this.listaCategoria.Items.Add(new ListItem(vlCadenaTotal, vlCadena));
                
            }
            dtMenu = null;

        }


    }
}