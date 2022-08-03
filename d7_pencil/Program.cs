// https://paiza.jp/works/mondai/drankfast/d7_pencil

using System;

class Program
{
    static void Main()
    {
        var line = int.Parse( Console.ReadLine());
        switch (line)
        {
            case 1:
                Console.WriteLine("6B");
                break;
            case 2:
                Console.WriteLine("5B");
                break;
            case 3:
                Console.WriteLine("4B");
                break;
            case 4:
                Console.WriteLine("3B");
                break;
            case 5:
                Console.WriteLine("2B");
                break;
            case 6:
                Console.WriteLine("B");
                break;
            case 7:
                Console.WriteLine("HB");
                break;
            case 8:
                Console.WriteLine("F");
                break;
            case 9:
                Console.WriteLine("H");
                break;
            case 10:
                Console.WriteLine("2H");
                break;
            case 11:
                Console.WriteLine("3H");
                break;
            case 12:
                Console.WriteLine("4H");
                break;
            case 13:
                Console.WriteLine("5H");
                break;
            case 14:
                Console.WriteLine("6H");
                break;
            case 15:
                Console.WriteLine("7H");
                break;
            case 16:
                Console.WriteLine("8H");
                break;
            case 17:
                Console.WriteLine("9H");
                break;
            default:
                Console.WriteLine("error");
                break;
        }

    }
}