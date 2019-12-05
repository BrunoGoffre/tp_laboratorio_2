using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        public delegate void DelegadoPaqueteDAO(string mensaje);
        static SqlConnection connection;
        static SqlCommand command;
        public static event DelegadoPaqueteDAO EventoDAO;
        /// <summary>
        /// Establece la conexcion con la base de datos
        /// </summary>
        static PaqueteDAO()
        {
            string connectionStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017; Integrated Security=True";

            PaqueteDAO.connection = new SqlConnection(connectionStr);
            PaqueteDAO.command = new SqlCommand();

            PaqueteDAO.command.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.command.Connection = PaqueteDAO.connection;
        }
        /// <summary>
        /// Abre la conexion con la base de datos y la completa con los datos actuales
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            try
            {
                string consulta = $"INSERT INTO dbo.Paquetes(direccionEntrega, trackingID, alumno) VALUES('{p.DireccionEntrega}', '{p.TrackingID}', 'Goffredo Bruno')";
                PaqueteDAO.command.CommandText = consulta;
                PaqueteDAO.connection.Open();
                PaqueteDAO.command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                PaqueteDAO.EventoDAO.Invoke("No se pudo realizar la consulta");
                return false;
            }
            finally
            {
                PaqueteDAO.connection.Close();
            }
        }
        
    }
}
