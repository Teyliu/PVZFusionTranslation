using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x020007B7 RID: 1975
[Token(Token = "0x20007B7")]
public class ResourcesManager
{
	// Token: 0x060027F0 RID: 10224 RVA: 0x000D3AF8 File Offset: 0x000D1CF8
	[Token(Token = "0x60027F0")]
	[Address(RVA = "0x651D60", Offset = "0x650360", VA = "0x180651D60")]
	public ResourcesManager()
	{
		ulong num3;
		do
		{
			Dictionary<PlantType, GameObject> dictionary = new Dictionary();
			this.plantPrefabs = dictionary;
			Dictionary<PlantType, List<GameObject>> dictionary2 = new Dictionary();
			this._plantPrefabs = dictionary2;
			Dictionary<PlantType, GameObject> dictionary3 = new Dictionary();
			this.plantPreviews = dictionary3;
			Dictionary<PlantType, List<GameObject>> dictionary4 = new Dictionary();
			this._plantPreviews = dictionary4;
			Dictionary<PlantType, int> dictionary5 = new Dictionary();
			this.plantSkinDic = dictionary5;
			Dictionary<ZombieType, GameObject> dictionary6 = new Dictionary();
			this.zombiePrefabs = dictionary6;
			Dictionary<ZombieType, Sprite> dictionary7 = new Dictionary();
			this.zombieSprites = dictionary7;
			Dictionary<BulletType, GameObject> dictionary8 = new Dictionary();
			this.bulletPrefabs = dictionary8;
			Dictionary<ParticleType, GameObject> dictionary9 = new Dictionary();
			this.particlePrefabs = dictionary9;
			Dictionary<GridItemType, GameObject> dictionary10 = new Dictionary();
			this.gridItemPrefabs = dictionary10;
			Dictionary<EquipmentType, GameObject> dictionary11 = new Dictionary();
			this.equipmentPrefabs = dictionary11;
			Dictionary<SceneType, GameObject> dictionary12 = new Dictionary();
			this.backgroundPrefabs = dictionary12;
			Dictionary<FunctionCardType, GameObject> dictionary13 = new Dictionary();
			this.specialCards = dictionary13;
			Dictionary<CardBgType, Sprite> dictionary14 = new Dictionary();
			this.CardBgTypes = dictionary14;
			Dictionary<PetType, GameObject> dictionary15 = new Dictionary();
			this.petPrefabs = dictionary15;
			List<PlantType> list = new List();
			this.allPlants = list;
			List<ZombieType> list2 = new List();
			this.allZombieTypes = list2;
			List<BulletType> list3 = new List();
			this.allBullets = list3;
			List<ParticleType> list4 = new List();
			this.allParticles = list4;
			List<GameObject> list5 = new List();
			this.gravePrefabs = list5;
			Dictionary<GardenToolType, AnimTool> dictionary16 = new Dictionary();
			this.ToolAnimPrefabs = dictionary16;
			Dictionary<Item, Sprite> dictionary17 = new Dictionary();
			this.ZenGardenGoodsSprites = dictionary17;
			this.LoadPlant();
			this.LoadBullet();
			Dictionary<ParticleType, GameObject> dict = global::Core.Lawnf.GetDict<ParticleType, GameObject>("Particle/Prefabs/", true);
			this.particlePrefabs = dict;
			Dictionary<ZombieType, GameObject> dict2 = global::Core.Lawnf.GetDict<ZombieType, GameObject>("Zombies/_Prefab/", true);
			this.zombiePrefabs = dict2;
			Dictionary<EquipmentType, GameObject> dict3 = global::Core.Lawnf.GetDict<EquipmentType, GameObject>("Garden/Equip/", true);
			this.equipmentPrefabs = dict3;
			Dictionary<SceneType, GameObject> dict4 = global::Core.Lawnf.GetDict<SceneType, GameObject>("Background/Prefab/", true);
			this.backgroundPrefabs = dict4;
			Dictionary<FunctionCardType, GameObject> dict5 = global::Core.Lawnf.GetDict<FunctionCardType, GameObject>("UI/Cards/Prefab/SpecialCard/", true);
			this.specialCards = dict5;
			Dictionary<PetType, GameObject> dict6 = global::Core.Lawnf.GetDict<PetType, GameObject>("MiniPet/Prefabs/", true);
			this.petPrefabs = dict6;
			Dictionary<ZombieType, Sprite> dict7 = global::Core.Lawnf.GetDict<ZombieType, Sprite>("ZombieImage/", true);
			this.zombieSprites = dict7;
			Dictionary<CardBgType, Sprite> dict8 = global::Core.Lawnf.GetDict<CardBgType, Sprite>("UI/Cards/SeedPacket_", true);
			this.CardBgTypes = dict8;
			Dictionary<GardenToolType, AnimTool> dict9 = global::Core.Lawnf.GetDict<GardenToolType, AnimTool>("Garden/Tools/", true);
			this.ToolAnimPrefabs = dict9;
			Dictionary<Item, Sprite> dict10 = global::Core.Lawnf.GetDict<Item, Sprite>("Garden/GardenSprites/GoodsIcon/", true);
			this.ZenGardenGoodsSprites = dict10;
			Dictionary<ZombieType, GameObject> dictionary18 = this.zombiePrefabs;
			bool flag;
			if (flag)
			{
				List<ZombieType> list6 = this.allZombieTypes;
				int num = list6._size + 1;
				list6._size = num;
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_0284;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num3 != (ulong)0L);
		return;
		IL_0284:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x000D3D9C File Offset: 0x000D1F9C
	[Token(Token = "0x60027F1")]
	[Address(RVA = "0x64AFB0", Offset = "0x6495B0", VA = "0x18064AFB0")]
	private void LoadNormalSkin()
	{
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x000D3DAC File Offset: 0x000D1FAC
	[Token(Token = "0x60027F2")]
	[Address(RVA = "0x6514D0", Offset = "0x64FAD0", VA = "0x1806514D0")]
	private void LoadSkin()
	{
		this.LoadPlant((PlantType)((uint)254), "Plants/UniquePlants/Endoflame/EndoFlame1/EndoFlame1");
		this.LoadPlant((PlantType)((uint)254), "Plants/UniquePlants/Endoflame/EndoFlame2/EndoFlame2");
		this.LoadPlant((PlantType)((uint)248), "Plants/Squash/Squalour/Squalour1");
		this.LoadPlant((PlantType)((uint)248), "Plants/Squash/Squalour/Squalour2/Squalour2");
		this.LoadPlant((PlantType)((uint)251), "Plants/Travel/SuperSunNut/BigSunNut1");
		this.LoadPlant((PlantType)((uint)900), "Plants/Travel/HyponoT/HypnoEmperor1");
		this.LoadPlant((PlantType)((uint)901), "Plants/UltimateGatling/UltimateGatling1");
		this.LoadPlant((PlantType)((uint)902), "Plants/TorchWood/UltimateTorch/UltimateTorch1");
		this.LoadPlant((PlantType)((uint)903), "Plants/_Mixer/SuperChomper/UltimateChomper/UltimateChomper1");
		this.LoadPlant((PlantType)((uint)904), "Plants/_Mixer/IceDoomFume/Ultimatefume1/Ultimatefume1");
		this.LoadPlant((PlantType)((uint)905), "Plants/Travel/SuperSunNut/SuperSunNut1");
		this.LoadPlant((PlantType)((uint)906), "Plants/Travel/ObsidianSpike/ObsidianSpike1");
		this.LoadPlant((PlantType)((uint)907), "Plants/Travel/DoomGatling/DoomGatling1");
		this.LoadPlant((PlantType)((uint)954), "Plants/SunFlower/UltimateSunflower/UltimateSunflower1");
		this.LoadPlant((PlantType)((uint)1054), "Plants/Squash/JalaSquash1");
		this.LoadPlant((PlantType)((uint)908), "Plants/_Mixer/DoublePuff/SnowGatlingPuff/SnowGatlingPuff1");
		this.LoadPlant((PlantType)((uint)241), "Plants/IceBean/Magic Landie/IceBean1");
		this.LoadPlant((PlantType)((uint)926), "Plants/CattailPlant/CattailLour/CattailLour1");
		this.LoadPlant((PlantType)((uint)909), "Plants/Travel/UltimateStar/UltimateStar1/UltimateStar1");
		this.LoadPlant((PlantType)((uint)910), "Plants/Travel/UltimateGloom/UltimateGloom1");
		this.LoadPlant((PlantType)((uint)973), "Plants/ElectricOnion/PinkOnion/PinkOnion1");
		this.LoadPlant((PlantType)((uint)911), "Plants/Pumpkin/UltimatePumpkin/UltimatePumpkin1/UltimatePumpkin1");
		this.LoadPlant((PlantType)((uint)940), "Plants/FumeShroom/UltimateSpring/UltimateSpring1");
		this.LoadPlant((PlantType)((uint)913), "Plants/TallNut/UltimateTallNut/UltimateTallNut1");
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x000D3F54 File Offset: 0x000D2154
	[Token(Token = "0x60027F3")]
	[Address(RVA = "0x650EC0", Offset = "0x64F4C0", VA = "0x180650EC0")]
	private void LoadPlant()
	{
		ulong num;
		do
		{
			this.LoadNormalSkin();
			this.LoadSkin();
			Dictionary<PlantType, List<GameObject>> dictionary = this._plantPrefabs;
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, List<GameObject>> dictionary2 = this._plantPrefabs;
				Dictionary<PlantType, List<GameObject>> dictionary3 = this._plantPreviews;
				Dictionary<PlantType, GameObject> dictionary4 = this.plantPrefabs;
				Dictionary<PlantType, GameObject> dictionary5 = this.plantPreviews;
				Dictionary<PlantType, int> dictionary6 = this.plantSkinDic;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x000D3FD4 File Offset: 0x000D21D4
	[Token(Token = "0x60027F4")]
	[Address(RVA = "0x651130", Offset = "0x64F730", VA = "0x180651130")]
	private void LoadPlant(PlantType thePlantType, string path)
	{
		GameObject gameObject = Resources.Load<GameObject>(path + "prefab");
		List<GameObject> list = new List();
		int num = 0;
		if (gameObject != num)
		{
			Dictionary<PlantType, List<GameObject>> dictionary = this._plantPrefabs;
			bool flag;
			if (!flag)
			{
				Dictionary<PlantType, List<GameObject>> dictionary2 = this._plantPrefabs;
			}
			GameObject gameObject2 = Resources.Load<GameObject>(path + "preview");
			List<GameObject> list2 = new List();
			int num2 = 0;
			if (gameObject2 != num2)
			{
				Dictionary<PlantType, List<GameObject>> dictionary3 = this._plantPreviews;
				bool flag2;
				if (!flag2)
				{
					Dictionary<PlantType, List<GameObject>> dictionary4 = this._plantPreviews;
					List<PlantType> list3 = this.allPlants;
					return;
				}
				throw new NullReferenceException();
			}
		}
		string text2;
		string text = string.Format(text2, text2);
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x000D4078 File Offset: 0x000D2278
	[Token(Token = "0x60027F5")]
	[Address(RVA = "0x64A530", Offset = "0x648B30", VA = "0x18064A530")]
	private void LoadBullet()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = Enum.GetValues(typeof(BulletType)).GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				Type typeFromHandle = typeof(BulletType);
				string name = Enum.GetName(typeFromHandle, typeFromHandle);
				GameObject gameObject = Resources.Load<GameObject>("Bullet/Prefabs/" + name);
				int num2 = 0;
				bool flag = gameObject != num2;
				if (!flag)
				{
					string text = string.Format("没有找到类型为{0}的子弹，编号为{1}", name, flag);
					Debug.LogWarning(text);
					text += text;
				}
				Dictionary<BulletType, GameObject> dictionary = this.bulletPrefabs;
				List<BulletType> list = this.allBullets;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x000D4148 File Offset: 0x000D2348
	[Token(Token = "0x60027F6")]
	[Address(RVA = "0x64A960", Offset = "0x648F60", VA = "0x18064A960")]
	private void LoadGraves()
	{
		int num = 0;
		int num2;
		GameObject gameObject = Resources.Load<GameObject>(string.Format("GridItem/Grave/Graves_{0}", num2));
		int num3 = 0;
		if (gameObject != num3)
		{
			List<GameObject> list = this.gravePrefabs;
			int size = list._size;
			num++;
			list._size = list;
			num++;
		}
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x000D41A0 File Offset: 0x000D23A0
	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x64AAD0", Offset = "0x6490D0", VA = "0x18064AAD0")]
	private void LoadGridItem()
	{
		int num = 0;
		int num2;
		GameObject gameObject = Resources.Load<GameObject>(string.Format("GridItem/Grave/Graves_{0}", num2));
		int num3 = 0;
		if (gameObject != num3)
		{
			List<GameObject> list = this.gravePrefabs;
			int size = list._size;
			num++;
			list._size = list;
			num++;
		}
		string text = "GridItem/" + "Crater/CraterDay";
		int num4 = 0;
		this.LoadGridItem((GridItemType)num4, text);
		string text2 = "GridItem/" + "Crater/CraterNight";
		string text3 = "GridItem/" + "ScaryPot/ScaryPot";
		string text4 = "GridItem/" + "Ladder";
		string text5 = "GridItem/" + "ScaryPot/ScaryPot_plant";
		string text6 = "GridItem/" + "ScaryPot/ScaryPot_zombie";
		string text7 = "GridItem/" + "FreezedPlant/IceBlock";
		string text8 = "GridItem/" + "ScaryPot/ScaryPot_hypnoZombie";
		string text9 = "GridItem/" + "ScaryPot/ScaryPot_obsidian";
		string text10 = "GridItem/" + "ScaryPot/ScaryPot_gold";
		string text11 = "GridItem/" + "ScaryPot/ScaryPot_red";
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x000D42C0 File Offset: 0x000D24C0
	[Token(Token = "0x60027F8")]
	[Address(RVA = "0x64AE80", Offset = "0x649480", VA = "0x18064AE80")]
	private void LoadGridItem(GridItemType theItemType, string path)
	{
		GameObject gameObject = Resources.Load<GameObject>(path);
		int num = 0;
		if (gameObject != num)
		{
			Dictionary<GridItemType, GameObject> dictionary = this.gridItemPrefabs;
			return;
		}
	}

	// Token: 0x060027F9 RID: 10233 RVA: 0x000D42F0 File Offset: 0x000D24F0
	[Token(Token = "0x60027F9")]
	[Address(RVA = "0x651BF0", Offset = "0x6501F0", VA = "0x180651BF0")]
	public void SkinListToDic(List<PlantSkinData> list)
	{
		ulong num;
		do
		{
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, int> dictionary = this.plantSkinDic;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060027FA RID: 10234 RVA: 0x000D4324 File Offset: 0x000D2524
	[Token(Token = "0x60027FA")]
	[Address(RVA = "0x651A00", Offset = "0x650000", VA = "0x180651A00")]
	public List<PlantSkinData> SkinDicToList()
	{
		List<PlantSkinData> list;
		ulong num;
		do
		{
			list = new List();
			Dictionary<PlantType, int> dictionary = this.plantSkinDic;
			bool flag;
			if (flag)
			{
				new PlantSkinData().skinIndex = 0;
			}
		}
		while (num != (ulong)0L);
		return list;
	}

	// Token: 0x060027FB RID: 10235 RVA: 0x000D4378 File Offset: 0x000D2578
	[Token(Token = "0x60027FB")]
	[Address(RVA = "0x651840", Offset = "0x64FE40", VA = "0x180651840")]
	public void SetSkin(PlantType thePlantType, int index)
	{
		Dictionary<PlantType, List<GameObject>> dictionary = this._plantPrefabs;
		Dictionary<PlantType, List<GameObject>> dictionary2 = this._plantPreviews;
		Dictionary<PlantType, GameObject> dictionary3 = this.plantPrefabs;
		Dictionary<PlantType, GameObject> dictionary4 = this.plantPreviews;
		string text;
		Debug.LogWarning(text);
	}

	// Token: 0x060027FC RID: 10236 RVA: 0x000D43CC File Offset: 0x000D25CC
	[Token(Token = "0x60027FC")]
	[Address(RVA = "0x64A4B0", Offset = "0x648AB0", VA = "0x18064A4B0")]
	public int GetSkin(PlantType thePlantType)
	{
		Dictionary<PlantType, int> dictionary = this.plantSkinDic;
		return 0;
	}

	// Token: 0x04001561 RID: 5473
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001561")]
	public readonly Dictionary<PlantType, GameObject> plantPrefabs;

	// Token: 0x04001562 RID: 5474
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001562")]
	public readonly Dictionary<PlantType, List<GameObject>> _plantPrefabs;

	// Token: 0x04001563 RID: 5475
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001563")]
	public readonly Dictionary<PlantType, GameObject> plantPreviews;

	// Token: 0x04001564 RID: 5476
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001564")]
	public readonly Dictionary<PlantType, List<GameObject>> _plantPreviews;

	// Token: 0x04001565 RID: 5477
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001565")]
	public readonly Dictionary<PlantType, int> plantSkinDic;

	// Token: 0x04001566 RID: 5478
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001566")]
	public readonly Dictionary<ZombieType, GameObject> zombiePrefabs;

	// Token: 0x04001567 RID: 5479
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001567")]
	public readonly Dictionary<ZombieType, Sprite> zombieSprites;

	// Token: 0x04001568 RID: 5480
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001568")]
	public readonly Dictionary<BulletType, GameObject> bulletPrefabs;

	// Token: 0x04001569 RID: 5481
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001569")]
	public readonly Dictionary<ParticleType, GameObject> particlePrefabs;

	// Token: 0x0400156A RID: 5482
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400156A")]
	public readonly Dictionary<GridItemType, GameObject> gridItemPrefabs;

	// Token: 0x0400156B RID: 5483
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400156B")]
	public readonly Dictionary<EquipmentType, GameObject> equipmentPrefabs;

	// Token: 0x0400156C RID: 5484
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400156C")]
	public readonly Dictionary<SceneType, GameObject> backgroundPrefabs;

	// Token: 0x0400156D RID: 5485
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400156D")]
	public readonly Dictionary<FunctionCardType, GameObject> specialCards;

	// Token: 0x0400156E RID: 5486
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400156E")]
	public readonly Dictionary<CardBgType, Sprite> CardBgTypes;

	// Token: 0x0400156F RID: 5487
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400156F")]
	public readonly Dictionary<PetType, GameObject> petPrefabs;

	// Token: 0x04001570 RID: 5488
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001570")]
	public readonly List<PlantType> allPlants;

	// Token: 0x04001571 RID: 5489
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001571")]
	public readonly List<ZombieType> allZombieTypes;

	// Token: 0x04001572 RID: 5490
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001572")]
	public readonly List<BulletType> allBullets;

	// Token: 0x04001573 RID: 5491
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001573")]
	public readonly List<ParticleType> allParticles;

	// Token: 0x04001574 RID: 5492
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001574")]
	public readonly List<GameObject> gravePrefabs;

	// Token: 0x04001575 RID: 5493
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001575")]
	public readonly Dictionary<GardenToolType, AnimTool> ToolAnimPrefabs;

	// Token: 0x04001576 RID: 5494
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001576")]
	public readonly Dictionary<Item, Sprite> ZenGardenGoodsSprites;
}
