﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webTemplate.Web.Global.Config
{
    public interface IConfig
    {
        string ConnectionStrings(string connectionString);

        bool DebugMode { get; }

        string AdminEmail { get; }

        bool EnableMail { get; }
      
        IQueryable<MailTemplate> MailTemplates { get; }
    }
}