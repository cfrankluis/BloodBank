using BloodBankData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BloodBankModels.Patient
{
    public class PatientEdit
    {
        [Required]
        public int PatientID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public BloodType BloodType { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public IEnumerable<SelectListItem> BloodTypes { get; set; }
    }
}
