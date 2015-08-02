using PatternsForFun.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsForFun.Visitors
{
    public abstract class DynamicVisitor : IAnimalVisitor
    {
        public void Visit(Animal animal)
        {
            (this as dynamic).Visit((dynamic)animal);
        }

        public abstract void Visit(Dog dog);
        public abstract void Visit(Cat cat);
        public abstract void Visit(Shiba shiba);
    }

    public class MakeSoundDynamicVisitor : DynamicVisitor
    {
        public override void Visit(Dog dog) { Console.WriteLine("Dynamic Woof"); }
        public override void Visit(Cat cat) { Console.WriteLine("Dynamic Meow"); }
        public override void Visit(Shiba shiba) { Console.WriteLine("Dynamic Hmph"); }
    }
}
