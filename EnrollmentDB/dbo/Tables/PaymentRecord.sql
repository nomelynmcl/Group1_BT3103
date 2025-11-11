CREATE TABLE [dbo].[PaymentRecord]
(
	TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    Id INT NOT NULL,                
    PaymentDate DATETIME NOT NULL,
    ModeOfPayment VARCHAR(50) NOT NULL,  
    AmountPaid DECIMAL(10,2) NOT NULL,    
    RemainingBalance DECIMAL(10,2) NOT NULL, 
)
