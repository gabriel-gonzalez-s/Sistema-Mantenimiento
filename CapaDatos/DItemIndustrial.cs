using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DItemIndustrial
    {
        private string _TextoBuscar;

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        public DItemIndustrial()
        {

        }

        public DItemIndustrial(string TextoBuscar)
        {
            this.TextoBuscar = TextoBuscar;
        }

        public DataTable Listar()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItemsIndustrialListar";

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

        public DataTable Buscar(DItemIndustrial Item)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "SpItemsIndustrialBuscar";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@Cadena", Item.TextoBuscar));

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
