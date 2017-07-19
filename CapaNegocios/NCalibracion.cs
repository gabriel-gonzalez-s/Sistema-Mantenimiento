using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NCalibracion
    {
        public static string Insertar(int Id_Instrumento, int Id_Identidad, int Id_Calibracion, DateTime Fec_Calibracion)
        {
            DCalibracion Obj = new DCalibracion();
            Obj.Id_Instrumento = Id_Instrumento;
            Obj.Id_Identidad = Id_Identidad;
            Obj.Id_Calibracion = Id_Calibracion;
            Obj.Fec_Calibracion = Fec_Calibracion;

            return Obj.Insertar(Obj);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIdentInstrumento
        //de la CapaDatos
        public static string Actualizar(int Id_Instrumento, int Id_Identidad, int Id_Calibracion, DateTime Fec_Calibracion)
        {
            DCalibracion Obj = new DCalibracion();
            Obj.Id_Instrumento = Id_Instrumento;
            Obj.Id_Identidad = Id_Identidad;
            Obj.Id_Calibracion = Id_Calibracion;
            Obj.Fec_Calibracion = Fec_Calibracion;

            return Obj.Actualizar(Obj);
        }


        //Método Listar que llama al método Listar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Listar(int Id_Instrumento, int Id_Identidad)
        {

            DCalibracion Obj = new DCalibracion();
            Obj.Id_Instrumento = Id_Instrumento;
            Obj.Id_Identidad = Id_Identidad;
            return new DCalibracion().Listar(Obj);
        }

        //Método Listar que llama al método Buscar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Buscar(int Id_Instrumento, int Id_Identidad, int Id_Calibracion)
        {
            DCalibracion Obj = new DCalibracion();
            Obj.Id_Instrumento = Id_Instrumento;
            Obj.Id_Identidad = Id_Identidad;
            Obj.Id_Calibracion = Id_Calibracion;
            return new DCalibracion().Buscar(Obj);
        }

        public static DataTable BuscarDetalles(int Id_Calibracion, int Id_Identidad, int Id_Instrumento)
        {
            DCalibracion Obj = new DCalibracion();
            Obj.Id_Instrumento = Id_Instrumento;
            Obj.Id_Identidad = Id_Identidad;
            Obj.Id_Calibracion = Id_Calibracion;
            return new DCalibracion().BuscarDetalles(Obj);
        }

        public static int ProximoCodigoIndividual(int Id_Instrumento, int Id_Identidad)
        {
            DCalibracion Obj = new DCalibracion();
            Obj.Id_Instrumento = Id_Instrumento;
            Obj.Id_Identidad = Id_Identidad;
            return new DCalibracion().ProximoCodigoCalibracion(Obj);
        }

    }
}
