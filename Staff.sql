USE [Staff]
GO

/****** Object:  Table [dbo].[goods]    Script Date: 11/07/2017 19:31:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[goods](
	[GoodId] [int] IDENTITY(1,1) NOT NULL,
	[GoodName] [nvarchar](max) NULL,
	[GoodCategory] [nvarchar](max) NULL,
	[GoodCount] [int] NOT NULL,
	[GoodDescription] [nvarchar](max) NULL,
	[GoodPicture] [nvarchar](max) NULL,
	[GoodPrice] [int] NOT NULL,
 CONSTRAINT [PK_dbo.goods] PRIMARY KEY CLUSTERED 
(
	[GoodId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

