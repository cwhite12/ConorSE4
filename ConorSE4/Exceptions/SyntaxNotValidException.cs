using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConorSE4.Exceptions
{

    /// <summary>
    /// An exception that is thrown if the syntax given is not valid
    /// </summary>
    [Serializable]
    public class SyntaxNotValidException : Exception

    {

        public SyntaxNotValidException(string message)
            : base(message)
        { }
        protected SyntaxNotValidException(SerializationInfo info, StreamingContext ctxt)
            : base(info, ctxt)
        { }
    }
}
