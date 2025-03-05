--(Modificación de datos) Jhostin Quispe 7365
--Ejemplo 1 
USE northwind 
INSERT customers 
(customerid, companyname, contactname, contacttitle ,address, city, region, 
postalcode, country, phone ,fax) 
VALUES ('PECOF', 'Pecos Coffee Company','Michael Dunn' ,'Owner', '1900 Oak Street', 
'Vancouver', 'BC' ,'V3F 2K1', 'Canada', '(604) 555-3392' ,'(604) 555-7293') 
GO 
--Para comprobar que se ha agregado ‘Pecos Coffee Company’ a la tabla customers, 
--puede ejecutar la instrucción siguiente: 

USE northwind 
SELECT  
companyname, contactname 
FROM  
customers 
WHERE  
customerid = 'PECOF' 
GO 
--Ejemplo 2 
USE northwind 
INSERT  customers 
SELECT  substring (firstname, 1, 3) + substring (lastname, 1, 2), lastname, firstname, title, address, city ,region, postalcode, country, homephone, NULL 
FROM  Employees
GO 

--Creación de una tabla mediante la instrucción SELECT INTO
--Ejemplo 3
USE northwind 
SELECT  productname AS products  ,unitprice AS price  ,(unitprice * 1.1) AS tax  
INTO #pricetable 
FROM products 
GO 
--Para ver el conjunto de resultados debe ejecutar la consulta siguiente.  
USE northwind  
SELECT *  
FROM  #pricetable
GO 
--Sale lo que indica el documento el resultado

--Ejemplo 4. Inserción de datos parciales 
USE northwind 
INSERT  shippers (companyname) 
VALUES  ('Fitch & Mather') 
GO 
--Comprobacion
USE northwind 
SELECT  * 
FROM shippers 
WHERE companyname = 'Fitch & Mather' 
GO 
--efectivamente sale el mismo resultado que el documento
--Ejemplo 5
USE northwind 
INSERT shippers (companyname, phone) 
VALUES  ('Fitch & Mather', DEFAULT) 
GO
--Ejemplo 6. Palabra clave DEFAULT
USE northwind 
INSERT shippers(companyname, phone) 
VALUES ('Kenya Coffee Co.', DEFAULT) 
GO
--Comprobacion 
USE northwind 
SELECT * 
FROM shippers 
WHERE companyname = 'Kenya Coffee Co.' 
GO 
--No sale como el documento aqui sale solo que ShipperID son 6 
--Ejemplo 7. Uso de la instrucción DELETE
USE northwind  
DELETE Orders 
WHERE DATEDIFF(MONTH, shippeddate, GETDATE()) >= 6 
GO 
--Ejemplo 8. Uso de la instrucción TRUNCATE TABLE (ERROR AL EJECUTAR)
USE northwind 
TRUNCATE TABLE orders 
GO 
--Ejemplo 9. Uso de una cláusula FROM adicional (ERROR POR FECHA)
USE northwind 
DELETE  
FROM [order details] 
FROM  orders AS o 
INNER JOIN  [order details] AS od ON  o.orderid = od.orderid 
WHERE  orderdate = '8/10/2024' 
GO 
--Ejemplo 10. Especificación de condiciones en la cláusula WHERE (ERROR POR LA FECHA)
USE northwind 
DELETE  
FROM  [order details] 
WHERE  orderid IN ( SELECT orderid 
					FROM orders 
					WHERE orderdate = '8/10/2024' 
					) 
GO
--Ejemplo 11. Actualización de datos 
USE northwind 
UPDATE products 
SET unitprice = (unitprice * 1.1) 
GO 
--Ejemplo 12. Uso de la instrucción UPDATE 
USE northwind 
UPDATE products 
SET unitprice = unitprice + 2 
FROM products 
INNER JOIN suppliers ON products.supplierid = suppliers.supplierid 
WHERE suppliers.country = 'USA' 
GO 
--Ejemplo 13. Especificación de filas para actualizar con subconsultas 
USE northwind 
UPDATE products 
SET unitprice = unitprice + 2 
WHERE  supplierid IN (SELECT supplierid 
						FROM suppliers 
						WHERE country = 'USA' 
						)
GO 
--Ejemplo 14 ERROR PEDIR UNA CONSULTA
USE northwind 
UPDATE  products 
SET todatesales = (SELECT SUM(quantity) 
					FROM [order details] AS od 
					WHERE products.productid = od.productid 
					) 
GO 

 
