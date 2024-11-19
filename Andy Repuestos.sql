-- Creacion y puesta en uso de la base de datos
Create database andyrepuestobd
use andyrepuestobd

-- Creacion de las tablas
create table empleados(
id int identity (1,1),
nombre varchar(40),
apellido varchar(40),
genero varchar(20),
fechadenacimiento date,
numerodetelefono varchar(20),
correoelectronico varchar(100),
estadocivil varchar(10),
cargo varchar(50),
fechadecontratacion date,
salario money,
nombredeusuario varchar(30),
contraseña varchar(8)
)
CREATE TABLE productos (
id INT identity (1,1),
nombre VARCHAR(100),
precio money,
stock INT,
fecha_ingreso DATE,
categoria VARCHAR(50)
)
create table facturas(
codigodefactura int identity(1,1),
cliente varchar(100),
numerodetelefono NVARCHAR(MAX),
dniocedula NVARCHAR(MAX),
numerodecuenta NVARCHAR(MAX),
fechadefacturacion date,
metododepago varchar(100),
productos varchar(3000),
itbis money,
total money
)

drop table facturas
-- Insercion de datos en las tablas - alimentacion del proyecto
INSERT INTO facturas (cliente, fechadefacturacion, metododepago, productos, total)
VALUES
('Cliente1', '2024-05-01', 'Tarjeta de crédito', 'Producto1, Producto2, Producto3', 150.00),
('Cliente2', '2024-05-02', 'Transferencia bancaria', 'Producto4, Producto5', 200.00),
('Cliente3', '2024-05-03', 'Efectivo', 'Producto6', 50.00),
('Cliente4', '2024-05-04', 'Tarjeta de débito', 'Producto7, Producto8, Producto9', 300.00),
('Cliente5', '2024-05-05', 'Cheque', 'Producto10, Producto11, Producto12', 250.00),
('Cliente6', '2024-05-06', 'Tarjeta de crédito', 'Producto13', 100.00),
('Cliente7', '2024-05-07', 'Transferencia bancaria', 'Producto14, Producto15', 180.00),
('Cliente8', '2024-05-08', 'Efectivo', 'Producto16, Producto17', 320.00),
('Cliente9', '2024-05-09', 'Tarjeta de débito', 'Producto18, Producto19', 70.00),
('Cliente10', '2024-05-10', 'Cheque', 'Producto20', 400.00);
INSERT INTO empleados (nombre, apellido, genero, fechadenacimiento, numerodetelefono, correoelectronico, estadocivil, cargo, fechadecontratacion, salario, nombredeusuario, contraseña)
VALUES 
('Juan', 'Pérez', 'M', '1990-05-15', 123456789, 'juan.perez@example.com', 'Soltero/a', 'Gerente de Tienda', '2015-02-10', 50000, 'jperez', 'pass3'),
('María', 'González', 'F', '1985-10-20', 987654321, 'maria.gonzalez@example.com', 'Casado/a', 'Asistente de Ventas', '2016-07-01', 35000, 'mgonzalez', 'clave6'),
('Pedro', 'López', 'M', '1992-03-08', 555666777, 'pedro.lopez@example.com', 'Soltero/a', 'Almacenero', '2019-09-15', 30000, 'plopez', 'seguro78'),
('Luisa', 'Martínez', 'F', '1988-12-12', 333444555, 'luisa.martinez@example.com', 'Casado/a', 'Vendedor/a', '2017-03-20', 38000, 'lmartinez', 'access3'),
('Carlos', 'Sánchez', 'M', '1987-08-25', 666777888, 'carlos.sanchez@example.com', 'Soltero/a', 'Encargado de Almacén', '2014-11-11', 45000, 'csanchez', 'segu1'),
('Ana', 'Rodríguez', 'F', '1995-06-30', 999000111, 'ana.rodriguez@example.com', 'Soltero/a', 'Asistente de Compras', '2018-05-05', 32000, 'arodriguez', 'clave34'),
('José', 'Gómez', 'M', '1983-04-18', 444555666, 'jose.gomez@example.com', 'Casado/a', 'Gerente de Marketing', '2013-09-01', 55000, 'jgomez', 'conta'),
('Laura', 'Hernández', 'F', '1991-09-08', 888999000, 'laura.hernandez@example.com', 'Casado/a', 'Contador/a', '2012-08-10', 60000, 'lhernandez', 'admin3'),
('Daniel', 'Díaz', 'M', '1994-11-25', 222333444, 'daniel.diaz@example.com', 'Soltero/a', 'Técnico de Reparación', '2020-10-15', 40000, 'ddiaz', 'sa567'),
('Sofía', 'Ramírez', 'F', '1993-07-05', 111222333, 'sofia.ramirez@example.com', 'Casado/a', 'Recepcionista', '2019-04-03', 32000, 'sramirez', 'acce');
INSERT INTO productos (nombre, precio, stock, fecha_ingreso, categoria)
VALUES
('Filtro de aceite', 10.99, 100, '2023-05-10', 'Filtros'),
('Pastillas de freno', 29.99, 50, '2023-04-25', 'Frenos'),
('Batería para automóvil', 99.99, 20, '2023-06-05', 'Baterías'),
('Llanta de aleación', 149.99, 30, '2023-05-02', 'Llantas'),
('Bujías de encendido', 8.99, 80, '2023-08-20', 'Encendido'),
('Aceite de motor sintético', 39.99, 60, '2023-07-15', 'Aceites'),
('Filtro de aire', 15.99, 100, '2023-09-10', 'Filtros'),
('Amortiguador', 59.99, 40, '2023-08-05', 'Suspensión'),
('Radiador', 89.99, 25, '2023-10-02', 'Refrigeración'),
('Espejo retrovisor', 49.99, 30, '2023-11-15', 'Espejos'),
('Correa de distribución', 24.99, 35, '2023-12-20', 'Correas'),
('Filtro de combustible', 12.99, 45, '2024-01-25', 'Filtros'),
('Termostato', 19.99, 20, '2024-02-10', 'Termostatos'),
('Bomba de agua', 39.99, 15, '2024-03-05', 'Bombas de Agua'),
('Foco delantero', 14.99, 50, '2024-04-10', 'Iluminación'),
('Kit de embrague', 149.99, 10, '2024-05-15', 'Embragues'),
('Juego de cables de bujías', 24.99, 30, '2024-06-20', 'Encendido')
-- Consultas
select * from empleados
select * from facturas
select * from productos

-- DROPS
drop table productos
drop table facturas
drop table empleados

-- DELETE
delete from empleados
delete facturas
delete from productos

insert into facturas values (@cliente,@numerodetelefono,@dniocedula,@numerodecuenta,@fechadefacturacion,@metododepago,@productos,@itis,@total)