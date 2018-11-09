using System;
using System.Threading.Tasks;

namespace TwilioLib
{
    interface ISmSSend
    {
        string PhoneNumber(string CustomerPhoneNumber);
    }

    public class VerifySmS : ISmSSend
    {
            public string PhoneNumber(string CustomerPhoneNumber)
            {
                VerifyText();
            }
    }
    public class NotifySmS : ISmSSend
    {
            public string PhoneNumber(string CustomerPhoneNumber)
            {
                NotifyText();
            }
    }

    
}
