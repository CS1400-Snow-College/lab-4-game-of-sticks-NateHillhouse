/*
Players will take turns removing between 1 and 3 of the remaining sticks.  
The player that removes the last stick loses.

Sticks left: 20
Player 1, how many sticks would you like to take? 3

Sticks left: 17
Player 2, how many sticks would you like to take? 3
*/
using System.Collections;
using System.Runtime.CompilerServices;

int sticks = 20, player = 1, playersticks = 0, max_sticks = 3;
string message = $"Player {player}, how many sticks will you take? ";
bool success = false;
while (sticks >= 0)
{
    do
    {
        if (sticks <= 3) max_sticks = sticks; 
        Console.Clear();
        Console.WriteLine("----------------------------------\n- Welcome to the game of sticks! -\n----------------------------------");
        Console.WriteLine();
        Console.WriteLine($"Players will take turns removing between 1 and {max_sticks} of the remaining sticks.\nThe player that removes the last stick loses.");
        Console.WriteLine();
 

        for (int i = 1; i <= sticks; i++) Console.Write("|");
        Console.WriteLine("\n");
        Console.WriteLine($"There are {sticks} sticks left.");
        if (sticks > 0)
        {
            Console.Write(message);
            message = $"Player {player}, how many sticks will you take? ";
            success = Int32.TryParse(Console.ReadLine(), out playersticks);
            if (playersticks > 3 || playersticks < 1)
            {
                message = "Please pick a number between 1 and 3: ";
                success = false;
            }
            if (success && sticks - playersticks < 0)
            {
                message = $"Sorry, there are not {playersticks} left. \nPlease pick a number between 1 and {max_sticks}: ";
                success = false;
            }
        }        
    }
    while (success == false);
    sticks -= playersticks;

    Console.WriteLine();
    if (player == 1) player = 2;
    else if (player == 2) player = 1;
} 
Console.WriteLine($@"/---------------\
| Player {player} won! |
\---------------/");