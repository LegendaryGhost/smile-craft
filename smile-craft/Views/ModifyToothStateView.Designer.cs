namespace smile_craft.Views
{
    partial class ModifyToothStateView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyToothStateView));
            markCB = new ComboBox();
            modifyStateBtn = new Button();
            opeationLabel = new Label();
            toothLabel = new Label();
            fullnameLabel = new Label();
            dismissBtn = new Button();
            SuspendLayout();
            // 
            // markCB
            // 
            markCB.FormattingEnabled = true;
            markCB.Location = new Point(34, 219);
            markCB.Name = "markCB";
            markCB.Size = new Size(289, 28);
            markCB.TabIndex = 22;
            // 
            // modifyStateBtn
            // 
            modifyStateBtn.BackColor = Color.FromArgb(33, 37, 41);
            modifyStateBtn.FlatAppearance.BorderSize = 0;
            modifyStateBtn.FlatStyle = FlatStyle.Flat;
            modifyStateBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modifyStateBtn.ForeColor = Color.FromArgb(224, 224, 224);
            modifyStateBtn.Location = new Point(34, 272);
            modifyStateBtn.Name = "modifyStateBtn";
            modifyStateBtn.Padding = new Padding(5, 0, 0, 0);
            modifyStateBtn.Size = new Size(289, 45);
            modifyStateBtn.TabIndex = 20;
            modifyStateBtn.Text = "Modifier";
            modifyStateBtn.UseVisualStyleBackColor = false;
            modifyStateBtn.Click += Modify;
            // 
            // opeationLabel
            // 
            opeationLabel.AutoSize = true;
            opeationLabel.Font = new Font("OCR A Extended", 13.8F);
            opeationLabel.Location = new Point(34, 191);
            opeationLabel.Name = "opeationLabel";
            opeationLabel.Size = new Size(66, 24);
            opeationLabel.TabIndex = 19;
            opeationLabel.Text = "Note";
            // 
            // toothLabel
            // 
            toothLabel.AutoSize = true;
            toothLabel.Font = new Font("OCR A Extended", 13.8F);
            toothLabel.Location = new Point(34, 124);
            toothLabel.Name = "toothLabel";
            toothLabel.Size = new Size(94, 24);
            toothLabel.TabIndex = 18;
            toothLabel.Text = "Dent 1";
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullnameLabel.Location = new Point(34, 58);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(140, 23);
            fullnameLabel.TabIndex = 23;
            fullnameLabel.Text = "Prénom Nom";
            // 
            // dismissBtn
            // 
            dismissBtn.BackColor = Color.White;
            dismissBtn.FlatAppearance.BorderSize = 0;
            dismissBtn.FlatStyle = FlatStyle.Flat;
            dismissBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dismissBtn.ForeColor = Color.FromArgb(33, 37, 41);
            dismissBtn.Location = new Point(34, 338);
            dismissBtn.Name = "dismissBtn";
            dismissBtn.Padding = new Padding(5, 0, 0, 0);
            dismissBtn.Size = new Size(289, 45);
            dismissBtn.TabIndex = 24;
            dismissBtn.Text = "Annuler";
            dismissBtn.UseVisualStyleBackColor = false;
            dismissBtn.Click += Dismiss;
            // 
            // ModifyToothStateView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 226, 230);
            ClientSize = new Size(357, 408);
            Controls.Add(dismissBtn);
            Controls.Add(fullnameLabel);
            Controls.Add(markCB);
            Controls.Add(modifyStateBtn);
            Controls.Add(opeationLabel);
            Controls.Add(toothLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ModifyToothStateView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModifyToothStateView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label opeationLabel;
        private Label toothLabel;
        private Label fullnameLabel;
        public ComboBox markCB;
        public Button modifyStateBtn;
        public Button dismissBtn;
    }
}