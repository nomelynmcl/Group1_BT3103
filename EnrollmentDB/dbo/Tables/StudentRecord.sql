CREATE TABLE [dbo].[StudentRecord]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL, 
    [ContactNumber] NVARCHAR(50) NOT NULL, 
    [Gender] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [GradeLevel] INT NOT NULL, 
    [Section] NVARCHAR(50) NOT NULL, 
    [EnrollmentStatus] NVARCHAR(50) NOT NULL
    
    
)
