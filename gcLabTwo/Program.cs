using System;

namespace gcLabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = false;
            do
            {
                Console.WriteLine("Hello, this application will be used to calculate the area, perimeter, and volume of your classroom!\n");

                Console.Write("Enter length: ");
                String inputOne = Console.ReadLine();
                double Length;
                double.TryParse(inputOne, out Length);

                Console.Write("Enter width: ");
                String inputTwo = Console.ReadLine();
                double Width;
                double.TryParse(inputTwo, out Width);

                Console.Write("Enter height: ");
                String inputThree = Console.ReadLine();
                double Height;
                double.TryParse(inputThree, out Height);

                Console.WriteLine("\nPerimeter: " + ((Length * 2) + (Width * 2)) + "ft");
                Console.WriteLine("Area: " + (Length * Width) + "ft");
                Console.WriteLine("Volume: " + (Length * Width * Height) + "ft");

                Console.WriteLine("Would you like to calculate another room? y/n");
                string response = Console.ReadLine();

                if (response == "y")
                {
                    isContinue = true;
                }

                else
                {
                    isContinue = false;
                }

            } while (isContinue == true);
                       
        }
    }
}
