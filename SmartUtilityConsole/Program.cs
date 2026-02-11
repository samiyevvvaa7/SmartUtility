b:
Console.WriteLine("===== Smart Utility Console App=====");
Console.WriteLine("" +
    "1. Number Analyzer\r\n" +
    "2. Geometry Zone\r\n" +
    "3. Text Tools\r\n" +
    "4. Exit");
Console.Write("Select a utility (1-4): ");
int choice = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
    command1:
        Console.Clear();
        Console.WriteLine("===Number Analyzer====");
        Console.WriteLine("" +
            "1. Son juft yoki toqligini aniqlash\r\n" +
            "2. Son musbat, manfiy yoki nol ekanini aniqlash\r\n" +
            "3. Sonning kvadrati va kubini chiqarish\r\n" +
            "4. Exit");
        Console.Write("Enter your command(1-4): ");
        int insideCommand = Convert.ToInt32(Console.ReadLine());
        int number = 0;
        if (insideCommand == 1)
        {
            Console.Write("Enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
        else if (insideCommand == 2)
        {
            Console.Write("Enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
        else if (insideCommand == 3)
        {
            Console.Write("Enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The square of {number} is {Math.Pow(number, 2)}.");
            Console.WriteLine($"The cube of {number} is {Math.Pow(number, 3)}.");
        }
        else if (insideCommand == 4)
        {
            Console.Write("Return main Menu:(y/n) ");
            string returnMainMenu = Console.ReadLine();
            if (returnMainMenu.ToLower() == "y" || returnMainMenu.ToLower() == "yes")
            {
                Console.Clear();
                goto b;
            }
            else
            {
                Console.WriteLine("Exiting the application. Goodbye!");
            }
        }

        Console.Write("Return Number Analyzer:(y/n) ");
        string returnAnalizeNumber = Console.ReadLine();
        if (returnAnalizeNumber.ToLower() == "y" || returnAnalizeNumber.ToLower() == "yes")
        {
            Console.Clear();
            goto command1;
        }
        else
        {
            Console.Clear();
            goto b;
        }

        break;
    case 2:
    command2:
        //EXIT va Asosiy menuga qaytish imkoniyatlarini qo'shish
        Console.Clear();
        Console.WriteLine("===Geometry Zone====");
        Console.WriteLine("" +
            "1. Rectangle\r\n" +
            "2. Triangle\r\n" +
            "3. Circle\r\n" +
            "4. Exit");
        Console.Write("Enter your command(1-3): ");
        int insideCommand2 = Convert.ToInt32(Console.ReadLine());
        if (insideCommand2 == 1)
        {
            Console.WriteLine("===Rectangle AREA====");
            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area is rectangle: {length * width}");
        }
        else if (insideCommand2 == 2)
        {
            Console.WriteLine("===Triangle AREA====");
            Console.Write("Enter the base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area is triangle: {(baseLength * height) / 2}");
        }
        else if (insideCommand2 == 3)
        {
            Console.WriteLine("===Circle AREA====");
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area is circle: {Math.PI * Math.Pow(radius, 2)}");
        }
        else if (insideCommand2 == 4)
        {
            Console.Write("Return main Menu:(y/n) ");
            string returnMainMenu = Console.ReadLine();
            if (returnMainMenu.ToLower() == "y" || returnMainMenu.ToLower() == "yes")
            {
                Console.Clear();
                goto b;
            }
            else
            {
                Console.WriteLine("Exiting the application. Goodbye!");
            }
        }

        Console.Write("Return Geometry zone:(y/n) ");
        string returnGeometryzone = Console.ReadLine();
        if (returnGeometryzone.ToLower() == "y" || returnGeometryzone.ToLower() == "yes")
        {
            Console.Clear();
            goto command2;
        }
        else
        {
            Console.Clear();
            goto b;
        }

        break;

    case 3:
    command3:
        //EXIT va Asosiy menuga qaytish imkoniyatlarini qo'shish
        Console.Clear();
        Console.WriteLine("===Text Tools====");
        Console.WriteLine("" +
            "1. Matn uzunligini aniqlash\r\n" +
            "2. Matnni katta harflarga o‘tkazish\r\n" +
            "3. Matnni teskari chiqarish\r\n" +
            "4. Exit");
        Console.Write("Enter your command(1-3): ");
        int insideCommand3 = Convert.ToInt32(Console.ReadLine());

        if (insideCommand3 == 1)
        {
            Console.WriteLine("===Text Length====");
            Console.Write("Enter your text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"The length of the text is: {text.Length}");
        }
        else if (insideCommand3 == 2)
        {
            Console.WriteLine("===Uppercase Text====");
            Console.Write("Enter your text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Uppercase version: {text.ToUpper()}");
        }
        else if (insideCommand3 == 3)
        {
            Console.WriteLine("===Reversed Text====");
            Console.Write("Enter your text: ");
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine($"Reversed version: {new string(charArray)}");
        }
        else if (insideCommand3 == 4)
        {
            Console.Write("Return main Menu:(y/n) ");
            string returnMainMenu = Console.ReadLine();
            if (returnMainMenu.ToLower() == "y" || returnMainMenu.ToLower() == "yes")
            {
                Console.Clear();
                goto b;
            }
            else
            {
                Console.WriteLine("Exiting the application. Goodbye!");
            }
        }

        Console.Write("Return Text Tools:(y/n) ");
        string returnTextTools = Console.ReadLine();
        if (returnTextTools.ToLower() == "y" ||
            returnTextTools.ToLower() == "yes")
        {
            Console.Clear();
            goto command3;
        }
        else
        {
            Console.Clear();
            goto b;
        }

        break;
        break;
    case 4:
        Console.WriteLine("Exiting the application. Goodbye!");
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a number between 1 and 3.");
        break;
}
