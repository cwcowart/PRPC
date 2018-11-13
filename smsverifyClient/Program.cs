using System;
using smsverifylibrary;
using System.Threading.Tasks;
using dotenv.net;

namespace smsverifyClient
{
    class Program 
    {
        public static string PhoneNumber= "";
        public static string TwilioNumber = System.Environment.GetEnvironmentVariable("TWILIO_PHONE");
        static void Main(string[] args)
        {
            DotEnv.Config();
            VerifySmS converter = new VerifySmS();
            converter.VerifyText("");

           /* string accountSID = System.Environment.GetEnvironmentVariable("TWILIO_SID");
            string authToken = System.Environment.GetEnvironmentVariable("TWILIO_AUTHTOKEN");
            
            Console.WriteLine($"auth token is: {authToken}");
            Console.WriteLine($"accout_sid is: {accountSID}");
            Console.WriteLine($"Phone number is: {PhoneNumber}");
            try
            {
                
                TwilioClient.Init(accountSID, authToken);
                

                var message = MessageResource.Create(
                    body: "Would you like to recieve SMS notifications? Reply Yes or No, Reply STOP at any time " 
                            + "to disable text notifications",
                    from: new Twilio.Types.PhoneNumber(TwilioNumber),
                    to: new Twilio.Types.PhoneNumber(PhoneNumber)
                );
                //Use Account Sid for testing to make sure the message was sent
                Console.WriteLine(message.Sid);
                Console.WriteLine(message.AccountSid);
            }
            catch(Exception exp)
            {
                Console.Error.WriteLine("Error:" + exp.Message + Environment.NewLine + " " + exp.StackTrace);
            }*/
        }
        
    }
}

