
using System;

namespace MathCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();


            int coins = 0;
            while(true)
            {
                if(question(3,r))
                {
                    coins++;
                }
                Console.WriteLine("Maths coins : " + coins);
            }
        }

        static bool question(int variables, Random r)
        {
            

            bool correct = false;

            int[] nums = new int[variables];

            int answer = 1;

            for(int x = 0; x < nums.Length; x++)
            {
                
                nums[x] = r.Next(0, 10);
                answer = answer * nums[x];
                Console.WriteLine(nums[x]);
            }

            Console.WriteLine("What is the product?");

            if(Convert.ToInt32(Console.ReadLine()) == answer)
            {
                correct = true;
            }

            return correct;

        }
    }
}
