USE [LinkOlustur]
GO

/****** Object:  Table [dbo].[Link]    Script Date: 8.08.2021 11:18:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Link](
	[LinkId] [int] IDENTITY(1,1) NOT NULL,
	[OlusturmaTarihi] [date] NOT NULL,
	[OdemeLinki] [nchar](250) NOT NULL,
	[LinkGecerlilikTarihi] [date] NOT NULL,
	[KullaniciId] [int] NOT NULL,
 CONSTRAINT [PK_Links] PRIMARY KEY CLUSTERED 
(
	[LinkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Link]  WITH CHECK ADD  CONSTRAINT [FK_Links_Kullanici] FOREIGN KEY([KullaniciId])
REFERENCES [dbo].[Kullanici] ([KullaniciId])
GO

ALTER TABLE [dbo].[Link] CHECK CONSTRAINT [FK_Links_Kullanici]
GO

