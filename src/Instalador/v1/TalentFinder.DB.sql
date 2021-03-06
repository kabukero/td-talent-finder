USE [master]
GO
/****** Object:  Database [TalentFinder]    Script Date: 11/19/2019 8:09:14 PM ******/
CREATE DATABASE [TalentFinder]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TalentFinder', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA\TalentFinder.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TalentFinder_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\DATA\TalentFinder_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TalentFinder] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TalentFinder].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TalentFinder] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TalentFinder] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TalentFinder] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TalentFinder] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TalentFinder] SET ARITHABORT OFF 
GO
ALTER DATABASE [TalentFinder] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TalentFinder] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TalentFinder] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TalentFinder] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TalentFinder] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TalentFinder] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TalentFinder] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TalentFinder] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TalentFinder] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TalentFinder] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TalentFinder] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TalentFinder] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TalentFinder] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TalentFinder] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TalentFinder] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TalentFinder] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TalentFinder] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TalentFinder] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TalentFinder] SET  MULTI_USER 
GO
ALTER DATABASE [TalentFinder] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TalentFinder] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TalentFinder] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TalentFinder] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TalentFinder]
GO
/****** Object:  Table [dbo].[AvisoLaboral]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AvisoLaboral](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[FechaVigencia] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[LugarTrabajo] [varchar](500) NOT NULL,
	[ReclutadorId] [int] NOT NULL,
 CONSTRAINT [PK_AvisoLaboral] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AvisoLaboralTecnologia]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AvisoLaboralTecnologia](
	[AvisoLaboralId] [int] NOT NULL,
	[TecnologiaId] [int] NOT NULL,
 CONSTRAINT [PK_AvisoLaboralTecnologia] PRIMARY KEY CLUSTERED 
(
	[AvisoLaboralId] ASC,
	[TecnologiaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[TipoEventoId] [int] NOT NULL,
	[Descripcion] [varchar](500) NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurriculumVitae]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumVitae](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[ProfesionalId] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumVitae] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CurriculumVitaeConocimiento]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CurriculumVitaeConocimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[CurriculumVitaeId] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumVitaeConocimiento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurriculumVitaeEstudio]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CurriculumVitaeEstudio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[FechaFin] [date] NOT NULL,
	[NivelEstudioId] [int] NOT NULL,
	[CurriculumVitaeId] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumVitaeEstudio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurriculumVitaeExperiencia]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CurriculumVitaeExperiencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[AniosExperiencia] [int] NOT NULL,
	[Empresa] [varchar](100) NOT NULL,
	[CurriculumVitaeId] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumVitaeExperiencia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurriculumVitaeIdioma]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CurriculumVitaeIdioma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Idioma] [varchar](50) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[CurriculumVitaeId] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumVitaeIdioma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CurriculumVitaeTecnologia]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurriculumVitaeTecnologia](
	[CurriculumVitaeId] [int] NOT NULL,
	[TecnologiaId] [int] NOT NULL,
 CONSTRAINT [PK_CurriculumVitaeTecnologia] PRIMARY KEY CLUSTERED 
(
	[CurriculumVitaeId] ASC,
	[TecnologiaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DigitoVerificador]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DigitoVerificador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TablaSistemaId] [int] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NULL,
	[DVV] [bigint] NOT NULL,
 CONSTRAINT [PK_DigitoVerificador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CUIT] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
	[DVH] [bigint] NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpresaHistorico]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpresaHistorico](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpresaId] [int] NOT NULL,
	[RazonSocial] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[CUIT] [varchar](50) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaActualizacion] [datetime] NOT NULL,
	[FechaCreacionHistorico] [datetime] NOT NULL,
	[DVH] [bigint] NOT NULL,
 CONSTRAINT [PK_EmpresaHistorico] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](500) NOT NULL,
	[CodigoFuenteTest] [varchar](max) NULL,
	[Ejercicio] [varchar](50) NOT NULL,
	[EvaluacionTipoId] [int] NOT NULL,
	[Tiempo] [varchar](50) NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EvaluacionTipo]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EvaluacionTipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
 CONSTRAINT [PK_EvaluacionTipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Frase]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Frase](
	[Tag] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Frase_1] PRIMARY KEY CLUSTERED 
(
	[Tag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Idioma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IdiomaFrase]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[IdiomaFrase](
	[IdiomaId] [int] NOT NULL,
	[Tag] [varchar](500) NOT NULL,
	[Traduccion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_IdiomaFrase] PRIMARY KEY CLUSTERED 
(
	[IdiomaId] ASC,
	[Tag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NivelEstudio]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NivelEstudio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_NivelEstudio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[TipoPermisoId] [int] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PermisoPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisoPermiso](
	[PermisoId] [int] NOT NULL,
	[PermisoPadreId] [int] NOT NULL,
 CONSTRAINT [PK_PermisoPermiso_1] PRIMARY KEY CLUSTERED 
(
	[PermisoId] ASC,
	[PermisoPadreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Postulacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postulacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[ProfesionalId] [int] NOT NULL,
	[AvisoLaboralId] [int] NOT NULL,
	[PostulacionEstadoId] [int] NOT NULL,
 CONSTRAINT [PK_Postulacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostulacionEstado]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PostulacionEstado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PostulacionEstado] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PostulacionEvaluacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PostulacionEvaluacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[PostulacionId] [int] NOT NULL,
	[EvaluacionId] [int] NOT NULL,
	[Respuesta] [varchar](max) NULL,
	[TiempoResolucionEvaluacion] [varchar](50) NULL,
	[Aprobo] [bit] NOT NULL,
 CONSTRAINT [PK_PostulacionPrueba] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesional]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesional](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](500) NULL,
	[UsuarioId] [int] NOT NULL,
	[EmpresaId] [int] NOT NULL,
 CONSTRAINT [PK_Profesional] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reclutador]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reclutador](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](500) NULL,
	[UsuarioId] [int] NOT NULL,
	[EmpresaId] [int] NOT NULL,
 CONSTRAINT [PK_Reclutador] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TablaSistema]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TablaSistema](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TablaSistema] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tecnologia]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tecnologia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Tecnologia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoEvento]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoEvento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEvento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoPermiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoPermiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserPassword] [varchar](600) NOT NULL,
	[Habilitado] [bit] NOT NULL CONSTRAINT [DF_Usuario_Habilitado]  DEFAULT ((1)),
	[DVH] [bigint] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPermiso](
	[UsuarioId] [int] NOT NULL,
	[PermisoId] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPermiso] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC,
	[PermisoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[AvisoLaboral] ON 

INSERT [dbo].[AvisoLaboral] ([Id], [Descripcion], [FechaVigencia], [FechaVencimiento], [FechaCreacion], [LugarTrabajo], [ReclutadorId]) VALUES (2, N'Se busca programador C# con experiencia en sql y base de datos', CAST(N'2019-10-01 00:00:00.000' AS DateTime), CAST(N'2019-12-31 00:00:00.000' AS DateTime), CAST(N'2019-09-01 00:00:00.000' AS DateTime), N'Capital Federal', 1)
INSERT [dbo].[AvisoLaboral] ([Id], [Descripcion], [FechaVigencia], [FechaVencimiento], [FechaCreacion], [LugarTrabajo], [ReclutadorId]) VALUES (3, N'Se busca desarrollador C# con experiencia en cloud computing con azure', CAST(N'2019-10-15 00:00:00.000' AS DateTime), CAST(N'2019-12-31 00:00:00.000' AS DateTime), CAST(N'2019-09-15 00:00:00.000' AS DateTime), N'Remoto', 1)
INSERT [dbo].[AvisoLaboral] ([Id], [Descripcion], [FechaVigencia], [FechaVencimiento], [FechaCreacion], [LugarTrabajo], [ReclutadorId]) VALUES (4, N'Se busca programador senior en java con experiencia en cloud computing con AWS', CAST(N'2019-10-15 00:00:00.000' AS DateTime), CAST(N'2019-12-31 00:00:00.000' AS DateTime), CAST(N'2019-09-15 00:00:00.000' AS DateTime), N'Buenos Aires', 1)
INSERT [dbo].[AvisoLaboral] ([Id], [Descripcion], [FechaVigencia], [FechaVencimiento], [FechaCreacion], [LugarTrabajo], [ReclutadorId]) VALUES (5, N'Se busca programador senior en java con experiencia en base de datos sql server', CAST(N'2019-10-15 00:00:00.000' AS DateTime), CAST(N'2019-12-31 00:00:00.000' AS DateTime), CAST(N'2019-09-15 00:00:00.000' AS DateTime), N'Cordoba', 2)
INSERT [dbo].[AvisoLaboral] ([Id], [Descripcion], [FechaVigencia], [FechaVencimiento], [FechaCreacion], [LugarTrabajo], [ReclutadorId]) VALUES (6, N'Se busca programador C# con experiencia en base de datos sql server', CAST(N'2019-10-15 00:00:00.000' AS DateTime), CAST(N'2019-12-31 00:00:00.000' AS DateTime), CAST(N'2019-09-15 00:00:00.000' AS DateTime), N'Buenos Aires', 2)
SET IDENTITY_INSERT [dbo].[AvisoLaboral] OFF
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (2, 1)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (2, 7)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (3, 1)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (3, 8)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (4, 2)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (4, 9)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (5, 2)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (5, 7)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (6, 1)
INSERT [dbo].[AvisoLaboralTecnologia] ([AvisoLaboralId], [TecnologiaId]) VALUES (6, 7)
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1147, CAST(N'2019-09-26 23:40:06.677' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1148, CAST(N'2019-09-26 23:40:50.997' AS DateTime), 5, 2, N'Se creo la empresa google ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1149, CAST(N'2019-09-26 23:41:32.933' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1150, CAST(N'2019-09-26 23:41:56.303' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1151, CAST(N'2019-09-26 23:42:19.413' AS DateTime), 5, 2, N'Se creo la empresa ebay ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1152, CAST(N'2019-09-26 23:42:31.317' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1153, CAST(N'2019-09-26 23:43:03.343' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1154, CAST(N'2019-09-26 23:43:17.670' AS DateTime), 5, 2, N'Se editó la empresa ebay ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1155, CAST(N'2019-09-26 23:43:39.723' AS DateTime), 5, 2, N'Se editó la empresa google ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1156, CAST(N'2019-09-26 23:43:53.523' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1157, CAST(N'2019-09-30 20:43:11.930' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1158, CAST(N'2019-09-30 20:43:29.807' AS DateTime), 5, 2, N'Se editó la empresa amazon ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1159, CAST(N'2019-09-30 20:43:52.250' AS DateTime), 5, 2, N'Se editó la empresa ebay ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1160, CAST(N'2019-09-30 20:44:23.350' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1161, CAST(N'2019-09-30 20:44:46.870' AS DateTime), 5, 2, N'Se creo la empresa Google ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1162, CAST(N'2019-09-30 20:45:21.597' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1163, CAST(N'2019-09-30 20:45:51.080' AS DateTime), 5, 2, N'Se editó la empresa Google Inc. ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1164, CAST(N'2019-09-30 20:46:06.520' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1165, CAST(N'2019-09-30 20:46:26.023' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1166, CAST(N'2019-09-30 20:46:32.460' AS DateTime), 5, 2, N'Se realizó un backup en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-09-30-20-46-32.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1167, CAST(N'2019-09-30 20:47:07.633' AS DateTime), 5, 2, N'Se realizó un backup en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-09-30-20-47-07.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1168, CAST(N'2019-09-30 21:41:47.370' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1169, CAST(N'2019-09-30 21:42:02.873' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-09-30-21-42-02.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1170, CAST(N'2019-09-30 21:44:10.587' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1171, CAST(N'2019-09-30 21:44:13.953' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-09-30-21-44-13.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1172, CAST(N'2019-09-30 21:50:18.523' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1173, CAST(N'2019-09-30 21:50:59.183' AS DateTime), 5, 2, N'Se editó la empresa e-bay inc ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1174, CAST(N'2019-09-30 21:51:38.597' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-09-30-21-51-38.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1175, CAST(N'2019-09-30 21:54:18.687' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1176, CAST(N'2019-09-30 21:54:27.607' AS DateTime), 5, 1, N'Ocurrió un error al intentar realizar un restore de la DB en el siguiente directorio: C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\TalentFinder-2019-09-30-21-51-38.bak/TalentFinder-2019-09-30-21-54-27.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1177, CAST(N'2019-09-30 21:55:15.100' AS DateTime), 5, 1, N'Ocurrió un error al intentar realizar un restore de la DB en el siguiente directorio: C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\TalentFinder-2019-09-30-21-51-38.bak/TalentFinder-2019-09-30-21-55-15.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1178, CAST(N'2019-09-30 21:55:35.370' AS DateTime), 5, 1, N'Ocurrió un error al intentar realizar un restore de la DB en el siguiente directorio: C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\TalentFinder-2019-09-30-21-51-38.bak/TalentFinder-2019-09-30-21-55-35.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1179, CAST(N'2019-09-30 21:56:40.153' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1180, CAST(N'2019-09-30 21:57:43.890' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1181, CAST(N'2019-09-30 21:58:32.023' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1182, CAST(N'2019-09-30 22:02:52.093' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1183, CAST(N'2019-09-30 22:03:03.743' AS DateTime), 5, 2, N'Se realizó un restore de la DB en el siguiente directorio: C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\TalentFinder-2019-09-30-21-51-38.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1184, CAST(N'2019-10-01 16:43:39.300' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1185, CAST(N'2019-10-01 16:43:46.350' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-10-01-16-43-45.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1186, CAST(N'2019-10-01 16:57:24.063' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1187, CAST(N'2019-10-01 16:58:06.300' AS DateTime), 5, 1, N'Ocurrió un error al intentar realizar un backup de la DB en el siguiente directorio: C:\Users\mbz\Downloads/TalentFinder-2019-10-01-16-58-06.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1188, CAST(N'2019-10-01 16:58:55.393' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS2012\MSSQL\Backup\/TalentFinder-2019-10-01-16-58-55.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (1189, CAST(N'2019-10-01 17:03:05.363' AS DateTime), 5, 1, N'Ocurrió un error al intentar realizar un backup de la DB en el siguiente directorio: C:\Users\mbz\Documents/TalentFinder-2019-10-01-16-59-04.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2188, CAST(N'2019-10-01 17:05:00.693' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: C:\Users\mbz\Downloads/TalentFinder-2019-10-01-17-05-00.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2189, CAST(N'2019-10-01 17:13:28.490' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2190, CAST(N'2019-10-01 17:34:43.417' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2191, CAST(N'2019-10-01 17:48:47.353' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2192, CAST(N'2019-10-01 17:48:52.207' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2193, CAST(N'2019-10-01 17:48:59.253' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2194, CAST(N'2019-10-01 18:15:16.540' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2195, CAST(N'2019-10-01 18:17:05.240' AS DateTime), 5, 2, N'Se realizó un restore de la DB en el siguiente directorio: C:\Users\mbz\Documents\uai\diploma\TalentFinder.BAK ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2196, CAST(N'2019-10-01 18:17:29.133' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2197, CAST(N'2019-10-01 18:17:35.700' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2198, CAST(N'2019-10-01 18:37:33.813' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2199, CAST(N'2019-10-01 18:44:27.593' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2200, CAST(N'2019-10-01 18:45:18.647' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2201, CAST(N'2019-10-01 18:48:31.350' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2202, CAST(N'2019-10-01 18:48:36.790' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2203, CAST(N'2019-10-01 18:48:43.867' AS DateTime), 1, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2204, CAST(N'2019-10-01 18:48:50.163' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2205, CAST(N'2019-10-01 18:49:28.313' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2206, CAST(N'2019-10-01 18:52:20.710' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2207, CAST(N'2019-10-01 18:53:38.153' AS DateTime), 5, 2, N'Se realizó un backup de la DB en el siguiente directorio: C:\Users\mbz\Documents/TalentFinder-2019-10-01-18-53-37.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2208, CAST(N'2019-10-01 18:56:32.550' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2211, CAST(N'2019-10-01 18:57:23.007' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2212, CAST(N'2019-10-01 18:58:23.820' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2213, CAST(N'2019-10-01 18:59:23.347' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2214, CAST(N'2019-10-01 19:00:27.913' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2221, CAST(N'2019-10-01 19:04:15.640' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2222, CAST(N'2019-10-01 19:07:06.270' AS DateTime), 5, 2, N'Se realizó un restore de la DB en el siguiente directorio: C:\Users\mbz\Documents\TalentFinder-2019-10-01-19-04-31.bak ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2223, CAST(N'2019-10-01 19:07:34.553' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2224, CAST(N'2019-10-01 19:07:59.323' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2225, CAST(N'2019-10-01 19:13:14.810' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2226, CAST(N'2019-10-01 19:15:06.090' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2227, CAST(N'2019-10-01 19:15:37.023' AS DateTime), 5, 2, N'Se creo la empresa Google ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2228, CAST(N'2019-10-01 19:16:53.717' AS DateTime), 5, 2, N'Se creo la empresa amazon ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2229, CAST(N'2019-10-01 19:17:15.143' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2230, CAST(N'2019-10-14 15:36:32.500' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2231, CAST(N'2019-10-14 15:39:45.340' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2232, CAST(N'2019-10-14 15:42:30.717' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2233, CAST(N'2019-10-14 15:44:11.950' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2234, CAST(N'2019-10-14 15:46:15.640' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2235, CAST(N'2019-10-14 16:05:15.447' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2236, CAST(N'2019-10-14 16:06:31.030' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2237, CAST(N'2019-10-14 16:16:23.590' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2238, CAST(N'2019-10-14 16:44:54.410' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2239, CAST(N'2019-10-14 16:53:17.333' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2240, CAST(N'2019-10-15 15:34:34.047' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2241, CAST(N'2019-10-17 09:09:38.773' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2242, CAST(N'2019-10-17 09:11:27.563' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2243, CAST(N'2019-10-17 09:12:58.600' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2244, CAST(N'2019-10-17 09:13:46.787' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2245, CAST(N'2019-10-17 09:20:31.453' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2246, CAST(N'2019-10-17 09:24:05.077' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2247, CAST(N'2019-10-17 09:25:17.563' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2248, CAST(N'2019-10-17 09:28:12.347' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2249, CAST(N'2019-10-17 11:19:24.830' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2250, CAST(N'2019-10-17 11:39:49.100' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2251, CAST(N'2019-10-19 22:25:13.160' AS DateTime), 5, 2, N'Ingresó al sistema')
GO
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2252, CAST(N'2019-10-20 08:39:53.313' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2253, CAST(N'2019-10-20 08:41:57.877' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2254, CAST(N'2019-10-21 11:20:34.907' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2255, CAST(N'2019-10-21 11:22:20.673' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2256, CAST(N'2019-10-21 11:42:36.703' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2257, CAST(N'2019-10-21 11:45:03.840' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2258, CAST(N'2019-10-21 11:45:47.397' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2259, CAST(N'2019-10-21 11:46:16.600' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2260, CAST(N'2019-10-21 12:12:41.810' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2261, CAST(N'2019-10-21 12:14:48.350' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2262, CAST(N'2019-10-21 12:19:27.147' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2263, CAST(N'2019-10-21 12:20:17.187' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2264, CAST(N'2019-10-21 12:20:56.947' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2265, CAST(N'2019-10-22 10:36:09.503' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2266, CAST(N'2019-10-22 10:38:42.717' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2267, CAST(N'2019-10-22 17:20:39.060' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2268, CAST(N'2019-10-22 20:29:06.873' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2269, CAST(N'2019-11-03 10:21:12.537' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2270, CAST(N'2019-11-03 10:54:57.430' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2271, CAST(N'2019-11-03 10:57:12.530' AS DateTime), 5, 1, N'Ocurrió un error al intentar crear la empresa Google Inc. ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2272, CAST(N'2019-11-03 10:59:30.820' AS DateTime), 5, 1, N'Ocurrió un error al intentar crear la empresa Facebook ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2273, CAST(N'2019-11-03 18:21:28.260' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2274, CAST(N'2019-11-03 18:40:00.740' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2275, CAST(N'2019-11-03 18:41:21.087' AS DateTime), 5, 1, N'Ocurrió un error al intentar crear la empresa Microsoft ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2276, CAST(N'2019-11-03 18:42:19.013' AS DateTime), 5, 2, N'Se eliminó la empresa Microsoft ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2277, CAST(N'2019-11-03 18:42:22.277' AS DateTime), 5, 2, N'Se eliminó la empresa Google Inc. ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2278, CAST(N'2019-11-03 18:42:24.333' AS DateTime), 5, 2, N'Se eliminó la empresa Facebook ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2279, CAST(N'2019-11-03 18:50:41.080' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2280, CAST(N'2019-11-03 18:51:01.340' AS DateTime), 5, 2, N'Se creo la empresa Google ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2281, CAST(N'2019-11-03 18:51:41.623' AS DateTime), 5, 2, N'Se editó la empresa Google Inc. ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2282, CAST(N'2019-11-03 18:52:24.740' AS DateTime), 5, 1, N'Ocurrió un error al intentar eliminar la empresa Google Inc. ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2283, CAST(N'2019-11-03 19:02:12.213' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2284, CAST(N'2019-11-03 19:03:03.657' AS DateTime), 5, 2, N'Se editó la empresa Google Inc. ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2285, CAST(N'2019-11-04 10:25:58.543' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2286, CAST(N'2019-11-04 10:26:11.590' AS DateTime), 5, 2, N'Se editó la empresa Microsoft ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2287, CAST(N'2019-11-04 10:26:20.297' AS DateTime), 5, 2, N'Se editó la empresa Globant ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2288, CAST(N'2019-11-04 10:26:29.617' AS DateTime), 5, 2, N'Se editó la empresa Microsoft ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2289, CAST(N'2019-11-04 10:26:38.537' AS DateTime), 5, 2, N'Se editó la empresa Globant ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2290, CAST(N'2019-11-04 10:56:56.730' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2291, CAST(N'2019-11-04 10:57:51.633' AS DateTime), 5, 2, N'Se editó la empresa SoftVision SA ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2292, CAST(N'2019-11-04 20:03:57.837' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2293, CAST(N'2019-11-04 20:04:27.367' AS DateTime), 5, 2, N'Se creo la empresa Amazon ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2294, CAST(N'2019-11-04 20:05:11.653' AS DateTime), 5, 2, N'Se creo la empresa Google ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2295, CAST(N'2019-11-04 20:05:51.877' AS DateTime), 5, 2, N'Se creo la empresa Oracle ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2296, CAST(N'2019-11-04 20:06:47.203' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2297, CAST(N'2019-11-04 20:07:24.857' AS DateTime), 5, 2, N'Se creo la empresa ITC SRL ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2298, CAST(N'2019-11-04 20:08:12.977' AS DateTime), 5, 2, N'Se creo la empresa Global System SA ')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2299, CAST(N'2019-11-04 21:39:14.880' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2300, CAST(N'2019-11-04 21:44:54.337' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2301, CAST(N'2019-11-04 21:45:09.273' AS DateTime), 1, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2302, CAST(N'2019-11-04 21:45:22.203' AS DateTime), 2, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2303, CAST(N'2019-11-04 21:46:44.620' AS DateTime), 2, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2304, CAST(N'2019-11-05 09:54:54.647' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2305, CAST(N'2019-11-05 09:58:04.880' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2306, CAST(N'2019-11-05 09:58:32.270' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2307, CAST(N'2019-11-05 10:02:51.080' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2308, CAST(N'2019-11-05 11:49:10.467' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2309, CAST(N'2019-11-05 11:54:03.057' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2310, CAST(N'2019-11-05 11:55:10.727' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2311, CAST(N'2019-11-05 11:57:24.190' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2312, CAST(N'2019-11-05 11:57:59.567' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2313, CAST(N'2019-11-05 11:58:33.277' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2314, CAST(N'2019-11-05 12:05:34.153' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2315, CAST(N'2019-11-05 12:09:04.097' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2316, CAST(N'2019-11-05 12:09:35.233' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2317, CAST(N'2019-11-05 12:14:21.753' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2318, CAST(N'2019-11-05 12:33:28.193' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2319, CAST(N'2019-11-05 16:22:50.033' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2320, CAST(N'2019-11-05 16:30:44.490' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2321, CAST(N'2019-11-05 16:32:34.580' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2322, CAST(N'2019-11-05 16:33:28.033' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2323, CAST(N'2019-11-05 16:34:47.450' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2324, CAST(N'2019-11-05 16:38:13.973' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2325, CAST(N'2019-11-05 16:38:47.573' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2326, CAST(N'2019-11-05 16:39:57.773' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2327, CAST(N'2019-11-05 16:41:49.730' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2328, CAST(N'2019-11-05 16:42:36.053' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2329, CAST(N'2019-11-05 17:57:13.213' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2330, CAST(N'2019-11-05 17:57:38.957' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2331, CAST(N'2019-11-05 18:00:45.313' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2332, CAST(N'2019-11-05 18:04:13.777' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2333, CAST(N'2019-11-05 18:06:14.983' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2334, CAST(N'2019-11-05 18:08:08.467' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2335, CAST(N'2019-11-05 18:14:11.683' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2336, CAST(N'2019-11-05 18:15:22.933' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2337, CAST(N'2019-11-05 18:25:48.783' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2338, CAST(N'2019-11-05 19:55:03.207' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2339, CAST(N'2019-11-06 09:50:41.330' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2340, CAST(N'2019-11-06 09:50:44.733' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2341, CAST(N'2019-11-06 09:50:49.027' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2342, CAST(N'2019-11-06 10:27:59.203' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2343, CAST(N'2019-11-11 12:07:40.600' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2344, CAST(N'2019-11-11 12:08:41.727' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2345, CAST(N'2019-11-11 12:10:07.823' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2346, CAST(N'2019-11-11 12:13:58.033' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2347, CAST(N'2019-11-11 12:23:24.993' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2348, CAST(N'2019-11-11 15:11:46.993' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2355, CAST(N'2019-11-11 15:26:17.663' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2356, CAST(N'2019-11-11 18:40:47.367' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2357, CAST(N'2019-11-11 18:55:46.850' AS DateTime), 5, 2, N'Ingresó al sistema')
GO
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2358, CAST(N'2019-11-11 18:56:13.527' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2361, CAST(N'2019-11-11 18:57:16.277' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2362, CAST(N'2019-11-11 18:57:26.210' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2365, CAST(N'2019-11-11 18:57:45.000' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2366, CAST(N'2019-11-11 18:58:22.540' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2367, CAST(N'2019-11-11 18:58:30.607' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2370, CAST(N'2019-11-11 18:58:42.100' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2371, CAST(N'2019-11-11 19:01:45.940' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2372, CAST(N'2019-11-11 19:02:39.613' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2374, CAST(N'2019-11-11 21:13:11.370' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2375, CAST(N'2019-11-11 21:19:50.333' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2376, CAST(N'2019-11-11 21:36:43.827' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2377, CAST(N'2019-11-11 21:39:16.910' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2378, CAST(N'2019-11-11 21:40:43.900' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2379, CAST(N'2019-11-11 21:47:40.297' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2380, CAST(N'2019-11-11 21:49:37.063' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2381, CAST(N'2019-11-11 21:50:56.477' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2382, CAST(N'2019-11-11 21:52:36.527' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2383, CAST(N'2019-11-11 21:53:35.067' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2384, CAST(N'2019-11-11 21:57:38.007' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2385, CAST(N'2019-11-12 00:58:30.697' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2386, CAST(N'2019-11-12 01:02:08.470' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2387, CAST(N'2019-11-13 10:30:58.680' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2388, CAST(N'2019-11-13 10:33:14.503' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2389, CAST(N'2019-11-13 10:36:02.087' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2390, CAST(N'2019-11-13 10:37:12.703' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2391, CAST(N'2019-11-13 11:23:21.060' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2392, CAST(N'2019-11-13 11:28:30.683' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2393, CAST(N'2019-11-13 11:31:31.143' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2394, CAST(N'2019-11-16 10:34:26.617' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2395, CAST(N'2019-11-16 11:01:41.327' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2396, CAST(N'2019-11-16 12:09:22.950' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2397, CAST(N'2019-11-16 12:14:47.940' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2398, CAST(N'2019-11-16 12:19:35.443' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2399, CAST(N'2019-11-16 13:04:06.170' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2400, CAST(N'2019-11-16 13:07:20.673' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2401, CAST(N'2019-11-17 16:37:40.700' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2402, CAST(N'2019-11-17 16:39:22.350' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2403, CAST(N'2019-11-17 16:42:27.110' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2404, CAST(N'2019-11-17 16:47:41.303' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2405, CAST(N'2019-11-17 17:09:32.273' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2406, CAST(N'2019-11-17 17:12:05.347' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2407, CAST(N'2019-11-17 17:15:12.627' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2408, CAST(N'2019-11-17 17:19:45.403' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2409, CAST(N'2019-11-17 18:06:27.233' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2410, CAST(N'2019-11-17 18:07:53.130' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2411, CAST(N'2019-11-17 18:13:50.163' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2412, CAST(N'2019-11-17 18:17:25.450' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2413, CAST(N'2019-11-17 18:18:09.550' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2414, CAST(N'2019-11-17 18:25:16.407' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2415, CAST(N'2019-11-17 18:25:43.563' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2416, CAST(N'2019-11-17 18:29:12.297' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2417, CAST(N'2019-11-17 18:33:55.243' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2418, CAST(N'2019-11-17 18:38:00.340' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2419, CAST(N'2019-11-17 18:41:37.750' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2420, CAST(N'2019-11-17 18:43:17.380' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2421, CAST(N'2019-11-18 19:17:27.227' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2422, CAST(N'2019-11-18 19:19:43.060' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2423, CAST(N'2019-11-18 19:22:54.627' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2424, CAST(N'2019-11-18 19:24:35.283' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2425, CAST(N'2019-11-18 19:27:33.297' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2426, CAST(N'2019-11-18 19:33:00.003' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2427, CAST(N'2019-11-18 20:22:01.270' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2428, CAST(N'2019-11-18 20:28:53.623' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2429, CAST(N'2019-11-18 20:36:39.957' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2430, CAST(N'2019-11-18 22:34:01.290' AS DateTime), 5, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2431, CAST(N'2019-11-18 22:35:05.803' AS DateTime), 5, 2, N'Salió del sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2432, CAST(N'2019-11-18 22:35:10.323' AS DateTime), 1, 2, N'Ingresó al sistema')
INSERT [dbo].[Bitacora] ([Id], [FechaCreacion], [UsuarioId], [TipoEventoId], [Descripcion]) VALUES (2433, CAST(N'2019-11-19 17:43:14.583' AS DateTime), 1, 2, N'Ingresó al sistema')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
SET IDENTITY_INSERT [dbo].[CurriculumVitae] ON 

INSERT [dbo].[CurriculumVitae] ([Id], [FechaCreacion], [ProfesionalId]) VALUES (1, CAST(N'2019-11-04 20:22:32.173' AS DateTime), 1)
INSERT [dbo].[CurriculumVitae] ([Id], [FechaCreacion], [ProfesionalId]) VALUES (2, CAST(N'2019-11-04 20:23:08.810' AS DateTime), 2)
INSERT [dbo].[CurriculumVitae] ([Id], [FechaCreacion], [ProfesionalId]) VALUES (3, CAST(N'2019-11-04 20:23:19.393' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[CurriculumVitae] OFF
SET IDENTITY_INSERT [dbo].[CurriculumVitaeConocimiento] ON 

INSERT [dbo].[CurriculumVitaeConocimiento] ([Id], [Descripcion], [FechaCreacion], [CurriculumVitaeId]) VALUES (1, N'Vasta experiencia diseño, desarrollo e implementacion de aplicaciones webs', CAST(N'2019-11-04 20:25:24.090' AS DateTime), 1)
INSERT [dbo].[CurriculumVitaeConocimiento] ([Id], [Descripcion], [FechaCreacion], [CurriculumVitaeId]) VALUES (2, N'Solidos conocimientos de programacion orientada objetos y programacion de base de datos', CAST(N'2019-11-04 20:26:00.073' AS DateTime), 2)
INSERT [dbo].[CurriculumVitaeConocimiento] ([Id], [Descripcion], [FechaCreacion], [CurriculumVitaeId]) VALUES (3, N'3 años de experiencia en desarrollo de microservicios en java', CAST(N'2019-11-04 20:26:42.243' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[CurriculumVitaeConocimiento] OFF
SET IDENTITY_INSERT [dbo].[CurriculumVitaeEstudio] ON 

INSERT [dbo].[CurriculumVitaeEstudio] ([Id], [Descripcion], [FechaFin], [NivelEstudioId], [CurriculumVitaeId]) VALUES (1, N'Egresé del coelgio Confederacipon Suiza como técnico en computación', CAST(N'2014-12-31' AS Date), 2, 1)
INSERT [dbo].[CurriculumVitaeEstudio] ([Id], [Descripcion], [FechaFin], [NivelEstudioId], [CurriculumVitaeId]) VALUES (2, N'Me recibí de ingeniero en sistemas en la UAI', CAST(N'2016-12-31' AS Date), 4, 2)
INSERT [dbo].[CurriculumVitaeEstudio] ([Id], [Descripcion], [FechaFin], [NivelEstudioId], [CurriculumVitaeId]) VALUES (3, N'Me recibi de analista de sistemas en la UTN', CAST(N'2016-12-31' AS Date), 3, 3)
SET IDENTITY_INSERT [dbo].[CurriculumVitaeEstudio] OFF
SET IDENTITY_INSERT [dbo].[CurriculumVitaeExperiencia] ON 

INSERT [dbo].[CurriculumVitaeExperiencia] ([Id], [Descripcion], [AniosExperiencia], [Empresa], [CurriculumVitaeId]) VALUES (1, N'Trabajé como analista programador en C# en Accenture durante 3 años', 3, N'Accenture', 1)
INSERT [dbo].[CurriculumVitaeExperiencia] ([Id], [Descripcion], [AniosExperiencia], [Empresa], [CurriculumVitaeId]) VALUES (2, N'Trabajé como analista programador en C# en Globant durante 1 año', 1, N'Accenture', 1)
INSERT [dbo].[CurriculumVitaeExperiencia] ([Id], [Descripcion], [AniosExperiencia], [Empresa], [CurriculumVitaeId]) VALUES (3, N'Trabajé como analista programador en C# en Hexacta durante 2 años', 2, N'Hexacta', 2)
INSERT [dbo].[CurriculumVitaeExperiencia] ([Id], [Descripcion], [AniosExperiencia], [Empresa], [CurriculumVitaeId]) VALUES (4, N'Trabajé como analista programador en C# en Cognizant durante 3 años', 3, N'Cognizant', 2)
INSERT [dbo].[CurriculumVitaeExperiencia] ([Id], [Descripcion], [AniosExperiencia], [Empresa], [CurriculumVitaeId]) VALUES (5, N'Trabajé como analista programador en java en Globa Logic durante 3 años', 3, N'Global Logic', 3)
INSERT [dbo].[CurriculumVitaeExperiencia] ([Id], [Descripcion], [AniosExperiencia], [Empresa], [CurriculumVitaeId]) VALUES (6, N'Trabajé como analista programador en java en 10Pines durante 1 año', 1, N'10Pines', 3)
SET IDENTITY_INSERT [dbo].[CurriculumVitaeExperiencia] OFF
SET IDENTITY_INSERT [dbo].[CurriculumVitaeIdioma] ON 

INSERT [dbo].[CurriculumVitaeIdioma] ([Id], [Idioma], [Descripcion], [CurriculumVitaeId]) VALUES (1, N'Ingles', N'Nivel Intermediate', 1)
INSERT [dbo].[CurriculumVitaeIdioma] ([Id], [Idioma], [Descripcion], [CurriculumVitaeId]) VALUES (2, N'Ingles', N'Rendi el First Certificate en el año 2015', 2)
INSERT [dbo].[CurriculumVitaeIdioma] ([Id], [Idioma], [Descripcion], [CurriculumVitaeId]) VALUES (3, N'Ingles', N'Nivel pre-intermediate', 3)
SET IDENTITY_INSERT [dbo].[CurriculumVitaeIdioma] OFF
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (1, 1)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (1, 4)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (1, 5)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (1, 6)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (1, 7)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (2, 1)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (2, 7)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (2, 8)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (3, 2)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (3, 7)
INSERT [dbo].[CurriculumVitaeTecnologia] ([CurriculumVitaeId], [TecnologiaId]) VALUES (3, 9)
SET IDENTITY_INSERT [dbo].[DigitoVerificador] ON 

INSERT [dbo].[DigitoVerificador] ([Id], [TablaSistemaId], [FechaCreacion], [FechaActualizacion], [DVV]) VALUES (8, 2, CAST(N'2019-11-03 10:57:12.013' AS DateTime), CAST(N'2019-11-04 20:08:12.960' AS DateTime), 2830988)
SET IDENTITY_INSERT [dbo].[DigitoVerificador] OFF
SET IDENTITY_INSERT [dbo].[Empresa] ON 

INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (11, N'Microsoft', N'Av. Belgrano 1200', N'11098098', N'info@microsoft.com', N'023098009', CAST(N'2019-11-03 18:21:51.000' AS DateTime), CAST(N'2019-11-04 10:26:29.000' AS DateTime), 411137)
INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (13, N'SoftVision SA', N'av. cabildo 123', N'11223344', N'info@softvision.com.ar', N'987987987', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-04 10:57:51.000' AS DateTime), 440301)
INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (14, N'Amazon', N'Av. Rivadavia 2300', N'098098', N'info@amazon.com', N'987987987', CAST(N'2019-11-04 20:04:27.000' AS DateTime), CAST(N'2019-11-04 20:04:27.000' AS DateTime), 387764)
INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (15, N'Google', N'Av. Alem 222', N'9876897', N'info@google.com', N'56678798', CAST(N'2019-11-04 20:05:11.000' AS DateTime), CAST(N'2019-11-04 20:05:11.000' AS DateTime), 369233)
INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (16, N'Oracle', N'Av. San Juan 800', N'5678998', N'info@oracle.com', N'987678786', CAST(N'2019-11-04 20:05:51.000' AS DateTime), CAST(N'2019-11-04 20:05:51.000' AS DateTime), 381153)
INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (17, N'ITC SRL', N'Lavalle 678', N'987867', N'rrhh@itc.com.ar', N'987754', CAST(N'2019-11-04 20:07:24.000' AS DateTime), CAST(N'2019-11-04 20:07:24.000' AS DateTime), 362059)
INSERT [dbo].[Empresa] ([Id], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [DVH]) VALUES (18, N'Global System SA', N'Av. Independencia 2500', N'987865', N'rrhh@globalsystem.com.ar', N'12386768', CAST(N'2019-11-04 20:08:12.000' AS DateTime), CAST(N'2019-11-04 20:08:12.000' AS DateTime), 479341)
SET IDENTITY_INSERT [dbo].[Empresa] OFF
SET IDENTITY_INSERT [dbo].[EmpresaHistorico] ON 

INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (5, 13, N'Google', N'av. cabildo 123', N'24234', N'info@google.com', N'0298098098', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), 380319)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (6, 13, N'Google Inc.', N'av. cabildo 456', N'11223344', N'info@google.com.ar', N'987987987', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:41.000' AS DateTime), 403027)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (7, 13, N'Google Inc.', N'av. cabildo 123', N'11223344', N'info@google.com.ar', N'987987987', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 19:03:03.000' AS DateTime), 402327)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (8, 11, N'Microsoft', N'Av. Belgrano 1200', N'11098098', N'info@amazon.com', N'023098009', CAST(N'2019-11-03 18:21:51.000' AS DateTime), CAST(N'2019-11-03 18:21:51.000' AS DateTime), CAST(N'2019-11-04 10:26:11.000' AS DateTime), 388267)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (9, 13, N'Globant', N'av. cabildo 123', N'11223344', N'info@google.com.ar', N'987987987', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-04 10:26:20.000' AS DateTime), 399468)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (10, 11, N'Microsoft', N'Av. Belgrano 1200', N'11098098', N'info@microsoft.com', N'023098009', CAST(N'2019-11-03 18:21:51.000' AS DateTime), CAST(N'2019-11-03 18:21:51.000' AS DateTime), CAST(N'2019-11-04 10:26:29.000' AS DateTime), 411137)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (11, 13, N'Globant', N'av. cabildo 123', N'11223344', N'info@globant.com.ar', N'987987987', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-04 10:26:38.000' AS DateTime), 408406)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (12, 13, N'SoftVision SA', N'av. cabildo 123', N'11223344', N'info@softvision.com.ar', N'987987987', CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-03 18:51:01.000' AS DateTime), CAST(N'2019-11-04 10:57:51.000' AS DateTime), 440301)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (13, 14, N'Amazon', N'Av. Rivadavia 2300', N'098098', N'info@amazon.com', N'987987987', CAST(N'2019-11-04 20:04:27.000' AS DateTime), CAST(N'2019-11-04 20:04:27.000' AS DateTime), CAST(N'2019-11-04 20:04:27.000' AS DateTime), 387764)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (14, 15, N'Google', N'Av. Alem 222', N'9876897', N'info@google.com', N'56678798', CAST(N'2019-11-04 20:05:11.000' AS DateTime), CAST(N'2019-11-04 20:05:11.000' AS DateTime), CAST(N'2019-11-04 20:05:11.000' AS DateTime), 369233)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (15, 16, N'Oracle', N'Av. San Juan 800', N'5678998', N'info@oracle.com', N'987678786', CAST(N'2019-11-04 20:05:51.000' AS DateTime), CAST(N'2019-11-04 20:05:51.000' AS DateTime), CAST(N'2019-11-04 20:05:51.000' AS DateTime), 381153)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (16, 17, N'ITC SRL', N'Lavalle 678', N'987867', N'rrhh@itc.com.ar', N'987754', CAST(N'2019-11-04 20:07:24.000' AS DateTime), CAST(N'2019-11-04 20:07:24.000' AS DateTime), CAST(N'2019-11-04 20:07:24.000' AS DateTime), 362059)
INSERT [dbo].[EmpresaHistorico] ([Id], [EmpresaId], [RazonSocial], [Direccion], [Telefono], [Email], [CUIT], [FechaCreacion], [FechaActualizacion], [FechaCreacionHistorico], [DVH]) VALUES (17, 18, N'Global System SA', N'Av. Independencia 2500', N'987865', N'rrhh@globalsystem.com.ar', N'12386768', CAST(N'2019-11-04 20:08:12.000' AS DateTime), CAST(N'2019-11-04 20:08:12.000' AS DateTime), CAST(N'2019-11-04 20:08:12.000' AS DateTime), 479341)
SET IDENTITY_INSERT [dbo].[EmpresaHistorico] OFF
SET IDENTITY_INSERT [dbo].[Evaluacion] ON 

INSERT [dbo].[Evaluacion] ([Id], [Descripcion], [CodigoFuenteTest], [Ejercicio], [EvaluacionTipoId], [Tiempo]) VALUES (1, N'Desarrollar en C# un método que reciba un número entero y retorne el factorial de dicho número. El método debe llamarse: MiMetodo', N'using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
	public class Program
	{
		static Random random;
		static Program()
		{
			random = new Random();
		}
		static void Main(string[] args)
		{
			TestMiMetodo();
		}
		static void TestMiMetodo()
		{
			for(int i = 0; i < 5; i++)
			{
				int numero = random.Next(0, 12);
				int resultadoObtenido = MiMetodo(numero);
				int resultadoEsperado = ImplementacionDeseadaMiMetodo(numero);
				Console.Write(string.Format("Resultado obtenido: {0} Resultado esperado: {1}", resultadoObtenido, resultadoEsperado));
				if(resultadoObtenido == resultadoEsperado)
					Console.WriteLine(" SUCCESS");
				else
					Console.WriteLine(" ERROR");
			}
		}
		static int ImplementacionDeseadaMiMetodo(int numero)
		{
			int factorial = 1;
			for(int i = 1; i <= numero; i++)
				factorial = factorial * i;
			return factorial;
		}
		static XXX_MI_METODO_XXX
	}
}
', N'Ejercicio2', 1, N'00:02:00')
INSERT [dbo].[Evaluacion] ([Id], [Descripcion], [CodigoFuenteTest], [Ejercicio], [EvaluacionTipoId], [Tiempo]) VALUES (2, N'Desarrollar en C# un método que reciba un array de enteros y retorne la suma de los números de dicho array. El método debe llamarse: MiMetodo', N'using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEjercicio1
{
	public class Program
	{
		static Random random;
		static Program()
		{
			random = new Random();
		}
		static void Main(string[] args)
		{
			TestMiMetodo();
		}
		static void TestMiMetodo()
		{
			for(int i = 0; i < 5; i++)
			{
				int[] v = GetRandomArray();
				int resultadoObtenido = MiMetodo(v);
				int resultadoEsperado = ImplementacionDeseadaMiMetodo(v);
				Console.Write(string.Format("Resultado obtenido: {0} Resultado esperado: {1}", resultadoObtenido, resultadoEsperado));
				if(resultadoObtenido == resultadoEsperado)
					Console.WriteLine(" SUCCESS");
				else
					Console.WriteLine(" ERROR");
			}
		}

		static int[] GetRandomArray()
		{
			int len = random.Next(1, 100);
			int[] v = new int[len];
			for(int i = 0; i < len; i++)
				v[i] = random.Next(-1000, 1000);
			return v;
		}
		static int ImplementacionDeseadaMiMetodo(int[] numeros)
		{
			int suma = 0;
			for(int i = 0; i < numeros.Length; i++)
				suma += numeros[i];
			return suma;
		}
		static XXX_MI_METODO_XXX
	}
}
', N'Ejercicio1', 1, N'00:03:00')
INSERT [dbo].[Evaluacion] ([Id], [Descripcion], [CodigoFuenteTest], [Ejercicio], [EvaluacionTipoId], [Tiempo]) VALUES (3, N'Desarrollar en C# un método que reciba un string que contiene una oración y retorne la cantidad de palabras que tiene dicho string. El método debe llamarse: MiMetodo', N'using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEjercicio3
{
	public class Program
	{
		static Random random;
		static Program()
		{
			random = new Random();
		}
		static void Main(string[] args)
		{
			TestMiMetodo();
		}
		static string GetRandomString()
		{
			string str = "";
			int len = random.Next(1, 10);
			for(int k = 0; k < len; k++)
			{
				for(int i = 0; i < random.Next(1, 20); i++)
				{
					str += ((char)(''a'' + random.Next(0, 26))).ToString();
				}
				for(int j = 0; j < random.Next(1, 20); j++)
				{
					str += " ";
				}
			}
			return str;
		}
		static void TestMiMetodo()
		{
			for(int i = 0; i < 5; i++)
			{
				string valor = GetRandomString();
				Console.WriteLine(valor);
				int resultadoObtenido = MiMetodo(valor);
				int resultadoEsperado = ImplementacionDeseadaMiMetodo(valor);
				Console.Write(string.Format("Resultado obtenido: {0} Resultado esperado: {1}", resultadoObtenido, resultadoEsperado));
				if(resultadoObtenido == resultadoEsperado)
					Console.WriteLine(" SUCCESS");
				else
					Console.WriteLine(" ERROR");
			}
		}
		static int ImplementacionDeseadaMiMetodo(string oracion)
		{
			int cantidadPalabras = 0;
			string[] arrayOracion = oracion.Split('' '');
			for(int i = 0; i < arrayOracion.Length; i++)
			{
				if(!string.IsNullOrEmpty(arrayOracion[i]))
					cantidadPalabras++;
			}
			return cantidadPalabras;
		}
		static XXX_MI_METODO_XXX	}
}
', N'Ejercicio3', 1, N'00:05:00')
SET IDENTITY_INSERT [dbo].[Evaluacion] OFF
SET IDENTITY_INSERT [dbo].[EvaluacionTipo] ON 

INSERT [dbo].[EvaluacionTipo] ([Id], [Nombre]) VALUES (1, N'Programación')
INSERT [dbo].[EvaluacionTipo] ([Id], [Nombre]) VALUES (2, N'Base de datos')
SET IDENTITY_INSERT [dbo].[EvaluacionTipo] OFF
INSERT [dbo].[Frase] ([Tag]) VALUES (N'administracion_sistema')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'agregar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'agregar_perfil_a_perfil')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'agregar_permiso_a_perfil')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'archivo')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'cancelar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'carpeta_destino')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'cerrar_sesion')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'clave')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'crear')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'cuit')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'descripcion')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'direccion')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'editar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'eliminar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'email')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'empresa')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_backup')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_empresa')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_perfil_profesional')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_perfiles')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_perfiles_permisos')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_perfiles_permisos_usuarios')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_postulante')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'gestion_usuarios')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'guardar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'ingresar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'ingrese_credenciales')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'ingreso_sistema')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'inicio')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'panel_de_control')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'perfil')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'perfiles')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'perfiles_permisos')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'permisos')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'postularse_aviso')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'publicar_aviso')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'quitar')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'razon_social')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'realizar_backup')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'realizar_restore')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'salir')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'seleccione_archivo')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'seleccione_carpeta')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'seleccione_dir_destino_bkp')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'selecione_idioma')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'telefono')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'usuario')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'usuarios')
INSERT [dbo].[Frase] ([Tag]) VALUES (N'ver_listado_empresas')
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (2, N'Inglés')
INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (3, N'Francés')
INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (4, N'Portugues')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'administracion_sistema', N'Administración Sistema')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'agregar', N'Agregar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'agregar_perfil_a_perfil', N'Agregar Perfil a Perfil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'agregar_permiso_a_perfil', N'Agregar Permiso a Perfil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'archivo', N'Archivo')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'cancelar', N'Cancelar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'carpeta_destino', N'Carpeta destino')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'cerrar_sesion', N'Cerrar Sesión')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'clave', N'Contraseña')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'crear', N'Crear')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'cuit', N'CUIT')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'descripcion', N'Descripción')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'direccion', N'Dirección')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'editar', N'Editar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'eliminar', N'Eliminar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'email', N'E-mail')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'empresa', N'Empresa')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_backup', N'Gestión Backup / Restore')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_empresa', N'Gestión Empresa')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_perfil_profesional', N'Gestion Perfil Profesional')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_perfiles', N'Gestión Perfiles')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_perfiles_permisos', N'Gestión Perfiles Permisos')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_perfiles_permisos_usuarios', N'Gestión de perfiles y permisos de usuarios')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_postulante', N'Gestión Postulante')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'gestion_usuarios', N'Gestión Usuarios')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'guardar', N'Guardar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'ingresar', N'Ingresar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'ingrese_credenciales', N'Ingrese sus credenciales')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'ingreso_sistema', N'Talent Finder - Ingreso al sistema')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'inicio', N'Inicio')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'panel_de_control', N'Panel de Control')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'perfil', N'Perfil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'perfiles', N'Perfiles')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'perfiles_permisos', N'Permifles Permisos')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'permisos', N'Permisos')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'postularse_aviso', N'Gestión Postulaciones')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'publicar_aviso', N'Gestión Avisos')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'quitar', N'Quitar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'razon_social', N'Razón Social')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'realizar_backup', N'Realizar backup')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'realizar_restore', N'Realizar Restore')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'salir', N'Salir')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'seleccione_archivo', N'Seleccione archivo')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'seleccione_carpeta', N'Seleccione carpeta')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'seleccione_dir_destino_bkp', N'Seleccione la operación a realizar')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'selecione_idioma', N'Seleccione Idioma')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'telefono', N'Teléfono')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'usuario', N'Usuario')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'usuarios', N'Usuarios')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (1, N'ver_listado_empresas', N'Ver Listado Empresas')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'administracion_sistema', N'Systema Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'agregar', N'Add')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'agregar_perfil_a_perfil', N'Add Profile to Profile')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'agregar_permiso_a_perfil', N'Add Permission to Profile')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'archivo', N'File')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'cancelar', N'Cancel')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'carpeta_destino', N'Target directory')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'cerrar_sesion', N'Logout')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'clave', N'Password')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'crear', N'Create')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'cuit', N'CUIT')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'descripcion', N'Description')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'direccion', N'Address')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'editar', N'Edit')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'eliminar', N'Remove')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'email', N'E-mail')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'empresa', N'Company')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_backup', N'Backup Restore Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_empresa', N'Company Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_perfil_profesional', N'Professional Profile Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_perfiles', N'Profile Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_perfiles_permisos', N'Profile Permission Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_perfiles_permisos_usuarios', N'Profile Permission Users')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_postulante', N'Candidate Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'gestion_usuarios', N'User Management')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'guardar', N'Save')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'ingresar', N'Login')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'ingrese_credenciales', N'Enter your credentials')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'ingreso_sistema', N'Talent Finder - Login System')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'inicio', N'Home')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'panel_de_control', N'Control Panel')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'perfil', N'Profile')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'perfiles', N'Profiles')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'perfiles_permisos', N'Profile Permission')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'permisos', N'Permissions')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'postularse_aviso', N'Apply to job')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'publicar_aviso', N'Post a Job')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'quitar', N'Detach')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'razon_social', N'Company')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'realizar_backup', N'Make Backup')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'realizar_restore', N'Make Restore')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'salir', N'Exit')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'seleccione_archivo', N'Choose File')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'seleccione_carpeta', N'Choose folder')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'seleccione_dir_destino_bkp', N'Choose an option')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'selecione_idioma', N'Choose Language')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'telefono', N'Telephone')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'usuario', N'User')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'usuarios', N'Users')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (2, N'ver_listado_empresas', N'Companies List')
GO
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'administracion_sistema', N'A gestion du système')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'agregar', N'Ajouter')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'agregar_perfil_a_perfil', N'Ajouter un profil à un profil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'agregar_permiso_a_perfil', N'Ajouter la permission au profil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'archivo', N'Fichier')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'cancelar', N'Annuler')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'carpeta_destino', N'Répertoire cible')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'cerrar_sesion', N'Logout')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'clave', N'Mot de passe')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'crear', N'Créer')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'cuit', N'CUIT')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'descripcion', N'La description')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'direccion', N'Address')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'editar', N'Modifier')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'eliminar', N'Retirer')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'email', N'E-mail')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'empresa', N'Enterprise')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_backup', N'Gestion de Sauvegarde Restaurer')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_empresa', N'gestion d''entreprise')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_perfil_profesional', N'Gestion de profil professionnel')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_perfiles', N'Gestion profil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_perfiles_permisos', N'Gestion des autorisations de profil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_perfiles_permisos_usuarios', N'Utilisateurs de l''autorisation de profil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_postulante', N'Gestion des candidats')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'gestion_usuarios', N'Gestion Utilisateur')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'guardar', N'Enregistrer')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'ingresar', N'Login')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'ingrese_credenciales', N'Entrez vos identifiants')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'ingreso_sistema', N'Talent Finder - Login système')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'inicio', N'Home')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'panel_de_control', N'Panneau de Configuration')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'perfil', N'Profil')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'perfiles', N'Profils')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'perfiles_permisos', N'Permission')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'permisos', N'Les permissions')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'postularse_aviso', N'Postuler pour un emploi')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'publicar_aviso', N'Publier une offre')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'quitar', N'
Détacher')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'razon_social', N'Enterprise')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'realizar_backup', N'Faire une sauvegarde')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'realizar_restore', N'Faire la restauration')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'salir', N'Quitter')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'seleccione_archivo', N'Choisir le fichier')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'seleccione_carpeta', N'Choisir le dossier')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'seleccione_dir_destino_bkp', N'Choisir la cible du dossier de sauvegarde')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'selecione_idioma', N'Choisir la langue')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'telefono', N'Telephone')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'usuario', N'Utilisateur')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'usuarios', N'Utilisatrices')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (3, N'ver_listado_empresas', N'Liste des entreprises')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'administracion_sistema', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'agregar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'agregar_perfil_a_perfil', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'agregar_permiso_a_perfil', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'archivo', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'cancelar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'carpeta_destino', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'cerrar_sesion', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'clave', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'crear', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'cuit', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'descripcion', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'direccion', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'editar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'eliminar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'email', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'empresa', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_backup', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_empresa', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_perfil_profesional', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_perfiles', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_perfiles_permisos', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_perfiles_permisos_usuarios', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_postulante', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'gestion_usuarios', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'guardar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'ingresar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'ingrese_credenciales', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'ingreso_sistema', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'inicio', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'panel_de_control', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'perfil', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'perfiles', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'perfiles_permisos', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'permisos', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'postularse_aviso', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'publicar_aviso', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'quitar', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'razon_social', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'realizar_backup', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'realizar_restore', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'salir', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'seleccione_archivo', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'seleccione_carpeta', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'seleccione_dir_destino_bkp', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'selecione_idioma', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'telefono', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'usuario', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'usuarios', N'tudo bem')
INSERT [dbo].[IdiomaFrase] ([IdiomaId], [Tag], [Traduccion]) VALUES (4, N'ver_listado_empresas', N'tudo bem')
GO
SET IDENTITY_INSERT [dbo].[NivelEstudio] ON 

INSERT [dbo].[NivelEstudio] ([Id], [Nombre]) VALUES (1, N'Primario')
INSERT [dbo].[NivelEstudio] ([Id], [Nombre]) VALUES (2, N'Secundario')
INSERT [dbo].[NivelEstudio] ([Id], [Nombre]) VALUES (3, N'Terciario')
INSERT [dbo].[NivelEstudio] ([Id], [Nombre]) VALUES (4, N'Universitario')
INSERT [dbo].[NivelEstudio] ([Id], [Nombre]) VALUES (5, N'Posgrado')
SET IDENTITY_INSERT [dbo].[NivelEstudio] OFF
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (1, N'Root', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (2, N'Reclutador', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (3, N'Gestión Candidato', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (4, N'Publicar aviso laboral', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (5, N'Postulante', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (6, N'Gestión Perfil Profesional', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (7, N'Postularse a aviso laboral', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (8, N'Administrador de Sistema', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (9, N'Gestion Sistema', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (10, N'Gestion Usuarios', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (11, N'Gestion Perfiles', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (12, N'Leer usuario', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (13, N'Crear usuario', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (14, N'Editar usuario', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (15, N'Eliminar usuario', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (16, N'Leer perfil', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (17, N'Crear perfil', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (18, N'Editar perfil', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (19, N'Eliminar perfil', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (20, N'Operador de Sistema', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (21, N'Gestión Empresa', 1)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (22, N'Leer Empresa', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (23, N'Crear Empresa', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (24, N'Editar Empresa', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (25, N'Eliminar Empresa', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (26, N'Realizar Backup', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (27, N'Realizar Restore', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (28, N'Ver Bitácora', 2)
INSERT [dbo].[Permiso] ([Id], [Nombre], [TipoPermisoId]) VALUES (29, N'Gestión Idiomas', 2)
SET IDENTITY_INSERT [dbo].[Permiso] OFF
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (2, 1)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (3, 2)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (4, 3)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (5, 1)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (6, 5)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (7, 6)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (8, 1)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (9, 8)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (10, 9)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (11, 9)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (12, 10)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (13, 10)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (14, 10)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (15, 10)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (16, 11)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (17, 11)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (18, 11)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (19, 11)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (20, 1)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (26, 9)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (26, 10)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (27, 9)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (27, 10)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (28, 9)
INSERT [dbo].[PermisoPermiso] ([PermisoId], [PermisoPadreId]) VALUES (29, 9)
SET IDENTITY_INSERT [dbo].[Postulacion] ON 

INSERT [dbo].[Postulacion] ([Id], [FechaCreacion], [ProfesionalId], [AvisoLaboralId], [PostulacionEstadoId]) VALUES (1, CAST(N'2019-10-05 00:00:00.000' AS DateTime), 1, 2, 4)
INSERT [dbo].[Postulacion] ([Id], [FechaCreacion], [ProfesionalId], [AvisoLaboralId], [PostulacionEstadoId]) VALUES (2, CAST(N'2019-10-25 00:00:00.000' AS DateTime), 1, 3, 5)
INSERT [dbo].[Postulacion] ([Id], [FechaCreacion], [ProfesionalId], [AvisoLaboralId], [PostulacionEstadoId]) VALUES (3, CAST(N'2019-10-25 00:00:00.000' AS DateTime), 1, 6, 5)
SET IDENTITY_INSERT [dbo].[Postulacion] OFF
SET IDENTITY_INSERT [dbo].[PostulacionEstado] ON 

INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (1, N'Iniciada')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (2, N'Seleccionado')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (3, N'No Seleccionado')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (4, N'En Evaluación')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (5, N'Evaluado')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (6, N'En Entrevista')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (7, N'Entrevistado')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (8, N'Contratado')
INSERT [dbo].[PostulacionEstado] ([Id], [Nombre]) VALUES (9, N'No Contratado')
SET IDENTITY_INSERT [dbo].[PostulacionEstado] OFF
SET IDENTITY_INSERT [dbo].[PostulacionEvaluacion] ON 

INSERT [dbo].[PostulacionEvaluacion] ([Id], [FechaCreacion], [PostulacionId], [EvaluacionId], [Respuesta], [TiempoResolucionEvaluacion], [Aprobo]) VALUES (1, CAST(N'2019-11-04 21:31:57.013' AS DateTime), 1, 1, N'		int MiMetodo(int numero)
		{
			if(numero == 0 || numero == 1)
				return 1;
			else
				return MiMetodo(numero - 1) * numero;
		}', NULL, 1)
INSERT [dbo].[PostulacionEvaluacion] ([Id], [FechaCreacion], [PostulacionId], [EvaluacionId], [Respuesta], [TiempoResolucionEvaluacion], [Aprobo]) VALUES (2, CAST(N'2019-11-04 21:32:37.717' AS DateTime), 2, 2, N'int MiMetodo(int[] v)
{
return v.Sum();
}', N'00:21', 1)
INSERT [dbo].[PostulacionEvaluacion] ([Id], [FechaCreacion], [PostulacionId], [EvaluacionId], [Respuesta], [TiempoResolucionEvaluacion], [Aprobo]) VALUES (3, CAST(N'2019-11-04 21:32:37.717' AS DateTime), 3, 3, N'int MiMetodo(string oracion)
{
return 2;
}', N'00:29', 1)
SET IDENTITY_INSERT [dbo].[PostulacionEvaluacion] OFF
SET IDENTITY_INSERT [dbo].[Profesional] ON 

INSERT [dbo].[Profesional] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (1, N'Eduardo', N'Canepa', N'eduardo@outlook.com', 1, 13)
INSERT [dbo].[Profesional] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (2, N'Roberto', N'Puente', N'roberto@google.com', 3, 17)
INSERT [dbo].[Profesional] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (3, N'Juan Manuel', N'Lopez', N'juan@google.com', 4, 18)
INSERT [dbo].[Profesional] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (7, N'pepe', N'argento', N'pepe@gmail.com', 15, 17)
SET IDENTITY_INSERT [dbo].[Profesional] OFF
SET IDENTITY_INSERT [dbo].[Reclutador] ON 

INSERT [dbo].[Reclutador] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (1, N'Maria', N'Nieves', N'maria@gmail.com', 2, 11)
INSERT [dbo].[Reclutador] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (2, N'Belen', N'Díaz', N'belen@gmail.com', 4, 14)
INSERT [dbo].[Reclutador] ([Id], [Nombre], [Apellido], [Email], [UsuarioId], [EmpresaId]) VALUES (4, N'Tito', N'Puente', N'puente@gmail.com', 16, 16)
SET IDENTITY_INSERT [dbo].[Reclutador] OFF
INSERT [dbo].[TablaSistema] ([Id], [Descripcion]) VALUES (1, N'Usuario')
INSERT [dbo].[TablaSistema] ([Id], [Descripcion]) VALUES (2, N'Empresa')
SET IDENTITY_INSERT [dbo].[Tecnologia] ON 

INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (1, N'C#')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (2, N'Java')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (3, N'PHP')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (4, N'Javascript')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (5, N'HTML')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (6, N'CSS')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (7, N'SQL')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (8, N'Azure')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (9, N'AWS')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (10, N'PYTHON')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (11, N'RUBY')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (12, N'SCALA')
INSERT [dbo].[Tecnologia] ([Id], [Nombre]) VALUES (13, N'VISUAL BASIC')
SET IDENTITY_INSERT [dbo].[Tecnologia] OFF
SET IDENTITY_INSERT [dbo].[TipoEvento] ON 

INSERT [dbo].[TipoEvento] ([Id], [Nombre]) VALUES (1, N'ERROR')
INSERT [dbo].[TipoEvento] ([Id], [Nombre]) VALUES (2, N'INFORMACION')
SET IDENTITY_INSERT [dbo].[TipoEvento] OFF
SET IDENTITY_INSERT [dbo].[TipoPermiso] ON 

INSERT [dbo].[TipoPermiso] ([Id], [Nombre]) VALUES (1, N'Perfil')
INSERT [dbo].[TipoPermiso] ([Id], [Nombre]) VALUES (2, N'Permiso')
SET IDENTITY_INSERT [dbo].[TipoPermiso] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (1, N'geozed', N'4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (2, N'spike', N'4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (3, N'kabuki', N'4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (4, N'snowden', N'4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (5, N'Administrador', N'4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (6, N'operador', N'4096:wizXm5gjr+/o4kk0vwSJvAEQSSwMBYGG0M5avlZbZYU=:6S4KgHmnH3rucUPNjXxBR4F8kK96EijJYXMOS+pcmZM=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (15, N'pepe', N'4096:YZPUEcCkL53D2I6ETrlTaZnQl/lMwgTcYpd9yaTsS0g=:ccTvngSPwqbC7er2INOgPGvKmiv8lhuyufCDicGFtQI=', 1, NULL)
INSERT [dbo].[Usuario] ([Id], [UserName], [UserPassword], [Habilitado], [DVH]) VALUES (16, N'tito', N'4096:Mwm9G5Bhvj7MacgjP6IB3dziLPvsmz0pII0fERaLvH4=:yFueLw3VcBzmFrjyoOGaSaRzE60PEGSbtFxTZAOt2e0=', 1, NULL)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (1, 5)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (1, 6)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (1, 7)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (2, 2)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (2, 3)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (2, 4)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (3, 5)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (3, 6)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (3, 7)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (4, 5)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (4, 6)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (4, 7)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 9)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 10)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 11)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 12)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 13)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 14)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 15)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 16)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 17)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 18)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 19)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 21)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 22)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 23)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 24)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 25)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 26)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 27)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 28)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (5, 29)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (6, 26)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (6, 27)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (6, 28)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (15, 5)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (15, 6)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (15, 7)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (16, 2)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (16, 3)
INSERT [dbo].[UsuarioPermiso] ([UsuarioId], [PermisoId]) VALUES (16, 4)
ALTER TABLE [dbo].[AvisoLaboral]  WITH CHECK ADD  CONSTRAINT [FK_AvisoLaboral_Reclutador] FOREIGN KEY([ReclutadorId])
REFERENCES [dbo].[Reclutador] ([Id])
GO
ALTER TABLE [dbo].[AvisoLaboral] CHECK CONSTRAINT [FK_AvisoLaboral_Reclutador]
GO
ALTER TABLE [dbo].[AvisoLaboralTecnologia]  WITH CHECK ADD  CONSTRAINT [FK_AvisoLaboralTecnologia_AvisoLaboral] FOREIGN KEY([AvisoLaboralId])
REFERENCES [dbo].[AvisoLaboral] ([Id])
GO
ALTER TABLE [dbo].[AvisoLaboralTecnologia] CHECK CONSTRAINT [FK_AvisoLaboralTecnologia_AvisoLaboral]
GO
ALTER TABLE [dbo].[AvisoLaboralTecnologia]  WITH CHECK ADD  CONSTRAINT [FK_AvisoLaboralTecnologia_Tecnologia] FOREIGN KEY([TecnologiaId])
REFERENCES [dbo].[Tecnologia] ([Id])
GO
ALTER TABLE [dbo].[AvisoLaboralTecnologia] CHECK CONSTRAINT [FK_AvisoLaboralTecnologia_Tecnologia]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_TipoEvento] FOREIGN KEY([TipoEventoId])
REFERENCES [dbo].[TipoEvento] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_TipoEvento]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[CurriculumVitae]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitae_Profesional] FOREIGN KEY([ProfesionalId])
REFERENCES [dbo].[Profesional] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitae] CHECK CONSTRAINT [FK_CurriculumVitae_Profesional]
GO
ALTER TABLE [dbo].[CurriculumVitaeConocimiento]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeConocimiento_CurriculumVitae] FOREIGN KEY([CurriculumVitaeId])
REFERENCES [dbo].[CurriculumVitae] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeConocimiento] CHECK CONSTRAINT [FK_CurriculumVitaeConocimiento_CurriculumVitae]
GO
ALTER TABLE [dbo].[CurriculumVitaeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeEstudio_CurriculumVitae] FOREIGN KEY([CurriculumVitaeId])
REFERENCES [dbo].[CurriculumVitae] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeEstudio] CHECK CONSTRAINT [FK_CurriculumVitaeEstudio_CurriculumVitae]
GO
ALTER TABLE [dbo].[CurriculumVitaeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeEstudio_NivelEstudio] FOREIGN KEY([NivelEstudioId])
REFERENCES [dbo].[NivelEstudio] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeEstudio] CHECK CONSTRAINT [FK_CurriculumVitaeEstudio_NivelEstudio]
GO
ALTER TABLE [dbo].[CurriculumVitaeExperiencia]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeExperiencia_CurriculumVitae] FOREIGN KEY([CurriculumVitaeId])
REFERENCES [dbo].[CurriculumVitae] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeExperiencia] CHECK CONSTRAINT [FK_CurriculumVitaeExperiencia_CurriculumVitae]
GO
ALTER TABLE [dbo].[CurriculumVitaeIdioma]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeIdioma_CurriculumVitae] FOREIGN KEY([CurriculumVitaeId])
REFERENCES [dbo].[CurriculumVitae] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeIdioma] CHECK CONSTRAINT [FK_CurriculumVitaeIdioma_CurriculumVitae]
GO
ALTER TABLE [dbo].[CurriculumVitaeTecnologia]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeTecnologia_CurriculumVitae] FOREIGN KEY([CurriculumVitaeId])
REFERENCES [dbo].[CurriculumVitae] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeTecnologia] CHECK CONSTRAINT [FK_CurriculumVitaeTecnologia_CurriculumVitae]
GO
ALTER TABLE [dbo].[CurriculumVitaeTecnologia]  WITH CHECK ADD  CONSTRAINT [FK_CurriculumVitaeTecnologia_Tecnologia] FOREIGN KEY([TecnologiaId])
REFERENCES [dbo].[Tecnologia] ([Id])
GO
ALTER TABLE [dbo].[CurriculumVitaeTecnologia] CHECK CONSTRAINT [FK_CurriculumVitaeTecnologia_Tecnologia]
GO
ALTER TABLE [dbo].[DigitoVerificador]  WITH CHECK ADD  CONSTRAINT [FK_DigitoVerificador_TablaSistema] FOREIGN KEY([TablaSistemaId])
REFERENCES [dbo].[TablaSistema] ([Id])
GO
ALTER TABLE [dbo].[DigitoVerificador] CHECK CONSTRAINT [FK_DigitoVerificador_TablaSistema]
GO
ALTER TABLE [dbo].[EmpresaHistorico]  WITH CHECK ADD  CONSTRAINT [FK_EmpresaHistorico_Empresa] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
GO
ALTER TABLE [dbo].[EmpresaHistorico] CHECK CONSTRAINT [FK_EmpresaHistorico_Empresa]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_EvaluacionTipo] FOREIGN KEY([EvaluacionTipoId])
REFERENCES [dbo].[EvaluacionTipo] ([Id])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_EvaluacionTipo]
GO
ALTER TABLE [dbo].[IdiomaFrase]  WITH CHECK ADD  CONSTRAINT [FK_IdiomaFrase_Frase] FOREIGN KEY([Tag])
REFERENCES [dbo].[Frase] ([Tag])
GO
ALTER TABLE [dbo].[IdiomaFrase] CHECK CONSTRAINT [FK_IdiomaFrase_Frase]
GO
ALTER TABLE [dbo].[IdiomaFrase]  WITH CHECK ADD  CONSTRAINT [FK_IdiomaFrase_Idioma] FOREIGN KEY([IdiomaId])
REFERENCES [dbo].[Idioma] ([Id])
GO
ALTER TABLE [dbo].[IdiomaFrase] CHECK CONSTRAINT [FK_IdiomaFrase_Idioma]
GO
ALTER TABLE [dbo].[Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_TipoPermiso] FOREIGN KEY([TipoPermisoId])
REFERENCES [dbo].[TipoPermiso] ([Id])
GO
ALTER TABLE [dbo].[Permiso] CHECK CONSTRAINT [FK_Permiso_TipoPermiso]
GO
ALTER TABLE [dbo].[PermisoPermiso]  WITH CHECK ADD  CONSTRAINT [FK_PermisoPermiso_Permiso] FOREIGN KEY([PermisoId])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[PermisoPermiso] CHECK CONSTRAINT [FK_PermisoPermiso_Permiso]
GO
ALTER TABLE [dbo].[PermisoPermiso]  WITH CHECK ADD  CONSTRAINT [FK_PermisoPermiso_Permiso1] FOREIGN KEY([PermisoPadreId])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[PermisoPermiso] CHECK CONSTRAINT [FK_PermisoPermiso_Permiso1]
GO
ALTER TABLE [dbo].[Postulacion]  WITH CHECK ADD  CONSTRAINT [FK_Postulacion_AvisoLaboral] FOREIGN KEY([AvisoLaboralId])
REFERENCES [dbo].[AvisoLaboral] ([Id])
GO
ALTER TABLE [dbo].[Postulacion] CHECK CONSTRAINT [FK_Postulacion_AvisoLaboral]
GO
ALTER TABLE [dbo].[Postulacion]  WITH CHECK ADD  CONSTRAINT [FK_Postulacion_PostulacionEstado] FOREIGN KEY([PostulacionEstadoId])
REFERENCES [dbo].[PostulacionEstado] ([Id])
GO
ALTER TABLE [dbo].[Postulacion] CHECK CONSTRAINT [FK_Postulacion_PostulacionEstado]
GO
ALTER TABLE [dbo].[Postulacion]  WITH CHECK ADD  CONSTRAINT [FK_Postulacion_Profesional] FOREIGN KEY([ProfesionalId])
REFERENCES [dbo].[Profesional] ([Id])
GO
ALTER TABLE [dbo].[Postulacion] CHECK CONSTRAINT [FK_Postulacion_Profesional]
GO
ALTER TABLE [dbo].[PostulacionEvaluacion]  WITH CHECK ADD  CONSTRAINT [FK_PostulacionPrueba_Evaluacion] FOREIGN KEY([EvaluacionId])
REFERENCES [dbo].[Evaluacion] ([Id])
GO
ALTER TABLE [dbo].[PostulacionEvaluacion] CHECK CONSTRAINT [FK_PostulacionPrueba_Evaluacion]
GO
ALTER TABLE [dbo].[PostulacionEvaluacion]  WITH CHECK ADD  CONSTRAINT [FK_PostulacionPrueba_Postulacion] FOREIGN KEY([PostulacionId])
REFERENCES [dbo].[Postulacion] ([Id])
GO
ALTER TABLE [dbo].[PostulacionEvaluacion] CHECK CONSTRAINT [FK_PostulacionPrueba_Postulacion]
GO
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Empresa] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesional_Empresa]
GO
ALTER TABLE [dbo].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Profesional] CHECK CONSTRAINT [FK_Profesional_Usuario]
GO
ALTER TABLE [dbo].[Reclutador]  WITH CHECK ADD  CONSTRAINT [FK_Reclutador_Empresa] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
GO
ALTER TABLE [dbo].[Reclutador] CHECK CONSTRAINT [FK_Reclutador_Empresa]
GO
ALTER TABLE [dbo].[Reclutador]  WITH CHECK ADD  CONSTRAINT [FK_Reclutador_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Reclutador] CHECK CONSTRAINT [FK_Reclutador_Usuario]
GO
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Permiso] FOREIGN KEY([PermisoId])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Permiso]
GO
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Usuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Usuario]
GO
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Usuario1] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Usuario1]
GO
/****** Object:  StoredProcedure [dbo].[AgregarDDV]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarDDV](@TablaSistemaId AS INT,@FechaCreacion AS DATETIME, @DVV AS BIGINT)
AS
BEGIN
	INSERT INTO DigitoVerificador (TablaSistemaId,FechaCreacion,DVV) VALUES (@TablaSistemaId,@FechaCreacion,@DVV)
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarIdioma]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarIdioma](@Nombre AS VARCHAR(50))
AS
BEGIN
	INSERT INTO Idioma (Nombre) VALUES (@Nombre)
END

GO
/****** Object:  StoredProcedure [dbo].[AgregarPermisoToPerfil]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarPermisoToPerfil](@PermisoId AS INT,@PermisoPadreId AS INT)
AS
BEGIN
	INSERT INTO PermisoPermiso (PermisoId,PermisoPadreId) VALUES (@PermisoId,@PermisoPadreId)
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarProfesional]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarProfesional](@Nombre AS VARCHAR(50),@Apellido AS VARCHAR(50),@Email AS VARCHAR(50),@UsuarioId AS INT,@EmpresaId AS INT)
AS
BEGIN
	INSERT INTO Profesional
	(Nombre,Apellido,Email,UsuarioId,EmpresaId) VALUES
	(@Nombre,@Apellido,@Email,@UsuarioId,@EmpresaId)
END

GO
/****** Object:  StoredProcedure [dbo].[AgregarReclutador]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarReclutador](@Nombre AS VARCHAR(50),@Apellido AS VARCHAR(50),@Email AS VARCHAR(50),@UsuarioId AS INT,@EmpresaId AS INT)
AS
BEGIN
	INSERT INTO Reclutador
	(Nombre,Apellido,Email,UsuarioId,EmpresaId) VALUES
	(@Nombre,@Apellido,@Email,@UsuarioId,@EmpresaId)
END


GO
/****** Object:  StoredProcedure [dbo].[AgregarUsuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarUsuario](@UserName AS VARCHAR(50),@UserPassword AS VARCHAR(600))
AS
BEGIN
	INSERT INTO Usuario (UserName,UserPassword) VALUES (@UserName,@UserPassword)
	SELECT @@IDENTITY
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarUsuarioPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarUsuarioPermiso](@UsuarioId AS INT,@PermisoId AS INT)
AS
BEGIN
	INSERT INTO UsuarioPermiso (UsuarioId,PermisoId) VALUES (@UsuarioId,@PermisoId)
END

GO
/****** Object:  StoredProcedure [dbo].[CambiarEstadoPostulacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CambiarEstadoPostulacion](@Id AS INT,@PostulacionEstadoId AS INT)
AS
BEGIN
	UPDATE Postulacion SET PostulacionEstadoId=@PostulacionEstadoId WHERE Id=@Id
END


GO
/****** Object:  StoredProcedure [dbo].[CambiarResultadoEvaluacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CambiarResultadoEvaluacion](@Id AS INT,@Respuesta AS VARCHAR(MAX),@TiempoResolucionEvaluacion AS VARCHAR(50),@Aprobo AS INT)
AS
BEGIN
	UPDATE PostulacionEvaluacion SET Respuesta=@Respuesta,TiempoResolucionEvaluacion=@TiempoResolucionEvaluacion,Aprobo=@Aprobo WHERE Id=@Id
END

GO
/****** Object:  StoredProcedure [dbo].[CrearEmpresa]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CrearEmpresa](@RazonSocial AS VARCHAR(50),@Direccion AS VARCHAR(50),@Telefono AS VARCHAR(50),@Email AS VARCHAR(50),@CUIT AS VARCHAR(50),@FechaCreacion AS VARCHAR(50), @FechaActualizacion AS VARCHAR(50))
AS
BEGIN
	INSERT INTO Empresa (RazonSocial,Direccion,Telefono,Email,CUIT,FechaCreacion,FechaActualizacion) VALUES
						(@RazonSocial,@Direccion,@Telefono,@Email,@CUIT,@FechaCreacion,@FechaActualizacion)
	SELECT @@IDENTITY
END

GO
/****** Object:  StoredProcedure [dbo].[CrearEmpresaHistorico]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CrearEmpresaHistorico](@EmpresaId AS INT,@RazonSocial AS VARCHAR(50),@Direccion AS VARCHAR(50),@Telefono AS VARCHAR(50),@Email AS VARCHAR(50),@CUIT AS VARCHAR(50),@FechaCreacion AS VARCHAR(50), @FechaActualizacion AS VARCHAR(50), @FechaCreacionHistorico AS VARCHAR(50), @DVH AS BIGINT)
AS
BEGIN
	INSERT INTO EmpresaHistorico(EmpresaId,RazonSocial,Direccion,Telefono,Email,CUIT,FechaCreacion,FechaActualizacion,FechaCreacionHistorico,DVH) VALUES
						(@EmpresaId,@RazonSocial,@Direccion,@Telefono,@Email,@CUIT,@FechaCreacion,@FechaActualizacion,@FechaCreacionHistorico,@DVH)
END

GO
/****** Object:  StoredProcedure [dbo].[CrearPerfil]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CrearPerfil](@Nombre AS VARCHAR(50),@PermisoPadreId AS INT)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION

		INSERT INTO Permiso (Nombre,TipoPermisoId) VALUES (@Nombre,1)

		DECLARE @NewId AS INT = SCOPE_IDENTITY()

		INSERT INTO PermisoPermiso (PermisoId,PermisoPadreId) VALUES (@NewId,@PermisoPadreId)

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		RAISERROR('Error',16,1)
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[DeshabilitarUsuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeshabilitarUsuario](@UserName AS VARCHAR(50))
AS
BEGIN
	UPDATE Usuario SET Habilitado=0 WHERE UserName=@UserName
END

GO
/****** Object:  StoredProcedure [dbo].[EditarDDV]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarDDV](@TablaSistemaId AS INT,@FechaActualizacion AS DATETIME,@DVV AS BIGINT)
AS
BEGIN
	UPDATE DigitoVerificador
	SET FechaActualizacion=@FechaActualizacion,DVV=@DVV
	WHERE TablaSistemaId=@TablaSistemaId
END
GO
/****** Object:  StoredProcedure [dbo].[EditarDVHEmpresa]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarDVHEmpresa](@EmpresaId AS INT, @DVH AS BIGINT)
AS
BEGIN
	UPDATE Empresa SET DVH=@DVH WHERE Id=@EmpresaId
END
GO
/****** Object:  StoredProcedure [dbo].[EditarEmpresa]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarEmpresa](@Id AS INT,@RazonSocial AS VARCHAR(50),@Direccion AS VARCHAR(50),@Telefono AS VARCHAR(50),@Email AS VARCHAR(50),@CUIT AS VARCHAR(50),@FechaActualizacion AS VARCHAR(50),@DVH AS BIGINT)
AS
BEGIN
	UPDATE Empresa
	SET RazonSocial=@RazonSocial,Direccion=@Direccion,Telefono=@Telefono,Email=@Email,CUIT=@CUIT,FechaActualizacion=@FechaActualizacion,DVH=@DVH
	WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[EditarIdioma]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarIdioma](@Id AS INT,@Nombre AS VARCHAR(50))
AS
BEGIN
	UPDATE Idioma SET Nombre=@Nombre WHERE Id=@Id
END


GO
/****** Object:  StoredProcedure [dbo].[EditarPerfil]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarPerfil](@Id AS INT,@Nombre AS VARCHAR(50))
AS
BEGIN
	UPDATE Permiso SET Nombre=@Nombre WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditarUsuario](@Id AS INT,@UserName AS VARCHAR(50),@UserPassword AS VARCHAR(600))
AS
BEGIN
	UPDATE Usuario
	SET UserName=@UserName,UserPassword=@UserPassword
	WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpresa]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarEmpresa](@Id AS INT)
AS
BEGIN
	DELETE FROM Empresa WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarIdioma]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarIdioma](@Id AS INT)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN tx
			DELETE FROM IdiomaFrase WHERE IdiomaId=@Id
			DELETE FROM Idioma WHERE Id=@Id
		COMMIT TRAN tx
	END TRY
	BEGIN CATCH
		DECLARE @error AS INT, @message VARCHAR(4000)
        SELECT @error = ERROR_NUMBER(),@message = ERROR_MESSAGE()
		ROLLBACK TRAN tx
		RAISERROR('EliminarIdioma: %d: %s', 16, 1, @error, @message)
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarIdiomaTraducciones]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarIdiomaTraducciones](@IdiomaId AS INT)
AS
BEGIN
	DELETE FROM IdiomaFrase	WHERE IdiomaId=@IdiomaId
END


GO
/****** Object:  StoredProcedure [dbo].[EliminarPerfil]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarPerfil](@Id AS INT)
AS
BEGIN
	DELETE FROM PermisoPermiso WHERE PermisoId=@Id
	DELETE FROM Permiso WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuario](@Id AS INT)
AS
BEGIN
	UPDATE Usuario SET Habilitado=0 WHERE Id=@Id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuarioPerfilesPermisos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuarioPerfilesPermisos](@UsuarioId AS INT)
AS
BEGIN
	DELETE FROM UsuarioPermiso WHERE UsuarioId=@UsuarioId
END

GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuarioPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarUsuarioPermiso](@UsuarioId AS INT,@PermisoId AS INT)
AS
BEGIN
	DELETE FROM UsuarioPermiso WHERE UsuarioId=@UsuarioId AND PermisoId=@PermisoId
END







GO
/****** Object:  StoredProcedure [dbo].[ExisteDVV]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExisteDVV](@TablaSistemaId AS INT)
AS
BEGIN
	SELECT COUNT(*) AS CANTIDAD FROM DigitoVerificador WHERE TablaSistemaId=@TablaSistemaId
END
GO
/****** Object:  StoredProcedure [dbo].[ExistePostulacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExistePostulacion](@AvisoLaboralId AS INT)
AS
BEGIN
	SELECT COUNT(AvisoLaboralId) FROM Postulacion WHERE AvisoLaboralId=@AvisoLaboralId
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmpresas]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllEmpresas]
AS
BEGIN
	SELECT Id,RazonSocial,Direccion,Telefono,Email,CUIT,FechaCreacion,FechaActualizacion,DVH
	FROM Empresa
	ORDER BY RazonSocial
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllFrases]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllFrases]
AS
BEGIN
	SELECT Tag FROM Frase ORDER BY Tag
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllIdiomas]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllIdiomas]
AS
BEGIN
	SELECT Id,Nombre FROM Idioma ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllPerfiles]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPerfiles]
AS
BEGIN
	SELECT Id,Nombre FROM Permiso WHERE TipoPermisoId=1 AND Id<>1 ORDER BY Nombre
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllPerfilesPermisos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPerfilesPermisos]
AS
BEGIN
	SELECT p.Id,p.Nombre,p.TipoPermisoId,pp.PermisoId,pp.PermisoPadreId
	FROM Permiso p INNER JOIN PermisoPermiso pp ON pp.PermisoId=p.Id
	ORDER BY pp.PermisoPadreId,p.Nombre
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllPermisos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPermisos]
AS
BEGIN
	SELECT Id,Nombre FROM Permiso WHERE TipoPermisoId=2 ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTecnologias]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllTecnologias]
AS
BEGIN
	SELECT Id,Nombre FROM Tecnologia ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTiposPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllTiposPermiso]
AS
BEGIN
	SELECT Id,Nombre FROM TipoPermiso ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTraducciones]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllTraducciones](@IdiomaId AS INT)
AS
BEGIN
	SELECT IdiomaId,Tag,Traduccion FROM IdiomaFrase WHERE IdiomaId=@IdiomaId
END


GO
/****** Object:  StoredProcedure [dbo].[GetAllUsuarioTipos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllUsuarioTipos]
AS
BEGIN
	SELECT Id,Nombre FROM TipoUsuario ORDER BY Nombre
END

GO
/****** Object:  StoredProcedure [dbo].[GetBitacoraEventos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [dbo].[GetBitacoraEventos](@UsuarioId AS INT = NULL,@TipoEventoId AS INT = NULL,@FechaDesde AS VARCHAR(50)=NULL,@FechaHasta AS VARCHAR(50)=NULL)
 AS
 BEGIN
	SELECT b.Id,b.FechaCreacion,b.UsuarioId,b.TipoEventoId,b.Descripcion,u.UserName,t.Nombre AS TipoEvento
	FROM Bitacora AS b INNER JOIN Usuario AS u ON u.Id=b.UsuarioId
	INNER JOIN TipoEvento AS t ON t.Id=b.TipoEventoId
	WHERE (b.UsuarioId = @UsuarioId OR @UsuarioId IS NULL)
	AND (b.TipoEventoId = @TipoEventoId OR @TipoEventoId IS NULL)
	AND (b.FechaCreacion >= CONVERT(DATETIME, @FechaDesde, 111) OR @FechaDesde IS NULL)
	AND (b.FechaCreacion <= CONVERT(DATETIME, @FechaHasta, 111) OR @FechaHasta IS NULL)
	ORDER BY FechaCreacion DESC
 END
GO
/****** Object:  StoredProcedure [dbo].[GetBitacoraTipoEventos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBitacoraTipoEventos]
AS
BEGIN
	SELECT Id,Nombre FROM TipoEvento ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[GetDVV]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDVV](@TablaSistemaId AS INT)
AS
BEGIN
	SELECT Id,TablaSistemaId,FechaCreacion,FechaActualizacion,DVV FROM DigitoVerificador WHERE TablaSistemaId=@TablaSistemaId
END
GO
/****** Object:  StoredProcedure [dbo].[GetEmpresa]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEmpresa](@EmpresaId AS INT)
AS
BEGIN
	SELECT Id,RazonSocial,Direccion,Telefono,Email,CUIT,FechaCreacion,FechaActualizacion,DVH
	FROM Empresa
	WHERE Id=@EmpresaId
END
GO
/****** Object:  StoredProcedure [dbo].[GetPostulaciones]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPostulaciones](@ProfesionalId AS INT)
AS
BEGIN
	SELECT p.Id,p.FechaCreacion,p.AvisoLaboralId,a.Descripcion,a.LugarTrabajo,a.FechaVencimiento,a.FechaVigencia,p.PostulacionEstadoId,e.Nombre
	FROM Postulacion p
	INNER JOIN AvisoLaboral a ON a.Id=p.AvisoLaboralId
	INNER JOIN PostulacionEstado e ON e.Id=p.PostulacionEstadoId
	ORDER BY p.FechaCreacion DESC
END

GO
/****** Object:  StoredProcedure [dbo].[GetPostulacionEvaluacion]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPostulacionEvaluacion](@PostulacionId AS INT)
AS
BEGIN
	SELECT p.Id,p.FechaCreacion,p.Aprobo,p.EvaluacionId,e.Descripcion,e.Ejercicio,e.Tiempo,e.CodigoFuenteTest
	FROM PostulacionEvaluacion p
	INNER JOIN Evaluacion e ON e.Id=p.EvaluacionId
	WHERE p.PostulacionId=@PostulacionId
END

GO
/****** Object:  StoredProcedure [dbo].[GetProfesional]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetProfesional](@UsuarioId AS INT)
AS
BEGIN
	SELECT p.Id,p.Nombre,p.Apellido,p.Email,p.UsuarioId,p.EmpresaId,e.RazonSocial
	FROM Profesional p INNER JOIN Empresa e ON e.Id=p.EmpresaId
	WHERE p.UsuarioId=@UsuarioId
END
GO
/****** Object:  StoredProcedure [dbo].[GetReclutador]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetReclutador](@UsuarioId AS INT)
AS
BEGIN
	SELECT r.Id,r.Nombre,r.Apellido,r.Email,r.UsuarioId,r.EmpresaId,e.RazonSocial
	FROM Reclutador r INNER JOIN Empresa e ON e.Id=r.EmpresaId
	WHERE UsuarioId=@UsuarioId
END

GO
/****** Object:  StoredProcedure [dbo].[GetUsuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUsuario](@UserName AS VARCHAR(50))
AS
BEGIN
	SELECT u.Id,u.UserName,u.UserPassword
	FROM Usuario u
	WHERE u.Habilitado=1 AND u.UserName=@UserName
END

GO
/****** Object:  StoredProcedure [dbo].[GetUsuarioPerfilesPermisos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUsuarioPerfilesPermisos](@UsuarioId AS INT)
AS
BEGIN
	SELECT p.Id,p.Nombre
	FROM Permiso p INNER JOIN UsuarioPermiso up ON up.PermisoId=p.Id
	WHERE up.UsuarioId=@UsuarioId
END

GO
/****** Object:  StoredProcedure [dbo].[GetUsuarios]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUsuarios]
AS
BEGIN
	SELECT u.Id,u.UserName,u.UserPassword
	FROM Usuario u
	WHERE u.Habilitado=1
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarIdiomaTraducciones]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarIdiomaTraducciones](@IdiomaId AS INT,@Tag AS VARCHAR(500),@Traduccion AS VARCHAR(MAX))
AS
BEGIN
	INSERT INTO IdiomaFrase	(IdiomaId,Tag,Traduccion) VALUES (@IdiomaId,@Tag,@Traduccion)
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarUsuarioPerfilesPermisos]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GuardarUsuarioPerfilesPermisos](@UsuarioId AS INT,@PermisoId AS INT)
AS
BEGIN
	INSERT INTO UsuarioPermiso (UsuarioId,PermisoId) VALUES (@UsuarioId,@PermisoId)
END

GO
/****** Object:  StoredProcedure [dbo].[LoginUsuario]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginUsuario](@UserName AS VARCHAR(50))
AS
BEGIN
	SELECT COUNT(*) AS Cantidad FROM Usuario WHERE Habilitado=1 AND UserName=@UserName
END

GO
/****** Object:  StoredProcedure [dbo].[Postularse]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Postularse](@FechaCreacion AS VARCHAR(50),@ProfesionalId AS INT,@AvisoLaboralId AS INT,@PostulacionEstadoId AS INT)
AS
BEGIN
	INSERT INTO Postulacion (FechaCreacion,ProfesionalId,AvisoLaboralId,PostulacionEstadoId)
	VALUES (@FechaCreacion,@ProfesionalId,@AvisoLaboralId,@PostulacionEstadoId)
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarPermisoPermiso]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[QuitarPermisoPermiso](@PermisoId AS INT,@PermisoPadreId AS INT)
AS
BEGIN
	DELETE FROM PermisoPermiso WHERE PermisoId=@PermisoId AND PermisoPadreId=@PermisoPadreId
END

GO
/****** Object:  StoredProcedure [dbo].[RealizarBackup]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RealizarBackup](@PathBackupFile AS VARCHAR(200))
AS
BEGIN
	BACKUP DATABASE TalentFinder TO DISK = @PathBackupFile
	SELECT 1
END

GO
/****** Object:  StoredProcedure [dbo].[RegistrarEntrada]    Script Date: 11/19/2019 8:09:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarEntrada](@FechaCreacion AS DATETIME,@UsuarioId AS INT,@TipoEventoId AS INT,@Descripcion AS VARCHAR(500))
AS
BEGIN
	INSERT INTO Bitacora (FechaCreacion,UsuarioId,TipoEventoId,Descripcion) VALUES (@FechaCreacion,@UsuarioId,@TipoEventoId,@Descripcion)
END
GO
USE [master]
GO
ALTER DATABASE [TalentFinder] SET  READ_WRITE 
GO
