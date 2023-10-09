using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    class DatosProduccion : DatosConexionBD
    {
        #region ABM
        public int abmProduccion(string accion, string Nivel, Produccion objProd, string delete) //accion= accion a realizar/ Nivel: numero de nivel a tocar
        {
            int Resultado = -1;
            string orden = string.Empty;


            switch (accion)
            {
                case "Agregar":
                    switch (Nivel)
                    {
                        case "REP":
                            orden = "Insert Into RecetasEnProceso(Receta_En_Proceso, Proceso_Activo, Fecha_Inicio, Fecha_Fianlizacion, Estado_Actual)" + "Values('" + objProd.RecetaEnProceso1 + 
                                "', '" + objProd.ProcesoActivo1 + "', '" + objProd.FechaInicio1 + "', '" + objProd.FechaFinalizacionProceso1 + "'," + objProd.EstadoActual1 + "'," + ");";
                            break;
                        case "RF":
                            orden = "Insert Into RecetasFinalizadas(RecetaCompletada, Fecha_Finalizacion, Cantidad_Producto, Estado)" + "Values('" + objProd.RecetasCompletadas1 + "', '" +
                                objProd.FechaFinalizacionReceta1 + "', '" + objProd.CantidadProducto1 + "', '" + objProd.Estado1 + ");";
                            break;
                    }

                    break;
                case "Modificar":
                    switch (Nivel)
                    {
                        case "REP":
                            orden = "update RecetasEnProceso set Recetas_En_Proceso = '" + objProd.RecetaEnProceso1 + "', Proceso_Activo = '" + objProd.ProcesoActivo1 +
                                "', Estado_Actual = '" + objProd.EstadoActual1 + "'" + "Where id_RecetaEnProceso = '" + objProd.ProdId1 + "';";
                            break;
                        case "RF":
                            orden = "update RecetasFinalizadas set Receta_Completada = '" + objProd.RecetasCompletadas1 + "', Fecha_Finalizacion = '" + objProd.FechaFinalizacionReceta1 +
                                "', Cantidad_Producto = '" + objProd.CantidadProducto1 + "', Estado = '" + objProd.Estado1 + "'" + "Where id_RecetaEnProceso = '" + objProd.ProdId1 + "';";
                            break;
                    }
                    break;
                case "Borrar":
                    orden = "delete from stock where id_RecetaEnProceso = '" + delete + "';";
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

        #region Conseguir Id
        public void Conseguir()
        {

        }
        #endregion
    }
}
