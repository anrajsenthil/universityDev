using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace University.Domain.Entities
{
    public class Blobinfo
    {
        public Stream Content { get; set; }
        public string ContentType { get; set; }
    }
}
