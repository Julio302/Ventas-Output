using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


/*@@identity*/
using System.Data.Entity.Core.Objects;

namespace BL
{
    public class Venta
    {
        /*ADO con SP*/
        //public static ML.Result VentaAdd(ML.Venta Venta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = context;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "AddVenta";

        //        cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Venta.IdCliente;
        //        cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = Venta.Total;
        //        cmd.Parameters.Add("@IdMetodoPago", SqlDbType.Int).Value = Venta.IdMetodoPago;
        //        cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = Venta.Fecha;

        //        cmd.Connection.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //        if (rowsAffected >= 1)
        //        {
        //            result.Correct = true;
        //        }
        //        else
        //        {
        //            result.Correct = false;
        //            result.ErrorMessage = "Error no se pudo realizar la venta";
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaDelete(int IdVenta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = context;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "DeleteVenta";

        //        cmd.Parameters.Add("@IdVenta", SqlDbType.Int).Value = IdVenta;

        //        cmd.Connection.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //        if(rowsAffected >= 1)
        //        {
        //            result.Correct = true;
        //        }
        //        else
        //        {
        //            result.Correct = false;
        //            result.ErrorMessage = "Error no se pudo eliminar la venta";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaUpdate(ML.Venta Venta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = context;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "UpdateVenta";

        //        cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = Venta.IdCliente;
        //        cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = Venta.Total;
        //        cmd.Parameters.Add("@IdMetodoPago", SqlDbType.Int).Value = Venta.IdMetodoPago;
        //        cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = Venta.Fecha;
        //        cmd.Parameters.Add("IdVenta", SqlDbType.Int).Value = Venta.IdVenta;

        //        cmd.Connection.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //        if(rowsAffected >= 1)
        //        {
        //            result.Correct = true;
        //        }
        //        else
        //        {
        //            result.Correct = false;
        //            result.ErrorMessage = "Error no se pudo modificar la venta ";
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaGetAll()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
        //        SqlCommand cmd = new SqlCommand();

        //        cmd.Connection = context;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "GetAllVenta";

        //        cmd.Connection.Open();

        //        DataSet ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);

        //        if (ds.Tables[0].Rows.Count >= 0)
        //        {
        //            result.Objects = new List<object>();

        //            foreach (DataRow row in ds.Tables[0].Rows)
        //            {
        //                ML.Venta Venta = new ML.Venta();
        //                Venta.IdVenta = int.Parse(row[0].ToString());
        //                Venta.IdCliente = int.Parse(row[1].ToString());
        //                Venta.Total = float.Parse(row[2].ToString());
        //                Venta.IdMetodoPago = int.Parse(row[3].ToString());
        //                Venta.Fecha = DateTime.Parse(row[4].ToString());

        //                result.Objects.Add(Venta);
        //            }

        //            result.Correct = true;
        //        }
        //        else
        //        {
        //            result.Correct = false;
        //            result.ErrorMessage = "No hay ventas ";
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}


        /*ENTITY*/
        //public static ML.Result VentaAddET(ML.Venta Venta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using(DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities()){
        //            var query = context.AddVenta(Venta.IdCliente, Venta.Total, Venta.IdMetodoPago, Venta.Fecha);

        //            if (query >= 1)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaDeleteEF(int IdVenta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            var query = context.DeleteVenta(IdVenta);
        //            if (query >= 1)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error no se pudo eliminar";
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en "+e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaUpdateEF(ML.Venta Venta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            var query = context.UpdateVenta(Venta.IdVenta, Venta.IdCliente, (float)Venta.Total, Venta.IdMetodoPago, Venta.Fecha);

        //            if (query >= 1)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error no se pudo modificar la venta";
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaGetAllEF()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            var query = context.GetAllVenta().ToList();

        //            if (query != null)
        //            {
        //                result.Objects = new List<object>();

        //                foreach (var item in query)
        //                {
        //                    ML.Venta venta = new ML.Venta();
        //                    venta.IdVenta = item.IdVenta;
        //                    venta.IdCliente = (int) item.IdCliente;
        //                    venta.Total = (float) item.Total;
        //                    venta.IdMetodoPago = (int)item.IdMetodoPago;
        //                    venta.Fecha = (DateTime)item.Fecha;

        //                    result.Objects.Add(venta);
        //                }

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No se encontraron registros";
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en "+e.Message;
        //    }
        //    return result;
        //}


        /*LINQ*/
        //public static ML.Result VentaAddLinq(ML.Venta Venta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            DL_EF.Venta ventaDL = new DL_EF.Venta();
        //            ventaDL.IdCliente = Venta.IdCliente;
        //            ventaDL.Total = Venta.Total;
        //            ventaDL.IdMetodoPago = Venta.IdMetodoPago;
        //            ventaDL.Fecha = Venta.Fecha;

        //            context.Ventas.Add(ventaDL);
        //            context.SaveChanges();
        //            result.Correct = true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaDeleteLinq(int IdVenta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            var query = (from v in context.Ventas
        //                         where v.IdVenta == IdVenta
        //                         select v).First();

        //            context.Ventas.Remove(query);

        //            int rowsAffected = context.SaveChanges();

        //            if (rowsAffected >= 1)
        //            {
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "Error no se pudo eliminar la venta";
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaUpdateLinq(ML.Venta Venta)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            var query = (from v in context.Ventas
        //                             where v.IdVenta == Venta.IdVenta
        //                             select v).SingleOrDefault();

        //            if (query != null)
        //            {

        //                query.IdCliente = Venta.IdCliente;
        //                query.Total = Venta.Total;
        //                query.IdMetodoPago = Venta.IdMetodoPago;
        //                query.Fecha = Venta.Fecha;
        //                query.IdVenta = Venta.IdVenta;

        //                //context.Ventas.Add(query);
        //                context.SaveChanges();

        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No se pudo editar la venta";
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result VentaGetAllLinq()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
        //        {
        //            var query = (from v in context.Ventas
        //                         select new
        //                         {
        //                             IdVenta = v.IdVenta,
        //                             IdCliente = v.IdCliente,
        //                             Total = v.Total,
        //                             IdMetodoPago = v.IdMetodoPago,
        //                             Fecha = v.Fecha
        //                         }).ToList();

        //            if (query != null)
        //            {
        //                result.Objects = new List<object>();

        //                foreach (var item in query)
        //                {
        //                    ML.Venta venta = new ML.Venta();
        //                    venta.IdVenta = item.IdVenta;
        //                    venta.IdCliente = item.IdVenta;
        //                    venta.Total = (float) item.Total;
        //                    venta.IdMetodoPago = (int) item.IdMetodoPago;
        //                    venta.Fecha = (DateTime) item.Fecha;

        //                    result.Objects.Add(venta);
        //                }
        //                result.Correct = true;
        //            }
        //            else
        //            {
        //                result.Correct = false;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = "Error en " + e.Message;
        //    }
        //    return result;
        //}


        /*Venta y VentaDetalle con entity*/

        public static ML.Result VentaAdd(ML.Venta venta, List<object> Result)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    //@@identity
                    var IdVenta = new ObjectParameter("IdVenta", typeof(int));
                    var query = context.AddVenta(IdVenta, venta.IdCliente, venta.Total, venta.IdMetodoPago, venta.Fecha);

                    if (query == 1)
                    {

                        foreach (ML.Producto producto in Result.ToList())
                        {
                            ML.VentaProducto ventaProducto = new ML.VentaProducto();
                            //recorre e inserta
                            ventaProducto.Venta = new ML.Venta();
                            ventaProducto.Venta.IdVenta = (int)IdVenta.Value;
                            ventaProducto.Venta.IdCliente = venta.IdCliente;
                            ventaProducto.Cantidad = 1;
                            ventaProducto.Producto = new ML.Producto();
                            ventaProducto.Producto.IdProducto = producto.IdProducto;
                            ventaProducto.ProductoSucursal = new ML.ProductoSucursal();
                            ventaProducto.ProductoSucursal.IdProductoSucursal = 2;

                            BL.VentaProducto.VentaProductoAdd(ventaProducto);
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


        /*Venta y VentaDetalle con ADO SP*/
        public static ML.Result VentaAddADOSP(ML.Venta venta, List<object> Result)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddVenta";


                cmd.Connection.Open();
                //@@identity
                SqlParameter outparam = cmd.Parameters.Add("@IdVenta", SqlDbType.Int);
                outparam.Direction = ParameterDirection.Output;



                //cmd.Parameters.Add("@IdVenta", SqlDbType.Int).Value = Convert.ToInt16(cmd.Parameters["@IdVenta"].Value); ;
                cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = venta.IdCliente;
                cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = venta.Total;
                cmd.Parameters.Add("@IdMetodoPago", SqlDbType.Int).Value = venta.IdMetodoPago;
                cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = venta.Fecha;

                int rowsAffected = cmd.ExecuteNonQuery();

                int idped = Convert.ToInt16(cmd.Parameters["@IdVenta"].Value);

                cmd.Connection.Close();

                if (rowsAffected >= 1)
                {


                    foreach (ML.Producto producto in Result.ToList())
                    {
                        ML.VentaProducto ventaProducto = new ML.VentaProducto();
                        ventaProducto.Venta = new ML.Venta();
                        ventaProducto.Venta.IdVenta = (int)idped;
                        ventaProducto.Venta.IdCliente = venta.IdCliente;
                        ventaProducto.Cantidad = 1; //uno por producto
                        ventaProducto.Producto = new ML.Producto();
                        ventaProducto.Producto.IdProducto = producto.IdProducto; // idproducto
                        ventaProducto.ProductoSucursal = new ML.ProductoSucursal();
                        ventaProducto.ProductoSucursal.IdProductoSucursal = 1;

                        //envio al BL de VentaProducto
                        BL.VentaProducto.VentaProductoAddADOSP(ventaProducto);
                    }

                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                }

            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e.Message;
            }

            return result;

        }


        /*COLLECTION Venta y VentaDetalle con ADO NET COLLECTION*/
        public static ML.Result VentaAddADONET(ML.Venta Venta, List<object> Result)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "INSERT INTO [Venta] ([IdCliente], [Total], [IdMetodoPago], [Fecha]) VALUES (@IdCliente, @Total, @IdMetodoPago, @Fecha) SELECT CAST(scope_identity() AS int)";

                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Connection = context;
                        cmd.CommandText = query;

                        //Entrada de datos
                        SqlParameter[] collection = new SqlParameter[4];

                        collection[0] = new SqlParameter("IdCliente", SqlDbType.Int);
                        collection[0].Value = Venta.IdCliente;

                        collection[1] = new SqlParameter("Total", SqlDbType.Float);
                        collection[1].Value = Venta.Total;

                        collection[2] = new SqlParameter("IdMetodoPago", SqlDbType.Int);
                        collection[2].Value = Venta.IdMetodoPago;

                        collection[3] = new SqlParameter("Fecha", SqlDbType.Date);
                        collection[3].Value = DateTime.Now;




                        //cmd.Connection.Open();
                        //var resultQuery = cmd.ExecuteScalar();

                        cmd.Parameters.AddRange(collection);

                        cmd.Connection.Open();
                        var resultQuery = cmd.ExecuteScalar();

                        cmd.Connection.Close();


                        if (resultQuery != null)
                        {
                            result.Correct = true;

                            foreach (ML.Producto producto in Result.ToList())
                            {
                                ML.VentaProducto ventaProducto = new ML.VentaProducto();
                                ventaProducto.Venta = new ML.Venta();
                                ventaProducto.Venta.IdVenta = (int)resultQuery;
                                ventaProducto.Venta.IdCliente = Venta.IdCliente;
                                ventaProducto.Cantidad = 2; //uno por producto
                                ventaProducto.Producto = new ML.Producto();
                                ventaProducto.Producto.IdProducto = producto.IdProducto; // idproducto
                                ventaProducto.ProductoSucursal = new ML.ProductoSucursal();
                                ventaProducto.ProductoSucursal.IdProductoSucursal = 2;

                                //envio al BL de VentaProducto
                                BL.VentaProducto.VentaProductoAddADONET(ventaProducto);
                            }

                        }
                        else
                        {
                            result.Correct = false;
                        }

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


        /*GetAll EF*/
        public static ML.Result VentaGetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var listaVenta = context.GetAllVenta().ToList();

                    if (listaVenta != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in listaVenta)
                        {
                            ML.Venta venta = new ML.Venta();
                            venta.IdVenta = item.IdVenta;
                            venta.IdCliente = (int)item.IdCliente;
                            venta.Total = (float)item.Total;
                            venta.IdMetodoPago = (int)item.IdMetodoPago;
                            venta.Fecha = (DateTime)item.Fecha;
                            result.Objects.Add(venta);
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

    }
}
