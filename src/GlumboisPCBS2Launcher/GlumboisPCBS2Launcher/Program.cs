// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using GlumboisPCBS2Launcher;

string gameExecutable = Path.Combine("./", "PCBS2.exe");
string savesFolder = Path.Combine("./", "Saves");
string userDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string pcbs2DocumentsFolder = Path.Combine(userDocuments, "PCBS2");
string documentsSaveFolder = Path.Combine(pcbs2DocumentsFolder, "Saves");

Save.MoveFromDocumentsToGame(pcbs2DocumentsFolder, documentsSaveFolder, savesFolder);

Game.Launch(gameExecutable);

Console.WriteLine("Waiting for Game to launch...");

do
{
    Thread.Sleep(500);
} while (Process.GetProcessesByName("PCBS2").Length < 0);

bool infoPrinted = false;
while (Process.GetProcessesByName("PCBS2").Length > 0)
{
    if (infoPrinted) continue;

    Console.WriteLine("Process found! Now waiting for Game to close to save your Save Files!");
    infoPrinted = true;
}

Console.WriteLine("Saving Files to Documents!");

Save.MoveFromGameToDocuments(savesFolder, pcbs2DocumentsFolder);

Console.WriteLine("Done!, closing...");
Thread.Sleep(3000);