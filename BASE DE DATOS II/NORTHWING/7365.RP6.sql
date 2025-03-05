--Agrupar y resumir datos
--Jhostin Quispe 7365

--Presentacion de los primeros n valores
USE northwind
SELECT TOP 5 orderid, productid, quantity
FROM [order details]
ORDER BY quantity DESC
GO

--Ejemplo
USE northwind
SELECT TOP 5 WITH TIES orderid, productid, quantity
FROM [order details]
ORDER BY quantity DESC
GO 

--Uso de funciones de agregadoUSE northwind
SELECT AVG(unitprice)
FROM products
GO--EjemploUSE northwind
SELECT SUM(quantity)
FROM [order details]
GO--Uso de funciones de agregado con valores nulosUSE northwind
SELECT COUNT(*)
FROM employees
GO--EjemploUSE northwind
SELECT COUNT(reportsto)
FROM employees
GO--Uso de la clausula GROUP BY (NO hay tabla orderhist pero con lo que esta en el aula se soluciona el problema)USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM orderhist
GROUP BY productid
GO--Ejemplo (No hay tabla para ejecutar la consulta)USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM orderhist
WHERE productid = 2
GROUP BY productid
GO--Solucion de ambos es agregar la tabla orderhist--EjemploUSE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM [order details]
GROUP BY productid
GO--Uso de la clausula GROUP BY con la clausula HAVING USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM orderhist
GROUP BY productid
HAVING SUM(quantity) >=30
GO--Ejemplo USE northwind
SELECT productid, SUM(quantity) AS total_quantity
FROM [order details]
GROUP BY productid
HAVING SUM(quantity) > 1200
GO--Uso de la clausula GROUP BY con el operador ROLLUPUSE northwind
SELECT productid, orderid, SUM(quantity) AS total_quantity
FROM orderhist
GROUP BY productid, orderid
WITH ROLLUP
ORDER BY productid, orderid
GO--EjemploUSE northwind
SELECT orderid, productid, SUM(quantity) AS total_quantity
FROM [order details]
WHERE orderid < 10250
GROUP BY orderid, productid
ORDER BY orderid, productid
GO--EjemploUSE northwind
SELECT orderid, productid, SUM(quantity) AS total_quantity
FROM [order details]
WHERE orderid < 10250
GROUP BY orderid, productid
WITH ROLLUP
ORDER BY orderid, productid
GO--Uso de la clausula GROUP BY con el operador CUBEUSE northwind
SELECT productid, orderid, SUM(quantity) AS total_quantity
FROM orderhist
GROUP BY productid, orderid
WITH CUBE
ORDER BY productid, orderid
GO--Uso de la funcion GROUPINGUSE northwind
SELECT productid, GROUPING (productid),orderid, GROUPING (orderid),SUM(quantity) AS total_quantity
FROM orderhist
GROUP BY productid, orderid
WITH CUBE
ORDER BY productid, orderid
GO--Ejemplo USE northwind
SELECT orderid, GROUPING(orderid), productid,GROUPING(productid), SUM(quantity) AS total_quantity
FROM [order details]
WHERE orderid < 10250
GROUP BY orderid, productid
WITH CUBE
ORDER BY orderid, productid
GO