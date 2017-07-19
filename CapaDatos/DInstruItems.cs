using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DInstruItems 
    {

        private int _Id;
        private int _Id_Instrumento;
        private int _Id_Item_Comp;
        private string _Metodo;
        private string _Unidad;
        private double _Rango;
        private double _Resolucion;
        private double _Criterio;

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

        public int Id_Item_Comp
        {
            get
            {
                return _Id_Item_Comp;
            }

            set
            {
                _Id_Item_Comp = value;
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

        //Constructor Vacio
        public DInstruItems()
        {
        }

        //Constructor con Paramentros.
        public DInstruItems(int Id, int Id_Instrumento, int Id_Item_Comp, string Metodo, string Unidad, double Rango, double Resolucion, double Criterio)
        {
            _Id = Id;
            _Id_Instrumento = Id_Instrumento;
            _Id_Item_Comp = Id_Item_Comp;
            _Metodo = Metodo;
            _Unidad = Unidad;
            _Rango = Rango;
            _Resolucion = Resolucion;
            _Criterio = Criterio;
        }

        public string Insertar(DInstruItems Instru_Item)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstru_ItemInsertar";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                //[Instanciando parámetro de Salida.]
                //SqlCmd.Parameters.Add(new SqlParameter("@id", 0));
                SqlCmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int, 8, Convert.ToString(ParameterDirection.Output))).Value = DBNull.Value;
                SqlCmd.Parameters.Add(new SqlParameter("@id_Instrumento", Instru_Item.Id_Instrumento));
                SqlCmd.Parameters.Add(new SqlParameter("@id_Item_Comp", Instru_Item.Id_Item_Comp));
                SqlCmd.Parameters.Add(new SqlParameter("@METODO", Instru_Item.Metodo));
                SqlCmd.Parameters.Add(new SqlParameter("@UNIDAD", Instru_Item.Unidad));
                SqlCmd.Parameters.Add(new SqlParameter("@RANGO", Instru_Item.Rango));
                SqlCmd.Parameters.Add(new SqlParameter("@RESOLUCION", Instru_Item.Resolucion));
                SqlCmd.Parameters.Add(new SqlParameter("@CRITERIO", Instru_Item.Criterio));

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

        public string Eliminar(DInstruItems Instru_Item)
        {
            string rpta = "";
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstru_ItemEliminar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SlqCon.Open();

                SqlCmd.Parameters.Add(new SqlParameter("@Instru", Instru_Item.Id_Instrumento));

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

        public DataTable ListarNoAsignados(DInstruItems Instru_Item)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstru_ItemListarNoAsociados";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.SelectCommand.Parameters.Add(new SqlParameter("@Instru", Instru_Item.Id_Instrumento));

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

        public DataTable ListarAsignados(DInstruItems Instru_Item)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpInstru_ItemListarAsociados";
                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.SelectCommand.Parameters.Add(new SqlParameter("@Instru", Instru_Item.Id_Instrumento));

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
