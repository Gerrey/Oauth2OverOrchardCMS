﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Oauth2OverOrchardCMS.DTO
{
    [Serializable]
    public class SimpleEmployeeDto
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }
    }
}