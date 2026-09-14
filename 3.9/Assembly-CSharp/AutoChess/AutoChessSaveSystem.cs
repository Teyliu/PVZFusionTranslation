using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AE7 RID: 2791
	[Token(Token = "0x2000AE7")]
	public class AutoChessSaveSystem : MonoBehaviour
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x0012E0F8 File Offset: 0x0012C2F8
		[Token(Token = "0x170003C4")]
		public static AutoChessSaveSystem Instance
		{
			[Token(Token = "0x600395D")]
			[Address(RVA = "0x7CC140", Offset = "0x7CA740", VA = "0x1807CC140")]
			get
			{
				AutoChessSaveSystem autoChessSaveSystem = AutoChessSaveSystem.instance;
				int num = 0;
				if (autoChessSaveSystem == num)
				{
					GameObject gameObject = new GameObject("AutoChessSaveSystem");
					AutoChessSaveSystem.instance = gameObject.AddComponent<AutoChessSaveSystem>();
					global::UnityEngine.Object.DontDestroyOnLoad(gameObject);
				}
				return AutoChessSaveSystem.instance;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x0012E140 File Offset: 0x0012C340
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x0012E154 File Offset: 0x0012C354
		[Token(Token = "0x170003C5")]
		public bool IsAutoSaveEnabled
		{
			[Token(Token = "0x600395E")]
			[Address(RVA = "0x400CB0", Offset = "0x3FF2B0", VA = "0x180400CB0")]
			get
			{
				return this.isAutoSaveEnabled;
			}
			[Token(Token = "0x600395F")]
			[Address(RVA = "0x7CC5D0", Offset = "0x7CABD0", VA = "0x1807CC5D0")]
			set
			{
				this.isAutoSaveEnabled = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x0012E168 File Offset: 0x0012C368
		[Token(Token = "0x170003C6")]
		public int CurrentPlayTime
		{
			[Token(Token = "0x6003960")]
			[Address(RVA = "0x590AF0", Offset = "0x58F0F0", VA = "0x180590AF0")]
			get
			{
				return this.currentPlayTime;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0012E17C File Offset: 0x0012C37C
		[Token(Token = "0x170003C7")]
		public IReadOnlyList<AutoChessSaveSystem.SaveSlot> SaveSlots
		{
			[Token(Token = "0x6003961")]
			[Address(RVA = "0x78F240", Offset = "0x78D840", VA = "0x18078F240")]
			get
			{
				List<AutoChessSaveSystem.SaveSlot> list = this.saveSlots;
				return null;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06003962 RID: 14690 RVA: 0x0012E19C File Offset: 0x0012C39C
		// (remove) Token: 0x06003963 RID: 14691 RVA: 0x0012E1CC File Offset: 0x0012C3CC
		[Token(Token = "0x14000002")]
		public event Action<string> OnSaveSuccess
		{
			[Token(Token = "0x6003962")]
			[Address(RVA = "0x7CC090", Offset = "0x7CA690", VA = "0x1807CC090")]
			[CompilerGenerated]
			add
			{
				Action<string> onSaveSuccess = this.OnSaveSuccess;
				Delegate @delegate = Delegate.Combine(onSaveSuccess, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSaveSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6003963")]
			[Address(RVA = "0x7CC520", Offset = "0x7CAB20", VA = "0x1807CC520")]
			[CompilerGenerated]
			remove
			{
				Action<string> onSaveSuccess = this.OnSaveSuccess;
				Delegate @delegate = Delegate.Remove(onSaveSuccess, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSaveSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06003964 RID: 14692 RVA: 0x0012E1FC File Offset: 0x0012C3FC
		// (remove) Token: 0x06003965 RID: 14693 RVA: 0x0012E22C File Offset: 0x0012C42C
		[Token(Token = "0x14000003")]
		public event Action<string> OnSaveFailed
		{
			[Token(Token = "0x6003964")]
			[Address(RVA = "0x7CBFE0", Offset = "0x7CA5E0", VA = "0x1807CBFE0")]
			[CompilerGenerated]
			add
			{
				Action<string> onSaveFailed = this.OnSaveFailed;
				Delegate @delegate = Delegate.Combine(onSaveFailed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSaveFailed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6003965")]
			[Address(RVA = "0x7CC470", Offset = "0x7CAA70", VA = "0x1807CC470")]
			[CompilerGenerated]
			remove
			{
				Action<string> onSaveFailed = this.OnSaveFailed;
				Delegate @delegate = Delegate.Remove(onSaveFailed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSaveFailed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06003966 RID: 14694 RVA: 0x0012E25C File Offset: 0x0012C45C
		// (remove) Token: 0x06003967 RID: 14695 RVA: 0x0012E28C File Offset: 0x0012C48C
		[Token(Token = "0x14000004")]
		public event Action<AutoChessSaveSystem.SaveData> OnLoadSuccess
		{
			[Token(Token = "0x6003966")]
			[Address(RVA = "0x7CBF30", Offset = "0x7CA530", VA = "0x1807CBF30")]
			[CompilerGenerated]
			add
			{
				Action<AutoChessSaveSystem.SaveData> onLoadSuccess = this.OnLoadSuccess;
				Delegate @delegate = Delegate.Combine(onLoadSuccess, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLoadSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6003967")]
			[Address(RVA = "0x7CC3C0", Offset = "0x7CA9C0", VA = "0x1807CC3C0")]
			[CompilerGenerated]
			remove
			{
				Action<AutoChessSaveSystem.SaveData> onLoadSuccess = this.OnLoadSuccess;
				Delegate @delegate = Delegate.Remove(onLoadSuccess, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLoadSuccess)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06003968 RID: 14696 RVA: 0x0012E2BC File Offset: 0x0012C4BC
		// (remove) Token: 0x06003969 RID: 14697 RVA: 0x0012E2EC File Offset: 0x0012C4EC
		[Token(Token = "0x14000005")]
		public event Action<string> OnLoadFailed
		{
			[Token(Token = "0x6003968")]
			[Address(RVA = "0x7CBE80", Offset = "0x7CA480", VA = "0x1807CBE80")]
			[CompilerGenerated]
			add
			{
				Action<string> onLoadFailed = this.OnLoadFailed;
				Delegate @delegate = Delegate.Combine(onLoadFailed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLoadFailed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6003969")]
			[Address(RVA = "0x7CC310", Offset = "0x7CA910", VA = "0x1807CC310")]
			[CompilerGenerated]
			remove
			{
				Action<string> onLoadFailed = this.OnLoadFailed;
				Delegate @delegate = Delegate.Remove(onLoadFailed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onLoadFailed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600396A RID: 14698 RVA: 0x0012E31C File Offset: 0x0012C51C
		// (remove) Token: 0x0600396B RID: 14699 RVA: 0x0012E34C File Offset: 0x0012C54C
		[Token(Token = "0x14000006")]
		public event Action OnAutoSave
		{
			[Token(Token = "0x600396A")]
			[Address(RVA = "0x7CBDE0", Offset = "0x7CA3E0", VA = "0x1807CBDE0")]
			[CompilerGenerated]
			add
			{
				Action onAutoSave = this.OnAutoSave;
				Delegate @delegate = Delegate.Combine(onAutoSave, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onAutoSave)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x600396B")]
			[Address(RVA = "0x7CC270", Offset = "0x7CA870", VA = "0x1807CC270")]
			[CompilerGenerated]
			remove
			{
				Action onAutoSave = this.OnAutoSave;
				Delegate @delegate = Delegate.Remove(onAutoSave, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onAutoSave)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x0012E37C File Offset: 0x0012C57C
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x7C9990", Offset = "0x7C7F90", VA = "0x1807C9990")]
		private void Awake()
		{
			AutoChessSaveSystem autoChessSaveSystem = AutoChessSaveSystem.instance;
			int num = 0;
			if (autoChessSaveSystem != num && AutoChessSaveSystem.instance != this)
			{
				global::UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			AutoChessSaveSystem.instance = this;
			global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			string text = Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
			if (!Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				Debug.Log("[AutoChessSaveSystem] 创建存档文件夹: " + text);
			}
			this.InitializeSaveSlots();
			Debug.Log("[AutoChessSaveSystem] 存档系统初始化完成");
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x0012E40C File Offset: 0x0012C60C
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x7CBC70", Offset = "0x7CA270", VA = "0x1807CBC70")]
		private void Start()
		{
			this.currentPlayTime = (int)((ulong)0L);
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x0012E424 File Offset: 0x0012C624
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x7CBC80", Offset = "0x7CA280", VA = "0x1807CBC80")]
		private void Update()
		{
			if (!RoundManager.<Instance>k__BackingField.isGameOver && this.isAutoSaveEnabled)
			{
				float deltaTime = Time.deltaTime;
				this.autoSaveTimer = deltaTime;
				this.autoSaveTimer = 0f;
				this.AutoSaveGame();
				return;
			}
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0012E470 File Offset: 0x0012C670
		[Token(Token = "0x600396F")]
		[Address(RVA = "0x7CB2B0", Offset = "0x7C98B0", VA = "0x1807CB2B0")]
		private void InitializeSaveSystem()
		{
			string text = Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
			if (!Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				Debug.Log("[AutoChessSaveSystem] 创建存档文件夹: " + text);
			}
			this.InitializeSaveSlots();
			Debug.Log("[AutoChessSaveSystem] 存档系统初始化完成");
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0012E4C0 File Offset: 0x0012C6C0
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x7CB010", Offset = "0x7C9610", VA = "0x1807CB010")]
		private void InitializeSaveSlots()
		{
			int num = 0;
			List<AutoChessSaveSystem.SaveSlot> list = this.saveSlots;
			int size = list._size;
			list._size = num;
			if (size > 0)
			{
			}
			if (num < 5)
			{
				AutoChessSaveSystem.SaveSlot saveSlot = new AutoChessSaveSystem.SaveSlot();
				saveSlot.isEmpty = true;
				saveSlot.slotIndex = num;
				string saveFilePath = this.GetSaveFilePath(num);
				if (File.Exists(saveFilePath))
				{
					AutoChessSaveSystem.SaveData saveData = JsonUtility.FromJson<AutoChessSaveSystem.SaveData>(File.ReadAllText(saveFilePath));
					string saveName = saveData.saveName;
					saveSlot.saveName = saveName;
					string saveTime = saveData.saveTime;
					saveSlot.saveTime = saveTime;
					int currentRound = saveData.currentRound;
					saveSlot.round = currentRound;
					int level = saveData.level;
					saveSlot.level = level;
					saveSlot.isEmpty = false;
					string text;
					Debug.LogWarning(text);
					saveSlot.isEmpty = true;
				}
				num++;
			}
			int num2;
			Debug.Log(string.Format("[AutoChessSaveSystem] 存档槽位初始化完成，共{0}个槽位", num2));
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x0012E5B0 File Offset: 0x0012C7B0
		[Token(Token = "0x6003971")]
		[Address(RVA = "0x7CB8E0", Offset = "0x7C9EE0", VA = "0x1807CB8E0")]
		public bool SaveGame(int slotIndex, [Optional] string saveName)
		{
			if (slotIndex <= 4)
			{
				AutoChessSaveSystem.SaveData saveData = this.CollectGameData();
				bool flag = string.IsNullOrEmpty(saveName);
				if (flag)
				{
					int num = slotIndex + 1;
					string text = string.Format("存档{0}", flag);
				}
				saveData.saveName = saveName;
				DateTime now = DateTime.Now;
				string text2;
				saveData.saveTime = text2;
				saveData.saveVersion = (int)((ulong)1L);
				ulong num2;
				string text3 = JsonUtility.ToJson(saveData, num2 != 0UL);
				File.WriteAllText(this.GetSaveFilePath(slotIndex), text3);
				AutoChessSaveSystem.SaveSlot saveSlot = this.saveSlots[slotIndex];
				string saveName2 = saveData.saveName;
				saveSlot.saveName = saveName2;
				string saveTime = saveData.saveTime;
				saveSlot.saveTime = saveTime;
				int currentRound = saveData.currentRound;
				saveSlot.round = currentRound;
				int level = saveData.level;
				saveSlot.level = level;
				saveSlot.isEmpty = false;
				if (this.OnSaveSuccess != 0)
				{
				}
				string saveName3 = saveData.saveName;
				string text4 = string.Format("[AutoChessSaveSystem] 存档成功: 槽位{0} - {1}", level, saveName3);
				Debug.Log(text4);
				string text6;
				string text5 = text6 + text6;
			}
			string text7 = string.Format("槽位索引无效: {0}", "存档{0}");
			if (this.OnSaveFailed != 0)
			{
			}
			Debug.LogError("[AutoChessSaveSystem] " + text7);
			throw new NullReferenceException();
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0012E6F8 File Offset: 0x0012C8F8
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x7C97B0", Offset = "0x7C7DB0", VA = "0x1807C97B0")]
		public void AutoSaveGame()
		{
			AutoChessSaveSystem.SaveData saveData = this.CollectGameData();
			saveData.saveName = "自动存档";
			DateTime now = DateTime.Now;
			string text;
			saveData.saveTime = text;
			saveData.saveVersion = (int)((ulong)1L);
			string text2 = JsonUtility.ToJson(saveData, true);
			File.WriteAllText(this.GetAutoSaveFilePath(), text2);
			if (this.OnAutoSave != 0)
			{
			}
			string saveTime = saveData.saveTime;
			string text3 = "[AutoChessSaveSystem] 自动存档成功: " + saveTime;
			Debug.Log(text3);
			Debug.LogError(text3 + text3);
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x0012E78C File Offset: 0x0012C98C
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x7C9BD0", Offset = "0x7C81D0", VA = "0x1807C9BD0")]
		private AutoChessSaveSystem.SaveData CollectGameData()
		{
			AutoChessSaveSystem.SaveData saveData;
			int num2;
			do
			{
				int num = 0;
				int theSun = Board.Instance.theSun;
				saveData.gold = theSun;
				int currentLevel = EconomyManager.<Instance>k__BackingField.currentLevel;
				saveData.level = currentLevel;
				int currentExp = EconomyManager.<Instance>k__BackingField.currentExp;
				saveData.exp = currentExp;
				int currentHealth = EconomyManager.<Instance>k__BackingField.currentHealth;
				saveData.health = currentHealth;
				int winStreak = EconomyManager.<Instance>k__BackingField.winStreak;
				saveData.winStreak = winStreak;
				int currentRound = EconomyManager.<Instance>k__BackingField.currentRound;
				saveData.currentRound = currentRound;
				bool isShopLocked = ShopManager.<Instance>k__BackingField.isShopLocked;
				saveData.shopLocked = isShopLocked;
				List<string> list = new List();
				saveData.shopPlantNames = list;
				ShopManager <Instance>k__BackingField = ShopManager.<Instance>k__BackingField;
				List<PlantData> currentShopPlants = <Instance>k__BackingField.currentShopPlants;
				if (<Instance>k__BackingField != 0)
				{
					if (num >= typeof(IEnumerator).TypeHandle)
					{
						goto IL_00CE;
					}
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
						goto IL_00CE;
					}
					IL_00E2:
					List<string> list2;
					list2 += list2;
					goto IL_00E9;
					IL_00CE:
					list2 = saveData.shopPlantNames;
					int size = list2._size;
					goto IL_00E2;
				}
				IL_00E9:
				List<AutoChessSaveSystem.PlantSaveData> list3 = new List();
				if ("{il2cpp array field local24->}" != (ulong)0L)
				{
				}
				if (num != 0)
				{
					goto IL_01E4;
				}
				List<AutoChessSaveSystem.PlantSaveData> list4 = new List();
				num2 = 0;
				saveData.plantsOnBoard = list4;
				List<Plant> allPlants = Lawnf.GetAllPlants();
				bool flag;
				if (flag)
				{
					AutoChessSaveSystem.PlantSaveData plantSaveData;
					plantSaveData.thePlantType = plantSaveData;
					plantSaveData.starLevel = plantSaveData;
					plantSaveData.theColumn = plantSaveData;
					plantSaveData.theRow = plantSaveData;
					List<AutoChessSaveSystem.PlantSaveData> plantsOnBoard = saveData.plantsOnBoard;
					int size2 = plantsOnBoard._size;
					plantsOnBoard._size = plantSaveData;
				}
			}
			while (num2 != 0);
			int num3 = 0;
			int currentRound2 = saveData.currentRound;
			saveData.totalRounds = currentRound2;
			saveData.totalWins = (int)((ulong)0L);
			int winStreak2 = saveData.winStreak;
			saveData.maxWinStreak = winStreak2;
			saveData.bossesDefeated = num3;
			saveData.playTime = num2;
			RoundPhase currentPhase = RoundManager.<Instance>k__BackingField.currentPhase;
			saveData.currentPhase = currentPhase;
			return saveData;
			IL_01E4:
			throw new IndexOutOfRangeException();
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x0012E99C File Offset: 0x0012CB9C
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x7CB5C0", Offset = "0x7C9BC0", VA = "0x1807CB5C0")]
		public bool LoadGame(int slotIndex)
		{
			if (slotIndex <= 4)
			{
				AutoChessSaveSystem.SaveSlot saveSlot = this.saveSlots[slotIndex];
				if (!saveSlot.isEmpty)
				{
					AutoChessSaveSystem.SaveData saveData = JsonUtility.FromJson<AutoChessSaveSystem.SaveData>(File.ReadAllText(this.GetSaveFilePath(slotIndex)));
					this.ApplyGameData(saveData);
					if (this.OnLoadSuccess != 0)
					{
					}
					string saveName = saveData.saveName;
					string text = string.Format("[AutoChessSaveSystem] 读档成功: 槽位{0} - {1}", saveData, saveName);
					Debug.Log(text);
					string text3;
					string text2 = text3 + text3;
				}
				string text4 = string.Format("槽位{0}为空，无法加载", saveSlot);
				if (this.OnLoadFailed != 0)
				{
				}
				Debug.LogWarning("[AutoChessSaveSystem] " + text4);
			}
			string text5 = string.Format("槽位索引无效: {0}", "槽位{0}为空，无法加载");
			if (this.OnLoadFailed != 0)
			{
			}
			Debug.LogError("[AutoChessSaveSystem] " + text5);
			throw new NullReferenceException();
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0012EA78 File Offset: 0x0012CC78
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x7CB3D0", Offset = "0x7C99D0", VA = "0x1807CB3D0")]
		public bool LoadAutoSave()
		{
			string autoSaveFilePath = this.GetAutoSaveFilePath();
			if (File.Exists(autoSaveFilePath))
			{
				AutoChessSaveSystem.SaveData saveData = JsonUtility.FromJson<AutoChessSaveSystem.SaveData>(File.ReadAllText(autoSaveFilePath));
				this.ApplyGameData(saveData);
				if (this.OnLoadSuccess != 0)
				{
				}
				string saveTime = saveData.saveTime;
				Debug.Log("[AutoChessSaveSystem] 自动存档加载成功: " + saveTime);
			}
			Debug.LogWarning("[AutoChessSaveSystem] 自动存档文件不存在");
			int num = 0;
			string text = num + num;
			Debug.LogError(text + text);
			throw new NullReferenceException();
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0012EB00 File Offset: 0x0012CD00
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x7C92F0", Offset = "0x7C78F0", VA = "0x1807C92F0")]
		private void ApplyGameData(AutoChessSaveSystem.SaveData data)
		{
			int num;
			do
			{
				EconomyManager <Instance>k__BackingField = EconomyManager.<Instance>k__BackingField;
				if ((ulong)1L == 0UL)
				{
				}
				int theSun = Board.Instance.theSun;
				bool flag = <Instance>k__BackingField.SpendGold(theSun);
				EconomyManager <Instance>k__BackingField2 = EconomyManager.<Instance>k__BackingField;
				int gold = data.gold;
				<Instance>k__BackingField2.EarnGold(gold);
				ShopManager <Instance>k__BackingField3 = ShopManager.<Instance>k__BackingField;
				bool shopLocked = data.shopLocked;
				<Instance>k__BackingField3.IsShopLocked = shopLocked;
				SynergyManager.<Instance>k__BackingField.ClearAllSynergies();
				List<AutoChessSaveSystem.PlantSaveData> plantsOnBoard = data.plantsOnBoard;
				num = 0;
				bool flag2;
				if (flag2)
				{
					CreatePlant createPlant = CreatePlant.Instance;
					int num2 = 0;
					if (!(0 != num2))
					{
						continue;
					}
				}
			}
			while (num != 0);
			RoundManager <Instance>k__BackingField4 = RoundManager.<Instance>k__BackingField;
			string text;
			Debug.Log(text);
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0012EBD0 File Offset: 0x0012CDD0
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x7CA380", Offset = "0x7C8980", VA = "0x1807CA380")]
		private Plant CreatePlantFromSaveData(AutoChessSaveSystem.PlantSaveData plantData)
		{
			CreatePlant createPlant = CreatePlant.Instance;
			int starLevel = plantData.starLevel;
			int num = 0;
			Plant plant;
			bool flag = plant.Upgrade(starLevel, true, num != 0);
			throw new NullReferenceException();
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0012EC0C File Offset: 0x0012CE0C
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x7CA550", Offset = "0x7C8B50", VA = "0x1807CA550")]
		public bool DeleteSave(int slotIndex)
		{
			if (slotIndex <= 4)
			{
				string saveFilePath = this.GetSaveFilePath(slotIndex);
				if (File.Exists(saveFilePath))
				{
					File.Delete(saveFilePath);
				}
				AutoChessSaveSystem.SaveSlot saveSlot = this.saveSlots[slotIndex];
				int num = 0;
				saveSlot.saveName = num;
				saveSlot.saveTime = num;
				saveSlot.round = num;
				saveSlot.isEmpty = true;
				string text = string.Format("[AutoChessSaveSystem] 删除存档成功: 槽位{0}", saveSlot);
				Debug.Log(text);
			}
			Debug.LogError(string.Format("[AutoChessSaveSystem] 槽位索引无效: {0}", "[AutoChessSaveSystem] 删除存档成功: 槽位{0}"));
			throw new NullReferenceException();
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x0012ECA0 File Offset: 0x0012CEA0
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x7CA450", Offset = "0x7C8A50", VA = "0x1807CA450")]
		public void DeleteAutoSave()
		{
			string autoSaveFilePath = this.GetAutoSaveFilePath();
			if (File.Exists(autoSaveFilePath))
			{
				File.Delete(autoSaveFilePath);
				Debug.Log("[AutoChessSaveSystem] 自动存档已删除");
			}
			string text;
			Debug.LogError(text);
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x0012ECE0 File Offset: 0x0012CEE0
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x7CAA60", Offset = "0x7C9060", VA = "0x1807CAA60")]
		private string GetSaveFolderPath()
		{
			return Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0012ED00 File Offset: 0x0012CF00
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x7CA960", Offset = "0x7C8F60", VA = "0x1807CA960")]
		private string GetSaveFilePath(int slotIndex)
		{
			string text = Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
			string text2 = string.Format("save{0}.json", text);
			return Path.Combine(text, text2);
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0012ED34 File Offset: 0x0012CF34
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x7CA750", Offset = "0x7C8D50", VA = "0x1807CA750")]
		private string GetAutoSaveFilePath()
		{
			return Path.Combine(Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves"), "autosave.json");
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0012ED5C File Offset: 0x0012CF5C
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x7CAAD0", Offset = "0x7C90D0", VA = "0x1807CAAD0")]
		public string GetSaveSystemInfo()
		{
			string text = Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
			int num = 0;
			string text2 = "=== 存档系统信息 ===\n" + "存档文件夹: " + text + "\n";
			int num2;
			string text3 = string.Format("最大槽位数: {0}\n", num2);
			string text4 = text2 + text3;
			if ((this.isAutoSaveEnabled ? 1 : 0) == num)
			{
			}
			string text5 = text4 + "自动存档: " + "启用" + "\n";
			string text6 = string.Format("自动存档间隔: {0}秒\n", text5);
			string text7 = text5 + text6;
			int num3 = this.currentPlayTime;
			string text8 = string.Format("当前游戏时长: {0}秒\n", text7);
			string text9 = text7 + text8 + "\n=== 存档槽位 ===\n";
			List<AutoChessSaveSystem.SaveSlot> list = this.saveSlots;
			AutoChessSaveSystem.SaveSlot saveSlot = this.saveSlots[num];
			if (!saveSlot.isEmpty)
			{
				object[] array = new object[5];
				int num4;
				if (num4 != 0)
				{
				}
				array[0] = num4;
				string saveName = saveSlot.saveName;
				if (saveName != 0)
				{
				}
				array[1] = saveName;
				int num5 = saveSlot.round;
				if (num5 != 0)
				{
				}
				array[2] = num5;
				int level = saveSlot.level;
				num5 = level;
				if (level != 0)
				{
				}
				array[3] = num5;
				string saveTime = saveSlot.saveTime;
				if (saveTime != 0)
				{
				}
				array[4] = saveTime;
				string text10 = string.Format("槽位{0}: {1} - 回合{2} Lv.{3} ({4})\n", array);
			}
			int num6;
			string text11 = string.Format("槽位{0}: [空]\n", num6);
			string text12 = text9 + text11;
			num++;
			List<AutoChessSaveSystem.SaveSlot> list2 = this.saveSlots;
			return text12;
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x0012EEEC File Offset: 0x0012D0EC
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x7CAFF0", Offset = "0x7C95F0", VA = "0x1807CAFF0")]
		public bool HasAutoSave()
		{
			return File.Exists(this.GetAutoSaveFilePath());
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x0012EF04 File Offset: 0x0012D104
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x7CA810", Offset = "0x7C8E10", VA = "0x1807CA810")]
		public string GetAutoSaveInfo()
		{
			string autoSaveFilePath = this.GetAutoSaveFilePath();
			if (File.Exists(autoSaveFilePath))
			{
				AutoChessSaveSystem.SaveData saveData = JsonUtility.FromJson<AutoChessSaveSystem.SaveData>(File.ReadAllText(autoSaveFilePath));
				int currentRound = saveData.currentRound;
				int level = saveData.level;
				string saveTime = saveData.saveTime;
				string text = string.Format("自动存档: 回合{0} Lv.{1} ({2})", saveData, saveData, saveTime);
				TypeCode typeCode = currentRound.GetTypeCode();
				string text2;
				return text2;
			}
			return "自动存档不存在";
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x0012EF74 File Offset: 0x0012D174
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x7CBD60", Offset = "0x7CA360", VA = "0x1807CBD60")]
		public AutoChessSaveSystem()
		{
			List<AutoChessSaveSystem.SaveSlot> list = new List();
			this.saveSlots = list;
			base..ctor();
		}

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		private static AutoChessSaveSystem instance;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		private const string saveFolder = "AutoChessSaves";

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		private const string autoSaveFileName = "autosave.json";

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		private const int maxSaveSlots = 5;

		// Token: 0x04002B94 RID: 11156
		[Token(Token = "0x4002B94")]
		private const float autoSaveInterval = 60f;

		// Token: 0x04002B95 RID: 11157
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B95")]
		private float autoSaveTimer;

		// Token: 0x04002B96 RID: 11158
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002B96")]
		private int currentPlayTime;

		// Token: 0x04002B97 RID: 11159
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B97")]
		private bool isAutoSaveEnabled = true;

		// Token: 0x04002B98 RID: 11160
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B98")]
		private List<AutoChessSaveSystem.SaveSlot> saveSlots;

		// Token: 0x02000AE8 RID: 2792
		[Token(Token = "0x2000AE8")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x06003981 RID: 14721 RVA: 0x0012EF9C File Offset: 0x0012D19C
			[Token(Token = "0x6003981")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public SaveData()
			{
			}

			// Token: 0x04002B9E RID: 11166
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002B9E")]
			public string saveName;

			// Token: 0x04002B9F RID: 11167
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002B9F")]
			public string saveTime;

			// Token: 0x04002BA0 RID: 11168
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002BA0")]
			public int saveVersion;

			// Token: 0x04002BA1 RID: 11169
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4002BA1")]
			public int playTime;

			// Token: 0x04002BA2 RID: 11170
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002BA2")]
			public int gold;

			// Token: 0x04002BA3 RID: 11171
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4002BA3")]
			public int level;

			// Token: 0x04002BA4 RID: 11172
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4002BA4")]
			public int exp;

			// Token: 0x04002BA5 RID: 11173
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Token(Token = "0x4002BA5")]
			public int health;

			// Token: 0x04002BA6 RID: 11174
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4002BA6")]
			public int plantCount;

			// Token: 0x04002BA7 RID: 11175
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Token(Token = "0x4002BA7")]
			public int winStreak;

			// Token: 0x04002BA8 RID: 11176
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4002BA8")]
			public int currentRound;

			// Token: 0x04002BA9 RID: 11177
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4002BA9")]
			public bool shopLocked;

			// Token: 0x04002BAA RID: 11178
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Token(Token = "0x4002BAA")]
			public List<string> shopPlantNames;

			// Token: 0x04002BAB RID: 11179
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Token(Token = "0x4002BAB")]
			public List<AutoChessSaveSystem.PlantSaveData> plantsOnBoard;

			// Token: 0x04002BAC RID: 11180
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Token(Token = "0x4002BAC")]
			public int totalRounds;

			// Token: 0x04002BAD RID: 11181
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Token(Token = "0x4002BAD")]
			public int totalWins;

			// Token: 0x04002BAE RID: 11182
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Token(Token = "0x4002BAE")]
			public int totalLosses;

			// Token: 0x04002BAF RID: 11183
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Token(Token = "0x4002BAF")]
			public int maxWinStreak;

			// Token: 0x04002BB0 RID: 11184
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Token(Token = "0x4002BB0")]
			public int bossesDefeated;

			// Token: 0x04002BB1 RID: 11185
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Token(Token = "0x4002BB1")]
			public RoundPhase currentPhase;
		}

		// Token: 0x02000AE9 RID: 2793
		[Token(Token = "0x2000AE9")]
		[Serializable]
		public class PlantSaveData
		{
			// Token: 0x06003982 RID: 14722 RVA: 0x0012EFB0 File Offset: 0x0012D1B0
			[Token(Token = "0x6003982")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public PlantSaveData()
			{
			}

			// Token: 0x04002BB2 RID: 11186
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002BB2")]
			public PlantType thePlantType;

			// Token: 0x04002BB3 RID: 11187
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4002BB3")]
			public int theColumn;

			// Token: 0x04002BB4 RID: 11188
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002BB4")]
			public int theRow;

			// Token: 0x04002BB5 RID: 11189
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002BB5")]
			public int starLevel;
		}

		// Token: 0x02000AEA RID: 2794
		[Token(Token = "0x2000AEA")]
		[Serializable]
		public class SaveSlot
		{
			// Token: 0x06003983 RID: 14723 RVA: 0x0012EFC4 File Offset: 0x0012D1C4
			[Token(Token = "0x6003983")]
			[Address(RVA = "0x7DC920", Offset = "0x7DAF20", VA = "0x1807DC920")]
			public SaveSlot()
			{
				this.isEmpty = true;
			}

			// Token: 0x04002BB6 RID: 11190
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002BB6")]
			public int slotIndex;

			// Token: 0x04002BB7 RID: 11191
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002BB7")]
			public string saveName;

			// Token: 0x04002BB8 RID: 11192
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002BB8")]
			public string saveTime;

			// Token: 0x04002BB9 RID: 11193
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002BB9")]
			public int round;

			// Token: 0x04002BBA RID: 11194
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4002BBA")]
			public int level;

			// Token: 0x04002BBB RID: 11195
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4002BBB")]
			public bool isEmpty;
		}
	}
}
