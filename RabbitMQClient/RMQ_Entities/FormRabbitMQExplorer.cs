using ScintillaNET;
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

#nullable disable warnings


namespace RabbitMQClient.RMQ_Entities
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Plattformkompatibilität überprüfen", Justification = "<Ausstehend>")]
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

        //scintilla
        private int maxLineNumberCharLength;

        public FormRabbitMQExplorer(string servername, string username, string password, bool useHttps = true)
        {
            _username = username;
            _password = password;
            _server = servername;
            _useHttps = useHttps;

            InitializeComponent();
            InitializeHttpClient();
            InitializeTreeView();
            InitializeScintilla();

            treeViewRMQ.AfterSelect += TreeViewRMQ_AfterSelect;
        }


        private void InitializeScintilla()
        {
            // Set the lexer
            scintilla.LexerName = "cpp";

            // Instruct the lexer to calculate folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;

            scintilla.Margins[0].Width = 16;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            scintilla.BackColor = System.Drawing.Color.LightGray;
            scintilla.StyleClearAll();
            StyleCollection sc = scintilla.Styles;
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

        private void TreeViewRMQ_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            TreeNode node = (sender as System.Windows.Forms.TreeView).SelectedNode;

            switch (node)
            {
                case RabbitMQExchangeNode:

                    var jsonElement = JsonSerializer.Deserialize<JsonElement>((node as RabbitMQExchangeNode).json_string);

                    string text = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions()
                    {
                        WriteIndented = true
                    });

                    scintilla.Text = text;

                    break;
                default:
                    break;
            }


        }

        private void scintilla_TextChanged(object sender, EventArgs e)
        {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla.Margins[0].Width = scintilla.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }
    }
}
