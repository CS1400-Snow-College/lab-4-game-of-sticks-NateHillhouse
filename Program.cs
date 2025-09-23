/*
Players will take turns removing between 1 and 3 of the remaining sticks.  
The player that removes the last stick loses.

Sticks left: 20
Player 1, how many sticks would you like to take? 3

Sticks left: 17
Player 2, how many sticks would you like to take? 3
*/

Console.WriteLine(@"Players will take turns removing between 1 and 3 of the remaining sticks.  
The player that removes the last stick loses.");

int sticks = 20, player = 1, playersticks;
bool success;
while (sticks > 0)
{
    Console.WriteLine($"Player {player}, how many sticks will you take? ");
    do success = Int32.TryParse(Console.ReadLine(), out playersticks);
    while (success == false);
    sticks -= playersticks; 
    Console.WriteLine($"There are {sticks} left.");

    if (sticks == 0)
    {
        Console.WriteLine($"Player {player} won!");
        break;
    }
    if (player == 1 && sticks > 0) player = 2;
        else if (player == 2 && sticks > 0) player = 1;
} 