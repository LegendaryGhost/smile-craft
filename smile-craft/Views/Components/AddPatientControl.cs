using smile_craft.Presenter;
using smile_craft.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smile_craft.Components
{
    public partial class AddPatientControl : UserControl
    {
        public delegate void AddPatientHandler(object sender, EventArgs e);
        public event AddPatientHandler? AddPatientEvent;

        public TextBox FirstNameTB { get => firstNameTB; }
        public TextBox LastNameTB { get => lastNameTB; }
        public DateTimePicker BirthdayDTP { get => birthdayDTP; }


        public AddPatientControl()
        {
            InitializeComponent();
        }

        private void AddPatient(object sender, EventArgs e)
        {
            AddPatientEvent?.Invoke(this, e);
        }
    }
}
