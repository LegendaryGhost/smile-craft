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
            fullNameTB = new Label();
            label1 = new Label();
            label2 = new Label();
            tabControl = new TabControl();
            operationsPage = new TabPage();
            operationsDGV = new DataGridView();
            teethStatePage = new TabPage();
            newOperationPage = new TabPage();
            dynamicGenerationPage = new TabPage();
            validateBtn = new Button();
            generatedOperationsDGV = new DataGridView();
            generateBtn = new Button();
            currencyLabel = new Label();
            amountLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            addNewPatientBtn = new Button();
            opeationLabel = new Label();
            toothLabel = new Label();
            suggestLabel = new Label();
            priorityLabel = new Label();
            priorityCB = new ComboBox();
            toothCB = new ComboBox();
            operationCB = new ComboBox();
            tabControl.SuspendLayout();
            operationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)operationsDGV).BeginInit();
            newOperationPage.SuspendLayout();
            dynamicGenerationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generatedOperationsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // fullNameTB
            // 
            fullNameTB.AutoSize = true;
            fullNameTB.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameTB.Location = new Point(23, 19);
            fullNameTB.Name = "fullNameTB";
            fullNameTB.Size = new Size(204, 32);
            fullNameTB.TabIndex = 2;
            fullNameTB.Text = "Prénom Nom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 65);
            label1.Name = "label1";
            label1.Size = new Size(375, 32);
            label1.TabIndex = 3;
            label1.Text = "Date de naissance :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 65);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 4;
            label2.Text = "01/01/1970";
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
            operationsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            operationsDGV.Dock = DockStyle.Fill;
            operationsDGV.Location = new Point(3, 3);
            operationsDGV.Name = "operationsDGV";
            operationsDGV.RowHeadersWidth = 51;
            operationsDGV.Size = new Size(959, 495);
            operationsDGV.TabIndex = 0;
            // 
            // teethStatePage
            // 
            teethStatePage.Location = new Point(4, 33);
            teethStatePage.Name = "teethStatePage";
            teethStatePage.Padding = new Padding(3);
            teethStatePage.Size = new Size(965, 501);
            teethStatePage.TabIndex = 1;
            teethStatePage.Text = "Etat des dents";
            teethStatePage.UseVisualStyleBackColor = true;
            // 
            // newOperationPage
            // 
            newOperationPage.Controls.Add(operationCB);
            newOperationPage.Controls.Add(toothCB);
            newOperationPage.Controls.Add(addNewPatientBtn);
            newOperationPage.Controls.Add(opeationLabel);
            newOperationPage.Controls.Add(toothLabel);
            newOperationPage.Location = new Point(4, 33);
            newOperationPage.Name = "newOperationPage";
            newOperationPage.Size = new Size(965, 501);
            newOperationPage.TabIndex = 2;
            newOperationPage.Text = "Nouvelle Opération";
            newOperationPage.UseVisualStyleBackColor = true;
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
            dynamicGenerationPage.Location = new Point(4, 33);
            dynamicGenerationPage.Name = "dynamicGenerationPage";
            dynamicGenerationPage.Size = new Size(965, 501);
            dynamicGenerationPage.TabIndex = 3;
            dynamicGenerationPage.Text = "Génération dynamique";
            dynamicGenerationPage.UseVisualStyleBackColor = true;
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
            generatedOperationsDGV.Location = new Point(0, 203);
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
            // priorityCB
            // 
            priorityCB.FormattingEnabled = true;
            priorityCB.Location = new Point(597, 21);
            priorityCB.Name = "priorityCB";
            priorityCB.Size = new Size(151, 32);
            priorityCB.TabIndex = 14;
            // 
            // toothCB
            // 
            toothCB.FormattingEnabled = true;
            toothCB.Location = new Point(344, 140);
            toothCB.Name = "toothCB";
            toothCB.Size = new Size(289, 32);
            toothCB.TabIndex = 16;
            // 
            // operationCB
            // 
            operationCB.FormattingEnabled = true;
            operationCB.Location = new Point(344, 227);
            operationCB.Name = "operationCB";
            operationCB.Size = new Size(289, 32);
            operationCB.TabIndex = 17;
            // 
            // DisplayPatientControl
            // 
            AutoScaleDimensions = new SizeF(14F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 226, 230);
            Controls.Add(tabControl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fullNameTB);
            Font = new Font("OCR A Extended", 13.8F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DisplayPatientControl";
            Size = new Size(973, 660);
            tabControl.ResumeLayout(false);
            operationsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)operationsDGV).EndInit();
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

        private Label fullNameTB;
        private Label label1;
        private Label label2;
        private TabControl tabControl;
        private TabPage operationsPage;
        private TabPage teethStatePage;
        private TabPage newOperationPage;
        private TabPage dynamicGenerationPage;
        private DataGridView operationsDGV;
        private NumericUpDown numericUpDown1;
        private Label currencyLabel;
        private Label amountLabel;
        private Button generateBtn;
        private Button validateBtn;
        private DataGridView generatedOperationsDGV;
        private Button addNewPatientBtn;
        private TextBox firstNameTB;
        private Label opeationLabel;
        private TextBox lastNameTB;
        private Label toothLabel;
        private Label suggestLabel;
        private Label priorityLabel;
        private ComboBox priorityCB;
        private ComboBox operationCB;
        private ComboBox toothCB;
    }
}
