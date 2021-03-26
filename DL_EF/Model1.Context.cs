﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL_EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class JFernandezEcommerce2Entities : DbContext
    {
        public JFernandezEcommerce2Entities()
            : base("name=JFernandezEcommerce2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamento> Departamentoes { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<VentaProducto> VentaProductoes { get; set; }
    
        public virtual int AddSP(string nombre, string descripcion, Nullable<decimal> precio, Nullable<int> idDepartamento, Nullable<int> idProveedor, string imagen, Nullable<int> stock)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddSP", nombreParameter, descripcionParameter, precioParameter, idDepartamentoParameter, idProveedorParameter, imagenParameter, stockParameter);
        }
    
        public virtual int DeleteSP(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSP", idProductoParameter);
        }
    
        public virtual ObjectResult<GetSP_Result> GetSP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSP_Result>("GetSP");
        }
    
        public virtual int UpdateSP(string nombre, string descripcion, Nullable<decimal> precio, Nullable<int> idDepartamento, Nullable<int> idProveedor, string imagen, Nullable<int> stock, Nullable<int> idProducto)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            var idProveedorParameter = idProveedor.HasValue ?
                new ObjectParameter("IdProveedor", idProveedor) :
                new ObjectParameter("IdProveedor", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var stockParameter = stock.HasValue ?
                new ObjectParameter("Stock", stock) :
                new ObjectParameter("Stock", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSP", nombreParameter, descripcionParameter, precioParameter, idDepartamentoParameter, idProveedorParameter, imagenParameter, stockParameter, idProductoParameter);
        }
    
        public virtual int AddDepartamento(string nombre, Nullable<int> idArea)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddDepartamento", nombreParameter, idAreaParameter);
        }
    
        public virtual int DeleteDepartamento(Nullable<int> idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteDepartamento", idDepartamentoParameter);
        }
    
        public virtual ObjectResult<GetAllDepartamento_Result> GetAllDepartamento()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllDepartamento_Result>("GetAllDepartamento");
        }
    
        public virtual int UpdateDepartamento(string nombre, Nullable<int> idArea, Nullable<int> idDepartamento)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var idAreaParameter = idArea.HasValue ?
                new ObjectParameter("IdArea", idArea) :
                new ObjectParameter("IdArea", typeof(int));
    
            var idDepartamentoParameter = idDepartamento.HasValue ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDepartamento", nombreParameter, idAreaParameter, idDepartamentoParameter);
        }
    
        public virtual int DeleteVenta(Nullable<int> idVenta)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteVenta", idVentaParameter);
        }
    
        public virtual ObjectResult<GetAllVenta_Result> GetAllVenta()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllVenta_Result>("GetAllVenta");
        }
    
        public virtual int UpdateVenta(Nullable<int> idVenta, Nullable<int> idCliente, Nullable<double> total, Nullable<int> idMetodoPago, Nullable<System.DateTime> fecha)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("Total", total) :
                new ObjectParameter("Total", typeof(double));
    
            var idMetodoPagoParameter = idMetodoPago.HasValue ?
                new ObjectParameter("IdMetodoPago", idMetodoPago) :
                new ObjectParameter("IdMetodoPago", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateVenta", idVentaParameter, idClienteParameter, totalParameter, idMetodoPagoParameter, fechaParameter);
        }
    
        public virtual int AddVenta(ObjectParameter idVenta, Nullable<int> idCliente, Nullable<double> total, Nullable<int> idMetodoPago, Nullable<System.DateTime> fecha)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("Total", total) :
                new ObjectParameter("Total", typeof(double));
    
            var idMetodoPagoParameter = idMetodoPago.HasValue ?
                new ObjectParameter("IdMetodoPago", idMetodoPago) :
                new ObjectParameter("IdMetodoPago", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddVenta", idVenta, idClienteParameter, totalParameter, idMetodoPagoParameter, fechaParameter);
        }
    
        public virtual int AddVentaProducto(Nullable<int> idVenta, Nullable<int> idProductoSucursal, Nullable<int> cantidad, Nullable<int> idProducto)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            var idProductoSucursalParameter = idProductoSucursal.HasValue ?
                new ObjectParameter("IdProductoSucursal", idProductoSucursal) :
                new ObjectParameter("IdProductoSucursal", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddVentaProducto", idVentaParameter, idProductoSucursalParameter, cantidadParameter, idProductoParameter);
        }
    
        public virtual ObjectResult<GetAllVentaProducto_Result> GetAllVentaProducto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllVentaProducto_Result>("GetAllVentaProducto");
        }
    
        public virtual int DeleteVentaProducto(Nullable<int> idVenta)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteVentaProducto", idVentaParameter);
        }
    
        public virtual int UpdateVentaProducto(Nullable<int> idVentaProducto, Nullable<int> idVenta, Nullable<int> idProductoSucursal, Nullable<int> cantidad, Nullable<int> idProducto)
        {
            var idVentaProductoParameter = idVentaProducto.HasValue ?
                new ObjectParameter("IdVentaProducto", idVentaProducto) :
                new ObjectParameter("IdVentaProducto", typeof(int));
    
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            var idProductoSucursalParameter = idProductoSucursal.HasValue ?
                new ObjectParameter("IdProductoSucursal", idProductoSucursal) :
                new ObjectParameter("IdProductoSucursal", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateVentaProducto", idVentaProductoParameter, idVentaParameter, idProductoSucursalParameter, cantidadParameter, idProductoParameter);
        }
    }
}
