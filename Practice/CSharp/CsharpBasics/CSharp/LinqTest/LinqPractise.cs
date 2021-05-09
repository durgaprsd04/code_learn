using System.Linq;
using System.Collections.Generic;
using System;

namespace CSharp.LinqPractise
{
    public class Employee
    {
        public Employee(int id, string name, double salary)
        {
            this.id=id;
            this.name = name;
            this.salary = salary;
        }
        public int id;
        public string name;
        public double salary;
        public override string ToString()
        {
            return $"Emp id {id} name {name} salary {salary}";
        }
    }
    public class EmployeeCallerFunction
    {
        public static IEnumerable<Employee> GetListOfEmployees()
        {
            return new List<Employee> {new Employee(1, "Ram",900),
                                        new Employee(2, "Seetha", 1200),
                                        new Employee(3, "Laxamn", 2000)
            };
        }
    }
    public class LinqPractise
    {
        public static bool FindEmployees(Employee e)
        {
            return e.salary>10000;
        }
        public IEnumerable<Employee> Practise()
        {
            var result = EmployeeCallerFunction.GetListOfEmployees();
            return result.Where(x =>x.salary>1000).OrderBy( Employee => Employee.name);
        }
        public IEnumerable<Employee> PractiseWithPredicate(Predicate<Employee> p)
        {
            var result = EmployeeCallerFunction.GetListOfEmployees();
            return result.Where(  x=> x.salary>1000).OrderBy( Employee => Employee.name);
        }
        public IEnumerable<int> GetPrime(int n)
        {
            for(int i=2;i< n;i++)
            {
                if(isPrime(i))
                    yield return i;
            }
        }
        public IEnumerable<int> GetSquare(int n)
        {
            return Enumerable.Range(1, n ).Select(x => x^2);
        }
        public IEnumerable<int> GetPrimeEnum(int n, Func<int, bool>  func)
        {
            return Enumerable.Range(2, n).Where( x => isPrime(x));
        }
        public bool isPrime(int n )
        {
            var flag =true;
            for(int i=2;i<Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    flag=false;
                    break;
                }
            }
            return flag;
        }   
    }
}