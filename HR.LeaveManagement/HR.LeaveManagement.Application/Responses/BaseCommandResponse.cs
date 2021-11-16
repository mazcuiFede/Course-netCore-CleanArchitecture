﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Responses
{
    public class BaseCommandResponse
    {
        public int Id { get; set; }
        public bool Sucess { get; set; } = true;
        public string Message { get; set; }
        public List<string> Errors { get; set; }
    }
}
