using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAnimal
    {
        void MakeSound();
        void EatFood(string food);

    }

    public class Dog : IAnimal
    {
        public void EatFood(string food)
        {
            Console.WriteLine("Cat Eat ");
        }

        public void MakeSound()
        {
            Console.WriteLine("Cat Makes Sound ");
        }
    }
    public class Cat : IAnimal

    {
        public void EatFood(string food)
        {
            Console.WriteLine("Dog Eat ");
        }

        public void MakeSound()
        {
            Console.WriteLine("Dog Makes Sound ");
        }
    }
    public class ProgramInterface
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.EatFood("Burger");

            Cat cat = new Cat();
            cat.MakeSound();
            cat.EatFood("Fish");
        }
    }
}
