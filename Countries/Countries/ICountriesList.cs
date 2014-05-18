using System.Collections;

namespace Countries
{
    interface ICountriesList : IEnumerable
    {
        /// <summary>
        /// Существует ли страна с заданным название.
        /// </summary>
        /// <param name="name">Название страны.</param>
        /// <returns>Найдено/не найдено</returns>
        bool IsExist(string name);
        /// <summary>
        /// Получить страну по названия.
        /// </summary>
        /// <param name="name">Название страны.</param>
        /// <returns>Объект IContry.</returns>
        ICountry Find(string name);
        /// <summary>
        /// Добавить страну в список
        /// </summary>
        /// <param name="country">Страна.</param>
        void Add(ICountry country);
        /// <summary>
        /// Удалить страну.
        /// </summary>
        /// <param name="name">Название страны.</param>
        void Delete(string name);
    }
}
