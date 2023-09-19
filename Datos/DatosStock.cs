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

                            break;
                    }
                    orden = "update Alumnos set Nombre = '" + objStock.Nombre + "', Apellido = '" + objStock.Apellido + "', Genero = '" + objStock.Genero +
                            "', DNI = '" + objStock.DNI + "'," + " Fecha_De_Naciemiento = '" + FechaN + "', Edad = '" + objStock.Edad +
                            "', LegajoAlumno = '" + objStock.LegajoAlumno + "', Carrera = '" + objStock.Carrera + "'," + " Fecha_De_Inscripcion = '" +
                            FechaI + "'" +
                            "Where AlumnoId = '" + objStock.AlumnoId + "';";
                    break;
                case "Borrar":
                    orden = "delete from Alumnos where AlumnoId = '" + delete + "';";
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
