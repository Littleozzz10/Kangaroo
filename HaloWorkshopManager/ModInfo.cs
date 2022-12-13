using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace HaloWorkshopManager
{
    /// <summary>
    /// Class for holding info about an imported mod.
    /// </summary>
    public class ModInfo
    {
        private JsonElement root;
        public string title, description;
        public string majorVersion, minorVersion, patch, game;
        public string workshopId, guid;
        public string[] multiMaps, firefightMaps, campaignMaps;
        public bool installed;
        public long size;
        public ModInfo(string modPath, bool full)
        {
            StreamReader reader = new StreamReader(modPath + "\\ModInfo.json");
            JsonDocument doc = JsonDocument.Parse(reader.ReadToEnd());
            root = doc.RootElement;
            JsonElement contents = root.GetProperty("GameModContents");

            // Title and version
            title = root.GetProperty("Title").GetProperty("Neutral").ToString();
            description = root.GetProperty("Description").GetProperty("Neutral").ToString();
            majorVersion = root.GetProperty("ModVersion").GetProperty("Major").ToString();
            minorVersion = root.GetProperty("ModVersion").GetProperty("Minor").ToString();
            patch = root.GetProperty("ModVersion").GetProperty("Patch").ToString();
            game = root.GetProperty("Engine").ToString();

            // Multiplayer maps
            multiMaps = new string[contents.GetProperty("MultiplayerMaps").GetArrayLength()];
            int i = 0;
            foreach (JsonElement map in contents.GetProperty("MultiplayerMaps").EnumerateArray())
            {
                multiMaps[i] = map.ToString().Replace("multiplayer/", "").Replace(".json", "");
                i++;
            }
            // Firefight maps
            firefightMaps = new string[contents.GetProperty("FirefightMaps").GetArrayLength()];
            i = 0;
            foreach (JsonElement map in contents.GetProperty("FirefightMaps").EnumerateArray())
            {
                firefightMaps[i] = map.ToString().Replace("firefight/", "").Replace(".json", "");
                i++;
            }
            // Campaign maps
            if (contents.GetProperty("HasCampaign").ToString() == "True")
            {
                StreamReader cReader = new StreamReader(modPath + "\\CampaignInfo.json");
                JsonDocument cDoc = JsonDocument.Parse(cReader.ReadToEnd());
                JsonElement cRoot = cDoc.RootElement;
                campaignMaps = new string[cRoot.GetProperty("CampaignMaps").GetArrayLength()];
                int j = 0;
                foreach (JsonElement map in cRoot.GetProperty("CampaignMaps").EnumerateArray())
                {
                    campaignMaps[j] = map.ToString().Replace("campaign/", "").Replace(".json", "");
                    j++;
                }
                cReader.Close();
            }
            else
            {
                campaignMaps = new string[0];
            }

            // IDs
            workshopId = root.GetProperty("ModIdentifier").GetProperty("HostedModIds").GetProperty("SteamWorkshopId").ToString();
            guid = root.GetProperty("ModIdentifier").GetProperty("ModGuid").ToString();

            // Map check
            installed = false;
            if (Directory.Exists(modPath + "\\maps"))
            {
                installed = true;
            }
            else
            {
                foreach (string file in Directory.GetFiles(modPath, "", SearchOption.AllDirectories))
                {
                    FileInfo info = new FileInfo(file);
                    if (info.Extension == ".bk2")
                    {
                        installed = true;
                    }
                }
            }

            // Size
            if (full)
            {
                size = 0;
                foreach (string file in Directory.EnumerateFiles(modPath, "", SearchOption.AllDirectories))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    size += fileInfo.Length;
                }
            }

            reader.Close();
        }
    }
}
