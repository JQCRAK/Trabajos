--Trabajo con subconsultas
--Jhostin Quispe 7365

--Uso de una subconsulta como una tabla derivada
USE northwind
SELECT T.orderid, T.customerid
FROM ( SELECT orderid, customerid
FROM orders ) AS T
GO
--Ejemplo
USE Northwind
SELECT ProductName, UnitPrice, (SELECT AVG(UnitPrice) FROM Products) AS average, UnitPrice - (SELECT AVG(UnitPrice) FROM Products) AS difference
FROM Products
WHERE ProductID = 11
GO

--Uso de una subconsulta para correlacionar datos
USE northwind
SELECT orderid, customerid
FROM orders AS or1
WHERE 20 < (SELECT quantity FROM [order details] AS od
WHERE or1.orderid = od.orderid AND od.productid = 23)
GO

--Ejemplo
USE northwind
SELECT DISTINCT productid, quantity
FROM [order details] AS ord1
WHERE quantity = ( SELECT MAX(quantity)
FROM [order details] AS ord2
WHERE ord1.productid = ord2.productid)
GO

--Simulacion de una clausula JOIN
USE Northwind
SELECT DISTINCT p1.categoryid
FROM products AS p1
WHERE p1.categoryid IN ( SELECT p2.categoryid FROM products AS p2 
WHERE p2.supplierid <> p1.supplierid)
GO
--Ejemplo
USE northwind
SELECT DISTINCT p1.categoryid FROM products AS p1 
INNER JOIN products AS p2 ON p1.categoryid = p2.categoryid 
WHERE p1.supplierid <> p2.supplierid
GO

--Simulacion de una clausula HAVING
Use Northwind
SELECT p1.categoryid, p1.ProductName, p1.UnitPrice
FROM products AS p1
WHERE p1.UnitPrice > ( SELECT AVG(p2.UnitPrice)
FROM Products AS p2
WHERE p1.categoryid = p2.categoryid )
GO

--Ejemplo
USE Northwind
SELECT p1.CategoryID, p1.ProductName, p1.UnitPrice
FROM Products AS p1
INNER JOIN Products AS p2 ON p1.CategoryID = p2.CategoryID
GROUP BY p1.CategoryID, p1.ProductName, p1.UnitPrice
HAVING p1.UnitPrice > AVG(p2.UnitPrice)
GO

--Uso de las clausulas EXISTS y NOT EXISTS
USE Northwind
SELECT lastname, employeeid
FROM employees AS e
WHERE EXISTS ( SELECT * FROM orders AS o
WHERE e.employeeid = o.employeeid AND o.orderdate = '5/9/1997' )
GO

--Ejemplo
USE northwind
SELECT DISTINCT lastname, e.employeeid
FROM orders AS o
INNER JOIN employees AS e ON o.employeeid = e.employeeid
WHERE o.orderdate = '5/9/1997'
GO


