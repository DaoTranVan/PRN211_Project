USE [master]
GO
/****** Object:  Database [StudentManagement]    Script Date: 7/24/2022 8:53:45 AM ******/
CREATE DATABASE [StudentManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student_Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Student_Management.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student_Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Student_Management_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StudentManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StudentManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StudentManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StudentManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StudentManagement] SET QUERY_STORE = OFF
GO
USE [StudentManagement]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 7/24/2022 8:53:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[class_id] [int] IDENTITY(1,1) NOT NULL,
	[class_name] [varchar](50) NULL,
	[class_desc] [text] NULL,
	[major_id] [varchar](50) NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 7/24/2022 8:53:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[gender_id] [int] IDENTITY(1,1) NOT NULL,
	[gender_name] [varchar](50) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[gender_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Major]    Script Date: 7/24/2022 8:53:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Major](
	[major_id] [varchar](50) NOT NULL,
	[major_name] [varchar](255) NULL,
	[major_desc] [text] NULL,
 CONSTRAINT [PK_Major] PRIMARY KEY CLUSTERED 
(
	[major_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/24/2022 8:53:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [varchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/24/2022 8:53:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[student_id] [varchar](50) NOT NULL,
	[student_name] [varchar](255) NULL,
	[password] [varchar](50) NULL,
	[student_img] [text] NULL,
	[student_dob] [date] NULL,
	[student_phone] [varchar](50) NULL,
	[student_address] [varchar](255) NULL,
	[class_id] [int] NULL,
	[major_id] [varchar](50) NULL,
	[role_id] [int] NULL,
	[gender_id] [int] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (1, N'SE15001', NULL, N'SE')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (2, N'SE15002', NULL, N'SE')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (3, N'IT15003', NULL, N'IT')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (4, N'IT15004', NULL, N'IT')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (5, N'JS15005', NULL, N'JS')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (6, N'JS15006', NULL, N'JS')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (7, N'EL15007', NULL, N'EL')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (8, N'EL15008', NULL, N'EL')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (9, N'BA15009', NULL, N'BA')
INSERT [dbo].[Class] ([class_id], [class_name], [class_desc], [major_id]) VALUES (10, N'BA15010', NULL, N'BA')
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([gender_id], [gender_name]) VALUES (1, N'Male')
INSERT [dbo].[Gender] ([gender_id], [gender_name]) VALUES (2, N'Female')
INSERT [dbo].[Gender] ([gender_id], [gender_name]) VALUES (3, N'Orther')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
INSERT [dbo].[Major] ([major_id], [major_name], [major_desc]) VALUES (N'BA', N'Business Administration', N'learn about BA')
INSERT [dbo].[Major] ([major_id], [major_name], [major_desc]) VALUES (N'EL', N'English Language', NULL)
INSERT [dbo].[Major] ([major_id], [major_name], [major_desc]) VALUES (N'IT', N'Information Technology', NULL)
INSERT [dbo].[Major] ([major_id], [major_name], [major_desc]) VALUES (N'JS', N'Japanese', N'learn Japanese ')
INSERT [dbo].[Major] ([major_id], [major_name], [major_desc]) VALUES (N'SE', N'Sortware Engineering', NULL)
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([role_id], [role_name]) VALUES (1, N'student')
INSERT [dbo].[Role] ([role_id], [role_name]) VALUES (2, N'admin')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[Student] ([student_id], [student_name], [password], [student_img], [student_dob], [student_phone], [student_address], [class_id], [major_id], [role_id], [gender_id]) VALUES (N'0151006', N'Dao', N'123@123a', NULL, CAST(N'2002-11-03' AS Date), N'0900000009', N'Quat Lam', NULL, NULL, 1, 2)
INSERT [dbo].[Student] ([student_id], [student_name], [password], [student_img], [student_dob], [student_phone], [student_address], [class_id], [major_id], [role_id], [gender_id]) VALUES (N'BA151004', N'Tran Van Dao', N'123@123a', NULL, CAST(N'2001-10-09' AS Date), N'0900000009', N'Nam Dinh', 10, N'BA', 1, 3)
INSERT [dbo].[Student] ([student_id], [student_name], [password], [student_img], [student_dob], [student_phone], [student_address], [class_id], [major_id], [role_id], [gender_id]) VALUES (N'EL151003', N'Nguyen Danh Chieu', N'1234', NULL, CAST(N'2000-10-09' AS Date), N'0900000009', N'Hung Yen', 7, N'EL', 1, 1)
INSERT [dbo].[Student] ([student_id], [student_name], [password], [student_img], [student_dob], [student_phone], [student_address], [class_id], [major_id], [role_id], [gender_id]) VALUES (N'IT151002', N'Nguyen Hoai Nam', N'123', NULL, CAST(N'2002-09-10' AS Date), NULL, NULL, 3, N'IT', 1, 1)
INSERT [dbo].[Student] ([student_id], [student_name], [password], [student_img], [student_dob], [student_phone], [student_address], [class_id], [major_id], [role_id], [gender_id]) VALUES (N'IT151005', N'Nguyen Ngoc Toan', N'123@123a', NULL, CAST(N'2001-10-09' AS Date), N'0900000009', N'Bac Linh', NULL, N'IT', 1, 2)
INSERT [dbo].[Student] ([student_id], [student_name], [password], [student_img], [student_dob], [student_phone], [student_address], [class_id], [major_id], [role_id], [gender_id]) VALUES (N'SE151001', N'Tran Van Dao', N'1234', NULL, CAST(N'1999-06-24' AS Date), NULL, NULL, NULL, NULL, 2, 2)
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Major] FOREIGN KEY([major_id])
REFERENCES [dbo].[Major] ([major_id])
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Major]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Class] FOREIGN KEY([class_id])
REFERENCES [dbo].[Class] ([class_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Class]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Gender] FOREIGN KEY([gender_id])
REFERENCES [dbo].[Gender] ([gender_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Gender]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Major] FOREIGN KEY([major_id])
REFERENCES [dbo].[Major] ([major_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Major]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Role] FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Role]
GO
USE [master]
GO
ALTER DATABASE [StudentManagement] SET  READ_WRITE 
GO
