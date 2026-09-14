using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
[Serializable]
public class OrderedSpawn
{
	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0003F34C File Offset: 0x0003D54C
	[Token(Token = "0x17000091")]
	public List<ZombieSpawnData> Zombies
	{
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x8A77B0", Offset = "0x8A5DB0", VA = "0x1808A77B0")]
		get
		{
			this.ConvertOldData();
			return this.zombiesWithRow;
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0003F368 File Offset: 0x0003D568
	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x8A74C0", Offset = "0x8A5AC0", VA = "0x1808A74C0")]
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

	// Token: 0x06000AF8 RID: 2808 RVA: 0x0003F3E0 File Offset: 0x0003D5E0
	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x8A76F0", Offset = "0x8A5CF0", VA = "0x1808A76F0")]
	public OrderedSpawn()
	{
		List<ZombieType> list = new List();
		this.zombies = list;
		List<ZombieSpawnData> list2 = new List();
		this.zombiesWithRow = list2;
		base..ctor();
	}

	// Token: 0x04000705 RID: 1797
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000705")]
	public int wave;

	// Token: 0x04000706 RID: 1798
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000706")]
	[SerializeField]
	private List<ZombieType> zombies;

	// Token: 0x04000707 RID: 1799
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000707")]
	[SerializeField]
	private List<ZombieSpawnData> zombiesWithRow;
}
