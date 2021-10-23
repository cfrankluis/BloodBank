using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankModels.Patient;
using BloodBankData;

namespace BloodBankServices
{
    public class PatientServices
    {
        public bool CreatePatient(PatientCreate model)
        {
            var entity =
                new Patient()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    BirthDate = model.BirthDate,
                    BloodType = model.BloodType,
                    CheckInDate = DateTime.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Patients.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PatientListItem> GetAllPatients()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.
                    Patients.
                    Select(
                        e => new PatientListItem()
                        {
                            PatientID = e.ID,
                            Name = e.FullName,
                            Age = e.Age,
                            CheckInDate = e.CheckInDate
                        }
                     );

                return query.ToArray();
            }
        }
    }
}
