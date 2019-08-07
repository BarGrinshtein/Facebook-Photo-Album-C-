using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19__EX01_Inbal311403133_Bar311492938
{
    public partial class FormUserPlaceChoice : Form
    {
        public FormUserPlaceChoice()
        {
            InitializeComponent();
            string m_userChoice = null;
        }

        public string userChoice { get; set; }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            userChoice = textBoxSelection.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
