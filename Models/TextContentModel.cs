using System;
using System.Collections.Generic;

namespace ShiranuiTextStore.Models
{
    public class TextContentModel
    {
        public string Text { get; set; }
        public Guid User { get; set; }
        public DateTime ExpireAt { get; set; }
    }
}
