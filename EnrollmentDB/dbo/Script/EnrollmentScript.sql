
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

--login credentials
INSERT INTO UsersDB (Username, User_password, Roles)
VALUES ('admin', 'admin123', 'Admin'),
('cashier1', 'cashier123', 'Cashier'),
('cashier2', 'cashier456', 'Cashier'),
('registrar', 'registrar123', 'Registrar');

--studentRecords
--grade 7

INSERT INTO [dbo].[StudentRecord]
(LastName, FirstName, MiddleName, GradeLevel, Section, ContactNumber, Gender, Address, EnrollmentStatus)
VALUES
('Cruz', 'Juan', 'Santos', 7, 'Sirius', '091712345501', 'Male', 'Quezon City', 'Enrolled'),
('Reyes', 'Maria', 'Lopez', 7, 'Sirius', '09181234502', 'Female', 'Manila', 'Enrolled'),
('Garcia', 'Jose', 'Torres', 7, 'Sirius', '09191234503', 'Male', 'Cebu City', 'Enrolled'),
('Santos', 'Ana', 'Villanueva', 7, 'Sirius', '09201234504', 'Female', 'Davao City', 'Enrolled'),
('Torres', 'Mark', 'San', 7, 'Sirius', '091712345501', 'Male', 'Quezon City', 'Enrolled'),
('Villanueva', 'Ella', 'Cruz', 7, 'Sirius', '091712345567', 'Female', 'Calaca City', 'Enrolled'),
('Lopez', 'Kevin', 'Reyes', 7, 'Sirius', '09231123505', 'Male', 'Caloocan City', 'Enrolled'),
('Dela Cruz', 'Liza', 'Martinez', 7, 'Sirius', '09241234508', 'Female', 'Baguio City', 'Enrolled'),
('Fernandez', 'Daniel', 'Domingo', 7, 'Sirius', '09251234509', 'Male', 'Antipolo City', 'Enrolled'),
('Bautista', 'Sofia', 'Aquino', 7, 'Sirius', '09261234510', 'Female', 'Calaca City', 'Enrolled'),
('Aquino', 'Miguel', 'Castillo', 7, 'Sirius', '09281234512', 'Male', 'Calaca City', 'Enrolled'),
('Mendoza', 'Jasmine', 'Garcia', 7, 'Sirius', '09281234512', 'Female', 'Balayan', 'Enrolled'),
('Domingo', 'Grace', 'Jiminez', 8, 'Polaris', '09301234513', 'Female', 'Velenzuela City', 'Enrolled'),
('Gonzales', 'Josh', 'Serrano', 8, 'Polaris', '09311234514', 'Male', 'San Fernando Pampanga', 'Enrolled'),
('Serrano', 'Hannah', 'Cortez', 8, 'Polaris', '09321234515', 'Female', 'Lucena City', 'Enrolled'),
('Ramos', 'Nathan', 'Ortiz', 8, 'Polaris', '09331234516', 'Male', 'Batangas City', 'Enrolled'),
('Rivera', 'Isabella', 'Navarro', 8, 'Polaris', '09341234517', 'Female', 'Legazpi City', 'Enrolled'),
('Perez', 'Christian', 'Diaz', 8, 'Polaris', '09351234518', 'Male', 'Iloilo City', 'Enrolled'),
('Martinez', 'Angela', 'Santiago', 8, 'Polaris', '09361234519', 'Female', 'General Santos City', 'Enrolled'),
('Ortiz', 'David', 'Vergara', 8, 'Polaris', '09371234520', 'Male', 'Zamboanga City', 'Enrolled'),
('Navarro', 'Chloe', 'Aguilar', 8, 'Polaris', '09381234521', 'Female', 'Mabalacat, Pampanga', 'Enrolled'),
('Jimenez', 'Ryan', 'Dominguez', 8, 'Polaris', '09391234522', 'Male', 'Olongapo City', 'Enrolled'),
('Flores', 'Leah', 'Alvarez', 8, 'Polaris', '09401234523', 'Female', 'Santa Rosa, Laguna', 'Enrolled'),
('Diaz', 'Samuel', 'Roxas', 8, 'Polaris', '09411234524', 'Male', 'Cabanatuan City', 'Enrolled'),
('Gomez', 'Victoria', 'Valdez', 9, 'Phoenix', '09421234525', 'Female', 'Dagupan City', 'Enrolled'),
('Castro', 'Matthew', 'De Guzman', 9, 'Phoenix', '09431234526', 'Male', 'Tarlac City', 'Enrolled'),
('Hernandez', 'Camille', 'Ferrer', 9, 'Phoenix', '09441234527', 'Female', 'Naga City', 'Enrolled'),
('Villamor', 'Ethan', 'Del Rosario', 9, 'Phoenix', '09451234528', 'Male', 'Butuan City', 'Enrolled'),
('Del Rosario', 'Nicole', 'Padilla', 9, 'Phoenix', '09461234529', 'Female', 'Dumaguete City', 'Enrolled'),
('Santiago', 'Lucas', 'Salazar', 9, 'Phoenix', '09471234530', 'Male', 'Tacloban City', 'Enrolled'),
('Vergara', 'Samantha', 'Agustin', 9, 'Phoenix', '09481234531', 'Female', 'Cavite City', 'Enrolled'),
('Cabrera', 'Kyle', 'Magsaysay', 9, 'Phoenix', '09491234532', 'Male', 'Angeles City', 'Enrolled'),
('Padilla', 'Bea', 'Reyes', 9, 'Phoenix', '09501234533', 'Female', 'Lipa City', 'Enrolled'),
('Salazar', 'Gabriel', 'Torres', 9, 'Phoenix', '09511234534', 'Male', 'San Jose del Monte', 'Enrolled'),
('Aguilar', 'Andrea', 'Garcia', 9, 'Phoenix', '09521234535', 'Female', 'Cavite City', 'Enrolled'),
('Dominguez', 'Justin', 'Santos', 9, 'Phoenix', '09531234536', 'Male', 'Malolos, Bulacan', 'Enrolled'),
('Ferrer', 'Julia', 'Cruz', 9, 'Phoenix', '09541234537', 'Female', 'San Fernando, La Union', 'Enrolled'),
('Alvarez', 'Kyla', 'Lopez', 10, 'Pegasus', '09551234538', 'Female', 'Imus, Cavite', 'Enrolled'),
('Roxas', 'Jerome', 'Fernandez', 10, 'Pegasus', '09561234539', 'Male', 'San Pedro, Laguna', 'Enrolled'),
('Valdez', 'Trisha', 'Santos', 10, 'Pegasus', '09571234540', 'Female', 'Meycauayan, Bulacan', 'Enrolled'),
('De Guzman', 'Andre', 'Castillo', 10, 'Pegasis', '09581234541', 'Male', 'Marikina City', 'Enrolled'),
('Agustin', 'Bianca', 'Martinez', 10, 'Pegasus', '09591234542', 'Female', 'Binan, Laguna', 'Enrolled'),
('Manalo', 'Francis', 'Reyes', 10, 'Pegasus', '09601234543', 'Male', 'Trece Martires, Cavite', 'Enrolled'),
('Santiago', 'Clarisse', 'Rivera', 10, 'Pegasus', '09611234544', 'Female', 'Tanauan City', 'Enrolled'),
('Pascual', 'Darren', 'Domingo', 10, 'Pegasus', '09621234545', 'Male', 'San Mateo, Rizal', 'Enrolled'),
('Reyes', 'Paula', 'Villanueva', 10, 'Pegasus', '09631234546', 'Female', 'Muntinlupa City', 'Enrolled'),
('Soriano', 'Nathaniel', 'Torres', 10, 'Pegasus', '09641234547', 'Male', 'Dasmariñas, Cavite', 'Enrolled'),
('Delos Santos', 'Mae', 'Aquino', 10, 'Pegasus', '09651234548', 'Female', 'Santa Maria, Bulacan', 'Enrolled'),
('Cortez', 'Leo', 'Jimenez', 10, 'Pegasus', '09661234549', 'Male', 'Navotas City', 'Enrolled'),
('Ferrer', 'Althea', 'Lopez', 10, 'Pegasus', '09671234550', 'Female', 'Malabon City', 'Enrolled');
