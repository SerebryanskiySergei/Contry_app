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
        private readonly string _description;
        public Country(string name)
        {
            _name = name;
        }
        public void Draw()
        {
            throw new NotImplementedException();            //Придумать и реализовать!
        }

        public string GetName()
        {
            return _name;
        }

        public string GetInfo()
        {
            return _description;
        }
    }
}
