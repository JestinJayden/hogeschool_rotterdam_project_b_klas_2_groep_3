﻿// this is the code where we should start


World game_world = new World();
string player;
while (true)
{
    Console.WriteLine("please input your name");
    player = Console.ReadLine();
    if (player is not null & player.Length > 0)
    {
        break;
    }
}
Console.WriteLine($"you are {player}. \nYou are currently at {game_world.current_location.Location_Name}");
Console.WriteLine(game_world.current_location.Location_Description);
