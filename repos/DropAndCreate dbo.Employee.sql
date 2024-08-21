USE [Company]
GO

/****** Object: Table [dbo].[Employee] Script Date: 20-08-2024 14:23:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Employee];


GO
CREATE TABLE [dbo].[Employee] (
    [Id]           INT           NOT NULL,
    [DepartmentId] INT           NOT NULL,
    [Name]         VARCHAR (100) NOT NULL,
    [Designation]  VARCHAR (25)  NOT NULL,
	CONSTRAINT PK_Employee primary key(Id)
);


