using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008F9 RID: 2297
[Token(Token = "0x20008F9")]
[Serializable]
public class MissionData
{
	// Token: 0x06002E98 RID: 11928 RVA: 0x000FEB88 File Offset: 0x000FCD88
	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x7145B0", Offset = "0x712BB0", VA = "0x1807145B0")]
	public MissionData()
	{
		List<MissionResult> list = new List();
		this.unlockedResult = list;
		base..ctor();
	}

	// Token: 0x04001CDA RID: 7386
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001CDA")]
	public AdvantureLevel level;

	// Token: 0x04001CDB RID: 7387
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001CDB")]
	public MissionResult result;

	// Token: 0x04001CDC RID: 7388
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CDC")]
	public List<MissionResult> unlockedResult;
}
