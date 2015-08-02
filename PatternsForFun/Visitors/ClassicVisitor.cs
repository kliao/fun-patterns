using PatternsForFun.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsForFun.Visitors
{
    public interface IAnimalVisitor
    {
        void Visit(Cat cat);
        void Visit(Dog dog);
        void Visit(Shiba shiba);
    }

    public class MakeSoundVisitor : IAnimalVisitor
    {
        public void Visit(Cat cat) { Console.WriteLine("Classic Meow"); }
        public void Visit(Dog dog) { Console.WriteLine("Classic Woof"); }
        public void Visit(Shiba shiba) { Console.WriteLine("Classic Hmph"); }
    }
}
