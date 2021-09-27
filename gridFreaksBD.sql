USE [master]
GO
/****** Object:  Database [gridFreaks]    Script Date: 27/09/2021 11:21:58 a. m. ******/
CREATE DATABASE [gridFreaks]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gridFreaks', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gridFreaks.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gridFreaks_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gridFreaks_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [gridFreaks] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gridFreaks].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gridFreaks] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gridFreaks] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gridFreaks] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gridFreaks] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gridFreaks] SET ARITHABORT OFF 
GO
ALTER DATABASE [gridFreaks] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gridFreaks] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gridFreaks] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gridFreaks] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gridFreaks] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gridFreaks] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gridFreaks] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gridFreaks] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gridFreaks] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gridFreaks] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gridFreaks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gridFreaks] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gridFreaks] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gridFreaks] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gridFreaks] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gridFreaks] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gridFreaks] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gridFreaks] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [gridFreaks] SET  MULTI_USER 
GO
ALTER DATABASE [gridFreaks] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gridFreaks] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gridFreaks] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gridFreaks] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [gridFreaks] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [gridFreaks] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [gridFreaks] SET QUERY_STORE = OFF
GO
USE [gridFreaks]
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 27/09/2021 11:21:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colores](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Colores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalleVentas]    Script Date: 27/09/2021 11:21:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleVentas](
	[nroTicket] [int] NOT NULL,
	[idPrenda] [int] NOT NULL,
	[cantidad] [int] NULL,
	[subtotal] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 27/09/2021 11:21:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prendas]    Script Date: 27/09/2021 11:21:59 a. m. ******/
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
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 27/09/2021 11:21:59 a. m. ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/09/2021 11:21:59 a. m. ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 27/09/2021 11:21:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[nroTicket] [int] NOT NULL,
	[idUsuario] [varchar](50) NULL,
	[fecha] [datetime] NULL,
	[total] [float] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[nroTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Colores] ([id], [nombre]) VALUES (1, N'Negro')
INSERT [dbo].[Colores] ([id], [nombre]) VALUES (2, N'Blanco')
INSERT [dbo].[Colores] ([id], [nombre]) VALUES (3, N'Rojo')
INSERT [dbo].[Colores] ([id], [nombre]) VALUES (4, N'Gris')
INSERT [dbo].[Colores] ([id], [nombre]) VALUES (5, N'Verde')
INSERT [dbo].[Colores] ([id], [nombre]) VALUES (6, N'Marron')
GO
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (1, 1, 1, 7000)
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (1, 7, 1, 2000)
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (2, 2, 1, 7000)
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (2, 5, 1, 1800)
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (3, 1, 1, 7000)
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (3, 8, 1, 1500)
INSERT [dbo].[detalleVentas] ([nroTicket], [idPrenda], [cantidad], [subtotal]) VALUES (3, 3, 1, 3500)
GO
INSERT [dbo].[Marcas] ([id], [nombre]) VALUES (1, N'Undefined')
INSERT [dbo].[Marcas] ([id], [nombre]) VALUES (2, N'RipNDip')
INSERT [dbo].[Marcas] ([id], [nombre]) VALUES (3, N'Vans')
INSERT [dbo].[Marcas] ([id], [nombre]) VALUES (4, N'Nike')
GO
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (1, 1, 1, N'Invierno', 11, 7000, 1, 0, N'BuzoNegroBH.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (2, 1, 2, N'Invierno', 7, 7000, 2, 0, N'BuzoBlancoRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (3, 3, 2, N'Verano', 15, 3500, 3, 0, N'PantalonBlancoVans.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (4, 3, 6, N'Verano', 8, 3200, 3, 0, N'PantalonMarronVans.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (5, 2, 4, N'Invierno', 21, 1800, 2, 0, N'RemeraGrisRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (6, 4, 1, N'Verano', 16, 1800, 2, 0, N'GorroNegroRipNdip.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (7, 3, 3, N'Verano', 12, 2000, 4, 0, N'PantalonRojoNike.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (8, 4, 5, N'Invierno', 10, 1500, 4, 0, N'GorroVerdeNike.png')
INSERT [dbo].[Prendas] ([id], [idTipoPrenda], [idColor], [Temporada], [Stock], [Precio], [idMarca], [borrado], [nombreImagen]) VALUES (9, 4, 2, N'Invierno', 5, 1400, 2, 0, N'GorroBlancoRipNdip.png')
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
INSERT [dbo].[Ventas] ([nroTicket], [idUsuario], [fecha], [total]) VALUES (1, N'juantargon', CAST(N'2021-09-09T00:00:00.000' AS DateTime), 9000)
INSERT [dbo].[Ventas] ([nroTicket], [idUsuario], [fecha], [total]) VALUES (2, N'gastonriosc', CAST(N'2021-08-01T00:00:00.000' AS DateTime), 8800)
INSERT [dbo].[Ventas] ([nroTicket], [idUsuario], [fecha], [total]) VALUES (3, N'tomasripsky', CAST(N'2021-08-20T00:00:00.000' AS DateTime), 12000)
GO
ALTER TABLE [dbo].[detalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_detalleVentas_Prendas] FOREIGN KEY([idPrenda])
REFERENCES [dbo].[Prendas] ([id])
GO
ALTER TABLE [dbo].[detalleVentas] CHECK CONSTRAINT [FK_detalleVentas_Prendas]
GO
ALTER TABLE [dbo].[detalleVentas]  WITH CHECK ADD  CONSTRAINT [FK_detalleVentas_Ventas] FOREIGN KEY([nroTicket])
REFERENCES [dbo].[Ventas] ([nroTicket])
GO
ALTER TABLE [dbo].[detalleVentas] CHECK CONSTRAINT [FK_detalleVentas_Ventas]
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
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Usuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuarios] ([usuario])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Usuarios]
GO
USE [master]
GO
ALTER DATABASE [gridFreaks] SET  READ_WRITE 
GO
