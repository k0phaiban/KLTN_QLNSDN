using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Base.Entity
{
    public class PagingRequest
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string Filter { get; set; }
    }
}
