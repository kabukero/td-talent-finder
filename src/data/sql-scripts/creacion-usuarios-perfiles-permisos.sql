USE TalentFinder
GO

INSERT INTO TipoPermiso (Nombre) VALUES ('Perfil'),('Permiso')
GO

INSERT INTO Permiso (Nombre,TipoPermisoId) VALUES
('Reclutador',1),('Postulante',1),
('Gestión Candidato',2),('Gestión Perfil Profesional',2)
('Publicar aviso laboral',3),('Postularse a aviso laboral',4)
GO

INSERT INTO PermisoPermiso (PermisoId,PermisoPadreId) VALUES
(1,NULL),(2,NULL),(3,1),(4,2)
GO

INSERT INTO UsuarioPermiso (UsuarioId,PermisoId) VALUES
(1,3),(2,3),(3,4),(4,4)
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
