using System;

namespace Del2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();
            input = input.ToUpper();
            Console.WriteLine("Converting input to all uppercase...");

            string message = "";
            int checksum = 0;

            //Console.WriteLine(input.Length);

            for (int i= 0; i < input.Length; i++)
            {
            //Console.WriteLine("i = " + i + " value at index i= " + input[i]);
                char A = input[i];

                int valA = A - 64;

                message = message + valA + "-";

                checksum = checksum + valA;
            }


            Console.WriteLine("Your coded message is " + message);
           // Console.WriteLine(checksum);

            Console.WriteLine("Message checksum is " + checksum);


        }
    }
}
