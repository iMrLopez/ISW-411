CREATE TABLE [dbo].[Empleado]
(
	[IdEmpleado] INT NOT NULL PRIMARY KEY, 
    [NombreEmpleado] VARCHAR(50) NULL, 
    [ApellidosEmpleado] VARCHAR(50) NULL, 
    [TelefonoEmpleado] VARCHAR(50) NULL, 
    [CorreoEmpleado] VARCHAR(50) NULL, 
    [DireccionEmpleado] VARCHAR(50) NULL, 
    [FotografiaEmpleado] IMAGE NULL
)
