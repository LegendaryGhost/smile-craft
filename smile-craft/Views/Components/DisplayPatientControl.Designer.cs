namespace smile_craft.Views.Components
{
    partial class DisplayPatientControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            fullNameLabel = new Label();
            birthdayLabel = new Label();
            birthdayLabelText = new Label();
            tabControl = new TabControl();
            operationsPage = new TabPage();
            operationsDGV = new DataGridView();
            teethStatePage = new TabPage();
            teethStateDGV = new DataGridView();
            toothNumeringPB = new PictureBox();
            newOperationPage = new TabPage();
            operationCB = new ComboBox();
            toothCB = new ComboBox();
            addNewPatientBtn = new Button();
            opeationLabel = new Label();
            toothLabel = new Label();
            dynamicGenerationPage = new TabPage();
            priorityCB = new ComboBox();
            priorityLabel = new Label();
            suggestLabel = new Label();
            validateBtn = new Button();
            generatedOperationsDGV = new DataGridView();
            generateBtn = new Button();
            currencyLabel = new Label();
            amountLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            tabControl.SuspendLayout();
            operationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)operationsDGV).BeginInit();
            teethStatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teethStateDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toothNumeringPB).BeginInit();
            newOperationPage.SuspendLayout();
            dynamicGenerationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generatedOperationsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameLabel.Location = new Point(23, 19);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(204, 32);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Prénom Nom";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthdayLabel.Location = new Point(23, 65);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(375, 32);
            birthdayLabel.TabIndex = 3;
            birthdayLabel.Text = "Date de naissance :";
            // 
            // birthdayLabelText
            // 
            birthdayLabelText.AutoSize = true;
            birthdayLabelText.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdayLabelText.Location = new Point(414, 65);
            birthdayLabelText.Name = "birthdayLabelText";
            birthdayLabelText.Size = new Size(194, 32);
            birthdayLabelText.TabIndex = 4;
            birthdayLabelText.Text = "01/01/1970";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(operationsPage);
            tabControl.Controls.Add(teethStatePage);
            tabControl.Controls.Add(newOperationPage);
            tabControl.Controls.Add(dynamicGenerationPage);
            tabControl.Dock = DockStyle.Bottom;
            tabControl.Location = new Point(0, 122);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(973, 538);
            tabControl.TabIndex = 5;
            // 
            // operationsPage
            // 
            operationsPage.Controls.Add(operationsDGV);
            operationsPage.Font = new Font("Segoe UI", 9F);
            operationsPage.Location = new Point(4, 33);
            operationsPage.Name = "operationsPage";
            operationsPage.Padding = new Padding(3);
            operationsPage.Size = new Size(965, 501);
            operationsPage.TabIndex = 0;
            operationsPage.Text = "Opérations";
            operationsPage.UseVisualStyleBackColor = true;
            // 
            // operationsDGV
            // 
            operationsDGV.AllowUserToAddRows = false;
            operationsDGV.AllowUserToDeleteRows = false;
            operationsDGV.AllowUserToResizeRows = false;
            operationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            operationsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            operationsDGV.Dock = DockStyle.Fill;
            operationsDGV.Location = new Point(3, 3);
            operationsDGV.Name = "operationsDGV";
            operationsDGV.ReadOnly = true;
            operationsDGV.RowHeadersWidth = 51;
            operationsDGV.Size = new Size(959, 495);
            operationsDGV.TabIndex = 0;
            // 
            // teethStatePage
            // 
            teethStatePage.Controls.Add(teethStateDGV);
            teethStatePage.Controls.Add(toothNumeringPB);
            teethStatePage.Font = new Font("Segoe UI", 9F);
            teethStatePage.Location = new Point(4, 33);
            teethStatePage.Name = "teethStatePage";
            teethStatePage.Padding = new Padding(3);
            teethStatePage.Size = new Size(965, 501);
            teethStatePage.TabIndex = 1;
            teethStatePage.Text = "Etat des dents";
            teethStatePage.UseVisualStyleBackColor = true;
            // 
            // teethStateDGV
            // 
            teethStateDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            teethStateDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            teethStateDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            teethStateDGV.DefaultCellStyle = dataGridViewCellStyle2;
            teethStateDGV.Dock = DockStyle.Right;
            teethStateDGV.Location = new Point(601, 3);
            teethStateDGV.Name = "teethStateDGV";
            teethStateDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            teethStateDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            teethStateDGV.RowHeadersWidth = 51;
            teethStateDGV.Size = new Size(361, 495);
            teethStateDGV.TabIndex = 1;
            // 
            // toothNumeringPB
            // 
            toothNumeringPB.Dock = DockStyle.Left;
            toothNumeringPB.Image = Properties.Resources.tooth_numering;
            toothNumeringPB.Location = new Point(3, 3);
            toothNumeringPB.Name = "toothNumeringPB";
            toothNumeringPB.Size = new Size(592, 495);
            toothNumeringPB.SizeMode = PictureBoxSizeMode.Zoom;
            toothNumeringPB.TabIndex = 0;
            toothNumeringPB.TabStop = false;
            // 
            // newOperationPage
            // 
            newOperationPage.Controls.Add(operationCB);
            newOperationPage.Controls.Add(toothCB);
            newOperationPage.Controls.Add(addNewPatientBtn);
            newOperationPage.Controls.Add(opeationLabel);
            newOperationPage.Controls.Add(toothLabel);
            newOperationPage.Location = new Point(4, 29);
            newOperationPage.Name = "newOperationPage";
            newOperationPage.Size = new Size(965, 505);
            newOperationPage.TabIndex = 2;
            newOperationPage.Text = "Nouvelle Opération";
            newOperationPage.UseVisualStyleBackColor = true;
            // 
            // operationCB
            // 
            operationCB.FormattingEnabled = true;
            operationCB.Location = new Point(344, 227);
            operationCB.Name = "operationCB";
            operationCB.Size = new Size(289, 32);
            operationCB.TabIndex = 17;
            // 
            // toothCB
            // 
            toothCB.FormattingEnabled = true;
            toothCB.Location = new Point(344, 140);
            toothCB.Name = "toothCB";
            toothCB.Size = new Size(289, 32);
            toothCB.TabIndex = 16;
            // 
            // addNewPatientBtn
            // 
            addNewPatientBtn.BackColor = Color.FromArgb(33, 37, 41);
            addNewPatientBtn.FlatAppearance.BorderSize = 0;
            addNewPatientBtn.FlatStyle = FlatStyle.Flat;
            addNewPatientBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewPatientBtn.ForeColor = Color.FromArgb(224, 224, 224);
            addNewPatientBtn.Location = new Point(344, 293);
            addNewPatientBtn.Name = "addNewPatientBtn";
            addNewPatientBtn.Padding = new Padding(5, 0, 0, 0);
            addNewPatientBtn.Size = new Size(289, 45);
            addNewPatientBtn.TabIndex = 15;
            addNewPatientBtn.Text = "Ajouter";
            addNewPatientBtn.UseVisualStyleBackColor = false;
            // 
            // opeationLabel
            // 
            opeationLabel.AutoSize = true;
            opeationLabel.Font = new Font("OCR A Extended", 13.8F);
            opeationLabel.Location = new Point(344, 200);
            opeationLabel.Name = "opeationLabel";
            opeationLabel.Size = new Size(136, 24);
            opeationLabel.TabIndex = 11;
            opeationLabel.Text = "Opération";
            // 
            // toothLabel
            // 
            toothLabel.AutoSize = true;
            toothLabel.Font = new Font("OCR A Extended", 13.8F);
            toothLabel.Location = new Point(344, 113);
            toothLabel.Name = "toothLabel";
            toothLabel.Size = new Size(66, 24);
            toothLabel.TabIndex = 9;
            toothLabel.Text = "Dent";
            // 
            // dynamicGenerationPage
            // 
            dynamicGenerationPage.Controls.Add(priorityCB);
            dynamicGenerationPage.Controls.Add(priorityLabel);
            dynamicGenerationPage.Controls.Add(suggestLabel);
            dynamicGenerationPage.Controls.Add(validateBtn);
            dynamicGenerationPage.Controls.Add(generatedOperationsDGV);
            dynamicGenerationPage.Controls.Add(generateBtn);
            dynamicGenerationPage.Controls.Add(currencyLabel);
            dynamicGenerationPage.Controls.Add(amountLabel);
            dynamicGenerationPage.Controls.Add(numericUpDown1);
            dynamicGenerationPage.Location = new Point(4, 29);
            dynamicGenerationPage.Name = "dynamicGenerationPage";
            dynamicGenerationPage.Size = new Size(965, 505);
            dynamicGenerationPage.TabIndex = 3;
            dynamicGenerationPage.Text = "Génération dynamique";
            dynamicGenerationPage.UseVisualStyleBackColor = true;
            // 
            // priorityCB
            // 
            priorityCB.FormattingEnabled = true;
            priorityCB.Location = new Point(597, 21);
            priorityCB.Name = "priorityCB";
            priorityCB.Size = new Size(151, 32);
            priorityCB.TabIndex = 14;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("OCR A Extended", 13.8F);
            priorityLabel.Location = new Point(440, 23);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(122, 24);
            priorityLabel.TabIndex = 13;
            priorityLabel.Text = "Priorité";
            // 
            // suggestLabel
            // 
            suggestLabel.AutoSize = true;
            suggestLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestLabel.Location = new Point(341, 159);
            suggestLabel.Name = "suggestLabel";
            suggestLabel.Size = new Size(283, 23);
            suggestLabel.TabIndex = 12;
            suggestLabel.Text = "Opérations suggérés :";
            // 
            // validateBtn
            // 
            validateBtn.BackColor = SystemColors.ControlDark;
            validateBtn.FlatAppearance.BorderSize = 0;
            validateBtn.FlatStyle = FlatStyle.Flat;
            validateBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            validateBtn.ForeColor = Color.FromArgb(33, 37, 41);
            validateBtn.Location = new Point(308, 72);
            validateBtn.Name = "validateBtn";
            validateBtn.Padding = new Padding(5, 0, 0, 0);
            validateBtn.Size = new Size(240, 45);
            validateBtn.TabIndex = 11;
            validateBtn.Text = "Valider";
            validateBtn.UseVisualStyleBackColor = false;
            // 
            // generatedOperationsDGV
            // 
            generatedOperationsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            generatedOperationsDGV.Dock = DockStyle.Bottom;
            generatedOperationsDGV.Location = new Point(0, 207);
            generatedOperationsDGV.Name = "generatedOperationsDGV";
            generatedOperationsDGV.RowHeadersWidth = 51;
            generatedOperationsDGV.Size = new Size(965, 298);
            generatedOperationsDGV.TabIndex = 10;
            // 
            // generateBtn
            // 
            generateBtn.BackColor = Color.FromArgb(33, 37, 41);
            generateBtn.FlatAppearance.BorderSize = 0;
            generateBtn.FlatStyle = FlatStyle.Flat;
            generateBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateBtn.ForeColor = Color.FromArgb(224, 224, 224);
            generateBtn.Location = new Point(19, 72);
            generateBtn.Name = "generateBtn";
            generateBtn.Padding = new Padding(5, 0, 0, 0);
            generateBtn.Size = new Size(240, 45);
            generateBtn.TabIndex = 9;
            generateBtn.Text = "Générer";
            generateBtn.UseVisualStyleBackColor = false;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Font = new Font("OCR A Extended", 13.8F);
            currencyLabel.Location = new Point(308, 23);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(38, 24);
            currencyLabel.TabIndex = 4;
            currencyLabel.Text = "Ar";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("OCR A Extended", 13.8F);
            amountLabel.Location = new Point(12, 23);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(108, 24);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Montant";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new Point(141, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 31);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // DisplayPatientControl
            // 
            AutoScaleDimensions = new SizeF(14F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 226, 230);
            Controls.Add(tabControl);
            Controls.Add(birthdayLabelText);
            Controls.Add(birthdayLabel);
            Controls.Add(fullNameLabel);
            Font = new Font("OCR A Extended", 13.8F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DisplayPatientControl";
            Size = new Size(973, 660);
            tabControl.ResumeLayout(false);
            operationsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)operationsDGV).EndInit();
            teethStatePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teethStateDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)toothNumeringPB).EndInit();
            newOperationPage.ResumeLayout(false);
            newOperationPage.PerformLayout();
            dynamicGenerationPage.ResumeLayout(false);
            dynamicGenerationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)generatedOperationsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullNameLabel;
        private Label birthdayLabel;
        private Label birthdayLabelText;
        private TabControl tabControl;
        private TabPage operationsPage;
        private TabPage teethStatePage;
        private TabPage newOperationPage;
        private TabPage dynamicGenerationPage;
        private NumericUpDown numericUpDown1;
        private Label currencyLabel;
        private Label amountLabel;
        private Button generateBtn;
        private Button validateBtn;
        private DataGridView generatedOperationsDGV;
        private Button addNewPatientBtn;
        private Label opeationLabel;
        private TextBox lastNameTB;
        private Label toothLabel;
        private Label suggestLabel;
        private Label priorityLabel;
        private ComboBox priorityCB;
        private ComboBox operationCB;
        private ComboBox toothCB;
        public DataGridView operationsDGV;
        private PictureBox toothNumeringPB;
        public DataGridView teethStateDGV;
    }
}
