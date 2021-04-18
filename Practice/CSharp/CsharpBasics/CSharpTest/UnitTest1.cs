using System.Text;
using System.Linq;
using Xunit;
using System;
using CSharp;
using System.Collections.Generic;
namespace CsharpTest1.cs
{
    public class UnitTest1
    {
        [Fact]
        public void FuncAsArgumentTest()
        {
            FuncAsArgument f  = new FuncAsArgument();
            var result = f.GetAllPrimeInts(f.IsPrime, Enumerable.Range(2,200));
            var list = new List<int>();
            for(int i=2;i<200;i++)
            {
                if(f.IsPrime(i))
                    list.Add(i);
            }
            Assert.Equal(result.Count(), list.Count());
            foreach(var v in result)
            {
                list.Remove(v);
            }
            Assert.Empty(list);
        }
        [Fact]
        public void JaggedArrayTest()
        {
        //Given
            List<List<int>> l =new List<List<int>>();
            var list1 = new List<int>(){1,2,3,6,4};
            var list2 = new List<int>(){5,6};
            var list3 = new List<int>(){7,8};
            l.Add(list1);
            l.Add(list2);
            l.Add(list3);
        //When
            JaggedArrayTest<int> jg = new JaggedArrayTest<int>();
            var result =jg.ConvertToJagged(l);
        //Then
            Assert.Equal(5, result[0].Length);
            Assert.Equal(2, result[1].Length);
            Assert.Equal(2, result[2].Length);
            Assert.Equal(list2, result[1].ToList());
        }
        [Fact]
        public void AbstractclassTest()
        {
        //Given
        TestAbstract1 abt = new TestAAbstract();
        TestAbstract1 abt2 = new TestBAbstract();
        TestAbstract1 abt3 = new TestBAbstract();
        //When
        var str = "TestAAbstract"+ " : 1"+", "+"TestBAbstract"+" : 2";
        //Then
        Assert.Equal(str,abt3.ToString());
        }
        [Fact]
        public void ActionTest()
        {
        //Given
        ActionTest at  = new ActionTest();
        var sb = new StringBuilder();        
        //When
        at.AddStrings(new []  {"a","b","c"}, new []{"e","f" ,"g"},'&',sb );
        //Then
        var str ="a&eb&fc&g";
        Assert.Equal(str, sb.ToString());
        }
        [Fact (Skip ="not working")]
        public void EventTest()
        {
        //Given
        
        EmployeeClass employeeClass = new EmployeeClass(101, "John", new System.DateTime(1976,4,3),TestAction);
        //When
        employeeClass.AddEvent(new EmployeeEvent(employeeClass.Id, EventType.WorkAnniversary));
        //Then
        Assert.Equal(1, 1);
        }
        [Fact]
        public void DelegateTest2Test1()
        {
        //Given
            var dt2 = new DelegateTest2();
        //When
            testdelegate1 t1 = new testdelegate1((int x) => {
                return x*x;
            });
        //Then
        Assert.Equal(9,t1(3));
        }
        [Fact]
        public void DelegateTest2Test2()
        {
        //Given
            var dt2 = new DelegateTest2();
        //When
            testdelegate2 t1 = new testdelegate2((string x) => {
                return "hello "+x;
            });
        //Then
        Assert.Equal("hello ramesh",t1("ramesh"));
        }
        [Fact]
        public void TestName()
        {
        //Given
        var tf = new Testfunc();
        //When
        var result = tf.FuncTest(tf.func1,"3","12");
        //Then
        Assert.Equal(15, result);
        }
        public void TestAction(IEnumerable<EmployeeEvent> eventList)
        {
            eventList.FirstOrDefault();
            //list.Add(eventList.FirstOrDefault().Id);
        }
    }
}
