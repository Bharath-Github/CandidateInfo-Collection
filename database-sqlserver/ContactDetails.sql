USE [CandidateInfo]
GO

/****** Object:  Table [dbo].[ContactDetails]    Script Date: 11/06/2015 4:19:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContactDetails](
	[StreetDetails] [nvarchar](max) NOT NULL,
	[Suburb] [nvarchar](50) NOT NULL,
	[NearestRailwayStation] [nvarchar](50) NOT NULL,
	[Postcode] [nchar](4) NOT NULL,
	[PhoneNumber] [nchar](10) NOT NULL,
	[MobileNumber] [nchar](10) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


