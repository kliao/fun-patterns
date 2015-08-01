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

            var visitor = new MakeSoundVisitor();
            c.Accept(visitor);
            d.Accept(visitor);

            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract void Accept(IAnimalVisitor visitor);
    }

    public class Cat : Animal {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Dog : Animal {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IAnimalVisitor
    {
        void Visit(Cat cat);
        void Visit(Dog dog);
    }

    public class MakeSoundVisitor : IAnimalVisitor
    {
        public void Visit(Cat cat) { Console.WriteLine("Meow"); }
        public void Visit(Dog dog) { Console.WriteLine("Woof"); }
    }
}
