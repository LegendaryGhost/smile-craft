using smile_craft.Models;
using System.ComponentModel;

namespace smile_craft.Views
{
    public interface IPatientsView
    {
        event Action AddPatientEvent;
        event Action<int?, int, int> AddPatientOperationEvent;
        event Action<int?, int, int> SuggestOperationEvent;
        event Action<int?> ConfirmSuggestionsEvent;
        string GetFirstName();
        string GetLastName();
        DateTime? GetBirthday();
        public void SetPatientsDataSource(BindingList<PatientSummary> patients);
        public void DisplaySinglePatient(Patient patient);
        public DataGridView GetPatientsDataGrid();
        public DataGridView GetPatientOperationsDataGrid();
        public DataGridView GetPatientTeethStateDataGrid();
        public DataGridView GetSuggestedOperationsDataGrid();
        public ComboBox GetTeethCB();
        public ComboBox GetOperationsCB();
        public ComboBox GetPrioritiesCB();
        public void DisplayRestSuggestionAmount(decimal restAmout);
        public void DisplaySuggestionTotal(int totalCost);
    }
}
