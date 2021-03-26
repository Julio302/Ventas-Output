
create database JFernandezEcommerce2
use JFernandezEcommerce2


create table Area(
	IdArea int primary key identity(1,1),
	Nombre varchar(50)
)
insert into Area values('Comida y Bebidas')
create table Departamento(
	IdDepartamento int primary key identity(1,1),
	Nombre varchar(50),
	IdArea int FOREIGN KEY REFERENCES Area(IdArea)
)
insert into Departamento values('Departamento de comida', 1)

create table Proveedor(
	IdProveedor int primary key identity(1,1),
	Nombre varchar(50),
	Telefono varchar(10)
)
insert into Proveedor values('juan', '5512356847')

create table Producto(
	IdProducto 	int primary key identity(1,1),
	Nombre varchar(50),
	Descripcion varchar(50),
	Precio decimal,
	IdDepartamento int FOREIGN KEY REFERENCES Departamento(IdDepartamento),
	IdProveedor int FOREIGN KEY REFERENCES Proveedor(IdProveedor),
	Imagen varbinary(MAX),
	Stock int
)
insert into Producto values('Sabritas', 'frituras', 12.30, 1,1, null, 45)


alter procedure AddSP
	@Nombre varchar(50),
	@Descripcion varchar(50),
	@Precio decimal,
	@IdDepartamento int,
	@IdProveedor int,
	@Imagen varchar(50),
	@Stock int
	as
	Insert into Producto values (@Nombre, @Descripcion, @Precio, @IdDepartamento, @IdProveedor,@Imagen, @Stock)

create procedure DeleteSP
	@IdProducto int
	as
	Delete from Producto where Producto.IdProducto = @IdProducto

	
select * from Producto 
create procedure UpdateSP
	@Nombre varchar(50),
	@Descripcion varchar(50),
	@Precio decimal,
	@IdDepartamento int,
	@IdProveedor int,
	@Imagen varchar(50),
	@Stock int,
	@IdProducto int
	as
	Update Producto set 
	Nombre = @Nombre, 
	Descripcion = @Descripcion, 
	Precio = @Precio, 
	IdDepartamento = @IdDepartamento,
	IdProveedor = @IdProveedor,
	Imagen = @Imagen,
	Stock = @Stock
	where IdProducto = @IdProducto
	

	create procedure GetSP
	as
	select IdProducto, Nombre, Descripcion, Precio, IdDepartamento, IdProveedor, Imagen, Stock from Producto


	select * from Departamento

	create procedure AddDepartamento
	@Nombre varchar(50),
	@IdArea int
	as
	insert into Departamento values (@Nombre, @IdArea)

	create procedure DepartamentoDelete
	@IdDepartamento int
	as
	Delete from Departamento where IdDepartamento = @IdDepartamento


	create procedure DepartamentoUpdate
	@Nombre varchar(50),
	@IdArea int,
	@IdDepartamento int
	as
	Update Departamento set Nombre = @Nombre, IdArea = @IdArea where IdDepartamento = @IdDepartamento


	create procedure DepartamentoGetAll
	as
	SELECT IdDepartamento, Nombre, IdArea FROM Departamento