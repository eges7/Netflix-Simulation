USE [master]
GO
/****** Object:  Database [Netflix]    Script Date: 1.06.2020 23:56:50 ******/
CREATE DATABASE [Netflix]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Netflix', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Netflix.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Netflix_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Netflix_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Netflix] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Netflix].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Netflix] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Netflix] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Netflix] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Netflix] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Netflix] SET ARITHABORT OFF 
GO
ALTER DATABASE [Netflix] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Netflix] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Netflix] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Netflix] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Netflix] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Netflix] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Netflix] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Netflix] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Netflix] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Netflix] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Netflix] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Netflix] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Netflix] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Netflix] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Netflix] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Netflix] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Netflix] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Netflix] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Netflix] SET  MULTI_USER 
GO
ALTER DATABASE [Netflix] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Netflix] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Netflix] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Netflix] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Netflix] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Netflix] SET QUERY_STORE = OFF
GO
USE [Netflix]
GO
/****** Object:  User [NewAdminName]    Script Date: 1.06.2020 23:56:51 ******/
CREATE USER [NewAdminName] FOR LOGIN [NewAdminName] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [NewAdminName]
GO
/****** Object:  Table [dbo].[Kullanıcılar]    Script Date: 1.06.2020 23:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcılar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Şifre] [varchar](50) NOT NULL,
	[DoğumTarihi] [date] NOT NULL,
 CONSTRAINT [PK_Kullanıcı] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullanıcıProgram]    Script Date: 1.06.2020 23:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullanıcıProgram](
	[KullanıcıId] [int] NOT NULL,
	[ProgramId] [int] NOT NULL,
	[İzlemeTarihi] [date] NULL,
	[İzlemeSüresi] [int] NULL,
	[KalınanBölüm] [int] NULL,
	[Puan] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Programlar]    Script Date: 1.06.2020 23:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Programlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Tip] [varchar](20) NOT NULL,
	[BölümSayisi] [int] NOT NULL,
	[Uzunluk] [int] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramTür]    Script Date: 1.06.2020 23:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramTür](
	[ProgramId] [int] NOT NULL,
	[TürId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Türler]    Script Date: 1.06.2020 23:56:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Türler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Türler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Programlar] ON 

INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (1, N'72 Sevimli Hayvan', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (2, N'Alaca Karanlık', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (3, N'Alvin ve Sincaplar', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (4, N'Angry Birds', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (5, N'Arif V 216', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (6, N'Assassin''s Creed', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (7, N'Atiye', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (8, N'Ay''daki Son Adam', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (9, N'Basketball or Nothing', N'TV Show', 4, 176)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (10, N'Başlangıç', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (11, N'Ben Efsaneyim', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (12, N'Beni Böyle Sev', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (13, N'Beyblade', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (14, N'Bizi Hatırla', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (15, N'Büyük Tasarımlar', N'TV Show', 4, 176)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (16, N'Car Masters', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (17, N'Charlie''nin Çikolata Fabrikası', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (18, N'Criminal', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (19, N'Da Vinci Şifresi', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (20, N'Dangal', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (21, N'Delibal', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (22, N'Diriliş Ertuğrul', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (23, N'Dream Big', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (24, N'Dünyanın En Sıra Dışı Evleri', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (25, N'Ejderhalar', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (26, N'Fantastik Canavarlar', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (27, N'Frankestein', N'Filim', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (28, N'Gezegenimiz', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (29, N'Harry Potter ve Ölüm Yadigarları', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (30, N'How I Met Your Mother', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (31, N'Interstellar', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (32, N'Jaws', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (33, N'Jurassic Park', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (34, N'Jurassic World', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (35, N'Kara Şövalye', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (36, N'Kardeşim Benim', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (37, N'Kung Fu Panda', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (38, N'Kung Fu Panda Muhteşem Sırlar', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (39, N'Kuşçular', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (40, N'Kuşlarla Dans', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (41, N'Leyla ile Mecnun', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (42, N'Mars''ta Keşif', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (43, N'Marvel''s Iron Fist', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (44, N'Maske', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (45, N'Maşa ve Koca Ayı', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (46, N'Mega Zeka', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (47, N'Mercan Peşinde', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (48, N'Mission Blue', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (49, N'Mr. Bean Tatilde', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (50, N'Ninja Kaplumbağalar', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (51, N'Örümcek Adam', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (52, N'Pandemic', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (53, N'Patron Bebek Yine İş Başında', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (54, N'PK', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (55, N'Plastik Okyanus', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (56, N'Pokemon', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (57, N'Rakamlarla Tahmin', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (58, N'Recep İvedik 6', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (59, N'Scooby-Doo', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (60, N'Sherlock Holmes', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (61, N'Shrek', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (62, N'Sıradışı Kulübeler', N'TV Show', 4, 176)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (63, N'Sonic X', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (64, N'Stranger Things', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (65, N'Sünger Bob', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (66, N'Şirinler', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (67, N'The Big Family Cooking', N'TV Show', 4, 176)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (68, N'The Blacklist', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (69, N'The Originals', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (70, N'Transformers Kayıp Çağ', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (71, N'Trol Avcıları Arcadia Hikayeleri', N'Dizi', 8, 352)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (72, N'Yerçekimi', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (73, N'Yüzüklerin Efendisi İki Kule', N'Film', 1, 44)
INSERT [dbo].[Programlar] ([Id], [Ad], [Tip], [BölümSayisi], [Uzunluk]) VALUES (74, N'Yüzüklerin Efendisi Kralın Dönüşü', N'Film', 1, 44)
SET IDENTITY_INSERT [dbo].[Programlar] OFF
GO
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (1, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (1, 5)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (2, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (2, 12)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (3, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (4, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (4, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (5, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (5, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (6, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (6, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (7, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (7, 12)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (8, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (9, 11)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (10, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (11, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (12, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (12, 12)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (13, 2)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (13, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (14, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (15, 11)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (16, 11)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (17, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (17, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (18, 8)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (19, 8)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (20, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (21, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (21, 12)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (22, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (23, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (24, 11)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (25, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (25, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (26, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (26, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (27, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (27, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (27, 10)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (28, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (28, 5)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (29, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (29, 5)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (30, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (30, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (31, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (31, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (32, 8)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (33, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (33, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (34, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (35, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (35, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (36, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (36, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (38, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (39, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (39, 5)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (40, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (41, 12)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (42, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (42, 5)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (43, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (44, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (44, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (45, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (46, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (46, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (47, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (48, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (49, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (50, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (50, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (51, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (51, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (52, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (52, 5)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (53, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (53, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (54, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (54, 12)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (55, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (56, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (57, 3)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (58, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (59, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (60, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (61, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (61, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (62, 11)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (63, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (63, 2)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (64, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (64, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (65, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (65, 9)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (66, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (66, 9)
GO
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (67, 11)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (68, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (68, 8)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (69, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (69, 10)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (70, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (71, 6)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (71, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (72, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (72, 7)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (73, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (73, 4)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (74, 1)
INSERT [dbo].[ProgramTür] ([ProgramId], [TürId]) VALUES (74, 4)
GO
SET IDENTITY_INSERT [dbo].[Türler] ON 

INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (1, N'Aksiyon ve Macera')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (2, N'Anime')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (3, N'Belgesel')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (4, N'Bilim Kurgu ve Fantastik Yapımlar')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (5, N'Bilim ve Doğa')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (6, N'Çocuk ve Aile')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (7, N'Drama')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (8, N'Gerilim')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (9, N'Komedi')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (10, N'Korku')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (11, N'Reality Program')
INSERT [dbo].[Türler] ([Id], [Ad]) VALUES (12, N'Romantik')
SET IDENTITY_INSERT [dbo].[Türler] OFF
GO
ALTER TABLE [dbo].[KullanıcıProgram]  WITH CHECK ADD  CONSTRAINT [FK_KullanıcıProgram_Kullanıcı1] FOREIGN KEY([KullanıcıId])
REFERENCES [dbo].[Kullanıcılar] ([Id])
GO
ALTER TABLE [dbo].[KullanıcıProgram] CHECK CONSTRAINT [FK_KullanıcıProgram_Kullanıcı1]
GO
ALTER TABLE [dbo].[KullanıcıProgram]  WITH CHECK ADD  CONSTRAINT [FK_KullanıcıProgram_Programlar] FOREIGN KEY([ProgramId])
REFERENCES [dbo].[Programlar] ([Id])
GO
ALTER TABLE [dbo].[KullanıcıProgram] CHECK CONSTRAINT [FK_KullanıcıProgram_Programlar]
GO
ALTER TABLE [dbo].[ProgramTür]  WITH CHECK ADD  CONSTRAINT [FK_ProgramTür_Programlar] FOREIGN KEY([ProgramId])
REFERENCES [dbo].[Programlar] ([Id])
GO
ALTER TABLE [dbo].[ProgramTür] CHECK CONSTRAINT [FK_ProgramTür_Programlar]
GO
ALTER TABLE [dbo].[ProgramTür]  WITH CHECK ADD  CONSTRAINT [FK_ProgramTür_Türler1] FOREIGN KEY([TürId])
REFERENCES [dbo].[Türler] ([Id])
GO
ALTER TABLE [dbo].[ProgramTür] CHECK CONSTRAINT [FK_ProgramTür_Türler1]
GO
USE [master]
GO
ALTER DATABASE [Netflix] SET  READ_WRITE 
GO
