--Jhostin Quispe
--7365 

--Introducción a las vistas 
USE Northwind 
GO 
CREATE VIEW dbo.EmployeeView 
AS 
SELECT LastName, Firstname 
FROM employees 
GO 
--Consulta 
SELECT * from EmployeeView

--Restricciones en las definiciones de vistas 
CREATE VIEW dbo.OrderSubtotalsView (OrderID, Subtotal) 
AS 
SELECT OD.OrderID, SUM(CONVERT (money,(OD.UnitPrice*Quantity*(1-Discount)/100))*100) 
FROM [Order Details] OD 
GROUP BY OD.OrderID 
GO
--Consulta 
SELECT * FROM OrderSubtotalsView 

--Vista de tablas combinadas
USE Northwind 
GO 
CREATE VIEW dbo.ShipStatusView 
AS 
SELECT OrderID, ShippedDate, ContactName 
FROM Customers c 
INNER JOIN Orders o ON c.CustomerID = O.CustomerID 
WHERE RequiredDate < ShippedDate 
GO
--Consulta
SELECT * FROM ShipStatusView 

--Alteración de vistas 
USE Northwind 
GO 
ALTER VIEW dbo.EmployeeView 
AS 
SELECT LastName, FirstName, Extension 
FROM employees 
GO
--Consulta
SELECT * from dbo.EmployeeView 
--Encriptar las vistas para mayor seguridad
--Uso de la opción WITH ENCRYPTION (Modifique el nombre de la vista al crear salia error)
USE Northwind 
GO 
CREATE VIEW dbo.[Order Subtotals1] 
WITH ENCRYPTION 
AS 
SELECT OrderID, Sum(CONVERT(money,(UnitPrice*Quantity*(1-Discount)/100))*100) 
AS Subtotal 
FROM [Order Details] 
GROUP BY OrderID 
GO
--Consulta 
Select * From [Order Subtotals1]

--Consideraciones acerca del rendimiento
USE Northwind 
GO 
CREATE VIEW dbo.TopSalesView 
AS 
SELECT * 
FROM dbo.TotalPurchaseView 
WHERE Subtotal > 50000 
GO 
--Consulta
Select * from TopSalesView
--Crear otra tabla para solucionar el anterior
USE Northwind 
GO 
CREATE VIEW dbo.TotalPurchaseView 
AS 
SELECT CompanyName, Sum(CONVERT(money, 
(UnitPrice*Quantity*(1-Discount)/100))*100) AS Subtotal 
FROM Customers c INNER JOIN Orders o 
ON c.CustomerID=o.CustomerID 
INNER JOIN [Order Details] od 
ON o.OrderID = od.OrderID 
GROUP BY CompanyName 
GO 

--Consulta
Select * From TotalPurchaseView

--Consulta 
SELECT * 
FROM dbo.TopSalesView 
WHERE CompanyName = 'Ernst Handel' 
