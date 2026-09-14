using System;
using Cpp2IlInjected;

// Token: 0x020004D4 RID: 1236
[Token(Token = "0x20004D4")]
public class CherrySuperGatling : SuperGatling
{
	// Token: 0x06001749 RID: 5961 RVA: 0x0007FF64 File Offset: 0x0007E164
	[Token(Token = "0x6001749")]
	[Address(RVA = "0x49F720", Offset = "0x49DD20", VA = "0x18049F720", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		float timer = this.timer;
		int num = 0;
		num += 178;
		return BulletType.Bullet_pea;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x0007FF90 File Offset: 0x0007E190
	[Token(Token = "0x600174A")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public CherrySuperGatling()
	{
	}
}
