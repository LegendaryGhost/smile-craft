using smile_craft.Data;
using smile_craft.Models;
using System;
using System.Diagnostics;

namespace smile_craft
{
    public partial class Home : Form
    {
        private bool dragging = false;
        private Point initialMousePosition;
        private Point initialWindowPosition;


        public Home()
        {
            InitializeComponent();
            this.CenterToScreen();
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
    }
}