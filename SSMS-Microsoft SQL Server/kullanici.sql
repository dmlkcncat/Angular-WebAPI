USE [LinkOlustur]
GO

/****** Object:  Table [dbo].[Kullanici]    Script Date: 8.08.2021 11:17:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kullanici](
	[KullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nchar](40) NOT NULL,
	[Soyad] [nchar](40) NOT NULL,
	[Mail] [nchar](40) NOT NULL,
	[Tel] [nchar](40) NOT NULL,
	[OdenecekTutar] [nchar](40) NOT NULL,
	[ParaBirimi] [nchar](40) NOT NULL,
	[Aciklama] [nchar](40) NULL,
	[Guid] [uniqueidentifier] SPARSE  NULL,
 CONSTRAINT [PK_Kullanicis] PRIMARY KEY CLUSTERED 
(
	[KullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

