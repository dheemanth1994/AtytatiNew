﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Atyati.Models
{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static List<Employee> GetObject(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(List<Employee>) : JsonConvert.DeserializeObject<List<Employee>>(value);
        }
    }
}
