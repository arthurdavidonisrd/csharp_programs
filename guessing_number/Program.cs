using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        bool loop_play = true;
        int max = 100;
        int min = 1;
        int cpu =  random.Next(min,max);
        int user_guess = 0;

        while (loop_play)
        {

            while (user_guess != cpu)
            {
                Console.WriteLine("Digite umm número:");
                user_guess = Convert.ToInt32(Console.ReadLine());



                if(user_guess > cpu)
                {
                    Console.WriteLine($"Seu chute {user_guess} foi ALTO");

                }
                else if (user_guess < cpu)
                {
                    Console.WriteLine($"Seu chute {user_guess} foi BAIXO");

                }
                else
                {
                     if(user_guess == cpu)
                    {
                        Console.WriteLine("Seu chute foi certeiro");
                        break;
                    }
                }



            }

        }
    }
}