using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Katas_project.PasswordVerifier
{
    [Serializable()]
    public class PasswordVerifierException : System.Exception
    {
        public PasswordVerifierException() : base() { }
        public PasswordVerifierException(string message) : base(message) { }
        public PasswordVerifierException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected PasswordVerifierException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
