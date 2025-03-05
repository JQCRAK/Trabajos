USE northwind
CREATE TABLE customer
(cust_id int, company varchar(40),contact varchar(30), phone char(12) )
GOUSE northwind
GRANT SELECT ON products TO public
GO

USE northwind
SELECT productname
, (unitsinstock - unitsonorder) -- Calcula el inventario
, supplierid
FROM products
GO

USE northwind
SELECT productname
, (unitsinstock - unitsonorder) -- Calcula el inventario
-- , supplierid
FROM products
GO/*
Este código devuelve todas las filas de la tabla
products y muestra el precio por unidad, el precio
aumentado en un 10 por ciento y el nombre del producto.
*/
USE northwind
SELECT unitprice, (unitprice * 1.1), productname
FROM products
GO
DECLARE @v1 int SET @v1 = 0
WHILE @v1 < 100
 BEGIN  SELECT @v1 = (@v1 + 1)
 SELECT @v1
 END
USE northwind
DECLARE @EmpID varchar(11)
 ,@vlName char(20)
SET @vlname = 'Dodsworth'
SELECT @EmpID = employeeid
FROM employees
WHERE LastName = @vlname
SELECT @EmpID AS EmployeeID
GO
--EmployeeID 9(1 fila afectada)USE northwind
SELECT AVG(unitprice) AS AvgPrice
FROM products
GO
/*AvgPrice 28.8663 (1 fila afectada) */USE northwind
SELECT DB_NAME() AS 'database'
GO /*La función DB_NAME() (con guion bajo) es la que se utiliza para obtener el nombre de la base de datos actual.
R: database Northwind (1 fila afectada) *//*SELECT *  Funciones de conjuntos de filas
FROM OPENQUERY(OracleSvr, 'SELECT name, id FROM owner.titles')
GO*/SELECT 'ANSI:', CONVERT (varchar(30), GETDATE(), 102) AS Style
UNION
SELECT 'Japanese:', CONVERT(varchar(30), GETDATE(), 111)
UNION
SELECT 'European:', CONVERT(varchar(30), GETDATE(), 113)
GO/*Style salio la fecha actual que se esta haciendo las consultas
European: 19 Mar 1998 16:34:40:616
Japanese: 1998/03/19
ANSI: 1998.03.19*/SET DATEFORMAT dmy
GO
DECLARE @vdate datetime
SET @vdate = '29/11/98'
SELECT @vdate
GO/*1998-11-29 00:00:00.000 resultado esperado
(1 fila afectada)*/USE Northwind--se creo una libreria con el codigo de abajo, pero no asi sido 
--necesario se creo por error prque en vez de libreria a sido de poner el nombre Northwind
SELECT user_name(), app_name()
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'library')
BEGIN
    CREATE DATABASE library;
END
GO

USE library;
GO

SELECT user_name() AS 'User Name', app_name() AS 'Application Name';
GO

/*dbo Analizador de consultas SQL
(1 fila afectada)*/USE Northwind
SELECT COLUMNPROPERTY(OBJECT_ID('member'), 'firstname',
'AllowsNull')
GO/*0 respuesta esperada
(1 fila afectada)*/SELECT OrderID, ProductID
 ,(UnitPrice * Quantity) as ExtendedAmount
FROM [Order Details]
WHERE (UnitPrice * Quantity) > 10000
GO /* respuesta esperadaOrderID ProductID ExtendedAmount
10353 38 10540.0000
10417 38 10540.0000
10424 38 10329.2000
10865 38 15810.0000
10889 38 10540.0000
10981 38 15810.0000
(6 filas afectadas)*/USE northwind
IF EXISTS (SELECT * FROM orders
 WHERE customerid = 'frank')
 PRINT '*** Customer cannot be deleted ***'
ELSE
 BEGIN
 DELETE customers WHERE customerid = 'frank'
 PRINT '*** Customer deleted ***'
 END
GO--R: Salido en mensaje que ha hecho con exito como se elimino al principio sale error que ya no existe--*** Customer cannot be deleted ***
--Completion time: 2024-10-24T06:02:10.9642950-05:00DECLARE @n tinyint
SET @n = 5
IF (@n BETWEEN 4 and 6)
BEGIN
 WHILE (@n > 0)
 BEGIN
 SELECT @n AS 'Number'
 ,CASE
 WHEN (@n % 2) = 1	 THEN 'ODD' ELSE 'EVEN'
 END AS 'Type'
 SET @n = @n - 1
 END
END
ELSE
PRINT 'NO ANALYSIS'
GO/*R: RESULTADO ESPERADO TAL COMO SALE EN EL DOCUMENTO INTRODUCCION A TRANSACT-SQLNumber Type
5 ODD
(1 fila afectada)
Number Type
4 EVEN
(1 fila afectada)
Number Type
3 ODD
(1 fila afectada)
Number Type
2 EVEN
(1 fila afectada)
Number Type
1 ODD
(1 fila afectada) */