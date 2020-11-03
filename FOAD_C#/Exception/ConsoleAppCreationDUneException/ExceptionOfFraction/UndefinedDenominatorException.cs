using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCreationDUneException.ExceptionOfFraction
{
    class UndefinedDenominatorException:Exception
    {
        public UndefinedDenominatorException() : base()
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "UndefinedDenominatorException_Class_Samples";
        } 
        
        public UndefinedDenominatorException(string message) : base(message)
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "UndefinedDenominatorException_Class_Samples";
        }  
        
        public UndefinedDenominatorException(string message, System.Exception inner) : base(message, inner)
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "UndefinedDenominatorException_Class_Samples";
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected UndefinedDenominatorException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
