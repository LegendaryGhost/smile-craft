using smile_craft.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smile_craft.Views.Components
{
    public partial class DisplayPatientControl : UserControl
    {
        public delegate void AddPatientOperationHandler(object sender, EventArgs e);
        public event AddPatientOperationHandler? AddPatientOperationEvent;

        private Patient? _patient;

        public DisplayPatientControl()
        {
            InitializeComponent();
            teethStateDGV.AutoGenerateColumns = false;
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
    }

}
