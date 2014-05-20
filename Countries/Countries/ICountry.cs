namespace Countries
{
    interface ICountry
    {
        /// <summary>
        /// Выделить страну на карте.
        /// </summary>
        void Draw();
        /// <summary>
        /// Получить название страны.
        /// </summary>
        /// <returns>Название страны.</returns>
        string GetName();
        /// <summary>
        /// Получить информация о стране.
        /// </summary>
        /// <returns>Инфо о  стране.</returns>
        string GetInfo();
    }
}
