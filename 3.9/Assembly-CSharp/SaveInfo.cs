using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E7 RID: 2023
[Token(Token = "0x20007E7")]
public class SaveInfo : MonoBehaviour
{
	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x0600290F RID: 10511 RVA: 0x000DD604 File Offset: 0x000DB804
	[Token(Token = "0x170001E4")]
	private string FilePath
	{
		[Token(Token = "0x600290F")]
		[Address(RVA = "0x66DAD0", Offset = "0x66C0D0", VA = "0x18066DAD0")]
		get
		{
			return Path.Combine(SaveInfo.GetDataPath(), "playerData.json");
		}
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x000DD624 File Offset: 0x000DB824
	[Token(Token = "0x6002910")]
	[Address(RVA = "0x66BDF0", Offset = "0x66A3F0", VA = "0x18066BDF0")]
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

	// Token: 0x06002911 RID: 10513 RVA: 0x000DD6B8 File Offset: 0x000DB8B8
	[Token(Token = "0x6002911")]
	[Address(RVA = "0x66C4B0", Offset = "0x66AAB0", VA = "0x18066C4B0")]
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

	// Token: 0x06002912 RID: 10514 RVA: 0x000DD730 File Offset: 0x000DB930
	[Token(Token = "0x6002912")]
	[Address(RVA = "0x66CF80", Offset = "0x66B580", VA = "0x18066CF80")]
	public static void SaveLastSelectedSave(string saveName)
	{
		PlayerPrefs.SetString("LastSelectedSave", saveName);
		PlayerPrefs.Save();
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x000DD750 File Offset: 0x000DB950
	[Token(Token = "0x6002913")]
	[Address(RVA = "0x66C0B0", Offset = "0x66A6B0", VA = "0x18066C0B0")]
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

	// Token: 0x06002914 RID: 10516 RVA: 0x000DD794 File Offset: 0x000DB994
	[Token(Token = "0x6002914")]
	[Address(RVA = "0x66C6B0", Offset = "0x66ACB0", VA = "0x18066C6B0")]
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

	// Token: 0x06002915 RID: 10517 RVA: 0x000DDA24 File Offset: 0x000DBC24
	[Token(Token = "0x6002915")]
	[Address(RVA = "0x66CFD0", Offset = "0x66B5D0", VA = "0x18066CFD0")]
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

	// Token: 0x06002916 RID: 10518 RVA: 0x000DDBD0 File Offset: 0x000DBDD0
	[Token(Token = "0x6002916")]
	[Address(RVA = "0x66D600", Offset = "0x66BC00", VA = "0x18066D600")]
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

	// Token: 0x06002917 RID: 10519 RVA: 0x000DDDBC File Offset: 0x000DBFBC
	[Token(Token = "0x6002917")]
	[Address(RVA = "0x66D4D0", Offset = "0x66BAD0", VA = "0x18066D4D0")]
	public void SaveSurvivalData(SurvivalData data, int level, int id)
	{
		string text = JsonUtility.ToJson(data, true);
		string path = this.GetPath(level, id);
		DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.GetDirectoryName(path));
		File.WriteAllText(path, text);
		Debug.Log(string.Format("关卡保存成功，编号为{0}_{1}", directoryInfo, directoryInfo));
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x000DDE00 File Offset: 0x000DC000
	[Token(Token = "0x6002918")]
	[Address(RVA = "0x66C1F0", Offset = "0x66A7F0", VA = "0x18066C1F0")]
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

	// Token: 0x06002919 RID: 10521 RVA: 0x000DDE48 File Offset: 0x000DC048
	[Token(Token = "0x6002919")]
	[Address(RVA = "0x66C2D0", Offset = "0x66A8D0", VA = "0x18066C2D0")]
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

	// Token: 0x0600291A RID: 10522 RVA: 0x000DDE94 File Offset: 0x000DC094
	[Token(Token = "0x600291A")]
	[Address(RVA = "0x66C410", Offset = "0x66AA10", VA = "0x18066C410")]
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

	// Token: 0x0600291B RID: 10523 RVA: 0x000DDEC4 File Offset: 0x000DC0C4
	[Token(Token = "0x600291B")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public SaveInfo()
	{
	}

	// Token: 0x040016F7 RID: 5879
	[Token(Token = "0x40016F7")]
	public static SaveInfo Instance;

	// Token: 0x040016F8 RID: 5880
	[Token(Token = "0x40016F8")]
	private const string LAST_SAVE_KEY = "LastSelectedSave";
}
