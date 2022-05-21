using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsDogs
{
    class Cat : Animal
    {
        private string fur;
        public Cat() { }
        public Cat(string name, string moving, string fur) : base(name, moving)
        {
            this.fur = fur;
        }

        public override string AnimalSay()
        {
            return "Cat says meow";
        }
        public override void Move()
        {
            Console.WriteLine("Cat moves fast");
        }
        public override void Move(string moving)
        {
            if (moving.Equals("jumps"))
            {
                Console.WriteLine("Cat jumps");
            }
            else
            {
                Console.WriteLine("Cat walks.");

            }
        }


    }

    class Dog : Animal
    {
        public Dog() { }
        public Dog(string name, string moving):base(name, moving)
        {
            this.name = name;
            this.moving = moving;
        }

        public override string AnimalSay()
        {
            return "Dog says woof";
        }
        public override void Move()
        {
            Console.WriteLine("Dogs run");
        }
        public override void Move(string moving)
        {
            if (moving == "fly")
            {
                Console.WriteLine("Dogs dont fly");

            }
            else if ( moving.Equals("jump")) {
                Console.WriteLine("Dogs jump");

            }
            else 
            {
                Console.WriteLine("Dogs run");
            }
        }


    }

    abstract class Animal
    {
        // vseki class ima poleta, konstruktori i metodi
        // abstract class ima kontruktori, properti i deklaraciq na metodi

        //constructor , prazen i s parametri
        public Animal() { }
        public Animal(string name, string moving)
        {
            this.name = name;
            this.moving = moving;
        }
        //property
        public string name { get; set; }
        public string moving { get; set; }

        //method
        public /* vidim v tozi klas i negovite naslednici */  abstract string AnimalSay();
        // deklaraciqta na method v abstract class(^): kaks e kazva, tip na vrushtane i eventualno dali chaka danni ili ne 
        // virtual methoda moje da bude prezapisan po dr nachin v naslednicite na klasa
        public abstract void Move();
        public abstract void Move(string moving);

        public static void PrintAnimal(Animal a)
        {
            Console.WriteLine($" {a.name} moves like {a.moving}");
        }

        // vs nasledstven klas tr da ima vsichki methodi ot abstractniq
        // kato se zamenq abstract s override i se pishat harakteristiki za suotvetniq naslednik
       
        
    }




    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Cat("Mimi", "walks", "black");
            Animal.PrintAnimal(a1);
            a1.Move(); // izpulnqva za cat
            a1 = new Dog("Gosho", "jump");
            Animal.PrintAnimal(a1); // tui kato printanimal e static tr da mu podadem obekt za koito da izvurshi deistvieto
            a1.Move(); //izpulnqwa za dog
            Animal d1 = new Dog("Roki", "roll");
            Console.WriteLine(d1.AnimalSay());
            Console.WriteLine(a1.AnimalSay());

        }


    }
}
