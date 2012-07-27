using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Collections;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Logging; 

namespace BLdatos
{
    public class UtilsSN
    {

        //def proiedades
        private string st_procedimiento = String.Empty;
        private Hashtable ht_parametros;
        private DataSet ds_tablasalida;
        private DataTable dt_TablaSalida;
        public string mensaje_error = String.Empty;

        public int Count = -99;


        public DataTable dt_TablaSalida_
        {
            get { return dt_TablaSalida; }
        }


        //Constructor
        public UtilsSN()
        {
            ht_parametros = new Hashtable();
            ds_tablasalida = new DataSet();
            dt_TablaSalida = new DataTable();
            dt_TablaSalida.TableName = "TBL_SALIDA";

            // Para controlar la salida en error 
            DataRow dr_;
            DataColumn dc_;
            dc_ = new DataColumn("Error");
            dt_TablaSalida.Columns.Add(dc_);
            dc_ = new DataColumn("Descripcion");
            dt_TablaSalida.Columns.Add(dc_);
            dr_ = dt_TablaSalida.NewRow();

        }


        public UtilsSN(string vl_procedimiento)
        {
            this.st_procedimiento = vl_procedimiento;
            ht_parametros = new Hashtable();
            ds_tablasalida = new DataSet();
            dt_TablaSalida = new DataTable();
            dt_TablaSalida.TableName = "TBL_SALIDA";

            // Para controlar la salida en error 
            DataRow dr_;
            DataColumn dc_;
            dc_ = new DataColumn("Error");
            dt_TablaSalida.Columns.Add(dc_);
            dc_ = new DataColumn("Descripcion");
            dt_TablaSalida.Columns.Add(dc_);
            dr_ = dt_TablaSalida.NewRow();
        }


        //Metodos -------------------------------------------------------------------------------------------
        // PARA CARGAR LOS PARAMETROS
        /// <summary>
        /// Agrega Parametros para Procedimiento
        /// </summary>
        /// <param name="camponombre">Nopmbre Columna</param>
        /// <param name="campotipo">Tipo de Dato mismo tabla</param>
        /// <param name="campovalor">Valor a agregar</param>
        /// <param name="campolargo">Largo del Campo mismo DB</param>
        public void AddParam(string camponombre, System.Data.DbType campotipo, string campovalor, int campolargo)
        {
            try
            {
                Parametro objParametro = new Parametro();
                objParametro.parametro_nombre = "@" + camponombre;
                objParametro.parametro_largo = campolargo;
                objParametro.parametro_tipo = campotipo;
                objParametro.parametro_valor = campovalor;

                ht_parametros.Add(camponombre, objParametro);
            }
            catch (Exception ex)
            {
                //String cdLg = "UtilsSN(AddParam) -- ";
                //EvLog mLog = new EvLog();
                //mLog.InsertaArchivo(cdLg + ex.Message.ToString());
                //mLog = null;

                //Asignar Valor a Error 
                dt_TablaSalida.Rows[0][0] = "-1";
                dt_TablaSalida.Rows[0][1] = ex.Message.ToString();
                throw ex;
            }
        }


        // PARA RECUPERAR LOS DATOS 
        /// <summary>
        /// Para Ejetutar Procedimiento SELECT
        /// </summary>
        /// <returns>DataTable de Salida</returns>
        public DataTable GETwebExecServSP()
        {
            DataTable dtSalida;
            try
            {
                Database vl_db = DatabaseFactory.CreateDatabase(Conexion.cadenaConexion);
                DbCommand vl_dbCommand = vl_db.GetStoredProcCommand(st_procedimiento);

                foreach (Parametro prm in ht_parametros.Values)
                {
                    vl_db.AddInParameter(vl_dbCommand, prm.parametro_nombre, prm.parametro_tipo, prm.parametro_valor);
                }

                DataSet ds = null;
                ds = vl_db.ExecuteDataSet(vl_dbCommand);
                dtSalida = ds.Tables[0];
                dtSalida.TableName = "TBL_SALIDA";

                if (dtSalida.Rows.Count == 0)
                {
                    dtSalida = null;
                }
            }
            catch (Exception ex)
            {
                //String cdLg = "UtilsSN(GETwebExecServSP) -- ";
                //EvLog mLog = new EvLog();
                //mLog.InsertaArchivo(cdLg + ex.Message.ToString());
                //mLog = null;

                //Asignar Valor a Error 
                dt_TablaSalida.Rows.Add("-1", ex.Message.ToString());                  
                dtSalida = dt_TablaSalida;

                //throw ex;
            }
            finally
            {
                ht_parametros = null;
            }
            return dtSalida;
        }

        //
        // PARA INSERTAR, MODIFICAR, ELIMINAR DATOS 
        /// <summary>
        /// Para Ejecutar Procedimeinto INSERT, UPDATE, DELETE
        /// </summary>
        /// <returns>1:Correcto | -1:Error ejec.</returns>
        public int SETwebExecServSP()
        {
            int intSalida = 0;
            try
            {
                Database vl_db = DatabaseFactory.CreateDatabase(Conexion.cadenaConexion);
                DbCommand vl_dbCommand = vl_db.GetStoredProcCommand(st_procedimiento);

                foreach (Parametro prm in ht_parametros.Values)
                {
                    vl_db.AddInParameter(vl_dbCommand, prm.parametro_nombre, prm.parametro_tipo, prm.parametro_valor);
                }

                //int exito = (int)vl_db.ExecuteScalar(vl_dbCommand);
                intSalida = vl_db.ExecuteNonQuery(vl_dbCommand) == 1 ? 1 : -1;
            }
            catch (Exception ex)
            {
                //String cdLg = "UtilsSN(SETwebExecServSP) -- ";
                //EvLog mLog = new EvLog();
                //mLog.InsertaArchivo(cdLg + ex.Message.ToString());
                //mLog = null;

                intSalida = -1;
                // Para controlar la salida en error 
                dt_TablaSalida.Rows[0][0] = "-1";
                dt_TablaSalida.Rows[0][1] = ex.Message.ToString();

                //throw ex;
            }
            return intSalida;
        }

        //
        /// <summary>
        /// Para Ejecutar Procedimeinto INSERT, UPDATE, DELETE
        /// </summary>
        /// <returns>STRING de salida PROC.</returns>
        public string SETwebExecServSPEscalar()
        {
            String strSalida = string.Empty;
            try
            {
                Database vl_db = DatabaseFactory.CreateDatabase(Conexion.cadenaConexion);
                DbCommand vl_dbCommand = vl_db.GetStoredProcCommand(st_procedimiento);

                foreach (Parametro prm in ht_parametros.Values)
                {
                    vl_db.AddInParameter(vl_dbCommand, prm.parametro_nombre, prm.parametro_tipo, prm.parametro_valor);
                }

                strSalida = (string)vl_db.ExecuteScalar(vl_dbCommand);

            }
            catch (Exception ex)
            {
                //String cdLg = "UtilsSN(SETwebExecServSPEscalar) -- ";
                //EvLog mLog = new EvLog();
                //mLog.InsertaArchivo(cdLg + ex.Message.ToString());
                //mLog = null;

                strSalida = "-1";
                // Para controlar la salida en error 
                dt_TablaSalida.Rows[0][0] = "-1";
                dt_TablaSalida.Rows[0][1] = ex.Message.ToString();

                //throw ex;

            }
            return strSalida;
        }

        /// <summary>
        /// Ejecuta UPD de Ins, Upd y Del 
        /// </summary>
        /// <returns>Objeto (int, string, etc) </returns> 
        public object SETwebExecServSPEscalarO()
        {
            Object vlObjSalida = null;
            try
            {
                Database vl_db = DatabaseFactory.CreateDatabase(Conexion.cadenaConexion);
                DbCommand vl_dbCommand = vl_db.GetStoredProcCommand(st_procedimiento);
                foreach (Parametro prm in ht_parametros.Values)
                {
                    vl_db.AddInParameter(vl_dbCommand, prm.parametro_nombre, prm.parametro_tipo, prm.parametro_valor);
                }
                vlObjSalida = vl_db.ExecuteScalar(vl_dbCommand);
            }
            catch (Exception ex)
            {
                //String cdLg = "UtilsSN(SETwebExecServSPEscalar) -- ";
                //EvLog mLog = new EvLog();
                //mLog.InsertaArchivo(cdLg + ex.Message.ToString());
                //mLog = null;

                vlObjSalida = (object)-1;

                // Para controlar la salida en error 
                dt_TablaSalida.Rows[0][0] = "-1";
                dt_TablaSalida.Rows[0][1] = ex.Message.ToString();

                //throw ex;
            }
            return vlObjSalida;
        }





        /// <summary>
        /// Retorna Tabla de salida 
        /// </summary>
        /// <returns>tabla Salida TBL_SALIDA</returns>
        public DataTable To_DataTable()
        {
            return dt_TablaSalida;
        }

    }


    // --------------------------------------------------------------------------------------------------
    // CLASE PARA PROCESOR LOS PARAMETROS
    /// <summary>
    /// 
    /// </summary>
    public class Parametro
    {
        #region Variables
        string _parametro_nombre;
        public string parametro_nombre
        {
            get { return _parametro_nombre; }
            set { _parametro_nombre = value; }
        }

        System.Data.DbType _parametro_tipo;
        public System.Data.DbType parametro_tipo
        {
            get { return _parametro_tipo; }
            set { _parametro_tipo = value; }
        }

        string _parametro_valor;
        public string parametro_valor
        {
            get { return _parametro_valor; }
            set { _parametro_valor = value; }
        }

        int _parametro_largo;
        public int parametro_largo
        {
            get { return _parametro_largo; }
            set { _parametro_largo = value; }
        }
        #endregion
    }
    // --------------------------------------------------------------------------------------------------
    // CLASE PARA LOS TIPOS DE DATOS
    /// <summary>
    /// Tipos de Datos Definidos
    /// </summary>
    public class TipoParametro
    {
        #region Variables
        System.Data.DbType _TipoParametroCadena;
        public System.Data.DbType TipoParametroCadena
        {
            get { return _TipoParametroCadena; }
            set { _TipoParametroCadena = value; }
        }

        System.Data.DbType _TipoParametroFecha;
        public System.Data.DbType TipoParametroFecha
        {
            get { return _TipoParametroFecha; }
            set { _TipoParametroFecha = value; }
        }

        System.Data.DbType _TipoParametroEntero;
        public System.Data.DbType TipoParametroEntero
        {
            get { return _TipoParametroEntero; }
            set { _TipoParametroEntero = value; }
        }

        System.Data.DbType _TipoParametroDecimal;
        public System.Data.DbType TipoParametroDecimal
        {
            get { return _TipoParametroDecimal; }
            set { _TipoParametroDecimal = value; }
        }

        System.Data.DbType _TipoParametroBinario;
        public System.Data.DbType TipoParametroBinario
        {
            get { return _TipoParametroBinario; }
            set { _TipoParametroBinario = value; }
        }

        System.Data.DbType _TipoParametroXml;
        public System.Data.DbType TipoParametroXml
        {
            get { return _TipoParametroXml; }
            set { _TipoParametroXml = value; }
        }

        System.Data.DbType _TipoParametroObjeto;
        public System.Data.DbType TipoParametroObjeto
        {
            get { return _TipoParametroObjeto; }
            set { _TipoParametroObjeto = value; }
        }

        System.Data.DbType _TipoParametroByte;
        public System.Data.DbType TipoParametroByte
        {
            get { return _TipoParametroByte; }
            set { _TipoParametroByte = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Contructor con la definicion de los parametros 
        /// </summary>
        public TipoParametro()
        {
            _TipoParametroCadena = System.Data.DbType.String;
            _TipoParametroEntero = System.Data.DbType.Int32;
            _TipoParametroFecha = System.Data.DbType.DateTime;
            _TipoParametroDecimal = System.Data.DbType.Decimal;
            _TipoParametroBinario = System.Data.DbType.Binary;
            _TipoParametroXml = System.Data.DbType.Xml;
            _TipoParametroObjeto = System.Data.DbType.Object;
            _TipoParametroByte = System.Data.DbType.Byte;
        }
        #endregion
    }
}
