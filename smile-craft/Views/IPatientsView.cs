using smile_craft.Models;
using System.ComponentModel;

namespace smile_craft.Views
{
    public interface IPatientsView
    {
        event Action AddPatientEvent;
        event Action<int?, int, int> AddPatientOperationEvent;
        string GetFirstName();
        string GetLastName();
        DateTime? GetBirthday();
        public void SetPatientsDataSource(BindingList<PatientSummary> patients);
        public DataGridView GetPatientsDataGrid();
        public void DisplaySinglePatient(Patient patient);
        public DataGridView GetPatientOperationsDataGrid();
        public DataGridView GetPatientTeethStateDataGrid();
        public ComboBox GetTeethCB();
        public ComboBox GetOperationsCB();
        public ComboBox GetPrioritiesCB();
    }
}
