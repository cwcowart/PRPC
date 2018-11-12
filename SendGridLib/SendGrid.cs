using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using dotenv.net;

namespace PRPC_1
{
    public class Class1
    {
        interface ISMTP
        {
            string EmailAddress(string ConfEmail);
        }

        public class EmailConf:ISMTP
        {
            public string EmailAddress (string ConfEmail)
            {
                VerifyEmail();
            }
        }        
    }
}

