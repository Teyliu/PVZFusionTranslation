using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000267 RID: 615
[Token(Token = "0x2000267")]
[Serializable]
public class OrderedSpawn
{
	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0003F208 File Offset: 0x0003D408
	[Token(Token = "0x170000CF")]
	public List<ZombieSpawnData> Zombies
	{
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x9377D0", Offset = "0x935DD0", VA = "0x1809377D0")]
		get
		{
			this.ConvertOldData();
			return this.zombiesWithRow;
		}
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x0003F224 File Offset: 0x0003D424
	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x9374E0", Offset = "0x935AE0", VA = "0x1809374E0")]
	private void ConvertOldData()
	{
		ulong num2;
		do
		{
			int num = 0;
			if (this.zombies == num)
			{
				break;
			}
			bool flag;
			if (flag)
			{
				List<ZombieSpawnData> list = this.zombiesWithRow;
				ZombieSpawnData zombieSpawnData;
				zombieSpawnData.zombieType = (ZombieType)num;
				zombieSpawnData.row = (int)((ulong)4294967295L);
				int size = list._size;
				list._size = zombieSpawnData;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x0003F29C File Offset: 0x0003D49C
	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x937710", Offset = "0x935D10", VA = "0x180937710")]
	public OrderedSpawn()
	{
		List<ZombieType> list = new List();
		this.zombies = list;
		List<ZombieSpawnData> list2 = new List();
		this.zombiesWithRow = list2;
		base..ctor();
	}

	// Token: 0x04000711 RID: 1809
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000711")]
	public int wave;

	// Token: 0x04000712 RID: 1810
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000712")]
	[SerializeField]
	private List<ZombieType> zombies;

	// Token: 0x04000713 RID: 1811
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000713")]
	[SerializeField]
	private List<ZombieSpawnData> zombiesWithRow;
}
