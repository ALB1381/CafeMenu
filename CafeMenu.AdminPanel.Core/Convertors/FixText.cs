﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.AdminPanel.Core.Convertors
{
    public class FixText
    {
        public static string FixEmaail(string Email)
        {
            return Email.Trim().ToLower();
        }
    }
}
