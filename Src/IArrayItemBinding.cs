﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSG
{
    public interface IArrayItemBinding : IBinding
    {
        int ItemIndex { get; set; }
    }
}