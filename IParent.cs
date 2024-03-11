﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IParent : IPrinter
{
    double Average();
    void ReCreate();
}
