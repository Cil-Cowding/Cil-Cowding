﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public class StlocNode : InstructionNode
    {
        string _label;

        public StlocNode(string label)
        {
            _label = label;
        }

        public override void Execute(IExecutionContext ctx)
        {
            throw new NotImplementedException();
        }
        // Constructeur 1 param
    }
}
