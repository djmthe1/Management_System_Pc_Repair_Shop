Create Table Usuarios(
	UsuarioId int Identity(1,1) Primary Key,
	Nombre varchar(50),
	Password varchar(50),
	Prioridad varchar(13)
)

Go

Create Table Piezas(
	PiezaId int Identity(1,1) Primary Key,
	Descripcion varchar(50),
)

Go

Create Table Marcas(
	MarcaId int Identity(1,1) Primary Key,
	Descripcion varchar(50),
)

Go

Create Table Clientes(
	ClienteId int Identity(1,1) Primary Key,
	NombreCompleto varchar(50),
	Direccion varchar(30),
)

Go

Create Table ClientesTelefonos(
	Id int Identity(1,1) Primary Key,
	ClienteId int References Clientes (ClienteId),
	Tipo varchar (12),
	Telefono varchar (12)
)

Go

create table Entradas(
	EntradaId int identity primary key,
	Fecha datetime,
	FechaEntrega datetime,
	ClienteId int References Clientes (ClienteId),
	Notas varchar (100),
	RecibidoPor varchar(20),
	Salio bit,
	Entregado bit
)

Go

Create Table EntradasArticulos(
	Id int Identity(1,1) Primary Key,
	EntradaId int References Entradas (EntradaId),
	Articulo varchar (100),
	Problema varchar (200)
)

Go

create table Salidas(
	SalidaId int identity primary key,
	Fecha datetime,
	EntradaId int References Entradas (EntradaId),
	Observacion varchar (200),
	RetiradoPor varchar(20)
)

Go

create table Facturas(
	FacturaId int identity primary key,
	Fecha datetime,
	EntradaId int References Entradas (EntradaId),
	ClienteId int References Clientes (ClienteId),
	CargoReparacion float,
	Total float,
	MontoAPagar float,
	DespachadoPor varchar(20)
)

Go

create table ArticulosVendidos(
	Id int identity primary key,
	FacturaId int References Facturas (FacturaId),
	Pieza varchar,
	Marca varchar,
	Precio float
)

Go

create table ArticulosEntregados(
	Id int identity primary key,
	FacturaId int References Facturas (FacturaId),
	Articulo varchar,
	Problema varchar,
	Cargo float
)

Go
