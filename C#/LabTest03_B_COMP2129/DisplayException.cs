using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jordan_Morenstein_LabTest03_B_COMP2129
{
    class DisplayException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp {get; set;}
        public string CauseOfError {get; set;}
        
        public DisplayException(){}
        
        public DisplayException(string message, string cause, DateTime time)
        {
            messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // Override the Exception.Message property.
        public override string Message
        {
            get
            {
                return string.Format("Error Message: {0}", messageDetails);
            }
        }
    }
}
