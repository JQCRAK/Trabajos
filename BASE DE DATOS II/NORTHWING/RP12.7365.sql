--Jhostin Quispe
--7365
--Implementación de funciones

USE Northwind
GO
CREATE FUNCTION fn_NewRegion
(@myinput nvarchar(30))
RETURNS nvarchar(30)
BEGIN
IF @myinput IS NULL
SET @myinput = 'Not Applicable'
RETURN @myinput
END

SELECT LastName, City, dbo.fn_NewRegion(Region) AS Region, Country
FROM dbo.Employees

--Uso de una función escalar definida por el usuario
USE Northwind
GO
CREATE FUNCTION fn_DateFormat
(@indate datetime, @separator char(1))
RETURNS Nchar(20)
AS
BEGIN
RETURN
CONVERT(Nvarchar(20), datepart(mm,@indate))
+ @separator
+ CONVERT(Nvarchar(20), datepart(dd, @indate))
+ @separator
+ CONVERT(Nvarchar(20), datepart(yy, @indate))
ENDSELECT dbo.fn_DateFormat(GETDATE(), ':')--Uso de una funcion con valores de tabla de varias instruccionesUSE Northwind
GO
CREATE FUNCTION fn_Employees
(@length nvarchar(9))
RETURNS @fn_Employees TABLE
(EmployeeID int PRIMARY KEY NOT NULL,
[Employee Name] Nvarchar(61) NOT NULL)
AS
BEGIN
IF @length = 'ShortName'
INSERT @fn_Employees SELECT EmployeeID, LastName
FROM Employees
ELSE IF @length = 'LongName'
INSERT @fn_Employees SELECT EmployeeID,
(FirstName + ' ' + LastName) FROM Employees
RETURN
END--Opcion 1SELECT * FROM dbo.fn_Employees('LongName')--Opcion 2SELECT * FROM dbo.fn_Employees('ShortName')--Uso de una funcion con valores de tabla en lineaUSE Northwind
GO
CREATE FUNCTION fn_CustomerNamesInRegion
( @RegionParameter nvarchar(30) )
RETURNS table
AS
RETURN (
SELECT CustomerID, CompanyName
FROM Northwind.dbo.Customers
WHERE Region = @RegionParameter
)--Ver FuncionSELECT * FROM fn_CustomerNamesInRegion(N'WA')