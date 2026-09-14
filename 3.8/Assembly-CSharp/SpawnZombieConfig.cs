using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

// Token: 0x020009A7 RID: 2471
[Token(Token = "0x20009A7")]
public class SpawnZombieConfig
{
	// Token: 0x0600325B RID: 12891 RVA: 0x0010AEEC File Offset: 0x001090EC
	[Token(Token = "0x600325B")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SpawnZombieConfig()
	{
	}

	// Token: 0x0400246D RID: 9325
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400246D")]
	[TupleElementNames(new string[] { "minWave", "maxWave" })]
	public Dictionary<ZombieType, ValueTuple<int, int>> minWaveSpawnConfig;
}
