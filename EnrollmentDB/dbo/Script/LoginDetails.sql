
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO UsersDB (Username, User_password, Roles)
VALUES ('admin', 'admin123', 'Admin'),
('cashier1', 'cashier123', 'Cashier'),
('cashier2', 'cashier456', 'Cashier'),
('registrar', 'registrar123', 'Registrar');