USE [CandidateInfo]
GO

/****** Object:  Table [dbo].[CareerDetails]    Script Date: 11/06/2015 4:19:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CareerDetails](
	[RecentJobRole] [nvarchar](50) NOT NULL,
	[DurationYears] [nchar](2) NOT NULL,
	[DurationMonths] [nchar](2) NOT NULL,
	[StillInCurrentRole] [bit] NOT NULL,
	[Resume] [nvarchar](max) NOT NULL,
	[CoverLetter] [nvarchar](max) NOT NULL,
	[IsPrivacyDetailsAccepted] [bit] NOT NULL,
	[IsDeclarationChecked] [bit] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CareeerDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


