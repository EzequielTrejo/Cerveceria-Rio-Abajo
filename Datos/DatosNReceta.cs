using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    class DatosRecetas : DatosConexionBD
    {
        #region ABM
        public int abmRecetas(string accion, string Nivel, RecetaNueva objRecetas, string delete) //accion= accion a realizar
        {
            int Resultado = -1;
            string orden = string.Empty;


            switch (accion)
            {
                case "Agregar":

                    orden = "Insert Into receta(nombre_stock, cantidad_stock, Unidad_Medida, numero_factura)" + "Values('" + objRecetas.MateriaPrima1 + "', '" + objRecetas.CantidadMateria1 + "', '" + 
                        objRecetas.UnidadMedida1 + "', '" + objRecetas.NumeroFactura1 + "'," + objRecetas.FechaIngreso1 + ");";
                    break;
                case "Modificar":

                    orden = "update stock set nombre_stock = '" + objRecetas.MateriaPrima1 + "', cantidad_stock = '" + objRecetas.CantidadMateria1 + "', Unidad_Medida = '" + objRecetas.UnidadMedida1 +
                            "', numero_factura = '" + objRecetas.NumeroFactura1 + "'" + "Where IdStock = '" + objRecetas.Stock_Id + "';";
                    break;
                case "Borrar":
                    orden = "delete from stock where StockId = '" + delete + "';";
                    break;
            }

            SqlCommand cmd = new SqlCommand(orden, Conexion);

            try
            {
                AbrirConexion();
                Resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de Guardar, Modificar o Borrar el Alumno", e);
                ;
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return Resultado;
        }
        #endregion
    }
}
