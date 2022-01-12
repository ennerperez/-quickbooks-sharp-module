﻿using System.Collections.Generic;

namespace QuickBooks
{
    public class Options
    {
        public string ClientId { get; set; }
        public string OrganizationId { get; set; }
        public string ClientSecret { get; set; }
        public string RefreshToken { get; set; }
        public Dictionary<string, Module> Modules { get; set; }
        public bool Debug { get; set; }
    }
}