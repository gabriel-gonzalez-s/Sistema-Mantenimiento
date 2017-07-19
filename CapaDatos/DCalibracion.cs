using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCalibracion
    {

        int _Id;
        int _Id_Instrumento;
        int _Id_Identidad;
        int _Id_Calibracion;
        DateTime _Fec_Calibracion;

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

        public int Id_Instrumento
        {
            get
            {
                return _Id_Instrumento;
            }

            set
            {
                _Id_Instrumento = value;
            }
        }

        public int Id_Identidad
        {
            get
            {
                return _Id_Identidad;
            }

            set
            {
                _Id_Identidad = value;
            }
        }

        public int Id_Calibracion
        {
            get
            {
                return _Id_Calibracion;
            }

            set
            {
                _Id_Calibracion = value;
            }
        }

        public DateTime Fec_Calibracion
        {
            get
            {
                return _Fec_Calibracion;
            }

            set
            {
                _Fec_Calibracion = value;
            }
        }

        public DCalibracion()
        {

        }

        public DCalibracion(int Id, int Id_Instrumento,int Id_Identidad, int Id_Calibracion , DateTime Fec_Calibracion)
        {
            _Id = Id;
            _Id_Instrumento = Id_Instrumento;
            _Id_Identidad =  Id_Identidad;
            _Id_Calibracion = Id_Calibracion;
            _Fec_Calibracion = Fec_Calibracion;
        }

        public string Insertar(DCalibracion Calibracion)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.AddWithValue("@ID", Calibracion.Id);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@FEC_CALIBRACION", Calibracion.Fec_Calibracion);
               

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

        public string Actualizar(DCalibracion Calibracion)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionActualizar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.AddWithValue("@ID", Calibracion.Id);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@FEC_CALIBRACION", Calibracion.Fec_Calibracion);

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

        public DataTable Listar(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionListar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);

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

        public DataTable Buscar(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionObtener";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);

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

        public DataTable BuscarDetalles(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionObtenerDetalles";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_CALIBRACION", Calibracion.Id_Calibracion);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);

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

        public int ProximoCodigoCalibracion(DCalibracion Calibracion)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpCalibracionProximoCodigo";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Calibracion.Id_Instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_IDENTIDAD", Calibracion.Id_Identidad);

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
            return Convert.ToInt32(DtResultado.Rows[0][0]);
        }

    }
}
