using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocios
{
    public class NFrecuencia
    {
        //Método Listar que llama al método Listar de la clase DFrecuencia
        //de la CapaDatos
        public static DataTable Listar()
        {
            return new DFrecuencia().Listar();
        }

        public static DataTable Buscar(string Frecuencia)
        {
            return new DFrecuencia().Buscar(Frecuencia);
        }
    }
}
