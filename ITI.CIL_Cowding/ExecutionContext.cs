﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public class ExecutionContext : IExecutionContext
    {
        Stack _stack;
        List<IFunction> _code;
        IEngine _engine;


        public IStack Stack
        {
            get { return _stack; }
        }

        public IHeap Heap
        {
            get { throw new NotImplementedException(); }
        }

        public ExecutionContext(List<IFunction>code, IEngine engine)
        {

            _stack = new Stack(engine);
            _engine = engine;

            // Initialisation du code
            _code = code;
            // Pour le moment on ne lance que la première fct, mais après on lancera la fct Main
            _stack.CallFunction(_code[0]);

        }

            
        public bool NextInstruction () {

            if (_stack.LastFrame == null)
            {
                return false;
            }
            InstructionNode IN = _stack.LastFrame.CurrentInstruction;
            IN.Execute(this); 

            // On passe à l'instruction suivante
            if(_stack.LastFrame == null) 
            {
                return false ;
            } 
            else 
            {
                _stack.LastFrame.NextInstruction();
            }


            return true;
            
        }

    }
}
