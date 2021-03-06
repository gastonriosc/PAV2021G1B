USE [master]
GO
/****** Object:  Database [gridFreaks2]    Script Date: 6/11/2021 19:19:52 ******/
CREATE DATABASE [gridFreaks2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gridFreaks2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gridFreaks2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gridFreaks2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gridFreaks2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gridFreaks2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gridFreaks2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gridFreaks2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gridFreaks2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gridFreaks2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gridFreaks2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gridFreaks2] SET ARITHABORT OFF 
GO
ALTER DATABASE [gridFreaks2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gridFreaks2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gridFreaks2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gridFreaks2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gridFreaks2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gridFreaks2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gridFreaks2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gridFreaks2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gridFreaks2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gridFreaks2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gridFreaks2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gridFreaks2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gridFreaks2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gridFreaks2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gridFreaks2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gridFreaks2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gridFreaks2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gridFreaks2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gridFreaks2] SET  MULTI_USER 
GO
ALTER DATABASE [gridFreaks2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gridFreaks2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gridFreaks2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gridFreaks2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gridFreaks2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gridFreaks2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [gridFreaks2] SET QUERY_STORE = OFF
GO
USE [gridFreaks2]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CUIT] [varchar](13) NULL,
	[nombre] [varchar](50) NOT NULL,
	[domicilioCalle] [varchar](50) NOT NULL,
	[domicilioNro] [int] NOT NULL,
	[mail] [varchar](50) NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colores](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Colores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[idDetalle] [int] IDENTITY(1,1) NOT NULL,
	[nroFactura] [int] NOT NULL,
	[idPrenda] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [int] NOT NULL,
	[borrado] [int] NOT NULL,
	[anulado] [int] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[idDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[nroFactura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[idCliente] [int] NOT NULL,
	[tipoFactura] [char](1) NOT NULL,
	[total] [int] NOT NULL,
	[descuento] [decimal](18, 2) NULL,
	[borrado] [int] NOT NULL,
	[anulado] [int] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[nroFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prendas]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prendas](
	[id] [int] NOT NULL,
	[idTipoPrenda] [int] NULL,
	[idColor] [int] NULL,
	[Temporada] [varchar](50) NULL,
	[Stock] [int] NULL,
	[Precio] [float] NULL,
	[idMarca] [int] NULL,
	[borrado] [int] NULL,
	[nombreImagen] [varchar](50) NULL,
 CONSTRAINT [PK_Prendas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoFactura]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoFactura](
	[id] [char](1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[borrado] [int] NOT NULL,
 CONSTRAINT [PK_TipoFactura] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPrenda](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TipoPrenda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6/11/2021 19:19:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[usuario] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[contra] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([id], [CUIT], [nombre], [domicilioCalle], [domicilioNro], [mail], [borrado]) VALUES (8, N'21123456789', N'Julian Robles', N'Catamarca', 111, N'julian@gmail.com', 0)
INSERT [dbo].[Clientes] ([id], [CUIT], [nombre], [domicilioCalle], [domicilioNro], [mail], [borrado]) VALUES (9, N'22123456789', N'Maria Ruiz', N'Apacay', 222, N'maria@gmail.com', 0)
INSERT [dbo].[Clientes] ([id], [CUIT], [nombre], [domicilioCalle], [domicilioNro], [mail], [borrado]) VALUES (10, N'23123456789', N'Federico Nissi', N'Terrachini', 333, N'fede@gmail.com', 0)
INSERT [dbo].[Clientes] ([id], [CUIT], [nombre], [domicilioCalle], [domicilioNro], [mail], [borrado]) VALUES (11, N'24123456789', N'Mateo Pañart', N'Nuñez', 5600, N'matu@gmail.com', 0)
INSERT [dbo].[Clientes] ([id], [CUIT], [nombre], [domicilioCalle], [domicilioNro], [mail], [borrado]) VALUES (12, N'25123456789', N'Juan Gimenez', N'Terrace', 2441, N'juan@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (1, N'Negro', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (2, N'Blanco', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (3, N'Rojo', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (4, N'Gris', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (5, N'Verde', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (6, N'Marron', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (7, N'Amarillo', 0)
INSERT [dbo].[Colores] ([id], [nombre], [borrado]) VALUES (8, N'Naranja', 0)
GO
SET IDENTITY_INSERT [dbo].[DetalleFactura] ON 

INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (1, 1, 1, 1, 7000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (2, 1, 7, 1, 2000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (3, 2, 2, 1, 7000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (4, 2, 5, 1, 1800, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (5, 3, 1, 1, 7000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (6, 3, 8, 1, 1500, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (7, 3, 3, 1, 3500, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (8, 4, 1, 1, 7000, 0, 1)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (9, 4, 7, 1, 2000, 0, 1)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (10, 5, 2, 1, 7000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (11, 5, 8, 2, 3000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (12, 6, 2, 1, 7000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (13, 6, 8, 2, 3000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (14, 7, 10, 2, 4000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (15, 7, 5, 1, 1800, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (16, 8, 2, 2, 14000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (17, 8, 10, 1, 2000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (18, 8, 10, 1, 2000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (19, 9, 8, 2, 3000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (20, 10, 7, 2, 4000, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (21, 10, 9, 1, 1400, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (24, 11, 4, 1, 3200, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (25, 11, 6, 2, 3600, 0, 0)
INSERT [dbo].[DetalleFactura] ([idDetalle], [nroFactura], [idPrenda], [cantidad], [subtotal], [borrado], [anulado]) VALUES (26, 12, 2, 1, 7000, 0, 1)
SET IDENTITY_INSERT [dbo].[DetalleFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (1, CAST(N'2021-09-09' AS Date), 8, N'A', 9000, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (2, CAST(N'2021-08-08' AS Date), 9, N'A', 8800, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (3, CAST(N'2021-08-20' AS Date), 10, N'C', 12000, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (4, CAST(N'2021-10-10' AS Date), 10, N'A', 9000, CAST(0.00 AS Decimal(18, 2)), 0, 1)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (5, CAST(N'2021-10-10' AS Date), 8, N'B', 10000, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (6, CAST(N'2021-10-10' AS Date), 10, N'A', 5000, CAST(50.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (7, CAST(N'2021-10-13' AS Date), 9, N'B', 5800, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (8, CAST(N'2021-10-13' AS Date), 11, N'A', 16200, CAST(10.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (9, CAST(N'2021-10-26' AS Date), 11, N'C', 3000, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (10, CAST(N'2021-11-03' AS Date), 11, N'C', 5400, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (11, CAST(N'2021-11-06' AS Date), 12, N'A', 6800, CAST(0.00 AS Decimal(18, 2)), 0, 0)
INSERT [dbo].[Facturas] ([nroFactura], [fecha], [idCliente], [tipoFactura], [total], [descuento], [borrado], [anulado]) VALUES (12, CAST(N'2021-11-06' AS Date), 12, N'B', 7000, CAST(0.00 AS Decimal(18, 2)), 0, 1)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
INSERT [dbo].[Marcas] ([id], [nombre], [borrado]) VALUES (1, N'Undefined', 0)
INSERT [dbo].[Marcas] ([id], [nombre], [borrado]) VALUES (2, N'RipNDip', 0)
INSERT [dbo].[Marcas] ([id], [nombre], [borrado]) VALUES (3, N'Vans', 0)
INSERT [dbo].[Marcas] ([id], [nombre], [borrado]) VALUES (4, N'Nike', 0)
INSERT [dbo].[Marcas] ([id], [nombre], [borrado]) VALUES (5, N'Adidas', 0)
GO
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (1, 1, 1, N'Invierno', 19, 7000, 1, 0, N'BuzoNegroBH.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (2, 1, 2, N'Invierno', 8, 7000, 2, 0, N'BuzoBlancoRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (3, 3, 2, N'Verano', 15, 3500, 3, 0, N'PantalonBlancoVans.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (4, 3, 6, N'Verano', 6, 3200, 3, 0, N'PantalonMarronVans.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (5, 2, 4, N'Invierno', 21, 1800, 2, 0, N'RemeraGrisRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (6, 4, 1, N'Verano', 12, 1800, 2, 0, N'GorroNegroRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (7, 3, 3, N'Verano', 11, 2000, 4, 0, N'PantalonRojoNike.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (8, 4, 5, N'Invierno', 10, 1500, 4, 0, N'GorroVerdeNike.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (9, 4, 2, N'Invierno', 4, 1400, 2, 0, N'GorroBlancoRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (10, 4, 8, N'Invierno', 5, 2000, 5, 0, N'GorroNaranjaAdidas.png')
GO
INSERT [dbo].[TipoFactura] ([id], [descripcion], [borrado]) VALUES (N'A', N'Factura de tipo A', 0)
INSERT [dbo].[TipoFactura] ([id], [descripcion], [borrado]) VALUES (N'B', N'Factura de tipo B', 0)
INSERT [dbo].[TipoFactura] ([id], [descripcion], [borrado]) VALUES (N'C', N'Factura de tipo C', 0)
GO
INSERT [dbo].[TipoPrenda] ([id], [nombre]) VALUES (1, N'Buzo')
INSERT [dbo].[TipoPrenda] ([id], [nombre]) VALUES (2, N'Remera')
INSERT [dbo].[TipoPrenda] ([id], [nombre]) VALUES (3, N'Pantalon')
INSERT [dbo].[TipoPrenda] ([id], [nombre]) VALUES (4, N'Gorro')
GO
INSERT [dbo].[Usuarios] ([usuario], [nombre], [apellido], [contra], [mail], [borrado]) VALUES (N'gastonriosc', N'Gaston', N'Rios Cardona', N'123', N'gaston@gmail.com', 0)
INSERT [dbo].[Usuarios] ([usuario], [nombre], [apellido], [contra], [mail], [borrado]) VALUES (N'juantargon', N'Juan', N'Targon', N'123', N'juan@gmail.com', 0)
INSERT [dbo].[Usuarios] ([usuario], [nombre], [apellido], [contra], [mail], [borrado]) VALUES (N'sergiocon', N'Sergio', N'Contini', N'123', N'sergio@gmail.com', 0)
INSERT [dbo].[Usuarios] ([usuario], [nombre], [apellido], [contra], [mail], [borrado]) VALUES (N'tomasripsky', N'Tomas', N'Ripsky', N'123', N'tomas@gmail.com', 0)
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Facturas] FOREIGN KEY([nroFactura])
REFERENCES [dbo].[Facturas] ([nroFactura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Facturas]
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Prendas] FOREIGN KEY([idPrenda])
REFERENCES [dbo].[Prendas] ([id])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Prendas]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_TipoFactura] FOREIGN KEY([tipoFactura])
REFERENCES [dbo].[TipoFactura] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_TipoFactura]
GO
ALTER TABLE [dbo].[Prendas]  WITH CHECK ADD  CONSTRAINT [FK_Prendas_Colores] FOREIGN KEY([idColor])
REFERENCES [dbo].[Colores] ([id])
GO
ALTER TABLE [dbo].[Prendas] CHECK CONSTRAINT [FK_Prendas_Colores]
GO
ALTER TABLE [dbo].[Prendas]  WITH CHECK ADD  CONSTRAINT [FK_Prendas_Marcas] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marcas] ([id])
GO
ALTER TABLE [dbo].[Prendas] CHECK CONSTRAINT [FK_Prendas_Marcas]
GO
ALTER TABLE [dbo].[Prendas]  WITH CHECK ADD  CONSTRAINT [FK_Prendas_TipoPrenda] FOREIGN KEY([idTipoPrenda])
REFERENCES [dbo].[TipoPrenda] ([id])
GO
ALTER TABLE [dbo].[Prendas] CHECK CONSTRAINT [FK_Prendas_TipoPrenda]
GO
USE [master]
GO
ALTER DATABASE [gridFreaks2] SET  READ_WRITE 
GO
