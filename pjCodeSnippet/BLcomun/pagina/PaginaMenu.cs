using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using BLdatos;



namespace BLcomun.pagina
{
    public class PaginaMenu
    {
        //propiedades---------------------------------------------------------------------------
        private String cvlLogin_;
        private String cvlPwd_;

        public String cvlLogin
        {
            get { return cvlLogin_; }
            set { cvlLogin_ = value; }
        }
        public String cvlPwd
        {
            get { return cvlPwd_; }
            set { cvlPwd_ = value; }
        }


        //Constructor---------------------------------------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public PaginaMenu()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vlUsuario">Login del usuario conectado</param>
        public PaginaMenu(String vlUsuario)
        { 
                    
        }



        //Metodos -----------------------------------------------------------------------------
        /// <summary>
        /// Consulta por tabla Menu
        /// </summary>
        /// <returns></returns>
        public DataTable Met_OpcionMenu()
        {
            String vlUpd = "sp_CargaMenu";
            String vlLogin = "XXX";
            DataTable dtSalida;

            UtilsSN callService = new UtilsSN(vlUpd);
            TipoParametro vlTp = new TipoParametro();

            callService.AddParam("inLoginUsuario", vlTp.TipoParametroCadena, vlLogin, 100);

            dtSalida = callService.GETwebExecServSP();

            return dtSalida;
        }

        /// <summary>
        /// Consulta Categoria y snippet 
        /// </summary>
        /// <returns>Nombre Categoria | total snippet</returns>
        public DataTable Met_OpcionCategoria()
        {
            String vlUpd = "sp_CargaMenuCategoria";            
            DataTable dtSalida;

            UtilsSN callService = new UtilsSN(vlUpd);
            
            dtSalida = callService.GETwebExecServSP();

            return dtSalida;                
        }

        public DataTable  Met_OptenerFooter(String vlCadena)
        {            
            String vlUpd = "sp_CargaFooter";
            DataTable dtSalida;

            UtilsSN callService = new UtilsSN(vlUpd);
            TipoParametro tp_ = new TipoParametro();

            callService.AddParam("v_prm_titulo", tp_.TipoParametroCadena, vlCadena, 100);
            
            dtSalida = callService.GETwebExecServSP();

            return dtSalida;     

        }

        public DataTable Met_OptenerTexoPaginaInicio()
        {
            String vlUpd = "sp_CargaTextoPaginaInicio";
            DataTable dtSalida;

            UtilsSN callService = new UtilsSN(vlUpd);
            
            dtSalida = callService.GETwebExecServSP();

            return dtSalida;     
        }




    }
}
