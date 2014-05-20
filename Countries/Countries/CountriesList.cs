﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    /// <summary>
    /// Объект, содержащий все страны.
    /// Реализует паттерн Singleton. Создавать через GetInstance.
    /// </summary>
    class CountriesList : ICountriesList
    {
        private List<ICountry> dataCountries;
        private static CountriesList _instance;

        private CountriesList()
        {
            dataCountries = new List<ICountry>();
        }

        public static CountriesList GetInstance()
        {
            return _instance ?? (_instance = new CountriesList());
        }

        public IEnumerator GetEnumerator()
        {
            return dataCountries.GetEnumerator();
        }

        public bool IsExist(string name)
        {
            foreach (ICountry country in dataCountries)
            {
                if (country.GetName() == name)
                    return true;
            }
            return false;
        }

        public ICountry Find(string name)
        {
            foreach (ICountry country in dataCountries)
            {
                if (country.GetName() == name)
                    return country;
            }
            return null;
        }

        public void Add(ICountry country)
        {
            dataCountries.Add(country);
        }

        public void Delete(string name)
        {
            foreach (ICountry country in dataCountries)
            {
                if (country.GetName() == name)
                    dataCountries.Remove(country);
            }
        }
    }
}