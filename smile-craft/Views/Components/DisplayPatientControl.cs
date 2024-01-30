using smile_craft.Models;
using System.Globalization;

namespace smile_craft.Views.Components
{
    public partial class DisplayPatientControl : UserControl
    {
        public delegate void AddPatientOperationHandler(object sender, EventArgs e);
        public event AddPatientOperationHandler? AddPatientOperationEvent;
        public Action? SuggestOperationEvent { get; internal set; }


        private Patient? _patient;

        public DisplayPatientControl()
        {
            InitializeComponent();
            teethStateDGV.AutoGenerateColumns = false;
            generatedOperationsDGV.AutoGenerateColumns = false;
        }

        public Patient? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                fullNameLabel.Text = _patient?.Firstname + " " + _patient?.Lastname;
                birthdayLabelText.Text = _patient?.Birthday?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }

        private void AddOperation(object sender, EventArgs e)
        {
            AddPatientOperationEvent?.Invoke(this, e);
        }

        private void TriggerSuggestEvent(object sender, EventArgs e)
        {
            SuggestOperationEvent?.Invoke();
        }
    }

}
