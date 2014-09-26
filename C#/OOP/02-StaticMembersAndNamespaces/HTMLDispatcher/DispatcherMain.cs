namespace HTMLDispatcher
{
    using System;

    class DispatcherMain
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");

            div.AddElement("id", "page");
            div.AddElement("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div*2);

            Console.WriteLine();

            Console.WriteLine(HTMLDispatcher.CreateImage("D:\\Picture\\image.jpg", "Preview not available", "Snimka"));
            Console.WriteLine(HTMLDispatcher.CreateInput("text", "inputText", "This is some text"));
            Console.WriteLine(HTMLDispatcher.CreateURL("www.abv.bg", "ABV mail", "Some text"));
        }
    }
}
