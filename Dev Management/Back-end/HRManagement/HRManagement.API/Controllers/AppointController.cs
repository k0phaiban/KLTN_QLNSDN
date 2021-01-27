using ApplicationCore.Service.Controllers;
using ApplicationCore.Service.Interface;
using HRManagement.BL.Interface;
using HRManagement.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.API.Controllers
{
    [Route("/api/[controller]/")]
    [ApiController]
    public class AppointController : BaseController<Appoint>
    {
        public AppointController(IAppointBL appointBL, IBaseBL baseBL) : base(baseBL)
        {
            this.BL = appointBL;
            this.curentType = typeof(Appoint);
        }
    }
}
