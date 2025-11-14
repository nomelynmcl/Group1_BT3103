using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class StudentPaymentModel
    {
        
            public int Id { get; set; }
            public int TransactionId { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public DateTime PaymentDate { get; set; }
            public decimal AmountPaid { get; set; }
            public string ModeOfPayment { get; set; }
            public int GradeLevel { get; set; }
            public string Section { get; set; } 
            
            public string StudentType { get; set; }
            public string EnrollmentStatus { get; set; }

    }
}

