using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        enum orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        enum PasswordStrength : int
        {
            easy = 1,
            normal = 2,
            hard = 3
        }

        static void Main(string[] args)
        {
            /*double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.WriteLine("Now give me a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now give me another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The result of subtracting {0} from {1} is {2}.", secondNumber, firstNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The result of dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber / secondNumber);
            Console.WriteLine("The remainder after dividing {0} by {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();*/

            /*int n = 0;
            List<int> numbers = new List<int>();
            Console.WriteLine("Would you like to enter values or let rand do the work? (1/0)");
            int decision;
            decision = Convert.ToInt16(Console.ReadLine());

            if (decision == 1)
            {
                n = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    numbers.Add(Convert.ToInt16(Console.ReadLine()));
                }
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < 10; i++)
                {
                    numbers.Add(rand.Next(1, 1000));
                }
            }

            *//*Console.WriteLine("Middle elem/s:");
            if (n % 2 == 0)
            {
                Console.WriteLine($"{numbers.IndexOf(n / 2)} and {numbers.IndexOf(n / 2 + 1)}");
            }
            else
                Console.WriteLine($"{numbers.IndexOf(n/2)}");*//*

            int min = numbers.IndexOf(n);
            int max = 0;
            foreach (int i in numbers)
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
            }
            Console.WriteLine("Max num:");
            Console.WriteLine(max);
            Console.WriteLine("Min num:");
            Console.WriteLine(min);
            Console.ReadKey();*/

            /*byte directionByte;
            string directionString;
            orientation myDirection = orientation.north;
            Console.WriteLine("myDirection = {0}", myDirection);
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine("byte equivalent = {0}", directionByte);
            Console.WriteLine("string equivalent = {0}", directionString);
            Console.ReadKey();*/

            /*string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
            Console.ReadKey();*/

            string generatePassword(PasswordStrength passwordStrenght)
            {
                string chars = "";
                if(passwordStrenght.Equals(1))
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                else if(passwordStrenght.Equals(2))
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                else if(passwordStrenght.Equals(3))
                    chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

                Random rand = new Random();
                var charArr = new char[10];
                for (int i = 0; i < charArr.Length; i++)
                {
                    //not working
                    charArr[i] = chars[rand.Next(0,chars.Length-1)];
                }
                return new string(charArr);
            }

            Console.WriteLine("Pick difficulty: 1(easy), 2(normal), 3(hard)");
            PasswordStrength difficulty = (PasswordStrength)Convert.ToInt16(Console.ReadLine());
            string password = generatePassword(difficulty);

            Console.WriteLine($"Your pw: {password}");

            int numTries = 0;
            Console.WriteLine("Try guessing the pw (3 tries):");
            while (numTries < 3)
            {
                numTries++;
                string guess = Console.ReadLine();
                if (password.Equals(guess))
                {
                    Console.WriteLine("CORRECT!");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("INCORRECT!");
                }
            }
            Console.ReadKey();
        }
    }
}
