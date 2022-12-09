USE [master]
GO

/****** Object:  Database [EmployeeManagmentDataBase]    Script Date: 09/12/2022 17:43:05 ******/
CREATE DATABASE [EmployeeManagmentDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeManagmentDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LEVPCMSSQLSERVER\MSSQL\DATA\EmployeeManagmentDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeManagmentDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LEVPCMSSQLSERVER\MSSQL\DATA\EmployeeManagmentDataBase_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeManagmentDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET RECOVERY FULL 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET  MULTI_USER 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EmployeeManagmentDataBase] SET  READ_WRITE 
GO


USE [EmployeeManagmentDataBase]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 09/12/2022 17:43:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[type] [nvarchar](50) NOT NULL,
	[_IntId] [int] NOT NULL,
	[_StateID] [nchar](9) NOT NULL,
	[_fName] [nvarchar](25) NOT NULL,
	[_lName] [nvarchar](25) NOT NULL,
	[_mName] [nvarchar](25) NOT NULL,
	[_email] [nvarchar](55) NOT NULL,
	[_password] [nvarchar](50) NOT NULL,
	[_gender] [nvarchar](25) NOT NULL,
	[_birthDate] [nchar](19) NOT NULL,
	[_created] [nchar](19) NOT NULL,
	[_employmentStatus] [nchar](21) NOT NULL,
	[_baseSalary] [float] NOT NULL,
	[_salaryModifire] [float] NOT NULL,
	[_phoneNumber] [nchar](10) NOT NULL,
	[_address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[_IntId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [EmployeeManagmentDataBase]
GO

/****** Object:  Table [dbo].[HourLogs]    Script Date: 09/12/2022 17:43:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HourLogs](
	[_intId] [int] NOT NULL,
	[_entry] [datetime2](0) NULL,
	[_exit] [datetime2](0) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HourLogs]  WITH CHECK ADD  CONSTRAINT [FK_HourLogs_Employees] FOREIGN KEY([_intId])
REFERENCES [dbo].[Employees] ([_IntId])
GO

ALTER TABLE [dbo].[HourLogs] CHECK CONSTRAINT [FK_HourLogs_Employees]
GO

