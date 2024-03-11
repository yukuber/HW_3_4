﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW_3_3.interfaces;
interface IParent : IPrinter
{
    double Average();
    void ReCreate(bool fill_rand);
}
