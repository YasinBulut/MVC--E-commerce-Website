USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[CargoDetays]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CargoDetays](
	[CargoExplanationID] [nvarchar](128) NOT NULL,
	[CargoExplanation] [varchar](250) NULL,
	[TakipKodu] [varchar](10) NULL,
	[Personel] [varchar](20) NULL,
	[Alici] [varchar](20) NULL,
	[Tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.CargoDetays] PRIMARY KEY CLUSTERED 
(
	[CargoExplanationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CargoDetays] ([CargoExplanationID], [CargoExplanation], [TakipKodu], [Personel], [Alici], [Tarih]) VALUES (N'1', N'1 ADET', N'1000050211', N'YASİN BULUT', N'İBRAHİM ÇAYIROĞLU', CAST(N'2021-02-08 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoDetays] ([CargoExplanationID], [CargoExplanation], [TakipKodu], [Personel], [Alici], [Tarih]) VALUES (N'2', N'1 ADET', N'1000050213', N'YASİN BULUT', N'İBRAHİM ÇAYIROĞLU', CAST(N'2021-02-09 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoDetays] ([CargoExplanationID], [CargoExplanation], [TakipKodu], [Personel], [Alici], [Tarih]) VALUES (N'3', N'1 ADET', N'1000050212', N'AYŞE ÖZTÜRK', N'MAHMUT YETER', CAST(N'2021-02-09 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoDetays] ([CargoExplanationID], [CargoExplanation], [TakipKodu], [Personel], [Alici], [Tarih]) VALUES (N'4', N'2 ADET', N'1000050214', N'AYŞE AYAR', N'MAHMUT YETER', CAST(N'2021-02-09 00:00:00.000' AS DateTime))
