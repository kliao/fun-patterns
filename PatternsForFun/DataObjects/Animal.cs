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

}
