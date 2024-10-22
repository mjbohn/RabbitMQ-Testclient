using RabbitMQClient.Interfaces;
using System.Text.Json.Serialization;

namespace RabbitMQClient.ConfigHandling
{

    public class PublisherConfig
    {

        public string Server { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Queue { get; set; }
        public string Exchange { get; set; }
        public string RoutingKey { get; set; }
        public string VHost { get; set; }
        public string Port { get; set; }
        public string ApiPort { get; set; }
    }
}