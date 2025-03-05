--Jhostin Quispe 
--7365

--Copia de seguridad de Bases de Datos


--Impedir la pérdida de los datos
ALTER DATABASE Northwind SET RECOVERY BULK_LOGGED


--Creación de dispositivos de copia de seguridad
USE master
EXEC sp_addumpdevice 'disk', 'mybackupfile', 'C:\Backup\MyBackupFile.bak'

USE master
EXEC sp_addumpdevice 'tape', 'mytape1', '\\.\tape0'

--Creación de archivos de copia de seguridad sin dispositivos permanentes
USE master
BACKUP DATABASE Northwind TO DISK = 'C:\Backups\MyCustomers.bak'


--Copia de seguridad completa de la base de datos
USE master
EXEC sp_addumpdevice 'disk', 'NwindBac', 'C:\Backups\NwindBac.bak'
BACKUP DATABASE Northwind TO NwindBac
EXEC sp_dropdevice 'NwindBac', 'delfile'
EXEC sp_addumpdevice 'disk', 'NwindBac', 'C:\Backups\NwindBac.bak'
BACKUP DATABASE Northwind TO NwindBac


BACKUP DATABASE Northwind TO DISK = 'C:\Backups\NwindBac.bak'


BACKUP DATABASE Northwind TO NwindBac WITH INIT

BACKUP DATABASE Northwind TO NwindBac WITH NOINIT


BACKUP DATABASE Northwind TO DISK = 'C:\Temp\MyTempBackup.bak'

BACKUP DATABASE Northwind TO
DISK = 'C:\MyData\MyDiffBackup.bak'
WITH DIFFERENTIAL
--Copia de seguridad del registro de transacciones

USE master
EXEC sp_addumpdevice 'disk', 'NwindBacLog', 'C:\Backups\NwindBacLog.bak'
BACKUP LOG Northwind TO NwindBacLog


BACKUP LOG Northwind WITH TRUNCATE_ONLYBACKUP LOG Northwind WITH NO_LOG--Copia de seguridad de un archivo o grupo de archivos de una base de datosBACKUP DATABASE PhoneOrders
FILE = 'Orders2'
TO DISK = 'C:\Backups\OrderBackup2.bak'
BACKUP LOG PhoneOrders TO DISK = 'C:\Backups\OrderBackupLog.bak'
BACKUP DATABASE PhoneOrders
FILE = 'Orders2'
TO DISK = 'C:\Backups\OrderBackup2.bak'

BACKUP LOG PhoneOrders TO DISK = 'C:\Backups\OrderBackupLog.bak'








