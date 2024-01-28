using smile_craft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smile_craft.Views
{
    public interface IPatientsView
    {
        event Action AddPatientEvent;
        string GetFirstName();
        string GetLastName();
        DateTime? GetBirthday();
        public void SetPatientsDataSource(BindingList<PatientSummary> patients);
        public DataGridView GetPatientsGridView();
    }
}
