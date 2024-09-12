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
        public FormRabbitMQExplorer()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private async void InitializeTreeView()
        {
            var client = new HttpClient();

            // Benutzername und Passwort für die Authentifizierung
            var username = "tester";
            var password = "1234";

            // Base64-kodierte Authentifizierungsdaten
            var authToken = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}"));

            // Authorization-Header hinzufügen
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            var url = "https://rabbit.michael-bohn.net/api/vhosts";

            // Anfrage senden
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                JsonArray? jsonArray = JsonNode.Parse(content).AsArray();

                foreach (JsonObject jo in jsonArray)
                {
                    //treeView1.Nodes.Add((string)jo["name"]);
                    RabbitMQVirtualHost vh = new RabbitMQVirtualHost();
                    vh.Text = (string)jo["name"];
                    treeViewRMQ.Nodes.Add(vh);
                }


                //MessageBox.Show(response.StatusCode.ToString());
            }
        }
    }
}
