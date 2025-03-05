--Combinacion de varias tablas
--Jhostin Quispe 7365

--Uso de combinaciones internas
USE northwind
SELECT productname, companyname
FROM products
INNER JOIN suppliers
ON products.supplierid = suppliers.supplierid
GO

--Ejemplo
USE northwind
SELECT DISTINCT companyname, orderdate
FROM orders INNER JOIN customers
ON orders.customerid = customers.customerid
WHERE orderdate > '1/1/98'
GO

--Uso de las combinaciones externas
USE northwind
SELECT companyname, customers.customerid, orderdate
FROM customers LEFT OUTER JOIN orders ON customers.customerid = orders.customerid
GO

--Uso de las combinaciones cruzadas
USE northwind
SELECT suppliers.companyname, shippers.companyname 
FROM suppliers CROSS JOIN shippers
GO

--Combinacion de mas de dos tablas
USE northwind
SELECT orderdate, productname
FROM orders AS O 
INNER JOIN [order details] AS OD ON O.orderid = OD.orderid
INNER JOIN products AS P ON OD.productid = P.productid
WHERE orderdate = '7/8/96'

--Combinacion de una tabla consigo misma
USE northwind
SELECT a.employeeid, LEFT(a.lastname,10) AS Name, LEFT(a.title,10) AS Title, b.employeeid, LEFT(b.lastname,10) AS Name, LEFT(b.title,10) AS Title
FROM employees AS a INNER JOIN employees AS b ON a.title = b.title
WHERE a.employeeid < b.employeeid
GO

--Combinacion de varios conjuntos de resultados
USE northwind
SELECT (firstname + ' ' + lastname) AS name, city, postalcode
FROM employees
UNION
SELECT companyname, city, postalcode
FROM customers
GO


