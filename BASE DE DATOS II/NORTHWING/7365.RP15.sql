--Análisis, Diseño y Creación de índices
--Jhostin Quispe 7365

CREATE CLUSTERED INDEX CL_lastname ON employees(lastname)
GO

USE Northwind
DROP INDEX employees.CL_lastname
GO

USE Northwind
CREATE UNIQUE NONCLUSTERED INDEX U_CustID
ON customers(CustomerID)


SELECT CustomerID, COUNT(CustomerID) AS '# of Duplicates'
FROM Northwind.dbo.Customers
GROUP BY CustomerID
HAVING COUNT(CustomerID)>1
ORDER BY CustomerID


USE Northwind
CREATE UNIQUE NONCLUSTERED INDEX U_OrdID_ProdID
ON [Order Details] (OrderID, ProductID)


USE Northwind
EXEC sp_helpindex Customers

USE Northwind
CREATE INDEX OrderID_ind
ON Orders(OrderID)
WITH PAD_INDEX, FILLFACTOR=70


USE Northwind
DBCC SHOWCONTIG (Customers, PK_Customers)
GO

DBCC INDEXDEFRAG(credit, member, mem_no_CL)
GO


CREATE UNIQUE NONCLUSTERED INDEX U_OrdID_ProdID
ON [Order Details] (OrderID, ProductID)
WITH DROP_EXISTING, FILLFACTOR=65


SELECT id, indid, reserved, used, origfillfactor, name
FROM Northwind.dbo.sysindexes
WHERE name = 'PK_customers'



