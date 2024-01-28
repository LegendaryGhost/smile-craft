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
            _patientList = [];
            _context = context;
            _patientsView = patientsView;
            LoadAllPatients();
        }

        public void AddPatient()
        {
            string firstName = _patientsView.GetFirstName();
            string lastName = _patientsView.GetLastName();
            DateTime? birthday = _patientsView.GetBirthday();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First name and last name cannot be empty.");
                return;
            }

            if (birthday > DateTime.Today)
            {
                MessageBox.Show("Birthday cannot be a future date.");
                return;
            }

            var newPatient = new Patient
            {
                Fristname = firstName,
                Lastname = lastName,
                Birthday = birthday == null ? null : DateOnly.FromDateTime((DateTime)birthday)
            };

            _context.Patients.Add(newPatient);
            _context.SaveChanges();

            LoadAllPatients();
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
            _patientsView.SetPatientsDataSource(_patientList);
        }

    }
}
