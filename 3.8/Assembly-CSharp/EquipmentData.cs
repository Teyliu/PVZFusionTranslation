using System;
using Cpp2IlInjected;

// Token: 0x02000613 RID: 1555
[Token(Token = "0x2000613")]
[Serializable]
public class EquipmentData
{
	// Token: 0x06001D73 RID: 7539 RVA: 0x0009D4BC File Offset: 0x0009B6BC
	[Token(Token = "0x6001D73")]
	[Address(RVA = "0x51A9B0", Offset = "0x518FB0", VA = "0x18051A9B0")]
	public EquipmentData()
	{
	}

	// Token: 0x04000FEF RID: 4079
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FEF")]
	public EquipmentType theEquipmentType;

	// Token: 0x04000FF0 RID: 4080
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000FF0")]
	public int level = (int)((ulong)1L);

	// Token: 0x04000FF1 RID: 4081
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FF1")]
	public int theColumn;

	// Token: 0x04000FF2 RID: 4082
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000FF2")]
	public int theRow;

	// Token: 0x04000FF3 RID: 4083
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF3")]
	public bool set;
}
