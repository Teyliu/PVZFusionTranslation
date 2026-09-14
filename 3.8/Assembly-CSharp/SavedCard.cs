using System;
using Cpp2IlInjected;

// Token: 0x0200087B RID: 2171
[Token(Token = "0x200087B")]
[Serializable]
public class SavedCard
{
	// Token: 0x06002C5D RID: 11357 RVA: 0x000F438C File Offset: 0x000F258C
	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public SavedCard()
	{
	}

	// Token: 0x04001A7B RID: 6779
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001A7B")]
	public PlantType plantType;

	// Token: 0x04001A7C RID: 6780
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001A7C")]
	public bool extra;
}
