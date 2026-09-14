using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
[Serializable]
public class BoardEntity
{
	// Token: 0x06000AF5 RID: 2805 RVA: 0x0003E948 File Offset: 0x0003CB48
	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0x92E520", Offset = "0x92CB20", VA = "0x18092E520")]
	public void AddWaveZombie(int wave, Zombie zombie)
	{
		bool flag = this.waveZombies.ContainsKey(wave);
		Dictionary<int, List<Zombie>> dictionary = this.waveZombies;
		if (!flag)
		{
			List<Zombie> list = new List();
			dictionary.Add(wave, list);
			return;
		}
		List<Zombie> list2 = dictionary[wave];
		throw new NullReferenceException();
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0003E98C File Offset: 0x0003CB8C
	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x92E650", Offset = "0x92CC50", VA = "0x18092E650")]
	public BoardEntity()
	{
		List<Plant> list = new List();
		this.plantArray = list;
		List<Plant> list2 = new List();
		this.hiddenPlants = list2;
		List<Plant> list3 = new List();
		this.plantHead = list3;
		Dictionary<PlantType, List<Plant>> dictionary = new Dictionary();
		this.plantHeads = dictionary;
		List<GardenPlant> list4 = new List();
		this.gardenPlants = list4;
		List<Bullet> list5 = new List();
		this.bulletArray = list5;
		Dictionary<int, List<Zombie>> dictionary2 = new Dictionary();
		this.waveZombies = dictionary2;
		List<GameObject> list6 = new List();
		this.zombiePreviews = list6;
		base..ctor();
	}

	// Token: 0x040006F3 RID: 1779
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F3")]
	public List<Plant> plantArray;

	// Token: 0x040006F4 RID: 1780
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F4")]
	public List<Plant> hiddenPlants;

	// Token: 0x040006F5 RID: 1781
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F5")]
	public List<Plant> plantHead;

	// Token: 0x040006F6 RID: 1782
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006F6")]
	public Dictionary<PlantType, List<Plant>> plantHeads;

	// Token: 0x040006F7 RID: 1783
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006F7")]
	public List<GardenPlant> gardenPlants;

	// Token: 0x040006F8 RID: 1784
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006F8")]
	public List<Bullet> bulletArray;

	// Token: 0x040006F9 RID: 1785
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006F9")]
	public Dictionary<int, List<Zombie>> waveZombies;

	// Token: 0x040006FA RID: 1786
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006FA")]
	public List<GameObject> zombiePreviews;
}
