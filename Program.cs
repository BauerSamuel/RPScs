using System;

namespace rps
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Random rnd = new Random();
      bool playing = true;
      int ties = 0;
      int wins = 0;
      int losses = 0;
      string rock = @"    
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";
      string paper = @"
    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
        ";
      string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
        ";
      string[] winConditions = new string[3];
      winConditions[0] = "rockscissors";
      winConditions[1] = "paperrock";
      winConditions[2] = "scissorspaper";
      Console.Write("Hello. Welcome to my RPS game. I have to warn you, it's going to be awful. This is actually my first C# program. Start by entering your name please: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Ah so your name is {name}, what a nice name... well, I guess we can stop putting off why you're really here {name}, you ready to play ROCK PAPER SCISSORS?");
      Console.WriteLine("Type something, I can't tell if you're ready: ");
      string answer = Console.ReadLine();
      if (answer.ToLower() == "y" || answer.ToLower() == "yes" || answer.ToLower() == "r" || answer.ToLower() == "ready")
      {
        playing = true;
      }
      else
      {
        Console.WriteLine("Quit? (Y or N)");
        answer = Console.ReadLine();
        if (answer.ToLower() == "y")
        {
          Console.WriteLine("Goodbye.");
          playing = false;
          return;
        }
        else
        {
          playing = true;
        }
      }
      Console.WriteLine($"So {name}, you want to challenge the computer to a classic game of Rock Paper Scissors huh? Great. Let's get started. First, you must choose a weapon, it's as simple as that. So, what will you choose? Rock? Paper? Or scissors?");
      while (playing)
      {
        Console.WriteLine($"\nWins: {wins}, Losses: {losses}, Ties: {ties}");
        Console.WriteLine("I choose(options are rock, paper, scissors, or q for quit): ");
        string compChoice;
        string userChoice = Console.ReadLine().ToLower();
        if (userChoice == "r")
        {
          userChoice = "rock";
        }
        else if (userChoice == "p")
        {
          userChoice = "paper";
        }
        else if (userChoice == "s")
        {
          userChoice = "scissors";
        }

        if (userChoice == "q")
        {
          Console.WriteLine($"Thanks for playing {name}. Wins: {wins}, Losses: {losses}, Ties: {ties}");
          playing = false;
          return;
        }
        int rando = rnd.Next(0, 4);
        if (rando == 1)
        {
          compChoice = "rock";
        }
        else if (rando == 2)
        {
          compChoice = "paper";
        }
        else
        {
          compChoice = "scissors";
        }
        Console.WriteLine($"You: {userChoice}");
        switch (userChoice)
        {
          case "rock":
            Console.WriteLine($@"{rock}");
            break;
          case "paper":
            Console.WriteLine($@"{paper}");
            break;
          case "scissors":
            Console.WriteLine($@"{scissors}");
            break;
        }
        Console.WriteLine($"\nComputer: {compChoice}");
        switch (compChoice)
        {
          case "rock":
            Console.WriteLine($@"{rock}");
            break;
          case "paper":
            Console.WriteLine($@"{paper}");
            break;
          case "scissors":
            Console.WriteLine($@"{scissors}");
            break;
        }
        string game = userChoice + compChoice;
        if (userChoice == compChoice)
        {
          Console.WriteLine($"\nWow {name}, you and my machine chose the same thing, impressive.");
          ties++;
        }
        else if (game == winConditions[0] || game == winConditions[1] || game == winConditions[2])
        {
          Console.WriteLine($"\nUnbelieveable, you win. Congrats {name}");
          wins++;
        }
        else
        {
          Console.WriteLine($"\nBetter luck next time {name}, you suck!");
          losses++;
        }
      }
    }
  }
}
