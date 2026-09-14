using System;
using Cpp2IlInjected;

// Token: 0x02000525 RID: 1317
[Token(Token = "0x2000525")]
public class GarlicSplit : SplitPea
{
	// Token: 0x06001899 RID: 6297 RVA: 0x00085478 File Offset: 0x00083678
	[Token(Token = "0x6001899")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x00085498 File Offset: 0x00083698
	[Token(Token = "0x600189A")]
	[Address(RVA = "0x525170", Offset = "0x523770", VA = "0x180525170", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_garlic;
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x000854AC File Offset: 0x000836AC
	[Token(Token = "0x600189B")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public GarlicSplit()
	{
	}
}
