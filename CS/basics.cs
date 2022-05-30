using System.Data;

namespace ConsoleApp1;

public static class Basic
{
    private static void _001()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to print Hello and your name in a separate line.");
        
        Console.WriteLine("\nInsert your name: ");
        string? _1_input = Console.ReadLine();
        
        Console.WriteLine("\nHello\n" + _1_input);
    }
    
    private static void _002()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to print the sum of two numbers.");
        
        Console.WriteLine("\nInsert the first number: ");
        string? _2_numero1 = Console.ReadLine();
        
        Console.WriteLine("Insert the second number: ");
        string? _2_numero2 = Console.ReadLine();

        int _2_numero1i = Convert.ToInt32(_2_numero1);
        int _2_numero2i = Convert.ToInt32(_2_numero2);
        
        int sum = _2_numero1i + _2_numero2i;

        Console.WriteLine("The sum of {0} and {1} is: {2}", _2_numero1i, _2_numero2i, sum);
    }

    private static void _003()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to print the result of dividing two numbers.");
        
        Console.WriteLine("\nInsert the first number: ");
        string? _3_numero1 = Console.ReadLine();
        
        Console.WriteLine("Insert the second number: ");
        string? _3_numero2 = Console.ReadLine();

        int _3_numero1i = Convert.ToInt32(_3_numero1);
        int _3_numero2i = Convert.ToInt32(_3_numero2);

        int _3_division = _3_numero1i / _3_numero2i;
        
        Console.WriteLine("The division between the two numbers is: " + _3_division);
    }

    private static void _004()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to print the result of the specified operations.");
        
        Console.WriteLine("\nInsert the operation: ");
        string? _4_operation = Console.ReadLine();
        
        string? _4_finalOperation = new DataTable().Compute(_4_operation, null).ToString();

        Console.WriteLine("The solution: " + _4_finalOperation);
    }
    
    private static void _005()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to swap two numbers.");

        Console.WriteLine("\nInsert the first number: ");
        string? _5_first = Console.ReadLine();

        Console.WriteLine("Insert the second number: ");
        string? _5_second = Console.ReadLine();

        (_5_first, _5_second) = (_5_second, _5_first);

        Console.WriteLine("\nThe first number: " + _5_first);
        Console.WriteLine("The second number: " + _5_second);

    }

    private static void _006()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.");
        
        Console.WriteLine("\nInsert the first number: ");
        string? _6_first = Console.ReadLine();

        Console.WriteLine("Insert the second number: ");
        string? _6_second = Console.ReadLine();
        
        Console.WriteLine("Insert the third number: ");
        string? _6_third = Console.ReadLine();
        
        int _6_firsti = Convert.ToInt32(_6_first);
        int _6_secondi = Convert.ToInt32(_6_second);
        int _6_thirdi = Convert.ToInt32(_6_third);

        int _6_multiply = _6_firsti * _6_secondi * _6_thirdi;

        Console.WriteLine("\n{0} * {1} * {2} = {3}", _6_firsti, _6_secondi, _6_thirdi, _6_multiply);
    }

    private static void _007()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user.");

        Console.WriteLine("\nInsert the first number: ");
        string? _7_first = Console.ReadLine();
        
        Console.WriteLine("Insert the second number: ");
        string? _7_second = Console.ReadLine();

        int _7_firsti = Convert.ToInt32(_7_first);
        int _7_secondi = Convert.ToInt32(_7_second);

         int _7_add = _7_firsti + _7_secondi;
         int _7_subtract = _7_firsti - _7_secondi;
         int _7_multiply = _7_firsti * _7_secondi;
         int _7_divide = _7_firsti / _7_secondi;

         Console.WriteLine("{0} + {1} = {2}", _7_firsti, _7_secondi, _7_add);
         Console.WriteLine("{0} - {1} = {2}", _7_firsti, _7_secondi, _7_subtract);
         Console.WriteLine("{0} * {1} = {2}", _7_firsti, _7_secondi, _7_multiply);
         Console.WriteLine("{0} / {1} = {2}", _7_firsti, _7_secondi, _7_divide);
    }
    
    private static void _008()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program that takes a number as input and print its multiplication table.");

        Console.WriteLine("\nInsert the number you want its multiplication table: ");
        string? _8_number = Console.ReadLine();

        Console.WriteLine("\n");
        
        int _8_numberi = Convert.ToInt32(_8_number);

        int i = 0;
        do
        {
            int _8_multiplication = _8_numberi * (i);
            Console.WriteLine("{0} * {1} = {2}", _8_numberi, i, _8_multiplication);
            i++;
        } while (i <= 10);
    }
    
    private static void _009()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program that takes four numbers as input to calculate and print the average");
        
        Console.WriteLine("\nInsert the first out of four numbers to know their average: ");
        string? _9_one = Console.ReadLine();
        
        Console.WriteLine("Insert the second out of four numbers to know their average: ");
        string? _9_two = Console.ReadLine();
        
        Console.WriteLine("Insert the third out of four numbers to know their average: ");
        string? _9_three = Console.ReadLine();
        
        Console.WriteLine("Insert the fourth out of four numbers to know their average: ");
        string? _9_four = Console.ReadLine();

        decimal _9_oned = Convert.ToDecimal(_9_one);
        decimal _9_twod = Convert.ToDecimal(_9_two);
        decimal _9_threed = Convert.ToDecimal(_9_three);
        decimal _9_fourd = Convert.ToDecimal(_9_four);

        decimal _9_average = (_9_oned + _9_twod + _9_threed + _9_fourd) / 4;

        Console.WriteLine("The average of {0}, {1}, {2} and {3} is {4}", _9_oned, _9_twod, _9_threed, _9_fourd, _9_average);
    }
    
    private static void _010()
    {
        Console.WriteLine("\n\nWrite a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.");
        
        Console.WriteLine("\nInsert x: ");
        string? _10_x = Console.ReadLine();
        
        Console.WriteLine("Insert y: ");
        string? _10_y = Console.ReadLine();
        
        Console.WriteLine("Insert z: ");
        string? _10_z = Console.ReadLine();
        
        int _10_xi = Convert.ToInt32(_10_x);
        int _10_yi = Convert.ToInt32(_10_y);
        int _10_zi = Convert.ToInt32(_10_z);

        int a = (_10_xi + _10_yi) * _10_zi; // (x+y).z
        int b = _10_xi * _10_yi + _10_yi * _10_zi; // x.y + y.z

        Console.WriteLine($"(x+y).z = {a}\nx.y + y.z = {b}");
    }

    private static void _011()
    {
        Console.WriteLine("\nWrite a C# Sharp program that takes an age (for example 20) as input and prints something as \"You look older than 20\".");
        
        Console.WriteLine("\nInsert your age: ");
        string? _11_age = Console.ReadLine();

        Console.WriteLine($"You look older than {_11_age}");
    }

    private static void _012()
    {
        Console.WriteLine("\nWrite a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.");

        Console.WriteLine("\nEnter the number you want: ");
        string? _12_number = Console.ReadLine();

        Console.WriteLine($"\n{_12_number} {_12_number} {_12_number} {_12_number}\n{_12_number}{_12_number}{_12_number}{_12_number}\n{_12_number} {_12_number} {_12_number} {_12_number}\n{_12_number}{_12_number}{_12_number}");
    }

    private static void _013()
    {
        Console.WriteLine("\nWrite a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.");
        
        Console.WriteLine("\nEnter the number you want: ");
        string? _13_number = Console.ReadLine();

        Console.WriteLine($"\n{_13_number} {_13_number} {_13_number}\n{_13_number}   {_13_number}\n{_13_number}   {_13_number}\n{_13_number}   {_13_number}\n{_13_number} {_13_number} {_13_number}");

    }

    private static void _014()
    {
        Console.WriteLine("\nWrite a C# program to convert from celsius degrees to Kelvin and Fahrenheit.");

        Console.WriteLine("\nInsert the temperature in Celcius: ");
        string? _014_celcius = Console.ReadLine();

        double _014_celciusd = Convert.ToDouble(_014_celcius);

        double _014_kelvind = _014_celciusd + 273.15;
        double _014_fahrenheitd = (((_014_celciusd * 9) / 5) + 32);

        Console.WriteLine($"\n{_014_celcius} is {_014_kelvind} kelvin and {_014_fahrenheitd} fahrenheit");
    }
    
    private static void _015()
    {
        Console.WriteLine("\nWrite a C# program remove specified a character from a non-empty string using index of a character.");

        Console.WriteLine("\nInsert the string: ");
        string? _015_string = Console.ReadLine();
        Console.WriteLine("\nInsert the character you want to remove: ");
        string? _015_character = Console.ReadLine();

        var charsToRemove = new string[] {_015_character};
        foreach (var c in charsToRemove)
        {
            string _015_stringdone = _015_string.Replace(c, string.Empty);
            Console.WriteLine("\nA sua nova string é: " + _015_stringdone);
        }
    }
    
    private static void _016()
    {
        Console.WriteLine("\n Write a C# program to create a new string from a given string where the first and last characters will change their positions.");
        Console.WriteLine("\nInsert the string: ");
        string? _016_string = Console.ReadLine();

        int _016_length = _016_string.Length;

        List<char> _016_stringlist = _016_string.ToList();

        char _16_anotherone = _016_stringlist[0];
        _016_stringlist[0] = _016_stringlist[_016_length - 1];
        Console.WriteLine("Check: " + _016_stringlist);
        _016_stringlist[_016_length - 1] = _16_anotherone;
        Console.WriteLine("Check: " + _016_stringlist);
        
        Console.WriteLine("The reversed string is: ");
        foreach (var item in _016_stringlist) {
            Console.Write(item);
        }
    }
    
    private static void _017()
    {
        Console.WriteLine("Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.");
		Console.WriteLine("\nInsert the string: ");
        string? _017_string = Console.ReadLine();
        
        if (_017_string.Length>=1)
        {
            var _017_cut = _017_string.Substring(0,1);
            Console.WriteLine(_017_cut + _017_string + _017_cut);
        }
    }

    private static void _018()
    {
        Console.WriteLine(
            "\nWrite a C# program to check two given integers and return true if one is negative and one is positive.");

        Console.WriteLine("\nInput the first number: ");
        string? _018_first = Console.ReadLine();
        Console.WriteLine("Input the second number:");
        string? _018_second = Console.ReadLine();

        int _018_firsti = Convert.ToInt32(_018_first);
        int _018_secondi = Convert.ToInt32(_018_second);

        bool _018_true = (_018_firsti < 0 && _018_secondi > 0) || (_018_firsti > 0 && _018_secondi < 0);

        switch (_018_true)
        {
            case true:
                Console.WriteLine("\nOne of the integers is negative and the other is positive.");
                break;
            case false:
                Console.WriteLine("Or both integers are positive or both are negative.");
                break;
        }
    }

    private static void _019()
    {
        Console.WriteLine("\nWrite a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.");
		
		Console.WriteLine("\nInsert the first number: ");
		int _019_first = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Insert the second number: ");
		int _019_second = Convert.ToInt32(Console.ReadLine());

        if (_019_first == _019_second)
        {
            int _019_final = (_019_first + _019_second) * 3;
            Console.WriteLine("The final sum is {0}", _019_final);
        }
        else
        {
            int _019_final = _019_first + _019_second;
            Console.WriteLine("The final sum is {0}", _019_final);
        }
    }
    
    private static void _020()
    {
        Console.WriteLine("\nWrite a C# program to get the absolute value of the difference between two given numbers." +
                          "Return double the absolute value of the difference" +
                          "if the first number is greater than second number.");

        Console.WriteLine("\nInsert the first number: ");
        int _020_first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insert the second number: ");
        int _020_second = Convert.ToInt32(Console.ReadLine());

        if (_020_first == _020_second)
        {
            Console.WriteLine("The result of the difference is: 0");
        }
        else if (_020_first > _020_second)
        {
            int _020_final = (_020_first - _020_second) * 2;
            Console.WriteLine("The result of the difference is: {0}", _020_final);
        }
        else
        {
            int _020_final = _020_second - _020_first;
            Console.WriteLine("The result of the difference is: {0}", _020_final);
        }
    }
    
    private static void _021()
    {
        Console.WriteLine("\nWrite a C# program to check the sum of the two given integers and return true" +
                          "if one of the integer is 20 or if their sum is 20.");
        int _021_one = Convert.ToInt32(Console.ReadLine());
        int _021_two = Convert.ToInt32(Console.ReadLine());
        
        if (_021_one + _021_two == 20) { Console.WriteLine("The sum of the integers is 20."); }
        else if (_021_one == 20 && _021_two == 20) Console.WriteLine("Both numbers are 20.");
        else if (_021_one == 20) { Console.WriteLine("The first integer is 20."); }
        else if (_021_two == 20) { Console.WriteLine("The second integer is 20."); }
    }

    private static void _022()
    {
        Console.WriteLine("\nWrite a C# program to check if an given integer is within 20 of 100 or 200.");
        
        int _022_integer = Convert.ToInt32(Console.ReadLine());

        if (_022_integer <= 220 && _022_integer >= 180) { Console.WriteLine("The integer is within 20 of 200"); }
        else if (_022_integer <= 120 && _022_integer >= 80) { Console.WriteLine("The integer is withing 20 of 100"); }
        else { Console.WriteLine("The integer is out of range."); }
    }
    
    
    private static void Main()
    {
        int _Finaloption;
        do
        {
            Console.WriteLine("\n\nInsert the name of the exercise you want to use: ");
            string? _Option = Console.ReadLine();
            
            _Finaloption = Convert.ToInt32(_Option);
            
            switch (_Finaloption)
            {
                case 1: _001();
                    break;
                case 2: _002();
                    break;
                case 3: _003();
                    break;
                case 4: _004();
                    break;
                case 5: _005();
                    break; 
                case 6: _006();
                    break;
                case 7: _007();
                    break;
                case 8: _008();
                    break;
                case 9: _009();
                    break;
                case 10: _010();
                    break;
                case 11: _011();
                    break;
                case 12: _012();
                    break;
                case 13: _013();
                    break;
                case 14: _014();
                    break;
                case 15: _015();
                    break;
                case 16: _016();
                    break;
                case 17: _017();
                    break;
                case 18: _018();
                    break;
                case 19: _019();
                    break;
                case 20: _020();
                    break;
                case 21: _021();
                    break;
            }
        }  while (_Finaloption != 0);
    }
}