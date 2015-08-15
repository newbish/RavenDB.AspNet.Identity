﻿using System;
using System.Configuration;

namespace RavenDB.AspNet.Identity
{
    public class Configuration : ConfigurationSection
    {
        [ConfigurationProperty("xmlns")]
        public string XmlNS
        {
            get { return (string)this["xmlns"]; }
            set { this["xmlns"] = value; }
        }

        [ConfigurationProperty("usecustomid", DefaultValue = true, IsRequired = false)]
        public bool UseCustomId
        {
            get { return (bool)this["usecustomid"]; }
            set { this["usecustomid"] = value; }
        }
        [ConfigurationProperty("findbyindex", DefaultValue=false, IsRequired=false)]
        public bool FindByIndex
        {
            get { return (bool)this["findbyindex"]; }
            set { this["findbyindex"] = value; }
        }
    }
}
