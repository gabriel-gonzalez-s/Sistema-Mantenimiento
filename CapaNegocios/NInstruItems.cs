using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NInstruItems
    {

        public static string Insertar(int IdInstrumento , int IdItem , string Metodo, string Unidad, double Rango, double Resolucion, double Criterio)
        {
            DInstruItems Obj = new DInstruItems();
            Obj.Id_Instrumento = IdInstrumento;
            Obj.Id_Item_Comp = IdItem;
            Obj.Metodo = Metodo;
            Obj.Unidad = Unidad;
            Obj.Rango = Rango;
            Obj.Resolucion = Resolucion;
            Obj.Criterio = Criterio;
            return Obj.Insertar(Obj);
        }

        public static string Eliminar(int Instrumento)
        {
            DInstruItems Obj = new DInstruItems();
            Obj.Id_Instrumento = Instrumento;
            return Obj.Eliminar(Obj);
        }

        public static DataTable ListarNoAsignados(int Instrumento)
        {
            DInstruItems Obj = new DInstruItems();
            Obj.Id_Instrumento = Instrumento;
            return Obj.ListarNoAsignados(Obj);
        }

        public static DataTable ListarAsignados(int Instrumento)
        {
            DInstruItems Obj = new DInstruItems();
            Obj.Id_Instrumento = Instrumento;
            return Obj.ListarAsignados(Obj);
        }

    }
}
