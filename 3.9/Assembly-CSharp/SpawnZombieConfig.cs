using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x020009E3 RID: 2531
[Token(Token = "0x20009E3")]
public class SpawnZombieConfig
{
	// Token: 0x0600338F RID: 13199 RVA: 0x0010FCC0 File Offset: 0x0010DEC0
	[Token(Token = "0x600338F")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SpawnZombieConfig()
	{
	}

	// Token: 0x0400257F RID: 9599
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400257F")]
	[TupleElementNames(new string[] { "minWave", "maxWave" })]
	public Dictionary<ZombieType, ValueTuple<int, int>> minWaveSpawnConfig;
}
