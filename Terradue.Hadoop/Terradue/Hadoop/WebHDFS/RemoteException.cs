using System;
using ServiceStack.Text;
using System.Net;

namespace Terradue.Hadoop.WebHDFS {
    public class RemoteException : Resource {

        // todo - should makt these immutable.
        public string Exception { get; set; }
        public string JavaClassName { get; set; }
        public string Message { get; set; }

        public RemoteException() {
        }


        public RemoteException(JsonObject value)
        {
            Exception = value.Get<string>("exception");
            JavaClassName = value.Get<string>("javaClassName");
            Message = value.Get<string>("message");
            Info = value;
        }

        public Exception GetException (){
            if (Message.Contains("org.apache.hadoop.hdfs.server.namenode.SafeModeException"))
                return new SafeModeException(Message);
            return new WebException(this.Message);
        }

    }
}

