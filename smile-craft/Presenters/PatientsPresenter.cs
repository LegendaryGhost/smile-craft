using Microsoft.EntityFrameworkCore;
using smile_craft.Data;
using smile_craft.Models;
using smile_craft.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Presenter
{
    public class PatientsPresenter
    {
        private BindingList<PatientSummary> _patientList;
        public readonly SmilecraftContext _context;
        public readonly IPatientsView _patientsView;

        public PatientsPresenter(SmilecraftContext context, IPatientsView patientsView)
        {
            _patientList = new BindingList<PatientSummary>();
            _context = context;
            _patientsView = patientsView;
            LoadAllPatients();
            _patientsView.SetPatientsDataSource(_patientList);
            ((Form)_patientsView).Show();
        }

        private void LoadAllPatients()
        {
            var patientSummaries = _context.Patients
                                    .Select(p => new PatientSummary
                                    (
                                        p.IdPatient,
                                        p.Fristname,
                                        p.Lastname,
                                        p.Birthday
                                    ))
                                    .ToList();

            _patientList = new BindingList<PatientSummary>(patientSummaries);
        }

    }
}
