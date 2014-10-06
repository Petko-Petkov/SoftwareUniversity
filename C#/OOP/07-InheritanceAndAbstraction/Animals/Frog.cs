namespace Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, string gender) 
            : base(name, age, gender)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("The frog quarks"); ;
        }
    }
}
