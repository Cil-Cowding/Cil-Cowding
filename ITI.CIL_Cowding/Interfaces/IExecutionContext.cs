﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public interface IExecutionContext
    {
        IStack Stack
        {
            get;
        }
        IHeap Heap
        {
            get;
        }
        int CurrentLine
        {
            get;
        }

    }
}