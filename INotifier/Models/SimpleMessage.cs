using System.Collections.Generic;

namespace INotifier.Models
{
    public class SimpleMessage
    {
        public Dictionary<string, string> MessageContent { get; set; }

        public string DeliveryMethod { get; set; }

        public string Recipient { get; set; }

        public Dictionary<string, string> ConnectorParams { get; set; }

    }
}