USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Costs]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Costs](
	[CostID] [int] IDENTITY(1,1) NOT NULL,
	[CostName] [varchar](100) NULL,
	[CostDate] [datetime] NOT NULL,
	[CostAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Costs] PRIMARY KEY CLUSTERED 
(
	[CostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Costs] ON 

INSERT [dbo].[Costs] ([CostID], [CostName], [CostDate], [CostAmount]) VALUES (1, N'ÜRÜN MALİYET', CAST(N'2021-02-01 00:00:00.000' AS DateTime), CAST(55000.00 AS Decimal(18, 2)))
INSERT [dbo].[Costs] ([CostID], [CostName], [CostDate], [CostAmount]) VALUES (3, N'PERSONEL MAAŞ', CAST(N'2021-02-01 00:00:00.000' AS DateTime), CAST(25000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Costs] OFF
