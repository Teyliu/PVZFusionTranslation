/*
 * [3.6 COMPATIBILITY] AlmanacCompatibility.cs
 *
 * These types are defined locally to maintain compatibility with code that
 * was written for 3.5's AlmanacPlantBank structure.
 *
 * In 3.6, the game uses:
 * - AlmanacData.AlmanacData (contains List<AlmanacData.PlantInfo> plants)
 * - AlmanacData.AlmanacDataLoader (static class with GetPlantData and plantDatas dict)
 * - AlmanacData.PlantInfo (replacement for AlmanacPlantBank.PlantInfo)
 *
 * Our patches in 3.6 should use the new AlmanacData types where possible,
 * but for backward compatibility with existing code (like Utils.cs), we define
 * these local types that match the 3.5 structure.
 *
 * NOTE: Using System.Text.Json for IL2CPP compatibility instead of Unity's JsonUtility
 */

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PvZ_Fusion_Translator__BepInEx_.Patches
{
    public class PlantData
    {
        [JsonPropertyName("plants")]
        public List<PlantInfo> plants { get; set; } = new List<PlantInfo>();
    }

    public class PlantInfo
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("introduce")]
        public string introduce { get; set; }

        [JsonPropertyName("info")]
        public string info { get; set; }

        [JsonPropertyName("cost")]
        public string cost { get; set; }

        [JsonPropertyName("seedType")]
        public int seedType { get; set; }
    }

    public class ZombieAlmanacData
    {
        [JsonPropertyName("zombies")]
        public List<ZombieInfo> zombies { get; set; }
    }

    public class ZombieInfo
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("info")]
        public string info { get; set; }

        [JsonPropertyName("introduce")]
        public string introduce { get; set; }

        [JsonPropertyName("theZombieType")]
        public ZombieType theZombieType { get; set; }
    }
}