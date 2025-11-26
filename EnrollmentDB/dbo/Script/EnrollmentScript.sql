
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
('cashier', 'cashier123', 'Cashier'),
('registrar', 'registrar123', 'Registrar');

--studentRecords
INSERT INTO [dbo].[StudentRecord]
(LastName, FirstName, MiddleName, Suffix, GradeLevel, Section, ContactNumber, Gender, Age, Birthdate, Barangay, Municipality, Province, GuardianName, GuardianContact, StudentType, EnrollmentStatus, Requirements, ModeOfPayment, SchoolYear)
VALUES
-- Grade 7 (New Students) - Sections: Sirius, Rigel
('Cruz', 'Juan', 'Santos', NULL, 7, 'Sirius', '091712345501', 'Male', 13, '2012-05-14', 'San Isidro', 'Quezon City', 'Metro Manila', 'Pedro Cruz', '09181234501', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Reyes', 'Maria', 'Lopez', NULL, 7, 'Rigel', '09181234502', 'Female', 13, '2012-03-21', 'San Jose', 'Manila', 'Metro Manila', 'Ana Reyes', '09181234502', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Garcia', 'Jose', 'Torres', 'Jr.', 7, 'Sirius', '09191234503', 'Male', 13, '2012-06-12', 'Poblacion', 'Cebu City', 'Cebu', 'Carlos Garcia', '09191234503', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Santos', 'Ana', 'Villanueva', NULL, 7, 'Rigel', '09201234504', 'Female', 13, '2012-04-05', 'San Miguel', 'Davao City', 'Davao del Sur', 'Liza Santos', '09201234504', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Torres', 'Mark', 'San', NULL, 7, 'Sirius', '091712345501', 'Male', 13, '2012-07-18', 'Barangay 1', 'Quezon City', 'Metro Manila', 'Mario Torres', '09171234550', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Villanueva', 'Ella', 'Cruz', NULL, 7, 'Rigel', '091712345567', 'Female', 13, '2012-08-09', 'Barangay 2', 'Calaca City', 'Batangas', 'Rose Villanueva', '09171234567', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Lopez', 'Kevin', 'Reyes', NULL, 7, 'Sirius', '09231123505', 'Male', 13, '2012-09-11', 'Barangay 3', 'Caloocan City', 'Metro Manila', 'Teresita Lopez', '09231123505', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Dela Cruz', 'Liza', 'Martinez', NULL, 7, 'Rigel', '09241234508', 'Female', 13, '2012-10-22', 'Barangay 4', 'Baguio City', 'Benguet', 'Andres Dela Cruz', '09241234508', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Fernandez', 'Daniel', 'Domingo', NULL, 7, 'Sirius', '09251234509', 'Male', 13, '2012-12-03', 'Barangay 5', 'Antipolo City', 'Rizal', 'Raul Fernandez', '09251234509', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Bautista', 'Sofia', 'Aquino', NULL, 7, 'Rigel', '09261234510', 'Female', 13, '2012-11-17', 'Barangay 6', 'Calaca City', 'Batangas', 'Marites Bautista', '09261234510', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Aquino', 'Miguel', 'Castillo', NULL, 7, 'Sirius', '09281234512', 'Male', 13, '2012-01-23', 'Barangay 7', 'Calaca City', 'Batangas', 'Roberto Aquino', '09281234512', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Mendoza', 'Jasmine', 'Garcia', NULL, 7, 'Rigel', '09281234512', 'Female', 13, '2012-02-18', 'Barangay 8', 'Balayan', 'Batangas', 'Ellen Mendoza', '09281234512', 'New Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),

-- Grade 8 (Old Students / Transferees) - Sections: Polaris, Vega
('Domingo', 'Grace', 'Jiminez', NULL, 8, 'Polaris', '09301234513', 'Female', 14, '2011-07-01', 'Barangay A', 'Valenzuela City', 'Metro Manila', 'Ana Domingo', '09301234513', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Gonzales', 'Josh', 'Serrano', NULL, 8, 'Vega', '09311234514', 'Male', 14, '2011-09-02', 'Barangay B', 'San Fernando', 'Pampanga', 'Rene Gonzales', '09311234514', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Serrano', 'Hannah', 'Cortez', NULL, 8, 'Polaris', '09321234515', 'Female', 14, '2011-05-08', 'Barangay C', 'Lucena City', 'Quezon', 'Grace Serrano', '09321234515', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Ramos', 'Nathan', 'Ortiz', NULL, 8, 'Vega', '09331234516', 'Male', 14, '2011-11-18', 'Barangay D', 'Batangas City', 'Batangas', 'Mario Ramos', '09331234516', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Rivera', 'Isabella', 'Navarro', NULL, 8, 'Polaris', '09341234517', 'Female', 14, '2011-02-15', 'Barangay E', 'Legazpi City', 'Albay', 'Elena Rivera', '09341234517', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Perez', 'Christian', 'Diaz', NULL, 8, 'Vega', '09351234518', 'Male', 14, '2011-04-20', 'Barangay F', 'Iloilo City', 'Iloilo', 'Maria Perez', '09351234518', 'Transferee', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Martinez', 'Angela', 'Santiago', NULL, 8, 'Polaris', '09361234519', 'Female', 14, '2011-01-05', 'Barangay G', 'General Santos City', 'South Cotabato', 'Jose Martinez', '09361234519', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Ortiz', 'David', 'Vergara', NULL, 8, 'Vega', '09371234520', 'Male', 14, '2011-03-22', 'Barangay H', 'Zamboanga City', 'Zamboanga', 'Lourdes Ortiz', '09371234520', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Navarro', 'Chloe', 'Aguilar', NULL, 8, 'Polaris', '09381234521', 'Female', 14, '2011-06-09', 'Barangay I', 'Mabalacat', 'Pampanga', 'Juan Navarro', '09381234521', 'Transferee', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Jimenez', 'Ryan', 'Dominguez', NULL, 8, 'Vega', '09391234522', 'Male', 14, '2011-08-30', 'Barangay J', 'Olongapo City', 'Zambales', 'Rosa Jimenez', '09391234522', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Flores', 'Leah', 'Alvarez', NULL, 8, 'Polaris', '09401234523', 'Female', 14, '2011-10-10', 'Barangay K', 'Santa Rosa', 'Laguna', 'Ellen Flores', '09401234523', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Diaz', 'Samuel', 'Roxas', NULL, 8, 'Vega', '09411234524', 'Male', 14, '2011-12-05', 'Barangay L', 'Cabanatuan City', 'Nueva Ecija', 'Mario Diaz', '09411234524', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),

-- Grade 9 (Old Students) - Sections: Phoenix, Altair
('Gomez', 'Victoria', 'Valdez', NULL, 9, 'Phoenix', '09421234525', 'Female', 15, '2010-05-02', 'Barangay 1', 'Dagupan City', 'Pangasinan', 'Eva Gomez', '09421234525', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Castro', 'Matthew', 'De Guzman', NULL, 9, 'Altair', '09431234526', 'Male', 15, '2010-03-11', 'Barangay 2', 'Tarlac City', 'Tarlac', 'Rico Castro', '09431234526', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Hernandez', 'Camille', 'Ferrer', NULL, 9, 'Phoenix', '09441234527', 'Female', 15, '2010-01-15', 'Barangay 3', 'Naga City', 'Camarines Sur', 'Liza Hernandez', '09441234527', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Villamor', 'Ethan', 'Del Rosario', NULL, 9, 'Altair', '09451234528', 'Male', 15, '2010-02-07', 'Barangay 4', 'Butuan City', 'Agusan del Norte', 'Lorenzo Villamor', '09451234528', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Del Rosario', 'Nicole', 'Padilla', NULL, 9, 'Phoenix', '09461234529', 'Female', 15, '2010-06-06', 'Barangay 5', 'Dumaguete City', 'Negros Oriental', 'Jose Del Rosario', '09461234529', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Santiago', 'Lucas', 'Salazar', NULL, 9, 'Altair', '09471234530', 'Male', 15, '2010-04-30', 'Barangay 6', 'Tacloban City', 'Leyte', 'Amelia Santiago', '09471234530', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Vergara', 'Samantha', 'Agustin', NULL, 9, 'Phoenix', '09481234531', 'Female', 15, '2010-09-13', 'Barangay 7', 'Cavite City', 'Cavite', 'Marites Vergara', '09481234531', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Cabrera', 'Kyle', 'Magsaysay', NULL, 9, 'Altair', '09491234532', 'Male', 15, '2010-11-20', 'Barangay 8', 'Angeles City', 'Pampanga', 'Pedro Cabrera', '09491234532', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Padilla', 'Bea', 'Reyes', NULL, 9, 'Phoenix', '09501234533', 'Female', 15, '2010-07-09', 'Barangay 9', 'Lipa City', 'Batangas', 'Belen Padilla', '09501234533', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Salazar', 'Gabriel', 'Torres', NULL, 9, 'Altair', '09511234534', 'Male', 15, '2010-08-01', 'Barangay 10', 'San Jose del Monte', 'Bulacan', 'Rico Salazar', '09511234534', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Aguilar', 'Andrea', 'Garcia', NULL, 9, 'Phoenix', '09521234535', 'Female', 15, '2010-10-19', 'Barangay 11', 'Cavite City', 'Cavite', 'Mario Aguilar', '09521234535', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Dominguez', 'Justin', 'Santos', NULL, 9, 'Altair', '09531234536', 'Male', 15, '2010-12-25', 'Barangay 12', 'Malolos', 'Bulacan', 'Liza Dominguez', '09531234536', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Ferrer', 'Julia', 'Cruz', NULL, 9, 'Phoenix', '09541234537', 'Female', 15, '2010-03-08', 'Barangay 13', 'San Fernando', 'La Union', 'Jose Ferrer', '09541234537', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),

-- Grade 10 (Old Students / Transferees) - Sections: Pegasus, Deneb
('Alvarez', 'Kyla', 'Lopez', NULL, 10, 'Pegasus', '09551234538', 'Female', 16, '2009-09-05', 'Barangay A', 'Imus', 'Cavite', 'Ramon Alvarez', '09551234538', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Roxas', 'Jerome', 'Fernandez', NULL, 10, 'Deneb', '09561234539', 'Male', 16, '2009-06-23', 'Barangay B', 'San Pedro', 'Laguna', 'Lina Roxas', '09561234539', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Valdez', 'Trisha', 'Santos', NULL, 10, 'Pegasus', '09571234540', 'Female', 16, '2009-03-14', 'Barangay C', 'Meycauayan', 'Bulacan', 'Ana Valdez', '09571234540', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('De Guzman', 'Andre', 'Castillo', NULL, 10, 'Deneb', '09581234541', 'Male', 16, '2009-12-09', 'Barangay D', 'Marikina City', 'Metro Manila', 'Mario De Guzman', '09581234541', 'Transferee', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Agustin', 'Bianca', 'Martinez', NULL, 10, 'Pegasus', '09591234542', 'Female', 16, '2009-11-20', 'Barangay E', 'Binan', 'Laguna', 'Helen Agustin', '09591234542', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Manalo', 'Francis', 'Reyes', NULL, 10, 'Deneb', '09601234543', 'Male', 16, '2009-01-08', 'Barangay F', 'Trece Martires', 'Cavite', 'Rey Manalo', '09601234543', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Santiago', 'Clarisse', 'Rivera', NULL, 10, 'Pegasus', '09611234544', 'Female', 16, '2009-02-11', 'Barangay G', 'Tanauan City', 'Batangas', 'Cesar Santiago', '09611234544', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025'),
('Pascual', 'Darren', 'Domingo', NULL, 10, 'Deneb', '09621234545', 'Male', 16, '2009-04-25', 'Barangay H', 'San Mateo', 'Rizal', 'Mario Pascual', '09621234545', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2025-2026'),
('Reyes', 'Paula', 'Villanueva', NULL, 10, 'Pegasus', '09631234546', 'Female', 16, '2009-07-29', 'Barangay I', 'Muntinlupa City', 'Metro Manila', 'John Reyes', '09631234546', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2024-2025'),
('Soriano', 'Nathaniel', 'Torres', NULL, 10, 'Deneb', '09641234547', 'Male', 16, '2009-08-21', 'Barangay J', 'Dasmarinas', 'Cavite', 'Marites Soriano', '09641234547', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2025-2026'),
('Delos Santos', 'Mae', 'Aquino', NULL, 10, 'Pegasus', '09651234548', 'Female', 16, '2009-05-17', 'Barangay K', 'Santa Maria', 'Bulacan', 'Elena Delos Santos', '09651234548', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Quarterly Payment', '2024-2025'),
('Cortez', 'Leo', 'Jimenez', NULL, 10, 'Deneb', '09661234549', 'Male', 16, '2009-06-01', 'Barangay L', 'Navotas City', 'Metro Manila', 'Ricky Cortez', '09661234549', 'Transferee', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Cash', '2025-2026'),
('Ferrer', 'Althea', 'Lopez', NULL, 10, 'Pegasus', '09671234550', 'Female', 16, '2009-10-27', 'Barangay M', 'Malabon City', 'Metro Manila', 'Mila Ferrer', '09671234550', 'Old Student', 'Enrolled', 'Birth Certificate, Good Moral, Form 137', 'Low Down Payment', '2024-2025');


INSERT INTO [dbo].[PaymentRecord]
(Id, PaymentDate, ModeOfPayment, AmountPaid, RemainingBalance)
VALUES
-- Grade 7
(1, GETDATE(), 'Cash', 5200.00, 0.00),
(2, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(3, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(4, GETDATE(), 'Cash', 5200.00, 0.00),
(5, GETDATE(), 'Low Down Payment', 800.00, 5700.00),
(6, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(7, GETDATE(), 'Cash', 5200.00, 0.00),
(8, GETDATE(), 'Low Down Payment', 1000.00, 5500.00),
(9, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(10, GETDATE(), 'Cash', 5200.00, 0.00),
(11, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(12, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),

-- Grade 8
(13, GETDATE(), 'Cash', 5200.00, 0.00),
(14, GETDATE(), 'Low Down Payment', 700.00, 5800.00),
(15, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(16, GETDATE(), 'Cash', 5200.00, 0.00),
(17, GETDATE(), 'Low Down Payment', 1000.00, 5500.00),
(18, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(19, GETDATE(), 'Cash', 5200.00, 0.00),
(20, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(21, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(22, GETDATE(), 'Cash', 5200.00, 0.00),
(23, GETDATE(), 'Low Down Payment', 600.00, 5900.00),
(24, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),

-- Grade 9
(25, GETDATE(), 'Cash', 5200.00, 0.00),
(26, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(27, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(28, GETDATE(), 'Cash', 5200.00, 0.000),
(29, GETDATE(), 'Low Down Payment', 800.00, 5700.00),
(30, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(31, GETDATE(), 'Cash', 5200.00, 0.00),
(32, GETDATE(), 'Low Down Payment', 1000.00, 5500.00),
(33, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(34, GETDATE(), 'Cash', 5200.00, 0.00),
(35, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(36, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(37, GETDATE(), 'Cash', 5200.00, 0.00),

-- Grade 10
(38, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(39, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(40, GETDATE(), 'Cash', 5200.00, 0.00),
(41, GETDATE(), 'Low Down Payment', 1000.00, 5500.00),
(42, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(43, GETDATE(), 'Cash', 5200.00, 0.00),
(44, GETDATE(), 'Low Down Payment', 600.00, 5900.00),
(45, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(46, GETDATE(), 'Cash', 5200.00, 0.00),
(47, GETDATE(), 'Low Down Payment', 500.00, 6000.00),
(48, GETDATE(), 'Low Quarterly Payment', 1500.00, 4500.00),
(49, GETDATE(), 'Cash', 5200.00, 0.00),
(50, GETDATE(), 'Low Down Payment', 800.00, 5700.00);