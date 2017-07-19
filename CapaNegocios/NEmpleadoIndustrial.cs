using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NEmpleadoIndustrial
    {
        //Método Listar que llama al método Listar de la clase DEmpleadoIndustrial
        //de la CapaDatos
        public static DataTable Listar()
        {
            return new DEmpleadoIndustrial().Listar();
        }

        //Método Listar que llama al método Buscar de la clase DEmpleadoIndustrial
        //de la CapaDatos
        public static DataTable Buscar(string TextoBuscar)
        {
            DEmpleadoIndustrial Obj = new DEmpleadoIndustrial();
            Obj.TextoBuscar = TextoBuscar;
            return Obj.Buscar(Obj);
        }

    }
}
