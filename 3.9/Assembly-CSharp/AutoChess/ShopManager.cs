using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public class ShopManager : MonoBehaviour
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x001306C0 File Offset: 0x0012E8C0
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x001306D4 File Offset: 0x0012E8D4
		[Token(Token = "0x170003D4")]
		public static ShopManager Instance
		{
			[Token(Token = "0x60039CC")]
			[Address(RVA = "0x7DEFD0", Offset = "0x7DD5D0", VA = "0x1807DEFD0")]
			get;
			[Token(Token = "0x60039CD")]
			[Address(RVA = "0x7DF0D0", Offset = "0x7DD6D0", VA = "0x1807DF0D0")]
			private set;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x001306E8 File Offset: 0x0012E8E8
		[Token(Token = "0x170003D5")]
		public IReadOnlyList<PlantData> CurrentShopPlants
		{
			[Token(Token = "0x60039CE")]
			[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920")]
			get
			{
				List<PlantData> list = this.currentShopPlants;
				return null;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x00130708 File Offset: 0x0012E908
		[Token(Token = "0x170003D6")]
		public int RefreshCost
		{
			[Token(Token = "0x60039CF")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0")]
			get
			{
				return 2;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x00130718 File Offset: 0x0012E918
		[Token(Token = "0x170003D7")]
		public int ShopSize
		{
			[Token(Token = "0x60039D0")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00")]
			get
			{
				return 5;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x00130728 File Offset: 0x0012E928
		[Token(Token = "0x170003D8")]
		public int RerollCountThisRound
		{
			[Token(Token = "0x60039D1")]
			[Address(RVA = "0x590B00", Offset = "0x58F100", VA = "0x180590B00")]
			get
			{
				return this.rerollCountThisRound;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0013073C File Offset: 0x0012E93C
		[Token(Token = "0x170003D9")]
		public int ExpCost
		{
			[Token(Token = "0x60039D2")]
			[Address(RVA = "0x7DEF80", Offset = "0x7DD580", VA = "0x1807DEF80")]
			get
			{
				return 4;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x00130750 File Offset: 0x0012E950
		// (set) Token: 0x060039D4 RID: 14804 RVA: 0x00130764 File Offset: 0x0012E964
		[Token(Token = "0x170003DA")]
		public bool IsShopLocked
		{
			[Token(Token = "0x60039D3")]
			[Address(RVA = "0x7DF010", Offset = "0x7DD610", VA = "0x1807DF010")]
			get
			{
				return this.isShopLocked;
			}
			[Token(Token = "0x60039D4")]
			[Address(RVA = "0x7DF130", Offset = "0x7DD730", VA = "0x1807DF130")]
			set
			{
				int num;
				do
				{
					num = 0;
					this.isShopLocked = value;
					List<CardUI> cards = InGameUI.Instance.Cards;
					Func<CardUI, bool> <>9__23_ = ShopManager.<>c.<>9__23_0;
					if (<>9__23_ == 0)
					{
						ShopManager.<>c.<>9__23_0 = delegate(CardUI a)
						{
							int num2 = 0;
							if (a != 0)
							{
							}
							return num2 == 0;
						};
					}
					if (Enumerable.Where<CardUI>(cards, <>9__23_) != 0)
					{
						if (num < typeof(IEnumerator).TypeHandle)
						{
							num += num;
							if (num != typeof(IEnumerator).TypeHandle)
							{
								num++;
							}
						}
						num += 312;
					}
					if ("{il2cpp array field local12->}" != (ulong)0L)
					{
					}
				}
				while (num != 0);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060039D5 RID: 14805 RVA: 0x001307F0 File Offset: 0x0012E9F0
		// (remove) Token: 0x060039D6 RID: 14806 RVA: 0x00130820 File Offset: 0x0012EA20
		[Token(Token = "0x1400000E")]
		public event Action<List<PlantData>> OnShopRefreshed
		{
			[Token(Token = "0x60039D5")]
			[Address(RVA = "0x7DEED0", Offset = "0x7DD4D0", VA = "0x1807DEED0")]
			[CompilerGenerated]
			add
			{
				Action<List<PlantData>> onShopRefreshed = this.OnShopRefreshed;
				Delegate @delegate = Delegate.Combine(onShopRefreshed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onShopRefreshed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60039D6")]
			[Address(RVA = "0x7DF020", Offset = "0x7DD620", VA = "0x1807DF020")]
			[CompilerGenerated]
			remove
			{
				Action<List<PlantData>> onShopRefreshed = this.OnShopRefreshed;
				Delegate @delegate = Delegate.Remove(onShopRefreshed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onShopRefreshed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060039D7 RID: 14807 RVA: 0x00130850 File Offset: 0x0012EA50
		[Token(Token = "0x60039D7")]
		[Address(RVA = "0x7DCA90", Offset = "0x7DB090", VA = "0x1807DCA90")]
		private void Awake()
		{
			ShopManager.<Instance>k__BackingField = this;
			List<PlantData> list = new List();
			this.currentShopPlants = list;
			this.rerollCountThisRound = (int)((ulong)0L);
			this.isShopLocked = false;
			this.InitializePlantPools();
			int num = 0;
			this.RefreshShopInternal(num != 0);
			Debug.Log("[ShopManager] 商店系统初始化完成");
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x0013089C File Offset: 0x0012EA9C
		[Token(Token = "0x60039D8")]
		[Address(RVA = "0x7DD7D0", Offset = "0x7DBDD0", VA = "0x1807DD7D0")]
		private void InitializeShop()
		{
			List<PlantData> list = new List();
			this.currentShopPlants = list;
			this.rerollCountThisRound = (int)((ulong)0L);
			this.isShopLocked = false;
			this.InitializePlantPools();
			int num = 0;
			this.RefreshShopInternal(num != 0);
			Debug.Log("[ShopManager] 商店系统初始化完成");
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x001308E0 File Offset: 0x0012EAE0
		[Token(Token = "0x60039D9")]
		[Address(RVA = "0x7DD4C0", Offset = "0x7DBAC0", VA = "0x1807DD4C0")]
		private void InitializePlantPools()
		{
			ulong num;
			do
			{
				Dictionary<int, List<PlantData>> dictionary = new Dictionary();
				this.plantPoolsByCost = dictionary;
				Dictionary<int, List<PlantData>> dictionary2 = this.plantPoolsByCost;
				List<PlantData> list = new List();
				dictionary2[1] = list;
				while (1UL <= (ulong)5L)
				{
				}
				this.LoadAllPlantsFromCode();
				Debug.Log("[ShopManager] 植物池初始化完成:");
				Dictionary<int, List<PlantData>> dictionary3 = this.plantPoolsByCost;
				bool flag;
				if (flag)
				{
					Debug.Log(string.Format("  {0}费植物: {1}个", flag, flag));
				}
			}
			while (num != (ulong)0L);
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x0013095C File Offset: 0x0012EB5C
		[Token(Token = "0x60039DA")]
		[Address(RVA = "0x7DD8A0", Offset = "0x7DBEA0", VA = "0x1807DD8A0")]
		private void LoadAllPlantsFromCode()
		{
			WallNut wallNut = new WallNut();
			this.AddPlantToPool(wallNut);
			ElectricOnion electricOnion = new ElectricOnion();
			this.AddPlantToPool(electricOnion);
			Melonpult melonpult = new Melonpult();
			this.AddPlantToPool(melonpult);
			Garlic garlic = new Garlic();
			this.AddPlantToPool(garlic);
			Cactus cactus = new Cactus();
			this.AddPlantToPool(cactus);
			Marigold marigold = new Marigold();
			this.AddPlantToPool(marigold);
			Plantern plantern = new Plantern();
			this.AddPlantToPool(plantern);
			StarFruit starFruit = new StarFruit();
			this.AddPlantToPool(starFruit);
			Sunflower sunflower = new Sunflower();
			this.AddPlantToPool(sunflower);
			ThreePeater threePeater = new ThreePeater();
			this.AddPlantToPool(threePeater);
			TorchWood torchWood = new TorchWood();
			this.AddPlantToPool(torchWood);
			GoldMelon goldMelon = new GoldMelon();
			this.AddPlantToPool(goldMelon);
			Cornpult cornpult = new Cornpult();
			this.AddPlantToPool(cornpult);
			Chomper chomper = new Chomper();
			this.AddPlantToPool(chomper);
			Garlicfume garlicfume = new Garlicfume();
			this.AddPlantToPool(garlicfume);
			JalaCaltrop jalaCaltrop = new JalaCaltrop();
			this.AddPlantToPool(jalaCaltrop);
			NutChomper nutChomper = new NutChomper();
			this.AddPlantToPool(nutChomper);
			PeaFume peaFume = new PeaFume();
			this.AddPlantToPool(peaFume);
			GoldCabbage goldCabbage = new GoldCabbage();
			this.AddPlantToPool(goldCabbage);
			SnowPeaShooter snowPeaShooter = new SnowPeaShooter();
			this.AddPlantToPool(snowPeaShooter);
			StarNut starNut = new StarNut();
			this.AddPlantToPool(starNut);
			EndoFlame endoFlame = new EndoFlame();
			this.AddPlantToPool(endoFlame);
			CobCannon cobCannon = new CobCannon();
			this.AddPlantToPool(cobCannon);
			MelonNut melonNut = new MelonNut();
			this.AddPlantToPool(melonNut);
			ObsidianJalapeno obsidianJalapeno = new ObsidianJalapeno();
			this.AddPlantToPool(obsidianJalapeno);
			LanternPumpkin lanternPumpkin = new LanternPumpkin();
			this.AddPlantToPool(lanternPumpkin);
			ThreeMine threeMine = new ThreeMine();
			this.AddPlantToPool(threeMine);
			IceScaredy iceScaredy = new IceScaredy();
			this.AddPlantToPool(iceScaredy);
			GoldCorn goldCorn = new GoldCorn();
			this.AddPlantToPool(goldCorn);
			SuperChomper superChomper = new SuperChomper();
			this.AddPlantToPool(superChomper);
			LanternUmbrella lanternUmbrella = new LanternUmbrella();
			this.AddPlantToPool(lanternUmbrella);
			JackboxStar jackboxStar = new JackboxStar();
			this.AddPlantToPool(jackboxStar);
			DoomPeashooter doomPeashooter = new DoomPeashooter();
			this.AddPlantToPool(doomPeashooter);
			CattailPlant cattailPlant = new CattailPlant();
			this.AddPlantToPool(cattailPlant);
			IceGloom iceGloom = new IceGloom();
			this.AddPlantToPool(iceGloom);
			GoldMagnet goldMagnet = new GoldMagnet();
			this.AddPlantToPool(goldMagnet);
			SuperCherryShooter superCherryShooter = new SuperCherryShooter();
			this.AddPlantToPool(superCherryShooter);
			ChomperPumpkin chomperPumpkin = new ChomperPumpkin();
			this.AddPlantToPool(chomperPumpkin);
			UltimateSpruce ultimateSpruce = new UltimateSpruce();
			this.AddPlantToPool(ultimateSpruce);
			LaserUmbrella laserUmbrella = new LaserUmbrella();
			this.AddPlantToPool(laserUmbrella);
			UltimateJalapeno ultimateJalapeno = new UltimateJalapeno();
			this.AddPlantToPool(ultimateJalapeno);
			SuperSnowGatling superSnowGatling = new SuperSnowGatling();
			this.AddPlantToPool(superSnowGatling);
			UltimateStar ultimateStar = new UltimateStar();
			this.AddPlantToPool(ultimateStar);
			UltimateHelmetGatling ultimateHelmetGatling = new UltimateHelmetGatling();
			this.AddPlantToPool(ultimateHelmetGatling);
			UltimateSunflower ultimateSunflower = new UltimateSunflower();
			this.AddPlantToPool(ultimateSunflower);
			UltimateBigGatling ultimateBigGatling = new UltimateBigGatling();
			this.AddPlantToPool(ultimateBigGatling);
			GarlicSniper garlicSniper = new GarlicSniper();
			this.AddPlantToPool(garlicSniper);
			UltimateBigSniper ultimateBigSniper = new UltimateBigSniper();
			this.AddPlantToPool(ultimateBigSniper);
			UltimateBigChomper ultimateBigChomper = new UltimateBigChomper();
			this.AddPlantToPool(ultimateBigChomper);
			EmeraldUmbrella emeraldUmbrella = new EmeraldUmbrella();
			this.AddPlantToPool(emeraldUmbrella);
			EndoFlameGirl endoFlameGirl = new EndoFlameGirl();
			this.AddPlantToPool(endoFlameGirl);
			UltimateCorn ultimateCorn = new UltimateCorn();
			this.AddPlantToPool(ultimateCorn);
			UltimateChomper ultimateChomper = new UltimateChomper();
			this.AddPlantToPool(ultimateChomper);
			CattailLour cattailLour = new CattailLour();
			this.AddPlantToPool(cattailLour);
			BambooDragon bambooDragon = new BambooDragon();
			this.AddPlantToPool(bambooDragon);
			SuperMachineNut superMachineNut = new SuperMachineNut();
			this.AddPlantToPool(superMachineNut);
			UltimateMelon ultimateMelon = new UltimateMelon();
			this.AddPlantToPool(ultimateMelon);
			UltimateLanternSplit ultimateLanternSplit = new UltimateLanternSplit();
			this.AddPlantToPool(ultimateLanternSplit);
			UltimateCannon ultimateCannon = new UltimateCannon();
			this.AddPlantToPool(ultimateCannon);
			UltimateExplodeCannon ultimateExplodeCannon = new UltimateExplodeCannon();
			this.AddPlantToPool(ultimateExplodeCannon);
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00130CE8 File Offset: 0x0012EEE8
		[Token(Token = "0x60039DB")]
		[Address(RVA = "0x7DC940", Offset = "0x7DAF40", VA = "0x1807DC940")]
		private void AddPlantToPool(PlantData plant)
		{
			int cost = plant.Cost;
			if (cost - 1 > 4)
			{
				string title = plant.Title;
				Debug.LogWarning(string.Format("[ShopManager] 植物费用异常: {0} - {1}费", title, title));
				return;
			}
			List<PlantData> list = this.plantPoolsByCost[cost];
			throw new NullReferenceException();
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00130D30 File Offset: 0x0012EF30
		[Token(Token = "0x60039DC")]
		[Address(RVA = "0x7DECC0", Offset = "0x7DD2C0", VA = "0x1807DECC0")]
		public void RefreshShop()
		{
			int num = 0;
			this.RefreshShopInternal(num != 0);
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x00130D48 File Offset: 0x0012EF48
		[Token(Token = "0x60039DD")]
		[Address(RVA = "0x7DECD0", Offset = "0x7DD2D0", VA = "0x1807DECD0")]
		public bool RerollShop()
		{
			if (this.rerollCountThisRound < 999 && EconomyManager.<Instance>k__BackingField.SpendGold(2))
			{
				this.RefreshShopInternal(true);
				return true;
			}
			int num;
			Debug.LogWarning(string.Format("[ShopManager] 本回合刷新次数已达上限: {0}", num));
			throw new NullReferenceException();
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00130D94 File Offset: 0x0012EF94
		[Token(Token = "0x60039DE")]
		[Address(RVA = "0x7DE8F0", Offset = "0x7DCEF0", VA = "0x1807DE8F0")]
		private void RefreshShopInternal(bool isPaid)
		{
			if (!this.isShopLocked)
			{
				List<PlantData> list = this.currentShopPlants;
				int size = list._size;
				int num = 0;
				list._size = num;
				if (size > 0)
				{
				}
				int currentLevel = EconomyManager.<Instance>k__BackingField.currentLevel;
				if (this.GenerateRandomPlant(currentLevel) != 0)
				{
					List<PlantData> list2 = this.currentShopPlants;
				}
				num++;
				if (isPaid)
				{
				}
				if (this.OnShopRefreshed != 0)
				{
					List<PlantData> list3 = new List(this.currentShopPlants);
				}
				if (isPaid)
				{
					int num2 = this.rerollCountThisRound;
					int num3;
					string text = string.Format("(-{0}金币, 第{1}次刷新)", num3, num3);
				}
				Debug.Log("[ShopManager] 商店刷新完成 " + "(免费刷新)");
				List<PlantData> list4 = this.currentShopPlants;
				string title = this.currentShopPlants[num].Title;
				int cost = this.currentShopPlants[num].Cost;
				int num4;
				Debug.Log(string.Format("  [{0}] {1} - {2}费", num4, title, cost));
				List<PlantData> list5 = this.currentShopPlants;
				num++;
			}
			Debug.Log("[ShopManager] 商店已锁定，跳过刷新");
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00130E98 File Offset: 0x0012F098
		[Token(Token = "0x60039DF")]
		[Address(RVA = "0x7DCC10", Offset = "0x7DB210", VA = "0x1807DCC10")]
		private PlantData GenerateRandomPlant(int playerLevel)
		{
			Dictionary<int, float> costProbabilities = this.GetCostProbabilities(playerLevel);
			int num = 0;
			int num2 = 0;
			float num3 = global::UnityEngine.Random.Range((float)num, 1f);
			if (costProbabilities.ContainsKey(1))
			{
				float num4 = costProbabilities[1];
				if (num2 >= (int)num3)
				{
					goto IL_0035;
				}
			}
			while (1UL <= (ulong)5L)
			{
			}
			IL_0035:
			PlantData plantData;
			if (this.plantPoolsByCost.ContainsKey(5))
			{
				List<PlantData> list = this.plantPoolsByCost[5];
				List<PlantData> list2 = this.plantPoolsByCost[5];
				int num5 = list2._size;
				num5 = global::UnityEngine.Random.Range(0, num5);
				plantData = list2[num5];
				return plantData;
			}
			Debug.LogWarning(string.Format("[ShopManager] 无法生成{0}费植物，池子为空", plantData));
			throw new NullReferenceException();
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00130F40 File Offset: 0x0012F140
		[Token(Token = "0x60039E0")]
		[Address(RVA = "0x7DCE40", Offset = "0x7DB440", VA = "0x1807DCE40")]
		private Dictionary<int, float> GetCostProbabilities(int playerLevel)
		{
			Dictionary<int, float> dictionary = new Dictionary();
			if (playerLevel - 1 <= 9)
			{
				int num = playerLevel - 1;
			}
			return dictionary;
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00130F70 File Offset: 0x0012F170
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x7DEE00", Offset = "0x7DD400", VA = "0x1807DEE00")]
		private int SelectCostByProbability(Dictionary<int, float> probabilities)
		{
			int num = 0;
			int num2 = 0;
			float num3 = global::UnityEngine.Random.Range((float)num, 1f);
			if (probabilities.ContainsKey(1))
			{
				float num4 = probabilities[1];
				if (num2 >= (int)num3)
				{
					throw new NullReferenceException();
				}
			}
			while (1UL <= (ulong)5L)
			{
			}
			return 5;
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00130FB4 File Offset: 0x0012F1B4
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x7DE580", Offset = "0x7DCB80", VA = "0x1807DE580")]
		public PlantData PurchasePlant(int shopIndex)
		{
			PlantData plantData = this.currentShopPlants[shopIndex];
			int num = 0;
			Board instance = Board.Instance;
			if (num < instance.columnNum)
			{
				CreatePlant instance2 = CreatePlant.Instance;
				int rowNum = Board.Instance.rowNum;
				PlantType plantType = plantData.PlantType;
				InGameText.Instance.TimeOver();
				int num2 = 0;
				Plant plant;
				if (!(plant != num2))
				{
					num++;
					Board instance3 = Board.Instance;
				}
				List<PlantData> list = this.currentShopPlants;
				InGameUI.Instance.Cards[shopIndex].Die();
				Board instance4 = Board.Instance;
				int cost = plantData.Cost;
				return plantData;
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance5 = InGameText.Instance;
			throw new NullReferenceException();
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00131074 File Offset: 0x0012F274
		[Token(Token = "0x60039E3")]
		[Address(RVA = "0x7DE4C0", Offset = "0x7DCAC0", VA = "0x1807DE4C0")]
		public void OnRoundStart()
		{
			InGameUI.Instance.SeedBank.SetActive(true);
			this.rerollCountThisRound = (int)((ulong)0L);
			if (!this.isShopLocked)
			{
				int num = 0;
				this.RefreshShopInternal(num != 0);
			}
			Debug.Log("[ShopManager] 新回合开始，刷新次数已重置");
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x001310BC File Offset: 0x0012F2BC
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x7DCBA0", Offset = "0x7DB1A0", VA = "0x1807DCBA0")]
		public bool BuyExperience()
		{
			EconomyManager economyManager = EconomyManager.<Instance>k__BackingField;
			bool flag = economyManager.SpendGold(4);
			if (!flag)
			{
				return flag;
			}
			economyManager.AddExp(4);
			return true;
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x001310EC File Offset: 0x0012F2EC
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x7DD2C0", Offset = "0x7DB8C0", VA = "0x1807DD2C0")]
		public string GetProbabilityDistribution()
		{
			int currentLevel = EconomyManager.<Instance>k__BackingField.currentLevel;
			Dictionary<int, float> costProbabilities = this.GetCostProbabilities(currentLevel);
			string text = string.Format("等级{0}植物分布:\n", costProbabilities);
			int num = 0;
			if (costProbabilities.ContainsKey(1) && costProbabilities[1] > num)
			{
				float num2 = costProbabilities[1];
				int num3;
				string text2 = string.Format("{0}费: {1:F0}%  ", num3, num3);
				string text3 = text + text2;
			}
			while (1UL <= (ulong)5L)
			{
			}
			return text.Trim();
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x00131168 File Offset: 0x0012F368
		[Token(Token = "0x60039E6")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public ShopManager()
		{
		}

		// Token: 0x04002BF0 RID: 11248
		[Token(Token = "0x4002BF0")]
		private const int shopSize = 5;

		// Token: 0x04002BF1 RID: 11249
		[Token(Token = "0x4002BF1")]
		private const int refreshCost = 2;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		private const int maxRerollsPerRound = 999;

		// Token: 0x04002BF3 RID: 11251
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BF3")]
		private List<PlantData> currentShopPlants;

		// Token: 0x04002BF4 RID: 11252
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BF4")]
		private int rerollCountThisRound;

		// Token: 0x04002BF5 RID: 11253
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002BF5")]
		private bool isShopLocked;

		// Token: 0x04002BF6 RID: 11254
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002BF6")]
		private Dictionary<int, List<PlantData>> plantPoolsByCost;
	}
}
