using System;

namespace Praktikum04
{
    class Program
    {
        static void Main(string[] args)
        {
            int leftBoarder = 20; // spaces between beginnig of the line and start of street
            int carPos = 7; // position of car on the street
            bool retry = true; //bool to breake while loop 
            int rounds = 0; // count round to dispaly it at the end
            int changeDirectionTimer = 5; // counter that saves in how many rounds the direction is changing 
            int direction = 1; //0 = left curve ; 1 = neutal ; 2 = right curve

            while (retry)
            {
                if (changeDirectionTimer == 0) //hits 0 after 5 rounds 
                {
                    changeDirectionTimer = 5;
                    do
                    {
                        direction = Convert.ToInt32(new Random().Next(3)); //set direction and confert it to integer
                    } while ((leftBoarder <= 1 && direction == 0) ||
                             (leftBoarder >= 40 && direction == 2)); //checks if its alreay on the border
                }

                if (direction == 0) //goes eft
                {
                    leftBoarder--;
                    carPos++; // so car position stays the same if street hits a curve
                }
                else if (direction == 2) // goes right
                {
                    leftBoarder++;
                    carPos--;
                }

                string street = new String(' ', leftBoarder); // space between street and beginning of the line
                street += "."; // point for left border
                street += new string(' ', 19);
                street += "."; // add right border
                street = street.Insert(carPos + leftBoarder, "X"); // add X for the car

                Console.WriteLine(street); // print street
                if (Console.KeyAvailable)
                {
                    char key = Console.ReadKey(true).KeyChar; //get keychar
                    if (key == 'a')
                    {
                        carPos--; //move left
                    }
                    else if (key == 'd')
                    {
                        carPos++; // move right
                    }
                }

                if (carPos + leftBoarder <= leftBoarder + 1 ||
                    carPos + leftBoarder + 1 >= leftBoarder + 20 + 1) // if carPos is the same as the border
                {
                    Console.WriteLine($"CRASH! \n {rounds} Runden geschafft! \n Spiel wiederholen (Y/N)?");
                    if (Console.ReadKey().KeyChar == 'y') //if retry
                    {
                        leftBoarder = 10; //reset vars
                        carPos = 4;
                        Console.Clear(); // clear console
                    }
                    else
                    {
                        retry = false;
                    }
                }

                rounds++; // increment round
                changeDirectionTimer--; // decrement Timer
                System.Threading.Thread.Sleep(150); // Sleep
            }
        }
    }
}