using System;

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        } 
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog(); // mammal이 Dog 객체 참조
            Dog     dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat(); // Mammal클래스의 mammal2는 Cat클래스를 참조한다

            Cat cat = mammal2 as Cat;
            if (cat != null)
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not a Cat");
            }
        }
    }
}
