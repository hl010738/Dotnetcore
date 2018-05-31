using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationDemo.Common
{
    public class ResponseMsg
    {
        public Int32 code { get; set; }

        public String message { get; set; }

        public Object body { get; set; }

        public ResponseMsg(int code, string message, object body)
        {
            this.code = code;
            this.message = message;
            this.body = body;
        }

        public static ResponseMsg Success(object body)
        {
            return new ResponseMsg(200, "Success", body);
        }

        public ResponseMsg(){ }

    }
}
