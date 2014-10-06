namespace Animals
{
    using System;

    class Dog : Animal, ISound
    {
        public Dog(string name, int age, string gender) 
            : base(name, age, gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("The dog barks!");
        }
    }
}
