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
        private Patient? _patient;
    
        public DisplayPatientControl()
        {
            InitializeComponent();
        }

        public Patient? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                fullNameLabel.Text = _patient?.Fristname + " " + _patient?.Lastname;
                birthdayLabelText.Text = _patient?.Birthday?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
        }
    }

}
