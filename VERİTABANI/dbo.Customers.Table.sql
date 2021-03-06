USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerNAME] [varchar](30) NULL,
	[CustomerUSERNAME] [varchar](30) NULL,
	[CustomerCITY] [varchar](20) NULL,
	[CustomerMAIL] [varchar](50) NULL,
	[Status] [bit] NOT NULL DEFAULT ((0)),
	[CustomerPassword] [varchar](20) NULL,
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (1, N'AYŞE', N'ÖZTÜRK', N'İSTANBUL', N'ayse_25@hotmail.com', 1, N'2')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (2, N'İBRAHİM', N'ÇAYIR', N'KARABÜK', N'icayir@outlook.com', 1, N'3333')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (3, N'ZEYNEP', N'KAYA', N'İSTANBUL', N'zeynep@outlook.com', 1, N'4')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (4, N'ASLI', N'ÇAKIR', N'ERZURUM', N'aslı@hotmail.com', 1, N'5')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (5, N'MESUT', N'ÖZİL', N'ANTALYA', N'mesut_34@hotmail.com', 1, N'6')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (6, N'AYŞE', N'AYAR', N'TRABZON', N'ayse25@outlook.com', 1, N'7')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (7, N'EMRE', N'SANCAK', N'ZONGULDAK', N'emre@hotmail.com', 1, N'8')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (8, N'SEDA', N'KOÇER', N'ERZURUM', N'seda25@hotmail.com', 1, N'9')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (9, N'RUKİYE', N'ÇELİK', N'ZONGULDAK', N'rukiye25@outlook.com', 1, N'10')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (10, N'HAVVA', N'GÖK', N'ANTALYA', N'havva@outlook.com', 1, N'11')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (11, N'KÜBRA', N'HASRET', N'ADANA', N'kubra@hotmail.com', 1, N'12')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (12, N'BEYZA', N'COŞKUN', N'ADANA', N'beyza01@hotmail.com', 1, N'13')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (19, N'MUHAMMET', N'YASİN', N'İSTANBUL', N'yasinbulut_25@outlook.com', 1, N'1111')
INSERT [dbo].[Customers] ([CustomerID], [CustomerNAME], [CustomerUSERNAME], [CustomerCITY], [CustomerMAIL], [Status], [CustomerPassword]) VALUES (20, N'EMİNE', N'ŞENGÜL', N'İSTANBUL', N'emine55@outlook.com', 1, N'14')
SET IDENTITY_INSERT [dbo].[Customers] OFF
