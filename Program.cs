using System;

namespace Game
{
    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.

    abstract class CannibalGame
    {
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod()
        {
            this.Catch();
            this.NoneOptinalOperations1();
            this.Eat();
            this.Hook1();
            this.NoneOptinalOperations2();
            this.Sleep();
            this.Hook2();
        }

        // These operations already have implementations.
        protected void Catch()
        {
            Console.WriteLine("Catch");
        }

        protected void Eat()
        {
            Console.WriteLine("Eaten");

        }

        protected void Sleep()
        {
            Console.WriteLine("Fallen asleep");
        }

        // These operations have to be implemented in subclasses.
        protected abstract void NoneOptinalOperations1();

        protected abstract void NoneOptinalOperations2();

        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation.
        protected virtual void Hook1() { }

        protected virtual void Hook2() { }
    }

    // Concrete classes have to implement all abstract operations of the base
    // class. They can also override some operations with a default
    // implementation.
    class FirstCannibal : CannibalGame
    {
        protected override void NoneOptinalOperations1()
        {
            Console.WriteLine("Fried");
        }

        protected override void NoneOptinalOperations2()
        {
            Console.WriteLine("Devoured");


        }
    }

    // Usually, concrete classes override only a fraction of base class'
    // operations.
    class SecondCannibal : CannibalGame
    {
        protected override void NoneOptinalOperations1()
        {
            Console.WriteLine("Chat");
        }

        protected override void NoneOptinalOperations2()
        {
            Console.WriteLine("Boil");
        }

        protected override void Hook1()
        {
            Console.WriteLine("Rest");
        }
    }

    class Client
    {
        // The client code calls the template method to execute the algorithm.

        public static void ClientCode(CannibalGame abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Cannibal:");

            Client.ClientCode(new FirstCannibal());

            Console.Write("\n");

            Console.WriteLine("Second Cannibal:");
            Client.ClientCode(new SecondCannibal());

        }
    }
}