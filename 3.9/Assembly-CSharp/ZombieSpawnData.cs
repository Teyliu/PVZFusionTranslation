using System;
using Cpp2IlInjected;

// Token: 0x02000268 RID: 616
[Token(Token = "0x2000268")]
[Serializable]
public class ZombieSpawnData
{
	// Token: 0x06000B15 RID: 2837 RVA: 0x0003F2CC File Offset: 0x0003D4CC
	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x940560", Offset = "0x93EB60", VA = "0x180940560")]
	public ZombieSpawnData(ZombieType zombieType)
	{
		this.zombieType = zombieType;
		this.row = (int)((ulong)4294967295L);
	}

	// Token: 0x04000714 RID: 1812
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000714")]
	public ZombieType zombieType;

	// Token: 0x04000715 RID: 1813
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000715")]
	public int row;
}
