﻿using System;

namespace ITI.CIL_Cowding
{
    public abstract class InstructionNode : Node
    {

        public abstract void Execute( IExecutionContext ctx );
        public virtual void PreExecute(IPreExecutionContext pec)
        {
            // Nothing
        }
    }

        

}
