using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DIdentInstrumento
    {

        private int _Id ;
        private int _Id_instrumento ;
        private int _Id_indivual ;
        private int _Calib_Num ;
        private DateTime _Ultima_Calib ;
        private DateTime _Ingreso ;
        private string _Estado ;
        private DateTime _Prox_Calib  ;
        private string _Cod_Trab ;
        private string _Nom_Trab ;
        private string _Certificado ;
        private string _Marca ;

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

        public int Id_instrumento
        {
            get
            {
                return _Id_instrumento;
            }
            set
            {
                _Id_instrumento = value;
            }
        }

        public int Id_indivual
        {
            get
            {
                return _Id_indivual;
            }
            set
            {
                _Id_indivual = value;
            }
        }

        public int Calib_Num
        {
            get
            {
                return _Calib_Num;
            }
            set
            {
                _Calib_Num = value;
            }
        }

        public DateTime Ultima_Calib
        {
            get
            {
                return _Ultima_Calib;
            }
            set
            {
                _Ultima_Calib = value;
            }
        }

        public DateTime Ingreso
        {
            get
            {
                return _Ingreso;
            }
            set
            {
                _Ingreso = value;
            }
        }

        public String Estado
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

        public DateTime Prox_Calib
        {
            get
            {
                return _Prox_Calib;
            }
            set
            {
                _Prox_Calib = value;
            }
        }

        public String Cod_Trab
        {
            get
            {
                return _Cod_Trab;
            }
            set
            {
                _Cod_Trab = value;
            }
        }

        public String Nom_Trab
        {
            get
            {
                return _Nom_Trab;
            }
            set
            {
                _Nom_Trab = value;
            }
        }

        public String Certificado
        {
            get
            {
                return _Certificado;
            }
            set
            {
                _Certificado = value;
            }
        }

        public String Marca
        {
            get
            {
                return _Marca;
            }
            set
            {
                _Marca = value;
            }
        }


        public DIdentInstrumento()
        {
        }


        public DIdentInstrumento(int id, int id_instrumento, int id_indivual, int Calib_Num, DateTime Ultima_Calib, DateTime Ingreso, string Estado, DateTime Prox_Calib, string Cod_Trab, string Nom_Trab, string Certificado, string Marca)
        { 
            _Id = Id;
            _Id_instrumento = Id_instrumento;
            _Id_indivual = Id_indivual;
            _Calib_Num = Calib_Num;
            _Ultima_Calib = Ultima_Calib;
            _Ingreso = Ingreso;
            _Estado = Estado;
            _Prox_Calib = Prox_Calib;
            _Cod_Trab = Cod_Trab;
            _Nom_Trab = Nom_Trab;
            _Certificado = Certificado;
            _Marca = Marca;
        }

        public string Insertar(DIdentInstrumento Ident_Instrumento)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_InstrumentoInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.AddWithValue("@ID", Ident_Instrumento.Id);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Ident_Instrumento.Id_instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_INDIVUAL", Ident_Instrumento.Id_indivual);
                SqlCmd.Parameters.AddWithValue("@CALIB_NUM", Ident_Instrumento.Calib_Num);
                SqlCmd.Parameters.AddWithValue("@ULTIMA_CALIB", Ident_Instrumento.Ultima_Calib);
                SqlCmd.Parameters.AddWithValue("@INGRESO", Ident_Instrumento.Ingreso);
                SqlCmd.Parameters.AddWithValue("@ESTADO", Ident_Instrumento.Estado);
                SqlCmd.Parameters.AddWithValue("@PROX_CALIB", Ident_Instrumento.Prox_Calib);
                SqlCmd.Parameters.AddWithValue("@COD_TRAB", Ident_Instrumento.Cod_Trab);
                SqlCmd.Parameters.AddWithValue("@NOM_TRAB", Ident_Instrumento.Nom_Trab);
                SqlCmd.Parameters.AddWithValue("@CERTIFICADO", Ident_Instrumento.Certificado);
                SqlCmd.Parameters.AddWithValue("@MARCA", Ident_Instrumento.Marca);

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

        public string Actualizar(DIdentInstrumento Ident_Instrumento)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_InstrumentoActualizar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.AddWithValue("@ID", Ident_Instrumento.Id);
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Ident_Instrumento.Id_instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_INDIVUAL", Ident_Instrumento.Id_indivual);
                SqlCmd.Parameters.AddWithValue("@CALIB_NUM", Ident_Instrumento.Calib_Num);
                SqlCmd.Parameters.AddWithValue("@ULTIMA_CALIB", Ident_Instrumento.Ultima_Calib);
                SqlCmd.Parameters.AddWithValue("@INGRESO", Ident_Instrumento.Ingreso);
                SqlCmd.Parameters.AddWithValue("@ESTADO", Ident_Instrumento.Estado);
                SqlCmd.Parameters.AddWithValue("@PROX_CALIB", Ident_Instrumento.Prox_Calib);
                SqlCmd.Parameters.AddWithValue("@COD_TRAB", Ident_Instrumento.Cod_Trab);
                SqlCmd.Parameters.AddWithValue("@NOM_TRAB", Ident_Instrumento.Nom_Trab);
                SqlCmd.Parameters.AddWithValue("@CERTIFICADO", Ident_Instrumento.Certificado);
                SqlCmd.Parameters.AddWithValue("@MARCA", Ident_Instrumento.Marca);

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

        public string Eliminar(DIdentInstrumento Ident_Instrumento)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_InstrumentoEliminar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.AddWithValue("@ID", Ident_Instrumento.Id);

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

        public DataTable Listar(DIdentInstrumento Ident_Instrumento)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_InstrumentoListar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Ident_Instrumento.Id_instrumento);

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

        public DataTable Buscar(DIdentInstrumento Ident_Instrumento)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_InstrumentoObtener";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Ident_Instrumento.Id_instrumento);
                SqlCmd.Parameters.AddWithValue("@ID_INDIVUAL", Ident_Instrumento.Id_indivual);

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

        public int ProximoCodigoIndividual(DIdentInstrumento Ident_Instrumento)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpIdent_InstrumentoProximoCodigoIndividual";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.AddWithValue("@ID_INSTRUMENTO", Ident_Instrumento.Id_instrumento);

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
