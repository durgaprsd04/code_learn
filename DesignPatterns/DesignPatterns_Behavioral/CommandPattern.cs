using System.Collections.Generic;
namespace DesignPatterns_Behavioral
{
    public abstract class Command
    {
        protected char _operator;
        protected double _operand;
        protected CalcReciever _calcReciever;
        public abstract void Execute();
        public abstract void UnExecute();
    }
    public class CalcReciever
    {
        public double CurVal{get;set;}
        public void Operation(char operator1, double operand)
        {
            switch(operator1)
            {
                case '+':CurVal+=operand;break;
                case '-':CurVal-=operand;break;
                case '*':CurVal*=operand;break;
                case '/':CurVal/=operand;break;
            }
        }
        public char UndoOperand(char operand)
        {
            if(operand=='+')
                return '-';
            if(operand=='-')
                return '+';
            if(operand=='*')
                return '/';
            if(operand=='/')
                return '*';
            return '?';
        }
    }
    public class CalcCommand :Command
    {
        public CalcCommand(char operator1, double operand, CalcReciever calcReciever)
        {
            this._operand=operand;
            this._operator=operator1;
            this._calcReciever = calcReciever;
        }
        public override void  Execute()
        {
            _calcReciever.Operation(_operator, _operand);
        }
        public override void UnExecute()
        {
            var oppchar = _calcReciever.UndoOperand(_operator);
            _calcReciever.Operation(oppchar, _operand);
        }
    }
    public class Client
    {
        
        CalcReciever calc = new CalcReciever();
        int _current=0;
        private List<Command> _listOfCommands=new List<Command>();
        public Client(){
            calc.CurVal=50;
        }        
        
        public void Compute(char operator1, double operand)
        {
            CalcCommand command = new CalcCommand(operator1, operand, calc);
            command.Execute();
            _listOfCommands.Add(command);
            _current++;
        }
        public void Undo(int levels)
        {
         _listOfCommands.Reverse();
         foreach(var command in _listOfCommands)
         {
             if(levels==0)
             break;
             command.UnExecute();
             _current--;
             levels--;
         }
         _listOfCommands.Reverse();
        }
        public void Redo(int levels)
        {
            foreach(var command in _listOfCommands)
            {
                command.Execute();
                _current++;
            }
        }
        public double currentValue()
        {
            return calc.CurVal;
        }

    }
}