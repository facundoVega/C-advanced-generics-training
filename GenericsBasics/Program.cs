using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salaries salaries = new Salaries();

            var salaryList = salaries.GetSalaries();

            float salary = salaryList[1];

            salary = salary + (salary * 0.02f);

            Console.WriteLine(salary);

            Console.ReadKey();
        }
    }

    public class Salaries
    {
        List<float> _salaryList = new List<float>(); 
        public Salaries()
        {
            _salaryList.Add(60000.34f);
            _salaryList.Add(40000.51f);
            _salaryList.Add(20000.23f );

        }

        public List<float> GetSalaries()
        {
            return _salaryList;
        }
    }
}