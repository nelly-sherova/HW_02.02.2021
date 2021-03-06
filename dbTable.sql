USE [MyDateBase1]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 02/02/2021 22:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Сountry] [nvarchar](200) NOT NULL,
	[Сapital] [nvarchar](200) NOT NULL,
	[Population_mln] [float] NOT NULL,
	[National_Сurrency] [nvarchar](50) NOT NULL,
	[Territory] [float] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
