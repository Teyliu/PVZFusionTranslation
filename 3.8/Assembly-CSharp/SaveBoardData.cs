using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007B6 RID: 1974
[Token(Token = "0x20007B6")]
[Serializable]
public class SaveBoardData
{
	// Token: 0x060027F5 RID: 10229 RVA: 0x000D9274 File Offset: 0x000D7474
	[Token(Token = "0x60027F5")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SaveBoardData()
	{
	}

	// Token: 0x04001662 RID: 5730
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001662")]
	public BoardStatistics boardStatistics;

	// Token: 0x04001663 RID: 5731
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001663")]
	public SceneType sceneType;

	// Token: 0x04001664 RID: 5732
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001664")]
	public bool isBoardSaved;

	// Token: 0x04001665 RID: 5733
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001665")]
	public int theBoardSun;

	// Token: 0x04001666 RID: 5734
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001666")]
	public int theBoardMoney;

	// Token: 0x04001667 RID: 5735
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001667")]
	public float theBoardPoints;

	// Token: 0x04001668 RID: 5736
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001668")]
	public int theCurrentSurvivalRound;

	// Token: 0x04001669 RID: 5737
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001669")]
	public int theEndlessSurvivalMaxRound;

	// Token: 0x0400166A RID: 5738
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400166A")]
	public long startTime;

	// Token: 0x0400166B RID: 5739
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400166B")]
	public List<JigSawData> jigSawDatas;
}
