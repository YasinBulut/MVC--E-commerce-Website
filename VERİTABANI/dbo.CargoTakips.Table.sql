USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[CargoTakips]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CargoTakips](
	[CargoTakipID] [int] IDENTITY(1,1) NOT NULL,
	[TakipKodu] [varchar](10) NULL,
	[Açıklama] [varchar](100) NULL,
	[TarihZaman] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.CargoTakips] PRIMARY KEY CLUSTERED 
(
	[CargoTakipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CargoTakips] ON 

INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (1, N'1000050214', N'KARGONUZ YOLA ÇIKTI', CAST(N'2021-02-08 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (3, N'1000050211', N'KARGONUZ YOLA ÇIKTI', CAST(N'2021-02-08 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (4, N'1000050213', N'KARGONUZ YOLA ÇIKTI', CAST(N'2021-02-09 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (6, N'1000050213', N'TRANSFER MERKEZİNDE', CAST(N'2021-02-11 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (7, N'1000050213', N'ŞUBEYE GELDİ', CAST(N'2021-02-13 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (9, N'1000050213', N'DAĞITIMDA', CAST(N'2021-02-14 00:00:00.000' AS DateTime))
INSERT [dbo].[CargoTakips] ([CargoTakipID], [TakipKodu], [Açıklama], [TarihZaman]) VALUES (10, N'1000050213', N'EVDE BULUNAMADI', CAST(N'2021-02-14 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[CargoTakips] OFF
