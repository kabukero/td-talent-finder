USE TalentFinder
GO

DBCC CHECKIDENT ('TipoUsuario', RESEED, 0) -- reset identity
INSERT INTO TipoUsuario (Nombre) VALUES ('Administrador Sistema'),('Reclutador'),('Profesional')
INSERT INTO Usuario (UserName,UserPassword,TipoUsuarioId,Habilitado) VALUES ('operador','4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=',1,1)

INSERT INTO TipoPermiso (Nombre) VALUES ('Perfil'),('Permiso')
GO
DELETE FROM UsuarioPermiso
GO
DELETE FROM PermisoPermiso
GO
DELETE FROM Permiso
GO
DBCC CHECKIDENT ('Permiso', RESEED, 0) -- reset identity
GO
INSERT INTO Permiso (Nombre,TipoPermisoId) VALUES
('Root',1),
('Reclutador',1),
('Gestión Candidato',1),
('Publicar aviso laboral',2),
('Postulante',1),
('Gestión Perfil Profesional',1),
('Postularse a aviso laboral',2),
('Administrador de Sistema',1),('Gestion Sistema',1),('Gestion Usuarios',1),('Gestion Perfiles',1),
('Leer usuario',2),('Crear usuario',2),('Editar usuario',2),('Eliminar usuario',2),
('Leer perfil',2),('Crear perfil',2),('Editar perfil',2),('Eliminar perfil',2),
('Operador de Sistema',1),('Login Sistema',2),
('Gestión Empresa',1),('Leer Empresa',2),('Crear Empresa',2),('Editar Empresa',2),('Eliminar Empresa',2)
GO
SELECT * FROM Permiso
GO
INSERT INTO PermisoPermiso (PermisoId,PermisoPadreId) VALUES
(2,1),(5,1),(8,1),
(3,2),(4,3),
(6,5),(7,6),
(9,8),(10,9),(12,10),(13,10),(14,10),(15,10),(21,10),
(11,9),(16,11),(17,11),(18,11),(19,11),
(20,1),(10,20),(22,1),(23,22),(24,22),(25,22),(26,22)
GO
INSERT INTO UsuarioPermiso (UsuarioId,PermisoId) VALUES
(5,9),(5,10),(5,11),(5,12),(5,13),(5,14),(5,15),(5,16),(5,17),(5,18),(5,19),(5,21),
(5,22),(5,23),(5,24),(5,25),(5,26)
GO

CREATE PROCEDURE AgregarUsuarioPermiso(@UsuarioId AS INT,@PermisoId AS INT)
AS
BEGIN
	INSERT INTO UsuarioPermiso (UsuarioId,PermisoId) VALUES (@UsuarioId,@PermisoId)
END
GO

CREATE PROCEDURE EliminarUsuarioPermiso(@UsuarioId AS INT,@PermisoId AS INT)
AS
BEGIN
	DELETE FROM UsuarioPermiso WHERE UsuarioId=@UsuarioId AND PermisoId=@PermisoId
END
GO



/*
CREATE PROCEDURE AgregarPermiso(@Nombre AS VARCHAR(50),@TipoPermisoId AS INT)
AS
BEGIN
	INSERT INTO Permiso (Nombre,TipoPermisoId) VALUES (@Nombre,@TipoPermisoId)
END

CREATE PROCEDURE EditarPermiso(@Id AS INT,@Nombre AS VARCHAR(50))
AS
BEGIN
	UPDATE Permiso SET Nombre=@Nombre WHERE Id=@Id
END

CREATE PROCEDURE AgregarPermisoPermiso(@PermisoId AS INT,@PermisoPadreId AS INT)
AS
BEGIN
	INSERT INTO PermisoPermiso (PermisoId,PermisoPadreId) VALUES (@PermisoId,@PermisoPadreId)
END
*/


INSERT INTO Idioma (Nombre) VALUES ('Español'),('Inglés'),('Portugués')
INSERT INTO Frase (Tag) VALUES ('Español'),('Inglés'),('Portugués')
