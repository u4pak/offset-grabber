using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUE4Parse
{
    public class Shady
    {
        public static bool IsExporting = false;

        public static long Offset = 0;

        public static List<long> OffsetList = new List<long>();

    }

    public class InstallationList
    {
        [JsonProperty("InstallLocation")] public string InstallLocation { get; set; }

        [JsonProperty("NamespaceId")] public string NamespaceId { get; set; }

        [JsonProperty("ItemId")] public string ItemId { get; set; }

        [JsonProperty("ArtifactId")] public string ArtifactId { get; set; }

        [JsonProperty("AppVersion")] public string AppVersion { get; set; }

        [JsonProperty("AppName")] public string AppName { get; set; }
    }

    public class InstalledApps
    {
        [JsonProperty("InstallationList")] public List<InstallationList> InstallationList { get; set; }
    }

    public class FortniteUtil
    {
        public static string PakPath
            => GetFortnitePath() + @"\FortniteGame\Content\Paks";

        public static string GetFortnitePath()
        {
            var path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                "Epic\\UnrealEngineLauncher\\LauncherInstalled.dat");

            return !File.Exists(path)
                   ? null
                   : Newtonsoft.Json.JsonConvert.DeserializeObject<InstalledApps>(File.ReadAllText(path)).InstallationList
                                .FirstOrDefault(x => x.AppName == "Fortnite").InstallLocation;
        }
    }
}
