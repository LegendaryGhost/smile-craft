using Microsoft.EntityFrameworkCore;
using smile_craft.Data;
using smile_craft.Models;
using smile_craft.Utils;
using smile_craft.Views;
using System;
using System.ComponentModel;

namespace smile_craft.Presenter
{
    public class PatientsPresenter
    {
        private BindingList<PatientSummary> _patientList;
        private readonly SmilecraftContext _context;
        private readonly IPatientsView _patientsView;
        private readonly DataGridView _patientsDataGrid;
        private readonly DataGridView _teethStateDataGrid;
        private readonly int _minimumOperationPrice;
        private List<PerformSummary> _suggestedOperations;

        public PatientsPresenter(SmilecraftContext context, IPatientsView patientsView)
        {
            _patientList = [];
            _suggestedOperations = [];
            _context = context;
            _patientsView = patientsView;
            _patientsDataGrid = patientsView.GetPatientsDataGrid();
            _teethStateDataGrid = patientsView.GetPatientTeethStateDataGrid();
            _minimumOperationPrice = context.Prices.Min(p => p.Price1);
            SetUpPatientsDataGrid();
            SetUpTeethStateDataGrid();
            SetUpSuggestedOperationsDataGrid();
            FillTeethCB();
            FillOperationsCB();
            FillPriorityCB();
            LoadAllPatients();
        }

        public void SuggestOperations(int? patientId, int amount, int priorityId)
        {
            if (amount < _minimumOperationPrice)
            {
                MessageBox.Show("Le montant saisi est insuffisant pour payer une opération");
                return;
            }

            (_suggestedOperations, int restAmout, int totalCost) = OperationsSuggester.Suggest
            (
                _context,
                patientId ?? 0,
                amount,
                priorityId
            );

            DisplaySuggestedOperations(_suggestedOperations);
            _patientsView.DisplayRestSuggestionAmount(restAmout);
            _patientsView.DisplaySuggestionTotal(totalCost);
        }

        private void DisplaySuggestedOperations(List<PerformSummary> suggestedOperations)
        {
            BindingList<PerformSummary> bindingList = new(suggestedOperations);
            _patientsView.GetSuggestedOperationsDataGrid().DataSource = bindingList;
        }


        public void AddPatientOperation(int? patientId, int toothId, int operationId)
        {
            Perform newPerform = new()
            {
                IdPatient = patientId,
                IdTooth = toothId,
                IdOperation = operationId
            };

            _context.Performs.Add(newPerform);
            _context.SaveChanges();
            LoadPatientOperations(patientId ?? 0);
            LoadPatientTeethState(patientId ?? 0);
            LoadPatientPersoCategoryAverage(patientId ?? 0);
            MessageBox.Show("Opération effectuée");
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

            if (birthday >= DateTime.Today)
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

        private void FillTeethCB()
        {
            ComboBox teethCB = _patientsView.GetTeethCB();

            // Retrieve all the teeth from the database
            var teeth = _context.Teeth.Include
            (
                t => t.IdCategoryNavigation
            ).ToList();

            // Create a list to store KeyValuePair objects
            List<KeyValuePair<int, string>> data = [];

            // Add each mark to the list
            foreach (var tooth in teeth)
            {
                data.Add(
                    new KeyValuePair<int, string>
                    (
                        tooth.IdTooth,
                        tooth.IdCategoryNavigation.Designation + " " + tooth.IdTooth
                    )
                );
            }

            // Bind the list to the DataSource of the ComboBox
            teethCB.DataSource = data;

            // Set the DisplayMember and ValueMember properties
            teethCB.DisplayMember = "Value";
            teethCB.ValueMember = "Key";

            // Select the mark with the given id
            teethCB.SelectedItem = data.FirstOrDefault(m => m.Key == 1);
        }

        private void FillOperationsCB()
        {
            ComboBox operationsCB = _patientsView.GetOperationsCB();

            // Retrieve all the teeth from the database
            var operations = _context.Operations.ToList();

            // Create a list to store KeyValuePair objects
            List<KeyValuePair<int, string>> data = [];

            // Add each mark to the list
            foreach (var operation in operations)
            {
                data.Add(new KeyValuePair<int, string>(operation.IdOperation, operation.Name));
            }

            // Bind the list to the DataSource of the ComboBox
            operationsCB.DataSource = data;

            // Set the DisplayMember and ValueMember properties
            operationsCB.DisplayMember = "Value";
            operationsCB.ValueMember = "Key";

            // Select the mark with the given id
            operationsCB.SelectedItem = data.FirstOrDefault(m => m.Key == 1);
        }

        private void FillPriorityCB()
        {
            ComboBox prioritiesCB = _patientsView.GetPrioritiesCB();

            // Retrieve all the teeth from the database
            var priorities = _context.ToothPriorities.ToList();

            // Create a list to store KeyValuePair objects
            List<KeyValuePair<int, string>> data = [];

            // Add each mark to the list
            foreach (var priority in priorities)
            {
                data.Add(new KeyValuePair<int, string>(priority.IdPriority, priority.PriorityName));
            }

            // Bind the list to the DataSource of the ComboBox
            prioritiesCB.DataSource = data;

            // Set the DisplayMember and ValueMember properties
            prioritiesCB.DisplayMember = "Value";
            prioritiesCB.ValueMember = "Key";

            // Select the mark with the given id
            prioritiesCB.SelectedItem = data.FirstOrDefault(m => m.Key == 1);
        }

        private void LoadAllPatients()
        {
            // Retrieve all the patients from the database and adds their summaries in the DataGridView
            var patientSummaries = _context.Patients.AsNoTracking()
                                    .Select(p => new PatientSummary
                                    (
                                        p.IdPatient,
                                        p.Firstname,
                                        p.Lastname,
                                        p.Birthday
                                    ))
                                    .ToList();
            //Create a binding list from the list so the data grid view can be notified of the changes
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
                        LoadPatientPersoCategoryAverage(patientId);
                        _suggestedOperations = [];
                        DeleteSuggestedOperations();
                    }
                }
            }
        }

        private void LoadPatientPersoCategoryAverage(int patientId)
        {
            var result = _context.States
                .Include(s => s.IdToothNavigation)
                .Where(state => state.IdPatient == patientId)
                .GroupBy(state => state.IdToothNavigation.IdPersoCategory)
                .Select(group => new AverageSummary
                {
                    PersonalizedCategoryName = group.First().IdToothNavigation.IdPersoCategoryNavigation != null ? group.First().IdToothNavigation.IdPersoCategoryNavigation.PersoCategoryName : null,
                    AverageMark1 = group.Average(state => state.IdMarkNavigation.Mark1)
                })
                .ToList();

            BindingList<AverageSummary> list = new (result);
            _patientsView.GetAverageDataGrid().DataSource = list;
        }

        private void LoadPatientOperations(int patientId)
        {
            var operations = _context.Performs.AsNoTracking()
                .Where(p => p.IdPatient == patientId)
                .OrderByDescending(o => o.IdPerform)
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
                        opc.Operation.DateOperation))
                .ToList();

            var operationsBindingList = new BindingList<OperationSummary>(operations);
            var bindingSource = new BindingSource(operationsBindingList, null);
            _patientsView.GetPatientOperationsDataGrid().DataSource = bindingSource;
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

        private void SetUpSuggestedOperationsDataGrid()
        {
            DataGridViewTextBoxColumn idColumn = new()
            {
                Name = "ID dent",
                DataPropertyName = "IdTooth"
            };

            DataGridViewTextBoxColumn categoryColumn = new()
            {
                Name = "Catégorie",
                DataPropertyName = "CategoryName"
            };

            DataGridViewTextBoxColumn positionColumn = new()
            {
                Name = "Position",
                DataPropertyName = "Position"
            };

            DataGridViewTextBoxColumn noteColumn = new()
            {
                Name = "Note actuelle",
                DataPropertyName = "CurrentMark"
            };

            DataGridViewTextBoxColumn operationColumn = new()
            {
                Name = "Opération",
                DataPropertyName = "OperationName"
            };

            DataGridViewTextBoxColumn priceColumn = new()
            {
                Name = "Prix",
                DataPropertyName = "PriceString"
            };

            DataGridView suggestionsGridView = _patientsView.GetSuggestedOperationsDataGrid();

            suggestionsGridView.Columns.Add(idColumn);
            suggestionsGridView.Columns.Add(categoryColumn);
            suggestionsGridView.Columns.Add(positionColumn);
            suggestionsGridView.Columns.Add(noteColumn);
            suggestionsGridView.Columns.Add(operationColumn);
            suggestionsGridView.Columns.Add(priceColumn);
        }

        private void LoadPatientTeethState(int patientId)
        {
            var teethStateSummaries = _context.States.AsNoTracking()
                                    .Where(p => p.IdPatient == patientId)
                                    .OrderBy(s => s.IdTooth)
                                    .Include(s => s.IdMarkNavigation)
                                    .Select(s => new ToothStateSummary
                                    (
                                        s.IdTooth,
                                        s.IdPatient,
                                        s.IdMarkNavigation.Mark1,
                                        s.IdMark,
                                        s.IdPatientNavigation.Firstname,
                                        s.IdPatientNavigation.Lastname,
                                        s.IdToothNavigation.IdCategoryNavigation.Designation
                                    ))
                                    .ToList();
            var teethStateList = new BindingList<ToothStateSummary>(teethStateSummaries);
            var bindingSource = new BindingSource(teethStateList, null);
            _teethStateDataGrid.DataSource = bindingSource;
        }

        private void ModifyMark(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && _teethStateDataGrid.Columns[e.ColumnIndex].Name == "Noter")
            {
                if (_teethStateDataGrid.Rows.Count > e.RowIndex)
                {
                    // Get the selected row
                    var selectedRow = _teethStateDataGrid.Rows[e.RowIndex];

                    // Cast the row to ToothStateSummary
                    var toothStateSummary = selectedRow.DataBoundItem as ToothStateSummary;

                    // Now you can access the idPatient
                    int toothId = toothStateSummary?.IdTooth ?? 0;
                    int patientId = toothStateSummary?.IdPatient ?? 0;
                    int markId = toothStateSummary?.IdMark ?? 0;
                    string fullname = (toothStateSummary?.Firstname ?? "") + " " + (toothStateSummary?.Lastname ?? "");
                    string toothDescription = (toothStateSummary?.Designation ?? "") + " " + (toothStateSummary?.IdTooth);

                    using ModifyToothStateView modifyView = new(fullname, toothDescription);
                    ComboBox comboBoxMarks = modifyView.markCB;

                    FillMarksComboBox(comboBoxMarks, markId);
                    comboBoxMarks.SelectedValue = markId;

                    modifyView.OnModifyStateButtonClicked += (newMarkId) =>
                    {
                        SaveMarkModification(newMarkId, patientId, toothId);
                        LoadPatientTeethState(patientId);
                        LoadPatientPersoCategoryAverage(patientId);
                    };

                    modifyView.ShowDialog();
                }
            }
        }

        private void SaveMarkModification(int? newMarkId, int patientId, int toothId)
        {
            // Check if newMarkId is not null
            if (newMarkId != null)
            {
                // Find the State record
                var stateRecord = _context.States.Find(patientId, toothId);

                if (stateRecord != null)
                {
                    // Update the IdMark property
                    stateRecord.IdMark = newMarkId ?? 0;

                    // Apply the changes to the database
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Patient introuvable lors de la modification de l'état d'une dent");
                }
            }
            else
            {
                // Handle the case when newMarkId is null
                // For example, you can show a message box to inform the user to select a mark
                MessageBox.Show("Please select a mark.");
            }
        }

        private void FillMarksComboBox(ComboBox comboBox, int markId)
        {
            // Retrieve all the marks from the database
            var marks = _context.Marks.ToList();

            // Create a list to store KeyValuePair objects
            List<KeyValuePair<int, int>> data = [];

            // Add each mark to the list
            foreach (var mark in marks)
            {
                data.Add(new KeyValuePair<int, int>(mark.IdMark, mark.Mark1));
            }

            // Bind the list to the DataSource of the ComboBox
            comboBox.DataSource = data;

            // Set the DisplayMember and ValueMember properties
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";

            // Select the mark with the given id
            comboBox.SelectedItem = data.FirstOrDefault(m => m.Key == markId);
        }

        public void ConfirmSuggestions(int? patientId)
        {
            bool suggestionExists = _suggestedOperations.Count != 0;

            if(!suggestionExists)
            {
                MessageBox.Show("Aucune suggestion à confirmer");
            }

            foreach(PerformSummary perform in _suggestedOperations)
            {
                _context.Performs.Add(perform.ToPerform());
            }
            _context.SaveChanges();

            DeleteSuggestedOperations();

            LoadPatientOperations(patientId ?? 1);
            LoadPatientTeethState(patientId ?? 1);
            LoadPatientPersoCategoryAverage(patientId ?? 1);

            MessageBox.Show("Opération(s) suggérées effectuées");
        }

        private void DeleteSuggestedOperations()
        {
            _suggestedOperations = [];
            DisplaySuggestedOperations(_suggestedOperations);
            _patientsView.DisplayRestSuggestionAmount(0);
            _patientsView.DisplaySuggestionTotal(0);
        }
    }
}
