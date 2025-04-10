USE [master]
GO
/****** Object:  Database [Budget]    Script Date: 8.4.2025 8:43:42 ******/
CREATE DATABASE [Budget]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Budget', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Budget.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Budget_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Budget_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Budget] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Budget].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Budget] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Budget] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Budget] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Budget] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Budget] SET ARITHABORT OFF 
GO
ALTER DATABASE [Budget] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Budget] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Budget] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Budget] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Budget] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Budget] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Budget] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Budget] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Budget] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Budget] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Budget] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Budget] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Budget] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Budget] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Budget] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Budget] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Budget] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Budget] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Budget] SET  MULTI_USER 
GO
ALTER DATABASE [Budget] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Budget] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Budget] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Budget] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Budget] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Budget] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Budget] SET QUERY_STORE = OFF
GO
USE [Budget]
GO
/****** Object:  Table [dbo].[Balance]    Script Date: 8.4.2025 8:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[IncomeId] [int] NULL,
	[ExpenseId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expense]    Script Date: 8.4.2025 8:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expense](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Date] [datetime] NULL,
	[Description] [text] NULL,
	[TypeOfExpenseID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Income]    Script Date: 8.4.2025 8:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Income](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Date] [datetime] NULL,
	[Description] [text] NULL,
	[TypeOfIncomeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfExpense]    Script Date: 8.4.2025 8:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfExpense](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeOfIncome]    Script Date: 8.4.2025 8:43:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeOfIncome](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Balance] ON 

INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (1, CAST(150.00 AS Decimal(10, 2)), 4, NULL)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (2, CAST(750.00 AS Decimal(10, 2)), 5, NULL)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (3, CAST(3250.00 AS Decimal(10, 2)), 1, NULL)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (4, CAST(3000.00 AS Decimal(10, 2)), NULL, 2)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (5, CAST(2800.00 AS Decimal(10, 2)), NULL, 4)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (6, CAST(12800.00 AS Decimal(10, 2)), 2, NULL)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (7, CAST(12900.00 AS Decimal(10, 2)), 3, NULL)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (8, CAST(900.00 AS Decimal(10, 2)), NULL, 1)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (9, CAST(400.00 AS Decimal(10, 2)), NULL, 3)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (10, CAST(-1600.00 AS Decimal(10, 2)), NULL, 5)
INSERT [dbo].[Balance] ([Id], [Amount], [IncomeId], [ExpenseId]) VALUES (11, CAST(0.00 AS Decimal(10, 2)), 6, NULL)
SET IDENTITY_INSERT [dbo].[Balance] OFF
GO
SET IDENTITY_INSERT [dbo].[Expense] ON 

INSERT [dbo].[Expense] ([Id], [Amount], [Date], [Description], [TypeOfExpenseID]) VALUES (1, CAST(12000.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:19:21.217' AS DateTime), N'Кола - Opel Zafira OPC, закупена от автокъща "Кентавър"', 4)
INSERT [dbo].[Expense] ([Id], [Amount], [Date], [Description], [TypeOfExpenseID]) VALUES (2, CAST(250.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:21:10.497' AS DateTime), N'Пазаруване в Кауфланд', 1)
INSERT [dbo].[Expense] ([Id], [Amount], [Date], [Description], [TypeOfExpenseID]) VALUES (3, CAST(500.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:22:02.243' AS DateTime), N'Курс по AI', 5)
INSERT [dbo].[Expense] ([Id], [Amount], [Date], [Description], [TypeOfExpenseID]) VALUES (4, CAST(200.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:27:12.550' AS DateTime), N'Сметка за ток', 6)
INSERT [dbo].[Expense] ([Id], [Amount], [Date], [Description], [TypeOfExpenseID]) VALUES (5, CAST(2000.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:29:47.160' AS DateTime), N'Почивка за две седмици до Камчия', 7)
SET IDENTITY_INSERT [dbo].[Expense] OFF
GO
SET IDENTITY_INSERT [dbo].[Income] ON 

INSERT [dbo].[Income] ([Id], [Amount], [Date], [Description], [TypeOfIncomeID]) VALUES (1, CAST(2500.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:32:50.663' AS DateTime), N'Заплата от работата', 1)
INSERT [dbo].[Income] ([Id], [Amount], [Date], [Description], [TypeOfIncomeID]) VALUES (2, CAST(10000.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:35:34.500' AS DateTime), N'Печалба от лотария', 2)
INSERT [dbo].[Income] ([Id], [Amount], [Date], [Description], [TypeOfIncomeID]) VALUES (3, CAST(100.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:36:55.480' AS DateTime), N'Стипендия от университет', 6)
INSERT [dbo].[Income] ([Id], [Amount], [Date], [Description], [TypeOfIncomeID]) VALUES (4, CAST(150.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:38:57.730' AS DateTime), N'Пари от татко', 5)
INSERT [dbo].[Income] ([Id], [Amount], [Date], [Description], [TypeOfIncomeID]) VALUES (5, CAST(600.00 AS Decimal(10, 2)), CAST(N'2025-03-25T09:39:10.033' AS DateTime), N'Дивидент от акции на Nvidia', 3)
INSERT [dbo].[Income] ([Id], [Amount], [Date], [Description], [TypeOfIncomeID]) VALUES (6, CAST(1600.00 AS Decimal(10, 2)), CAST(N'2025-04-07T10:31:25.340' AS DateTime), N'Машинки - цял екран камбанки', 2)
SET IDENTITY_INSERT [dbo].[Income] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeOfExpense] ON 

INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (1, N'Groceries')
INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (2, N'Fuel')
INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (3, N'Taxes')
INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (4, N'Family')
INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (5, N'Education')
INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (6, N'Bills')
INSERT [dbo].[TypeOfExpense] ([Id], [Name]) VALUES (7, N'Vacation')
SET IDENTITY_INSERT [dbo].[TypeOfExpense] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeOfIncome] ON 

INSERT [dbo].[TypeOfIncome] ([Id], [Name]) VALUES (1, N'Salary')
INSERT [dbo].[TypeOfIncome] ([Id], [Name]) VALUES (2, N'Lottery')
INSERT [dbo].[TypeOfIncome] ([Id], [Name]) VALUES (3, N'From Investment')
INSERT [dbo].[TypeOfIncome] ([Id], [Name]) VALUES (4, N'From Friend')
INSERT [dbo].[TypeOfIncome] ([Id], [Name]) VALUES (5, N'From Parents')
INSERT [dbo].[TypeOfIncome] ([Id], [Name]) VALUES (6, N'Scholarship')
SET IDENTITY_INSERT [dbo].[TypeOfIncome] OFF
GO
ALTER TABLE [dbo].[Expense] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Income] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Balance]  WITH CHECK ADD FOREIGN KEY([ExpenseId])
REFERENCES [dbo].[Expense] ([Id])
GO
ALTER TABLE [dbo].[Balance]  WITH CHECK ADD FOREIGN KEY([IncomeId])
REFERENCES [dbo].[Income] ([Id])
GO
ALTER TABLE [dbo].[Expense]  WITH CHECK ADD FOREIGN KEY([TypeOfExpenseID])
REFERENCES [dbo].[TypeOfExpense] ([Id])
GO
ALTER TABLE [dbo].[Income]  WITH CHECK ADD FOREIGN KEY([TypeOfIncomeID])
REFERENCES [dbo].[TypeOfIncome] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Budget] SET  READ_WRITE 
GO
