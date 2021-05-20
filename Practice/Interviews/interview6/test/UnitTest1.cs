using System;
using Xunit;
using System.Collections.Generic;
using  interview6;
using interview6.Interfaces;
namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var players = new List<IPlayer> ()
            {
                new Player(1, "abe",0, false),
                new Player(1, "bart",0 , false)

            };
            var columnList  = new List<IColumnType>();
            for(int i=0;i<25;i++)
                columnList.Add(new VacantColumnType(i));
            var snakevsLadder = new  SnakevsLadder(columnList, players, 6); 
            
        }
    }
}
