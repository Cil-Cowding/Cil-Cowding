﻿using System;

namespace ITI.CIL_Cowding
{
    /// <summary>
    /// 
    /// </summary>
    public class ReadNode : InstructionNode
    {
        int _line;
        public override int Line
        {
            get { return _line; }
        }
        public ReadNode(int line)
        {
            _line = line;
        }
        public override void Execute( IExecutionContext ctx )
        {
            Console.Write("Input ==> ");
            string read = Console.ReadLine();
            object toint;
            CILNetType type;
            Value value;

            try {

                toint = Int32.Parse(read);
                type = new CILNetType(typeof (int));

            } catch {

                type = new CILNetType(typeof(string));
                toint = null;

            }
            

            if(toint == null) {

                value = new Value(type, read);
            }
            else
            {
                value = new Value(type, toint);
            }

            ctx.Stack.Push( value );
        }
    }
}
