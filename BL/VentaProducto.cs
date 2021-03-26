using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class VentaProducto
    {
        /*Con entity*/
        public static ML.Result VentaProductoAdd(ML.VentaProducto VentaProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var ventaproductolist = context.AddVentaProducto(VentaProducto.Venta.IdVenta, VentaProducto.ProductoSucursal.IdProductoSucursal, VentaProducto.Cantidad, VentaProducto.Producto.IdProducto);
                    if (ventaproductolist >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
    
        /*Con Ado y SP*/

        public static ML.Result VentaProductoAddADOSP(ML.VentaProducto VentaProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddVentaProducto";

                cmd.Parameters.Add("@IdVenta", SqlDbType.Int).Value = VentaProducto.Venta.IdVenta;
                cmd.Parameters.Add("@IdProductoSucursal", SqlDbType.Int).Value = VentaProducto.ProductoSucursal.IdProductoSucursal;
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = VentaProducto.Cantidad;
                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = VentaProducto.Producto.IdProducto;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }


        /*PROBLEMA COLLECTION Venta y VentaDetalle con ADO NET COLLECTION*/
        public static ML.Result VentaProductoAddADONET(ML.VentaProducto VentaProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "INSERT INTO [VentaProducto] ([IdVenta], [IdProductoSucursal], [Cantidad], [IdProducto]) values (@IdVenta, @IdProductoSucursal, @Cantidad, @IdProducto)";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;

                        SqlParameter[] collection = new SqlParameter[4];

                        collection[0] = new SqlParameter("IdVenta", SqlDbType.Int);
                        collection[0].Value = VentaProducto.Venta.IdVenta;

                        collection[1] = new SqlParameter("IdProductoSucursal", SqlDbType.Int);
                        collection[1].Value = VentaProducto.ProductoSucursal.IdProductoSucursal;

                        collection[2] = new SqlParameter("Cantidad", SqlDbType.Int);
                        collection[2].Value = VentaProducto.Cantidad;

                        collection[3] = new SqlParameter("IdProducto", SqlDbType.Int);
                        collection[3].Value = VentaProducto.Producto.IdProducto;

                        cmd.Parameters.AddRange(collection);

                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();

                        result.Correct = true;
                        
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }



        /*GetAllVentaProducto con EF*/
        public static ML.Result VentaProductoGetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var listaVentaProducto = context.GetAllVentaProducto().ToList();

                    if (listaVentaProducto != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in listaVentaProducto)
                        {
                            ML.VentaProducto ventaproducto = new ML.VentaProducto();
                            ventaproducto.IdVentaProducto = item.IdVentaProducto;
                            ventaproducto.Venta = new ML.Venta();
                            ventaproducto.Venta.IdVenta = (int) item.IdVenta;
                            ventaproducto.ProductoSucursal = new ML.ProductoSucursal();
                            ventaproducto.ProductoSucursal.IdProductoSucursal = (int) item.IdProductoSucursal;
                            ventaproducto.Cantidad = (int)item.Cantidad;
                            ventaproducto.Producto = new ML.Producto();
                            ventaproducto.Producto.IdProducto = (int)item.IdProducto;

                            result.Objects.Add(ventaproducto);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay registros";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
    
        /*Delete VentaProducto con EF*/
        public static ML.Result VentaProductoDelete(int IdVenta)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var ventaproductolist = context.DeleteVentaProducto(IdVenta);

                    if (ventaproductolist >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
   
        /*Update VentaProducto con EF*/
        public static ML.Result VentaProductoUpdate(ML.VentaProducto ventaProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var ventaproductolist = context.UpdateVentaProducto(ventaProducto.IdVentaProducto, ventaProducto.Venta.IdVenta, ventaProducto.ProductoSucursal.IdProductoSucursal, ventaProducto.Cantidad, ventaProducto.Producto.IdProducto);

                    if (ventaproductolist >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
    
        /*GetAll VentaProducto con EF*/
        public static ML.Result VentaProductoGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var ventaproductolist = context.GetAllVentaProducto().ToList();

                    if (ventaproductolist != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in ventaproductolist){
                            ML.VentaProducto ventaproducto = new ML.VentaProducto();
                            ventaproducto.IdVentaProducto = (int)item.IdVentaProducto;
                            ventaproducto.Venta = new ML.Venta();
                            ventaproducto.Venta.IdVenta = (int) item.IdVenta;
                            ventaproducto.ProductoSucursal = new ML.ProductoSucursal();
                            ventaproducto.ProductoSucursal.IdProductoSucursal = (int)item.IdProductoSucursal;
                            ventaproducto.Cantidad = (int) item.Cantidad;
                            ventaproducto.Producto = new ML.Producto();
                            ventaproducto.Producto.IdProducto = (int)item.IdProducto;

                            result.Objects.Add(ventaproducto);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }
            return result;
        }
    }
}
