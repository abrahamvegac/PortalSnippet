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
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        //propiedades
        private String vlPaginaActual_;
        public String vlPaginaActual 
        {
            get {return vlPaginaActual_;}
            set {vlPaginaActual_ = value ;}
        }
                    

        /// <summary>
        /// Carga inicial de Control de Usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // ver para controlar el postback
           
            // Carga el menu

            if (!IsPostBack)
            {
                CargaMenu();
            }

        }

        //METODOS --------------------------------------------------
        private void CargaMenu()
        { 
            //
            DataTable dtMenu;
            
            BLcomun.pagina.PaginaMenu clsCargaMenu = new BLcomun.pagina.PaginaMenu();
            clsCargaMenu.cvlLogin = "XXX";
                        
            dtMenu = clsCargaMenu.Met_OpcionMenu();

            foreach (DataRow mifila in dtMenu.Rows )
            {
                //this.listaMenu.Items.Add(new ListItem( mifila["mnu_titulo"].ToString(),
                //                                       "<a href=\"#\" accesskey=\"1\" title=\"\">" + mifila["mnu_titulo"].ToString() + "</a>"));

                this.listaMenu.Items.Add(new ListItem(mifila["mnu_titulo"].ToString(),
                                                       mifila["mnu_titulo"].ToString()));                
            }
            dtMenu = null;
        }

        protected void listaMenu_Click(object sender, BulletedListEventArgs e)
        {
            // se realizo un click en el control
            // sacar con TEXT

            Console.WriteLine(this.listaMenu.Items[e.Index].Value + " " + this.listaMenu.Items[e.Index].Text );  
            

        }


    }
}