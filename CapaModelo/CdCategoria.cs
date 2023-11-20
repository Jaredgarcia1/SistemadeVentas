using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CdCategoria
    {
        public static bool RegistrarCategoria(Categoria oCategoria)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarCategoria", oConexion);
                    cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConexion.Open();

                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);

                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public static bool ModificarCategoria(Categoria oCategoria)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_ModificarCategoria", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("IdCategoria", oCategoria.IdCategoria);
                cmd.Parameters.AddWithValue("Descripcion", oCategoria.Descripcion);
                cmd.Parameters.AddWithValue("Activo", oCategoria.Activo);
                cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception)
                {
                    respuesta = false;
                }
            }
            return respuesta;

        }

        public static bool EliminarCategoria(int IdCategoria)
        {
            bool respuesta;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_EliminarCategoria", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("IdCategoria", IdCategoria);
                cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public static List<Categoria> ObtenerCategoria()
        {
            var ListaCategorias = new List<Categoria>();
            using (var oConexion = new SqlConnection(Conexion.CN))
            {
                var cmd = new SqlCommand("usp_ObtenerCategorias", oConexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                try
                {
                    oConexion.Open();

                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ListaCategorias.Add(new Categoria
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"].ToString()),
                                Descripcion = dr["Descripcion"].ToString(),
                                Activo = Convert.ToBoolean(dr["Activo"].ToString())
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    ListaCategorias = null;
                }
            }
            return ListaCategorias;
        }

    }
}
