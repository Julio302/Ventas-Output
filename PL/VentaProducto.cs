using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class VentaProducto
    {
        /*Delete con EF*/
        public static void VentaProductoDelete()
        {
            Console.WriteLine("Ingresa el id de la venta");
            int IdVenta = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();
            result = BL.VentaProducto.VentaProductoDelete(IdVenta);

            if (result.Correct)
            {
                Console.WriteLine("VentaProducto eliminado con exito EF");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    
        /*Update con EF*/
        public static void VentaProductoUpdate()
        {
            ML.VentaProducto ventaProducto = new ML.VentaProducto();
            Console.WriteLine("Ingresa IdVentaProducto");
            ventaProducto.IdVentaProducto = int.Parse(Console.ReadLine());
            Console.WriteLine("IdVenta");
            ventaProducto.Venta = new ML.Venta();
            ventaProducto.Venta.IdVenta = int.Parse(Console.ReadLine());

            Console.WriteLine("IdProductoSucursal");
            ventaProducto.ProductoSucursal = new ML.ProductoSucursal();
            ventaProducto.ProductoSucursal.IdProductoSucursal = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad");
            ventaProducto.Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("IdProducto");
            ventaProducto.Producto = new ML.Producto();
            ventaProducto.Producto.IdProducto = int.Parse(Console.ReadLine());

            ML.Result result = new ML.Result();

            result = BL.VentaProducto.VentaProductoUpdate(ventaProducto);
            if (result.Correct)
            {
                Console.WriteLine("Modificacion de ventaProducto con EF");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    
        /*GetAll Con EF*/
        public static void VentaProductoGetAll()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla de ventaProductos usando ENTITY");
            result = BL.VentaProducto.VentaProductoGetAll();

            if (result.Correct)
            {
                foreach (ML.VentaProducto ventaProducto in result.Objects)
                {
                    Console.WriteLine("IdVentaProducto: " + ventaProducto.IdVentaProducto + " IdVenta " + ventaProducto.Venta.IdVenta + " IdProductoSucursal " + ventaProducto.ProductoSucursal.IdProductoSucursal + " Cantidad "+ventaProducto.Cantidad + " IdProducto "+ventaProducto.Producto.IdProducto);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    }
}
