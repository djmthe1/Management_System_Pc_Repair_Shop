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
	ClienteId int References Clientes (ClienteId),
	Telefono varchar (12),
)

Go

create table Entradas(
	EntradaId int identity primary key,
	Fecha date,
	FechaEntrega date,
	ClienteId int References Clientes (ClienteId),
	Problemas varchar (100),
	Notas varchar (100),
	RecibidoPor varchar(20)
)

Go

Create Table EntradasArticulos(
	Id int Identity(1,1) Primary Key,
	EntradaId int References Entradas (EntradaId),
	Articulo varchar (100),
)

Go

create table Facturas(
	FacturaNo int identity primary key,
	Fecha date,
	MontoAPagar int,
	DespachadoPor varchar(20)
)

Go