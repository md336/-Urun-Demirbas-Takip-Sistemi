USE [demirbasKayitDB]
GO
/****** Object:  Table [dbo].[demirbaslar]    Script Date: 23.05.2024 23:09:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[demirbaslar](
	[id] [int] NOT NULL,
	[UrunKodu] [int] NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[AlanKisi] [nvarchar](50) NULL,
	[AlisTarih] [date] NULL,
	[GarantiSuresi] [int] NULL,
	[resim] [nvarchar](100) NULL
) ON [PRIMARY]
GO
