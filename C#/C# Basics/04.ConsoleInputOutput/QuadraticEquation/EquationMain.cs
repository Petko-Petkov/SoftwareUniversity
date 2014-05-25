/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). */
using System;
using System.Text;

class QuadraticEquation
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        double aNum = 0;
        double bNum = 0;
        double cNum = 0;
        double root1 = 0;
        double root2 = 0;
        double doubleRoot = 0;
        bool checkInput = false;
        while (!(checkInput && aNum != 0))
        {
            Console.Write("\n\nPlease input a (must be !=0): ");
            checkInput = double.TryParse(Console.ReadLine(), out aNum);
            Console.Write("\nPlease input b: ");
            checkInput = checkInput && double.TryParse(Console.ReadLine(), out bNum);
            Console.Write("\nPlease input c: ");
            checkInput = checkInput && double.TryParse(Console.ReadLine(), out cNum);
        }
        double discriminant = (bNum * bNum) - (4 * aNum * cNum);
        if (discriminant > 0)
        {
            root1 = (-bNum + Math.Sqrt(discriminant)) / (aNum * 2);
            root2 = (-bNum - Math.Sqrt(discriminant)) / (aNum * 2);
            Console.WriteLine("\n\nQuadratic equation ax\u00b2+bx+c=0 have two real roots: {0} and {1}\n", root1, root2);
        }
        else if (discriminant == 0)
        {
            doubleRoot = -bNum / (2 * aNum);
            Console.WriteLine("\n\nQuadratic equation ax\u00b2+bx+c=0 have one real (double) root: {0}\n", doubleRoot);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("\n\nQuadratic equation ax\u00b2+bx+c=0 have no real roots!\n");
        }
    }
}