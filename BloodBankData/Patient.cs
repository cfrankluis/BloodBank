using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankData
{
    public class Patient
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

        [ForeignKey(nameof(BloodTable))]
        public BloodType BloodType { get; set; }
        public virtual BloodTable BloodTable { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        
        public int Age { 
            get 
            {
                if(DateTime.Now.Date > BirthDate.Date)
                    return DateTime.Now.Year - BirthDate.Year;
                else
                    return DateTime.Now.Year - BirthDate.Year - 1;
            } 
        }
    }
}
