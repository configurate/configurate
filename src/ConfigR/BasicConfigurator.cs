﻿// <copyright file="BasicConfigurator.cs" company="ConfigR contributors">
//  Copyright (c) ConfigR contributors. (configr.net@gmail.com)
// </copyright>

namespace ConfigR
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Common.Logging;
    using ServiceStack.Text;

    public class BasicConfigurator : IConfigurator
    {
        private static readonly ILog log = LogManager.GetCurrentClassLogger();
        private readonly Dictionary<string, dynamic> configuration = new Dictionary<string, dynamic>();

        public IEnumerable<KeyValuePair<string, dynamic>> Items
        {
            get { return this.configuration.Select(item => item); }
        }

        public dynamic this[string key]
        {
            get { return this.configuration[key]; }
        }

        public virtual IConfigurator Load()
        {
            return this;
        }

        public IConfigurator Add(string key, dynamic value)
        {
            log.DebugFormat(CultureInfo.InvariantCulture, "Adding '{0}': {1}", key, StringExtensions.ToJsv(value));
            this.configuration.Add(key, value);
            return this;
        }

        public bool TryGet(string key, out dynamic value)
        {
            return this.configuration.TryGetValue(key, out value);
        }
    }
}
