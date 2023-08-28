using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexionBD
    {
        public SqlConnection Conexion;
        public string cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = EscuelasDB; Integrated Security = True;";

        public DatosConexionBD()
        {
            Conexion = new SqlConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed)
                {
                    Conexion.Open();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de Cerrar la conexion", e);
            }
        }
    }
}