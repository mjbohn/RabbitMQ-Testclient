using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RabbitMQClient.RMQ_Entities
{
    public partial class FormRabbitMQExplorer : Form
    {
        private string _username { get; set; }
        private string _password { get; set; }
        private string _server { get; set; }
        private bool _useHttps { get; set; }
        private string _urlVhosts { get; set; }
        private string _urlExchanges { get; set; }
        private string _protocol { get; set; }
        private string _authToken { get; set; }

        private HttpClient? _client;

        public FormRabbitMQExplorer(string servername, string username, string password, bool useHttps = true)
        {
            _username = username;
            _password = password;
            _server = servername;
            _useHttps = useHttps;

            InitializeComponent();
            InitializeHttpClient();
            InitializeTreeView();
            treeViewRMQ.AfterSelect += TreeViewRMQ_AfterSelect;
        }

        private void TreeViewRMQ_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            TreeNode node = (sender as System.Windows.Forms.TreeView).SelectedNode;

            switch (node)
            {
                case RabbitMQExchangeNode:
                    
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>((node as RabbitMQExchangeNode).json_string);

                    richTextBox1.Text = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    });

                    break;
                default:
                    break;
            }


        }

        private void InitializeHttpClient()
        {
            _client = new HttpClient();
            _protocol = _useHttps ? "https" : "http";
            _urlVhosts = $"{_protocol}://{_server}/api/vhosts";
            _urlExchanges = $"{_protocol}://{_server}/api/exchanges";

            _authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_username}:{_password}"));

            // Authorization-Header 
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authToken);

        }

        private async void InitializeTreeView()
        {
            string test = _urlVhosts;

            // Send requests
            HttpResponseMessage responseVhosts = await _client.GetAsync(_urlVhosts);

            await TreeViewAddVhosts(responseVhosts);

        }

        private async Task TreeViewAddVhosts(HttpResponseMessage responseVhosts)
        {
            if (responseVhosts.IsSuccessStatusCode)
            {
                string contentVhosts = await responseVhosts.Content.ReadAsStringAsync();


                JsonArray jaVhosts = JsonNode.Parse(contentVhosts).AsArray();
                foreach (JsonObject jo in jaVhosts)
                {
                    //treeView1.Nodes.Add((string)jo["name"]);
                    RabbitMQVirtualHostNode vhNode = new RabbitMQVirtualHostNode();
                    vhNode.Text = (string)jo["name"];
                    vhNode.Name = (string)jo["name"];
                    treeViewRMQ.Nodes.Add(vhNode);

                    TreeViewAddExchangesToVhost(vhNode);
                }


            }
            else
            {
                MessageBox.Show(responseVhosts.StatusCode.ToString());
            }
        }

        private async void TreeViewAddExchangesToVhost(RabbitMQVirtualHostNode vhNode)
        {
            // encode '/' as %2F  
            string vHostName = vhNode.Name == "/" ? HttpUtility.UrlEncode("/") : vhNode.Name;

            HttpResponseMessage responseExchanges = await _client.GetAsync($"{_urlExchanges}/{vHostName}");

            if (responseExchanges.IsSuccessStatusCode)
            {
                string contentExchanges = await responseExchanges.Content.ReadAsStringAsync();
                JsonArray jaExchanges = JsonNode.Parse(contentExchanges).AsArray();

                foreach (JsonObject jo in jaExchanges)
                {
                    string name = (string)jo["name"] == string.Empty ? "(AMPQ default)" : (string)jo["name"];

                    RabbitMQExchangeNode exchangeNode = new RabbitMQExchangeNode();
                    exchangeNode.Name = name;
                    exchangeNode.Text = name;
                    exchangeNode.arguments = (string)jo["arguments"].ToJsonString();
                    exchangeNode.auto_delete = (bool)jo["auto_delete"];
                    exchangeNode.durable = (bool)jo["durable"];
                    exchangeNode.isInternal = (bool)jo["internal"];
                    exchangeNode.type = (string)jo["string"];
                    exchangeNode.user_who_performed_action = (String)jo["user_who_performed_action"];
                    exchangeNode.vhost = (string)jo["vhost"];
                    exchangeNode.json_string = jo.ToJsonString();


                    vhNode.Nodes.Add(exchangeNode);
                }
            }
            else
            {
                MessageBox.Show(responseExchanges.StatusCode.ToString());
            }
        }


    }
}
