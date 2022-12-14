USE [master]
GO
/****** Object:  Database [ProductDB]    Script Date: 8/14/2022 12:09:52 PM ******/
CREATE DATABASE [ProductDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductDB', FILENAME = N'E:\MSSQL11.SQLEXPRESS\MSSQL\DATA\ProductDB.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProductDB_log', FILENAME = N'E:\MSSQL11.SQLEXPRESS\MSSQL\DATA\ProductDB_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProductDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProductDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProductDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProductDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProductDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProductDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ProductDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/14/2022 12:09:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 8/14/2022 12:09:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Order]    Script Date: 8/14/2022 12:09:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](250) NOT NULL,
	[Address] [nvarchar](250) NULL,
	[Price] [float] NULL,
	[OrderDate] [datetime] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 8/14/2022 12:09:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 8/14/2022 12:09:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PayTime] [datetime] NULL,
	[Amount] [float] NOT NULL,
	[OrderId] [int] NOT NULL,
	[PayType] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 8/14/2022 12:09:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Price] [float] NULL,
	[CreatedDate] [datetime] NULL,
	[Status] [int] NULL,
	[CategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (1, N'FFOD', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (2, N'VEBLE', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (3, N'MEAT', 1)
INSERT [dbo].[Category] ([Id], [Name], [Status]) VALUES (5, N'FRUIT', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [CustomerName], [Address], [Price], [OrderDate], [Status]) VALUES (5, N'Mamako', N'My House,Nibban,Japan', 40000, CAST(N'2022-09-11 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([Id], [CustomerName], [Address], [Price], [OrderDate], [Status]) VALUES (22, N'Mamako', N'Kohaku, Hokkaido , Japan', 80000, CAST(N'2022-10-11 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([Id], [CustomerName], [Address], [Price], [OrderDate], [Status]) VALUES (24, N'Mamako Sakura', N'My House, Nibba , Japan', 30000, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([Id], [CustomerName], [Address], [Price], [OrderDate], [Status]) VALUES (25, N'Mamako Sakura', N'My House, Nibba , Japan', 30000, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([Id], [CustomerName], [Address], [Price], [OrderDate], [Status]) VALUES (26, N'Yor Forger', N'13/26 Nagasaki, Shibuya, Japan', 50000, CAST(N'2022-07-26 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Order] ([Id], [CustomerName], [Address], [Price], [OrderDate], [Status]) VALUES (30, N'Keith Newell', N'ashdbukqwkdbksubdakugduiwqhdiisldubsa', 32000, CAST(N'2022-07-20 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (31, 5, 22, 2, 30000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (32, 4, 22, 1, 35000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (33, 5, 22, 1, 15000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (34, 5, 24, 1, 15000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (35, 13, 24, 1, 10000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (36, 13, 24, 1, 10000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (37, 5, 25, 1, 15000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (39, 13, 25, 1, 10000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (40, 32, 24, 4, 40000)
INSERT [dbo].[OrderDetail] ([Id], [ProductID], [OrderId], [Quantity], [Price]) VALUES (41, 28, 25, 5, 50000)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (19, CAST(N'2022-10-11 00:00:00.000' AS DateTime), 50000, 22, 1)
INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (21, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 15000, 24, 1)
INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (23, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 15000, 25, 1)
INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (24, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 20000, 25, 2)
INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (25, CAST(N'2022-07-20 00:00:00.000' AS DateTime), 44000, 25, 0)
INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (26, CAST(N'2022-08-05 00:00:00.000' AS DateTime), 75000, 25, 1)
INSERT [dbo].[Payment] ([Id], [PayTime], [Amount], [OrderId], [PayType]) VALUES (27, CAST(N'2022-07-29 00:00:00.000' AS DateTime), 90000, 24, 2)
SET IDENTITY_INSERT [dbo].[Payment] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (4, N'Burger', 40000, CAST(N'2022-09-05 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (5, N'French Fries', 15000, CAST(N'2022-08-10 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (13, N'Coca Cola', 10000, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 0, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (16, N'Smashed Potato', 5000, CAST(N'2022-10-11 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (17, N'Apple', 3000, CAST(N'2022-06-06 00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (18, N'Tomato', 3000, CAST(N'2022-09-10 00:00:00.000' AS DateTime), 1, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (19, N'Orange', 3000, CAST(N'2022-05-05 00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (20, N'Orange', 3000, CAST(N'2022-05-05 00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (21, N'Orange', 3000, CAST(N'2022-05-05 00:00:00.000' AS DateTime), 0, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (22, N'Smashed Potato', 5000, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (23, N'Orange', 3000, CAST(N'2022-08-10 00:00:00.000' AS DateTime), 1, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (24, N'Smashed Potato', 5000, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (25, N'Orange', 3000, CAST(N'2022-08-10 00:00:00.000' AS DateTime), 1, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (26, N'Smashed Potato', 5000, CAST(N'2022-09-09 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (27, N'Orange', 3000, CAST(N'2022-08-10 00:00:00.000' AS DateTime), 1, 2)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (28, N'Olong tea', 15000, CAST(N'2022-06-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (31, N'Revive', 15000, CAST(N'2022-06-14 00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (32, N'Cheese', 100, CAST(N'2022-06-30 20:30:37.000' AS DateTime), 1, 1)
INSERT [dbo].[Product] ([Id], [Name], [Price], [CreatedDate], [Status], [CategoryId]) VALUES (35, N'Big Mac', 50000, CAST(N'2022-07-12 20:21:21.000' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Order__1A14E395] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Order__1A14E395]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Produ__1920BF5C] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Produ__1920BF5C]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK__Payment__OrderId__1B0907CE] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK__Payment__OrderId__1B0907CE]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__Categor__182C9B23] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__Categor__182C9B23]
GO
USE [master]
GO
ALTER DATABASE [ProductDB] SET  READ_WRITE 
GO
