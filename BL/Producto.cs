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
    public class Producto
    {
        /*Con SqlConnection Y StoredProcedure*/
        public static ML.Result ProductoAdd(ML.Producto Producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddSP";

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Producto.Nombre;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Producto.Descripcion;
                cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Producto.Precio;
                cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = Producto.IdDepartamento;
                cmd.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = Producto.IdProveedor;
                cmd.Parameters.Add("@Imagen", SqlDbType.VarChar).Value = Producto.Imagen;
                cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = Producto.Stock;

                cmd.Connection = context;
                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected >= 1)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Error no se pudo agregar el producto";
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result ProductoDelete(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteSP";

                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = IdProducto;

                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if(rowsAffected >= 1)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "Error no se pudo eliminar el producto ";
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result ProductoUpdate(ML.Producto producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = context;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateSP";

                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = producto.Nombre;
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = producto.Descripcion;
                cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.Precio;
                cmd.Parameters.Add("@IdDepartamento", SqlDbType.Int).Value = producto.IdDepartamento;
                cmd.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = producto.IdProveedor;
                cmd.Parameters.Add("@Imagen", SqlDbType.VarChar).Value = producto.Imagen;
                cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;
                cmd.Parameters.Add("@IdProducto", SqlDbType.Int).Value = producto.IdProducto;

                cmd.Connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (rowsAffected >= 1)
                {
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "No se pudo modificar el producto ";
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result ProductoGetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString());
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = context;
                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetSP";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    result.Objects = new List<object>();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        ML.Producto Producto = new ML.Producto();
                        Producto.IdProducto = int.Parse(row[0].ToString());
                        Producto.Nombre = row[1].ToString();
                        Producto.Descripcion = row[2].ToString();
                        Producto.Precio = decimal.Parse(row[3].ToString());
                        Producto.IdDepartamento = int.Parse(row[4].ToString());
                        Producto.IdProveedor = int.Parse(row[5].ToString());
                        Producto.Imagen = row[6].ToString();
                        Producto.Stock = int.Parse(row[7].ToString());
                        result.Objects.Add(Producto);
                    }
                    result.Correct = true;
                }
                else
                {
                    result.Correct = false;
                    result.ErrorMessage = "No hay registros";
                }

                cmd.Connection.Close();
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }
    
        
        /*ENTITY*/
        public static ML.Result ProductoAddEF(ML.Producto Producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = context.AddSP(Producto.Nombre, Producto.Descripcion, Producto.Precio, Producto.IdDepartamento, Producto.IdProveedor, Producto.Imagen, Producto.Stock);

                    if (query >= 1)
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

        public static ML.Result ProductoDeleteEF(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = context.DeleteSP(IdProducto);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo eliminar el producto ";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result ProductoUpdateEF(ML.Producto Producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities()) {
                    var query = context.UpdateSP(Producto.Nombre, Producto.Descripcion, Producto.Precio, Producto.IdDepartamento, Producto.IdProveedor, Producto.Imagen, Producto.Stock, Producto.IdProducto);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no se pudo modificar el producto ";
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

        public static ML.Result ProductoGetAllEF()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = context.GetSP().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Producto producto = new ML.Producto();
                            producto.IdProducto = item.IdProducto;
                            producto.Nombre = item.Nombre;
                            producto.Descripcion = item.Descripcion;
                            producto.Precio = (decimal) item.Precio;
                            producto.IdDepartamento = (int) item.IdDepartamento;
                            producto.IdProveedor = (int) item.IdProveedor;
                            producto.Imagen = item.Imagen;
                            producto.Stock = (int) item.Stock;

                            result.Objects.Add(producto);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no hay registros";
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
    
        /*LINQ*/
        public static ML.Result ProductoAddLinq(ML.Producto Producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    DL_EF.Producto productoDL = new DL_EF.Producto();
                    productoDL.Nombre = Producto.Nombre;
                    productoDL.Descripcion = Producto.Descripcion;
                    productoDL.Precio = Producto.Precio;
                    productoDL.IdDepartamento = Producto.IdDepartamento;
                    productoDL.IdProveedor = Producto.IdProveedor;
                    productoDL.Imagen = Producto.Imagen;
                    productoDL.Stock = Producto.Stock;

                    context.Productoes.Add(productoDL);
                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en " + e;
            }
            return result;
        }

        public static ML.Result ProductoDeleteLinq(int IdProducto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = (from p in context.Productoes
                                 where p.IdProducto == IdProducto
                                     select p).First();

                    context.Productoes.Remove(query);
                    int rowsAffected = context.SaveChanges();

                    if (rowsAffected >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no se pudo eliminar el producto";
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = "Error en "+e.Message;
            }
            return result;
        }

        public static ML.Result ProductoUpdateLinq(ML.Producto Producto)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = (from p in context.Productoes
                                 where p.IdProducto == Producto.IdProducto
                                 select p).SingleOrDefault();

                    if (query != null)
                    {
                        query.IdProducto = Producto.IdProducto;
                        query.Nombre = Producto.Nombre;
                        query.Descripcion = Producto.Descripcion;
                        query.Precio = Producto.Precio;
                        query.IdDepartamento = Producto.IdDepartamento;
                        query.IdProveedor = Producto.IdProveedor;
                        query.Imagen = Producto.Imagen;
                        query.Stock = Producto.Stock;

                        //context.Productoes.Add(query);
                        context.SaveChanges();

                        result.Correct = true;


                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no se pudo editar el producto";
                        
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

        public static ML.Result ProductoGetAllLinq()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL_EF.JFernandezEcommerce2Entities context = new DL_EF.JFernandezEcommerce2Entities())
                {
                    var query = (from p in context.Productoes
                                 select new
                                 {
                                     IdProducto = p.IdProducto,
                                     Nombre = p.Nombre,
                                     Descripcion = p.Descripcion,
                                     Precio = p.Precio,
                                     IdDepartamento = p.IdDepartamento,
                                     IdProveedor = p.IdProveedor,
                                     Imagen = p.Imagen,
                                     Stock = p.Stock
                                 }).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Producto ProductoDL = new ML.Producto();
                            ProductoDL.IdProducto = item.IdProducto;
                            ProductoDL.Nombre = item.Nombre;
                            ProductoDL.Descripcion = item.Descripcion;
                            ProductoDL.Precio = (decimal) item.Precio;
                            ProductoDL.IdDepartamento = (int) item.IdDepartamento;
                            ProductoDL.IdProveedor = (int) item.IdProveedor;
                            ProductoDL.Stock = (int) item.Stock;

                            result.Objects.Add(ProductoDL);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error no hay registros";
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
