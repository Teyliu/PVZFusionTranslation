using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007AE RID: 1966
[Token(Token = "0x20007AE")]
public class SaveInfo : MonoBehaviour
{
	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000D8648 File Offset: 0x000D6848
	[Token(Token = "0x1700019A")]
	private string FilePath
	{
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x60A280", Offset = "0x608880", VA = "0x18060A280")]
		get
		{
			return Path.Combine(SaveInfo.GetDataPath(), "playerData.json");
		}
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x000D8668 File Offset: 0x000D6868
	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x6085A0", Offset = "0x606BA0", VA = "0x1806085A0")]
	private void Awake()
	{
		SaveInfo.Instance = this;
		string @string = PlayerPrefs.GetString("LastSelectedSave", "Player");
		if (@string != "Player" && !Directory.Exists(Path.Combine(Application.persistentDataPath, "Saves", @string)))
		{
			Debug.LogWarning("上次使用的存档 '" + @string + "' 不存在，使用默认存档");
		}
		GameAPP.playerName = @string;
		string playerName = GameAPP.playerName;
		Debug.Log("加载存档：" + playerName);
		this.LoadPlayerData();
		Application.quitting += this.SavePlayerData;
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x000D86FC File Offset: 0x000D68FC
	[Token(Token = "0x60027E2")]
	[Address(RVA = "0x608C60", Offset = "0x607260", VA = "0x180608C60")]
	private void LoadLastSelectedSave()
	{
		string @string = PlayerPrefs.GetString("LastSelectedSave", "Player");
		if (@string != "Player" && !Directory.Exists(Path.Combine(Application.persistentDataPath, "Saves", @string)))
		{
			Debug.LogWarning("上次使用的存档 '" + @string + "' 不存在，使用默认存档");
		}
		GameAPP.playerName = @string;
		string playerName = GameAPP.playerName;
		Debug.Log("加载存档：" + playerName);
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x000D8774 File Offset: 0x000D6974
	[Token(Token = "0x60027E3")]
	[Address(RVA = "0x609730", Offset = "0x607D30", VA = "0x180609730")]
	public static void SaveLastSelectedSave(string saveName)
	{
		PlayerPrefs.SetString("LastSelectedSave", saveName);
		PlayerPrefs.Save();
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x000D8794 File Offset: 0x000D6994
	[Token(Token = "0x60027E4")]
	[Address(RVA = "0x608860", Offset = "0x606E60", VA = "0x180608860")]
	public static string GetDataPath()
	{
		if (!string.Equals(GameAPP.playerName, "Player"))
		{
			string persistentDataPath = Application.persistentDataPath;
			string playerName = GameAPP.playerName;
			return Path.Combine(persistentDataPath, "Saves", playerName);
		}
		return Application.persistentDataPath;
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x000D87D8 File Offset: 0x000D69D8
	[Token(Token = "0x60027E5")]
	[Address(RVA = "0x608E60", Offset = "0x607460", VA = "0x180608E60")]
	public void LoadPlayerData()
	{
		while (File.Exists(Path.Combine(SaveInfo.GetDataPath(), "playerData.json")))
		{
			PlatyerSettings platyerSettings = JsonUtility.FromJson<PlatyerSettings>(File.ReadAllText(Path.Combine(SaveInfo.GetDataPath(), "playerData.json")));
			if (platyerSettings.advLevelCompleted != (ulong)0L)
			{
				GameAPP.advLevelCompleted = platyerSettings.advLevelCompleted;
			}
			if (platyerSettings.clgLevelCompleted != (ulong)0L)
			{
				int num = 0;
				bool[] clgLevelCompleted = platyerSettings.clgLevelCompleted;
				if (num < clgLevelCompleted.Length)
				{
					bool[] clgLevelCompleted2 = GameAPP.clgLevelCompleted;
					bool[] clgLevelCompleted3 = platyerSettings.clgLevelCompleted;
					num++;
					num++;
				}
			}
			if (platyerSettings.gameLevelCompleted != (ulong)0L)
			{
				GameAPP.gameLevelCompleted = platyerSettings.gameLevelCompleted;
			}
			if (platyerSettings.survivalLevelCompleted != (ulong)0L)
			{
				GameAPP.survivalLevelCompleted = platyerSettings.survivalLevelCompleted;
			}
			if (platyerSettings.tutorLevelCompleted != (ulong)0L)
			{
				GameAPP.exploreLevelCompleted = Enumerable.ToHashSet<int>(platyerSettings.tutorLevelCompleted);
			}
			if (platyerSettings.nameLevelCompleted != (ulong)0L)
			{
				GameAPP.nameLevelCompleted = Enumerable.ToHashSet<string>(platyerSettings.nameLevelCompleted);
			}
			if (platyerSettings.skinLevelCompleted != (ulong)0L)
			{
				GameAPP.skinLevelCompleted = Enumerable.ToHashSet<int>(platyerSettings.skinLevelCompleted);
			}
			if (platyerSettings.customCompleted != (ulong)0L)
			{
				GameAPP.customCompleted = Enumerable.ToHashSet<int>(platyerSettings.customCompleted);
			}
			if (platyerSettings.advLevel != 0)
			{
				GameAPP.advantureLevel = platyerSettings.advLevel;
				if (platyerSettings.advZhouMu != 0)
				{
					GameAPP.advantureZhouMu = platyerSettings.advZhouMu;
					if (platyerSettings.newAdvArrivedLevel != 0)
					{
						GameAPP.newAdvArrivedLevel = platyerSettings.newAdvArrivedLevel;
						if (platyerSettings.towerLevel != 0)
						{
							GameAPP.towerLevel = platyerSettings.towerLevel;
							GameAPP.config = platyerSettings.config;
							if (platyerSettings.playerShootingArrivedLevel != 0)
							{
								PlayerShootingData.arrivedLevel = platyerSettings.playerShootingArrivedLevel;
								TreasureData.LoadData(platyerSettings.treasureSaveData);
								AdvantureConfig.LoadData(platyerSettings.advantureData);
								if (platyerSettings.godData != (ulong)0L)
								{
									GodManager.godData = platyerSettings.godData;
								}
								bool[] advLevelCompleted = GameAPP.advLevelCompleted;
								if ("{il2cpp array field local50->}" != (ulong)0L)
								{
								}
								GameAPP.theMoneyCount = platyerSettings.theMoneyCount;
								if (platyerSettings.plantSkinData != (ulong)0L)
								{
									ResourcesManager resourcesManager = GameAPP.resourcesManager;
									List<PlantSkinData> plantSkinData = platyerSettings.plantSkinData;
									resourcesManager.SkinListToDic(plantSkinData);
								}
								GameAPP.bannedInPVPScaryPot = platyerSettings.bannedInPVPScaryPot;
								GameAPP.bannedInPVPScaryPot_zombie = platyerSettings.bannedInPVPScaryPot_zombie;
								if (platyerSettings.randomPlantInZhouMu != (ulong)0L)
								{
									GameAPP.randomPlantInZhouMu = platyerSettings.randomPlantInZhouMu;
								}
								return;
							}
						}
					}
				}
			}
		}
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(SaveInfo.GetDataPath(), "playerData.json")));
	}

	// Token: 0x060027E6 RID: 10214 RVA: 0x000D8A68 File Offset: 0x000D6C68
	[Token(Token = "0x60027E6")]
	[Address(RVA = "0x609780", Offset = "0x607D80", VA = "0x180609780")]
	public void SavePlayerData()
	{
		PlatyerSettings platyerSettings = new PlatyerSettings();
		bool[] advLevelCompleted = GameAPP.advLevelCompleted;
		platyerSettings.advLevelCompleted = advLevelCompleted;
		bool[] clgLevelCompleted = GameAPP.clgLevelCompleted;
		platyerSettings.clgLevelCompleted = clgLevelCompleted;
		bool[] gameLevelCompleted = GameAPP.gameLevelCompleted;
		platyerSettings.gameLevelCompleted = gameLevelCompleted;
		List<int> list = Enumerable.ToList<int>(GameAPP.exploreLevelCompleted);
		platyerSettings.tutorLevelCompleted = list;
		List<string> list2 = Enumerable.ToList<string>(GameAPP.nameLevelCompleted);
		platyerSettings.nameLevelCompleted = list2;
		List<int> list3 = Enumerable.ToList<int>(GameAPP.skinLevelCompleted);
		platyerSettings.skinLevelCompleted = list3;
		List<int> list4 = Enumerable.ToList<int>(GameAPP.customCompleted);
		platyerSettings.customCompleted = list4;
		bool[] survivalLevelCompleted = GameAPP.survivalLevelCompleted;
		platyerSettings.survivalLevelCompleted = survivalLevelCompleted;
		GameConfig config = GameAPP.config;
		platyerSettings.config = config;
		int advantureLevel = GameAPP.advantureLevel;
		platyerSettings.advLevel = advantureLevel;
		int advantureZhouMu = GameAPP.advantureZhouMu;
		platyerSettings.advZhouMu = advantureZhouMu;
		List<PlantType> randomPlantInZhouMu = GameAPP.randomPlantInZhouMu;
		platyerSettings.randomPlantInZhouMu = randomPlantInZhouMu;
		long theMoneyCount = GameAPP.theMoneyCount;
		platyerSettings.theMoneyCount = theMoneyCount;
		List<PlantSkinData> list5 = GameAPP.resourcesManager.SkinDicToList();
		platyerSettings.plantSkinData = list5;
		List<PlantType> bannedInPVPScaryPot = GameAPP.bannedInPVPScaryPot;
		platyerSettings.bannedInPVPScaryPot = bannedInPVPScaryPot;
		int newAdvArrivedLevel = GameAPP.newAdvArrivedLevel;
		platyerSettings.newAdvArrivedLevel = newAdvArrivedLevel;
		int arrivedLevel = PlayerShootingData.arrivedLevel;
		platyerSettings.playerShootingArrivedLevel = arrivedLevel;
		AdvantureData data = AdvantureConfig.data;
		platyerSettings.advantureData = data;
		int towerLevel = GameAPP.towerLevel;
		platyerSettings.towerLevel = towerLevel;
		TreasureSaveData treasureSaveData = TreasureData.SaveData();
		platyerSettings.treasureSaveData = treasureSaveData;
		GodData godData = GodManager.godData;
		platyerSettings.godData = godData;
		string text = JsonUtility.ToJson(platyerSettings, true);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(Path.Combine(SaveInfo.GetDataPath(), "playerData.json")));
		File.WriteAllText(Path.Combine(SaveInfo.GetDataPath(), "playerData.json"), text);
	}

	// Token: 0x060027E7 RID: 10215 RVA: 0x000D8C14 File Offset: 0x000D6E14
	[Token(Token = "0x60027E7")]
	[Address(RVA = "0x609DB0", Offset = "0x6083B0", VA = "0x180609DB0")]
	public SurvivalData SaveSurvivalData(int level, bool clear = false, int id = -1, string name = "新的存档")
	{
		SurvivalData survivalData = new SurvivalData();
		List<ZombieType> list = new List();
		survivalData.zombie_a = list;
		List<ZombieType> list2 = new List();
		survivalData.zombie_b = list2;
		List<ZombieType> list3 = new List();
		survivalData.zombie_c = list3;
		List<PlantType> list4 = new List();
		survivalData.rogueCards = list4;
		List<SavePlantData> savePlantData = SaveMgr.savePlantData;
		survivalData.plants = savePlantData;
		SaveBoardData boardData = SaveMgr.boardData;
		survivalData.boardData = boardData;
		CampType campType = RogueManager.Instance.campType;
		survivalData.campType = campType;
		LeaderType leaderType = RogueManager.Instance.leaderType;
		survivalData.leaderType = leaderType;
		List<ZombieType> zombies_a = RogueManager.Instance.zombies_a;
		survivalData.zombie_a = zombies_a;
		List<ZombieType> zombies_b = RogueManager.Instance.zombies_b;
		survivalData.zombie_b = zombies_b;
		List<ZombieType> zombies_c = RogueManager.Instance.zombies_c;
		survivalData.zombie_c = zombies_c;
		ZombieType boss = RogueManager.Instance.boss;
		survivalData.bossType = boss;
		List<PlantType> rogueCards = RogueManager.Instance.rogueCards;
		survivalData.rogueCards = rogueCards;
		TravelData data = TravelMgr.Instance.data;
		survivalData.travelData = data;
		string version = GameAPP.version;
		survivalData.version = version;
		survivalData.name = 0;
		long time = GameAPP.GetTime();
		survivalData.savedTime = time;
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num)
		{
			MiniPet pet = Board.Instance.pet;
			int num2 = 0;
			if (pet != num2)
			{
				PetData data2 = Board.Instance.pet.data;
				survivalData.petData = data2;
			}
		}
		EndlessShooting instance2 = EndlessShooting.Instance;
		int num3 = 0;
		if (instance2 != num3)
		{
			List<PlantType> cardOnBank = EndlessShooting.Instance.cardOnBank;
			survivalData.cardOnBank = cardOnBank;
		}
		int num4 = 0;
		if (clear)
		{
			survivalData.cardOnBank = num4;
			survivalData.travelData.routeBossType = (ZombieType)((ulong)212L);
		}
		this.SaveSurvivalData(survivalData, level, id);
		return survivalData;
	}

	// Token: 0x060027E8 RID: 10216 RVA: 0x000D8E00 File Offset: 0x000D7000
	[Token(Token = "0x60027E8")]
	[Address(RVA = "0x609C80", Offset = "0x608280", VA = "0x180609C80")]
	public void SaveSurvivalData(SurvivalData data, int level, int id)
	{
		string text = JsonUtility.ToJson(data, true);
		string path = this.GetPath(level, id);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(path));
		File.WriteAllText(path, text);
		Debug.Log(string.Format("关卡保存成功，编号为{0}_{1}", directoryInfo, directoryInfo));
	}

	// Token: 0x060027E9 RID: 10217 RVA: 0x000D8E44 File Offset: 0x000D7044
	[Token(Token = "0x60027E9")]
	[Address(RVA = "0x6089A0", Offset = "0x606FA0", VA = "0x1806089A0")]
	public int GetMaxRound(int level, int id = -1)
	{
		string path = this.GetPath(level, id);
		if (!File.Exists(path))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(path));
			return 0;
		}
		return JsonUtility.FromJson<SurvivalData>(File.ReadAllText(path)).boardData.theEndlessSurvivalMaxRound;
	}

	// Token: 0x060027EA RID: 10218 RVA: 0x000D8E8C File Offset: 0x000D708C
	[Token(Token = "0x60027EA")]
	[Address(RVA = "0x608A80", Offset = "0x607080", VA = "0x180608A80")]
	private string GetPath(int level, int id)
	{
		if (id == -1)
		{
			string dataPath = SaveInfo.GetDataPath();
			string text = string.Format("level{0}.json", dataPath);
			return Path.Combine(dataPath, text);
		}
		string dataPath2 = SaveInfo.GetDataPath();
		string text2 = string.Format("Player/Saves/level{0}_{1}.json", dataPath2, dataPath2);
		return Path.Combine(dataPath2, text2);
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x000D8ED8 File Offset: 0x000D70D8
	[Token(Token = "0x60027EB")]
	[Address(RVA = "0x608BC0", Offset = "0x6071C0", VA = "0x180608BC0")]
	public SurvivalData GetSurvivalData(int level, int id = -1)
	{
		string path;
		do
		{
			path = this.GetPath(level, id);
		}
		while (File.Exists(path) && File.ReadAllText(path) != 0);
		return JsonUtility.FromJson<SurvivalData>(0);
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x000D8F08 File Offset: 0x000D7108
	[Token(Token = "0x60027EC")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public SaveInfo()
	{
	}

	// Token: 0x0400161B RID: 5659
	[Token(Token = "0x400161B")]
	public static SaveInfo Instance;

	// Token: 0x0400161C RID: 5660
	[Token(Token = "0x400161C")]
	private const string LAST_SAVE_KEY = "LastSelectedSave";
}
