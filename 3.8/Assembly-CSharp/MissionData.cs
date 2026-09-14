using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008BD RID: 2237
[Token(Token = "0x20008BD")]
[Serializable]
public class MissionData
{
	// Token: 0x06002D65 RID: 11621 RVA: 0x000F9FF4 File Offset: 0x000F81F4
	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x69A450", Offset = "0x698A50", VA = "0x18069A450")]
	public MissionData()
	{
		List<MissionResult> list = new List();
		this.unlockedResult = list;
		base..ctor();
	}

	// Token: 0x04001BEA RID: 7146
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001BEA")]
	public AdvantureLevel level;

	// Token: 0x04001BEB RID: 7147
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001BEB")]
	public MissionResult result;

	// Token: 0x04001BEC RID: 7148
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001BEC")]
	public List<MissionResult> unlockedResult;
}
