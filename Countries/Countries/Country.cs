using System;
using System.Drawing;

namespace Countries
{
    class Country:ICountry
    {
        private readonly string _name;
        private readonly string _description;
        private readonly Point _mapPoint;
        private readonly Image _countryImage;
        public Country(string name,string description,Point mapPoint,Image countryImage)
        {
            _name = name;
            _description = description;
            _mapPoint = mapPoint;
            _countryImage = countryImage;
        }

        public void Draw(Bitmap currentImage)
        {
            Graphics g = Graphics.FromImage(currentImage);
            g.DrawImage(_countryImage,_mapPoint);
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
