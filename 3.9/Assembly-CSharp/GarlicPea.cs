using System;
using Cpp2IlInjected;

// Token: 0x02000523 RID: 1315
[Token(Token = "0x2000523")]
public class GarlicPea : PeaShooter
{
	// Token: 0x06001894 RID: 6292 RVA: 0x000853B4 File Offset: 0x000835B4
	[Token(Token = "0x6001894")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x000853D4 File Offset: 0x000835D4
	[Token(Token = "0x6001895")]
	[Address(RVA = "0x525170", Offset = "0x523770", VA = "0x180525170", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_garlic;
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x000853E8 File Offset: 0x000835E8
	[Token(Token = "0x6001896")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public GarlicPea()
	{
	}
}
