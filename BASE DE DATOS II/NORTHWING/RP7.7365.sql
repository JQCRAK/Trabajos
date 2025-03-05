--(Recuperación de datos) Jhostin Quispe 7365
--Ejemplo 1. Recuperación de datos mediante la instrucción SELECT 
USE northwind 
SELECT employeeid, lastname, firstname, title 
FROM employees 
GO 
--Salio tal como esta en el documento
--Ejemplo 2. Uso de la cláusula WHERE para especificar filas 
USE northwind 
SELECT employeeid, lastname, firstname, title 
FROM employees 
WHERE employeeid = 5 
GO 
--Salio como el documento la respuesta
--Ejempplo 3. Uso de los operadores de comparación
USE northwind 
SELECT lastname, city 
FROM employees 
WHERE country = 'USA' 
GO 
--Salio la respuesta como el documento
--Ejemplo 4  
USE northwind 
SELECT orderid, customerid 
FROM orders 
WHERE orderdate < '2/10/24' 
GO 
--depende de la fecha para que salga resultados
--Ejemplo 5. Uso de comparaciones de cadenas 
USE northwind 
SELECT companyname 
FROM customers 
WHERE companyname LIKE '%Restaurant%' 
GO 
--Ejemplo 6. Uso de operadores lógicos
USE northwind  
SELECT productid, productname, supplierid, unitprice FROM products WHERE (productname LIKE 'T%' OR productid = 46) AND (unitprice > 16.00)  
GO 
--Ejemplo 7. 
USE northwind 
SELECT productid, productname, supplierid, unitprice FROM products WHERE (productname LIKE 'T%') OR (productid = 46 AND unitprice > 16.00) 
GO 
--Ejemplo 8. Obtención de un intervalo de valores 
USE northwind 
SELECT productname, unitprice 
FROM products 
WHERE unitprice BETWEEN 10 AND 20 
GO 
--en la base de datos solo hay 25 y el documento indica 29 
--Ejemplo 9
USE northwind 
SELECT productname, unitprice 
FROM products 
WHERE (unitprice > 10) AND (unitprice < 20) 
GO 
--Ejemplo 10. Uso de una lista de valores como criterio de búsqueda
USE northwind 
SELECT companyname, country 
FROM suppliers 
WHERE country IN ('Japan', 'Italy') 
GO
--Ejemplo 11
USE northwind 
SELECT companyname, country 
FROM suppliers 
WHERE country = 'Japan' OR country = 'Italy' 
GO 
--Ejemplo 12. Obtención de valores desconocidos
USE northwind 
SELECT companyname, fax 
FROM suppliers 
WHERE fax IS NULL 
GO 
--Ejemplo 13. Ordenación de los datos 
USE northwind 
SELECT productid, productname, categoryid, unitprice 
FROM products 
ORDER BY categoryid, unitprice DESC 
GO
--Ejemplo 14
USE northwind 
SELECT productid, productname, categoryid, unitprice 
FROM products 
ORDER BY 3, 4 DESC 
GO
--Ejemplo 15. Eliminación de filas duplicadas
USE northwind 
SELECT DISTINCT country 
FROM suppliers 
ORDER BY country 
GO
--Ejemplo 16
USE northwind 
SELECT country 
FROM suppliers 
ORDER BY country 
GO 
--Ejemplo 17. Cambio del nombre de las columnas 
USE northwind 
SELECT firstname AS First, lastname AS Last, employeeid AS 'Employee ID:' 
FROM employees 
GO 
--Ejemplo 18. Uso de literales
USE northwind 
SELECT firstname, lastname,'Número de identificación:', employeeid 
FROM employees 
GO