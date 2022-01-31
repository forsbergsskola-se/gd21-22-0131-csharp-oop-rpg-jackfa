using System;

namespace BlackJack
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int cards = 0;
            int dealerCards = 0;
            
            Console.WriteLine("Hello! Welcome to BlackJack");

            while (cards < 1)
            {
                PlayerDraw();
                DealerDraw();
                WinCheck();
                Reset();
            }

            void PlayerDraw()
            {
                for (int i = 0; i <= 20; i++)
                {
                    
                    int playerDraw = random.Next(1, 12);
                    cards += playerDraw;
                    Console.WriteLine("You draw " + playerDraw + " for a total of " + cards);
                    if (cards > 21)
                    {
                        Console.WriteLine("Bust! You lose!\n");
                        Thread.Sleep(1000);
                        Main();
                    }
                    else if (cards == 21)
                    {
                        Console.WriteLine("21! Nice. Dealers turn.");
                        break;
                    }
                    Console.WriteLine("Would you like to draw an additional card? (y/n)");
                    string yesNo = Console.ReadLine();
                    bool drawAgain = yesNo == "y";
                    bool stopDraw = yesNo == "n";

                    if (drawAgain)
                    {
                        Thread.Sleep(400);
                    }
                    else if (stopDraw)
                    {
                        Thread.Sleep(800);
                        break;
                    }
                }
            }
             
            void DealerDraw()
            {
                for (int i = 0; i <= 20; i++)
                {
                    Thread.Sleep(600);
                    int randomDraw = random.Next(1,12);
                    dealerCards += randomDraw;
                    Console.WriteLine("The Dealer draws " + randomDraw + " for a total of " + dealerCards);
                    if (dealerCards >= 17)
                    {
                        break;
                    }
                
                }
            }

            void Reset()
            {
                cards = 0;
                dealerCards = 0;
            }

            void WinCheck()
            {
                if (dealerCards > 21)
                {
                    Console.WriteLine("Dealer busts, you win!");
                }
                else if (cards > dealerCards)
                {
                    Console.WriteLine("You win!\n Your cards: " + cards + "\n Dealer cards: " + dealerCards);
                }
                else if (cards == dealerCards)
                {
                    Console.WriteLine("Push!");
                }
                else if (cards < dealerCards)
                {
                    Console.WriteLine("You lose!\n Your cards: " + cards + "\n Dealer cards: " + dealerCards);
                }

            }
            
            

        }
        
        
    }
}