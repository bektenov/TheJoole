USE [master]
GO
ALTER DATABASE [JooleDatabase] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JooleDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
USE [JooleDatabase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [JooleDatabase]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 9/12/2021 11:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Category_Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Category_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 9/12/2021 11:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TABLE [dbo].[Product](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[SubCategory_Id] [int] NOT NULL,
	[Product_Name] [varchar](50) NOT NULL,
	[Product_Image] [varchar](255) NOT NULL,
	[Series] [varchar](100) NOT NULL,
	[Model] [varchar](100) NOT NULL,
	[Model_Year] [varchar](50) NOT NULL,
	[Series_Info] [varchar](255) NOT NULL,
	[Featured] [varchar](255) NOT NULL,
	[UseType] [varchar](100) NULL,
	[Application] [varchar](100) NULL,
	[Mount] [varchar](100) NULL,
	[Accessories] [varchar](100) NULL,
	[AirFlow] [varchar](100) NULL,
	[MinPower] [varchar](100) NULL,
	[MaxPower] [varchar](100) NULL,
	[MinVolt] [varchar](100) NULL,
	[MaxVolt] [varchar](100) NULL,
	[MinRPM] [varchar](100) NULL,
	[MaxRPM] [varchar](100) NULL,
	[Speeds] [varchar](100) NULL,
	[Sound] [varchar](100) NULL,
	[Sweep] [varchar](100) NULL,
	[MinHeight] [varchar](100) NULL,
	[MaxHeight] [varchar](100) NULL,
	[Weight] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 9/12/2021 11:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Project_Id] [int] IDENTITY(1,1) NOT NULL,
	[Project_Name] [varchar](255) NOT NULL,
	[Project_Address] [varchar](255) NOT NULL,
	[Project_City] [varchar](50) NOT NULL,
	[Project_State] [varchar](50) NOT NULL,
	[Project_Size] [int] NOT NULL,
	[User_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Project_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjtoProd]    Script Date: 9/12/2021 11:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjtoProd](
	[Project_Id] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 9/12/2021 11:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategory](
	[SubCategory_Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_Id] [int] NOT NULL,
	[SubCategory_Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubCategory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9/12/2021 11:57:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [varchar](255) NOT NULL,
	[User_Email] [varchar](50) NOT NULL,
	[User_Image] [varbinary](max) NOT NULL,
	[User_Password] [varchar](255) NOT NULL,
	[Confirm_Password] [varchar](255) NULL,
	[LoginErrorMessage] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [Product_fk0] FOREIGN KEY([SubCategory_Id])
REFERENCES [dbo].[SubCategory] ([SubCategory_Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [Product_fk0]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [Project_fk0] FOREIGN KEY([User_Id])
REFERENCES [dbo].[Users] ([User_Id])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [Project_fk0]
GO
ALTER TABLE [dbo].[ProjtoProd]  WITH CHECK ADD  CONSTRAINT [Product_IDConstraint] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Product] ([Product_Id])
GO
ALTER TABLE [dbo].[ProjtoProd] CHECK CONSTRAINT [Product_IDConstraint]
GO
ALTER TABLE [dbo].[ProjtoProd]  WITH CHECK ADD  CONSTRAINT [Project_IDConstraint] FOREIGN KEY([Project_Id])
REFERENCES [dbo].[Project] ([Project_Id])
GO
ALTER TABLE [dbo].[ProjtoProd] CHECK CONSTRAINT [Project_IDConstraint]
GO
ALTER TABLE [dbo].[SubCategory]  WITH CHECK ADD  CONSTRAINT [SubCategory_fk0] FOREIGN KEY([Category_Id])
REFERENCES [dbo].[Category] ([Category_Id])
GO
ALTER TABLE [dbo].[SubCategory] CHECK CONSTRAINT [SubCategory_fk0]
GO
USE [master]
GO
ALTER DATABASE [JooleDatabase] SET  READ_WRITE 
GO
