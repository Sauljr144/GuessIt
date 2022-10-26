//-----Variables----//
string userInput;
string userInput2;
bool playAgain = true;
bool gameLoop;
int easyNum;
int medNum;
int hardNum;
int randoEasy;
int randoMed;
int randoHard;


//I made a "while" loop with "do" to ask the user if they whish to play again.
//Aslo there are 3 random number generating functions to play against the computer.


//-----Loop-----//

while (playAgain == true)

{
    //----User input----//

    Console.WriteLine("Welcome to random number guessing game!");
    Console.WriteLine("Enter a mode at your won risk: Easy, Medium, Hard.");

    userInput = Console.ReadLine().ToLower();


    //------Conditionals------//

    //Easy Mode
    if (userInput == "easy")
    {
        
        Console.WriteLine("Guess a random number between 1 and 10. Win by guessing the random number!");
        easyNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------");
        Console.Write($"This was your answer:{easyNum}. This is the random number:");
        RandoGenEasy();

        if(randoEasy == easyNum)
        {
            Console.WriteLine("You Won!");
        }
        
        else
        {
            Console.WriteLine("Sorry You Lost.");
            Console.WriteLine("Game Over.");
        }
    }

    //Medium Mode
    if (userInput == "medium")
    {
        Console.WriteLine("Guess a random number between 1 and 50. Win by guessing the random number!");
        medNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------");
        Console.Write($"This was your answer:{medNum}. This is the random number:");
        RandoGenMed();

        if (randoMed == medNum)
        {
            Console.WriteLine("You Won!");
        }
        
        else
        {
            Console.WriteLine("Sorry You Lost.");
            Console.WriteLine("Game Over.");
        }
    }

    //Hard Mode
    if (userInput == "hard")
    {
        Console.WriteLine("Guess a random number between 1 and 100. Win by guessing the random number!");
        hardNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------");
        Console.Write($"This was your answer:{hardNum}. This is the random number:");
        RandoGenHard();

        if(randoHard == hardNum)
        {
            Console.WriteLine("You Won!");
        }
        
        else
        {
            Console.WriteLine("Sorry You Lost.");
            Console.WriteLine("Game Over.");
        }
    }

    do
    {
        gameLoop = true;
        Console.WriteLine("Want to play again? Y/N");
        userInput2 = Console.ReadLine().ToLower();

        if (userInput2 == "y")
        {
            playAgain = true;
        }

        else if (userInput2 == "n")
        {
            playAgain = false;
        }

    }

    while (gameLoop == false);

}

//Exit Statement
Console.WriteLine("K. Bye.");



//-----Functions----//

//Easy Random Number Generator Function
int RandoGenEasy()
{
    Random numGen = new Random();
    randoEasy = numGen.Next(1,11);
    Console.WriteLine(randoEasy);
    return randoEasy;
}

//Medium Random Number Generator Function
int RandoGenMed()
{
    Random numGen = new Random();
    randoMed = numGen.Next(1,51);
    Console.WriteLine(randoMed);
    return randoMed;
}

//Hard Random Number Generator Function
int RandoGenHard()
{
    Random numGen = new Random();
    randoHard = numGen.Next(1,101);
    Console.WriteLine(randoHard);
    return randoHard;
}

