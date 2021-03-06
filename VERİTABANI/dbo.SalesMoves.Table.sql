USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[SalesMoves]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesMoves](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[SalesDate] [datetime] NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
 CONSTRAINT [PK_SalesMoves] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SalesMoves] ON 

INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (2, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 1, 1, 1)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (3, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(125.00 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), 2, 9, 3)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (4, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 2, CAST(175.00 AS Decimal(18, 2)), CAST(350.00 AS Decimal(18, 2)), 3, 17, 1)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (5, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(170.00 AS Decimal(18, 2)), CAST(170.00 AS Decimal(18, 2)), 4, 44, 2)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (6, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(185.00 AS Decimal(18, 2)), CAST(185.00 AS Decimal(18, 2)), 5, 52, 2)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (10, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(85.00 AS Decimal(18, 2)), CAST(85.00 AS Decimal(18, 2)), 6, 56, 2)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (11, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(270.00 AS Decimal(18, 2)), CAST(270.00 AS Decimal(18, 2)), 7, 47, 3)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (12, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 2, CAST(120.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)), 8, 55, 4)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (13, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 3, CAST(165.00 AS Decimal(18, 2)), CAST(165.00 AS Decimal(18, 2)), 1, 78, 4)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (15, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(350.00 AS Decimal(18, 2)), CAST(350.00 AS Decimal(18, 2)), 2, 71, 3)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (16, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 4, 51, 1)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (18, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(250.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), 5, 36, 1)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (19, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(125.00 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), 6, 9, 2)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (21, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 4, CAST(35.00 AS Decimal(18, 2)), CAST(140.00 AS Decimal(18, 2)), 6, 5, 2)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (22, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(170.00 AS Decimal(18, 2)), CAST(170.00 AS Decimal(18, 2)), 5, 12, 2)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (24, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(65.00 AS Decimal(18, 2)), CAST(65.00 AS Decimal(18, 2)), 2, 1, 3)
INSERT [dbo].[SalesMoves] ([SalesID], [SalesDate], [Amount], [Price], [Total], [CustomerId], [ProductID], [PersonelID]) VALUES (25, CAST(N'2021-02-07 00:00:00.000' AS DateTime), 1, CAST(175.00 AS Decimal(18, 2)), CAST(175.00 AS Decimal(18, 2)), 1, 17, 4)
SET IDENTITY_INSERT [dbo].[SalesMoves] OFF
ALTER TABLE [dbo].[SalesMoves]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SalesMoves_dbo.Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalesMoves] CHECK CONSTRAINT [FK_dbo.SalesMoves_dbo.Customers_CustomerId]
GO
ALTER TABLE [dbo].[SalesMoves]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SalesMoves_dbo.Staffs_PersonelID] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Staffs] ([PersonelID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalesMoves] CHECK CONSTRAINT [FK_dbo.SalesMoves_dbo.Staffs_PersonelID]
GO
