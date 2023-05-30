using System.Diagnostics;

namespace GlumboisPCBS2Launcher;

public static class Game
{
    public static void Launch(string gameExecutable)
    {
        try
        {
            Process.Start(gameExecutable);
        }
        catch
        {
            Console.WriteLine("Could not start the Game, does the Installation Directory require Admin Rights?");
        }
    }
}