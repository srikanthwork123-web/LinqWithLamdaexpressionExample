using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithLamdaexpressionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamda expression  Query output");
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            //MethodSyntaxLinq: Datasource.Conditionmethod(lamdaexpression)
            //Lamdaexpression Synatx:(parameters) => expression/ConditionLogic
            //       =>   we called this one as goes to
            var methodSyntax = list.Where(a => a > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            //=======================================================================================
            Console.WriteLine("Normal Linq Query output");
            //Normal LinqSyntax:var query=from object in datasource
            //where condition
            //Select object;
            var query = from obj in list
                        where obj > 2
                        select obj;//select * fom list

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
/*output:
Lamda expression  Query output
3
4
5
6
Normal Linq Query output
3
4
5
6
