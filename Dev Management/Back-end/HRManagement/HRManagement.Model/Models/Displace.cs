using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HRManagement.Model.Models
{
    public class Displace
    {
        [Key]
        public int DisplaceID { get; set; }

        public string DisplaceName { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeCode { get; set; }

        public DateTime? Date { get; set; }

        public DateTime? DateApply { get; set; }

        public string JobtitleName { get; set; }

        public int JobtitleID { get; set; }

        public int OrganizationID { get; set; }

        public string OrganizationName { get; set; }

        public string CreatorName { get; set; }

        public int CreatorID { get; set; }

        public string Note { get; set; }

        public string NewJobtitleName { get; set; }

        public int NewJobtitleID { get; set; }

        public string NewOrgazitionName { get; set; }

        public int NewOrgazitionID { get; set; }
    }
}
