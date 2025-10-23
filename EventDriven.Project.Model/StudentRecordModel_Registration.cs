using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class StudentRecordModel_Registration
    {
            public int Id { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string Middlename { get; set; }
            public int Age { get; set; }
            public DateTime Birthdate { get; set; }
            public string Gender { get; set; }
            public string Barangay { get; set; }
            public string Municipality { get; set; }
            public string Province { get; set; }
            public string ContactNumber { get; set; }
            public int GradeLevel { get; set; }
            public string GuardianName { get; set; }
            public string GuardianContact { get; set; }
            public string StudentType { get; set; }
            public string Section { get; set; }
            public string Requirements { get; set; }
            public string ModeOfPayment { get; set; }



        
    }
}
