using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    public partial class CountryComponent : Component
    {
        public CountryComponent()
        {
            InitializeComponent();
            MapForm form = new MapForm();
            form.Show();
        }

        public CountryComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
