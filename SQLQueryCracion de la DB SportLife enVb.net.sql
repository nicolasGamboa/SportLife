SET DATEFORMAT DMY
create table Categorias(
						id_cat int primary key,
						descrip nvarchar (50)
						)

INSERT INTO Categorias (id_cat, descrip) VALUES (1,'Empleado')
INSERT INTO Categorias (id_cat, descrip) VALUES (2,'Gerente')
INSERT INTO Categorias (id_cat, descrip) VALUES (3,'DBA')

create table Provincias(
						id_Prov int primary key,
						descrip varchar (50)
						)

INSERT INTO Provincias(id_Prov, descrip) VALUES (1,'Corrientes')

create table Localidades(
						id_Prov int,
						id_Loc int,
						descrip varchar (50),
						constraint PK_Prov_Loc primary key(id_Prov, id_Loc),
						constraint FK_Prov foreign key (id_Prov) references Provincias(id_Prov)
						) 

INSERT INTO Localidades(id_Prov,id_Loc,descrip) VALUES (1,1,'Ctes. Cap')
INSERT INTO Localidades(id_Prov,id_Loc,descrip) VALUES (1,2,'Empedrado')
INSERT INTO Localidades(id_Prov,id_Loc,descrip) VALUES (1,3,'Bella Vista')
INSERT INTO Localidades(id_Prov,id_Loc,descrip) VALUES (1,4,'Formosa')



create table Sucursales(
						id_Suc int primary key,
						id_Prov int,
						id_Loc int,
						nombre varchar (50),
						direccion varchar (50),
						telefono varchar (12),
						email varchar (50),
						constraint FK_Loc foreign key (id_Prov, id_Loc) references Localidades(id_Prov, id_Loc)
						)


INSERT INTO Sucursales(id_Suc,id_Prov, id_Loc,nombre, direccion,telefono,email) VALUES (1,1,1,'Sucursal Alvear','Alvear 2817','3795-828834','sportalvear@store.com')
INSERT INTO Sucursales(id_Suc,id_Prov, id_Loc, nombre,direccion,telefono,email) VALUES (2,1,2,'Sucursal 3de Abril','Av. 3 de Abril 1427','3795-224456','sportabril@store.com')
INSERT INTO Sucursales(id_Suc,id_Prov, id_Loc, nombre,direccion,telefono,email) VALUES (3,1,3,'Sucursal San Juan','San Juan 2737','3794-142785','sportsanjuan@store.com')



create table TipoUs(
					id_tipoUs int  primary key,
					descrip varchar (50)
					)
					

INSERT INTO TipoUs(id_tipoUs, descrip) VALUES (1,'Persona')
INSERT INTO TipoUs(id_tipoUs, descrip) VALUES (2,'Empresa')


create table Consultas(
						id_Consulta int primary key,
						descrip varchar (100)
						)


create table Rubros(
					cod_Rubro int primary key,
					descrip varchar (50)
					)

INSERT INTO Rubros(cod_Rubro, descrip) VALUES (1,'Calzados')
INSERT INTO Rubros(cod_Rubro, descrip) VALUES (2,'Remeras')
INSERT INTO Rubros(cod_Rubro, descrip) VALUES (3,'Camisas')
INSERT INTO Rubros(cod_Rubro, descrip) VALUES (4,'Pantalones')
INSERT INTO Rubros(cod_Rubro, descrip) VALUES (5,'Shorts')
INSERT INTO Rubros(cod_Rubro, descrip) VALUES (6,'Otros')

create table Colores (
						cod_Color int primary key,
						descrip varchar (50)
						)
					

INSERT INTO Colores (cod_Color, descrip) VALUES (1,'Amarillo')
INSERT INTO Colores (cod_Color, descrip) VALUES (2,'Azul')
INSERT INTO Colores (cod_Color, descrip) VALUES (3,'Verde')
INSERT INTO Colores (cod_Color, descrip) VALUES (4,'Blanco')
INSERT INTO Colores (cod_Color, descrip) VALUES (5,'Negro')
INSERT INTO Colores (cod_Color, descrip) VALUES (6,'Rojo')
INSERT INTO Colores (cod_Color, descrip) VALUES (7,'Estampado')



create table EstadosProd(
						id_estado int primary key,
						descrip varchar (20)
						)
INSERT INTO EstadosProd(id_estado, descrip) VALUES (1,'Disponible')
INSERT INTO EstadosProd(id_estado, descrip) VALUES (2,'Agotado')



create table Productos(
						id_Prod int primary key,
						nom_Prod nvarchar (50),
						cod_Rubro int,
						PrecioVta decimal(18,2),
						PrecioCompra decimal(18,2),
						cant_Stock int,
						cod_Color int,
						cod_Talle varchar(10),
						id_estado int Default 1,
						constraint FK_Rubros foreign key (cod_Rubro) references Rubros(cod_Rubro),
						constraint FK_Estados foreign key (id_estado) references EstadosProd(id_estado),
						constraint FK_Color foreign key (cod_Color) references Colores(cod_Color)
						)

INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (1,'Remera AirBike',2,200,80,100,1,'Chico',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (2,'Remera AirBike',2,200,80,0,2,'Mediano',2)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (3,'Remera AirBike',2,200,80,70,3,'Mediano',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (4,'Remera AirBike',2,200,80,100,5,'Chico',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (5,'Calzado AirBike',1,540,200,100,1,'Mediano',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (6,'Calzado AirBike',1,540,200,0,3,'Mediano',2)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (7,'Calzado AirBike',1,540,200,100,5,'Chico',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (8,'Calzado AirBike',1,540,200,100,6,'Grande',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (9,'PantalonesAirBike',4,200,80,100,1,'Grande',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (10,'Pantalone AirBike',4,180,70,0,1,'Chico',2)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (11,'Pantalone AirBike',4,180,70,80,1,'Grande',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (12,'Pantalone AirBike',4,180,70,30,1,'Mediano',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (13,'Short AirBike',5,150.99,80.5,0,7,'Grande',2)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (14,'Short AirBike',5,150.99,80.5,100,6,'Grande',1)
INSERT INTO Productos(id_Prod, nom_Prod,cod_Rubro,PrecioVta,PrecioCompra,cant_Stock,cod_Color,cod_Talle,id_estado) VALUES (15,'Media AirBike',6,70,20,500,1,'Grande',1)

create table Sexo(
					id_sexo int primary key,
					descrip varchar (20)
					)
					
INSERT INTO Sexo(id_sexo, descrip) VALUES (1,'Hombre')
INSERT INTO Sexo(id_sexo, descrip) VALUES (2,'Mujer')

create table Estados(
						id_estado int primary key,
						descrip varchar (20)
						)
INSERT INTO Estados(id_estado, descrip) VALUES (1,'Activo')
INSERT INTO Estados(id_estado, descrip) VALUES (2,'Inactivo')

create table Clientes(
						nro_Cliente int primary key,
						nombre nvarchar (50),
						apellido nvarchar (50),
						dni int,
						f_nac date default getdate(),
						telefono nvarchar (50),
						email nvarchar (50),
						direccion nvarchar (50),
						id_tipoUs int default (1),
						id_estado int default 1,
						id_sexo int,
						constraint FK_tipoUs foreign key (id_tipoUs) references TipoUs(id_tipoUs),
						constraint FK_id_estado foreign key (id_estado) references Estados(id_estado),
						constraint FK_Sexo foreign key (id_sexo) references Sexo(id_sexo)
						)

INSERT INTO Clientes (nro_Cliente, nombre, apellido, dni, f_nac, telefono, email, direccion, id_tipoUs, id_estado, id_sexo) VALUES (1,'Jose Alberto', 'Ramirez', 34568897, '12-11-1991', '3794-722568', 'nonmail@nothig.com', 'Pasaje cabrera 2017', 1, 2, 1)
INSERT INTO Clientes (nro_Cliente, nombre, apellido, dni, f_nac, telefono, email, direccion, id_tipoUs, id_estado, id_sexo) VALUES (2,'Martina Daniela', 'Perez', 25288960, '03-04-1992', '3794-730020', 'nonmail@nothig.com', 'Ramon Horinaga 2019', 2, 1, 2)
INSERT INTO Clientes (nro_Cliente, nombre, apellido, dni, f_nac, telefono, email, direccion, id_tipoUs, id_estado, id_sexo) VALUES (3,'Ramon Horacio', 'Gonzalez', 34568020, '01-10-1991', '3794-999564', 'nonmail@nothig.com', 'Pasaje Orindu 207', 1, 1, 1)
INSERT INTO Clientes (nro_Cliente, nombre, apellido, dni, f_nac, telefono, email, direccion, id_tipoUs, id_estado, id_sexo) VALUES (4,'Maria Teresa', 'Gomez', 1564856, '15-08-2001', '3794-456852', 'nonmail@nothig.com', 'Av. 3 de Abril 637', 1, 1, 2)



create table Empleados(
						id_Empleado int primary key,
						DNI int,
						Usuario nvarchar (50),
						Pass nvarchar (50),
						Nombre nvarchar (50),
						Apellido nvarchar (50),
						FechaNacimiento date,
						FechaIngreso date default getdate(),
						id_estado int default 1,--default activo
						id_cat int,
						id_sexo int,
						id_Suc int,
						constraint FK_id_cat foreign key (id_cat) references Categorias(id_cat),
						constraint FK_id_estadoEmp foreign key (id_estado) references Estados(id_estado),
						constraint FK_SucEmp foreign key (id_Suc) references Sucursales(id_Suc),
						constraint FK_SexoEmp foreign key (id_sexo) references Sexo(id_sexo)
						)

INSERT INTO Empleados (id_Empleado, DNI,Usuario, Pass,Nombre, Apellido, FechaNacimiento,FechaIngreso, id_estado,id_cat,id_sexo,id_Suc) VALUES (1,32020360,'admin','pasword1', 'Martin', 'Perez', '25-12-1991',GETDATE(),1, 1,1,1)
INSERT INTO Empleados (id_Empleado, DNI, Usuario,Pass,Nombre, Apellido, FechaNacimiento,FechaIngreso, id_estado,id_cat,id_sexo,id_Suc) VALUES (2,25218020,'admin','pasword1', 'Jorge', 'Gomes', '25-10-1992',GETDATE(),2,1,1,2)
INSERT INTO Empleados (id_Empleado, DNI, Usuario,Pass,Nombre, Apellido, FechaNacimiento,FechaIngreso, id_estado,id_cat,id_sexo,id_Suc) VALUES (3,32015420,'admin','pasword1', 'Manuel', 'Elizondo', '25-05-1998',GETDATE(),1,2,1,2)
INSERT INTO Empleados (id_Empleado, DNI, Usuario,Pass,Nombre, Apellido, FechaNacimiento,FechaIngreso, id_estado,id_cat,id_sexo,id_Suc) VALUES (4,32030512,'admin','pasword1', 'Jose', 'Nabarro', '25-09-1991',GETDATE(),2,3,1,3 )
INSERT INTO Empleados (id_Empleado, DNI, Usuario,Pass,Nombre, Apellido, FechaNacimiento,FechaIngreso, id_estado,id_cat,id_sexo,id_Suc) VALUES (5,12345688,'admin','pasword1', 'Viviana', 'Morel', '25-01-1990',GETDATE(),1,1,2,3)
INSERT INTO Empleados (id_Empleado, DNI, Usuario,Pass,Nombre, Apellido, FechaNacimiento,FechaIngreso, id_estado,id_cat,id_sexo,id_Suc) VALUES (6,34895020,'admin','pasword1', 'Noelia', 'Barrientos', '25-02-1989',GETDATE(),1,3,2,1)


create table Factura(
						id_Factura int primary key,
						id_Empleado int,
						nro_Cliente int,
						importe decimal (18,2),
						fecha date,
						id_Suc int,
						constraint FK_Emp foreign key (id_Empleado) references Empleados(id_Empleado),
						constraint FK_Cli foreign key (nro_Cliente) references Clientes(nro_Cliente),
						constraint FK_Suc foreign key (id_Suc) references Sucursales(id_Suc)
						)
						
INSERT INTO Factura (id_Factura, id_Empleado, nro_Cliente, importe, fecha, id_Suc) VALUES (1,1,1,400,GETDATE(),1)
INSERT INTO Factura (id_Factura, id_Empleado, nro_Cliente, importe, fecha, id_Suc) VALUES (2,5,2,400,GETDATE(),2)
INSERT INTO Factura (id_Factura, id_Empleado, nro_Cliente, importe, fecha, id_Suc) VALUES (3,3,3,400,GETDATE(),3)
INSERT INTO Factura (id_Factura, id_Empleado, nro_Cliente, importe, fecha, id_Suc) VALUES (4,2,4,400,GETDATE(),2)


create table Detalle(
id_Detalle int primary key,
id_Factura int,
id_Prod int,
cantidad int,
precio decimal(18,2),
constraint FK_Fact foreign key (id_Factura) references Factura(id_Factura),
constraint FK_Prod foreign key (id_Prod) references Productos(id_Prod))

INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (1,1,1,2,200)
INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (2,1,1,2,200)
INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (3,2,1,1,200)
INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (4,3,1,2,200)
INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (5,4,1,2,200)
INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (6,2,1,1,200)
INSERT INTO Detalle (id_Detalle, id_Factura, id_Prod, cantidad, precio) VALUES (7,3,1,2,200)