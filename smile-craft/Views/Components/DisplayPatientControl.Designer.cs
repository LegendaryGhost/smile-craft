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
            teethCB = new ComboBox();
            addNewPatientBtn = new Button();
            opeationLabel = new Label();
            toothLabel = new Label();
            dynamicGenerationPage = new TabPage();
            costAmountLabel = new Label();
            restAmountLabel = new Label();
            costTextLabel = new Label();
            restTextLabel = new Label();
            prioritiesCB = new ComboBox();
            priorityLabel = new Label();
            suggestLabel = new Label();
            validateBtn = new Button();
            generatedOperationsDGV = new DataGridView();
            label1 = new Label();
            generateBtn = new Button();
            label2 = new Label();
            currencyLabel = new Label();
            amountLabel = new Label();
            amountNUD = new NumericUpDown();
            tabControl.SuspendLayout();
            operationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)operationsDGV).BeginInit();
            teethStatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teethStateDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toothNumeringPB).BeginInit();
            newOperationPage.SuspendLayout();
            dynamicGenerationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)generatedOperationsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNUD).BeginInit();
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
            teethStatePage.Location = new Point(4, 29);
            teethStatePage.Name = "teethStatePage";
            teethStatePage.Padding = new Padding(3);
            teethStatePage.Size = new Size(965, 505);
            teethStatePage.TabIndex = 1;
            teethStatePage.Text = "Etat des dents";
            teethStatePage.UseVisualStyleBackColor = true;
            // 
            // teethStateDGV
            // 
            teethStateDGV.AllowUserToAddRows = false;
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
            teethStateDGV.Size = new Size(361, 499);
            teethStateDGV.TabIndex = 1;
            // 
            // toothNumeringPB
            // 
            toothNumeringPB.Dock = DockStyle.Left;
            toothNumeringPB.Image = Properties.Resources.tooth_numering;
            toothNumeringPB.Location = new Point(3, 3);
            toothNumeringPB.Name = "toothNumeringPB";
            toothNumeringPB.Size = new Size(592, 499);
            toothNumeringPB.SizeMode = PictureBoxSizeMode.Zoom;
            toothNumeringPB.TabIndex = 0;
            toothNumeringPB.TabStop = false;
            // 
            // newOperationPage
            // 
            newOperationPage.Controls.Add(operationCB);
            newOperationPage.Controls.Add(teethCB);
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
            // teethCB
            // 
            teethCB.FormattingEnabled = true;
            teethCB.Location = new Point(344, 140);
            teethCB.Name = "teethCB";
            teethCB.Size = new Size(289, 32);
            teethCB.TabIndex = 16;
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
            addNewPatientBtn.Click += AddOperation;
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
            dynamicGenerationPage.Controls.Add(costAmountLabel);
            dynamicGenerationPage.Controls.Add(restAmountLabel);
            dynamicGenerationPage.Controls.Add(costTextLabel);
            dynamicGenerationPage.Controls.Add(restTextLabel);
            dynamicGenerationPage.Controls.Add(prioritiesCB);
            dynamicGenerationPage.Controls.Add(priorityLabel);
            dynamicGenerationPage.Controls.Add(suggestLabel);
            dynamicGenerationPage.Controls.Add(validateBtn);
            dynamicGenerationPage.Controls.Add(generatedOperationsDGV);
            dynamicGenerationPage.Controls.Add(label1);
            dynamicGenerationPage.Controls.Add(generateBtn);
            dynamicGenerationPage.Controls.Add(label2);
            dynamicGenerationPage.Controls.Add(currencyLabel);
            dynamicGenerationPage.Controls.Add(amountLabel);
            dynamicGenerationPage.Controls.Add(amountNUD);
            dynamicGenerationPage.Font = new Font("Segoe UI", 9F);
            dynamicGenerationPage.Location = new Point(4, 33);
            dynamicGenerationPage.Name = "dynamicGenerationPage";
            dynamicGenerationPage.Size = new Size(965, 501);
            dynamicGenerationPage.TabIndex = 3;
            dynamicGenerationPage.Text = "Suggestion intelligente";
            dynamicGenerationPage.UseVisualStyleBackColor = true;
            // 
            // costAmountLabel
            // 
            costAmountLabel.AutoSize = true;
            costAmountLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costAmountLabel.Location = new Point(204, 158);
            costAmountLabel.Name = "costAmountLabel";
            costAmountLabel.Size = new Size(23, 23);
            costAmountLabel.TabIndex = 16;
            costAmountLabel.Text = "0";
            // 
            // restAmountLabel
            // 
            restAmountLabel.AutoSize = true;
            restAmountLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restAmountLabel.Location = new Point(733, 157);
            restAmountLabel.Name = "restAmountLabel";
            restAmountLabel.Size = new Size(23, 23);
            restAmountLabel.TabIndex = 16;
            restAmountLabel.Text = "0";
            // 
            // costTextLabel
            // 
            costTextLabel.AutoSize = true;
            costTextLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costTextLabel.Location = new Point(19, 158);
            costTextLabel.Name = "costTextLabel";
            costTextLabel.Size = new Size(166, 23);
            costTextLabel.TabIndex = 15;
            costTextLabel.Text = "Prix total :";
            // 
            // restTextLabel
            // 
            restTextLabel.AutoSize = true;
            restTextLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restTextLabel.Location = new Point(613, 157);
            restTextLabel.Name = "restTextLabel";
            restTextLabel.Size = new Size(101, 23);
            restTextLabel.TabIndex = 15;
            restTextLabel.Text = "Reste :";
            // 
            // prioritiesCB
            // 
            prioritiesCB.FormattingEnabled = true;
            prioritiesCB.Location = new Point(551, 23);
            prioritiesCB.Name = "prioritiesCB";
            prioritiesCB.Size = new Size(151, 28);
            prioritiesCB.TabIndex = 14;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("OCR A Extended", 13.8F);
            priorityLabel.Location = new Point(394, 25);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(122, 24);
            priorityLabel.TabIndex = 13;
            priorityLabel.Text = "Priorité";
            // 
            // suggestLabel
            // 
            suggestLabel.AutoSize = true;
            suggestLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suggestLabel.Location = new Point(347, 203);
            suggestLabel.Name = "suggestLabel";
            suggestLabel.Size = new Size(296, 23);
            suggestLabel.TabIndex = 12;
            suggestLabel.Text = "Opérations suggérées :";
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
            validateBtn.Click += TriggerConfirmSuggestionsEvent;
            // 
            // generatedOperationsDGV
            // 
            generatedOperationsDGV.AllowUserToAddRows = false;
            generatedOperationsDGV.AllowUserToDeleteRows = false;
            generatedOperationsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            generatedOperationsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            generatedOperationsDGV.Dock = DockStyle.Bottom;
            generatedOperationsDGV.Location = new Point(0, 240);
            generatedOperationsDGV.Name = "generatedOperationsDGV";
            generatedOperationsDGV.ReadOnly = true;
            generatedOperationsDGV.RowHeadersWidth = 51;
            generatedOperationsDGV.Size = new Size(965, 261);
            generatedOperationsDGV.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 13.8F);
            label1.Location = new Point(374, 158);
            label1.Name = "label1";
            label1.Size = new Size(38, 24);
            label1.TabIndex = 4;
            label1.Text = "Ar";
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
            generateBtn.Text = "Suggérer";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += TriggerSuggestEvent;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 13.8F);
            label2.Location = new Point(903, 157);
            label2.Name = "label2";
            label2.Size = new Size(38, 24);
            label2.TabIndex = 4;
            label2.Text = "Ar";
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
            // amountNUD
            // 
            amountNUD.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            amountNUD.Location = new Point(141, 21);
            amountNUD.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            amountNUD.Name = "amountNUD";
            amountNUD.Size = new Size(150, 27);
            amountNUD.TabIndex = 0;
            amountNUD.ThousandsSeparator = true;
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
            ((System.ComponentModel.ISupportInitialize)amountNUD).EndInit();
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
        private Label currencyLabel;
        private Label amountLabel;
        private Button generateBtn;
        private Button validateBtn;
        private Button addNewPatientBtn;
        private Label opeationLabel;
        private Label toothLabel;
        private Label suggestLabel;
        private Label priorityLabel;
        public DataGridView operationsDGV;
        private PictureBox toothNumeringPB;
        public DataGridView teethStateDGV;
        public ComboBox operationCB;
        public ComboBox teethCB;
        public ComboBox prioritiesCB;
        public DataGridView generatedOperationsDGV;
        private Label restTextLabel;
        private Label label2;
        public Label restAmountLabel;
        public NumericUpDown amountNUD;
        public Label costAmountLabel;
        private Label costTextLabel;
        private Label label1;
    }
}
