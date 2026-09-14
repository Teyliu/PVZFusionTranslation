using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000BF7 RID: 3063
	[Token(Token = "0x2000BF7")]
	public class ShootingManager : MonoBehaviour
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06003FDE RID: 16350 RVA: 0x00152214 File Offset: 0x00150414
		[Token(Token = "0x170004BD")]
		public static RogueShootingData Data
		{
			[Token(Token = "0x6003FDE")]
			[Address(RVA = "0x822FC0", Offset = "0x8215C0", VA = "0x180822FC0")]
			get
			{
				return GameAPP.config.shootingData;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06003FDF RID: 16351 RVA: 0x00152234 File Offset: 0x00150434
		[Token(Token = "0x170004BE")]
		private bool SuperQualitative
		{
			[Token(Token = "0x6003FDF")]
			[Address(RVA = "0x823060", Offset = "0x821660", VA = "0x180823060")]
			get
			{
				float value = global::UnityEngine.Random.value;
				return false;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06003FE0 RID: 16352 RVA: 0x0015224C File Offset: 0x0015044C
		// (set) Token: 0x06003FE1 RID: 16353 RVA: 0x00152260 File Offset: 0x00150460
		[Token(Token = "0x170004BF")]
		public float Lucky
		{
			[Token(Token = "0x6003FE0")]
			[Address(RVA = "0x823050", Offset = "0x821650", VA = "0x180823050")]
			get
			{
				return this._lucky;
			}
			[Token(Token = "0x6003FE1")]
			[Address(RVA = "0x823080", Offset = "0x821680", VA = "0x180823080")]
			set
			{
				this._lucky = value;
				Dictionary<Quality, float> dictionary = new Dictionary();
				float lucky = this._lucky;
				float lucky2 = this._lucky;
				float num = this._lucky * 3f;
				float lucky3 = this._lucky;
				this.qualityWeights = dictionary;
				throw new NullReferenceException();
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06003FE2 RID: 16354 RVA: 0x001522AC File Offset: 0x001504AC
		[Token(Token = "0x170004C0")]
		private float LuckyMultiplier
		{
			[Token(Token = "0x6003FE2")]
			[Address(RVA = "0x823030", Offset = "0x821630", VA = "0x180823030")]
			get
			{
				return this._lucky * 0.3f;
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x001522C8 File Offset: 0x001504C8
		[Token(Token = "0x6003FE3")]
		[Address(RVA = "0x81B1B0", Offset = "0x8197B0", VA = "0x18081B1B0")]
		private void Awake()
		{
			ShootingManager.Instance = this;
			List<PlantType> list = new List(this.AllPlants);
			this.RestPlants = list;
			List<RandomZombieType> list2 = Enumerable.ToList<RandomZombieType>(global::Core.Lawnf.GetEnumValues<RandomZombieType>());
			bool flag = list2.Remove((uint)4);
			ShootingManager.randomType = ListExtensions.GetRandom<RandomZombieType>(list2);
			bool flag2 = GameAPP.config.shootingData.victoryTimes >= 20;
			this.canTab = flag2;
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00152334 File Offset: 0x00150534
		[Token(Token = "0x6003FE4")]
		[Address(RVA = "0x81B3A0", Offset = "0x8199A0", VA = "0x18081B3A0")]
		public void BossSpawn(ZombieBoss boss)
		{
			int num = 0;
			List<ZombieType> list = this.zombieTypes2;
			ZombieType random = ListExtensions.GetRandom<ZombieType>(Enumerable.ToList<ZombieType>(Enumerable.Concat<ZombieType>(this.zombieTypes1, list)));
			Board board = this.board;
			if (num < board.rowNum)
			{
				CreateZombie instance = CreateZombie.Instance;
				num++;
			}
			num++;
			if (boss != 0)
			{
				List<ZombieType> list2 = this.leaders;
				CreateZombie instance2 = CreateZombie.Instance;
				ZombieType random2 = ListExtensions.GetRandom<ZombieType>(list2);
				Transform spawnPosition = boss.spawnPosition;
				return;
			}
			IEnumerable<ZombieType> enumerable;
			List<ZombieType> list3 = Enumerable.ToList<ZombieType>(enumerable);
			throw new NullReferenceException();
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x001523B8 File Offset: 0x001505B8
		[Token(Token = "0x6003FE5")]
		[Address(RVA = "0x81FF60", Offset = "0x81E560", VA = "0x18081FF60")]
		private void Start()
		{
			bool flag = GameAPP.soundManager.musics[(uint)17].LoadAudioData();
			bool flag2 = GameAPP.soundManager.musics[(uint)18].LoadAudioData();
			if (GameAPP.config.ra2Sound)
			{
				bool flag3 = GameAPP.soundManager.musics[(uint)26].LoadAudioData();
			}
			Action action = delegate
			{
				Board board = this.board;
				int num7 = board.theWave;
				if (board < 0)
				{
					num7++;
				}
				if (num7 == 0)
				{
					this.ShowBuff();
					return;
				}
			};
			int num = 0;
			EventManager.AddListener(GameEvent.BoardWaveAdd, action, num != 0);
			Action action2 = delegate
			{
				int num8;
				for (;;)
				{
					Board board2 = this.board;
					int theMaxWave = board2.theMaxWave;
					if (board2.theWave != theMaxWave || this.maxStage == 0)
					{
						return;
					}
					num8 = this.stage;
					if (this.maxStage != 0)
					{
						break;
					}
					CreateZombie instance2 = CreateZombie.Instance;
					Zombie zombie;
					if (zombie != 0)
					{
					}
					global::Lawnf.SetZombieHealth(zombie, 100f);
					List<ZombieType> list = new List();
					if (GameAPP.config.ra2Sound)
					{
						goto Block_4;
					}
				}
				if (num8 == 1)
				{
					CreateZombie instance3 = CreateZombie.Instance;
					Zombie zombie2;
					if (zombie2 != 0)
					{
					}
					global::Lawnf.SetZombieHealth(zombie2, 50f);
					GameAPP instance4 = GameAPP.Instance;
					return;
				}
				CreateZombie instance5 = CreateZombie.Instance;
				int num9 = 0;
				Zombie zombie3;
				if (zombie3 != 0)
				{
				}
				global::Lawnf.SetZombieHealth(num9, 50f);
				GameAPP instance6 = GameAPP.Instance;
				return;
				Block_4:
				GameAPP instance7 = GameAPP.Instance;
			};
			int num2 = 0;
			EventManager.AddListener((GameEvent)((uint)3), action2, num2 != 0);
			int num3 = 0;
			Action<object> action3;
			EventManager.AddListener_obj((GameEvent)((uint)2), action3, num3 != 0);
			Action action4 = delegate
			{
				GameAPP.config.shootingData.OnBoardWin(this);
			};
			int num4 = 0;
			EventManager.AddListener((GameEvent)((uint)19), action4, num4 != 0);
			InGameText instance = InGameText.Instance;
			int num5 = 0;
			instance.ShowText("在出战前请先点击右下角查看出怪", 10f, num5 != 0);
			float num6 = this.shieldHealth;
			this.shieldHealth = num6;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x001524B4 File Offset: 0x001506B4
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x81B670", Offset = "0x819C70", VA = "0x18081B670")]
		public void CheatHard()
		{
			if (!this.cheatHard)
			{
				this.cheatHard = true;
				List<TextMeshProUGUI> levelNameText = InGameUI.Instance.levelNameText;
				Action<TextMeshProUGUI> <>9__39_ = ShootingManager.<>c.<>9__39_0;
				if (<>9__39_ == 0)
				{
					Action<TextMeshProUGUI> action;
					ShootingManager.<>c.<>9__39_0 = action;
				}
				levelNameText.ForEach(<>9__39_);
				Action action2 = delegate
				{
					BoardConfig config = this.board.config;
					int num2 = this.stage;
					int num3 = num2 * num2;
					int theWave = this.board.theWave;
					uint num4;
					num4 += num4;
					if (theWave == (int)num4)
					{
						List<ZombieType> list = new List(this.leaders);
						Board board = this.board;
						CreateZombie instance = CreateZombie.Instance;
						int rowNum = board.rowNum;
						int num5 = global::UnityEngine.Random.Range(0, rowNum);
						ZombieType random = ListExtensions.GetRandom<ZombieType>(list);
					}
				};
				int num = 0;
				EventManager.AddListener(GameEvent.BoardWaveAdd, action2, num != 0);
			}
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00152518 File Offset: 0x00150718
		[Token(Token = "0x6003FE7")]
		[Address(RVA = "0x81D7F0", Offset = "0x81BDF0", VA = "0x18081D7F0")]
		public void QuickShowBuff()
		{
			this.ShowBuff();
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x0015252C File Offset: 0x0015072C
		[Token(Token = "0x6003FE8")]
		[Address(RVA = "0x81BC00", Offset = "0x81A200", VA = "0x18081BC00")]
		public Quality GetRandomQuality()
		{
			ulong num2;
			do
			{
				int i = 0;
				if (this.superUpgrade)
				{
					break;
				}
				float num = Enumerable.Sum(this.qualityWeights.Values);
				float value = global::UnityEngine.Random.value;
				Dictionary<Quality, float> dictionary = this.qualityWeights;
				bool flag;
				if (flag)
				{
					while (i <= (int)value)
					{
					}
				}
			}
			while (num2 != (ulong)0L);
			return Quality.diamond;
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00152588 File Offset: 0x00150788
		[Token(Token = "0x6003FE9")]
		[Address(RVA = "0x81BB70", Offset = "0x81A170", VA = "0x18081BB70")]
		public float GetQualityValue(float baseValue, Quality quality)
		{
			if (this.superUpgrade && quality == Quality.diamond)
			{
				return baseValue * 25f;
			}
			float num;
			if (quality == Quality.Default || quality == Quality.Default)
			{
				return num;
			}
			if (quality != Quality.Default)
			{
				if (quality != Quality.silver)
				{
				}
				num = baseValue * 5f;
				return num;
			}
			return num;
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x001525D0 File Offset: 0x001507D0
		[Token(Token = "0x6003FEA")]
		[Address(RVA = "0x81BBD0", Offset = "0x81A1D0", VA = "0x18081BBD0")]
		public int GetQualityValue(int baseValue, Quality quality)
		{
			if (quality != Quality.Default && quality != Quality.Default && quality != Quality.Default && quality != Quality.silver)
			{
				return 0;
			}
			return baseValue;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x001525F4 File Offset: 0x001507F4
		[Token(Token = "0x6003FEB")]
		[Address(RVA = "0x8202A0", Offset = "0x81E8A0", VA = "0x1808202A0")]
		public bool TryGetPlant(PlantType thePlantType, [Out] Plant plant)
		{
			new ShootingManager.<>c__DisplayClass44_0().thePlantType = thePlantType;
			Func<Plant, bool> func;
			Plant plant2 = Enumerable.FirstOrDefault<Plant>(Board.Instance.boardEntity.plantHead, func);
			bool flag;
			return flag;
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00152634 File Offset: 0x00150834
		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x81B9C0", Offset = "0x819FC0", VA = "0x18081B9C0")]
		public void GetNewPlant(PlantType thePlantType, bool free = false)
		{
			CreatePlant instance = CreatePlant.Instance;
			List<PlantType> yourPlants = this.YourPlants;
			int size = yourPlants._size;
			Plant plant;
			HealthSlider healthSlider = plant.snakePre.healthSlider;
			int num = (int)(thePlantType + 1);
			yourPlants._size = num;
			healthSlider.fillObject = thePlantType;
			List<PlantType> restPlants = this.RestPlants;
			List<PlantType> currentPlants = this.CurrentPlants;
			int size2 = currentPlants._size;
			int num2 = (int)(thePlantType + 1);
			currentPlants._size = num2;
			this.laseFree = free;
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x001526C0 File Offset: 0x001508C0
		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x821900", Offset = "0x81FF00", VA = "0x180821900")]
		public void UpgradePlant(PlantType from, PlantType to)
		{
			int num3;
			do
			{
				this.upgrading = true;
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				int num = 0;
				bool flag;
				if (flag)
				{
					CreatePlant instance = CreatePlant.Instance;
				}
				if (num != 0)
				{
					goto IL_0064;
				}
				int num2 = 0;
				List<PlantType> list = new List();
				bool flag2;
				if (flag2)
				{
				}
				if (num2 != 0)
				{
					goto IL_006A;
				}
				num3 = 0;
				bool flag3;
				if (flag3)
				{
				}
			}
			while (num3 != 0);
			return;
			IL_0064:
			throw new NullReferenceException();
			IL_006A:
			throw new NullReferenceException();
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x00152740 File Offset: 0x00150940
		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x81D380", Offset = "0x81B980", VA = "0x18081D380")]
		public void LosePlant(Plant plant)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003FEF RID: 16367 RVA: 0x00152760 File Offset: 0x00150960
		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x81FA80", Offset = "0x81E080", VA = "0x18081FA80")]
		public void ReinforcePlant(Plant plant)
		{
			Dictionary<PlantType, Action<Plant>> dictionary = this.reinforceActions;
			bool flag;
			ulong num;
			if (!flag || num != (ulong)0L)
			{
			}
			float num2 = this.shieldHealth;
			int num3 = 0;
			if (num2 > (float)num3)
			{
				plant.GetShield(num2);
			}
			bool flag2 = this.uncrashable;
			plant.uncrashable = flag2;
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x001527AC File Offset: 0x001509AC
		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x81D800", Offset = "0x81BE00", VA = "0x18081D800")]
		public void RecordBuffChoice(PlantType plantType, string buffTitle)
		{
			if (!string.IsNullOrEmpty(buffTitle))
			{
				Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
				bool flag;
				if (!flag)
				{
					Dictionary<PlantType, Dictionary<string, int>> dictionary2 = this.plantBuffRecords;
					Dictionary<string, int> dictionary3 = new Dictionary();
				}
				Dictionary<PlantType, Dictionary<string, int>> dictionary4 = this.plantBuffRecords;
				Dictionary<string, int> dictionary5;
				if (!dictionary5.ContainsKey(buffTitle))
				{
					Dictionary<PlantType, Dictionary<string, int>> dictionary6 = this.plantBuffRecords;
					int num = 0;
					Dictionary<string, int> dictionary7;
					dictionary7[buffTitle] = num;
				}
				Dictionary<PlantType, Dictionary<string, int>> dictionary8 = this.plantBuffRecords;
				Dictionary<string, int> dictionary9;
				int num2 = dictionary9[buffTitle];
				int num3 = num2 + 1;
				dictionary9[buffTitle] = num3;
				Dictionary<PlantType, Dictionary<string, int>> dictionary10 = this.plantBuffRecords;
				Dictionary<string, int> dictionary11;
				int num4 = dictionary11[buffTitle];
				Debug.Log(string.Format("[BuffRecord] {0} 选择了词条 {1}，累计 {2} 次", num2, buffTitle, num4));
			}
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x00152858 File Offset: 0x00150A58
		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x81B8C0", Offset = "0x819EC0", VA = "0x18081B8C0")]
		public int GetBuffChoiceCount(PlantType plantType, string buffTitle)
		{
			Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, Dictionary<string, int>> dictionary2 = this.plantBuffRecords;
				Dictionary<string, int> dictionary3;
				if (dictionary3.ContainsKey(buffTitle))
				{
					Dictionary<PlantType, Dictionary<string, int>> dictionary4 = this.plantBuffRecords;
					Dictionary<string, int> dictionary5;
					return dictionary5[buffTitle];
				}
			}
			return 0;
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x0015289C File Offset: 0x00150A9C
		[Token(Token = "0x6003FF2")]
		[Address(RVA = "0x81FB40", Offset = "0x81E140", VA = "0x18081FB40")]
		private void ShowBuff()
		{
			UIResourcesLoader uimanager = GameAPP.UIManager;
			int num = 0;
			BaseMenu baseMenu = uimanager.Push((UIType)((uint)81), num != 0);
			int num2 = 0;
			MultipleChoiceMenu menu;
			if (baseMenu == 0)
			{
				menu = num2;
			}
			menu = baseMenu;
			MultipleChoiceMenu menu11 = menu;
			this.RegisterCoreBuff(menu11);
			MultipleChoiceMenu menu2 = menu;
			this.RegisterGetPlantBuff(menu2);
			MultipleChoiceMenu menu3 = menu;
			this.RegisterOtherBuff(menu3);
			MultipleChoiceMenu menu4 = menu;
			this.RegisterExpertBuff(menu4);
			if (menu.OptionCount == 0)
			{
				MultipleChoiceMenu menu5 = menu;
			}
			MultipleChoiceMenu menu6 = menu;
			int num3 = this.optionCount;
			int num4 = menu6.OptionCount;
			if (num3 < num4)
			{
				num4 = num3;
			}
			menu6.RegisterWindow(num4);
			MultipleChoiceMenu menu7 = menu;
			int num5 = 0;
			menu7.SetCancelable(num5 != 0, true);
			MultipleChoiceMenu menu8 = menu;
			int num6 = this.refreshCount;
			bool flag = this.refreshCount > 0;
			int num7 = 0;
			ulong num8;
			menu8.SetRefreshable(true, num6, num7 != 0, flag, num8 != 0UL);
			menu.<KeySelect>k__BackingField = true;
			MultipleChoiceMenu menu9 = menu;
			Action actionOnRefresh = menu9.actionOnRefresh;
			Action action = delegate
			{
				ShootingManager <>4__this = this;
				ShootingManager <>4__this2 = this;
				int num9 = <>4__this.refreshCount;
				<>4__this2.refreshCount = num9;
				menu.PopMenu();
				this.ShowBuff();
			};
			Delegate @delegate = Delegate.Combine(actionOnRefresh, action);
			if (@delegate == 0)
			{
				menu9.actionOnRefresh = num2;
			}
			if (@delegate != 0)
			{
				menu9.actionOnRefresh = @delegate;
				if (@delegate != 0)
				{
					MultipleChoiceMenu menu10 = menu;
					Action actionOnExit = menu10.actionOnExit;
					Action action2 = delegate
					{
						ShootingManager <>4__this3 = this;
						if (<>4__this3.laseFree)
						{
							<>4__this3.ShowBuff();
						}
						this.laseFree = false;
					};
					Delegate delegate2 = Delegate.Combine(actionOnExit, action2);
					if (delegate2 == 0)
					{
						menu10.actionOnExit = num2;
					}
					if (delegate2 != 0)
					{
						menu10.actionOnExit = delegate2;
						if (delegate2 != 0)
						{
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x00152A54 File Offset: 0x00150C54
		[Token(Token = "0x6003FF3")]
		[Address(RVA = "0x81DAB0", Offset = "0x81C0B0", VA = "0x18081DAB0")]
		private void RegisterCoreBuff(MultipleChoiceMenu menu)
		{
			ulong num3;
			do
			{
				int num = 0;
				List<PlantType> currentPlants = this.CurrentPlants;
				bool flag;
				if (flag)
				{
					if (!Config.configs.TryGetValue(num, num))
					{
						continue;
					}
					TypeCode typeCode = num.GetTypeCode();
					bool flag2;
					if (flag2)
					{
						ShootingManager.<>c__DisplayClass58_0 CS$<>8__locals1;
						CS$<>8__locals1.<>4__this = this;
						TypeCode typeCode2 = num.GetTypeCode();
						int i;
						sbyte b;
						while (i >= (int)b)
						{
						}
						TypeCode typeCode3 = num.GetTypeCode();
						bool flag3;
						if (flag3 && this.plantBuffRecords.TryGetValue(num, num))
						{
							Func<KeyValuePair<string, int>, bool> func;
							if (ShootingManager.<>c.<>9__58_0 == 0)
							{
								ShootingManager.<>c.<>9__58_0 = func;
							}
							if (Enumerable.Any<KeyValuePair<string, int>>(num, func))
							{
								continue;
							}
						}
						float value = global::UnityEngine.Random.value;
						CS$<>8__locals1.capturedPlant = (PlantType)num;
						TypeCode typeCode4 = num.GetTypeCode();
						CS$<>8__locals1.capturedBuffTitle = typeCode4;
						UnityAction unityAction;
						CS$<>8__locals1.originalOnGet = unityAction;
						if (i > 0)
						{
							bool flag4;
							string text = string.Format("{0}\n已选了{1}次", flag4, flag4);
						}
						Dictionary<PlantType, BaseConfig> configs = Config.configs;
						bool flag5;
						if (flag5)
						{
						}
						TypeCode typeCode5 = num.GetTypeCode();
						UnityAction unityAction2 = new UnityAction(CS$<>8__locals1.<RegisterCoreBuff>g__wrappedOnGet|1);
					}
					ulong num2;
					if (num2 != (ulong)0L)
					{
						goto IL_0122;
					}
				}
			}
			while (num3 != (ulong)0L);
			return;
			IL_0122:
			throw new NullReferenceException();
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00152B98 File Offset: 0x00150D98
		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x81E570", Offset = "0x81CB70", VA = "0x18081E570")]
		private void RegisterGetPlantBuff(MultipleChoiceMenu menu)
		{
			int num2;
			do
			{
				int num = 0;
				num2 = 0;
				if (this.maxPlantCount <= 0)
				{
					break;
				}
				List<PlantType> restPlants = this.RestPlants;
				bool flag;
				if (flag)
				{
					ShootingManager.<>c__DisplayClass59_0 CS$<>8__locals1;
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.plant = (PlantType)num;
					RogueShootingData shootingData = GameAPP.config.shootingData;
					RogueShootingData shootingData2 = GameAPP.config.shootingData;
					PlantType plant = CS$<>8__locals1.plant;
					List<DataRecord<PlantType>> plant2 = shootingData2.plant;
					int value = shootingData.GetValue<PlantType>(plant2, plant);
					RogueShootingData data = ShootingManager.Data;
					RogueShootingData data2 = ShootingManager.Data;
					PlantType plant3 = CS$<>8__locals1.plant;
					List<DataRecord<PlantType>> plant4 = data2.plant;
					int value2 = data.GetValue<PlantType>(plant4, plant3);
					string text = string.Format("获得新植物\n\n已使用该植物通关了{0}次", value2);
					Dictionary<PlantType, BaseConfig> configs = Config.configs;
					PlantType plant5 = CS$<>8__locals1.plant;
					if (configs.TryGetValue(plant5, num2))
					{
					}
					string name = global::Lawnf.GetName(CS$<>8__locals1.plant);
					UnityAction unityAction = delegate
					{
						ShootingManager <>4__this = CS$<>8__locals1.<>4__this;
						PlantType plant7 = CS$<>8__locals1.plant;
						<>4__this.GetNewPlant(plant7, true);
					};
					PlantType plant6 = CS$<>8__locals1.plant;
				}
			}
			while (num2 != 0);
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00152CD8 File Offset: 0x00150ED8
		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x81E9F0", Offset = "0x81CFF0", VA = "0x18081E9F0")]
		private void RegisterOtherBuff(MultipleChoiceMenu menu)
		{
			float value11 = global::UnityEngine.Random.value;
			float lucky = this._lucky;
			int num = 0;
			if (lucky > value11)
			{
				Quality randomQuality = this.GetRandomQuality();
				int num2 = (int)randomQuality;
				if ((this.superUpgrade ? 1 : 0) == num || randomQuality == Quality.diamond)
				{
				}
				if (num2 == 0 || num2 == 0 || num2 == 0 || num2 != 1)
				{
				}
				float lucky2 = this._lucky;
				string text = string.Format("幸运提高{0:F0}，幸运可以提高好词条出现概率\n当前幸运值：{1:F0}/250", randomQuality, randomQuality);
				UnityAction unityAction = delegate
				{
					ShootingManager <>4__this = this;
					float lucky3 = <>4__this._lucky;
					<>4__this._lucky = lucky3;
					Dictionary<Quality, float> dictionary = new Dictionary();
					float lucky4 = <>4__this._lucky;
					float lucky5 = <>4__this._lucky;
					float num11 = <>4__this._lucky * 3f;
					float lucky6 = <>4__this._lucky;
					<>4__this.qualityWeights = dictionary;
					throw new NullReferenceException();
				};
			}
			float value2 = global::UnityEngine.Random.value;
			string text2;
			UnityAction unityAction2;
			if (this._lucky > value2)
			{
				Quality randomQuality2 = this.GetRandomQuality();
				int num3 = (int)randomQuality2;
				if (((this.superUpgrade ? 1 : 0) != num && randomQuality2 == Quality.diamond) || num3 == 0 || num3 == 0 || num3 == 0 || num3 != 1)
				{
				}
				TravelMgr instance = TravelMgr.Instance;
				float value;
				float value3 = value;
				float damageAmplification = instance.damageAmplification;
				text2 = string.Format("全体植物获得{0:F0}%伤害增幅\n当前增幅：{1:F0}%", instance, instance);
				unityAction2 = delegate
				{
					TravelMgr instance2 = TravelMgr.Instance;
					float damageAmplification2 = instance2.damageAmplification;
					instance2.damageAmplification = damageAmplification2;
				};
			}
			float value4 = global::UnityEngine.Random.value;
			string text3;
			UnityAction unityAction3;
			if (this._lucky > value4)
			{
				int num4 = 0;
				ShootingManager.<>c__DisplayClass60_2 CS$<>8__locals3;
				CS$<>8__locals3.FieldGetter(num4, text2, unityAction2);
				CS$<>8__locals3.<>4__this = this;
				Quality randomQuality3 = this.GetRandomQuality();
				int num5 = (int)randomQuality3;
				if (randomQuality3 == Quality.Default || randomQuality3 == Quality.Default || randomQuality3 == Quality.Default || num5 != 1)
				{
				}
				uint num6;
				CS$<>8__locals3.value = (int)num6;
				int num7;
				text3 = string.Format("获得{0}次词条刷新的机会", num7);
				unityAction3 = delegate
				{
					int num12 = CS$<>8__locals3.<>4__this.refreshCount;
					CS$<>8__locals3.<>4__this.refreshCount = num12;
				};
			}
			float value5 = global::UnityEngine.Random.value;
			if (this._lucky > value5)
			{
				int num8 = 0;
				ShootingManager.<>c__DisplayClass60_3 CS$<>8__locals4;
				CS$<>8__locals4.FieldGetter(num8, text3, unityAction3);
				CS$<>8__locals4.<>4__this = this;
				Quality randomQuality4 = this.GetRandomQuality();
				int num9 = (int)randomQuality4;
				if (randomQuality4 == Quality.Default || randomQuality4 == Quality.Default || randomQuality4 == Quality.Default || num9 != 1)
				{
				}
				CS$<>8__locals4.value = value5;
				float num10 = value5 * 10f;
				CS$<>8__locals4.value = num10;
				float value6 = CS$<>8__locals4.value;
				UnityAction unityAction4 = delegate
				{
					List<Plant> allPlants = global::Lawnf.GetAllPlants();
					Action<Plant> <>9__ = CS$<>8__locals4.<>9__7;
					if (<>9__ == 0)
					{
						Action<Plant> action;
						CS$<>8__locals4.<>9__7 = action;
					}
					global::Core.Lawnf.Foreach<Plant>(allPlants, <>9__);
					ShootingManager <>4__this2 = CS$<>8__locals4.<>4__this;
					float num13 = <>4__this2.shieldHealth;
					<>4__this2.shieldHealth = num13;
				};
			}
			float value7 = global::UnityEngine.Random.value;
			if (this._lucky > value7)
			{
				if ((this.superUpgrade ? 1 : 0) == num)
				{
					Quality randomQuality5 = this.GetRandomQuality();
					UnityAction unityAction7;
					if (randomQuality5 != Quality.Default)
					{
						UnityAction unityAction6;
						if (randomQuality5 != Quality.Default)
						{
							UnityAction unityAction5;
							if (randomQuality5 != Quality.Default)
							{
								if (randomQuality5 != Quality.silver)
								{
									goto IL_02B7;
								}
								string text4 = string.Format("复活时间降低50%\n当前复活时长：{0:F1}秒", randomQuality5);
								unityAction5 = delegate
								{
									float num14 = this.reviveTimer * 0.5f;
									this.reviveTimer = num14;
								};
							}
							string text5 = string.Format("复活时间降低30%\n当前复活时长：{0:F1}秒", unityAction5);
							unityAction6 = delegate
							{
								float num15 = this.reviveTimer * 0.7f;
								this.reviveTimer = num15;
							};
						}
						string text6 = string.Format("复活时间降低20%\n当前复活时长：{0:F1}秒", unityAction6);
						unityAction7 = delegate
						{
							float num16 = this.reviveTimer * 0.8f;
							this.reviveTimer = num16;
						};
					}
					string text7 = string.Format("复活时间降低10%\n当前复活时长：{0:F1}秒", unityAction7);
					UnityAction unityAction8 = delegate
					{
						float num17 = this.reviveTimer * 0.9f;
						this.reviveTimer = num17;
					};
				}
				UnityAction unityAction9 = delegate
				{
					this.reviveTimer = 1f;
				};
			}
			IL_02B7:
			float value8 = global::UnityEngine.Random.value;
			if (this._lucky > value8 && (this.uncrashable ? 1 : 0) == num)
			{
				UnityAction unityAction10 = delegate
				{
					List<Plant> allPlants2 = global::Lawnf.GetAllPlants();
					Action<Plant> <>9__60_ = ShootingManager.<>c.<>9__60_12;
					if (<>9__60_ == 0)
					{
						Action<Plant> action2;
						ShootingManager.<>c.<>9__60_12 = action2;
					}
					global::Core.Lawnf.Foreach<Plant>(allPlants2, <>9__60_);
					this.uncrashable = true;
				};
			}
			float value9 = global::UnityEngine.Random.value;
			bool flag;
			if (this._lucky > value9 && !flag && ShootingManager.<>c.<>9__60_2 == 0)
			{
				ShootingManager.<>c.<>9__60_2 = delegate
				{
					TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)13000));
				};
			}
			float value10 = global::UnityEngine.Random.value;
			if (typeof(ShootingManager.<>c).TypeHandle != 0)
			{
				if (typeof(ShootingManager.<>c).TypeHandle != 0)
				{
					if (typeof(ShootingManager.<>c).TypeHandle == (ulong)1L)
					{
						string text9;
						string text10;
						string text11;
						string text8 = string.Concat(new string[] { "获得词条：力量会给予希望\n获得植物：", text9, "\n获得植物：", text10, "\n", text11, "获得600%攻击力加成" });
						UnityAction unityAction11 = delegate
						{
							TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)3005));
							int num18 = 0;
							this.GetNewPlant((PlantType)((uint)969), num18 != 0);
							int num19 = 0;
							this.GetNewPlant((PlantType)((uint)953), num19 != 0);
							TravelMgr.Instance.data.AddDamage((PlantType)((uint)969), 6f);
							TravelMgr.Instance.data.AddDamage((PlantType)((uint)953), 6f);
						};
					}
					return;
				}
				UnityAction unityAction12 = delegate
				{
					this.superUpgrade = true;
				};
			}
			if (ShootingManager.<>c.<>9__60_13 == 0)
			{
				ShootingManager.<>c.<>9__60_13 = delegate
				{
					TravelMgr.Instance.GetNormalBuff((AdvBuff)((uint)2007));
				};
			}
			throw new NullReferenceException();
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x001530CC File Offset: 0x001512CC
		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x81E320", Offset = "0x81C920", VA = "0x18081E320")]
		private void RegisterExpertBuff(MultipleChoiceMenu menu)
		{
			float value = global::UnityEngine.Random.value;
			float lucky = this._lucky;
			int num = 0;
			float num2 = lucky * 0.3f * 0.01f;
			if (num != 0)
			{
				List<PlantType> expertPlants = this.ExpertPlants;
				Func<PlantType, bool> func = delegate(PlantType p)
				{
					List<PlantType> yourPlants = this.YourPlants;
					bool flag;
					return flag;
				};
				List<PlantType> list = Enumerable.ToList<PlantType>(Enumerable.Where<PlantType>(expertPlants, func));
				PlantType random = ListExtensions.GetRandom<PlantType>(list);
				PlantType plantType = random;
				string text2;
				string text = "获得新植物：" + text2;
				UnityAction unityAction = delegate
				{
					ShootingManager <>4__this = this;
					PlantType plantType2 = plantType;
					int num3 = 0;
					<>4__this.GetNewPlant(plantType2, num3 != 0);
				};
				PlantType plantType3 = plantType;
			}
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00153178 File Offset: 0x00151378
		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x81D450", Offset = "0x81BA50", VA = "0x18081D450")]
		[ContextMenu("打印词条记录")]
		public void PrintBuffRecords()
		{
			int num;
			do
			{
				Debug.Log("=== 植物词条选择记录 ===");
				Dictionary<PlantType, Dictionary<string, int>> dictionary = this.plantBuffRecords;
				num = 0;
				bool flag;
				if (flag)
				{
					string text = string.Format("植物: {0}", flag);
					Debug.Log(text);
					bool flag2;
					if (flag2)
					{
						string text2;
						Debug.Log(text2);
					}
					if (num != 0)
					{
						goto IL_004E;
					}
				}
			}
			while (num != 0);
			return;
			IL_004E:
			throw new NullReferenceException();
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x001531DC File Offset: 0x001513DC
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x821560", Offset = "0x81FB60", VA = "0x180821560")]
		private void Update()
		{
			List<Plant> allPlants = global::Lawnf.GetAllPlants();
			if (allPlants != 0 && this.canTab)
			{
				Plant plant = Enumerable.FirstOrDefault<Plant>(allPlants);
				List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
				Func<Zombie, bool> <>9__63_ = ShootingManager.<>c.<>9__63_0;
				if (<>9__63_ == 0)
				{
					Func<Zombie, bool> func;
					ShootingManager.<>c.<>9__63_0 = func;
				}
				IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(allZombies, <>9__63_);
				Func<Zombie, float> func2;
				if (ShootingManager.<>c.<>9__63_1 == 0)
				{
					ShootingManager.<>c.<>9__63_1 = func2;
				}
				Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(enumerable, func2));
				int num = 0;
				if (zombie != num)
				{
					int theZombieRow = zombie.theZombieRow;
					if (plant.thePlantRow != theZombieRow)
					{
						CreatePlant instance = CreatePlant.Instance;
					}
				}
			}
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00153284 File Offset: 0x00151484
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x81BE00", Offset = "0x81A400", VA = "0x18081BE00")]
		public static ZombieType GetZombieType(int wave, int waveToAdd = 5)
		{
			for (;;)
			{
				ShootingManager instance = ShootingManager.Instance;
				int num = 0;
				bool flag = instance != num;
				if (flag)
				{
					ShootingManager instance2 = ShootingManager.Instance;
				}
				flag += flag;
				long num2 = (long)(waveToAdd * (int)((uint)7));
				num2 += num2;
				long num3 = (long)(waveToAdd * (int)((uint)11));
				long num4 = (long)(waveToAdd * (int)((uint)13));
				long num5 = (long)(waveToAdd * (int)((uint)14));
				long num6 = (long)(waveToAdd * (int)((uint)15));
				long num7 = (long)(waveToAdd * (int)((uint)17));
				num7 += num7;
				long num8 = (long)(waveToAdd * (int)((uint)19));
				List<ZombieType> list = new List();
				int size = list._size;
				list._size = list;
				int size2 = list._size;
				list._size = list;
				int size3 = list._size;
				list._size = list;
				List<ZombieType> list2 = new List();
				int size4 = list2._size;
				list2._size = list2;
				uint num9;
				if (ShootingManager.randomType == (RandomZombieType)num9)
				{
					List<RandomZombieType> list3 = Enumerable.ToList<RandomZombieType>(global::Core.Lawnf.GetEnumValues<RandomZombieType>());
					RandomZombieType randomZombieType = ShootingManager.randomType;
					bool flag2 = list3.Remove(randomZombieType);
					int num10 = ListExtensions.GetRandom<RandomZombieType>(list3) - RandomZombieType.Machine;
					if (num10 != 0)
					{
						if (num10 == 0)
						{
							goto IL_010D;
						}
						if (num10 == 1)
						{
							break;
						}
					}
				}
			}
			return ZombieType.NormalZombie;
			IL_010D:
			return ZombieType.NormalZombie;
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x001533A8 File Offset: 0x001515A8
		[Token(Token = "0x6003FFA")]
		[Address(RVA = "0x821E30", Offset = "0x820430", VA = "0x180821E30")]
		public ShootingManager()
		{
			List<TravelDebuff> list = new List();
			this.selectedDebuffs = list;
			this.reviveTimer = 3000f;
			Dictionary<Quality, float> dictionary = new Dictionary();
			this.qualityWeights = dictionary;
			Dictionary<PlantType, Dictionary<string, int>> dictionary2 = new Dictionary();
			this.plantBuffRecords = dictionary2;
			Dictionary<PlantType, Action<Plant>> dictionary3 = new Dictionary();
			this.reinforceActions = dictionary3;
			Dictionary<PlantType, PlantType> dictionary4 = new Dictionary();
			this.revivingPlants = dictionary4;
			List<ZombieType> list2 = new List();
			int size = list2._size;
			int size2 = list2._size;
			int size3 = list2._size;
			int size4 = list2._size;
			int size5 = list2._size;
			int size6 = list2._size;
			int size7 = list2._size;
			this.zombieTypes1 = list2;
			List<ZombieType> list3 = new List();
			int size8 = list3._size;
			int size9 = list3._size;
			int size10 = list3._size;
			int size11 = list3._size;
			int size12 = list3._size;
			int size13 = list3._size;
			this.zombieTypes2 = list3;
			List<ZombieType> list4 = new List();
			int size14 = list4._size;
			int size15 = list4._size;
			int size16 = list4._size;
			int size17 = list4._size;
			int size18 = list4._size;
			int size19 = list4._size;
			this.leaders = list4;
			List<PlantType> list5 = new List();
			this.YourPlants = list5;
			List<PlantType> list6 = new List();
			this.CurrentPlants = list6;
			List<PlantType> list7 = new List();
			this.RestPlants = list7;
			List<PlantType> list8 = new List();
			int size20 = list8._size;
			int size21 = list8._size;
			int size22 = list8._size;
			int size23 = list8._size;
			int size24 = list8._size;
			int size25 = list8._size;
			int size26 = list8._size;
			int size27 = list8._size;
			int size28 = list8._size;
			int size29 = list8._size;
			int size30 = list8._size;
			int size31 = list8._size;
			int size32 = list8._size;
			int size33 = list8._size;
			int size34 = list8._size;
			int size35 = list8._size;
			int size36 = list8._size;
			int size37 = list8._size;
			this.AllPlants = list8;
			List<PlantType> list9 = new List();
			int size38 = list9._size;
			int size39 = list9._size;
			this.ExpertPlants = list9;
			base..ctor();
		}

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		public static ShootingManager Instance;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		private static RandomZombieType randomType;

		// Token: 0x04003084 RID: 12420
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003084")]
		public Board board;

		// Token: 0x04003085 RID: 12421
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4003085")]
		public int refreshCount;

		// Token: 0x04003086 RID: 12422
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4003086")]
		public int maxPlantCount = (int)((ulong)1L);

		// Token: 0x04003087 RID: 12423
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4003087")]
		public int currentPlantCount;

		// Token: 0x04003088 RID: 12424
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4003088")]
		public int stage = (int)((ulong)1L);

		// Token: 0x04003089 RID: 12425
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4003089")]
		public int maxStage = (int)((ulong)1L);

		// Token: 0x0400308A RID: 12426
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400308A")]
		public int optionCount = (int)((ulong)5L);

		// Token: 0x0400308B RID: 12427
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400308B")]
		public int difficulty;

		// Token: 0x0400308C RID: 12428
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400308C")]
		public readonly List<TravelDebuff> selectedDebuffs;

		// Token: 0x0400308D RID: 12429
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400308D")]
		public bool endless;

		// Token: 0x0400308E RID: 12430
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x51")]
		[Token(Token = "0x400308E")]
		public bool superUpgrade;

		// Token: 0x0400308F RID: 12431
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x52")]
		[Token(Token = "0x400308F")]
		public bool cheatHard;

		// Token: 0x04003090 RID: 12432
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4003090")]
		private float reviveTimer;

		// Token: 0x04003091 RID: 12433
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4003091")]
		private bool upgrading;

		// Token: 0x04003092 RID: 12434
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4003092")]
		private bool uncrashable;

		// Token: 0x04003093 RID: 12435
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
		[Token(Token = "0x4003093")]
		private bool canTab;

		// Token: 0x04003094 RID: 12436
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4003094")]
		private float shieldHealth;

		// Token: 0x04003095 RID: 12437
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4003095")]
		[SerializeField]
		private float _lucky;

		// Token: 0x04003096 RID: 12438
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4003096")]
		private Dictionary<Quality, float> qualityWeights;

		// Token: 0x04003097 RID: 12439
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4003097")]
		public readonly Dictionary<PlantType, Dictionary<string, int>> plantBuffRecords;

		// Token: 0x04003098 RID: 12440
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003098")]
		private readonly Dictionary<PlantType, Action<Plant>> reinforceActions;

		// Token: 0x04003099 RID: 12441
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4003099")]
		private readonly Dictionary<PlantType, PlantType> revivingPlants;

		// Token: 0x0400309A RID: 12442
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400309A")]
		public List<ZombieType> zombieTypes1;

		// Token: 0x0400309B RID: 12443
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400309B")]
		public List<ZombieType> zombieTypes2;

		// Token: 0x0400309C RID: 12444
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400309C")]
		public List<ZombieType> leaders;

		// Token: 0x0400309D RID: 12445
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400309D")]
		private bool laseFree;

		// Token: 0x0400309E RID: 12446
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400309E")]
		public List<PlantType> YourPlants;

		// Token: 0x0400309F RID: 12447
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400309F")]
		public List<PlantType> CurrentPlants;

		// Token: 0x040030A0 RID: 12448
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40030A0")]
		public List<PlantType> RestPlants;

		// Token: 0x040030A1 RID: 12449
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40030A1")]
		public List<PlantType> AllPlants;

		// Token: 0x040030A2 RID: 12450
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40030A2")]
		public List<PlantType> ExpertPlants;
	}
}
