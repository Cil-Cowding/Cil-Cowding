﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public interface IFunction
    {
        String GetSignature();

        void AddLocalVariable(IValue var);
        IValue GetLocalVariable(int index);
        IValue SetLocalVariable(IValue var);

        //List<IInstructionNode> GetInstructions();

    }
}
