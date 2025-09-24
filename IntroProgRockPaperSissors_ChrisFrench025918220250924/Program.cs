using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgRockPaperSissors_ChrisFrench025918220250924
{
    internal class Program
    {
        static int Wins = 0;
        static int Loose = 0;
        static Random random = new Random();
      
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play Rock, Paper, Sissors, best 3 out of 5 rounds! ");
            Console.ReadKey(true);

           
             WANA();


        }
        //Methods below here


        static void winOrLoose()
        {
            if (Wins == 3)
            {
                Console.WriteLine($"You have {Wins} wins. Good Job you are the winner this turnament");
                Console.ReadKey(true);
            }
            else if (Loose == 3)
            {
                Console.WriteLine($"You have {Loose} losses. Too bad , this time you are the looser this turnament");
                Console.ReadKey(true);
               
            }

        }
        static void WANA()
        {
            Console.WriteLine($"You have {Wins} wins and {Loose} losses" + "\n");
            Console.WriteLine("Do you wan to play a round? y = yes, n= no");
            string playAround = Console.ReadLine();

            if (playAround == "y") //sets up loop depending o user input.
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("Thanks for comming by see you again.");
                Console.ReadKey(true);
            }
        }


        static void PlayGame()
        {
            
            int ChallengerThrow = random.Next(1, 4);

            Console.WriteLine("what is your Throw?  1 = Rock, 2 = Paper, 3 = Sissors");
            string playerThrow = Console.ReadLine();

            if (playerThrow == "1")
            {
                if (ChallengerThrow == 2)
                {
                    Console.WriteLine("You chose Rock, the challenger chose Paper...You loose..");
                Console.ReadKey(true);
                Loose ++;
                }
                else if (ChallengerThrow == 3)
                {
                    Console.WriteLine("You chose Rock, the challenger chose Sissors...You Win..");
                Console.ReadKey(true);
                Wins++;
                }
                else
                {
                    Console.WriteLine("You chose Rock, the challenger chose Rock...great minds think alike \n It is a tie....");
                Console.ReadKey(true);
                }
                
            }

            if (playerThrow == "2")
            {
                if (ChallengerThrow == 1)
                {
                    Console.WriteLine("You chose Paper, the challenger chose Rock...You Win..");
                Console.ReadKey(true);
                Wins++;
                }
                else if (ChallengerThrow == 3)
                {
                    Console.WriteLine("You chose Paper, the challenger chose Sissors...You Loose..");
                Console.ReadKey(true);
                Loose ++;
                }
                else
                {
                    Console.WriteLine("You chose Paper, the challenger chose Paper...great minds think alike \n It is a tie....");
                Console.ReadKey(true);
                }
                
            }

            if (playerThrow == "3")
            {
                if (ChallengerThrow == 1)
                {
                    Console.WriteLine("You chose Sissors, the challenger chose Rock...You Loose..");
                Console.ReadKey(true);
                Loose++;
                }
                else if (ChallengerThrow == 2)
                {
                    Console.WriteLine("You chose Sissors, the challenger chose Paper...You Win..");
                Console.ReadKey(true);
                Wins++;
                }
                else
                {
                    Console.WriteLine("You chose Sissors, the challenger chose Sissors...great minds think alike \n It is a tie....");
                Console.ReadKey(true);
                }

             
            }
            winOrLoose();
            WANA();




        }

    }




}

