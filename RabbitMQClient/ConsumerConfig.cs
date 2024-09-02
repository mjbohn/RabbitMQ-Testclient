using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient
{
    internal class ConsumerConfig
    {
        public string Server { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Queue { get; set; }
        public string ClientName { get; set; }
        public bool AddLineFeed { get; set; }
        public bool AutoAck { get; set; }
        public decimal Prefetch {  get; set; }

    }
}
