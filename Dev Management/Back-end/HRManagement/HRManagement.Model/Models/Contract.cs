using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManagement.Model.Models
{
    public class Contract
    {
        [Key]
        public Guid? ContractID { get; set; }

        public string ContractName { get; set; }

        public int? EmployeeID { get; set; }

        public string EmployeeCode { get; set; }

        public string EmployeeName { get; set; }

        public int? OrganizationUnitID { get; set; }

        public string OrganizationUnitName { get; set; }

        public int? Type { get; set; }

        public int? CreatorID { get; set; }

        public string CreatorName { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public string JobtitleName { get; set; }

        public int? JobtitleID { get; set; }

        public int? Salary { get; set; }

        public string Note { get; set; }
    }
}
