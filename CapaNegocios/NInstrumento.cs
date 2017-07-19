using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NInstrumento
    {
        //Método Insertar que llama al método Insertar de la clase DIntrumento
        //de la CapaDatos
        public static string Insertar(string codigo, string descripcion, string frecuenciaNvo, string frecuenciaUsa, string estado)
        {
            DIntrumento Obj = new DIntrumento();
            Obj.Codigo = codigo;
            Obj.Descripcion = descripcion;
            Obj.Frecuencia_Nvo = frecuenciaNvo;
            Obj.Frecuencia_Usa = frecuenciaUsa;
            Obj.Estado = estado;
            Obj.Fecha_Creacion = new DateTime(1900, 01, 01); // > new DateTime(1900,01,01) ? Instrumento.Fecha_Creacion  : new DateTime(1900, 01, 01)
            Obj.Usu_Creacion = "";
            Obj.Fecha_Modifi = new DateTime(1900, 01, 01);
            Obj.Usu_Modif = "";
            return Obj.Insertar(Obj);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIntrumento
        //de la CapaDatos
        public static string Actualizar(int idinstrumento, string codigo, string descripcion, string frecuenciaNvo, string frecuenciaUsa, string estado)
        {
            DIntrumento Obj = new DIntrumento();
            Obj.Id = idinstrumento;
            Obj.Codigo = codigo;
            Obj.Descripcion = descripcion;
            Obj.Frecuencia_Nvo = frecuenciaNvo;
            Obj.Frecuencia_Usa = frecuenciaUsa;
            Obj.Estado = estado;
            Obj.Fecha_Creacion = new DateTime(1900, 01, 01); // > new DateTime(1900,01,01) ? Instrumento.Fecha_Creacion  : new DateTime(1900, 01, 01)
            Obj.Usu_Creacion = "";
            Obj.Fecha_Modifi = new DateTime(1900, 01, 01); 
            Obj.Usu_Modif = "";

            return Obj.Actualizar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DIntrumento
        //de la CapaDatos
        public static string Eliminar(int idinstrumento, string codigo)
        {
            DIntrumento Obj = new DIntrumento();
            Obj.Id = idinstrumento;
            Obj.Codigo = codigo;
            return Obj.Eliminar(Obj);
        }

        //Método Listar que llama al método Listar de la clase DIntrumento
        //de la CapaDatos
        public static DataTable Listar()
        {
            return new DIntrumento().Listar();
        }

        public static DataTable Buscar(int idinstrumento)
        {
            DIntrumento Obj = new DIntrumento();
            Obj.Id = idinstrumento;
            return new DIntrumento().Buscar(Obj);
        }
    }
}
