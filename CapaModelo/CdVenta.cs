using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Linq;

namespace CapaDatos
{
    public class CdVenta
    {
        public static int RegistrarVenta(string Detalle)
        {
            int respuesta;
            using (var conexion = new SqlConnection(Conexion.CN))
            {
                var cmd = new SqlCommand("usp_RegistrarVenta", conexion)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("Detalle", SqlDbType.Xml).Value = Detalle;
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception)
                {
                    respuesta = 0;
                }
            }
            return respuesta;
        }




        public static Venta ObtenerDetalleVenta(int IdVenta)
        {
            Venta rptDetalleVenta = new Venta();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerDetalleVenta", oConexion);
                cmd.Parameters.AddWithValue("@IdVenta", IdVenta);
                cmd.CommandType = CommandType.StoredProcedure;
                

                try
                {
                    

                    return rptDetalleVenta;
                }
                catch (Exception ex)
                {
                    rptDetalleVenta = null;
                    return rptDetalleVenta;
                }
            }
        }

        public static List<Venta> ObtenerListaVenta(string Codigo, DateTime FechaInicio , DateTime FechaFin,string NumeroDocumento,string Nombre)
        {
            List<Venta> rptListaVenta = new List<Venta>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerListaVenta", oConexion);
                cmd.Parameters.AddWithValue("@Codigo", Codigo);
                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", FechaFin);
                cmd.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaVenta.Add(new Venta()
                        {
                            IdVenta = Convert.ToInt32(dr["IdVenta"].ToString()),
                            TipoDocumento = dr["TipoDocumento"].ToString(),
                            Codigo = dr["Codigo"].ToString(),
                            VFechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString()),
                            Cliente = new Cliente() { NumeroDocumento = dr["NumeroDocumento"].ToString(), Nombre = dr["Nombre"].ToString() },
                            TotalCosto = float.Parse(dr["TotalCosto"].ToString())
                        });
                    }
                    dr.Close();

                    return rptListaVenta;

                }
                catch (Exception ex)
                {
                    rptListaVenta = null;
                    return rptListaVenta;
                }
            }
        }




    }
}
