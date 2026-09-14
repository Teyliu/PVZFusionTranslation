using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x0200077E RID: 1918
[Token(Token = "0x200077E")]
public class ResourcesManager
{
	// Token: 0x060026C1 RID: 9921 RVA: 0x000CEAC8 File Offset: 0x000CCCC8
	[Token(Token = "0x60026C1")]
	[Address(RVA = "0x5EE780", Offset = "0x5ECD80", VA = "0x1805EE780")]
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

	// Token: 0x060026C2 RID: 9922 RVA: 0x000CED6C File Offset: 0x000CCF6C
	[Token(Token = "0x60026C2")]
	[Address(RVA = "0x5E7CA0", Offset = "0x5E62A0", VA = "0x1805E7CA0")]
	private void LoadNormalSkin()
	{
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x000CED7C File Offset: 0x000CCF7C
	[Token(Token = "0x60026C3")]
	[Address(RVA = "0x5EDF10", Offset = "0x5EC510", VA = "0x1805EDF10")]
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
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x000CEF10 File Offset: 0x000CD110
	[Token(Token = "0x60026C4")]
	[Address(RVA = "0x5ED900", Offset = "0x5EBF00", VA = "0x1805ED900")]
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

	// Token: 0x060026C5 RID: 9925 RVA: 0x000CEF90 File Offset: 0x000CD190
	[Token(Token = "0x60026C5")]
	[Address(RVA = "0x5EDB70", Offset = "0x5EC170", VA = "0x1805EDB70")]
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

	// Token: 0x060026C6 RID: 9926 RVA: 0x000CF034 File Offset: 0x000CD234
	[Token(Token = "0x60026C6")]
	[Address(RVA = "0x5E71F0", Offset = "0x5E57F0", VA = "0x1805E71F0")]
	private void LoadBullet()
	{
		int num;
		do
		{
			num = 0;
			Array values = Enum.GetValues(typeof(BulletType));
			int num2 = 0;
			IEnumerator enumerator = values.GetEnumerator();
			if (num < num2)
			{
				num += num;
				num++;
			}
			num += num;
			num++;
			Type typeFromHandle = typeof(BulletType);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			GameObject gameObject = Resources.Load<GameObject>("Bullet/Prefabs/" + name);
			int num3 = 0;
			bool flag = gameObject != num3;
			if (!flag)
			{
				string text = string.Format("没有找到类型为{0}的子弹，编号为{1}", name, flag);
				int num4 = 0;
				Debug.LogWarning(text);
				text += text;
				num4 += 312;
				text += text;
			}
			Dictionary<BulletType, GameObject> dictionary = this.bulletPrefabs;
			List<BulletType> list = this.allBullets;
		}
		while (num != 0);
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000CF11C File Offset: 0x000CD31C
	[Token(Token = "0x60026C7")]
	[Address(RVA = "0x5E7650", Offset = "0x5E5C50", VA = "0x1805E7650")]
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

	// Token: 0x060026C8 RID: 9928 RVA: 0x000CF174 File Offset: 0x000CD374
	[Token(Token = "0x60026C8")]
	[Address(RVA = "0x5E77C0", Offset = "0x5E5DC0", VA = "0x1805E77C0")]
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

	// Token: 0x060026C9 RID: 9929 RVA: 0x000CF294 File Offset: 0x000CD494
	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x5E7B70", Offset = "0x5E6170", VA = "0x1805E7B70")]
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

	// Token: 0x060026CA RID: 9930 RVA: 0x000CF2C4 File Offset: 0x000CD4C4
	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x5EE610", Offset = "0x5ECC10", VA = "0x1805EE610")]
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

	// Token: 0x060026CB RID: 9931 RVA: 0x000CF2F8 File Offset: 0x000CD4F8
	[Token(Token = "0x60026CB")]
	[Address(RVA = "0x5EE420", Offset = "0x5ECA20", VA = "0x1805EE420")]
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

	// Token: 0x060026CC RID: 9932 RVA: 0x000CF34C File Offset: 0x000CD54C
	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x5EE260", Offset = "0x5EC860", VA = "0x1805EE260")]
	public void SetSkin(PlantType thePlantType, int index)
	{
		Dictionary<PlantType, List<GameObject>> dictionary = this._plantPrefabs;
		Dictionary<PlantType, List<GameObject>> dictionary2 = this._plantPreviews;
		Dictionary<PlantType, GameObject> dictionary3 = this.plantPrefabs;
		Dictionary<PlantType, GameObject> dictionary4 = this.plantPreviews;
		string text;
		Debug.LogWarning(text);
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x000CF3A0 File Offset: 0x000CD5A0
	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x5E7170", Offset = "0x5E5770", VA = "0x1805E7170")]
	public int GetSkin(PlantType thePlantType)
	{
		Dictionary<PlantType, int> dictionary = this.plantSkinDic;
		return 0;
	}

	// Token: 0x04001485 RID: 5253
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001485")]
	public readonly Dictionary<PlantType, GameObject> plantPrefabs;

	// Token: 0x04001486 RID: 5254
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001486")]
	public readonly Dictionary<PlantType, List<GameObject>> _plantPrefabs;

	// Token: 0x04001487 RID: 5255
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001487")]
	public readonly Dictionary<PlantType, GameObject> plantPreviews;

	// Token: 0x04001488 RID: 5256
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001488")]
	public readonly Dictionary<PlantType, List<GameObject>> _plantPreviews;

	// Token: 0x04001489 RID: 5257
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001489")]
	public readonly Dictionary<PlantType, int> plantSkinDic;

	// Token: 0x0400148A RID: 5258
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400148A")]
	public readonly Dictionary<ZombieType, GameObject> zombiePrefabs;

	// Token: 0x0400148B RID: 5259
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400148B")]
	public readonly Dictionary<ZombieType, Sprite> zombieSprites;

	// Token: 0x0400148C RID: 5260
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400148C")]
	public readonly Dictionary<BulletType, GameObject> bulletPrefabs;

	// Token: 0x0400148D RID: 5261
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400148D")]
	public readonly Dictionary<ParticleType, GameObject> particlePrefabs;

	// Token: 0x0400148E RID: 5262
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400148E")]
	public readonly Dictionary<GridItemType, GameObject> gridItemPrefabs;

	// Token: 0x0400148F RID: 5263
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400148F")]
	public readonly Dictionary<EquipmentType, GameObject> equipmentPrefabs;

	// Token: 0x04001490 RID: 5264
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001490")]
	public readonly Dictionary<SceneType, GameObject> backgroundPrefabs;

	// Token: 0x04001491 RID: 5265
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001491")]
	public readonly Dictionary<FunctionCardType, GameObject> specialCards;

	// Token: 0x04001492 RID: 5266
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001492")]
	public readonly Dictionary<CardBgType, Sprite> CardBgTypes;

	// Token: 0x04001493 RID: 5267
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001493")]
	public readonly Dictionary<PetType, GameObject> petPrefabs;

	// Token: 0x04001494 RID: 5268
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001494")]
	public readonly List<PlantType> allPlants;

	// Token: 0x04001495 RID: 5269
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001495")]
	public readonly List<ZombieType> allZombieTypes;

	// Token: 0x04001496 RID: 5270
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001496")]
	public readonly List<BulletType> allBullets;

	// Token: 0x04001497 RID: 5271
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001497")]
	public readonly List<ParticleType> allParticles;

	// Token: 0x04001498 RID: 5272
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001498")]
	public readonly List<GameObject> gravePrefabs;

	// Token: 0x04001499 RID: 5273
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001499")]
	public readonly Dictionary<GardenToolType, AnimTool> ToolAnimPrefabs;

	// Token: 0x0400149A RID: 5274
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400149A")]
	public readonly Dictionary<Item, Sprite> ZenGardenGoodsSprites;
}
