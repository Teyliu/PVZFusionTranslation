using System;
using Cpp2IlInjected;

// Token: 0x0200050E RID: 1294
[Token(Token = "0x200050E")]
public class IceCactus : Cactus
{
	// Token: 0x0600182B RID: 6187 RVA: 0x00083564 File Offset: 0x00081764
	[Token(Token = "0x600182B")]
	[Address(RVA = "0x4CE6C0", Offset = "0x4CCCC0", VA = "0x1804CE6C0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cactus_ice;
	}

	// Token: 0x0600182C RID: 6188 RVA: 0x00083578 File Offset: 0x00081778
	[Token(Token = "0x600182C")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public IceCactus()
	{
	}
}
