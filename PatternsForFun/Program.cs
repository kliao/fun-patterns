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
            Mutant m = new Mutant();

            var visitor = new MakeSoundVisitor();

            // Classic visitor pattern allows us to add behavior to existing objects without modifying them
            Console.WriteLine("Call Accept() using classic visitor");
            c.Accept(visitor);
            d.Accept(visitor);
            s.Accept(visitor);
            m.Accept(visitor);

            // Think of the Accept() method as a way to delegate the desired action to whichever Visitor implementation is passed in
            // Virtual functions are dispatched dynamically while function overloading is done statically.
            // To get around this, double dispatch is used
            Console.WriteLine("Testing wrapper");
            var wrappedCat = new AnimalWrapper(c);
            wrappedCat.Accept(visitor);

            var dynamicVisitor = new MakeSoundDynamicVisitor();

            Console.WriteLine("Call Accept() using dynamic visitor");
            c.Accept(dynamicVisitor);
            d.Accept(dynamicVisitor);
            s.Accept(dynamicVisitor);
            m.Accept(dynamicVisitor);

            Console.WriteLine("Direct call to dynamic visitor");
            dynamicVisitor.Visit(c);
            dynamicVisitor.Visit(d);
            dynamicVisitor.Visit(s);
            dynamicVisitor.Visit(m);
            Console.ReadKey();
        }
    }

}
