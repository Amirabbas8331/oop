using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    abstract class animal
    {
        public abstract void animalsound();
        public void sound()
        {
            Console.WriteLine("Zzz");
        }
        public abstract void animalmovement();
        public void move()
        {
            Console.WriteLine("clap clap");
        }
        public abstract void animalfood();
        public void eat()
        {
            Console.WriteLine(" yummy yummy");
        }

    }
    class Dog  :animal
    { 
        public override void animalsound() 
        {
            Console.WriteLine("The Dog says Bark Bark");
        }
        public override void animalmovement()
        {
            Console.WriteLine("The Dog moves fast and has 4 feet");
        }
        public override void animalfood()
        {
            Console.WriteLine("The Dog eats bone and meet");
        }
    }
    class Horse : animal
    {
        public override void animalsound()
        {
            Console.WriteLine("The Horse Neighs");
        }
        public override void animalmovement()
        {
            Console.WriteLine("The Horse trots and has 2 feet");
        }
        public override void animalfood()
        {
            Console.WriteLine("The Horse eats grass and hay");
        }
        class sparrow : animal
        {
            public override void animalsound()
            {
                Console.WriteLine("The sparrow have series of chrrup notes");
            }
            public override void animalmovement()
            {
                Console.WriteLine("The sparrow flies and has 2 feet and wings");
            }
            public override void animalfood()
            {
                Console.WriteLine("The sparrow eats seeds like sunflower and safflower seed and cracked corn");
            }
            internal class Program
            {
                static void Main(string[] args)
                {
                    Dog mydog = new Dog();
                    mydog.animalsound();
                    mydog.sound();
                    mydog.animalmovement();
                    mydog.move();
                    mydog.animalfood();
                    mydog.eat();
                    Horse myhorse = new Horse();
                    myhorse.animalsound();
                    myhorse.sound();
                    myhorse.animalmovement();
                    myhorse.move();
                    myhorse.animalfood();
                    myhorse.eat();
                    sparrow mysp = new sparrow();
                    mysp.animalsound();
                    mysp.sound();
                    mysp.animalmovement();
                    mysp.move();
                    mysp.animalfood();
                    mysp.eat();
                    Console.ReadKey();
                }
            }
        }
    }
}
