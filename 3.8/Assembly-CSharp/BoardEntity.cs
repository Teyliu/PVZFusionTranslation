using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x0200025B RID: 603
[Token(Token = "0x200025B")]
[Serializable]
public class BoardEntity
{
	// Token: 0x06000AD9 RID: 2777 RVA: 0x0003EA9C File Offset: 0x0003CC9C
	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x89E5A0", Offset = "0x89CBA0", VA = "0x18089E5A0")]
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

	// Token: 0x06000ADA RID: 2778 RVA: 0x0003EAE0 File Offset: 0x0003CCE0
	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x89E6D0", Offset = "0x89CCD0", VA = "0x18089E6D0")]
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

	// Token: 0x040006E7 RID: 1767
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E7")]
	public List<Plant> plantArray;

	// Token: 0x040006E8 RID: 1768
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E8")]
	public List<Plant> hiddenPlants;

	// Token: 0x040006E9 RID: 1769
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006E9")]
	public List<Plant> plantHead;

	// Token: 0x040006EA RID: 1770
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006EA")]
	public Dictionary<PlantType, List<Plant>> plantHeads;

	// Token: 0x040006EB RID: 1771
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40006EB")]
	public List<GardenPlant> gardenPlants;

	// Token: 0x040006EC RID: 1772
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40006EC")]
	public List<Bullet> bulletArray;

	// Token: 0x040006ED RID: 1773
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40006ED")]
	public Dictionary<int, List<Zombie>> waveZombies;

	// Token: 0x040006EE RID: 1774
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40006EE")]
	public List<GameObject> zombiePreviews;
}
