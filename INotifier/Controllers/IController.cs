using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using INotifier.Models;
using Newtonsoft;
using NLog;

namespace INotifier.Controllers
{
    public class IController : ApiController
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        // POST: notifier/v1/messages
        public MessageResponse messages([FromBody]Message message)
        {
            string text = Newtonsoft.Json.JsonConvert.SerializeObject(message);
            logger.Info("Message:" + text);

            MessageResponse response = new MessageResponse();
            response.MessageId = System.Guid.NewGuid().ToString();
            response.Error = "sample string 1";
            response.SendMessageErrors = new string[] { "sample string 2", "sample string 3" };
            response.ValidationErrors = new string[] { "sample string 4", "sample string 5" };
            return response;
        }

        // POST notifier/v1/messagebatches
        public MessageResponse messagebatches([FromBody]List<Message> messages)
        {
            string text = Newtonsoft.Json.JsonConvert.SerializeObject(messages);
            logger.Info("MessageBatches:" + text);

            MessageResponse response = new MessageResponse();
            response.MessageId = System.Guid.NewGuid().ToString();
            response.Error = "sample string 1";
            response.SendMessageErrors = new string[] { "sample string 2", "sample string 3" };
            response.ValidationErrors = new string[] { "sample string 4", "sample string 5" };
            return response;
        }

        // POST notifier/v1/simplemessages
        public MessageResponse simplemessages([FromBody]List<SimpleMessage> simples)
        {
            string text = Newtonsoft.Json.JsonConvert.SerializeObject(simples);
            logger.Info("SimpleMessages:" + text);

            MessageResponse response = new MessageResponse();
            response.MessageId = System.Guid.NewGuid().ToString();
            response.Error = "sample string 1";
            response.SendMessageErrors = new string[] { "sample string 2", "sample string 3" };
            response.ValidationErrors = new string[] { "sample string 4", "sample string 5" };
            return response;
        }
    }
}
