﻿using System;

namespace ITI.CIL_Cowding
{
    /// <summary>
    /// Bitwise OR of two integer values, returns an integer.
    /// </summary>
    public class OrNode : BinaryBooleanOperatorNode
    {
        int _line;
        public override int Line
        {
            get { return _line; }
        }
        public OrNode(int line)
        {
            _line = line;
        }
        protected override IValue Operator( IValue value1, IValue value2 )
        {
            IValue result;
            if ( Convert.ToBoolean( value1.Data ) || Convert.ToBoolean( value2.Data ) )
            {
                result = new Value( value1.Type, 1 );
            }
            else
            {
                result = new Value( value1.Type, 0 );
            }
            return result;
        }
    }
}
