USE [master]
GO
/****** Object:  Database [MiBilleteraVirtual]    Script Date: 11/12/2022 10:46:35 ******/
CREATE DATABASE [MiBilleteraVirtual]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MiBilleteraVirtual', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MiBilleteraVirtual.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MiBilleteraVirtual_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MiBilleteraVirtual_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MiBilleteraVirtual] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiBilleteraVirtual].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiBilleteraVirtual] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiBilleteraVirtual] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiBilleteraVirtual] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MiBilleteraVirtual] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiBilleteraVirtual] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MiBilleteraVirtual] SET  MULTI_USER 
GO
ALTER DATABASE [MiBilleteraVirtual] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiBilleteraVirtual] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiBilleteraVirtual] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiBilleteraVirtual] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MiBilleteraVirtual] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MiBilleteraVirtual]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 11/12/2022 10:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[idCuenta] [int] NOT NULL,
	[Saldo] [float] NULL,
	[CVU] [bigint] NULL,
	[Habilitado] [bit] NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [PK__Cuenta__BBC6DF320DA72A4F] PRIMARY KEY CLUSTERED 
(
	[idCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 11/12/2022 10:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[idLocalidad] [int] NOT NULL,
	[NombreLocalidad] [varchar](max) NULL,
	[Domicilio] [varchar](max) NULL,
	[idProvincia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 11/12/2022 10:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moneda](
	[idMoneda] [int] NOT NULL,
	[Monto] [float] NULL,
	[Nombre] [varchar](max) NULL,
	[idUsuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idMoneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operacion]    Script Date: 11/12/2022 10:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operacion](
	[idOperacion] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Monto] [float] NULL,
	[Deposito] [bit] NULL,
	[Extraccion] [bit] NULL,
	[idCuenta] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 11/12/2022 10:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[idprovincia] [int] NOT NULL,
	[NombreProvincia] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[idprovincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/12/2022 10:46:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Apellido] [varchar](max) NULL,
	[cuil] [bigint] NULL,
	[NombreUsuario] [varchar](max) NULL,
	[Email] [varchar](max) NULL,
	[Contraseña] [varchar](8) NULL,
	[idLocalidad] [int] NULL,
 CONSTRAINT [PK__Usuario__645723A66B22906A] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Cuenta] ([idCuenta], [Saldo], [CVU], [Habilitado], [idUsuario]) VALUES (1, 20000, 34343434343434, NULL, 1)
INSERT [dbo].[Cuenta] ([idCuenta], [Saldo], [CVU], [Habilitado], [idUsuario]) VALUES (6, 8000, 40850, 1, 1)
INSERT [dbo].[Cuenta] ([idCuenta], [Saldo], [CVU], [Habilitado], [idUsuario]) VALUES (10, 6000, 9898975, 1, 1)
GO
INSERT [dbo].[Localidad] ([idLocalidad], [NombreLocalidad], [Domicilio], [idProvincia]) VALUES (1, N'Misiones', N'jlb', 2)
INSERT [dbo].[Localidad] ([idLocalidad], [NombreLocalidad], [Domicilio], [idProvincia]) VALUES (3, N'Alta Gracia', N'Beethoven', 3)
INSERT [dbo].[Localidad] ([idLocalidad], [NombreLocalidad], [Domicilio], [idProvincia]) VALUES (4, N'Oasis', N'benson', 3)
GO
INSERT [dbo].[Moneda] ([idMoneda], [Monto], [Nombre], [idUsuario]) VALUES (1, 200000, N'Pesos', 1)
GO
INSERT [dbo].[Operacion] ([idOperacion], [Fecha], [Monto], [Deposito], [Extraccion], [idCuenta]) VALUES (1, CAST(N'2022-09-22' AS Date), 200000, NULL, NULL, 1)
GO
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (2, N'Misiones')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (3, N'Chaco')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (4, N'Buenos Aires')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (5, N'Catamarca')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (6, N'Entre Rios')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (8, NULL)
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (9, NULL)
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (10, N'Chubut')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (11, N'Formosa')
INSERT [dbo].[Provincia] ([idprovincia], [NombreProvincia]) VALUES (13, N'Usuahia')
GO
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Apellido], [cuil], [NombreUsuario], [Email], [Contraseña], [idLocalidad]) VALUES (1, N'Ramon', N'Perez', 2039445504, N'RamonP', N'ramon@gmail', N'12456', 1)
INSERT [dbo].[Usuario] ([idUsuario], [Nombre], [Apellido], [cuil], [NombreUsuario], [Email], [Contraseña], [idLocalidad]) VALUES (2, N'Yami', N'Esth', 200000000, N'YamilaE', N'yami22est@hotmail.com', N'412305', 1)
GO
ALTER TABLE [dbo].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK__Cuenta__idUsuari__1DE57479] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Cuenta] CHECK CONSTRAINT [FK__Cuenta__idUsuari__1DE57479]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD FOREIGN KEY([idProvincia])
REFERENCES [dbo].[Provincia] ([idprovincia])
GO
ALTER TABLE [dbo].[Moneda]  WITH CHECK ADD  CONSTRAINT [FK__Moneda__idUsuari__1ED998B2] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Moneda] CHECK CONSTRAINT [FK__Moneda__idUsuari__1ED998B2]
GO
ALTER TABLE [dbo].[Operacion]  WITH CHECK ADD  CONSTRAINT [FK__Operacion__idCue__1CF15040] FOREIGN KEY([idCuenta])
REFERENCES [dbo].[Cuenta] ([idCuenta])
GO
ALTER TABLE [dbo].[Operacion] CHECK CONSTRAINT [FK__Operacion__idCue__1CF15040]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK__Usuario__idLocal__1BFD2C07] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK__Usuario__idLocal__1BFD2C07]
GO
USE [master]
GO
ALTER DATABASE [MiBilleteraVirtual] SET  READ_WRITE 
GO
