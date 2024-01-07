using System.Text.Json;

namespace BlazorShop.Models
{
    public class MySendEmailMessage : ISendMessage
    {
        public void SendMessage()
        {
            
        }

        public void SaveParamsObjectToFile()
        {
            var objectToSave = new EmailMessageModel(
                "smtp.yandex.ru",
                "v11_tes@rod.ru",
                "kuF991", 
                25);
            string filePath = "C:\\Users\\Yuriy\\Desktop\\params.json";
            string jsonContent = JsonSerializer.Serialize(objectToSave, 
                new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonContent);
        }

        public class EmailMessageModel 
        {
            public string SmtpServer { get; }
            public string Login { get; }
            public string Parol { get; }
            public int Port { get; }

            public EmailMessageModel(string smtpServer, string login, string parol, int port)
            {
                SmtpServer = smtpServer;
                Login = login;
                Parol = parol;
                Port = port;
            }
        }

    }
}
