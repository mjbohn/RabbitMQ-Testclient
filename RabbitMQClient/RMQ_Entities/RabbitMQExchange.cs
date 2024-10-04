using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQClient.RMQ_Entities
{
    class RabbitMQExchangeNode : TreeNode
    {
        public string arguments {  get; set; }
        public bool auto_delete { get; set; }
        public bool durable { get; set; }
        public bool isInternal {  get; set; }
        public string type { get; set; }
        public string user_who_performed_action { get; set; }
        public string vhost { get; set; }
        public string json_string { get; set; }


        public RabbitMQExchangeNode() : base()
        {

        }

        public string ToString()
        {
            return json_string;
        }

    }
}
