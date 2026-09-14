using System;
using Cpp2IlInjected;

// Token: 0x0200073C RID: 1852
[Token(Token = "0x200073C")]
[Serializable]
public class CustomPlant
{
	// Token: 0x060025B3 RID: 9651 RVA: 0x000C6B14 File Offset: 0x000C4D14
	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public CustomPlant()
	{
	}

	// Token: 0x04001302 RID: 4866
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001302")]
	public PlantType thePlantType;

	// Token: 0x04001303 RID: 4867
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001303")]
	public int theAttackDamage;

	// Token: 0x04001304 RID: 4868
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001304")]
	public float theAttackInterval;

	// Token: 0x04001305 RID: 4869
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001305")]
	public int theSun;

	// Token: 0x04001306 RID: 4870
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001306")]
	public float theCD;

	// Token: 0x04001307 RID: 4871
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001307")]
	public int theHealth;
}
