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
    public class NItemIndustrial
    {
        //Método Listar que llama al método Listar de la clase DItemIndustrial
        //de la CapaDatos
        public static DataTable Listar()
        {
            return new DItemIndustrial().Listar();
        }

        public static DataTable Buscar(string TextoBuscar)
        {
            DItemIndustrial Obj = new DItemIndustrial();
            Obj.TextoBuscar = TextoBuscar;
            return Obj.Buscar(Obj);
        }

    }
}
