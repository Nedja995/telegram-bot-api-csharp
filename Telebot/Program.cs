using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Telebot.Objects;

namespace Telebot
{
    public class komp
    {
        [JsonProperty("CPU")]
        public string cpu;
        [JsonProperty("PSU")]
        public string psu;
    }




    public class Bot
    {
        static void Main(string[] args)
        {
            var bot = new Bot("209137847:AAH7uktgrCt1_TGDFdX6-xM80KF9GgNfADE");
            Console.Out.WriteLine("");
            Console.Out.WriteLine(bot.getMe());
            Console.Out.WriteLine("");
            Console.Out.WriteLine(bot.sendMessage("hello iz charpa"));
            bot.loop().Wait();
        }

        public string Key;

        public Bot(string key)
        {
            Key = key;
        }

        public async Task loop()
        {
            while (true)
            {
                WebRequest request = WebRequest.Create("https://api.telegram.org/bot" + Key + "/getUpdates");
                var response = request.GetResponse();
                System.Diagnostics.Debug.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                System.Diagnostics.Debug.WriteLine("");
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                JsonTextReader jreader = new JsonTextReader(new StringReader(responseFromServer));
                var ob = JsonSerializer.Create().Deserialize<Update[]>(jreader)[0];

                // Display the content.
                System.Diagnostics.Debug.WriteLine(responseFromServer);
                System.Diagnostics.Debug.WriteLine("");
                System.Diagnostics.Debug.WriteLine("");
                // Clean up the streams and the response.
                reader.Close();
                response.Close();

                await Task.Delay(1000);
            }
        }

        public string getMe()
        {
            WebRequest request = WebRequest.Create("https://api.telegram.org/bot" + Key + "/getMe");
            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            JsonTextReader jreader = new JsonTextReader(new StringReader(responseFromServer));
            var ob = JsonSerializer.Create().Deserialize<getMe>(jreader);

            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();

            return responseFromServer;
        }

        public string sendMessage(string text)
        {
            WebRequest request = WebRequest.Create("https://api.telegram.org/bot" + Key + "/sendMessage?chat_id=180771137&text=" + text);

            var response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            string json = @"{
                    'CPU': 'Intel',
                    'PSU': '500W'
            }";

            JsonTextReader jreader = new JsonTextReader(new StringReader(json));
            var ob = JsonSerializer.Create().Deserialize<komp>(jreader);

            while (jreader.Read())
            {
                if (jreader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", jreader.TokenType, jreader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", jreader.TokenType);
                }
            }
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Clean up the streams and the response.
            reader.Close();
            response.Close();

            return responseFromServer;
        }

    }
}
