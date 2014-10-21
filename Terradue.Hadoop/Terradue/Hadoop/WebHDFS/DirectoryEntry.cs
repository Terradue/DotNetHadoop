using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace Terradue.Hadoop.WebHDFS
{
    // todo - make abstract
    public class DirectoryEntry : Resource
    {
        // todo - should makt these immutable.
        public string AccessTime { get; set; }
        public string BlockSize { get; set; }
        public string Group { get; set; }
        public Int64 Length { get; set; }
        public string ModificationTime { get; set; }
        public string Owner { get; set; }
        public string PathSuffix { get; set; }
        // todo, replace with flag enum 
        public string Permission { get; set; }
        public int Replication { get; set; }
        // todo, replace with enum 
        public string Type { get; set; }

        public DirectoryEntry(JsonObject value)
        {
            AccessTime = value.Get<string>("accessTime");
			BlockSize = value.Get<string>("blockSize");
			Group = value.Get<string>("group");
			Length = value.Get<Int64>("length");
			ModificationTime = value.Get<string>("modificationTime");
			Owner = value.Get<string>("owner");
			PathSuffix = value.Get<string>("pathSuffix");
			Permission = value.Get<string>("permission");
			Replication = value.Get<int>("replication");
			Type = value.Get<string>("type");
            base.Info = value;
        }

    }
}
