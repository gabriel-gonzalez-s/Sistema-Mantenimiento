using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NItemComprobacion
    {
        //Método Insertar que llama al método Insertar de la clase DIntrumento
        //de la CapaDatos
        public static string Insertar(string Metodo, string Unidad, double Rango, double Resolucion, double Criterio)
        {
            DItemComprobacion Obj = new DItemComprobacion();
            Obj.Metodo = Metodo;
            Obj.Unidad = Unidad;
            Obj.Rango = Rango;
            Obj.Resolucion = Resolucion;
            Obj.Criterio = Criterio;
            return Obj.Insertar(Obj);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIntrumento
        //de la CapaDatos
        public static string Actualizar(int Codigo, string Metodo, string Unidad, double Rango, double Resolucion, double Criterio)
        {
            DItemComprobacion Obj = new DItemComprobacion();
            Obj.Codigo = Codigo;
            Obj.Metodo = Metodo;
            Obj.Unidad = Unidad;
            Obj.Rango = Rango;
            Obj.Resolucion = Resolucion;
            Obj.Criterio = Criterio;
            return Obj.Actualizar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DIntrumento
        //de la CapaDatos
        public static string Eliminar(int Codigo)
        {
            DItemComprobacion Obj = new DItemComprobacion();
            Obj.Codigo = Codigo;
            return Obj.Eliminar(Obj);
        }

        //Método Listar que llama al método Listar de la clase DIntrumento
        //de la CapaDatos
        public static DataTable Listar()
        {
            return new DItemComprobacion().Listar();
        }

        public static DataTable Ultimo()
        {
            return new DItemComprobacion().Ultimo();
        }

        public static int ProximoCodigo()
        {
            return new DItemComprobacion().ProximoCodigo();
        }

    }
}
