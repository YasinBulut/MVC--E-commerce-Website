USE [DBYeterZüccaciye]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 1.03.2021 16:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentNAME] [varchar](30) NULL,
	[Status] [bit] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentID], [DepartmentNAME], [Status]) VALUES (1, N'SATIŞ ', 1)
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentNAME], [Status]) VALUES (2, N'MUHASEBE', 1)
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentNAME], [Status]) VALUES (3, N'PERSONEL', 1)
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentNAME], [Status]) VALUES (4, N'WEB DEVELOPER', 1)
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentNAME], [Status]) VALUES (5, N'SATIN ALMA', 1)
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentNAME], [Status]) VALUES (6, N'MÜDÜR', 1)
SET IDENTITY_INSERT [dbo].[Departments] OFF
