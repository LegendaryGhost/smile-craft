namespace smile_craft
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            controlPanel = new Panel();
            minimizePictureBox = new PictureBox();
            closePictureBox = new PictureBox();
            sidePanel = new Panel();
            addPatientBtn = new Button();
            appName = new Label();
            addPatientPB = new PictureBox();
            logoPictureBox = new PictureBox();
            patientsBtn = new Button();
            patientsPB = new PictureBox();
            patientsControl = new Components.PatientsControl();
            addPatientControl = new Components.AddPatientControl();
            displayPatientControl = new Views.Components.DisplayPatientControl();
            controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimizePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).BeginInit();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addPatientPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientsPB).BeginInit();
            SuspendLayout();
            // 
            // controlPanel
            // 
            controlPanel.BackColor = Color.FromArgb(248, 249, 250);
            controlPanel.Controls.Add(minimizePictureBox);
            controlPanel.Controls.Add(closePictureBox);
            controlPanel.Dock = DockStyle.Top;
            controlPanel.Location = new Point(0, 0);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(1223, 39);
            controlPanel.TabIndex = 0;
            controlPanel.MouseDown += StartDragging;
            controlPanel.MouseMove += DragWindow;
            controlPanel.MouseUp += StopDragging;
            // 
            // minimizePictureBox
            // 
            minimizePictureBox.Cursor = Cursors.Hand;
            minimizePictureBox.Image = (Image)resources.GetObject("minimizePictureBox.Image");
            minimizePictureBox.Location = new Point(1102, 5);
            minimizePictureBox.Name = "minimizePictureBox";
            minimizePictureBox.Size = new Size(26, 26);
            minimizePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minimizePictureBox.TabIndex = 3;
            minimizePictureBox.TabStop = false;
            minimizePictureBox.Click += Minimize;
            // 
            // closePictureBox
            // 
            closePictureBox.Cursor = Cursors.Hand;
            closePictureBox.Image = Properties.Resources.power;
            closePictureBox.Location = new Point(1154, 5);
            closePictureBox.Name = "closePictureBox";
            closePictureBox.Size = new Size(26, 26);
            closePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            closePictureBox.TabIndex = 2;
            closePictureBox.TabStop = false;
            closePictureBox.Click += Close;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(33, 37, 41);
            sidePanel.Controls.Add(addPatientBtn);
            sidePanel.Controls.Add(appName);
            sidePanel.Controls.Add(addPatientPB);
            sidePanel.Controls.Add(logoPictureBox);
            sidePanel.Controls.Add(patientsBtn);
            sidePanel.Controls.Add(patientsPB);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 39);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 660);
            sidePanel.TabIndex = 1;
            // 
            // addPatientBtn
            // 
            addPatientBtn.BackColor = Color.FromArgb(33, 37, 41);
            addPatientBtn.Cursor = Cursors.Hand;
            addPatientBtn.FlatAppearance.BorderSize = 0;
            addPatientBtn.FlatStyle = FlatStyle.Flat;
            addPatientBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPatientBtn.ForeColor = Color.FromArgb(224, 224, 224);
            addPatientBtn.Location = new Point(43, 325);
            addPatientBtn.Name = "addPatientBtn";
            addPatientBtn.Padding = new Padding(5, 0, 0, 0);
            addPatientBtn.Size = new Size(207, 45);
            addPatientBtn.TabIndex = 5;
            addPatientBtn.Text = "Nouveau patient";
            addPatientBtn.TextAlign = ContentAlignment.MiddleLeft;
            addPatientBtn.UseVisualStyleBackColor = false;
            addPatientBtn.Click += ShowAddPatientPanel;
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.FromArgb(224, 224, 224);
            appName.Location = new Point(23, 209);
            appName.Name = "appName";
            appName.Size = new Size(204, 32);
            appName.TabIndex = 2;
            appName.Text = "SmileCraft";
            // 
            // addPatientPB
            // 
            addPatientPB.Cursor = Cursors.Hand;
            addPatientPB.Image = Properties.Resources.add_user;
            addPatientPB.Location = new Point(8, 334);
            addPatientPB.Name = "addPatientPB";
            addPatientPB.Size = new Size(29, 27);
            addPatientPB.SizeMode = PictureBoxSizeMode.Zoom;
            addPatientPB.TabIndex = 6;
            addPatientPB.TabStop = false;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Cursor = Cursors.Hand;
            logoPictureBox.Image = Properties.Resources.happy_white;
            logoPictureBox.Location = new Point(48, 28);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(147, 158);
            logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            logoPictureBox.TabIndex = 4;
            logoPictureBox.TabStop = false;
            // 
            // patientsBtn
            // 
            patientsBtn.BackColor = Color.FromArgb(33, 37, 41);
            patientsBtn.Cursor = Cursors.Hand;
            patientsBtn.FlatAppearance.BorderSize = 0;
            patientsBtn.FlatStyle = FlatStyle.Flat;
            patientsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsBtn.ForeColor = Color.FromArgb(224, 224, 224);
            patientsBtn.Location = new Point(43, 274);
            patientsBtn.Name = "patientsBtn";
            patientsBtn.Padding = new Padding(5, 0, 0, 0);
            patientsBtn.Size = new Size(207, 45);
            patientsBtn.TabIndex = 2;
            patientsBtn.Text = "Nos patients";
            patientsBtn.TextAlign = ContentAlignment.MiddleLeft;
            patientsBtn.UseVisualStyleBackColor = false;
            patientsBtn.Click += ShowPatientsPanel;
            // 
            // patientsPB
            // 
            patientsPB.Cursor = Cursors.Hand;
            patientsPB.Image = Properties.Resources.patients;
            patientsPB.Location = new Point(8, 283);
            patientsPB.Name = "patientsPB";
            patientsPB.Size = new Size(29, 27);
            patientsPB.SizeMode = PictureBoxSizeMode.Zoom;
            patientsPB.TabIndex = 4;
            patientsPB.TabStop = false;
            // 
            // patientsControl
            // 
            patientsControl.BackColor = Color.FromArgb(222, 226, 230);
            patientsControl.Dock = DockStyle.Fill;
            patientsControl.Location = new Point(250, 39);
            patientsControl.Name = "patientsControl";
            patientsControl.Size = new Size(973, 660);
            patientsControl.TabIndex = 2;
            // 
            // addPatientControl
            // 
            addPatientControl.BackColor = Color.FromArgb(222, 226, 230);
            addPatientControl.Dock = DockStyle.Fill;
            addPatientControl.Location = new Point(0, 0);
            addPatientControl.Name = "addPatientControl";
            addPatientControl.Size = new Size(1223, 699);
            addPatientControl.TabIndex = 7;
            // 
            // displayPatientControl
            // 
            displayPatientControl.BackColor = Color.FromArgb(222, 226, 230);
            displayPatientControl.Dock = DockStyle.Fill;
            displayPatientControl.Font = new Font("OCR A Extended", 13.8F);
            displayPatientControl.Location = new Point(0, 0);
            displayPatientControl.Margin = new Padding(5, 4, 5, 4);
            displayPatientControl.Name = "displayPatientControl";
            displayPatientControl.Patient = null;
            displayPatientControl.Size = new Size(1223, 699);
            displayPatientControl.TabIndex = 8;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 226, 230);
            ClientSize = new Size(1223, 699);
            ControlBox = false;
            Controls.Add(patientsControl);
            Controls.Add(sidePanel);
            Controls.Add(controlPanel);
            Controls.Add(addPatientControl);
            Controls.Add(displayPatientControl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimumSize = new Size(974, 691);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Click += Minimize;
            controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)minimizePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).EndInit();
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addPatientPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientsPB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel controlPanel;
        private Panel sidePanel;
        private PictureBox closePictureBox;
        private PictureBox minimizePictureBox;
        private PictureBox logoPictureBox;
        private Label appName;
        private PictureBox patientsPB;
        private Button patientsBtn;
        private Button addPatientBtn;
        private PictureBox addPatientPB;
        private Components.PatientsControl patientsControl;
        private Components.AddPatientControl addPatientControl;
        private Views.Components.DisplayPatientControl displayPatientControl;
    }
}
