using System;
using System.Collections.Generic;
using System.Text;

namespace CC.ApplicationCore.Entity
{
    class ServiceResponse
    {
        public ServiceResponse()
        {
            Success = true;
            Data = null;
            Message = null;
            Validate = null;
        }
        public Boolean Success { get; set; }

        public object Data { get; set; }

        public string Message { get; set; }

        public object Validate { get; set; }
    }
}
