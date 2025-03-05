--Jhostin Quispe
--7365
--Implementación de Desencadenadores, Sinónimos y Cursores

--Imposibilidad de incluir determinadas instrucciones
Use Northwind
GO
CREATE TRIGGER Empl_Delete ON Employees
FOR DELETE
AS
	IF (SELECT COUNT(*) FROM Deleted) > 1
BEGIN
	RAISERROR('You cannot delete more than one employee at a time.',16, 1)
	ROLLBACK TRANSACTION
END

--Cambios en la definición sin quitar el desencadenador
Use Northwind
GO
ALTER TRIGGER Empl_Delete ON Employees
FOR DELETE
AS
IF (SELECT COUNT(*) FROM Deleted) > 6
BEGIN
RAISERROR( 'You cannot delete more than six employees at a time.', 16, 1)
ROLLBACK TRANSACTION
END

--Funcionamiento de un desencadenador INSERT (Signo -)
USE Northwind
GO
CREATE TRIGGER OrdDet_Insert ON [Order Details]
FOR INSERT
AS
UPDATE P SET UnitsInStock = (UnitsInStock - I.Quantity)
FROM Products AS P INNER JOIN Inserted AS I ON P.ProductID = I.ProductID

--Funcionamiento de un desencadenador DELETE
USE Northwind
GO
CREATE TRIGGER Category_Delete ON Categories
FOR DELETE
AS
UPDATE P SET Discontinued = 1
FROM Products AS P INNER JOIN deleted AS d ON P.CategoryID = d.CategoryID

--Funcionamiento de un desencadenador UPDATE
USE Northwind
GO
CREATE TRIGGER Employee_Update ON Employees
FOR UPDATE
AS
IF UPDATE (EmployeeID)
BEGIN TRANSACTION
RAISERROR ('Transaction cannot be processed.\
***** Employee ID number cannot be modified.', 10, 1)
ROLLBACK TRANSACTION

--Funcionamiento de un desencadenador INSTEAD OF
--Cree dos tablas con datos de clientes
SELECT * INTO CustomersGer FROM Customers WHERE Customers.Country = 'Germany'
SELECT * INTO CustomersMex FROM Customers WHERE Customers.Country = 'Mexico'
GO
--Cree una vista en esos datos
CREATE VIEW CustomersView AS
SELECT * FROM CustomersGer
UNION
SELECT * FROM CustomersMex
GO
--Cree un desencadenador INSTEAD OF en la vista
CREATE TRIGGER Customers_Update2
ON CustomersView
INSTEAD OF UPDATE AS
DECLARE @Country nvarchar(15)
SET @Country = (SELECT Country FROM Inserted)
IF @Country = 'Germany'
BEGIN
UPDATE CustomersGer
SET CustomersGer.Phone = Inserted.Phone
FROM CustomersGer JOIN Inserted ON CustomersGer.CustomerID = Inserted.CustomerID
END
ELSE
IF @Country = 'Mexico'
BEGIN
UPDATE CustomersMex
SET CustomersMex.Phone = Inserted.Phone
FROM CustomersMex JOIN Inserted ON CustomersMex.CustomerID = Inserted.CustomerID
END

--Comprobación del nivel de anidamiento
USE Northwind
GO
CREATE TRIGGER Products_Update ON Products
FOR UPDATE
AS
IF UPDATE (UnitsInStock)
IF (Products.UnitsInStock + Products.UnitsOnOrder) < Products.ReorderLevel
BEGIN
--Enviar mensaje al departamento de compras
END
--Se modifco el codigo
USE Northwind
GO
CREATE TRIGGER Products_Update1 ON Products
FOR UPDATE
AS
BEGIN
    IF UPDATE(UnitsInStock)
    BEGIN
        IF EXISTS (
            SELECT 1
            FROM INSERTED i
            WHERE i.UnitsInStock < i.ReorderLevel
        )
        BEGIN
            IF EXISTS (
                SELECT 1
                FROM INSERTED i
                WHERE (i.UnitsInStock + i.UnitsOnOrder) < i.ReorderLevel
            )
            BEGIN
                IF (SELECT COUNT(*) FROM INSERTED) > 1
                BEGIN
                    PRINT 'Alerta: Más de un producto requiere reposición.'
                END
                ELSE
                BEGIN
                    PRINT 'Alerta: Un producto requiere reposición.'
                END
            END
        END
    END
END;
GO

--Conveniencia del uso de los desencadenadores recursivos
CREATE TRIGGER BackOrderList_Delete ON Products
FOR UPDATE AS
IF (SELECT BO.ProductID FROM BackOrders AS BO JOIN Inserted AS I ON BO.ProductID = I.Product_ID ) > 0
BEGIN
DELETE BO FROM BackOrders AS BO INNER JOIN Inserted AS I ON BO.ProductID = I.ProductID END

--Exigir reglas de empresa
Use Northwind
GO
CREATE TRIGGER Product_Delete ON Products FOR DELETE
AS
IF (Select Count (*) FROM [Order Details] 
INNER JOIN deleted ON [Order Details].ProductID = deleted.ProductID ) > 0
BEGIN
RAISERROR('Transaction cannot be processed. \
This product has order history.', 16, 1)
ROLLBACK TRANSACTION
END

--Implementación de Sinónimos
USE Northwind;
GO
CREATE SYNONYM dbo.Empleados -- Nombre del Sinónimo.
FOR Employees; -- Objeto Base al cual le aplicaremos el Sinónimo.
GO
--Pruebe el sinónimo
SELECT * FROM Empleados

--Implementación de Cursores
USE Northwind;
GO
-- Declaración del cursos
DECLARE Employee_Cursor CURSOR FOR
SELECT LastName, FirstName
FROM Northwind.dbo.Employees
WHERE LastName like 'B%'
-- Abrir o evaluar la consulta
OPEN Employee_Cursor
-- Recuperar las filas del cursor
FETCH NEXT FROM Employee_Cursor
WHILE @@FETCH_STATUS = 0
BEGIN
FETCH NEXT FROM Employee_Cursor
END
-- Cerrar el cursor y eliminarlo
CLOSE Employee_Cursor
DEALLOCATE Employee_Cursor
