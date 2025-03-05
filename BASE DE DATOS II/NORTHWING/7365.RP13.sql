--Jhostin Quispe 
--7365
--Implementación de Procedimientos Almacenados
--Uso de CREATE PROCEDURE
USE Northwind
GO
CREATE PROC dbo.OverdueOrders
AS
SELECT *
FROM dbo.Orders
WHERE RequiredDate < GETDATE() AND ShippedDate IS Null
GO

--Ejecución de un procedimiento almacenado por separado
EXEC OverdueOrders--Ejecucion de un procedimiento almacenado en una instrucción INSERTUSE Northwind
GO
CREATE PROC dbo.EmployeeCustomer
AS 
SELECT UPPER(SUBSTRING(LastName, 1, 4)+SUBSTRING(FirstName, 1,1)),'Northwind Traders', RTRIM(FirstName)+' '+LastName, 'Employee', Address, City, Region,PostalCode, Country, ('(206) 555-1234'+' x'+Extension), NULL 
FROM Employees
WHERE HireDate < GETDATE () GO

--Corregido
USE Northwind
GO
CREATE PROC dbo.EmployeeCustomer
AS
SELECT 
    UPPER(SUBSTRING(LastName, 1, 4) + SUBSTRING(FirstName, 1, 1)) AS CustomerID,
    'Northwind Traders' AS CompanyName,
    RTRIM(FirstName) + ' ' + LastName AS ContactName,
    'Employee' AS ContactTitle,
    Address,
    City,
    Region,
    PostalCode,
    Country,
    CAST('(206) 555-1234' + ' x' + Extension AS nvarchar(50)) AS Phone,
    NULL AS Fax
FROM Employees
WHERE HireDate < GETDATE()
GO
INSERT INTO Customers
EXEC EmployeeCustomer

--Modificacion de procedimientos almacenados
USE Northwind
GO
ALTER PROC dbo.OverdueOrders
AS
SELECT CONVERT(char(8), RequiredDate, 1) RequiredDate,
CONVERT(char(8), OrderDate, 1) OrderDate,
OrderID, CustomerID, EmployeeID
FROM Orders
WHERE RequiredDate < GETDATE() AND ShippedDate IS Null
ORDER BY RequiredDate
GO

EXEC OverdueOrders

--Eliminacion de procedimientos almacenadosUSE Northwind
GO
DROP PROC dbo.OverdueOrders
GO

--Utilizacion de parametros de entrada
CREATE PROCEDURE dbo.[Year to Year Sales] @BeginningDate 
DateTime, @EndingDate 
DateTime AS IF @BeginningDate IS NULL
OR @EndingDate IS NULL 
BEGIN RAISERROR('NULL values are not allowed', 14, 1)
RETURN 
END 
SELECT O.ShippedDate, O.OrderID, OS.Subtotal,
DATENAME(yy,ShippedDate) AS Year 
FROM ORDERS O INNER JOIN [Order Subtotals]
OS ON O.OrderID = OS.OrderID
WHERE O.ShippedDate BETWEEN @BeginningDate
AND @EndingDate
GO

--Paso de valores por el nombre del parametroUSE Northwind
GO
CREATE PROCEDURE dbo.AddCustomer
@CustomerID nchar (5),
@CompanyName nvarchar (40),
@ContactName nvarchar (30) = NULL,
@ContactTitle nvarchar (30) = NULL,
@Address nvarchar (60) = NULL,
@City nvarchar (15) = NULL,
@Region nvarchar (15) = NULL,
@PostalCode nvarchar (10) = NULL,
@Country nvarchar (15) = NULL,
@Phone nvarchar (24) = NULL,
@Fax nvarchar (24) = NULL
AS

EXEC AddCustomer
@CustomerID = 'ALFKI',
@ContactName = 'Maria Anders',
@CompanyName = 'Alfreds Futterkiste',
@ContactTitle = 'Sales Representative',
@Address = 'Obere Str. 57',
@City = 'Berlin',
@PostalCode = '12209',
@Country = 'Germany',
@Phone = '030-0074321'--Paso de valores por posicionEXEC AddCustomer 'ALFKI2', 'Alfreds Futterkiste', 'Maria Anders', 'Sales Representative',
'Obere Str. 57', 'Berlin', NULL, '12209', 'Germany', '030-0074321'--Devolucion de valores mediante parametros de salidaCREATE PROCEDURE dbo.MathTutor
@m1 smallint,
@m2 smallint,
@result smallint OUTPUT
AS
SET @result = @m1* @m2
GO

DECLARE @answer smallint
EXECUTE MathTutor 5,6, @answer OUTPUT
SELECT 'The result is: ', @answer

--CREATE PROCEDURE…[WITH RECOMPILE]
USE Northwind
GO
CREATE PROC dbo.OrderCount
@CustomerID nchar (10)
WITH RECOMPILE
AS
SELECT count(*) FROM [Orders Qry]
WHERE CustomerID = @CustomerID
GO

--EXECUTE…[WITH RECOMPILE]
EXEC sp_help WITH RECOMPILE--EjemploEXEC sp_recompile Customers--Ejecucipn de procedimientos almacenados extendidosEXEC master..xp_cmdshell 'dir c:\ '--Instruccion RETURNUSE Northwind
GO
CREATE PROCEDURE dbo.GetOrders
@CustomerID nchar (10)
AS
SELECT OrderID, CustomerID, EmployeeID
FROM [Orders Qry]WHERE CustomerID = @CustomerID
RETURN (@@ROWCOUNT)
GO--sp_addmessageEXEC sp_addmessage
@msgnum = 50010,
@severity = 10,
@lang= 'us_english',
@msgtext = 'Customer cannot be deleted.',
@with_log = 'true'--@@errorUSE Northwind
GO
CREATE PROCEDURE dbo.AddSupplierProduct
@CompanyName nvarchar (40) = NULL,
@ContactName nvarchar (40) = NULL,
@ContactTitle nvarchar (40)= NULL,
@Address nvarchar (60) = NULL,
@City nvarchar (15) = NULL,
@Region nvarchar (40) = NULL,
@PostalCode nvarchar (10) = NULL,
@Country nvarchar (15) = NULL,
@Phone nvarchar (24) = NULL,
@Fax nvarchar (24) = NULL,
@HomePage ntext = NULL,
@ProductName nvarchar (40) = NULL,
@CategoryID int = NULL,
@QuantityPerUnit nvarchar (20) = NULL,
@UnitPrice money = NULL,
@UnitsInStock smallint = NULL,
@UnitsOnOrder smallint = NULL,
@ReorderLevel smallint = NULL,
@Discontinued bit = NULL
AS
BEGIN TRANSACTION
INSERT Suppliers (
CompanyName,
ContactName,
Address,
City,
Region,
PostalCode,
Country,
Phone)
VALUES (
@CompanyName,
@ContactName,
@Address,
@City,
@Region,
@PostalCode,
@Country,
@Phone)
IF @@error <> 0
BEGIN
ROLLBACK TRAN
RETURN
END
DECLARE @InsertSupplierID int
SELECT @InsertSupplierID=@@identity
INSERT Products (
ProductName,
SupplierID,
CategoryID, QuantityPerUnit,
Discontinued)
VALUES (
@ProductName,
@InsertSupplierID,
@CategoryID,
@QuantityPerUnit,
@Discontinued)
IF @@error <> 0
BEGIN
ROLLBACK TRAN
RETURN
END
COMMIT TRANSACTION

--Instruccion RAISERROR
--RAISERROR(50010, 16, 1) WITH LOG
