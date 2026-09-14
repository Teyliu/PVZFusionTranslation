using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200087A RID: 2170
[Token(Token = "0x200087A")]
[Serializable]
public class SavedCardGroup
{
	// Token: 0x06002C5C RID: 11356 RVA: 0x000F4360 File Offset: 0x000F2560
	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x6847D0", Offset = "0x682DD0", VA = "0x1806847D0")]
	public SavedCardGroup()
	{
		List<SavedCard> list = new List();
		this.savedCards = list;
		base..ctor();
	}

	// Token: 0x04001A79 RID: 6777
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A79")]
	public string name = "自定义卡组";

	// Token: 0x04001A7A RID: 6778
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001A7A")]
	public List<SavedCard> savedCards;
}
