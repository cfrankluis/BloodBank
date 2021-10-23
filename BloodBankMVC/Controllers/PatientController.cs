using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BloodBankData;
using BloodBankModels.Patient;
using BloodBankServices;

namespace BloodBankMVC.Controllers
{
    [Authorize]
    public class PatientController : Controller
    {
        private readonly ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Patient
        public ActionResult Index()
        {
            var service = new PatientServices();

            return View(service.GetAllPatients());
        }

        public ActionResult Create()
        {
            var viewModel = new PatientCreate();

            viewModel.BloodTypes = _db.Table.Select(bloodTypes => new SelectListItem
            {
                Text = bloodTypes.Type.ToString(),
                Value = bloodTypes.Type.ToString()
            });

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatientCreate model)
        {
            if (ModelState.IsValid)
            {
                var service = new PatientServices();
                if (service.CreatePatient(model))
                {
                    TempData["SaveResult"] = "A new patient was created.";
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError("", "Patient could not be created.");

            return View(model);
        }
    }
}