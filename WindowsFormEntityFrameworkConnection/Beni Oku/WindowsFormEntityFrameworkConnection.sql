USE [master]
GO
/****** Object:  Database [WindowsFormEntityFrameworkConnection]    Script Date: 22.01.2022 18:37:36 ******/
CREATE DATABASE [WindowsFormEntityFrameworkConnection]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WindowsFormEntityFrameworkConnection', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WindowsFormEntityFrameworkConnection.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WindowsFormEntityFrameworkConnection_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\WindowsFormEntityFrameworkConnection_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WindowsFormEntityFrameworkConnection].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET ARITHABORT OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET  MULTI_USER 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET QUERY_STORE = OFF
GO
USE [WindowsFormEntityFrameworkConnection]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 22.01.2022 18:37:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LastNmae] [nvarchar](max) NULL,
	[Telefon] [nvarchar](max) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [WindowsFormEntityFrameworkConnection] SET  READ_WRITE 
GO
