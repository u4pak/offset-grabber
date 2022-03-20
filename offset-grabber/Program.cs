using CUE4Parse.Encryption.Aes;
using CUE4Parse.FileProvider;
using CUE4Parse.UE4.Objects.Core.Misc;
using CUE4Parse.UE4.Versions;
using CUE4Parse;
using static offset_grabber.FortniteUtil;

Console.Title = "FORTNITE HXD OFFSET GRABBER | Made by shady#9999 and owens#2519";
var p = new DefaultFileProvider(FortniteUtils.PakPath, SearchOption.TopDirectoryOnly, false, new VersionContainer(EGame.GAME_UE5_LATEST));
p.Initialize();

Console.WriteLine(@" _______  _______  _______  _______  _______  _______            
|       ||       ||       ||       ||       ||       |           
|   _   ||    ___||    ___||  _____||    ___||_     _|           
|  | |  ||   |___ |   |___ | |_____ |   |___   |   |             
|  |_|  ||    ___||    ___||_____  ||    ___|  |   |             
|       ||   |    |   |     _____| ||   |___   |   |             
|_______||___|    |___|    |_______||_______|  |___|             
 _______  ______    _______  _______  _______  _______  ______   
|       ||    _ |  |   _   ||  _    ||  _    ||       ||    _ |  
|    ___||   | ||  |  |_|  || |_|   || |_|   ||    ___||   | ||  
|   | __ |   |_||_ |       ||       ||       ||   |___ |   |_||_ 
|   ||  ||    __  ||       ||  _   | |  _   | |    ___||    __  |
|   |_| ||   |  | ||   _   || |_|   || |_|   ||   |___ |   |  | |
|_______||___|  |_||__| |__||_______||_______||_______||___|  |_|

Created by shady#9999 with a lot of help from owens#2519.
");

Console.WriteLine("\nEnter the file path below (Ex: FortniteGame/Content/Athena/Artemis/Maps/Artemis_Terrain.umap):");

p.SubmitKey(new FGuid(), new FAesKey("0x0000000000000000000000000000000000000000000000000000000000000000"));

Owen.IsExporting = true;

string filePath = Console.ReadLine();

try
{
    p.SaveAsset(filePath);
}
catch
{
    Console.WriteLine("ERROR! The file path you entered was invalid. Please restart the program.");
    Console.WriteLine("\nPress Enter to close the program.");
    Console.ReadLine();
    return;
}

Console.Clear();

Console.WriteLine(@" _______  _______  _______  _______  _______  _______            
|       ||       ||       ||       ||       ||       |           
|   _   ||    ___||    ___||  _____||    ___||_     _|           
|  | |  ||   |___ |   |___ | |_____ |   |___   |   |             
|  |_|  ||    ___||    ___||_____  ||    ___|  |   |             
|       ||   |    |   |     _____| ||   |___   |   |             
|_______||___|    |___|    |_______||_______|  |___|             
 _______  ______    _______  _______  _______  _______  ______   
|       ||    _ |  |   _   ||  _    ||  _    ||       ||    _ |  
|    ___||   | ||  |  |_|  || |_|   || |_|   ||    ___||   | ||  
|   | __ |   |_||_ |       ||       ||       ||   |___ |   |_||_ 
|   ||  ||    __  ||       ||  _   | |  _   | |    ___||    __  |
|   |_| ||   |  | ||   _   || |_|   || |_|   ||   |___ |   |  | |
|_______||___|  |_||__| |__||_______||_______||_______||___|  |_|

Created by shady#9999 with a lot of help from owens#2519.
");

Console.WriteLine("\nOFFSET FOUND!");

Console.WriteLine($"\nFile Path:\n{Owen.Path}");

Console.WriteLine("\nAll Offsets:");

foreach(var offset in Owen.Offsets)
{
    Console.WriteLine(offset);
}

//for (int i = 0; i < Shady.OffsetList.Count; i++)
//{
//    Console.WriteLine(Shady.OffsetList);
//}

Console.WriteLine("\n(Try these one by one only if the most likely offset doesn't work.)");
Console.WriteLine("\nPress Enter to close the program.");
Console.ReadLine();