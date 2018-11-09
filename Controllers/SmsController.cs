using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;


//uses <PackageReference Include="Twilio.AspNet.Mvc" Version="5.9.7" /> for mvc
namespace WebApplication1.Controllers
{
    public class SmsController : TwilioController
    {
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            string response = incomingMessage.Body.ToUpper; 
            if(response = "YES")
            {
                //tell DB sms is good
            }else if(response = "NO" || "STOP")
            {
                //tell DB not to send sms
            }
            /* var messagingResponse = new MessagingResponse();
            messagingResponse.Message("The copy cat says: " +
                                      incomingMessage.Body);*/

            return TwiML(messagingResponse);
        }
    }
}