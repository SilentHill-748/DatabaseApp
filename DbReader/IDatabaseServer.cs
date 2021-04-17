using System.Data;

namespace DbReader
{
    public interface IDatabaseServer
    {
        /// <summary>
        ///     Название типа сервера.
        /// </summary>
        ServerType Type { get; }

        /// <summary>
        ///     Команда на языке SQL, которую должен выполнить сервер.
        /// </summary>
        string Command { get; set; }

        /// <summary>
        ///     Данные, полученные из запроса в БД.
        /// </summary>
        DataSet DataSet { get; }

        /// <summary>
        ///     Выгружает данные из БД в <see cref="DataSet"/>, используя код запроса <see cref="Command"/>.
        /// </summary>
        void LoadData();
    }
}
