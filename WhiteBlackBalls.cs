namespace Problem2
{
    internal class WhiteBlackBalls
    {
        static void Main(string[] args)
        { 
                // user inputs:
                Console.Write("Enter number of white balls: ");
                int white = int.Parse(Console.ReadLine());

                Console.Write("Enter number of black balls: ");
                int black = int.Parse(Console.ReadLine());

                //start from first level ( default value )
                int level = 1;
                //start from white ball
                bool isWhite = true;

                while (true)
                {
                    //first check white balls
                    if (isWhite)
                    {
                        if (white >= level)
                        {
                            white -= level; 
                            level++;        // move to next level
                            isWhite = false; // change color to black
                        }
                        else
                        {
                            break; //No enough white balls
                        }
                    }
                //first check white balls

                else
                {
                        if (black >= level)
                        {
                            black -= level;
                            level++;
                            isWhite = true;
                        }
                        else
                        {
                            break; //No enough black balls
                    }
                    }
                }

                // maximum level can reach 
                Console.WriteLine("Max level of the Triangle is : " + (level - 1));
            }
        }

    }

