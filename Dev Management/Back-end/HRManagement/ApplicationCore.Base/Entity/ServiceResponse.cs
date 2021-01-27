using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Base.Entity
{
    public class ServiceResponse
    {
        public ServiceResponse()
        {
            Success = true;
            Data = null;
            Message = null;
            Code = 200;
        }
        public Boolean Success { get; set; }

        public object Data { get; set; }

        public string Message { get; set; }

        public int Code { get; set; }
    }
}
