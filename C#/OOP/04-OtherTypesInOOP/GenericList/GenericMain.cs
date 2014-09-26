namespace GenericList
{
    using System;
    using System.Reflection;
    
    class GenericMain
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(32);

            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(i * 5);
            }

            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);
       
            list.Remove();
            Console.WriteLine("Value on position 2: {0}", list.IndexOf(2));
            list.InsertAt(4, 20);

            int max = list.Max();
            int min = list.Min();

            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Index with value 20: {0}", list.FindIndex(20)); 
            Console.WriteLine("List contains value 100: ", list.Contains(100));
            list.Clear();

            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);

            var attr = typeof(GenericList<>).GetCustomAttribute(typeof(VersionAttribute), false);
            Console.WriteLine("Version: {0}", attr);
        }
    }
}
