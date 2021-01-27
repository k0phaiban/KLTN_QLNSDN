using ApplicationCore.Service.Controllers;
using ApplicationCore.Service.Interface;
using HRManagement.BL.Interface;
using HRManagement.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.API.Controllers
{
    [Route("/api/[controller]/")]
    [ApiController]
    public class ContractController : BaseController<Contract>
    {
        public ContractController(IContractBL contractBL, IBaseBL baseBL):base(baseBL)
        {
            this.BL = contractBL;
            this.curentType = typeof(Contract);
        }
        
    }
}
