using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smile_craft.Views
{
    public partial class ModifyToothStateView : Form
    {
        public event Action<int?>? OnModifyStateButtonClicked;

        public ModifyToothStateView(string fullname, string toothDescription)
        {
            InitializeComponent();
            fullnameLabel.Text = fullname;
            toothLabel.Text = toothDescription;
        }

        private void Modify(object sender, EventArgs e)
        {
            OnModifyStateButtonClicked?.Invoke((int?)markCB.SelectedValue);
            this.Close();
        }

        private void Dismiss(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
