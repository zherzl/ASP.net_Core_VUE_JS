using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Services.Messaging.Messaging
{
    public abstract class ResponseBase
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; }
    }
}
