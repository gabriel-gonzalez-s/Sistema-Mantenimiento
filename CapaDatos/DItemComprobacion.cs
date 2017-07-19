using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DItemComprobacion
    {

        private int _Codigo ;
        private string _Metodo ;
        private string _Unidad ;
        private double _Rango ;
        private double _Resolucion;
        private double _Criterio ;
        private int _InstruAsociado;

        public int Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }

        public string Metodo
        {
            get
            {
                return _Metodo;
            }
            set
            {
                _Metodo = value;
            }
        }

        public string Unidad
        {
            get
            {
                return _Unidad;
            }
            set
            {
                _Unidad = value;
            }
        }

        public double Rango
        {
            get
            {
                return _Rango;
            }
            set
            {
                _Rango = value;
            }
        }

        public double Resolucion
        {
            get
            {
                return _Resolucion;
            }
            set
            {
                _Resolucion = value;
            }
        }

        public double Criterio
        {
            get
            {
                return _Criterio;
            }
            set
            {
                _Criterio = value;
            }
        }

        public int InstruAsociado
        {
            get
            {
                return _InstruAsociado;
            }

            set
            {
                _InstruAsociado = value;
            }
        }

        public DItemComprobacion()
        {
        }

        public DItemComprobacion(int Codigo, string Metodo, string Unidad, double Rango, double Resolucion, double Criterio,int InstruAsociado)
        {
            _Codigo = Codigo;
            _Metodo = Metodo;
            _Unidad = Unidad;
            _Rango = Rango;
            _Resolucion = Resolucion;
            _Criterio = Criterio;
            _InstruAsociado = InstruAsociado;
        }

        public void Cargar(DItemComprobacion ItemComprobacion, ref DataRow dr)
        {
            try
            {
                ItemComprobacion.Codigo = (int)(dr["Codigo"] == DBNull.Value ? 0 : dr["Codigo"]);
                ItemComprobacion.Metodo =  (string)(dr["Metodo"] == DBNull.Value ? "" : dr["Metodo"]);
                ItemComprobacion.Unidad = (string)(dr["Unidad"] == DBNull.Value ? "" : dr["Unidad"]);
                ItemComprobacion.Rango = (double)(dr["Rango"] == DBNull.Value ? 0.0 : dr["Rango"]);
                ItemComprobacion.Resolucion = (double)(dr["Resolucion"] == DBNull.Value ? 0.0 : dr["Resolucion"]);
                ItemComprobacion.Criterio = (double)(dr["Criterio"] == DBNull.Value ? 0.0 : dr["Criterio"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Insertar(DItemComprobacion ItemComprobacion)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItem_CompInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                //[Instanciando parámetro de Salida.]
                //SqlParameter Codigo = new SqlParameter("@CODIGO", SqlDbType.Int);
                //Codigo.Direction = ParameterDirection.Output;
                //SqlCmd.Parameters.Add(Codigo);
                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", SqlDbType.Int, 8, Convert.ToString(ParameterDirection.Output))).Value=DBNull.Value;
                //SqlCmd.Parameters("@CODIGO").Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(new SqlParameter("@METODO", ItemComprobacion.Metodo));
                SqlCmd.Parameters.Add(new SqlParameter("@UNIDAD", ItemComprobacion.Unidad));
                SqlCmd.Parameters.Add(new SqlParameter("@RANGO", ItemComprobacion.Rango));
                SqlCmd.Parameters.Add(new SqlParameter("@RESOLUCION", ItemComprobacion.Resolucion));
                SqlCmd.Parameters.Add(new SqlParameter("@CRITERIO", ItemComprobacion.Criterio));

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }

            return rpta;
        }

        public string Actualizar(DItemComprobacion ItemComprobacion)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItem_CompActualizar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", ItemComprobacion.Codigo));
                SqlCmd.Parameters.Add(new SqlParameter("@METODO", ItemComprobacion.Metodo));
                SqlCmd.Parameters.Add(new SqlParameter("@UNIDAD", ItemComprobacion.Unidad));
                SqlCmd.Parameters.Add(new SqlParameter("@RANGO", ItemComprobacion.Rango));
                SqlCmd.Parameters.Add(new SqlParameter("@RESOLUCION", ItemComprobacion.Resolucion));
                SqlCmd.Parameters.Add(new SqlParameter("@CRITERIO", ItemComprobacion.Criterio));

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Modifico el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }

            return rpta;
        }

        public string Eliminar( DItemComprobacion ItemComprobacion)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItem_CompEliminar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", ItemComprobacion.Codigo));

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";

                return rpta;

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }

            return rpta;
        }

        public DataTable Listar()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItem_CompListar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch
            {
                DtResultado = null;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }
            return DtResultado;
        }

        
        public bool Obtener(DItemComprobacion ItemComprobacion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();
            try
            {
                string sp = "SpItem_CompObtener";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.SelectCommand.Parameters.Add(new SqlParameter("@CODIGO", ItemComprobacion.Codigo));

                DataTable dt = new DataTable();
                SqlDat.Fill(dt);

                if ((dt.Rows.Count == 1))
                {
                    DataRow dr = dt.Rows[0];
                    Cargar(ItemComprobacion, ref dr);
                }
                else {
                    throw new Exception("No se pudo obtener el registro");
                }

                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Ultimo()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItem_CompUltimo";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch
            {
                DtResultado = null;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }
            return DtResultado;
        }

        public int ProximoCodigo()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string comm = "SELECT IDENT_CURRENT ('[Item_Comp]') + 1;";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(comm, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch
            {
                DtResultado = null;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }
            return Convert.ToInt32(DtResultado.Rows[0][0]) ;
        }


    }
}
