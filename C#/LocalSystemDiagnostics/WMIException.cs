using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalSystemDiagnostics
{
    class WMIException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime errorTimeStamp { get; set; }
        public string causeOfError { get; set; }

        public WMIException() { }

        public WMIException(string message, string cause, DateTime time) :base(message)
        {
            this.causeOfError = cause;
            this.errorTimeStamp = time;
        }

    }
}
