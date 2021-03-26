using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Producto
    {
        /*Con SqlConnection Y StoredProcedure*/
        public static void ProductoAdd()
        {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Ingresa Nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa Precio del producto");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdDepartamento");
            producto.IdDepartamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdProveedor");
            producto.IdProveedor = int.Parse(Console.ReadLine());
            //imagen
            producto.Imagen = "";
            Console.WriteLine("Ingresa stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());

            
            ML.Result result = new ML.Result();
            result = BL.Producto.ProductoAdd(producto);

            if (result.Correct)
            {
                Console.WriteLine("Producto registrado con exito SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
        public static void ProductoDelete()
        {
            Console.WriteLine("Ingresa producto a Eliminar");
            int IdProducto = int.Parse(Console.ReadLine());
            var result = BL.Producto.ProductoDelete(IdProducto);
            if (result.Correct)
            {
                Console.WriteLine("Producto eliminado con SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
        public static void ProductoUpdate()
        {
            ML.Producto producto = new ML.Producto();
            Console.WriteLine("Ingresa el IdProducto a modificar");
            producto.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa Precio del producto");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdDepartamento");
            producto.IdDepartamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdProveedor");
            producto.IdProveedor = int.Parse(Console.ReadLine());
            //imagen
            producto.Imagen = "";
            Console.WriteLine("Ingresa stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());

            var result = BL.Producto.ProductoUpdate(producto);

            if (result.Correct)
            {
                Console.WriteLine("Producto modificado correctamente SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
        public static void ProductoGetAll()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla productos con SP");

            result = BL.Producto.ProductoGetAll();
            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("IdProducto: " + producto.IdProducto + 
                                      " Nombre: " + producto.Nombre +
                                      " Descripcion "+ producto.Descripcion +
                                      " Precio: " + producto.Precio + " $ "+
                                      " IdDepartamento "+producto.IdDepartamento +
                                      " IdProveedor "+producto.IdProveedor +
                                      " Imagen "+ producto.Imagen +
                                      " Stock: " + producto.Stock);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        /*ENTITY*/
        public static void ProductoAddEF()
        {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Ingresa Nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa Precio del producto");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdDepartamento");
            producto.IdDepartamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdProveedor");
            producto.IdProveedor = int.Parse(Console.ReadLine());
            //imagen
            producto.Imagen = "";
            Console.WriteLine("Ingresa stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());


            ML.Result result = new ML.Result();
            result = BL.Producto.ProductoAddEF(producto);

            if (result.Correct)
            {
                Console.WriteLine("Producto registrado con exito ENTITY");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
        public static void ProductoDeleteEF()
        {
            Console.WriteLine("Ingresa producto a Eliminar");
            int IdProducto = int.Parse(Console.ReadLine());
            var result = BL.Producto.ProductoDeleteEF(IdProducto);
            if (result.Correct)
            {
                Console.WriteLine("Producto eliminado con ENTITY");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
        public static void ProductoUpdateEF()
        {
            ML.Producto producto = new ML.Producto();
            Console.WriteLine("Ingresa el IdProducto a modificar");
            producto.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa Precio del producto");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdDepartamento");
            producto.IdDepartamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdProveedor");
            producto.IdProveedor = int.Parse(Console.ReadLine());
            //imagen
            producto.Imagen = "";
            Console.WriteLine("Ingresa stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());

            var result = BL.Producto.ProductoUpdateEF(producto);

            if (result.Correct)
            {
                Console.WriteLine("Producto modificado correctamente ENTITY");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
        public static void ProductoGetAllEF()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla productos con ENTITY");

            result = BL.Producto.ProductoGetAllEF();
            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("IdProducto: " + producto.IdProducto +
                                      " Nombre: " + producto.Nombre +
                                      " Descripcion " + producto.Descripcion +
                                      " Precio: " + producto.Precio + " $ " +
                                      " IdDepartamento " + producto.IdDepartamento +
                                      " IdProveedor " + producto.IdProveedor +
                                      " Imagen " + producto.Imagen +
                                      " Stock: " + producto.Stock);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }

        }
    
        /*LINQ*/
        public static void ProductoAddLinq()
        {
            ML.Producto producto = new ML.Producto();

            Console.WriteLine("Ingresa Nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa Precio del producto");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdDepartamento");
            producto.IdDepartamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdProveedor");
            producto.IdProveedor = int.Parse(Console.ReadLine());
            //imagen
            producto.Imagen = "";
            Console.WriteLine("Ingresa stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());


            ML.Result result = new ML.Result();
            result = BL.Producto.ProductoAddLinq(producto);

            if (result.Correct)
            {
                Console.WriteLine("Producto registrado con exito LINQ");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void ProductoDeleteLinq()
        {
            Console.WriteLine("Ingresa producto a Eliminar");
            int IdProducto = int.Parse(Console.ReadLine());
            var result = BL.Producto.ProductoDeleteLinq(IdProducto);
            if (result.Correct)
            {
                Console.WriteLine("Producto eliminado con LINQ");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void ProductoUpdateLinq()
        {
            ML.Producto producto = new ML.Producto();
            Console.WriteLine("Ingresa el IdProducto a modificar");
            producto.IdProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa Nombre del producto");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Descripcion del producto");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingresa Precio del producto");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdDepartamento");
            producto.IdDepartamento = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa IdProveedor");
            producto.IdProveedor = int.Parse(Console.ReadLine());
            //imagen
            producto.Imagen = "";
            Console.WriteLine("Ingresa stock del producto");
            producto.Stock = int.Parse(Console.ReadLine());

            var result = BL.Producto.ProductoUpdateLinq(producto);

            if (result.Correct)
            {
                Console.WriteLine("Producto modificado correctamente LINQ");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }

        public static void ProductoGetAllLinq()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla productos con LINQ");

            result = BL.Producto.ProductoGetAllLinq();
            if (result.Correct)
            {
                foreach (ML.Producto producto in result.Objects)
                {
                    Console.WriteLine("IdProducto: " + producto.IdProducto +
                                      " Nombre: " + producto.Nombre +
                                      " Descripcion " + producto.Descripcion +
                                      " Precio: " + producto.Precio + " $ " +
                                      " IdDepartamento " + producto.IdDepartamento +
                                      " IdProveedor " + producto.IdProveedor +
                                      " Imagen " + producto.Imagen +
                                      " Stock: " + producto.Stock);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }

        }
    }
}
