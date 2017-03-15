using System.Collections.Generic;

namespace INotifier.Models
{
    public class Message
    {
        public string MessageDefinitionName { get; set; }

        public int Version { get; set; }

        public string LanguageCode { get; set; }

        public Dictionary<string, string> Data { get; set; }

        public string DeliveryMethod { get; set; }

        public string Recipient { get; set; }

        public Dictionary<string, string> ConnectorParams { get; set;  }
    }
}