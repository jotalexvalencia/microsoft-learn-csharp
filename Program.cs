Random random = new Random();


Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
  PlayGame();
}

void PlayGame()
{
  var play = true;

  while (play)
  {
    var target = GetTarget();
    var roll = GetRoll();

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    Console.WriteLine(WinOrLose(roll, target));
    Console.WriteLine("\nPlay again? (Y/N)");

    play = ShouldPlay();
  }
}

bool ShouldPlay()
{
  string? input = Console.ReadLine();
  bool result = input == "Y" ? true : false;
  return result;

}

string WinOrLose(int roll, int target)
{
  return roll > target ? "You win!" : "You lose!";

}

int GetTarget()
{
  return random.Next(1, 6);

}

int GetRoll()
{
  return random.Next(1, 7);
}