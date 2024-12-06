USE [master]
GO
/****** Object:  Database [DBCourseRegistration]    Script Date: 6.12.2024 17:39:00 ******/
CREATE DATABASE [DBCourseRegistration]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBCourseRegistration', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBCourseRegistration.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBCourseRegistration_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBCourseRegistration_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DBCourseRegistration] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBCourseRegistration].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBCourseRegistration] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBCourseRegistration] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBCourseRegistration] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBCourseRegistration] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBCourseRegistration] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET RECOVERY FULL 
GO
ALTER DATABASE [DBCourseRegistration] SET  MULTI_USER 
GO
ALTER DATABASE [DBCourseRegistration] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBCourseRegistration] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBCourseRegistration] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBCourseRegistration] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBCourseRegistration] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBCourseRegistration] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBCourseRegistration', N'ON'
GO
ALTER DATABASE [DBCourseRegistration] SET QUERY_STORE = ON
GO
ALTER DATABASE [DBCourseRegistration] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DBCourseRegistration]
GO
/****** Object:  Table [dbo].[Tbl_Branch]    Script Date: 6.12.2024 17:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Branch](
	[BranchID] [tinyint] IDENTITY(1,1) NOT NULL,
	[BranchName] [varchar](20) NULL,
 CONSTRAINT [PK_Tbl_Branch] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Course]    Script Date: 6.12.2024 17:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Course](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[BranchID] [tinyint] NULL,
	[TeacherID] [tinyint] NULL,
	[StudentID] [smallint] NULL,
	[Date] [varchar](10) NULL,
	[Time] [char](5) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Tbl_Course] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Student]    Script Date: 6.12.2024 17:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Student](
	[StudentID] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](15) NULL,
	[Surname] [varchar](30) NULL,
	[Photograph] [varchar](100) NULL,
	[Class] [char](2) NULL,
	[Phone] [varchar](15) NULL,
	[Mail] [varchar](50) NULL,
	[Password] [varchar](10) NULL,
	[StudentNumber] [smallint] NULL,
 CONSTRAINT [PK_Tbl_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Teacher]    Script Date: 6.12.2024 17:39:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Teacher](
	[TeacherID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](15) NULL,
	[Surname] [varchar](30) NULL,
	[BranchID] [tinyint] NULL,
	[Password] [varchar](10) NULL,
	[TeacherNumber] [smallint] NULL,
 CONSTRAINT [PK_Tbl_Teacher_1] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Course] ADD  CONSTRAINT [DF_Tbl_Course_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Tbl_Course]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Course_Tbl_Branch] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Tbl_Branch] ([BranchID])
GO
ALTER TABLE [dbo].[Tbl_Course] CHECK CONSTRAINT [FK_Tbl_Course_Tbl_Branch]
GO
ALTER TABLE [dbo].[Tbl_Course]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Course_Tbl_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Tbl_Student] ([StudentID])
GO
ALTER TABLE [dbo].[Tbl_Course] CHECK CONSTRAINT [FK_Tbl_Course_Tbl_Student]
GO
ALTER TABLE [dbo].[Tbl_Course]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Course_Tbl_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Tbl_Teacher] ([TeacherID])
GO
ALTER TABLE [dbo].[Tbl_Course] CHECK CONSTRAINT [FK_Tbl_Course_Tbl_Teacher]
GO
ALTER TABLE [dbo].[Tbl_Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Teacher_Tbl_Branch] FOREIGN KEY([BranchID])
REFERENCES [dbo].[Tbl_Branch] ([BranchID])
GO
ALTER TABLE [dbo].[Tbl_Teacher] CHECK CONSTRAINT [FK_Tbl_Teacher_Tbl_Branch]
GO
USE [master]
GO
ALTER DATABASE [DBCourseRegistration] SET  READ_WRITE 
GO
