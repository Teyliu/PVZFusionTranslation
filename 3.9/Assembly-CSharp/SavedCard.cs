using System;
using Cpp2IlInjected;

// Token: 0x020008B7 RID: 2231
[Token(Token = "0x20008B7")]
[Serializable]
public class SavedCard
{
	// Token: 0x06002D8F RID: 11663 RVA: 0x000F9020 File Offset: 0x000F7220
	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public SavedCard()
	{
	}

	// Token: 0x04001B69 RID: 7017
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001B69")]
	public PlantType plantType;

	// Token: 0x04001B6A RID: 7018
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001B6A")]
	public bool extra;
}
