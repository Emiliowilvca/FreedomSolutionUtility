using System;

namespace Freedom.Utility.Responses
{
    [Serializable]
    public class ErrorInterceptor
    {
        public string Code { get; set; }

        public string ResxCode { get; set; }

        public string Menssage { get; set; }
    }
}