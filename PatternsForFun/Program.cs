using PatternsForFun.DataObjects;
using PatternsForFun.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsForFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Dog d = new Dog();
            Shiba s = new Shiba();

            var visitor = new MakeSoundVisitor();
            c.Accept(visitor);
            d.Accept(visitor);
            s.Accept(visitor);

            var dynamicVisitor = new MakeSoundDynamicVisitor();
            c.Accept(dynamicVisitor);
            d.Accept(dynamicVisitor);
            s.Accept(dynamicVisitor);

            dynamicVisitor.Visit(c);
            dynamicVisitor.Visit(d);
            dynamicVisitor.Visit(s);

            Console.ReadKey();
        }
    }

}
