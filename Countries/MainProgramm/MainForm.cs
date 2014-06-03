using System;
using System.Windows.Forms;
using CountryControl;

namespace MainProgramm
{
    public partial class MainForm : Form
    {
        private CountryDialog countryDialog;
        public MainForm()
        {
            countryDialog = new CountryDialog();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (countryDialog.ShowDialog() == DialogResult.OK)
            {
                comboBox1.Text = countryDialog.ChoosenCountry;
            }
        }
    }
}
