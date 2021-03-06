USE [ProvidenceFund]
GO
/****** Object:  Table [dbo].[Employee]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[Age] [int] NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (0, N'John', N'Wick', CAST(N'1421-09-02T00:00:00.0000000' AS DateTime2), 58, N'New York, USA')
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (1, N'Beyoncé', N'Knowles', CAST(N'1438-09-04T00:00:00.0000000' AS DateTime2), 41, N'Houston, Texas, U.S.')
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (2, N'Justin', N'Bieber', CAST(N'1451-03-01T00:00:00.0000000' AS DateTime2), 28, N'London, Ontario, Canada')
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (3, N'Justin', N'Timberlake', CAST(N'1438-01-31T00:00:00.0000000' AS DateTime2), 41, N'Memphis, Tennessee, U.S.')
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (4, N'Taylor', N'Swift', CAST(N'1446-12-13T00:00:00.0000000' AS DateTime2), 33, N'West Reading, Pennsylvania, U.S.')
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (5, N'Nattapat', N'Pinta', CAST(N'1456-11-22T00:00:00.0000000' AS DateTime2), 23, N'Hang Dong, Chiang Mai')
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [DateOfBirth], [Age], [Address]) VALUES (6, N'Nuttawut', N'Potisarn', CAST(N'1457-02-21T00:00:00.0000000' AS DateTime2), 22, N'Suthep, Chiang Mai')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
