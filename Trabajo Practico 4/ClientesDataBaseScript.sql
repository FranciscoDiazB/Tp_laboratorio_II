USE [master]
GO
/****** Object:  Database [ClientesDataBase]    Script Date: 19/06/2022 17:09:09 ******/
CREATE DATABASE [ClientesDataBase]
 CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'ClientesDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ClientesDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'ClientesDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ClientesDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT
--GO
ALTER DATABASE [ClientesDataBase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClientesDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClientesDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClientesDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClientesDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClientesDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClientesDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClientesDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClientesDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClientesDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClientesDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClientesDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClientesDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClientesDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClientesDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClientesDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClientesDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClientesDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClientesDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClientesDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClientesDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClientesDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClientesDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClientesDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClientesDataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [ClientesDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [ClientesDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClientesDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClientesDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClientesDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClientesDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClientesDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ClientesDataBase', N'ON'
GO
ALTER DATABASE [ClientesDataBase] SET QUERY_STORE = OFF
GO
USE [ClientesDataBase]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/06/2022 17:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[metodoPago] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (19367094, N'Claudio David', N'Gonzalez', N'Tarjeta de Credito')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (29832100, N'Juana', N'Escudero', N'Transferencia')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (42786985, N'Mariano', N'Perez', N'Efectivo')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (35779015, N'Luciano', N'Mendez', N'Efectivo')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (22367890, N'Bruno', N'Barbacovi Gonzalez', N'Tarjeta de Debito')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (39854233, N'Juan Pablo', N'Mendoza', N'Efectivo')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (40980755, N'Jose', N'Rodriguez', N'Transferencia')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (36798021, N'Lorenzo', N'Valderrama', N'Tarjeta de Credito')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (27079765, N'Jazmin', N'Morales', N'Transferencia')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (34876900, N'Alejandro', N'Dominguez', N'Efectivo')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (40020123, N'Laura', N'Garza', N'Tarjeta de Debito')
INSERT [dbo].[Clientes] ([dni], [nombre], [apellido], [metodoPago]) VALUES (18908008, N'Esteban', N'Terron', N'Tarjeta de Debito')
GO
USE [master]
GO
ALTER DATABASE [ClientesDataBase] SET  READ_WRITE 
GO
