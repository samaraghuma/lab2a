using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playgame = true;
            int state = 1;
           
            while (playgame) {
                switch (state) {
                    case 1:
                        Console.WriteLine("welcome to the game What is your name ");
                        string name = Console.ReadLine();
                        state = 2;
                        break;
                    case 2:
                        Console.WriteLine("would you like to play game yes/no ");
                        string input = Console.ReadLine();
                        if (input=="yes")
                        {
                            state = 3;
                        }
                        else
                        {
                            state = 6;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Excellent! you are walking across a field you encountered a fire dragon  you want to face or run away");
                        string stand = Console.ReadLine();
                        if (stand == "face") 
                        {
                            state = 4;
                        }
                        else
                        {
                            state = 6;
                        }
                        break;
                    case 4:
                        Console.WriteLine("it is scary dragon man, choose weapon sword or arrow");
                        string weopon = Console.ReadLine();
                        state = 5;
                        break;
                    case 5:
                           
                            Console.WriteLine(" you armed with good weopon,dragon is approaching, it stares at you with -- eyes(enter red/blue )");
                        string colour = Console.ReadLine();
                        if (colour=="blue")
                        {
                            Console.WriteLine("blue eyed dragons are friendly,you pet it and become friends");
                            state = 6;
                        }
                        else
                        {
                            Console.WriteLine("red eyed dragons are friendly,you pet it and become friends");
                            state =6;
                        }
                        break;
                    case 6:                       
                        Console.WriteLine("game is over");
                        playgame = false;                        
                        break;
                       

                }
            }
         


        }
    }
}
