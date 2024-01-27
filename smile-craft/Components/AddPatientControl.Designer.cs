namespace smile_craft.Components
{
    partial class AddPatientControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            nameLabel = new Label();
            lastNameTB = new TextBox();
            firstNameTB = new TextBox();
            firstNameLabel = new Label();
            birthdayLabel = new Label();
            birthdayDTP = new DateTimePicker();
            addNewPatientBtn = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(23, 19);
            title.Name = "title";
            title.Size = new Size(508, 32);
            title.TabIndex = 1;
            title.Text = "Ajouter un nouveau patient";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("OCR A Extended", 13.8F);
            nameLabel.Location = new Point(338, 178);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(52, 24);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Nom";
            // 
            // lastNameTB
            // 
            lastNameTB.Font = new Font("OCR A Extended", 13.8F);
            lastNameTB.Location = new Point(338, 214);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(289, 31);
            lastNameTB.TabIndex = 3;
            // 
            // firstNameTB
            // 
            firstNameTB.Font = new Font("OCR A Extended", 13.8F);
            firstNameTB.Location = new Point(338, 301);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(289, 31);
            firstNameTB.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("OCR A Extended", 13.8F);
            firstNameLabel.Location = new Point(338, 265);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(94, 24);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "Prénom";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("OCR A Extended", 13.8F);
            birthdayLabel.Location = new Point(338, 354);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(248, 24);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Date de naissance";
            // 
            // birthdayDTP
            // 
            birthdayDTP.CalendarFont = new Font("OCR A Extended", 13.8F);
            birthdayDTP.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdayDTP.Location = new Point(338, 391);
            birthdayDTP.Name = "birthdayDTP";
            birthdayDTP.Size = new Size(289, 34);
            birthdayDTP.TabIndex = 7;
            // 
            // addNewPatientBtn
            // 
            addNewPatientBtn.BackColor = Color.FromArgb(33, 37, 41);
            addNewPatientBtn.FlatAppearance.BorderSize = 0;
            addNewPatientBtn.FlatStyle = FlatStyle.Flat;
            addNewPatientBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewPatientBtn.ForeColor = Color.FromArgb(224, 224, 224);
            addNewPatientBtn.Location = new Point(338, 471);
            addNewPatientBtn.Name = "addNewPatientBtn";
            addNewPatientBtn.Padding = new Padding(5, 0, 0, 0);
            addNewPatientBtn.Size = new Size(289, 45);
            addNewPatientBtn.TabIndex = 8;
            addNewPatientBtn.Text = "Ajouter";
            addNewPatientBtn.UseVisualStyleBackColor = false;
            // 
            // AddPatientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 226, 230);
            Controls.Add(addNewPatientBtn);
            Controls.Add(birthdayDTP);
            Controls.Add(birthdayLabel);
            Controls.Add(firstNameTB);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameTB);
            Controls.Add(nameLabel);
            Controls.Add(title);
            Name = "AddPatientControl";
            Size = new Size(973, 660);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label nameLabel;
        private TextBox lastNameTB;
        private TextBox firstNameTB;
        private Label firstNameLabel;
        private Label birthdayLabel;
        private DateTimePicker birthdayDTP;
        private Button addNewPatientBtn;
    }
}
