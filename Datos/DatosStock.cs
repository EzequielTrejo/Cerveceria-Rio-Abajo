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
        public int abmStock(string accion, Stock objStock, string delete)
        {
            int Resultado = -1;
            string orden = string.Empty;


            switch (accion)
            {
                case "Agregar":
                    orden = "Insert Into Stock(Nombre, Apellido, Genero, DNI, Fecha_De_Naciemiento, Edad, LegajoAlumno, Carrera, Fecha_De_Inscripcion)" +
                        "    Values('" + objStock.Nombre + "', '" + objStock.Apellido + "', '" + objStock.Genero + "', '" +
                                    objStock.DNI + "'," + FechaN + "," + "'" + edad + "', '" + objStock.LegajoAlumno + "', '" +
                                    objStock.Carrera + "', " + FechaI + ");";
                    break;
                case "Modificar":
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
