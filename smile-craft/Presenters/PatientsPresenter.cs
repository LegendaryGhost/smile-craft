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
        private readonly DataGridView _teethStateDataGrid;

        public PatientsPresenter(SmilecraftContext context, IPatientsView patientsView)
        {
            _patientList = [];
            _context = context;
            _patientsView = patientsView;
            _patientsDataGrid = patientsView.GetPatientsDataGrid();
            _teethStateDataGrid = patientsView.GetPatientTeethDataGrid();
            SetUpPatientsDataGrid();
            SetUpTeethStateDataGrid();
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
                Firstname = firstName,
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
                                        p.Firstname,
                                        p.Lastname,
                                        p.Birthday
                                    ))
                                    .ToList();
            _patientList = new BindingList<PatientSummary>(patientSummaries);
            _patientsView.SetPatientsDataSource(_patientList);
        }

        private void LoadSinglePatient(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _patientsDataGrid.Columns[e.ColumnIndex].Name == "Details")
            {
                if (_patientsDataGrid.Rows.Count > e.RowIndex)
                {
                    // Gets the ID of the patient
                    int patientId = (int)_patientsDataGrid.Rows[e.RowIndex].Cells["Id"].Value;

                    Patient? patient = _context.Patients.Find(patientId);

                    if (patient != null)
                    {
                        _patientsView.DisplaySinglePatient(patient);
                        LoadPatientOperations(patientId);
                        LoadPatientTeethState(patientId);
                    }
                }
            }
        }

        private void LoadPatientOperations(int patientId)
        {
            var operations = _context.Performs
                .Where(p => p.IdPatient == patientId)
                .Join(_context.Teeth,
                    p => p.IdTooth,
                    t => t.IdTooth,
                    (p, t) => new { Perform = p, Tooth = t })
                .Join(_context.Categories,
                    pt => pt.Tooth.IdCategory,
                    c => c.IdCategory,
                    (pt, c) => new { Operation = pt.Perform, pt.Tooth, Category = c })
                .Join(_context.Operations,
                    opc => opc.Operation.IdOperation,
                    o => o.IdOperation,
                    (opc, o) => new OperationSummary(
                        opc.Operation.IdPerform,
                        $"{opc.Category.Designation} {opc.Tooth.IdTooth}",
                        o.Name,
                        opc.Operation.DateOperation)
                ).ToList();

            var operationsBindingList = new BindingList<OperationSummary>(operations);
            _patientsView.GetPatientOperationsDataGrid().DataSource = operationsBindingList;
        }

        private void SetUpTeethStateDataGrid()
        {
            DataGridViewTextBoxColumn idColumn = new()
            {
                Name = "ID",
                DataPropertyName = "IdTooth"
            };

            DataGridViewTextBoxColumn noteColumn = new()
            {
                Name = "Note",
                DataPropertyName = "Mark"
            };

            DataGridViewButtonColumn btnNoter = new()
            {
                Name = "Noter",
                Text = "Modify",
                UseColumnTextForButtonValue = true
            };

            _teethStateDataGrid.CellClick += ModifyMark;
            _teethStateDataGrid.Columns.Add(idColumn);
            _teethStateDataGrid.Columns.Add(noteColumn);
            _teethStateDataGrid.Columns.Add(btnNoter);
        }

        private void LoadPatientTeethState(int patientId)
        {
            var teethStateSummaries = _context.States
                                    .Where(p => p.IdPatient == patientId)
                                    .Include(s => s.Mark)
                                    .Select(s => new TeethStateSummary
                                    (
                                        s.IdTooth,
                                        s.Mark.Mark
                                    ))
                                    .ToList();
            BindingList<TeethStateSummary> teethStateList = new BindingList<TeethStateSummary>(teethStateSummaries);
            _teethStateDataGrid.DataSource = teethStateList;
        }
    }
}
