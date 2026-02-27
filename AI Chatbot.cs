using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace traveliti
{
    public partial class AIChatbot : Form
    {
        private readonly HttpClient client = new HttpClient();

        // 🔑 PUT YOUR OPENAI API KEY HERE
        private string apiKey = "YOUR_OPENAI_API_KEY";

        public AIChatbot()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userMessage = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(userMessage))
                return;

            rtbChat.AppendText("You: " + userMessage + Environment.NewLine);
            txtMessage.Clear();

            string response = await GetAIResponse(userMessage);

            rtbChat.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);
        }

        private async Task<string> GetAIResponse(string message)
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

                var requestData = new
                {
                    model = "gpt-4o-mini",
                    messages = new[]
                    {
                        new { role = "system", content = "You are a helpful travel assistant chatbot." },
                        new { role = "user", content = message }
                    }
                };

                string json = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.openai.com/v1/chat/completions", content);

                string result = await response.Content.ReadAsStringAsync();

                dynamic jsonResult = JsonConvert.DeserializeObject(result);

                return jsonResult.choices[0].message.content.ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }
}