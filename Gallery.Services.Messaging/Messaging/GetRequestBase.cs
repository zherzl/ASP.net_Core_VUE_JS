using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Services.Messaging.Messaging
{
    public abstract class GetRequestBase
    {
        public DateTime Now { get; set; } = DateTime.Now;
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
