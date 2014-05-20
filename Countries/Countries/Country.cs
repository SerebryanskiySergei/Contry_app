using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    class Country:ICountry
    {
        private readonly string _name;

        public Country(string name)
        {
            _name = name;
        }
        public void Draw()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return _name;
        }
    }
}
