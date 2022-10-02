﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHTTP.HTTP.Common
{
    public class CoreValidator
    {
        public static void ThrowIfNull(object obj,string name)
        {
            if(obj==null)
            {
                throw new ArgumentException(name);
            }
        }

        public static void ThrowIfNullOrEmpty(string text,string name)
        {
            if(string.IsNullOrEmpty(text))
            {
                throw new ArgumentException(message: $"{name}cannot be null or empty.", name);
            }
        }
    }
}
