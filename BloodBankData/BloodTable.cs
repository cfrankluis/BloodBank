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

        public string BloodValue
        {
            get
            {
                switch (Type)
                {
                    case BloodType.Ap:
                        return "A+";
                    case BloodType.An:
                        return "A-";
                    case BloodType.Bp:
                        return "B+";
                    case BloodType.Bn:
                        return "B-";
                    case BloodType.ABp:
                        return "AB+";
                    case BloodType.ABn:
                        return "AB-";
                    case BloodType.Op:
                        return "O+";
                    case BloodType.On:
                        return "O-";
                    default:
                        return "Other";
                }
            }
            private set { }
        }

        public virtual IEnumerable<Patient> Patients { get; set; } = new List<Patient>();
        public virtual IEnumerable<Donor> Donors { get; set; } = new List<Donor>();
        public virtual IEnumerable<Blood> Inventory { get; set; } = new List<Blood>();
    }
}
