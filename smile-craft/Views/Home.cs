using smile_craft.Components;
using smile_craft.Data;
using smile_craft.Models;
using smile_craft.Presenter;
using smile_craft.Views;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace smile_craft
{
    public partial class Home : Form, IPatientsView
    {
        private bool dragging = false;
        private Point initialMousePosition;
        private Point initialWindowPosition;
        private readonly PatientsPresenter patientsPresenter;
        private readonly SmilecraftContext context;

        public event Action AddPatientEvent;

        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
            context = new SmilecraftContext();
            patientsPresenter = new PatientsPresenter(context, this);

            // Subscribe the event to the patientsPresenter
            AddPatientEvent += patientsPresenter.AddPatient;
            addPatientControl.AddPatientEvent += AddPatient;
        }

        public string GetFirstName()
        {
            return addPatientControl.FirstNameTB.Text;
        }

        public string GetLastName()
        {
            return addPatientControl.LastNameTB.Text;
        }

        public DateTime? GetBirthday()
        {
            return addPatientControl.BirthdayDTP.Value;
        }

        private void AddPatient(object sender, EventArgs e)
        {
            AddPatientEvent?.Invoke();
            ShowPatientsPanel(sender, e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            context.Dispose();
            base.OnFormClosing(e);
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StartDragging(object sender, EventArgs e)
        {
            this.dragging = true;
            initialMousePosition = Control.MousePosition;
            initialWindowPosition = this.Location;
        }

        private void StopDragging(object sender, EventArgs e)
        {
            this.dragging = false;
        }

        private void DragWindow(object sender, EventArgs e)
        {
            if (this.dragging)
            {
                // Get the current mouse position
                Point mousePos = Control.MousePosition;

                // Calculate the new location of the window
                int x = mousePos.X - initialMousePosition.X + initialWindowPosition.X;
                int y = mousePos.Y - initialMousePosition.Y + initialWindowPosition.Y;

                // Set the new location of the window
                this.Location = new Point(x, y);
            }
        }

        private void ShowPatientsPanel(object sender, EventArgs e)
        {
            patientsControl.BringToFront();
        }

        private void ShowAddPatientPanel(object sender, EventArgs e)
        {
            addPatientControl.BringToFront();
        }

        public DataGridView GetPatientsGridView()
        {
            return patientsControl.PatientsGridView;
        }

        void IPatientsView.SetPatientsDataSource(BindingList<PatientSummary> patients)
        {
            GetPatientsGridView().DataSource = patients;
        }

        public void DisplaySinglePatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
