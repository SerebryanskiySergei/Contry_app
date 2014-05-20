using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countries
{
    public partial class Form1 : Form
    {
        private ICountriesList countriesList;
        public Form1()
        {
            InitializeComponent();
            countriesList = CountriesList.GetInstance(); 
            foreach (ICountry country in countriesList)
                countriesListBox.Items.Add(country.GetName());
            
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countriesList.IsExist(countriesListBox.SelectedIndex.ToString()))
                countriesList.Find(countriesListBox.SelectedIndex.ToString()).Draw();
        }

    }
}
