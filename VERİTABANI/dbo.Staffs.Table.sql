USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Staffs](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAD] [varchar](30) NULL,
	[PersonelUSERNAME] [varchar](30) NULL,
	[PersonelIMAGE] [varchar](250) NULL,
	[DepartmentID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Staffs] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([PersonelID], [PersonelAD], [PersonelUSERNAME], [PersonelIMAGE], [DepartmentID]) VALUES (1, N'MAHMUT', N'YETER', N'https://www.kurulumyap.com/resimler/243/parsanda-personel-takip-programi-icon.jpg', 1)
INSERT [dbo].[Staffs] ([PersonelID], [PersonelAD], [PersonelUSERNAME], [PersonelIMAGE], [DepartmentID]) VALUES (2, N'ALİ', N'YETER', N'https://www.kurulumyap.com/resimler/243/parsanda-personel-takip-programi-icon.jpg', 3)
INSERT [dbo].[Staffs] ([PersonelID], [PersonelAD], [PersonelUSERNAME], [PersonelIMAGE], [DepartmentID]) VALUES (3, N'YASİN', N'BULUT', N'https://www.kurulumyap.com/resimler/243/parsanda-personel-takip-programi-icon.jpg', 4)
INSERT [dbo].[Staffs] ([PersonelID], [PersonelAD], [PersonelUSERNAME], [PersonelIMAGE], [DepartmentID]) VALUES (4, N'ÖMER', N'YETER', N'https://www.kurulumyap.com/resimler/243/parsanda-personel-takip-programi-icon.jpg', 6)
INSERT [dbo].[Staffs] ([PersonelID], [PersonelAD], [PersonelUSERNAME], [PersonelIMAGE], [DepartmentID]) VALUES (5, N'AHMET', N'KAYA', N'https://www.kurulumyap.com/resimler/243/parsanda-personel-takip-programi-icon.jpg', 5)
SET IDENTITY_INSERT [dbo].[Staffs] OFF
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Staffs_dbo.Departments_DepartmentID] FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Departments] ([DepartmentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [FK_dbo.Staffs_dbo.Departments_DepartmentID]
GO
