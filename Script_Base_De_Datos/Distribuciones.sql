USE [master]
GO
/****** Object:  Database [Distribuciones]    Script Date: 02/05/2015 23:11:14 ******/
CREATE DATABASE [Distribuciones] ON  PRIMARY 
( NAME = N'Distribuciones', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.FACCI\MSSQL\DATA\Distribuciones.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Distribuciones_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.FACCI\MSSQL\DATA\Distribuciones_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Distribuciones] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Distribuciones].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Distribuciones] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Distribuciones] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Distribuciones] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Distribuciones] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Distribuciones] SET ARITHABORT OFF
GO
ALTER DATABASE [Distribuciones] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Distribuciones] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Distribuciones] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Distribuciones] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Distribuciones] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Distribuciones] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Distribuciones] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Distribuciones] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Distribuciones] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Distribuciones] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Distribuciones] SET  DISABLE_BROKER
GO
ALTER DATABASE [Distribuciones] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Distribuciones] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Distribuciones] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Distribuciones] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Distribuciones] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Distribuciones] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Distribuciones] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Distribuciones] SET  READ_WRITE
GO
ALTER DATABASE [Distribuciones] SET RECOVERY FULL
GO
ALTER DATABASE [Distribuciones] SET  MULTI_USER
GO
ALTER DATABASE [Distribuciones] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Distribuciones] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Distribuciones', N'ON'
GO
USE [Distribuciones]
GO
/****** Object:  Table [dbo].[Cuadratica]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cuadratica](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[X] [varchar](200) NOT NULL,
	[Y] [nchar](200) NOT NULL,
 CONSTRAINT [PK_Cuadratica] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Congruencial]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Congruencial](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[N] [int] NOT NULL,
	[M] [int] NOT NULL,
	[Xn] [int] NOT NULL,
	[A] [int] NOT NULL,
	[C] [int] NOT NULL,
 CONSTRAINT [PK_Congruencial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlisamientoExponencial]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AlisamientoExponencial](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Alfa] [varchar](50) NOT NULL,
	[Demandas] [varchar](200) NOT NULL,
	[NuevasDemandas] [varchar](200) NOT NULL,
 CONSTRAINT [PK_AlisamientoExponencial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AleatoriosVentasImpresoras]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AleatoriosVentasImpresoras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Mes] [varchar](50) NOT NULL,
	[Cantidad] [varchar](50) NOT NULL,
	[Cobro] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AleatoriosVentasImpresoras] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AleatoriosCantidadImpresoras]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AleatoriosCantidadImpresoras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Mes] [varchar](100) NOT NULL,
	[Cantidad] [varchar](50) NOT NULL,
	[Cobro] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AleatoriosCantidadImpresoras] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aleatorios]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aleatorios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CadenaAleatorios] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Aleatorios] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Simulacion]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Simulacion](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdArreglo] [int] NOT NULL,
	[IdVenta] [int] NOT NULL,
 CONSTRAINT [PK_Simulacion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdActividadUno] [int] NOT NULL,
	[IdActividadDos] [int] NOT NULL,
	[IdActividadTres] [int] NOT NULL,
	[IdActividadCuatro] [int] NOT NULL,
	[IdAleatorio] [int] NOT NULL,
 CONSTRAINT [PK_Proyecto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PronosticosVentasImpresoras]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PronosticosVentasImpresoras](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MesPronostico] [varchar](50) NOT NULL,
	[CantidadVenta] [varchar](50) NOT NULL,
	[Cobro] [varchar](50) NOT NULL,
	[Evaluar] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PronosticosVentasImpresoras] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PronosticosImpresorasArregladas]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PronosticosImpresorasArregladas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MesPronostico] [varchar](50) NOT NULL,
	[CantidadVenta] [varchar](50) NOT NULL,
	[Cobro] [varchar](50) NOT NULL,
	[Evaluar] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PronosticosImpresorasArregladas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PromedioMovilPronostico]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PromedioMovilPronostico](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Demandas] [varchar](200) NOT NULL,
	[EvaluarUno] [int] NOT NULL,
	[EvaluarDos] [int] NOT NULL,
 CONSTRAINT [PK_PromedioMovilPronostico] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PromedioMovil]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PromedioMovil](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Demandas] [varchar](200) NOT NULL,
	[Evaluar] [int] NOT NULL,
 CONSTRAINT [PK_PromedioMovil] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PoliticaInventario]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PoliticaInventario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Distribucion] [int] NOT NULL,
	[TiempoDeEntrega] [int] NOT NULL,
	[AleatorioDistribucion] [int] NOT NULL,
	[AleatorioTiempoDeEntrega] [int] NOT NULL,
	[CantidadOrdenar] [varchar](50) NOT NULL,
	[PuntoDeReorden] [varchar](50) NOT NULL,
	[CostoPorFaltantes] [varchar](50) NOT NULL,
	[CostoMantenimiento] [varchar](50) NOT NULL,
	[CostoDeOrdenar] [varchar](50) NOT NULL,
	[InventarioInicial] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PoliticaInventario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lineal]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lineal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[X] [varchar](200) NOT NULL,
	[Y] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Lineal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LineaEsperaUnCanal]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LineaEsperaUnCanal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdLlegada] [int] NOT NULL,
	[IdServicio] [int] NOT NULL,
	[MediaTiempoEntreLlegada] [varchar](50) NOT NULL,
	[MediaTiempoDeServicio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LineaEsperaUnCanal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LineaDeEsperaCasoUno]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LineaDeEsperaCasoUno](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Llegada] [int] NOT NULL,
	[Servicio] [int] NOT NULL,
	[TiempoEntreLlegada] [varchar](50) NOT NULL,
	[TiempoDeServicio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LineaDeEsperaCasoUno] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LineaDeEsperaCasoDos]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LineaDeEsperaCasoDos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TiempoEntreLlegada] [int] NOT NULL,
	[TiempoDeServicio] [int] NOT NULL,
	[AleatorioEntrada] [int] NOT NULL,
	[AleatorioServicio] [int] NOT NULL,
 CONSTRAINT [PK_LineaDeEsperaCasoDos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdDistribucion] [int] NOT NULL,
	[IdTiempo] [int] NOT NULL,
	[IdDistribucionM] [int] NOT NULL,
	[IdTiempoM] [int] NOT NULL,
	[CantidadOrdenar] [varchar](50) NOT NULL,
	[PuntoReorden] [varchar](50) NOT NULL,
	[CostoPorFaltantes] [varchar](50) NOT NULL,
	[CostoMantenimiento] [varchar](50) NOT NULL,
	[CostoOrdenar] [varchar](50) NOT NULL,
	[InventarioInicial] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Frecuencias]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Frecuencias](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CadenaDemandas] [varchar](500) NOT NULL,
	[CadenaProbabilidad] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Frecuencias] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Exponencial]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exponencial](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdCongruencial] [int] NOT NULL,
	[Landa] [float] NOT NULL,
 CONSTRAINT [PK_Exponencial] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poisson]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poisson](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdCongruencial] [int] NOT NULL,
	[Landa] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Poisson] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonteCarlo]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonteCarlo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdCongruencial] [int] NOT NULL,
	[Demandas] [varchar](200) NOT NULL,
	[Ocurrencias] [varchar](200) NOT NULL,
 CONSTRAINT [PK_MonteCarlo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Aleatoria]    Script Date: 02/05/2015 23:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Aleatoria](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdCongruencial] [int] NOT NULL,
	[PrimerParametro] [varchar](100) NOT NULL,
	[SegundoParametro] [varchar](100) NOT NULL,
	[Funcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Aleatoria] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_Exponencial_Congruencial]    Script Date: 02/05/2015 23:11:16 ******/
ALTER TABLE [dbo].[Exponencial]  WITH CHECK ADD  CONSTRAINT [FK_Exponencial_Congruencial] FOREIGN KEY([IdCongruencial])
REFERENCES [dbo].[Congruencial] ([ID])
GO
ALTER TABLE [dbo].[Exponencial] CHECK CONSTRAINT [FK_Exponencial_Congruencial]
GO
/****** Object:  ForeignKey [FK_Poisson_Congruencial]    Script Date: 02/05/2015 23:11:16 ******/
ALTER TABLE [dbo].[Poisson]  WITH CHECK ADD  CONSTRAINT [FK_Poisson_Congruencial] FOREIGN KEY([IdCongruencial])
REFERENCES [dbo].[Congruencial] ([ID])
GO
ALTER TABLE [dbo].[Poisson] CHECK CONSTRAINT [FK_Poisson_Congruencial]
GO
/****** Object:  ForeignKey [FK_MonteCarlo_Congruencial]    Script Date: 02/05/2015 23:11:16 ******/
ALTER TABLE [dbo].[MonteCarlo]  WITH CHECK ADD  CONSTRAINT [FK_MonteCarlo_Congruencial] FOREIGN KEY([IdCongruencial])
REFERENCES [dbo].[Congruencial] ([ID])
GO
ALTER TABLE [dbo].[MonteCarlo] CHECK CONSTRAINT [FK_MonteCarlo_Congruencial]
GO
/****** Object:  ForeignKey [FK_Aleatoria_Congruencial]    Script Date: 02/05/2015 23:11:16 ******/
ALTER TABLE [dbo].[Aleatoria]  WITH CHECK ADD  CONSTRAINT [FK_Aleatoria_Congruencial] FOREIGN KEY([IdCongruencial])
REFERENCES [dbo].[Congruencial] ([ID])
GO
ALTER TABLE [dbo].[Aleatoria] CHECK CONSTRAINT [FK_Aleatoria_Congruencial]
GO
