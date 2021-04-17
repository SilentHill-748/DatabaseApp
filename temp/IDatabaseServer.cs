using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBReader
{
    public interface IDatabaseServer
    {
        /// <summary>
        ///     Название типа сервера.
        /// </summary>
        string DataType { get; }

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
