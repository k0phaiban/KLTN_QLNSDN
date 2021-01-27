﻿using ApplicationCore.Service.Controllers;
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
    public class OrganizationUnitController : BaseController<OrganizationUnit>
    {
        public OrganizationUnitController(IOrganizationUnitBL organizationUnitBL, IBaseBL baseBL) : base(baseBL)
        {
            baseBL.SetTableName("organization_unit");
            this.BL = organizationUnitBL;
            this.curentType = typeof(OrganizationUnit);
        }
    }
}
