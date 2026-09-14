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
	// Token: 0x02000AB1 RID: 2737
	[Token(Token = "0x2000AB1")]
	public class ShopManager : MonoBehaviour
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x0012B49C File Offset: 0x0012969C
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x0012B4B0 File Offset: 0x001296B0
		[Token(Token = "0x1700038C")]
		public static ShopManager Instance
		{
			[Token(Token = "0x6003888")]
			[Address(RVA = "0x778130", Offset = "0x776730", VA = "0x180778130")]
			get;
			[Token(Token = "0x6003889")]
			[Address(RVA = "0x778230", Offset = "0x776830", VA = "0x180778230")]
			private set;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x0012B4C4 File Offset: 0x001296C4
		[Token(Token = "0x1700038D")]
		public IReadOnlyList<PlantData> CurrentShopPlants
		{
			[Token(Token = "0x600388A")]
			[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0")]
			get
			{
				List<PlantData> list = this.currentShopPlants;
				return null;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x0012B4E4 File Offset: 0x001296E4
		[Token(Token = "0x1700038E")]
		public int RefreshCost
		{
			[Token(Token = "0x600388B")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0")]
			get
			{
				return 2;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x0012B4F4 File Offset: 0x001296F4
		[Token(Token = "0x1700038F")]
		public int ShopSize
		{
			[Token(Token = "0x600388C")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00")]
			get
			{
				return 5;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x0012B504 File Offset: 0x00129704
		[Token(Token = "0x17000390")]
		public int RerollCountThisRound
		{
			[Token(Token = "0x600388D")]
			[Address(RVA = "0x525970", Offset = "0x523F70", VA = "0x180525970")]
			get
			{
				return this.rerollCountThisRound;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x0012B518 File Offset: 0x00129718
		[Token(Token = "0x17000391")]
		public int ExpCost
		{
			[Token(Token = "0x600388E")]
			[Address(RVA = "0x7780E0", Offset = "0x7766E0", VA = "0x1807780E0")]
			get
			{
				return 4;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x0012B52C File Offset: 0x0012972C
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x0012B540 File Offset: 0x00129740
		[Token(Token = "0x17000392")]
		public bool IsShopLocked
		{
			[Token(Token = "0x600388F")]
			[Address(RVA = "0x778170", Offset = "0x776770", VA = "0x180778170")]
			get
			{
				return this.isShopLocked;
			}
			[Token(Token = "0x6003890")]
			[Address(RVA = "0x778290", Offset = "0x776890", VA = "0x180778290")]
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
						Func<CardUI, bool> func;
						ShopManager.<>c.<>9__23_0 = func;
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
		// (add) Token: 0x06003891 RID: 14481 RVA: 0x0012B5BC File Offset: 0x001297BC
		// (remove) Token: 0x06003892 RID: 14482 RVA: 0x0012B5EC File Offset: 0x001297EC
		[Token(Token = "0x1400000E")]
		public event Action<List<PlantData>> OnShopRefreshed
		{
			[Token(Token = "0x6003891")]
			[Address(RVA = "0x778030", Offset = "0x776630", VA = "0x180778030")]
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
			[Token(Token = "0x6003892")]
			[Address(RVA = "0x778180", Offset = "0x776780", VA = "0x180778180")]
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

		// Token: 0x06003893 RID: 14483 RVA: 0x0012B61C File Offset: 0x0012981C
		[Token(Token = "0x6003893")]
		[Address(RVA = "0x775C00", Offset = "0x774200", VA = "0x180775C00")]
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

		// Token: 0x06003894 RID: 14484 RVA: 0x0012B668 File Offset: 0x00129868
		[Token(Token = "0x6003894")]
		[Address(RVA = "0x776940", Offset = "0x774F40", VA = "0x180776940")]
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

		// Token: 0x06003895 RID: 14485 RVA: 0x0012B6AC File Offset: 0x001298AC
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x776630", Offset = "0x774C30", VA = "0x180776630")]
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

		// Token: 0x06003896 RID: 14486 RVA: 0x0012B728 File Offset: 0x00129928
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x776A10", Offset = "0x775010", VA = "0x180776A10")]
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

		// Token: 0x06003897 RID: 14487 RVA: 0x0012BAB4 File Offset: 0x00129CB4
		[Token(Token = "0x6003897")]
		[Address(RVA = "0x775AB0", Offset = "0x7740B0", VA = "0x180775AB0")]
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

		// Token: 0x06003898 RID: 14488 RVA: 0x0012BAFC File Offset: 0x00129CFC
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x777E20", Offset = "0x776420", VA = "0x180777E20")]
		public void RefreshShop()
		{
			int num = 0;
			this.RefreshShopInternal(num != 0);
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x0012BB14 File Offset: 0x00129D14
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x777E30", Offset = "0x776430", VA = "0x180777E30")]
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

		// Token: 0x0600389A RID: 14490 RVA: 0x0012BB60 File Offset: 0x00129D60
		[Token(Token = "0x600389A")]
		[Address(RVA = "0x777A50", Offset = "0x776050", VA = "0x180777A50")]
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

		// Token: 0x0600389B RID: 14491 RVA: 0x0012BC64 File Offset: 0x00129E64
		[Token(Token = "0x600389B")]
		[Address(RVA = "0x775D80", Offset = "0x774380", VA = "0x180775D80")]
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

		// Token: 0x0600389C RID: 14492 RVA: 0x0012BD0C File Offset: 0x00129F0C
		[Token(Token = "0x600389C")]
		[Address(RVA = "0x775FB0", Offset = "0x7745B0", VA = "0x180775FB0")]
		private Dictionary<int, float> GetCostProbabilities(int playerLevel)
		{
			Dictionary<int, float> dictionary = new Dictionary();
			if (playerLevel - 1 <= 9)
			{
				int num = playerLevel - 1;
			}
			return dictionary;
		}

		// Token: 0x0600389D RID: 14493 RVA: 0x0012BD3C File Offset: 0x00129F3C
		[Token(Token = "0x600389D")]
		[Address(RVA = "0x777F60", Offset = "0x776560", VA = "0x180777F60")]
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

		// Token: 0x0600389E RID: 14494 RVA: 0x0012BD80 File Offset: 0x00129F80
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x7776F0", Offset = "0x775CF0", VA = "0x1807776F0")]
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
			int num3 = 0;
			instance5.ShowText("备战席已满", 3f, num3 != 0);
			throw new NullReferenceException();
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x0012BE58 File Offset: 0x0012A058
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x777630", Offset = "0x775C30", VA = "0x180777630")]
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

		// Token: 0x060038A0 RID: 14496 RVA: 0x0012BEA0 File Offset: 0x0012A0A0
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x775D10", Offset = "0x774310", VA = "0x180775D10")]
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

		// Token: 0x060038A1 RID: 14497 RVA: 0x0012BED0 File Offset: 0x0012A0D0
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x776430", Offset = "0x774A30", VA = "0x180776430")]
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

		// Token: 0x060038A2 RID: 14498 RVA: 0x0012BF4C File Offset: 0x0012A14C
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public ShopManager()
		{
		}

		// Token: 0x04002A7D RID: 10877
		[Token(Token = "0x4002A7D")]
		private const int shopSize = 5;

		// Token: 0x04002A7E RID: 10878
		[Token(Token = "0x4002A7E")]
		private const int refreshCost = 2;

		// Token: 0x04002A7F RID: 10879
		[Token(Token = "0x4002A7F")]
		private const int maxRerollsPerRound = 999;

		// Token: 0x04002A80 RID: 10880
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A80")]
		private List<PlantData> currentShopPlants;

		// Token: 0x04002A81 RID: 10881
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A81")]
		private int rerollCountThisRound;

		// Token: 0x04002A82 RID: 10882
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002A82")]
		private bool isShopLocked;

		// Token: 0x04002A83 RID: 10883
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A83")]
		private Dictionary<int, List<PlantData>> plantPoolsByCost;
	}
}
