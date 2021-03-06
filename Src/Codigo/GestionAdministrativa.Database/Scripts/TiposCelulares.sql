﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
Insert into [dbo].TiposCelulares ([Tipo],[Monto],[MontoInicial],FechaAlta,OperadorAltaId,SucursalAltaId) 
select  N'Propio',25,20,N'1900-01-01 01:00:00.923',N'b43f3432-08d2-409e-9b82-aa400142bbe6',1 
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposCelulares WHERE Tipo = 'Propio')

Insert into [dbo].TiposCelulares ([Tipo],[Monto],[MontoInicial],FechaAlta,OperadorAltaId,SucursalAltaId) 
select N'Apipe',31,20,N'1900-01-01 01:00:00.923',N'b43f3432-08d2-409e-9b82-aa400142bbe6',1 
WHERE NOT EXISTS (SELECT 1 FROM [DBO].TiposCelulares WHERE Tipo = 'Apipe')

