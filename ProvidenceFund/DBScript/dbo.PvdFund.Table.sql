USE [ProvidenceFund]
GO
/****** Object:  Table [dbo].[PvdFund]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PvdFund](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StartWorkDate] [datetime2](7) NOT NULL,
	[Salary] [int] NOT NULL,
	[Rate] [real] NOT NULL,
 CONSTRAINT [PK_PvdFund] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PvdFund] ON 

INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (0, CAST(N'1461-03-01T00:00:00.0000000' AS DateTime2), 46000, 10)
INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (1, CAST(N'1465-09-16T00:00:00.0000000' AS DateTime2), 25000, 3)
INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (2, CAST(N'1473-12-01T00:00:00.0000000' AS DateTime2), 21000, 3)
INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (3, CAST(N'1471-01-20T00:00:00.0000000' AS DateTime2), 35000, 5)
INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (4, CAST(N'1475-05-01T00:00:00.0000000' AS DateTime2), 23000, 4)
INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (5, CAST(N'1479-05-01T00:00:00.0000000' AS DateTime2), 25000, 0)
INSERT [dbo].[PvdFund] ([Id], [StartWorkDate], [Salary], [Rate]) VALUES (6, CAST(N'1479-01-02T00:00:00.0000000' AS DateTime2), 20000, 0)
SET IDENTITY_INSERT [dbo].[PvdFund] OFF
GO
