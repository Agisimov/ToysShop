﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prod163.DB;

namespace Prod163.ClassHelper
{
    class EFClass
    {
        public static Entities context { get; set; } = new Entities();

    }
}
