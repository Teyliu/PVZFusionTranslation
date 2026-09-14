using System;
using Cpp2IlInjected;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
public abstract class BaseDebuff : BaseBuff<TravelDebuff>
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000AB RID: 171 RVA: 0x000045E8 File Offset: 0x000027E8
	[Token(Token = "0x1700002B")]
	public virtual ZombieType ZombieType
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3E8430", Offset = "0x3E6A30", VA = "0x1803E8430", Slot = "20")]
		get;
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000AC RID: 172 RVA: 0x000045FC File Offset: 0x000027FC
	[Token(Token = "0x1700002C")]
	public virtual int Point
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3EB740", Offset = "0x3E9D40", VA = "0x1803EB740", Slot = "21")]
		get;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00004610 File Offset: 0x00002810
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	protected BaseDebuff()
	{
	}
}
