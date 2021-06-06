using System;
using System.Linq;
using System.Collections.Generic;
namespace mineSweeper
{
    public class User : IUser
    {
        private IInput input;
        public User(IInput input)
        {
            this.input = input;
        }

        public ICell GetCell()
        {
            return input.GetCellFromInput();
        }

        public ICommand GetInput(IGrid grid)
        {
            var cell = GetCell();
            return CommandFactory.GetCommand(input.GetCommand(), grid, cell);
        }
    }
}