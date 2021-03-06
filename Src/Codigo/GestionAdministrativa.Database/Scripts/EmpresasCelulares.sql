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
Insert into [dbo].[EmpresasCelulares] ([Id],[Descripcion]) 
select 1, N'Personal' WHERE NOT EXISTS (SELECT 1 FROM [DBO].EmpresasCelulares WHERE Id = 1)
Insert into [dbo].[EmpresasCelulares] ([Id],[Descripcion]) 
select 2, N'Claro' WHERE NOT EXISTS (SELECT 1 FROM [DBO].EmpresasCelulares WHERE Id = 2)
Insert into [dbo].[EmpresasCelulares] ([Id],[Descripcion]) 
select 3, N'Movistar' WHERE NOT EXISTS (SELECT 1 FROM [DBO].EmpresasCelulares WHERE Id = 3)
