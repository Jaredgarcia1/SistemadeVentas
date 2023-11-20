using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
//using System.Xml;
//using System.Xml.Linq;

namespace CapaDatos
{
    public class CdCompra
    {
        public static bool RegistrarCompra(string Detalle)
        {
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_RegistrarCompra", oConexion);
                    cmd.Parameters.Add("Detalle", SqlDbType.Xml).Value = Detalle;
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


        public static Compra ObtenerDetalleCompra(int IdCompra)
        {
            Compra rptDetalleCompra = new Compra();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerDetalleCompra", oConexion);
                cmd.Parameters.AddWithValue("@IdCompra", IdCompra);
                cmd.CommandType = CommandType.StoredProcedure;


                try
                {
                    

                    return rptDetalleCompra;
                }
                catch (Exception ex)
                {
                    rptDetalleCompra = null;
                    return rptDetalleCompra;
                }
            }
        }




        public static List<Compra> ObtenerListaCompra(DateTime FechaInicio, DateTime FechaFin,int IdProveedor, int IdTienda)
        {
            List<Compra> rptListaCompra = new List<Compra>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                SqlCommand cmd = new SqlCommand("usp_ObtenerListaCompra", oConexion);
                cmd.Parameters.AddWithValue("@FechaInicio", FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", FechaFin);
                cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                cmd.Parameters.AddWithValue("@IdTienda", IdTienda);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        rptListaCompra.Add(new Compra()
                        {
                            IdCompra = Convert.ToInt32(dr["IdCompra"].ToString()),
                            NumeroCompra = dr["NumeroCompra"].ToString(),
                            Proveedor = new Proveedor() { RazonSocial = dr["RazonSocial"].ToString() },
                            Tienda = new Tienda() { Nombre = dr["Nombre"].ToString() },
                            FechaCompra = dr["FechaCompra"].ToString(),
                            TotalCosto = float.Parse(dr["TotalCosto"].ToString())
                        });
                    }
                    dr.Close();

                    return rptListaCompra;

                }
                catch (Exception ex)
                {
                    rptListaCompra = null;
                    return rptListaCompra;
                }
            }
        }



    }
}
