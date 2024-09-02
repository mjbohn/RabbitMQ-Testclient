using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient.Interfaces
{
    internal interface IConfigHandler
    {
        T ReadConfig<T>();
        void WriteConfig();
    }
}
