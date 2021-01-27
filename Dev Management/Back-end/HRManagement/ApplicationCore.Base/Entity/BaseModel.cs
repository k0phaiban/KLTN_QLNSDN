using ApplicationCore.Base.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Base.Entity
{
    public class BaseModel
    {
        public object OldData { get; set; }

        public ModelState? State { get; set; }

    }
}
