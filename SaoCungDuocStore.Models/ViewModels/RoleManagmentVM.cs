﻿using Microsoft.AspNetCore.Mvc.Rendering;
using SaoCungDuocStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SaoCungDuocStore.Models.ViewModels
{
    public class RoleManagmentVM
    {
        public ApplicationUser ApplicationUser { get; set; }
        public IEnumerable<SelectListItem> RoleList { get; set; }
        public IEnumerable<SelectListItem> CompanyList { get; set; }
    }
}