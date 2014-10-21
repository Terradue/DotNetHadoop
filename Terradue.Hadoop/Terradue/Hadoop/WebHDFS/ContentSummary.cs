using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace Terradue.Hadoop.WebHDFS
{
    // todo - make abstract
    public class ContentSummary : Resource
    {
        // todo - should makt these immutable.
        public Int64 DirectoryCount { get; set; }
        public Int64 FileCount { get; set; }
        public Int64 Length { get; set; }
        public Int64 Quota { get; set; }
        public Int64 SpaceConsumed { get; set; }

        private Int64 spaceQuota;

        public Int64 SpaceQuota {
            get {
                return spaceQuota;
            }
        }

        public ContentSummary(JsonObject value)
        {
            DirectoryCount = value.Get<Int64>("directoryCount");
            FileCount = value.Get<Int64>("fileCount");
            Length = value.Get<Int64>("length");
            Quota = value.Get<Int64>("quota");
            SpaceConsumed = value.Get<Int64>("spaceConsumed");
            spaceQuota = value.Get<Int64>("spaceQuota");
            Info = value;
        }
    }
}
