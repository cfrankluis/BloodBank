using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankModels.Patient
{
    public class PatientListItem
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CheckInDate { get; set; }
    }
}
