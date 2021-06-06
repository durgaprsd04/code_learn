using System;
using System.Collections.Generic;
using System.Linq;

namespace mineSweeper
{
    public static class CommandFactory
    {
        public static ICommand GetCommand(string inputFromUser, IGrid grid, ICell cell)
        {
            ICommand command=null;
            switch(inputFromUser)
                {
                    case "Open":
                        command = new ClickCommand(grid, cell);
                        break;
                    case "Mark":
                        command = new MarkCommand(grid, cell);
                        break;
                }
                return command;
        }
    }
}