
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
(LastName, FirstName, MiddleName, GradeLevel, Section, ContactNumber, Gender, Age, Birthdate, Barangay, Municipality, Province,GuardianName, GuardianContact, StudentType, EnrollmentStatus)
VALUES
-- Grade 7 (New Students)
('Cruz', 'Juan', 'Santos', 7, 'Sirius', '091712345501', 'Male', 13, '2012-05-14', 'San Isidro', 'Quezon City', 'Metro Manila', 'Pedro Cruz', '09181234501', 'New Student', 'Enrolled'),
('Reyes', 'Maria', 'Lopez', 7, 'Sirius', '09181234502', 'Female', 13, '2012-03-21', 'San Jose', 'Manila', 'Metro Manila', 'Ana Reyes', '09181234502', 'New Student', 'Enrolled'),
('Garcia', 'Jose', 'Torres', 7, 'Sirius', '09191234503', 'Male', 13, '2012-06-12', 'Poblacion', 'Cebu City', 'Cebu', 'Carlos Garcia', '09191234503', 'New Student', 'Enrolled'),
('Santos', 'Ana', 'Villanueva', 7, 'Sirius', '09201234504', 'Female', 13, '2012-04-05', 'San Miguel', 'Davao City', 'Davao del Sur', 'Liza Santos', '09201234504', 'New Student', 'Enrolled'),
('Torres', 'Mark', 'San', 7, 'Sirius', '091712345501', 'Male', 13, '2012-07-18', 'Barangay 1', 'Quezon City', 'Metro Manila', 'Mario Torres', '09171234550', 'New Student', 'Enrolled'),
('Villanueva', 'Ella', 'Cruz', 7, 'Sirius', '091712345567', 'Female', 13, '2012-08-09', 'Barangay 2', 'Calaca City', 'Batangas', 'Rose Villanueva', '09171234567', 'New Student', 'Enrolled'),
('Lopez', 'Kevin', 'Reyes', 7, 'Sirius', '09231123505', 'Male', 13, '2012-09-11', 'Barangay 3', 'Caloocan City', 'Metro Manila', 'Teresita Lopez', '09231123505', 'New Student', 'Enrolled'),
('Dela Cruz', 'Liza', 'Martinez', 7, 'Sirius', '09241234508', 'Female', 13, '2012-10-22', 'Barangay 4', 'Baguio City', 'Benguet', 'Andres Dela Cruz', '09241234508', 'New Student', 'Enrolled'),
('Fernandez', 'Daniel', 'Domingo', 7, 'Sirius', '09251234509', 'Male', 13, '2012-12-03', 'Barangay 5', 'Antipolo City', 'Rizal', 'Raul Fernandez', '09251234509', 'New Student', 'Enrolled'),
('Bautista', 'Sofia', 'Aquino', 7, 'Sirius', '09261234510', 'Female', 13, '2012-11-17', 'Barangay 6', 'Calaca City', 'Batangas', 'Marites Bautista', '09261234510', 'New Student', 'Enrolled'),
('Aquino', 'Miguel', 'Castillo', 7, 'Sirius', '09281234512', 'Male', 13, '2012-01-23', 'Barangay 7', 'Calaca City', 'Batangas', 'Roberto Aquino', '09281234512', 'New Student', 'Enrolled'),
('Mendoza', 'Jasmine', 'Garcia', 7, 'Sirius', '09281234512', 'Female', 13, '2012-02-18', 'Barangay 8', 'Balayan', 'Batangas', 'Ellen Mendoza', '09281234512', 'New Student', 'Enrolled'),

-- Grade 8 (Old Students / Transferees)
('Domingo', 'Grace', 'Jiminez', 8, 'Polaris', '09301234513', 'Female', 14, '2011-07-01', 'Barangay A', 'Valenzuela City', 'Metro Manila', 'Ana Domingo', '09301234513', 'Old Student', 'Enrolled'),
('Gonzales', 'Josh', 'Serrano', 8, 'Polaris', '09311234514', 'Male', 14, '2011-09-02', 'Barangay B', 'San Fernando', 'Pampanga', 'Rene Gonzales', '09311234514', 'Old Student', 'Enrolled'),
('Serrano', 'Hannah', 'Cortez', 8, 'Polaris', '09321234515', 'Female', 14, '2011-05-08', 'Barangay C', 'Lucena City', 'Quezon', 'Grace Serrano', '09321234515', 'Old Student', 'Enrolled'),
('Ramos', 'Nathan', 'Ortiz', 8, 'Polaris', '09331234516', 'Male', 14, '2011-11-18', 'Barangay D', 'Batangas City', 'Batangas', 'Mario Ramos', '09331234516', 'Old Student', 'Enrolled'),
('Rivera', 'Isabella', 'Navarro', 8, 'Polaris', '09341234517', 'Female', 14, '2011-02-15', 'Barangay E', 'Legazpi City', 'Albay', 'Elena Rivera', '09341234517', 'Old Student', 'Enrolled'),
('Perez', 'Christian', 'Diaz', 8, 'Polaris', '09351234518', 'Male', 14, '2011-04-20', 'Barangay F', 'Iloilo City', 'Iloilo', 'Maria Perez', '09351234518', 'Transferee', 'Enrolled'),
('Martinez', 'Angela', 'Santiago', 8, 'Polaris', '09361234519', 'Female', 14, '2011-01-05', 'Barangay G', 'General Santos City', 'South Cotabato', 'Jose Martinez', '09361234519', 'Old Student', 'Enrolled'),
('Ortiz', 'David', 'Vergara', 8, 'Polaris', '09371234520', 'Male', 14, '2011-03-22', 'Barangay H', 'Zamboanga City', 'Zamboanga', 'Lourdes Ortiz', '09371234520', 'Old Student', 'Enrolled'),
('Navarro', 'Chloe', 'Aguilar', 8, 'Polaris', '09381234521', 'Female', 14, '2011-06-09', 'Barangay I', 'Mabalacat', 'Pampanga', 'Juan Navarro', '09381234521', 'Transferee', 'Enrolled'),
('Jimenez', 'Ryan', 'Dominguez', 8, 'Polaris', '09391234522', 'Male', 14, '2011-08-30', 'Barangay J', 'Olongapo City', 'Zambales', 'Rosa Jimenez', '09391234522', 'Old Student', 'Enrolled'),
('Flores', 'Leah', 'Alvarez', 8, 'Polaris', '09401234523', 'Female', 14, '2011-10-10', 'Barangay K', 'Santa Rosa', 'Laguna', 'Ellen Flores', '09401234523', 'Old Student', 'Enrolled'),
('Diaz', 'Samuel', 'Roxas', 8, 'Polaris', '09411234524', 'Male', 14, '2011-12-05', 'Barangay L', 'Cabanatuan City', 'Nueva Ecija', 'Mario Diaz', '09411234524', 'Old Student', 'Enrolled'),

-- Grade 9 (Old Students)
('Gomez', 'Victoria', 'Valdez', 9, 'Phoenix', '09421234525', 'Female', 15, '2010-05-02', 'Barangay 1', 'Dagupan City', 'Pangasinan', 'Eva Gomez', '09421234525', 'Old Student', 'Enrolled'),
('Castro', 'Matthew', 'De Guzman', 9, 'Phoenix', '09431234526', 'Male', 15, '2010-03-11', 'Barangay 2', 'Tarlac City', 'Tarlac', 'Rico Castro', '09431234526', 'Old Student', 'Enrolled'),
('Hernandez', 'Camille', 'Ferrer', 9, 'Phoenix', '09441234527', 'Female', 15, '2010-01-15', 'Barangay 3', 'Naga City', 'Camarines Sur', 'Liza Hernandez', '09441234527', 'Old Student', 'Enrolled'),
('Villamor', 'Ethan', 'Del Rosario', 9, 'Phoenix', '09451234528', 'Male', 15, '2010-02-07', 'Barangay 4', 'Butuan City', 'Agusan del Norte', 'Lorenzo Villamor', '09451234528', 'Old Student', 'Enrolled'),
('Del Rosario', 'Nicole', 'Padilla', 9, 'Phoenix', '09461234529', 'Female', 15, '2010-06-06', 'Barangay 5', 'Dumaguete City', 'Negros Oriental', 'Jose Del Rosario', '09461234529', 'Old Student', 'Enrolled'),
('Santiago', 'Lucas', 'Salazar', 9, 'Phoenix', '09471234530', 'Male', 15, '2010-04-30', 'Barangay 6', 'Tacloban City', 'Leyte', 'Amelia Santiago', '09471234530', 'Old Student', 'Enrolled'),
('Vergara', 'Samantha', 'Agustin', 9, 'Phoenix', '09481234531', 'Female', 15, '2010-09-13', 'Barangay 7', 'Cavite City', 'Cavite', 'Marites Vergara', '09481234531', 'Old Student', 'Enrolled'),
('Cabrera', 'Kyle', 'Magsaysay', 9, 'Phoenix', '09491234532', 'Male', 15, '2010-11-20', 'Barangay 8', 'Angeles City', 'Pampanga', 'Pedro Cabrera', '09491234532', 'Old Student', 'Enrolled'),
('Padilla', 'Bea', 'Reyes', 9, 'Phoenix', '09501234533', 'Female', 15, '2010-07-09', 'Barangay 9', 'Lipa City', 'Batangas', 'Belen Padilla', '09501234533', 'Old Student', 'Enrolled'),
('Salazar', 'Gabriel', 'Torres', 9, 'Phoenix', '09511234534', 'Male', 15, '2010-08-01', 'Barangay 10', 'San Jose del Monte', 'Bulacan', 'Rico Salazar', '09511234534', 'Old Student', 'Enrolled'),
('Aguilar', 'Andrea', 'Garcia', 9, 'Phoenix', '09521234535', 'Female', 15, '2010-10-19', 'Barangay 11', 'Cavite City', 'Cavite', 'Mario Aguilar', '09521234535', 'Old Student', 'Enrolled'),
('Dominguez', 'Justin', 'Santos', 9, 'Phoenix', '09531234536', 'Male', 15, '2010-12-25', 'Barangay 12', 'Malolos', 'Bulacan', 'Liza Dominguez', '09531234536', 'Old Student', 'Enrolled'),
('Ferrer', 'Julia', 'Cruz', 9, 'Phoenix', '09541234537', 'Female', 15, '2010-03-08', 'Barangay 13', 'San Fernando', 'La Union', 'Jose Ferrer', '09541234537', 'Old Student', 'Enrolled'),

-- Grade 10 (Old Students / Transferees)
('Alvarez', 'Kyla', 'Lopez', 10, 'Pegasus', '09551234538', 'Female', 16, '2009-09-05', 'Barangay A', 'Imus', 'Cavite', 'Ramon Alvarez', '09551234538', 'Old Student', 'Enrolled'),
('Roxas', 'Jerome', 'Fernandez', 10, 'Pegasus', '09561234539', 'Male', 16, '2009-06-23', 'Barangay B', 'San Pedro', 'Laguna', 'Lina Roxas', '09561234539', 'Old Student', 'Enrolled'),
('Valdez', 'Trisha', 'Santos', 10, 'Pegasus', '09571234540', 'Female', 16, '2009-03-14', 'Barangay C', 'Meycauayan', 'Bulacan', 'Ana Valdez', '09571234540', 'Old Student', 'Enrolled'),
('De Guzman', 'Andre', 'Castillo', 10, 'Pegasus', '09581234541', 'Male', 16, '2009-12-09', 'Barangay D', 'Marikina City', 'Metro Manila', 'Mario De Guzman', '09581234541', 'Transferee', 'Enrolled'),
('Agustin', 'Bianca', 'Martinez', 10, 'Pegasus', '09591234542', 'Female', 16, '2009-11-20', 'Barangay E', 'Binan', 'Laguna', 'Helen Agustin', '09591234542', 'Old Student', 'Enrolled'),
('Manalo', 'Francis', 'Reyes', 10, 'Pegasus', '09601234543', 'Male', 16, '2009-01-08', 'Barangay F', 'Trece Martires', 'Cavite', 'Rey Manalo', '09601234543', 'Old Student', 'Enrolled'),
('Santiago', 'Clarisse', 'Rivera', 10, 'Pegasus', '09611234544', 'Female', 16, '2009-02-11', 'Barangay G', 'Tanauan City', 'Batangas', 'Cesar Santiago', '09611234544', 'Old Student', 'Enrolled'),
('Pascual', 'Darren', 'Domingo', 10, 'Pegasus', '09621234545', 'Male', 16, '2009-04-25', 'Barangay H', 'San Mateo', 'Rizal', 'Mario Pascual', '09621234545', 'Old Student', 'Enrolled'),
('Reyes', 'Paula', 'Villanueva', 10, 'Pegasus', '09631234546', 'Female', 16, '2009-07-29', 'Barangay I', 'Muntinlupa City', 'Metro Manila', 'John Reyes', '09631234546', 'Old Student', 'Enrolled'),
('Soriano', 'Nathaniel', 'Torres', 10, 'Pegasus', '09641234547', 'Male', 16, '2009-08-21', 'Barangay J', 'Dasmarinas', 'Cavite', 'Marites Soriano', '09641234547', 'Old Student', 'Enrolled'),
('Delos Santos', 'Mae', 'Aquino', 10, 'Pegasus', '09651234548', 'Female', 16, '2009-05-17', 'Barangay K', 'Santa Maria', 'Bulacan', 'Elena Delos Santos', '09651234548', 'Old Student', 'Enrolled'),
('Cortez', 'Leo', 'Jimenez', 10, 'Pegasus', '09661234549', 'Male', 16, '2009-06-01', 'Barangay L', 'Navotas City', 'Metro Manila', 'Ricky Cortez', '09661234549', 'Transferee', 'Enrolled'),
('Ferrer', 'Althea', 'Lopez', 10, 'Pegasus', '09671234550', 'Female', 16, '2009-10-27', 'Barangay M', 'Malabon City', 'Metro Manila', 'Mila Ferrer', '09671234550', 'Old Student', 'Enrolled');
