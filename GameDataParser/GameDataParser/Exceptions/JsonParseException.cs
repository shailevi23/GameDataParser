using System;
using System.Runtime.Serialization;

namespace GameDataParser.Exceptions
{
    [Serializable]
    public class JsonParseException : Exception
    {
        public string JsonBody { get; }

        protected JsonParseException(SerializationInfo info, StreamingContext context) :
            base(info, context) { }

        public JsonParseException() { }
        public JsonParseException(string message) : base(message) { }
        public JsonParseException(string message, Exception innerException) : base(message, innerException) { }

        public JsonParseException(string message, string jsonBody) :
            base(message)
        {
            JsonBody = jsonBody;
        }

        public JsonParseException(string message, string jsonBody ,Exception innerException) : 
            base(message, innerException)
        {
            JsonBody = jsonBody;
        }

    }
}
