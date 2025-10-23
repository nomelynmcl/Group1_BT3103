CREATE TABLE [dbo].[StudentRecord]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL, 
    [ContactNumber] NVARCHAR(50) NOT NULL, 
    [Gender] NVARCHAR(50) NOT NULL, 
    [GradeLevel] INT NOT NULL, 
    [Section] NVARCHAR(50) NOT NULL, 
    [EnrollmentStatus] NVARCHAR(50) NOT NULL, 
    [Barangay] NVARCHAR(50) NOT NULL, 
    [Municipality] NVARCHAR(50) NOT NULL, 
    [Province] NVARCHAR(50) NOT NULL, 
    [Birthdate] DATETIME NOT NULL, 
    [Age] INT NOT NULL, 
    [GuardianName] NVARCHAR(50) NOT NULL, 
    [GuardianContact] NVARCHAR(50) NOT NULL, 
    [StudentType] NVARCHAR(50) NOT NULL, 
    [Requirements] NVARCHAR(50) NULL, 
    [ModeOfPayment] NVARCHAR(50) NULL
    
    
)
