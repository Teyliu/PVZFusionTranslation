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
	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2000AA7")]
	public class AutoChessSaveSystem : MonoBehaviour
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x00128EC8 File Offset: 0x001270C8
		[Token(Token = "0x1700037C")]
		public static AutoChessSaveSystem Instance
		{
			[Token(Token = "0x6003819")]
			[Address(RVA = "0x765300", Offset = "0x763900", VA = "0x180765300")]
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600381A RID: 14362 RVA: 0x00128F10 File Offset: 0x00127110
		// (set) Token: 0x0600381B RID: 14363 RVA: 0x00128F24 File Offset: 0x00127124
		[Token(Token = "0x1700037D")]
		public bool IsAutoSaveEnabled
		{
			[Token(Token = "0x600381A")]
			[Address(RVA = "0x3B3F20", Offset = "0x3B2520", VA = "0x1803B3F20")]
			get
			{
				return this.isAutoSaveEnabled;
			}
			[Token(Token = "0x600381B")]
			[Address(RVA = "0x765790", Offset = "0x763D90", VA = "0x180765790")]
			set
			{
				this.isAutoSaveEnabled = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x00128F38 File Offset: 0x00127138
		[Token(Token = "0x1700037E")]
		public int CurrentPlayTime
		{
			[Token(Token = "0x600381C")]
			[Address(RVA = "0x525960", Offset = "0x523F60", VA = "0x180525960")]
			get
			{
				return this.currentPlayTime;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x00128F4C File Offset: 0x0012714C
		[Token(Token = "0x1700037F")]
		public IReadOnlyList<AutoChessSaveSystem.SaveSlot> SaveSlots
		{
			[Token(Token = "0x600381D")]
			[Address(RVA = "0x7291C0", Offset = "0x7277C0", VA = "0x1807291C0")]
			get
			{
				List<AutoChessSaveSystem.SaveSlot> list = this.saveSlots;
				return null;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600381E RID: 14366 RVA: 0x00128F6C File Offset: 0x0012716C
		// (remove) Token: 0x0600381F RID: 14367 RVA: 0x00128F9C File Offset: 0x0012719C
		[Token(Token = "0x14000002")]
		public event Action<string> OnSaveSuccess
		{
			[Token(Token = "0x600381E")]
			[Address(RVA = "0x765250", Offset = "0x763850", VA = "0x180765250")]
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
			[Token(Token = "0x600381F")]
			[Address(RVA = "0x7656E0", Offset = "0x763CE0", VA = "0x1807656E0")]
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
		// (add) Token: 0x06003820 RID: 14368 RVA: 0x00128FCC File Offset: 0x001271CC
		// (remove) Token: 0x06003821 RID: 14369 RVA: 0x00128FFC File Offset: 0x001271FC
		[Token(Token = "0x14000003")]
		public event Action<string> OnSaveFailed
		{
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x7651A0", Offset = "0x7637A0", VA = "0x1807651A0")]
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
			[Token(Token = "0x6003821")]
			[Address(RVA = "0x765630", Offset = "0x763C30", VA = "0x180765630")]
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
		// (add) Token: 0x06003822 RID: 14370 RVA: 0x0012902C File Offset: 0x0012722C
		// (remove) Token: 0x06003823 RID: 14371 RVA: 0x0012905C File Offset: 0x0012725C
		[Token(Token = "0x14000004")]
		public event Action<AutoChessSaveSystem.SaveData> OnLoadSuccess
		{
			[Token(Token = "0x6003822")]
			[Address(RVA = "0x7650F0", Offset = "0x7636F0", VA = "0x1807650F0")]
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
			[Token(Token = "0x6003823")]
			[Address(RVA = "0x765580", Offset = "0x763B80", VA = "0x180765580")]
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
		// (add) Token: 0x06003824 RID: 14372 RVA: 0x0012908C File Offset: 0x0012728C
		// (remove) Token: 0x06003825 RID: 14373 RVA: 0x001290BC File Offset: 0x001272BC
		[Token(Token = "0x14000005")]
		public event Action<string> OnLoadFailed
		{
			[Token(Token = "0x6003824")]
			[Address(RVA = "0x765040", Offset = "0x763640", VA = "0x180765040")]
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
			[Token(Token = "0x6003825")]
			[Address(RVA = "0x7654D0", Offset = "0x763AD0", VA = "0x1807654D0")]
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
		// (add) Token: 0x06003826 RID: 14374 RVA: 0x001290EC File Offset: 0x001272EC
		// (remove) Token: 0x06003827 RID: 14375 RVA: 0x0012911C File Offset: 0x0012731C
		[Token(Token = "0x14000006")]
		public event Action OnAutoSave
		{
			[Token(Token = "0x6003826")]
			[Address(RVA = "0x764FA0", Offset = "0x7635A0", VA = "0x180764FA0")]
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
			[Token(Token = "0x6003827")]
			[Address(RVA = "0x765430", Offset = "0x763A30", VA = "0x180765430")]
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

		// Token: 0x06003828 RID: 14376 RVA: 0x0012914C File Offset: 0x0012734C
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x762B50", Offset = "0x761150", VA = "0x180762B50")]
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

		// Token: 0x06003829 RID: 14377 RVA: 0x001291DC File Offset: 0x001273DC
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x764E30", Offset = "0x763430", VA = "0x180764E30")]
		private void Start()
		{
			this.currentPlayTime = (int)((ulong)0L);
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x001291F4 File Offset: 0x001273F4
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x764E40", Offset = "0x763440", VA = "0x180764E40")]
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

		// Token: 0x0600382B RID: 14379 RVA: 0x00129240 File Offset: 0x00127440
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x764470", Offset = "0x762A70", VA = "0x180764470")]
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

		// Token: 0x0600382C RID: 14380 RVA: 0x00129290 File Offset: 0x00127490
		[Token(Token = "0x600382C")]
		[Address(RVA = "0x7641D0", Offset = "0x7627D0", VA = "0x1807641D0")]
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

		// Token: 0x0600382D RID: 14381 RVA: 0x00129380 File Offset: 0x00127580
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x764AA0", Offset = "0x7630A0", VA = "0x180764AA0")]
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

		// Token: 0x0600382E RID: 14382 RVA: 0x001294C8 File Offset: 0x001276C8
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x762970", Offset = "0x760F70", VA = "0x180762970")]
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

		// Token: 0x0600382F RID: 14383 RVA: 0x0012955C File Offset: 0x0012775C
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x762D90", Offset = "0x761390", VA = "0x180762D90")]
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

		// Token: 0x06003830 RID: 14384 RVA: 0x0012976C File Offset: 0x0012796C
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x764780", Offset = "0x762D80", VA = "0x180764780")]
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

		// Token: 0x06003831 RID: 14385 RVA: 0x00129848 File Offset: 0x00127A48
		[Token(Token = "0x6003831")]
		[Address(RVA = "0x764590", Offset = "0x762B90", VA = "0x180764590")]
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

		// Token: 0x06003832 RID: 14386 RVA: 0x001298D0 File Offset: 0x00127AD0
		[Token(Token = "0x6003832")]
		[Address(RVA = "0x7624B0", Offset = "0x760AB0", VA = "0x1807624B0")]
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

		// Token: 0x06003833 RID: 14387 RVA: 0x001299A0 File Offset: 0x00127BA0
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x763540", Offset = "0x761B40", VA = "0x180763540")]
		private Plant CreatePlantFromSaveData(AutoChessSaveSystem.PlantSaveData plantData)
		{
			CreatePlant createPlant = CreatePlant.Instance;
			int starLevel = plantData.starLevel;
			int num = 0;
			Plant plant;
			bool flag = plant.Upgrade(starLevel, true, num != 0);
			throw new NullReferenceException();
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x001299DC File Offset: 0x00127BDC
		[Token(Token = "0x6003834")]
		[Address(RVA = "0x763710", Offset = "0x761D10", VA = "0x180763710")]
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

		// Token: 0x06003835 RID: 14389 RVA: 0x00129A70 File Offset: 0x00127C70
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x763610", Offset = "0x761C10", VA = "0x180763610")]
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

		// Token: 0x06003836 RID: 14390 RVA: 0x00129AB0 File Offset: 0x00127CB0
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x763C20", Offset = "0x762220", VA = "0x180763C20")]
		private string GetSaveFolderPath()
		{
			return Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00129AD0 File Offset: 0x00127CD0
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x763B20", Offset = "0x762120", VA = "0x180763B20")]
		private string GetSaveFilePath(int slotIndex)
		{
			string text = Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves");
			string text2 = string.Format("save{0}.json", text);
			return Path.Combine(text, text2);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00129B04 File Offset: 0x00127D04
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x763910", Offset = "0x761F10", VA = "0x180763910")]
		private string GetAutoSaveFilePath()
		{
			return Path.Combine(Path.Combine(SaveInfo.GetDataPath(), "AutoChessSaves"), "autosave.json");
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00129B2C File Offset: 0x00127D2C
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x763C90", Offset = "0x762290", VA = "0x180763C90")]
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

		// Token: 0x0600383A RID: 14394 RVA: 0x00129CBC File Offset: 0x00127EBC
		[Token(Token = "0x600383A")]
		[Address(RVA = "0x7641B0", Offset = "0x7627B0", VA = "0x1807641B0")]
		public bool HasAutoSave()
		{
			return File.Exists(this.GetAutoSaveFilePath());
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00129CD4 File Offset: 0x00127ED4
		[Token(Token = "0x600383B")]
		[Address(RVA = "0x7639D0", Offset = "0x761FD0", VA = "0x1807639D0")]
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

		// Token: 0x0600383C RID: 14396 RVA: 0x00129D44 File Offset: 0x00127F44
		[Token(Token = "0x600383C")]
		[Address(RVA = "0x764F20", Offset = "0x763520", VA = "0x180764F20")]
		public AutoChessSaveSystem()
		{
			List<AutoChessSaveSystem.SaveSlot> list = new List();
			this.saveSlots = list;
			base..ctor();
		}

		// Token: 0x04002A1D RID: 10781
		[Token(Token = "0x4002A1D")]
		private static AutoChessSaveSystem instance;

		// Token: 0x04002A1E RID: 10782
		[Token(Token = "0x4002A1E")]
		private const string saveFolder = "AutoChessSaves";

		// Token: 0x04002A1F RID: 10783
		[Token(Token = "0x4002A1F")]
		private const string autoSaveFileName = "autosave.json";

		// Token: 0x04002A20 RID: 10784
		[Token(Token = "0x4002A20")]
		private const int maxSaveSlots = 5;

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		private const float autoSaveInterval = 60f;

		// Token: 0x04002A22 RID: 10786
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A22")]
		private float autoSaveTimer;

		// Token: 0x04002A23 RID: 10787
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002A23")]
		private int currentPlayTime;

		// Token: 0x04002A24 RID: 10788
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A24")]
		private bool isAutoSaveEnabled = true;

		// Token: 0x04002A25 RID: 10789
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A25")]
		private List<AutoChessSaveSystem.SaveSlot> saveSlots;

		// Token: 0x02000AA8 RID: 2728
		[Token(Token = "0x2000AA8")]
		[Serializable]
		public class SaveData
		{
			// Token: 0x0600383D RID: 14397 RVA: 0x00129D6C File Offset: 0x00127F6C
			[Token(Token = "0x600383D")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public SaveData()
			{
			}

			// Token: 0x04002A2B RID: 10795
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002A2B")]
			public string saveName;

			// Token: 0x04002A2C RID: 10796
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002A2C")]
			public string saveTime;

			// Token: 0x04002A2D RID: 10797
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002A2D")]
			public int saveVersion;

			// Token: 0x04002A2E RID: 10798
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Token(Token = "0x4002A2E")]
			public int playTime;

			// Token: 0x04002A2F RID: 10799
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002A2F")]
			public int gold;

			// Token: 0x04002A30 RID: 10800
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4002A30")]
			public int level;

			// Token: 0x04002A31 RID: 10801
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4002A31")]
			public int exp;

			// Token: 0x04002A32 RID: 10802
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Token(Token = "0x4002A32")]
			public int health;

			// Token: 0x04002A33 RID: 10803
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4002A33")]
			public int plantCount;

			// Token: 0x04002A34 RID: 10804
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Token(Token = "0x4002A34")]
			public int winStreak;

			// Token: 0x04002A35 RID: 10805
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4002A35")]
			public int currentRound;

			// Token: 0x04002A36 RID: 10806
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4002A36")]
			public bool shopLocked;

			// Token: 0x04002A37 RID: 10807
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Token(Token = "0x4002A37")]
			public List<string> shopPlantNames;

			// Token: 0x04002A38 RID: 10808
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Token(Token = "0x4002A38")]
			public List<AutoChessSaveSystem.PlantSaveData> plantsOnBoard;

			// Token: 0x04002A39 RID: 10809
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Token(Token = "0x4002A39")]
			public int totalRounds;

			// Token: 0x04002A3A RID: 10810
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Token(Token = "0x4002A3A")]
			public int totalWins;

			// Token: 0x04002A3B RID: 10811
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Token(Token = "0x4002A3B")]
			public int totalLosses;

			// Token: 0x04002A3C RID: 10812
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Token(Token = "0x4002A3C")]
			public int maxWinStreak;

			// Token: 0x04002A3D RID: 10813
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Token(Token = "0x4002A3D")]
			public int bossesDefeated;

			// Token: 0x04002A3E RID: 10814
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Token(Token = "0x4002A3E")]
			public RoundPhase currentPhase;
		}

		// Token: 0x02000AA9 RID: 2729
		[Token(Token = "0x2000AA9")]
		[Serializable]
		public class PlantSaveData
		{
			// Token: 0x0600383E RID: 14398 RVA: 0x00129D80 File Offset: 0x00127F80
			[Token(Token = "0x600383E")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public PlantSaveData()
			{
			}

			// Token: 0x04002A3F RID: 10815
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002A3F")]
			public PlantType thePlantType;

			// Token: 0x04002A40 RID: 10816
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4002A40")]
			public int theColumn;

			// Token: 0x04002A41 RID: 10817
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002A41")]
			public int theRow;

			// Token: 0x04002A42 RID: 10818
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4002A42")]
			public int starLevel;
		}

		// Token: 0x02000AAA RID: 2730
		[Token(Token = "0x2000AAA")]
		[Serializable]
		public class SaveSlot
		{
			// Token: 0x0600383F RID: 14399 RVA: 0x00129D94 File Offset: 0x00127F94
			[Token(Token = "0x600383F")]
			[Address(RVA = "0x775A90", Offset = "0x774090", VA = "0x180775A90")]
			public SaveSlot()
			{
				this.isEmpty = true;
			}

			// Token: 0x04002A43 RID: 10819
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002A43")]
			public int slotIndex;

			// Token: 0x04002A44 RID: 10820
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002A44")]
			public string saveName;

			// Token: 0x04002A45 RID: 10821
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002A45")]
			public string saveTime;

			// Token: 0x04002A46 RID: 10822
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002A46")]
			public int round;

			// Token: 0x04002A47 RID: 10823
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4002A47")]
			public int level;

			// Token: 0x04002A48 RID: 10824
			[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4002A48")]
			public bool isEmpty;
		}
	}
}
