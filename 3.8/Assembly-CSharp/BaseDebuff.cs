using System;
using Cpp2IlInjected;

// Token: 0x02000021 RID: 33
[Token(Token = "0x2000021")]
public abstract class BaseDebuff : BaseBuff<TravelDebuff>
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000091 RID: 145 RVA: 0x00004274 File Offset: 0x00002474
	[Token(Token = "0x17000025")]
	public virtual ZombieType ZombieType
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x39C420", Offset = "0x39AA20", VA = "0x18039C420", Slot = "20")]
		get;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00004288 File Offset: 0x00002488
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	protected BaseDebuff()
	{
	}
}
