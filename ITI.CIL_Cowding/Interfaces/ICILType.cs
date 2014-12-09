﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public interface ICILType
    {
        string FullName { get; }

        /// <summary>
        /// Gets whether this type suports Addition Subtraction Multiplication  and Division
        /// </summary>
        bool IsNumeric { get; }

        bool IsNetType { get; }

        /// <summary>
        /// Gets the actual .net type: null if <see cref="IsNetType"/> is false.
        /// </summary>
        Type NetType { get; }

        bool IsValueType { get; }

        /// <summary>
        /// Gets the size of this type in Bytes on the stack (4 for reference types).
        /// </summary>
        int StackSize { get; }

    }
}