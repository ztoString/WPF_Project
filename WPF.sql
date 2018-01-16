USE [WPF]
GO
/****** Object:  Table [dbo].[User]    Script Date: 01/16/2018 14:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NULL,
	[Account] [nvarchar](20) NOT NULL,
	[Pwd] [nvarchar](20) NOT NULL,
	[Mobile] [nvarchar](20) NULL,
	[Mail] [nvarchar](20) NULL,
	[Memo] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([Id], [Name], [Account], [Pwd], [Mobile], [Mail], [Memo]) VALUES (1, N'zoutong             ', N'133036', N'250712', N'15030323330', N'514202874@qq.com', N'aaa')
SET IDENTITY_INSERT [dbo].[User] OFF
