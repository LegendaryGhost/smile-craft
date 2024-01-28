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
    public partial class PatientsControl : UserControl
    {
        public DataGridView PatientsGridView { get; set; }

        public PatientsControl()
        {
            InitializeComponent();
            PatientsGridView = patientsGridView;
        }
    }
}
