using PatternsForFun.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsForFun.DataObjects
{
    public abstract class Animal
    {
        public abstract void Accept(IAnimalVisitor visitor);
    }

    public class AnimalWrapper
    {
        Animal a;
        public AnimalWrapper(Animal a)
        { 
            this.a = a; 
        }

        public void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit((dynamic)a);
        }
    }
    
    public class Cat : Animal
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Dog : Animal
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Shiba : Dog
    {
        public override void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Mutant
    {
        public List<Animal> Animals { get; set; }
        public Mutant()
        {
            Animals = new List<Animal>() { new Cat(), new Dog(), new Shiba() };
        }

        public void Accept(IAnimalVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var animal in Animals)
            {
                animal.Accept(visitor);
            }            
        }
    }
}
