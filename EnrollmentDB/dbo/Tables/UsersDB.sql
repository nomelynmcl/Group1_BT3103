CREATE TABLE [dbo].[UsersDB]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [Username] VARCHAR(50) NOT NULL UNIQUE, 
    [User_password] VARCHAR(50) NOT NULL, 
    [Roles] VARCHAR(50) NULL
)
