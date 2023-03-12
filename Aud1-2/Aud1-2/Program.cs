using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //debug testing
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int max = findMax(arr);
            

            //exception testing
            try
            {
                int zero = 0;
                int result = 100 / zero; //will throw DivideByZeroException
                int elem = arr[100]; //will throw IndexOutOfBoundsException
                Console.WriteLine(max);
                Console.ReadKey(); //adds delay so program doesn't instantly close
                //bottom 2 lines wont get reached because of exception
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            catch (Exception ex) //if no other type of exception is caught, this general one will be caught
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            finally //this executes regardless of if there is an exception or not
            {
                Console.WriteLine("Finally message");
                Console.ReadKey();
            }
        }

        private static int findMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
