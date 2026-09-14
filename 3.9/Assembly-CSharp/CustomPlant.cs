using System;
using Cpp2IlInjected;

// Token: 0x02000775 RID: 1909
[Token(Token = "0x2000775")]
[Serializable]
public class CustomPlant
{
	// Token: 0x060026D8 RID: 9944 RVA: 0x000CB9F8 File Offset: 0x000C9BF8
	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public CustomPlant()
	{
	}

	// Token: 0x040013D8 RID: 5080
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40013D8")]
	public PlantType thePlantType;

	// Token: 0x040013D9 RID: 5081
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40013D9")]
	public int theAttackDamage;

	// Token: 0x040013DA RID: 5082
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013DA")]
	public float theAttackInterval;

	// Token: 0x040013DB RID: 5083
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40013DB")]
	public int theSun;

	// Token: 0x040013DC RID: 5084
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013DC")]
	public float theCD;

	// Token: 0x040013DD RID: 5085
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013DD")]
	public int theHealth;
}
