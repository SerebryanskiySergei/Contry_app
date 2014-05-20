using System;
using System.Drawing;
using System.Windows.Forms;

namespace Countries
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список стран.
        /// </summary>
        private ICountriesList _countriesList;
        /// <summary>
        /// Картинка, которая отображается в mapPictureBox в любой момент времени.
        /// </summary>
        private Bitmap _currentImage;
        /// <summary>
        /// Чистая крата без выделенных участков.
        /// </summary>
        private Image _backgroundImage;
        public Form1()
        {
            InitializeComponent();
            _backgroundImage = mapPictureBox.Image;
            _currentImage = new Bitmap(_backgroundImage,mapPictureBox.Width,mapPictureBox.Height);
            _countriesList = CountriesList.GetInstance(); 
            mapPictureBox.Image = new Bitmap(_currentImage);
            foreach (ICountry country in _countriesList)
                countriesListBox.Items.Add(country.GetName());
            
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentImage = new Bitmap(_backgroundImage, mapPictureBox.Width, mapPictureBox.Height); //рисуем фон (чистую карту)
            if (_countriesList.IsExist(countriesListBox.SelectedIndex.ToString()))
                _countriesList.Find(countriesListBox.SelectedIndex.ToString()).Draw(_currentImage); //рисуем выделенный участок
            Invalidate();                       //вызывем перерисовку формы
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImageUnscaled(_currentImage,0,0);
        }
    }
}
