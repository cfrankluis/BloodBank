using BloodBankData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankModels.Patient
{
    public class PatientDetail
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public int Age { get; set; }
        public BloodType BloodType { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CheckInDate { get; set; }
    }
}
