USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[UserNAME] [varchar](30) NULL,
	[Password] [varchar](30) NULL,
	[Authority] [char](1) NULL,
 CONSTRAINT [PK_dbo.Admins] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([AdminID], [UserNAME], [Password], [Authority]) VALUES (3, N'DENEME', N'1', N'A')
INSERT [dbo].[Admins] ([AdminID], [UserNAME], [Password], [Authority]) VALUES (4, N'YASİN', N'1453', N' ')
INSERT [dbo].[Admins] ([AdminID], [UserNAME], [Password], [Authority]) VALUES (5, N'MAHMUT', N'2222', N'D')
INSERT [dbo].[Admins] ([AdminID], [UserNAME], [Password], [Authority]) VALUES (6, N'ÖMER', N'3333', N'B')
SET IDENTITY_INSERT [dbo].[Admins] OFF
