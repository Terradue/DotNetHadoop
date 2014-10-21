using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Text;

namespace Terradue.Hadoop
{
    public abstract class Resource
    {
        public JsonObject Info { get; set; }
    }

    public enum Version
    {
        V1
    }

    //public enum TypeOfJob
    //{
    //    Hive,
    //    Pig,
    //    MapReduce
    //}
}
