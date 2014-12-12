﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.CIL_Cowding
{
    public class FunctionNode : Node
    {
        string _namefct;
        string _typeOfReturn;
        List<string> _parameters;
        List<InstructionNode> _code;


        public FunctionNode(string name, string typeReturn, List<InstructionNode> code, List<string> parameters)
        {
            _namefct = name;
            _typeOfReturn = typeReturn;
            _code = code;
            _parameters = new List<string>();

            foreach(string variable in parameters) 
            {
                _parameters.Add(variable);
            }
        }
        public void PreExecute(PreExecutionContext pec)
        {
            ICILType typeReturn = pec.TypeManager.Find(_typeOfReturn);

            List<ICILType> parameters = new List<ICILType>();
            foreach (string str in _parameters)
            {
                parameters.Add( pec.TypeManager.Find( _typeOfReturn ) );
            }

            Function function = new Function( _namefct, typeReturn, parameters, _code );
        }

    }
}
















// La faute à Microsoft si les gens comprennent rien à l'informatique.





//La faute aux cassos si Apple se fait des couilles en poil de titanium.