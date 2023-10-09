using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    class DatosStock : DatosConexionBD
    {
        #region ABM
        public int abmStock(string accion, string Nivel, Stock objStock, string delete) //accion= accion a realizar/ Nivel: numero de nivel a tocar
        {
            int Resultado = -1;
            string orden = string.Empty;


            switch (accion)
            {
                case "Agregar":
                    switch (Nivel)
                    {
                        case "MP":
                            orden = "Insert Into stock(nombre_stock, cantidad_stock, Unidad_Medida, numero_factura)" +
                        "    Values('" + objStock.MateriaPrima1 + "', '" + objStock.CantidadMateria1 + "', '" + objStock.UnidadMedida1 + "', '" +
                                    objStock.NumeroFactura1 + "'," + objStock.FechaIngreso1 + ");";
                            break;
                        case "PF":
                            orden = "Insert Into stock(nombre_stock, cantidad_stock, Unidad_Medida, numero_factura)" +
                        "    Values('" + objStock.ProductoFinal1 + "', '" + objStock.CantidadProducto1 + "', '" + objStock.UnidadMedidaProducto1 + "', '" +
                                    objStock.NºLote1 + "'," + objStock.FechaFinalizacion1 + ");";
                            break;
                        case "C":
                            orden = "Insert Into stock(nombre_stock, cantidad_stock, Unidad_Medida, numero_factura)" +
                        "    Values('" + objStock.Contenedor1 + "', '" + objStock.CantidadContenedores1 + "', '" + objStock.UnidadMedidaContenedores1 + "', '" +
                                    objStock.TotalContenedores1 + ");";
                            break;
                    }
                    
                    break;
                case "Modificar":
                    switch (Nivel)
                    {
                        case "MP":
                            orden = "update stock set nombre_stock = '" + objStock.MateriaPrima1 + "', cantidad_stock = '" + objStock.CantidadMateria1 + "', Unidad_Medida = '" + objStock.UnidadMedida1 +
                            "', numero_factura = '" + objStock.NumeroFactura1 + "'" + "Where IdStock = '" + objStock.Stock_Id + "';";
                            break;
                        case "PF":
                            orden = "update stock set nombre_stock = '" + objStock.ProductoFinal1 + "', cantidad_stock = '" + objStock.CantidadProducto1 +
                                "', Unidad_Medida = '" + objStock.UnidadMedidaProducto1 + "', numero_factura = '" + objStock.NºLote1 + "'" + "Where IdStock = '" + objStock.Stock_Id + "';";
                            break;
                        case "C":
                            orden = "update stock set nombre_stock = '" + objStock.Contenedor1 + "', cantidad_stock = '" + objStock.CantidadContenedores1 +
                                "', Unidad_Medida = '" + objStock.UnidadMedidaContenedores1 + "', numero_factura = '" + objStock.NºLote1 + "'" + "Where IdStock = '" + objStock.Stock_Id + "';";
                            break;
                    }
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
