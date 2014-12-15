﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public class LocalsInitNode : InstructionNode
    {
        List<IValue> _localsVars;
        List<string> _types;
        public LocalsInitNode(List<string> types)
        {
            _types = types;
            _localsVars = new List<IValue>();
           
        }
        public void PreExecute(PreExecutionContext pec)
        {
            foreach (string str in _types)
            {
                _localsVars.Add( new Value( pec.TypeManager.Find( str ), null ) );
            }
        }
        public override void Execute( IExecutionContext ctx )
        {
            throw new NotImplementedException();
        }
    }
}