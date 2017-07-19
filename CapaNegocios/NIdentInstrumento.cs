using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class NIdentInstrumento
    {

        public static string Insertar(int id_instrumento, int id_indivual, int Calib_Num, DateTime Ultima_Calib, DateTime Ingreso, string Estado, DateTime Prox_Calib, string Cod_Trab, string Nom_Trab, string Certificado, string Marca)
        {
            DIdentInstrumento Obj = new DIdentInstrumento();
           Obj.Id_instrumento = id_instrumento;
           Obj.Id_indivual = id_indivual;
           Obj.Calib_Num = Calib_Num;
           Obj.Ultima_Calib = Ultima_Calib;
           Obj.Ingreso = Ingreso;
           Obj.Estado = Estado;
           Obj.Prox_Calib = Prox_Calib;
           Obj.Cod_Trab = Cod_Trab;
           Obj.Nom_Trab = Nom_Trab;
           Obj.Certificado = Certificado;
           Obj.Marca = Marca;
           return Obj.Insertar(Obj);
        }

        //Método Actualizar que llama al método Actualizar de la clase DIdentInstrumento
        //de la CapaDatos
        public static string Actualizar(int id ,int id_instrumento, int id_indivual, int Calib_Num, DateTime Ultima_Calib, DateTime Ingreso, string Estado, DateTime Prox_Calib, string Cod_Trab, string Nom_Trab, string Certificado, string Marca)
        {
            DIdentInstrumento Obj = new DIdentInstrumento();
            Obj.Id = id;
            Obj.Id_instrumento = id_instrumento;
            Obj.Id_indivual = id_indivual;
            Obj.Calib_Num = Calib_Num;
            Obj.Ultima_Calib = Ultima_Calib;
            Obj.Ingreso = Ingreso;
            Obj.Estado = Estado;
            Obj.Prox_Calib = Prox_Calib;
            Obj.Cod_Trab = Cod_Trab;
            Obj.Nom_Trab = Nom_Trab;
            Obj.Certificado = Certificado;
            Obj.Marca = Marca;

            return Obj.Actualizar(Obj);
        }

        //Método Eliminar que llama al método Eliminar de la clase DIdentInstrumento
        //de la CapaDatos
        public static string Eliminar(int id_instrumento, int id_indivual)
        {
            DIdentInstrumento Obj = new DIdentInstrumento();
            Obj.Id_instrumento = id_instrumento;
            Obj.Id_indivual = id_indivual;
            return Obj.Eliminar(Obj);
        }

        //Método Listar que llama al método Listar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Listar(int Id_Instrumento)
        {

            DIdentInstrumento Obj = new DIdentInstrumento();
            Obj.Id_instrumento = Id_Instrumento;
            return new DIdentInstrumento().Listar(Obj);
        }

        //Método Listar que llama al método Buscar de la clase DIdentInstrumento
        //de la CapaDatos
        public static DataTable Buscar(int Id_Instrumento, int Id_Individual)
        {
            DIdentInstrumento Obj = new DIdentInstrumento();
            Obj.Id_instrumento = Id_Instrumento;
            Obj.Id_indivual = Id_Individual;
            return new DIdentInstrumento().Buscar(Obj);
        }

        public static int ProximoCodigoIndividual(int Id_Instrumento)
        {
            DIdentInstrumento Obj = new DIdentInstrumento();
            Obj.Id_instrumento = Id_Instrumento;
            return new DIdentInstrumento().ProximoCodigoIndividual(Obj);
        }

    }
}
