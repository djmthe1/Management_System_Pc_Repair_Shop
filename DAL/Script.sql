Create Table Usuarios(
	UsuarioId int Identity(1,1) Primary Key,
	Nombre varchar(50),
	Password varchar(50),
	Prioridad int
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
	Telefono varchar(15),
	Celular varchar(15),
	Direccion varchar(30),
	Cedula varchar(20),
	Sexo varchar(10)
)

Go

create table Entradas(
	EntradaNo int identity primary key,
	Fecha date,
	FechaEntrega date,
	Descripcion varchar (100),
	MontoAPagar int,
	RecibidoPor varchar(20)
)

Go

create table Facturas(
	FacturaNo int identity primary key,
	Fecha date,
	MontoAPagar int,
	AutorizadoPor varchar(20)
)

Go