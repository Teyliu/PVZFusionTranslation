using System;
using Cpp2IlInjected;

// Token: 0x020004CC RID: 1228
[Token(Token = "0x20004CC")]
public class CoinShroom : SunShroom
{
	// Token: 0x0600172C RID: 5932 RVA: 0x0007F370 File Offset: 0x0007D570
	[Token(Token = "0x600172C")]
	[Address(RVA = "0x50E2D0", Offset = "0x50C8D0", VA = "0x18050E2D0", Slot = "69")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(97, 0.5f, 1f);
		CreateItem instance = CreateItem.Instance;
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x0007F3A0 File Offset: 0x0007D5A0
	[Token(Token = "0x600172D")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "71")]
	protected override void ChangeUpdate()
	{
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
	[Token(Token = "0x600172E")]
	[Address(RVA = "0x50E3B0", Offset = "0x50C9B0", VA = "0x18050E3B0")]
	public CoinShroom()
	{
		this.timer = 150f;
		base..ctor();
	}
}
