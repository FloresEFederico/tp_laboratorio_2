using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;
namespace Entidades
{
    public class FabricaDAO
    {
        private static SqlConnection conexionSql;
        private static SqlCommand comandoSql;
        private static SqlDataReader readerSql;
        private static DataTable tabla;

        static FabricaDAO()
        {
            FabricaDAO.conexionSql = new SqlConnection("Data source = .; Database = Fabrica; Trusted_Connection = True;");
            FabricaDAO.comandoSql = new SqlCommand();
            FabricaDAO.comandoSql.Connection = conexionSql;
            FabricaDAO.comandoSql.CommandType = System.Data.CommandType.Text;
            FabricaDAO.tabla = new DataTable();
        }

        public static DataTable CargarDatosALaTabla()
        {
            try
            {
                if (FabricaDAO.conexionSql.State != System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Open();
                }
                FabricaDAO.comandoSql.CommandText = "SELECT * FROM Productos";
                FabricaDAO.tabla.Load(FabricaDAO.comandoSql.ExecuteReader());
                return tabla;
            }
            catch (InvalidOperationException operacionInvalida)
            {
                throw operacionInvalida;
            }
            catch (SqlException excepcionSql)
            {
                throw excepcionSql;
            }
            catch (Exception exceptionNeutral)
            {
                throw exceptionNeutral;
            }
            finally
            {
                if (FabricaDAO.conexionSql.State == System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Close();
                }
                
            }
        }

        public static DataTable CargarDatosALaTablaPorTipo(string tipoProducto)
        {
            try
            {
                if (FabricaDAO.conexionSql.State != System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Open();
                }
                FabricaDAO.comandoSql.CommandText = "SELECT * FROM Productos where TipoDeProducto = @TipoProducto";
                FabricaDAO.comandoSql.Parameters.AddWithValue("@TipoProducto", tipoProducto);
                FabricaDAO.tabla.Load(FabricaDAO.comandoSql.ExecuteReader());
                return tabla;
            }
            catch (InvalidOperationException operacionInvalida)
            {
                throw operacionInvalida;
            }
            catch (SqlException excepcionSql)
            {
                throw excepcionSql;
            }
            catch (Exception exceptionNeutral)
            {
                throw exceptionNeutral;
            }
            finally
            {
                if (FabricaDAO.conexionSql.State == System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Close();
                }
                FabricaDAO.comandoSql.Parameters.Clear();
            }
        }

        public static bool BuscarProductoExistente(Producto producto)
        {
            bool existeProducto = false;
            try
            {
                if (FabricaDAO.conexionSql.State != System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Open();
                }
                if(producto is null)
                {
                    throw new ElementoNullException("No se ha seleccionado ningun producto del listado");
                }
                FabricaDAO.comandoSql.CommandText = "SELECT * FROM Productos where Nombre = @Nombre";
                FabricaDAO.comandoSql.Parameters.AddWithValue("@Nombre", producto.Nombre);
                FabricaDAO.readerSql = FabricaDAO.comandoSql.ExecuteReader();
                if(FabricaDAO.readerSql.Read())
                {
                    throw new ProductoExistenteException("Ese producto ya existe en la base de datos");
                }
                return existeProducto;
            }
            catch (InvalidOperationException operacionInvalida)
            {
                throw operacionInvalida;
            }
            catch (SqlException excepcionSql)
            {
                throw excepcionSql;
            }
            catch (Exception exceptionNeutral)
            {
                throw exceptionNeutral;
            }
            finally
            {
                if (FabricaDAO.conexionSql.State == System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Close();
                }
                FabricaDAO.comandoSql.Parameters.Clear();
            }
        }

        public static int InsertarJuego(Producto producto)
        {
            string tipoDeProducto = "JuegoDeMesa";
            int cantidadDeFilasAfectadas = 0;
            if(producto.GetType().ToString() == "Entidades.VideoJuego")
            {
                tipoDeProducto = "VideoJuego";
            }
            try
            {
                if (FabricaDAO.conexionSql.State != System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Open();
                }
                FabricaDAO.comandoSql.CommandText = "INSERT INTO Productos(Nombre,Clasificacion,TipoDeProducto) VALUES (@nombre,@clasificacion,@tipoDeProducto)";
                FabricaDAO.comandoSql.Parameters.AddWithValue("@nombre", producto.Nombre);
                FabricaDAO.comandoSql.Parameters.AddWithValue("@clasificacion", producto.ClasificacionPorEdad);
                FabricaDAO.comandoSql.Parameters.AddWithValue("@tipoDeProducto", tipoDeProducto);
                cantidadDeFilasAfectadas = FabricaDAO.comandoSql.ExecuteNonQuery();
                return cantidadDeFilasAfectadas;
            }
            catch (InvalidOperationException operacionInvalida)
            {
                throw operacionInvalida;
            }
            catch (SqlException excepcionSql)
            {
                throw excepcionSql;
            }
            catch (Exception exceptionNeutral)
            {
                throw exceptionNeutral;
            }
            finally
            {
                if (FabricaDAO.conexionSql.State == System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Close();
                }
                FabricaDAO.comandoSql.Parameters.Clear();
            }
        }

        public static int BorrarJuegoPorId(int idJuego)
        {
            int cantidadDeFilasAfectadas = 0;
            try
            {
                if (FabricaDAO.conexionSql.State != System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Open();
                }
                FabricaDAO.comandoSql.CommandText = "DELETE Productos WHERE IdJuego = @idJuego";
                FabricaDAO.comandoSql.Parameters.AddWithValue("@idJuego", idJuego);
                cantidadDeFilasAfectadas = FabricaDAO.comandoSql.ExecuteNonQuery();
                return cantidadDeFilasAfectadas;
            }
            catch (InvalidOperationException operacionInvalida)
            {
                throw operacionInvalida;
            }
            catch (SqlException excepcionSql)
            {
                throw excepcionSql;
            }
            catch (Exception exceptionNeutral)
            {
                throw exceptionNeutral;
            }
            finally
            {
                if (FabricaDAO.conexionSql.State == System.Data.ConnectionState.Open)
                {
                    FabricaDAO.conexionSql.Close();
                }
                FabricaDAO.comandoSql.Parameters.Clear();
            }
        }
    }
}
