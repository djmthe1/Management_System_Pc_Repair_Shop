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
	Nombre varchar(40),
	Apellido varchar(40),
	Direccion varchar(30),
)

Go

Create Table ClientesTelefonos(
	Id int Identity(1,1) Primary Key,
	ClienteId int Foreign Key References Clientes (ClienteId),
	Tipo varchar (10),
	Telefono varchar (12)
)

Go

create table Entradas(
	EntradaId int identity primary key,
	Fecha date,
	FechaEntrega date,
	ClienteId int References Clientes (ClienteId),
	Notas varchar (100),
	RecibidoPor varchar(20),
	Salio bit
)

Go

Create Table EntradasArticulos(
	Id int Identity(1,1) Primary Key,
	EntradaId int Foreign Key References Entradas (EntradaId),
	Articulo varchar (100),
	Problema varchar (200)
)

Go

create table Salidas(
	SalidaId int identity primary key,
	Fecha date,
	EntradaId int References Entradas (EntradaId),
	Observacion varchar (200),
	Entregado bit,
	RetiradoPor varchar(20)
)

Go

create table Facturas(
	FacturaId int identity primary key,
	Fecha date,
	SalidaId int References Salidas (SalidaId),
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
