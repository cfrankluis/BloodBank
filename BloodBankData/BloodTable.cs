using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankData
{
    public enum BloodType
    {
        Ap,
        An,
        Bp,
        Bn,
        ABp,
        ABn,
        Op,
        On,
    }
    public class BloodTable
    {
        [Key]
        public BloodType Type { get; set; }

        public virtual IEnumerable<Patient> Patients { get; set; } = new List<Patient>();
        public virtual IEnumerable<Donor> Donors { get; set; } = new List<Donor>();
        public virtual IEnumerable<Blood> Inventory { get; set; } = new List<Blood>();
    }
}
