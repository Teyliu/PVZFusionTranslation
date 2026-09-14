using System;
using Cpp2IlInjected;

// Token: 0x02000262 RID: 610
[Token(Token = "0x2000262")]
[Serializable]
public class ZombieSpawnData
{
	// Token: 0x06000AF9 RID: 2809 RVA: 0x0003F410 File Offset: 0x0003D610
	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x8B0950", Offset = "0x8AEF50", VA = "0x1808B0950")]
	public ZombieSpawnData(ZombieType zombieType)
	{
		this.zombieType = zombieType;
		this.row = (int)((ulong)4294967295L);
	}

	// Token: 0x04000708 RID: 1800
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000708")]
	public ZombieType zombieType;

	// Token: 0x04000709 RID: 1801
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000709")]
	public int row;
}
