﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace GECP_FRONTEND_NET_CORE.Models
{
    public class VisionVM
    {
        public VisionVM()
        {
            DepartmentList = new List<SelectListItem>();
        }
        public int Id { get; set; }
        public int DeptId { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedDateInt { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedDateInt { get; set; }
        public List<SelectListItem> DepartmentList { get; set; }
    }
}