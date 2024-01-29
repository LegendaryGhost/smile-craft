namespace smile_craft.Components
{
    partial class PatientsControl
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
            patientsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)patientsGridView).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("OCR A Extended", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(23, 19);
            title.Name = "title";
            title.Size = new Size(356, 32);
            title.TabIndex = 0;
            title.Text = "Liste des patients";
            // 
            // patientsGridView
            // 
            patientsGridView.AllowUserToAddRows = false;
            patientsGridView.AllowUserToDeleteRows = false;
            patientsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientsGridView.Location = new Point(24, 178);
            patientsGridView.Name = "patientsGridView";
            patientsGridView.RowHeadersWidth = 51;
            patientsGridView.Size = new Size(924, 457);
            patientsGridView.TabIndex = 1;
            // 
            // PatientsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 226, 230);
            Controls.Add(patientsGridView);
            Controls.Add(title);
            Name = "PatientsControl";
            Size = new Size(973, 660);
            ((System.ComponentModel.ISupportInitialize)patientsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private DataGridView patientsGridView;
    }
}
