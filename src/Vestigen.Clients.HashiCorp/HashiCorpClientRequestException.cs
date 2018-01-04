using System;
using System.Net;

namespace Vestigen.Clients.HashiCorp
{
    public class HashiCorpClientRequestException : Exception
    {
        public HashiCorpClientRequestException(string message, HttpStatusCode statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public HashiCorpClientRequestException(string message, HttpStatusCode statusCode, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; }

        public string ResponseBody { get; set; }
    }
}