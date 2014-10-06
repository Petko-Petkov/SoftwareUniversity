namespace Animals
{
    using System;

    public abstract class Cat : Animal, ISound
    {
        public Cat(string name, int age, string gender)
            :base(name, age, gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("The cat myauuu");
        }
    }
}
