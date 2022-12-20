﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALogger.Tools.Interfaces
{
    public interface IDisplay
    {
        public static HttpRequest _request;

        public void display(DateTime date, string log_level, string message, string className, string appName, int line, string memberName);
    }
}
