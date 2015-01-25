﻿using System;

namespace ITI.bacASable
{
    /// <summary>
    /// Pop a value from stack into local variable.
    /// </summary>
    public class StlocNode : InstructionNode
    {
        private int _index;
        public StlocNode( int index, int line )
            : base( line )
        {
            _index = index;
        }
        public override void Execute( IExecutionContext ctx )
        {
            ctx.Stack.SetLocalVar( ctx.Stack.Pop(), _index );
        }
    }
}