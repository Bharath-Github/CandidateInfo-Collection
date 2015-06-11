USE [CandidateInfo]
GO

/****** Object:  Table [dbo].[EducationDetails]    Script Date: 11/06/2015 4:19:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EducationDetails](
	[HighestQualification] [nvarchar](50) NOT NULL,
	[GroupCategory] [nchar](10) NOT NULL,
	[YearOfCompletion] [date] NOT NULL,
	[UniversityDetails] [nvarchar](50) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_EducationDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


