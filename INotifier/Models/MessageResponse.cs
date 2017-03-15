
namespace INotifier.Models
{
    public class MessageResponse
    {
        public string MessageId { get; set; }

        public string Error { get; set; }

        public string[] ValidationErrors { get; set; }

        public string[] SendMessageErrors { get; set;  }
    }
}