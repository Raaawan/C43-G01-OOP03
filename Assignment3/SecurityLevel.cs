﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    [Flags]
    internal enum SecurityLevel
    {
        guest=1,
        developer=2,
        secretary=4,
        DBA=8,
        FullPermissions=16
    }
}
