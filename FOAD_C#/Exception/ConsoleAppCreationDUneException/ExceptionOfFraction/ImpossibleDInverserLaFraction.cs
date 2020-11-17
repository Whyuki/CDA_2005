using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleAppCreationDUneException.ExceptionOfFraction
{
    public class ImpossibleDInverserLaFraction : Exception
    {
        public ImpossibleDInverserLaFraction() : base()
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "ImpossibleDInverserLaFraction_Class_Samples";
        }
        public ImpossibleDInverserLaFraction(string message) : base(message)
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "ImpossibleDInverserLaFraction_Class_Samples";
        }
        public ImpossibleDInverserLaFraction(string message, System.Exception inner) : base(message, inner)
        {
            this.HelpLink = "https://docs.microsoft.com";
            this.Source = "ImpossibleDInverserLaFraction_Class_Samples";
        }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client.
        protected ImpossibleDInverserLaFraction(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
