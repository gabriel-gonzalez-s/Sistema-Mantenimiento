using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DIntrumento
    {

        private int _Id;
        private string _Codigo ;
        private string _Descripcion ;
        private string _Frecuencia_Nvo ;
        private string _Frecuencia_Usa ;
        private string _Estado ;
        private DateTime _Fecha_Creacion ;
        private string _Usu_Creacion ;
        private DateTime _Fecha_Modifi ;
        private string _Usu_Modif ;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Codigo
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

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public string Frecuencia_Nvo
        {
            get
            {
                return _Frecuencia_Nvo;
            }

            set
            {
                _Frecuencia_Nvo = value;
            }
        }

        public string Frecuencia_Usa
        {
            get
            {
                return _Frecuencia_Usa;
            }

            set
            {
                _Frecuencia_Usa = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public DateTime Fecha_Creacion
        {
            get
            {
                return _Fecha_Creacion;
            }

            set
            {
                _Fecha_Creacion = value;
            }
        }

        public string Usu_Creacion
        {
            get
            {
                return _Usu_Creacion;
            }

            set
            {
                _Usu_Creacion = value;
            }
        }

        public DateTime Fecha_Modifi
        {
            get
            {
                return _Fecha_Modifi;
            }

            set
            {
                _Fecha_Modifi = value;
            }
        }

        public string Usu_Modif
        {
            get
            {
                return _Usu_Modif;
            }

            set
            {
                _Usu_Modif = value;
            }
        }


        //Constructor Vacio
        public DIntrumento()
        {
        }

        //Constructor con Paramentros.
        public DIntrumento(int id, string Codigo, string Descripcion, string Frecuencia_Nvo, string Frecuencia_Usa, string Estado, DateTime Fecha_Creacion, string Usu_Creacion, DateTime Fecha_Modifi, string Usu_Modif)
        {
            _Id = Id;
            _Codigo = Codigo;
            _Descripcion = Descripcion;
            _Frecuencia_Nvo = Frecuencia_Nvo;
            _Frecuencia_Usa = Frecuencia_Usa;
            _Estado = Estado;
            _Fecha_Creacion = Fecha_Creacion;
            _Usu_Creacion = Usu_Creacion;
            _Fecha_Modifi = Fecha_Modifi;
            _Usu_Modif = Usu_Modif;
        }

        public string Insertar(DIntrumento Instrumento)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstrumentoInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@ID", Instrumento.Id));
                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", Instrumento.Codigo));
                SqlCmd.Parameters.Add(new SqlParameter("@DESCRIPCION", Instrumento.Descripcion));
                SqlCmd.Parameters.Add(new SqlParameter("@FRECUENCIA_NVO", Instrumento.Frecuencia_Nvo));
                SqlCmd.Parameters.Add(new SqlParameter("@FRECUENCIA_USA", Instrumento.Frecuencia_Usa));
                SqlCmd.Parameters.Add(new SqlParameter("@ESTADO", Instrumento.Estado));
                SqlCmd.Parameters.Add(new SqlParameter("@FECHA_CREACION", Instrumento.Fecha_Creacion));
                SqlCmd.Parameters.Add(new SqlParameter("@USU_CREACION", Instrumento.Usu_Creacion));
                SqlCmd.Parameters.Add(new SqlParameter("@FECHA_MODIFI", Instrumento.Fecha_Modifi));
                SqlCmd.Parameters.Add(new SqlParameter("@USU_MODIF", Instrumento.Usu_Modif));

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

        public string Actualizar(DIntrumento Instrumento)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstrumentoActualizar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@ID", Instrumento.Id));
                SqlCmd.Parameters.Add(new SqlParameter("@CODIGO", Instrumento.Codigo));
                SqlCmd.Parameters.Add(new SqlParameter("@DESCRIPCION", Instrumento.Descripcion));
                SqlCmd.Parameters.Add(new SqlParameter("@FRECUENCIA_NVO", Instrumento.Frecuencia_Nvo));
                SqlCmd.Parameters.Add(new SqlParameter("@FRECUENCIA_USA", Instrumento.Frecuencia_Usa));
                SqlCmd.Parameters.Add(new SqlParameter("@ESTADO", Instrumento.Estado));
                SqlCmd.Parameters.Add(new SqlParameter("@FECHA_CREACION", Instrumento.Fecha_Creacion));
                SqlCmd.Parameters.Add(new SqlParameter("@USU_CREACION", Instrumento.Usu_Creacion));
                SqlCmd.Parameters.Add(new SqlParameter("@FECHA_MODIFI", Instrumento.Fecha_Modifi));
                SqlCmd.Parameters.Add(new SqlParameter("@USU_MODIF", Instrumento.Usu_Modif));

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

        public string Eliminar(DIntrumento Instrumento)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstrumentoEliminar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@ID", Instrumento.Id));

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
                string sp = "SpInstrumentoListar";

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

        public DataTable Buscar(DIntrumento Instrumento)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstrumentoObtener";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@Id", Instrumento.Id));

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


    }
}
