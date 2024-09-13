using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RabbitMQClient.RMQ_Entities
{
    public partial class FormRabbitMQExplorer : Form
    {
        private string _username { get; set; }
        private string _password { get; set; }
        private string _server { get; set; }
        private bool _useHttps { get; set; }

        public FormRabbitMQExplorer(string servername, string username, string password, bool useHttps = true)
        {
            _username = username;
            _password = password;
            _server = servername;
            _useHttps = useHttps;

            InitializeComponent();
            InitializeTreeView();
        }

        private async void InitializeTreeView()
        {
            HttpClient? client = new HttpClient();
            string protocol = _useHttps ? "https" : "http";
            string? urlVhosts = $"{protocol}://{_server}/api/vhosts";
            string? urlExchanges = $"{protocol}://{_server}/api/exchanges";

            string? authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_username}:{_password}"));

            // Authorization-Header 
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            // Send requests
            HttpResponseMessage responseVhosts = await client.GetAsync(urlVhosts);
            HttpResponseMessage responseExchanges = await client.GetAsync(urlExchanges);


            if (responseVhosts.IsSuccessStatusCode)
            {
                string contentVhosts = await responseVhosts.Content.ReadAsStringAsync();
                string contentExchanges = await responseExchanges.Content.ReadAsStringAsync();

                JsonArray jaVhosts = JsonNode.Parse(contentVhosts).AsArray();
                JsonArray jaExchanges = JsonNode.Parse(contentExchanges).AsArray();

                TreeViewAddVhosts(jaVhosts);
                NewMethod(jaExchanges);

                treeViewRMQ.ExpandAll();

                //MessageBox.Show(response.StatusCode.ToString());
            }
        }

        private void NewMethod(JsonArray jaExchanges)
        {
            foreach (JsonObject jo in jaExchanges)
            {
                RabbitMQExchange exchangeNode = new RabbitMQExchange();
                exchangeNode.Text = (string)jo["name"] != string.Empty ? (string)jo["name"] : "(AMQP default)";

                TreeNode[] tmpNode = treeViewRMQ.Nodes.Find((string)jo["vhost"], false);

                tmpNode[0].Nodes.Add(exchangeNode);
            }
        }

        private void TreeViewAddVhosts(JsonArray jaVhosts)
        {
            foreach (JsonObject jo in jaVhosts)
            {
                //treeView1.Nodes.Add((string)jo["name"]);
                RabbitMQVirtualHost vhNode = new RabbitMQVirtualHost();
                vhNode.Text = (string)jo["name"];
                vhNode.Name = (string)jo["name"];
                treeViewRMQ.Nodes.Add(vhNode);
            }
        }
    }
}
