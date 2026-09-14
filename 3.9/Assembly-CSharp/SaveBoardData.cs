using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020007EF RID: 2031
[Token(Token = "0x20007EF")]
[Serializable]
public class SaveBoardData
{
	// Token: 0x06002924 RID: 10532 RVA: 0x000DE230 File Offset: 0x000DC430
	[Token(Token = "0x6002924")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SaveBoardData()
	{
	}

	// Token: 0x0400173E RID: 5950
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400173E")]
	public BoardStatistics boardStatistics;

	// Token: 0x0400173F RID: 5951
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400173F")]
	public SceneType sceneType;

	// Token: 0x04001740 RID: 5952
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001740")]
	public bool isBoardSaved;

	// Token: 0x04001741 RID: 5953
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001741")]
	public int theBoardSun;

	// Token: 0x04001742 RID: 5954
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001742")]
	public int theBoardMoney;

	// Token: 0x04001743 RID: 5955
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001743")]
	public float theBoardPoints;

	// Token: 0x04001744 RID: 5956
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001744")]
	public int theCurrentSurvivalRound;

	// Token: 0x04001745 RID: 5957
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001745")]
	public int theEndlessSurvivalMaxRound;

	// Token: 0x04001746 RID: 5958
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001746")]
	public long startTime;

	// Token: 0x04001747 RID: 5959
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001747")]
	public List<JigSawData> jigSawDatas;
}
