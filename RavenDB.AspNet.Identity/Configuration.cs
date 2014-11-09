﻿using System;
using System.Configuration;

namespace RavenDB.AspNet.Identity
{
    public class Configuration : ConfigurationSection
    {
        [ConfigurationProperty("usecustomid", DefaultValue = true, IsRequired = false)]
        public bool UseCustomId
        {
            get { return (bool)this["usecustomid"]; }
            set { this["usecustomid"] = value; }
        }
    }
}