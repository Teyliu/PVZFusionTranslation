using System;
using Cpp2IlInjected;

// Token: 0x0200052E RID: 1326
[Token(Token = "0x200052E")]
public class HelmetGatling : Shooter
{
	// Token: 0x060018C1 RID: 6337 RVA: 0x00086020 File Offset: 0x00084220
	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x5270C0", Offset = "0x5256C0", VA = "0x1805270C0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num != 12)
		{
			return BulletType.Bullet_ironPea;
		}
		this.attributeCount = (int)((ulong)0L);
		return BulletType.Bullet_helmetPea;
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00086058 File Offset: 0x00084258
	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public HelmetGatling()
	{
	}
}
