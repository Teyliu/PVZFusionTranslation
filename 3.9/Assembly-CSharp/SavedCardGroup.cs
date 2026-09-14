using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020008B6 RID: 2230
[Token(Token = "0x20008B6")]
[Serializable]
public class SavedCardGroup
{
	// Token: 0x06002D8E RID: 11662 RVA: 0x000F8FF4 File Offset: 0x000F71F4
	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x6FDD90", Offset = "0x6FC390", VA = "0x1806FDD90")]
	public SavedCardGroup()
	{
		List<SavedCard> list = new List();
		this.savedCards = list;
		base..ctor();
	}

	// Token: 0x04001B67 RID: 7015
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001B67")]
	public string name = "自定义卡组";

	// Token: 0x04001B68 RID: 7016
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001B68")]
	public List<SavedCard> savedCards;
}
