CREATE TABLE [dbo].[Users]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[FirstName] NVARCHAR(50) NOT NULL, 
	[LastName] NVARCHAR(50) NOT NULL, 
	[Username] NVARCHAR(50) NOT NULL, 
	[Password] NVARCHAR(50) NULL
)
GO

CREATE TABLE [dbo].Projects
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Name] NVARCHAR(100) NOT NULL, 
	[Description] NVARCHAR(MAX) NULL, 
	[OwnerId] UNIQUEIDENTIFIER NOT NULL,
	[IconId] INT NULL
)
GO 

CREATE TABLE [dbo].[Categories]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Name] NVARCHAR(50) NOT NULL,
	[OwnerId] UNIQUEIDENTIFIER NOT NULL
)
GO 

CREATE TABLE [dbo].[Folders]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[ParentItemId] UNIQUEIDENTIFIER NOT NULL, 
	[CategoryId] UNIQUEIDENTIFIER NULL, 
	[Type] INT NOT NULL, 
	[OwnerId] UNIQUEIDENTIFIER NOT NULL
)
GO 

CREATE TABLE [dbo].Article
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[ParentItemId] UNIQUEIDENTIFIER NOT NULL, 
	[CategoryId] UNIQUEIDENTIFIER NULL, 
	[OwnerId] UNIQUEIDENTIFIER NOT NULL,
	[Text] NVARCHAR(MAX) NOT NULL, 
	[CreatedOn] DATETIME NOT NULL,
	[IconId] INT NULL
)
GO 

CREATE TABLE [dbo].Icons
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[Code] NVARCHAR(50) NOT NULL 
)
GO 