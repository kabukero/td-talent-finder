USE TalentFinder
GO

-- user: admintalentfinder
-- pass: #asdfdiploma#
-- sql server service NT Service\MSSQL$SQLEXPRESS2012

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
('Operador de Sistema',1),
('Gestión Empresa',1),('Leer Empresa',2),('Crear Empresa',2),('Editar Empresa',2),('Eliminar Empresa',2),
('Realizar Backup',2),('Realizar Restore',2),('Ver Bitácora',2),('Gestión Idiomas',2)
GO
SELECT * FROM Permiso
GO
DELETE FROM PermisoPermiso
GO
INSERT INTO PermisoPermiso (PermisoId,PermisoPadreId) VALUES
(2,1),(5,1),(8,1),
(3,2),(4,3),
(6,5),(7,6),
(9,8),(10,9),(12,10),(13,10),(14,10),(15,10),(26,10),(27,10),
(11,9),(16,11),(17,11),(18,11),(19,11),
(20,1),(26,9),(27,9),(28,9),(29,9)
GO
DELETE FROM UsuarioPermiso
GO
INSERT INTO UsuarioPermiso (UsuarioId,PermisoId) VALUES
(5,9),(5,10),(5,11),(5,12),(5,13),(5,14),(5,15),(5,16),(5,17),(5,18),(5,19),(5,21),
(5,22),(5,23),(5,24),(5,25),(5,26),(5,27),
(1,7),(3,7),(4,7),(2,4),(8,4)
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


DELETE FROM IdiomaFrase
DELETE FROM Frase
DELETE FROM Idioma
DBCC CHECKIDENT ('Idioma', RESEED, 0)
INSERT INTO Idioma (Nombre) VALUES ('Español'),('Inglés'),('Francés')
GO
INSERT INTO Frase (Tag) VALUES
('ingreso_sistema'),
('selecione_idioma'),
('ingresar'),
('salir'),
('ingrese_credenciales'),
('usuario'),
('clave')

GO
INSERT INTO IdiomaFrase (IdiomaId,Tag,Traduccion) VALUES
(1,'ingreso_sistema','Talent Finder - Ingreso al sistema'),
(2,'ingreso_sistema','Talent Finder - Login System'),
(3,'ingreso_sistema','Talent Finder - Login système'),
(1,'selecione_idioma','Seleccione Idioma'),
(2,'selecione_idioma','Choose Language'),
(3,'selecione_idioma','Choisir la langue'),
(1,'ingresar','Ingresar'),
(2,'ingresar','Login'),
(3,'ingresar','Login'),
(1,'salir','Salir'),
(2,'salir','Logout'),
(3,'salir','Quitter'),
(1,'ingrese_credenciales','Ingrese sus credenciales'),
(2,'ingrese_credenciales','Enter your credentials'),
(3,'ingrese_credenciales','Entrez vos identifiants'),
(1,'usuario','Usuario'),
(2,'usuario','User'),
(3,'usuario','Utilisateur'),
(1,'clave','Contraseña'),
(2,'clave','Password'),
(3,'clave','Mot de passe')
