USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Yapilacaks]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Yapilacaks](
	[YapılacakID] [int] IDENTITY(1,1) NOT NULL,
	[Baslik] [varchar](100) NULL,
	[Durum] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Yapilacaks] PRIMARY KEY CLUSTERED 
(
	[YapılacakID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Yapilacaks] ON 

INSERT [dbo].[Yapilacaks] ([YapılacakID], [Baslik], [Durum]) VALUES (2, N'SABAH SİPARİŞ LİSTESİNİ KONTROL ET', 1)
INSERT [dbo].[Yapilacaks] ([YapılacakID], [Baslik], [Durum]) VALUES (3, N'GÜNLÜK KARGO TAKİPLERİNİ YAP', 1)
INSERT [dbo].[Yapilacaks] ([YapılacakID], [Baslik], [Durum]) VALUES (4, N'ÜRÜN FİYAT GÜNCELLEMELERİNİ KONTROL ET', 1)
SET IDENTITY_INSERT [dbo].[Yapilacaks] OFF
