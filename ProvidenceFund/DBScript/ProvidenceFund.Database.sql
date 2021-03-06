USE [master]
GO
/****** Object:  Database [ProvidenceFund]    ******/
CREATE DATABASE [ProvidenceFund]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProvidenceFund', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.WHITENATTAPAT\MSSQL\DATA\ProvidenceFund.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProvidenceFund_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.WHITENATTAPAT\MSSQL\DATA\ProvidenceFund_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProvidenceFund] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProvidenceFund].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProvidenceFund] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProvidenceFund] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProvidenceFund] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProvidenceFund] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProvidenceFund] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProvidenceFund] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProvidenceFund] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProvidenceFund] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProvidenceFund] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProvidenceFund] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProvidenceFund] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProvidenceFund] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProvidenceFund] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProvidenceFund] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProvidenceFund] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProvidenceFund] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProvidenceFund] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProvidenceFund] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProvidenceFund] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProvidenceFund] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProvidenceFund] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProvidenceFund] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProvidenceFund] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProvidenceFund] SET  MULTI_USER 
GO
ALTER DATABASE [ProvidenceFund] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProvidenceFund] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProvidenceFund] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProvidenceFund] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProvidenceFund] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProvidenceFund] SET  READ_WRITE 
GO
