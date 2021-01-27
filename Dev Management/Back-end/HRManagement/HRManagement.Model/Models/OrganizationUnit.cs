using ApplicationCore.Base.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagement.Model.Models
{
    public class OrganizationUnit : BaseModel
    {
        public int? OrganizationUnitID { get; set; }

        public string OrganizationUnitName { get; set; }

        public int? ParentID { get; set; }

        public string CCCode { get; set; }

        public string Address { get; set; }

        public int? Status { get; set; }

        public string Note { get; set; }

        public int? TenantID { get; set; }
    }
}
