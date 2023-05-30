namespace GlumboisPCBS2Launcher;

public static class Save
{
    public static void MoveFromDocumentsToGame(string pcbs2DocumentsFolder, string documentsSaveFolder, string savesFolder)
    {
        try
        {
            if (!Directory.Exists(pcbs2DocumentsFolder)) Directory.CreateDirectory(pcbs2DocumentsFolder);

            if (Directory.Exists(documentsSaveFolder))
            {
                FileHelpers.CopyDirectory(documentsSaveFolder, savesFolder, false);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An Error happened: {e.Message}");
        }
    }

    public static void MoveFromGameToDocuments(string savesFolder, string pcbs2DocumentsFolder)
    {
        try
        {
            FileHelpers.CopyDirectory(savesFolder, Path.Combine(pcbs2DocumentsFolder, "Saves"), false);
        }
        catch (Exception e)
        {
            Console.WriteLine($"An Error happened: {e.Message}");
        }
    }
}