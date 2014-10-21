using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace Terradue.Hadoop.WebHDFS
{
    // todo - make abstract
    public class FileChecksum : Resource
    {
        // todo - should makt these immutable.
        public string Algorithm { get; set; }
        public string Checksum { get; set; }
        public int Length { get; set; }

        public FileChecksum(JsonObject value)
        {
            Algorithm = value.Get<string>("algorithm");
			Checksum = value.Get<string>("bytes");
			Length = value.Get<int>("length");
            Info = value;
        }
    }
}
