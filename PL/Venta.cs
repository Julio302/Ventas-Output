using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Venta
    {
        /*ADO CON SP*/
        //public static void VentaAdd()
        //{
        //    ML.Venta venta = new ML.Venta();
        //    Console.WriteLine("Ingresa IdCliente");
        //    venta.IdCliente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa Total");
        //    venta.Total = float.Parse(Console.ReadLine());
        //    Console.WriteLine("IdMetodo Pago");
        //    venta.IdMetodoPago = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Fecha");
        //    venta.Fecha = DateTime.Now;

        //    ML.Result result = new ML.Result();
        //    result = BL.Venta.VentaAdd(venta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Venta Realizada con SP");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaDelete()
        //{
        //    Console.WriteLine("Ingresa IdVenta");
        //    int IdVenta = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Venta.VentaDelete(IdVenta);

        //    if(result.Correct)
        //    {
        //        Console.WriteLine("La venta se a eliminado SP");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaUpdate()
        //{
        //    ML.Venta venta = new ML.Venta();
        //    Console.WriteLine("Ingresa IdVenta a modificar");
        //    venta.IdVenta = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa IdCliente nuevo");
        //    venta.IdCliente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa Total nuevo");
        //    venta.Total = float.Parse(Console.ReadLine());
        //    Console.WriteLine("IdMetodo Pago nuevo");
        //    venta.IdMetodoPago = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Fecha");
        //    venta.Fecha = DateTime.Now;

        //    ML.Result result = new ML.Result();
        //    result = BL.Venta.VentaUpdate(venta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Venta Modificada con SP");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaGetAll()
        //{
        //    ML.Result result = new ML.Result();
        //    Console.WriteLine("Tabla de ventas con SP");
        //    result = BL.Venta.VentaGetAll();

        //    foreach (ML.Venta venta in result.Objects)
        //    {
        //        Console.WriteLine("IdVenta: " + venta.IdVenta + " IdCliente:" + venta.IdCliente + " Total: " + venta.Total + " IdMetodoPago: " +venta.IdMetodoPago + " Fecha"+ venta.Fecha );
        //    }
        //}
  
        /*ENTITY*/
        //public static void VentaAddEF()
        //{
        //    ML.Venta venta = new ML.Venta();
        //    Console.WriteLine("Ingresa IdCliente");
        //    venta.IdCliente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa Total");
        //    venta.Total = float.Parse(Console.ReadLine());
        //    Console.WriteLine("IdMetodo Pago");
        //    venta.IdMetodoPago = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Fecha");
        //    venta.Fecha = DateTime.Now;

        //    ML.Result result = new ML.Result();
        //    result = BL.Venta.VentaAddET(venta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Venta Realizada con ENTITY");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaDeleteEF()
        //{
        //    Console.WriteLine("Ingresa IdVenta");
        //    int IdVenta = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Venta.VentaDeleteEF(IdVenta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("La venta se a eliminado ENTITY");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaUpdateEF()
        //{
        //    ML.Venta venta = new ML.Venta();
        //    Console.WriteLine("Ingresa IdVenta a modificar");
        //    venta.IdVenta = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa IdCliente nuevo");
        //    venta.IdCliente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa Total nuevo");
        //    venta.Total = float.Parse(Console.ReadLine());
        //    Console.WriteLine("IdMetodo Pago nuevo");
        //    venta.IdMetodoPago = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Fecha");
        //    venta.Fecha = DateTime.Now;

        //    ML.Result result = new ML.Result();
        //    result = BL.Venta.VentaUpdateEF(venta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Venta Modificada con ENTITY");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaGetAllEF()
        //{

        //    ML.Result result = new ML.Result();
        //    Console.WriteLine("Tabla de ventas con ENTITY");
        //    result = BL.Venta.VentaGetAllEF();

        //    foreach (ML.Venta venta in result.Objects)
        //    {
        //        Console.WriteLine("IdVenta: " + venta.IdVenta + " IdCliente:" + venta.IdCliente + " Total: " + venta.Total + " IdMetodoPago: " + venta.IdMetodoPago + " Fecha" + venta.Fecha);
        //    }
        //}
    
    
        /*LINQ*/
        //public static void VentaAddLinq()
        //{
        //    ML.Venta venta = new ML.Venta();
        //    Console.WriteLine("Ingresa IdCliente");
        //    venta.IdCliente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa Total");
        //    venta.Total = float.Parse(Console.ReadLine());
        //    Console.WriteLine("IdMetodo Pago");
        //    venta.IdMetodoPago = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Fecha");
        //    venta.Fecha = DateTime.Now;

        //    ML.Result result = new ML.Result();
        //    result = BL.Venta.VentaAddLinq(venta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Venta Realizada con LINQ");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaDeleteLinq()
        //{
        //    Console.WriteLine("Ingresa IdVenta");
        //    int IdVenta = int.Parse(Console.ReadLine());

        //    ML.Result result = BL.Venta.VentaDeleteLinq(IdVenta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("La venta se a eliminado linq");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaUpdateLinq()
        //{
        //    ML.Venta venta = new ML.Venta();
        //    Console.WriteLine("Ingresa IdVenta a modificar");
        //    venta.IdVenta = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa IdCliente nuevo");
        //    venta.IdCliente = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Ingresa Total nuevo");
        //    venta.Total = float.Parse(Console.ReadLine());
        //    Console.WriteLine("IdMetodo Pago nuevo");
        //    venta.IdMetodoPago = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Fecha");
        //    venta.Fecha = DateTime.Now;

        //    ML.Result result = new ML.Result();
        //    result = BL.Venta.VentaUpdateLinq(venta);

        //    if (result.Correct)
        //    {
        //        Console.WriteLine("Venta Modificada con LINQ");
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.ErrorMessage);
        //    }
        //}

        //public static void VentaGetAllLinq()
        //{
        //    ML.Result result = new ML.Result();
        //    Console.WriteLine("Tabla de ventas con LINQ");
        //    result = BL.Venta.VentaGetAllLinq();

        //    foreach (ML.Venta venta in result.Objects)
        //    {
        //        Console.WriteLine("IdVenta: " + venta.IdVenta + " IdCliente:" + venta.IdCliente + " Total: " + venta.Total + " IdMetodoPago: " + venta.IdMetodoPago + " Fecha" + venta.Fecha);
        //    }
        //}
    
    
        /*Venta y VentaDetalle con EF*/
        public static void VentaAdd()
        {
            ML.Venta venta = new ML.Venta();
            Console.WriteLine("Ingresa IdCliente");
            venta.IdCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Total");
            venta.Total = float.Parse(Console.ReadLine());
            Console.WriteLine("IdMetodo Pago");
            venta.IdMetodoPago = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha");
            venta.Fecha = DateTime.Now;

            ML.Result result = new ML.Result();

            //** insertacion de productos*/
            //ML.Producto producto = new ML.Producto();
            //result = BL.Producto.ProductoGetAllLinq();

            result.Objects = new List<object>();
            result.Objects.Add(new ML.Producto() { IdProducto = 2, Nombre = "sabritas" });
            result.Objects.Add(new ML.Producto() { IdProducto = 3, Nombre = "caramelo" });

            result = BL.Venta.VentaAdd(venta,result.Objects);
            
            if (result.Correct)
            {
                Console.WriteLine("Venta y ventaproducto Realizado con ENTITY");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }


        /*Venta y Detalle con ADO SP*/
        public static void VentaAddADOSP()
        {
            ML.Venta venta = new ML.Venta();

            Console.WriteLine("Ingresa IdCliente");
            venta.IdCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Total");
            venta.Total = float.Parse(Console.ReadLine());
            Console.WriteLine("IdMetodo Pago");
            venta.IdMetodoPago = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha");
            venta.Fecha = DateTime.Now;

            ML.Result result = new ML.Result();

            //** insertacion de productos selecionar productos esto se hara con session y productos seleccionados*/
            //ML.Producto producto = new ML.Producto();
            //result = BL.Producto.ProductoGetAllLinq();


            result.Objects = new List<object>();
            result.Objects.Add(new ML.Producto() { IdProducto = 2, Nombre = "sabritas" });
            result.Objects.Add(new ML.Producto() { IdProducto = 3, Nombre = "caramelo" });

            result = BL.Venta.VentaAddADOSP(venta, result.Objects);

            if (result.Correct)
            {
                Console.WriteLine("Venta y ventaproducto Realizado con ADO SP");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }

        }

        /* PROBLEMA COLLECTION Venta y VentaDetalle con ADO NET COLLECTION */

        public static void VentaAddADONET()
        {
            ML.Venta venta = new ML.Venta();
            Console.WriteLine("Ingresa IdCliente");
            venta.IdCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa Total");
            venta.Total = float.Parse(Console.ReadLine());
            Console.WriteLine("IdMetodo Pago");
            venta.IdMetodoPago = int.Parse(Console.ReadLine());
            Console.WriteLine("Fecha");
            venta.Fecha = DateTime.Now;

            ML.Result result = new ML.Result();

            //** insertacion de productos*/
            result.Objects = new List<object>();
            result.Objects.Add(new ML.Producto() { IdProducto = 2, Nombre = "sabritas" });
            result.Objects.Add(new ML.Producto() { IdProducto = 3, Nombre = "caramelo" });

            result = BL.Venta.VentaAddADONET(venta, result.Objects);

            if (result.Correct)
            {
                Console.WriteLine("Venta y ventaproducto Realizado con ADO NET Collection");
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
 

        /*GetAll Venta EF*/
        public static void VentaGetAllEF()
        {
            ML.Result result = new ML.Result();
            Console.WriteLine("Tabla de venta usando ENTITY");
            result = BL.Venta.VentaGetAllEF();

            if (result.Correct)
            {
                foreach (ML.Venta venta in result.Objects)
                {
                    Console.WriteLine("IdVenta: " + venta.IdVenta + " IdCliente " + venta.IdCliente + " Total " + venta.Total + " Fecha "+venta.Fecha);
                }
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
        }
    }
}
