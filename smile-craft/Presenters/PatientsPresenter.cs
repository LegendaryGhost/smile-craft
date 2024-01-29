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
        private readonly SmilecraftContext _context;
        private readonly IPatientsView _patientsView;
        private readonly DataGridView _patientsDataGrid;

        public PatientsPresenter(SmilecraftContext context, IPatientsView patientsView)
        {
            _patientList = [];
            _context = context;
            _patientsView = patientsView;
            _patientsDataGrid = patientsView.GetPatientsGridView();
            SetUpPatientsDataGrid();
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

        private void SetUpPatientsDataGrid()
        {
            DataGridViewTextBoxColumn idColumn = new()
            {
                Name = "Id",
                DataPropertyName = "IdPatient"
            };

            DataGridViewTextBoxColumn firstnameColumn = new()
            {
                Name = "Firstname",
                DataPropertyName = "Fristname"
            };

            DataGridViewTextBoxColumn lastnameColumn = new()
            {
                Name = "Lastname",
                DataPropertyName = "Lastname"
            };

            DataGridViewTextBoxColumn birthdayColumn = new()
            {
                Name = "Birthday",
                DataPropertyName = "Birthday"
            };

            // Add a detail button for each patient
            DataGridViewButtonColumn btnDetails = new()
            {
                Name = "Details",
                Text = "Details",
                UseColumnTextForButtonValue = true
            };

            _patientsDataGrid.CellClick += LoadSinglePatient;
            _patientsDataGrid.Columns.Add(idColumn);
            _patientsDataGrid.Columns.Add(firstnameColumn);
            _patientsDataGrid.Columns.Add(lastnameColumn);
            _patientsDataGrid.Columns.Add(birthdayColumn);
            _patientsDataGrid.Columns.Add(btnDetails);
        }

        private void LoadAllPatients()
        {
            // Retrieve all the patients from the database and adds their summaries in the DataGridView
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

        private void LoadSinglePatient(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _patientsView.GetPatientsGridView().Columns[e.ColumnIndex].Name == "Details")
            {
                if (_patientsDataGrid.Rows.Count > e.RowIndex)
                {
                    // Gets the ID of the patient
                    int patientId = (int)_patientsView.GetPatientsGridView().Rows[e.RowIndex].Cells["Id"].Value;

                    Patient? patient = _context.Patients.Find(patientId);

                    if (patient != null)
                    {
                        _patientsView.DisplaySinglePatient(patient);
                    }
                }
            }
        }
    }
}
