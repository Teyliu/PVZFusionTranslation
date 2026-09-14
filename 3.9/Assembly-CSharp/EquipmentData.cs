using System;
using Cpp2IlInjected;

// Token: 0x02000648 RID: 1608
[Token(Token = "0x2000648")]
[Serializable]
public class EquipmentData
{
	// Token: 0x06001E72 RID: 7794 RVA: 0x000A1F68 File Offset: 0x000A0168
	[Token(Token = "0x6001E72")]
	[Address(RVA = "0x58FBB0", Offset = "0x58E1B0", VA = "0x18058FBB0")]
	public EquipmentData()
	{
	}

	// Token: 0x040010B7 RID: 4279
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010B7")]
	public EquipmentType theEquipmentType;

	// Token: 0x040010B8 RID: 4280
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40010B8")]
	public int level = (int)((ulong)1L);

	// Token: 0x040010B9 RID: 4281
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010B9")]
	public int theColumn;

	// Token: 0x040010BA RID: 4282
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40010BA")]
	public int theRow;

	// Token: 0x040010BB RID: 4283
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010BB")]
	public bool set;
}
