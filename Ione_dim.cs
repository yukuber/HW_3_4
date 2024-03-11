﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface Ione_dim : IParent
{
    int Length { get; }
    int this[int index] { get; set; }
}
